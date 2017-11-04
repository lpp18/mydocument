using ApplicationModel;
using ApplicationModel.Models;
using DaKaApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DaKaApp.Controllers
{
    public class DaKaHomeController : Controller
    {
        // GET: DaKaHome
        public string ServiceName = "DaKaHomeController";
        //定义公用的  cookie
        public string UserloginNameCookie()
        {
            //是否为测试环境，0或""为正式环境
            string IsTest = Common.GetAppSetting("IsTest");
            if (IsTest != "1")
            {
                if (Request.Cookies["UserloginNameCookie"] != null)
                {
                    return Request.Cookies["UserloginNameCookie"].Value;
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return Common.GetAppSetting("UserName");
            }
        }

        public string UserPhoneCookie()
        {
            //是否为测试环境，0或""为正式环境
            string IsTest = Common.GetAppSetting("IsTest");
            if (IsTest != "1")
            {
                if (Request.Cookies["UserPhoneCookie"] != null)
                {
                    return Request.Cookies["UserPhoneCookie"].Value;
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return Common.GetAppSetting("Phone");
            }

        }

        //所属企业ID
        public int CompanyId()
        {
            int result = 0;
            List<wx_org_DKruleMX> dt = DB.Context.From<wx_org_DKruleMX>().Where(wx_org_DKruleMX._.Phone == UserPhoneCookie() && wx_org_DKruleMX._.isDelete == 0).ToList();
            result = dt.FirstOrDefault().Company_Key;
            return result;
        }

        //所属企业ID
        public int CompanyIdByUser()
        {
            int result = 0;
            List<wx_org_DKruleMX> dt = DB.Context.From<wx_org_DKruleMX>().Where(wx_org_DKruleMX._.UserLoginName == UserloginNameCookie() && wx_org_DKruleMX._.isDelete == 0).ToList();
            result = dt.FirstOrDefault().Company_Key;
            return result;
        }

        private const double EARTH_RADIUS = 6378137;
        // GET: DaKa/DaKaHome
        public ActionResult Index()
        {
            try
            {
                //根据存储  Cookie查询用户信息
                List<WX_ORG_USER> dts = DB.Context.From<WX_ORG_USER>().Where(WX_ORG_USER._.UserLoginName == UserloginNameCookie()).ToList();
                ViewBag.DaKaName = dts.FirstOrDefault().Name;
            }
            catch (Exception e) {
                ServiceName += "_Index()";
                string LogBody = "---打卡页面运行异常，异常信息:" + e.Message + ",时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
            }
            return View();
        }

        public ActionResult DaKaTest()
        {
            return View();
        }

        public ActionResult DaKaRCS()
        {
            //根据存储  Cookie查询用户信息
            List<wx_org_DKruleMX> dts = DB.Context.From<wx_org_DKruleMX>().Where(wx_org_DKruleMX._.Phone == UserPhoneCookie()).ToList();
            ViewBag.DaKaName = dts.FirstOrDefault().UserName;
            return View();
        }

        //查询用户的打卡记录
        public JsonResult selectDaKaJiLu()
        {
            //获取用户 cookie  
            try
            {
                List<wx_org_cardrecordlist> dts = DB.Context.From<wx_org_cardrecordlist>().
                Where(wx_org_cardrecordlist._.UserLoginName == UserloginNameCookie()
                && wx_org_cardrecordlist._.dakashijian > (DateTime.Now.AddMonths(-3)) && wx_org_cardrecordlist._.isEff == 1).
                OrderByDescending(wx_org_cardrecordlist._.dakashijian).ToList();

                return Json(dts);
            }
            catch (Exception e)
            {
                //WeiXinHelperClass.Log log = new WeiXinHelperClass.Log();
                //log.WriteLogFile("", "获取用户打卡记录报错 时间：" + DateTime.Now + "错误：" + ex.ToString());
                ServiceName += "_selectDaKaJiLu";
                string LogBody = "---获取用户打卡记录报错，异常信息:" + e.Message + ",时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
                return null;
            }
        }

        //打卡操作
        public string DaKa()
        {
            ////WeiXinHelperClass.Log log = new WeiXinHelperClass.Log();
            ////log.WriteLogFile("", "用户" + UserloginNameCookie() + "进行打卡操作,经度：" + Request["jingdu"] + "维度：" + Request["weidu"] + "，时间：" + DateTime.Now);

            ServiceName += "_DaKa()";
            string LogBody = "---用户" + UserloginNameCookie() + "进行打卡操作,经度：" + Request["jingdu"] + "维度：" + Request["weidu"] + "，时间：" + DateTime.Now + "---\r\n";
            Common.WriteLogFile(Common.getLogFile(ServiceName), LogBody);
            try
            {
                string userno = UserloginNameCookie();
                int companyid = 0;
                try
                {
                    companyid = CompanyIdByUser();
                }
                catch (Exception)
                {
                    return "OK:003";
                }

                var time = Request["time"];  //打卡时间
                var jingdu = Convert.ToDouble(Request["jingdu"]);
                var weidu = Convert.ToDouble(Request["weidu"]);
                if (string.IsNullOrEmpty(jingdu.ToString()) || string.IsNullOrEmpty(weidu.ToString()))
                {
                    ////log.WriteLogFile("", "用户" + userno + "打卡未获取到经纬度 时间：" + DateTime.Now);
                    LogBody = "---用户" + UserloginNameCookie() + "打卡未获取到经纬度，时间：" + DateTime.Now + "---\r\n";
                    Common.WriteLogFile(Common.getLogFile(ServiceName), LogBody);
                }
                string address = Request["address"].ToString();
                double Djingdu = 0;
                double Dweidu = 0;
                double MaxJuLi = 0;

                // 查询用户信息
                List<WX_ORG_USER> dts = DB.Context.From<WX_ORG_USER>().Where(WX_ORG_USER._.UserLoginName == userno).ToList();
                wx_org_cardrecordlist card = new wx_org_cardrecordlist();
                card.dakashijian = Convert.ToDateTime(DateTime.Now.ToLongTimeString().ToString()); //打卡时间
                card.dakeriqi = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));   //打卡日期
                card.isdel = 0;    //是否删除
                card.isSync = 0;    //是否同步
                card.latitude = weidu.ToString();  //纬度
                card.longitude = jingdu.ToString();   //精度
                card.userName = dts.FirstOrDefault().Name;  //登录用户名
                card.UserLoginName = dts.FirstOrDefault().UserLoginName;  //登录用户名
                card.userNo = dts.FirstOrDefault().UserNo;   //员工工号
                card.zwAddress = address;   //打卡中文地址
                card.Company_Key = companyid; //所属公司
                card.Phone = dts.FirstOrDefault().Cellphone;

                //根据用户信息查询用户打卡规则中加班表
                List<wx_org_DKruleMX> DKMX = DB.Context.From<wx_org_DKruleMX>().Where(wx_org_DKruleMX._.UserLoginName == userno && wx_org_DKruleMX._.Company_Key == companyid && wx_org_DKruleMX._.isDelete == 0).ToList();
                int isEff = 0;
                //记录特殊地点，地点类型为“无固定地点”，随时打卡
                string newtype = "";
                if (DKMX != null && DKMX.Count > 0)
                {
                    //判断员工是否有特殊类型
                    foreach (var item in DKMX)
                    {
                        //类型为“无固定地点”,随时打卡
                        newtype = item.DKRule.ToString();
                        if (newtype == "0")
                        {
                            card.guizeID = 0;   //规则ID
                            card.xcDistance = "0";   //相差距离
                            card.isEff = 1;
                            card.DaKaRule = 0;
                            isEff = 1;
                            break;
                        }
                    }
                    if (isEff != 1)
                    {
                        foreach (var item in DKMX)
                        {
                            //根据ID  查询考勤规则
                            List<wx_org_DaKaRule> DaKaRuleli = DB.Context.From<wx_org_DaKaRule>().Where(wx_org_DaKaRule._.ID == item.DKRule && wx_org_DaKaRule._.Company_Key == companyid && wx_org_DaKaRule._.isDelete == 0).ToList();
                            if (DaKaRuleli.Count > 0)
                            {
                                Djingdu = Convert.ToDouble(DaKaRuleli.FirstOrDefault().longitude);
                                Dweidu = Convert.ToDouble(DaKaRuleli.FirstOrDefault().latitude);
                                MaxJuLi = Convert.ToDouble(DaKaRuleli.FirstOrDefault().MaxXCJL);
                                double GetDistances = GetDistance(Dweidu, Djingdu, weidu, jingdu);

                                card.guizeID = DaKaRuleli.FirstOrDefault().ID;   //规则ID
                                card.xcDistance = GetDistances.ToString();   //相差距离
                                card.DaKaRule = DaKaRuleli.FirstOrDefault().ID; //打卡地址id

                                if (GetDistances < MaxJuLi)
                                {
                                    card.isEff = 1;
                                    isEff = 1;
                                    card.DaKaRule = DaKaRuleli.FirstOrDefault().ID; //打卡地址id
                                    break;
                                }
                                else
                                {
                                    card.isEff = 0;
                                    isEff = 0;
                                }
                            }
                            else
                            {
                                card.isEff = 0;
                                isEff = 0;
                            }
                        }
                    }
                    int insertcard = DB.Context.Insert<wx_org_cardrecordlist>(card);
                    if (insertcard <= 0)
                    {
                        isEff = 0;
                    }
                }
                else
                {
                    //员工不允许使用打卡功能 likuo
                    isEff = 3;
                }
                if (isEff == 1)
                {
                    return "OK:001";
                }
                if (isEff == 3) //员工不允许使用打卡功能 likuo
                {
                    return "OK:003";
                }
                else
                {
                    return "OK:002";
                }
            }
            catch (Exception ex)
            {
                //log.WriteLogFile("", "用户" + UserloginNameCookie() + "打卡报错,经度：" + Request["jingdu"] + "维度：" + Request["weidu"] + "，时间：" + DateTime.Now + "，错误：" + ex.ToString());
                LogBody = "---用户" + UserloginNameCookie() + "打卡报错,经度：" + Request["jingdu"] + "维度：" + Request["weidu"] + "，时间：" + DateTime.Now + "，错误：" + ex.ToString() + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
                return ex.ToString();
            }
        }

        public JsonResult selectDaKaJiLuRcs()
        {
            //获取用户 cookie  
            try
            {
                string phone = UserPhoneCookie();
                List<wx_org_cardrecordlist> dts = DB.Context.From<wx_org_cardrecordlist>().
                Where(wx_org_cardrecordlist._.Phone == phone
                && wx_org_cardrecordlist._.dakashijian > (DateTime.Now.AddMonths(-3)) && wx_org_cardrecordlist._.isEff == 1).
                OrderByDescending(wx_org_cardrecordlist._.dakashijian).ToList();

                return Json(dts);
            }
            catch (Exception ex)
            {
                //WeiXinHelperClass.Log log = new WeiXinHelperClass.Log();
                //log.WriteLogFile("", "获取用户打卡记录报错 时间：" + DateTime.Now + "错误：" + ex.ToString());

                ServiceName += "_selectDaKaJiLuRcs()";
                string LogBody = "---获取用户打卡记录报错，时间：" + DateTime.Now + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
                return null;
            }
        }

        public string DaKaRcsA()
        {
            //WeiXinHelperClass.Log log = new WeiXinHelperClass.Log();
            //log.WriteLogFile("", "用户" + UserPhoneCookie() + "进行打卡操作,经度：" + Request["jingdu"] + "维度：" + Request["weidu"] + "，时间：" + DateTime.Now);
            ServiceName += "_DaKaRcsA()";
            string LogBody = "---用户" + UserPhoneCookie() + "进行打卡操作,经度：" + Request["jingdu"] + "维度：" + Request["weidu"] + "---\r\n";
            Common.WriteLogFile(Common.getLogFile(ServiceName), LogBody);
            try
            {
                string phone = UserPhoneCookie();
                int cmpid = 0;
                try
                {
                    cmpid = CompanyId();
                }
                catch (Exception)
                {
                    return "OK:003";
                }

                var time = Request["time"];  //打卡时间
                var jingdu = Convert.ToDouble(Request["jingdu"]);
                var weidu = Convert.ToDouble(Request["weidu"]);
                if (string.IsNullOrEmpty(jingdu.ToString()) || string.IsNullOrEmpty(weidu.ToString()))
                {
                    //log.WriteLogFile("", "用户" + phone + "打卡未获取到经纬度 时间：" + DateTime.Now);
                    LogBody = "---用户" + phone + "打卡未获取到经纬度时间：" + DateTime.Now + "---\r\n";
                    Common.WriteLogFile(Common.getLogFile(ServiceName), LogBody);
                }
                string address = Request["address"].ToString();
                double Djingdu = 0;
                double Dweidu = 0;
                double MaxJuLi = 0;

                // 查询用户信息
                List<wx_org_DKruleMX> dts = DB.Context.From<wx_org_DKruleMX>().Where(wx_org_DKruleMX._.Phone == phone && wx_org_DKruleMX._.isDelete == 0 && wx_org_DKruleMX._.Company_Key == cmpid).ToList();
                wx_org_cardrecordlist card = new wx_org_cardrecordlist();
                card.dakashijian = Convert.ToDateTime(DateTime.Now.ToLongTimeString().ToString()); //打卡时间
                card.dakeriqi = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));   //打卡日期
                card.isdel = 0;    //是否删除
                card.isSync = 0;    //是否同步
                card.latitude = weidu.ToString();  //纬度
                card.longitude = jingdu.ToString();   //精度
                card.userName = dts.FirstOrDefault().UserName;  //用户中文名
                card.UserLoginName = dts.FirstOrDefault().UserLoginName;  //登录用户名

                card.userNo = "";   //员工工号
                card.zwAddress = address;   //打卡中文地址
                card.Company_Key = cmpid;  //所属公司
                card.Phone = phone;  //手机号

                //根据用户信息查询用户打卡规则中加班表
                int isEff = 0;
                //记录特殊地点，地点类型为“无固定地点”，随时打卡
                string newtype = "";
                if (dts != null && dts.Count > 0)
                {
                    //判断员工是否有特殊类型
                    foreach (var item in dts)
                    {
                        //类型为“无固定地点”,随时打卡
                        newtype = item.DKRule.ToString();
                        if (newtype == "0")
                        {
                            card.guizeID = 0;   //规则ID
                            card.xcDistance = "0";   //相差距离
                            card.isEff = 1;
                            card.DaKaRule = 0;
                            isEff = 1;
                            break;
                        }
                    }
                    if (isEff != 1)    //不是特殊类型
                    {
                        foreach (var item in dts)
                        {
                            //根据ID  查询考勤规则
                            List<wx_org_DaKaRule> DaKaRuleli = DB.Context.From<wx_org_DaKaRule>().Where(wx_org_DaKaRule._.ID == item.DKRule && wx_org_DaKaRule._.isDelete == 0 && wx_org_DaKaRule._.Company_Key == cmpid).ToList();
                            if (DaKaRuleli.Count > 0)
                            {
                                Djingdu = Convert.ToDouble(DaKaRuleli.FirstOrDefault().longitude);
                                Dweidu = Convert.ToDouble(DaKaRuleli.FirstOrDefault().latitude);
                                MaxJuLi = Convert.ToDouble(DaKaRuleli.FirstOrDefault().MaxXCJL);
                                double GetDistances = GetDistance(Dweidu, Djingdu, weidu, jingdu);

                                card.guizeID = DaKaRuleli.FirstOrDefault().ID;   //规则ID
                                card.xcDistance = GetDistances.ToString();   //相差距离
                                card.DaKaRule = DaKaRuleli.FirstOrDefault().ID; //打卡地址id

                                if (GetDistances < MaxJuLi)
                                {
                                    card.isEff = 1;
                                    isEff = 1;
                                    card.DaKaRule = DaKaRuleli.FirstOrDefault().ID; //打卡地址id
                                    break;
                                }
                                else
                                {
                                    card.isEff = 0;
                                    isEff = 0;
                                }
                            }
                            else
                            {
                                card.isEff = 0;
                                isEff = 0;
                            }
                        }
                    }
                    var insertcard = DB.Context.Insert<wx_org_cardrecordlist>(card);
                    if (insertcard <= 0)
                    {
                        isEff = 0;
                    }
                }
                else
                {
                    //员工不允许使用打卡功能 likuo
                    isEff = 3;
                }
                if (isEff == 1)
                {
                    return "OK:001";
                }
                else if (isEff == 3) //员工不允许使用打卡功能 likuo
                {
                    return "OK:003";
                }
                else
                {
                    return "OK:002";
                }
            }
            catch (Exception ex)
            {
                //log.WriteLogFile("", "用户" + UserPhoneCookie() + "打卡报错,经度：" + Request["jingdu"] + "维度：" + Request["weidu"] + "，时间：" + DateTime.Now + "，错误：" + ex.ToString());
                LogBody = "---用户" + UserPhoneCookie() + "打卡报错,经度：" + Request["jingdu"] + "维度：" + Request["weidu"] + "，时间：" + DateTime.Now + "，错误：" + ex.ToString() + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
                return ex.ToString();
            }
        }

        public void AddLog()
        {
            //WeiXinHelperClass.Log log = new WeiXinHelperClass.Log();
            //log.WriteLogFile("", "用户" + UserPhoneCookie() + "进行打卡操作，此操作为点击了按钮");

            string LogBody = "---用户" + UserPhoneCookie() + "进行打卡操作，此操作为点击了按钮，时间：" + DateTime.Now + "---\r\n";
            Common.WriteLogFile(Common.getLogFile(ServiceName), LogBody);
        }

        /// <summary>
        /// 计算 两点之间的距离
        /// </summary>
        /// <param name="lat1"></param>
        /// <param name="lng1"></param>
        /// <param name="lat2"></param>
        /// <param name="lng2"></param>
        /// <returns></returns>
        public static double GetDistance(double lat1, double lng1, double lat2, double lng2)
        {
            double radLat1 = Rad(lat1);
            double radLng1 = Rad(lng1);
            double radLat2 = Rad(lat2);
            double radLng2 = Rad(lng2);
            double a = radLat1 - radLat2;
            double b = radLng1 - radLng2;
            double result = 2 * Math.Asin(Math.Sqrt(Math.Pow(Math.Sin(a / 2), 2) + Math.Cos(radLat1) * Math.Cos(radLat2) * Math.Pow(Math.Sin(b / 2), 2))) * EARTH_RADIUS;
            return result;
        }

        private static double Rad(double d)
        {
            return (double)d * Math.PI / 180d;
        }


        /// 通过GET方式发送数据
        /// url
        /// GET数据
        /// GET容器
        public string SendDataByGET(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);

            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }

        //google 坐标转百度链接 //http://api.map.baidu.com/ag/coord/convert?from=2&to=4&x=116.32715863448607&y=39.990912172420714&callback=BMap.Convertor.cbk_3694
        //gps坐标的type=0
        //google坐标的type=2
        //baidu坐标的type=4
        public string change(string xy)
        {
            string result = "";
            try
            {
                //转换前的GPS坐标
                //double x = 116.286792;
                //double y = 39.817852;
                double x = 0;
                double y = 0;
                try
                {
                    string[] xys = xy.Split(',');
                    x = Convert.ToDouble(xys[0]);
                    y = Convert.ToDouble(xys[1]);
                }
                catch (Exception)
                {
                }
                String path = "http://api.map.baidu.com/ag/coord/convert?from=0&to=4&x=" + x + "+&y=" + y + "&callback=BMap.Convertor.cbk_7594";
                string res = SendDataByGET(path);
                if (res.IndexOf("(") > 0 && res.IndexOf(")") > 0)
                {
                    int sint = res.IndexOf("(") + 1;
                    int eint = res.IndexOf(")");
                    int ls = res.Length;
                    String str = res.Substring(sint, eint - sint);
                    int errint = res.IndexOf("error") + 7;
                    int enderr = res.IndexOf("error") + 8;
                    String err = res.Substring(errint, 1);
                    if ("0".Equals(err))
                    {
                        int sx = str.IndexOf(",\"x\":\"") + 6;
                        int sy = str.IndexOf("\",\"y\":\"");
                        int endy = str.IndexOf("\"}");
                        int sl = str.Length;
                        string xp = str.Substring(sx, sy - sx);
                        string yp = str.Substring(sy + 7, endy - sy - 7);
                        byte[] outputb = Convert.FromBase64String(xp);
                        string XStr = Encoding.Default.GetString(outputb);
                        outputb = Convert.FromBase64String(yp);
                        string YStr = Encoding.Default.GetString(outputb);
                        result = XStr + "," + YStr;
                    }
                }
            }
            catch (Exception ex)
            {
                //WeiXinHelperClass.Log log = new WeiXinHelperClass.Log();
                //log.WriteLogFile("", "GPS坐标转换为百度坐标 时间：" + DateTime.Now + "错误：" + ex.ToString());
                ServiceName += "_change()";
                string LogBody = "---GPS坐标转换为百度坐标 时间：" + DateTime.Now + "错误：" + ex.ToString() + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
                result = "";
            }
            return result;
        }


        public ActionResult DaKaRCSTwo()
        {
            //根据存储  Cookie查询用户信息
            List<wx_org_DKruleMX> dts = DB.Context.From<wx_org_DKruleMX>().Where(wx_org_DKruleMX._.Phone == UserPhoneCookie()).ToList();
            ViewBag.DaKaName = dts.FirstOrDefault().UserName;
            return View();
        }

        #region 导入打卡规则数据
        /// <summary>
        /// 导入打卡规则数据
        /// </summary>
        /// <returns></returns>
        public ActionResult DaKaRuleOperation()
        {
            return View();
        }
        public JsonResult ImportDaKaRule()
        {
            Common.ReturnMsg rm = new Common.ReturnMsg();
            int Result = 0;
            try
            {
                HttpFileCollectionBase files = Request.Files;
                HttpPostedFileBase file = files[0];
                string fileName = file.FileName;
                string FileType = fileName.Substring(fileName.LastIndexOf(".") + 1); //得到文件的后缀名
                fileName = fileName.Substring(0, fileName.LastIndexOf(".")) + DateTime.Now.ToString("yyyyMMddHHssMM") + "." + FileType;
                string filePath = Server.MapPath("~/UploadFiles/ImportDaKaRule/");
                DirectoryInfo dir = new DirectoryInfo(filePath);
                if (!dir.Exists)
                {
                    dir.Create();
                }
                filePath += fileName;
                file.SaveAs(filePath);
                DataTable dt = Excel.ExcelToDataTable(filePath, "Sheet1", true);
                int count = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    Result = DB.Context.FromProc("proc_AddDakaRuleData")
                    .AddInParameter("UserName", DbType.String, dr[0])
                    .AddInParameter("UserLoginName", DbType.String, dr[1])
                    .AddInParameter("Phone", DbType.String, dr[2])
                    .AddInParameter("Address", DbType.String, dr[3])
                    .AddInParameter("Longitude", DbType.String, dr[4])
                    .AddInParameter("Latitude", DbType.String, dr[5])
                    .AddInParameter("DakaRang", DbType.String, dr[6])
                    .AddInParameter("Company_Key", DbType.Int32,Convert.ToInt32(dr[7]))
                    .ExecuteNonQuery();
                    count++;
                }
                rm.Success = Result > 0 ? true : false;
                rm.Message = Result > 0 ? "导入数据成功！" : "数据导入失败，请稍后重试！";
                //写入日志
                ServiceName += "_RImportDaKaRule()";
                string LogBody = "---打卡规则数据导入成功，行数："+count+",时间：" + DateTime.Now + "---\r\n";
                Common.WriteLogFile(Common.getLogFile(ServiceName), LogBody);
            }
            catch (Exception e)
            {
                rm.Success = false;
                rm.Message = "服务器出现错误，请稍后刷新页面或重新导入，错误信息:" + e.Message;
                ServiceName += "_RImportDaKaRule()";
                string LogBody = "---打卡规则数据导入错误，异常信息：" + e.Message + "，时间：" + DateTime.Now + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
            }
            return Json(rm);
        }
        #endregion

        /// <summary>
        /// java和飞信对接C#微信H5接口
        /// </summary> 
        /// <returns></returns>
        public ActionResult RCSLogin() {
            try
            {
                var guid = Request["guid"];
                var VisitType = Request["VisitType"];
                if (guid != null && guid != "")
                {
                    //根据GUID查询值
                    List<JavaAndNetLogin> JavaAndNetLogins = DB.Context.From<JavaAndNetLogin>().Where(JavaAndNetLogin._.ID == guid).ToList();
                    if (JavaAndNetLogins.Count() == 0)
                    {
                        ViewBag.ReturnValue = "授权登陆失败";
                        return View();
                    }
                    else
                    {
                        //根据查询到的电话号码查询用户表
                        List<wx_org_DKruleMX> listuser = DB.Context.From<wx_org_DKruleMX>().Where(wx_org_DKruleMX._.Phone == JavaAndNetLogins.FirstOrDefault().Phone).ToList();
                        if (listuser.Count() == 0)
                        {
                            ViewBag.ReturnValue = "你没有权限，请联系管理员";
                            return View();
                        }
                        else
                        {
                            //把获取到的用户信息插入到cookice中
                            HttpCookie cookie = new HttpCookie("UserPhoneCookie");
                            cookie.Value = listuser.FirstOrDefault().Phone;
                            cookie.Expires = DateTime.Now.AddDays(14);
                            Response.Cookies.Add(cookie);
                            //根据获取到的 GUID 删除
                            int JavaAndNetLoginDelete = DB.Context.Delete<JavaAndNetLogin>(JavaAndNetLogin._.ID == guid);
                            //操作成功后进行页面跳转
                            if  (VisitType == "T")
                            {
                                return RedirectToAction("../DaKaHome/DaKaRCS");  //和飞信打开页面跳转
                            }
                            return View();
                        }
                    }
                }
                else
                {
                    ViewBag.ReturnValue = "guid等于空";
                    return View();
                }
            }
            catch (Exception e)
            {
                ServiceName += "_RCSLogin()";
                string LogBody = "---打卡鉴权出现错误，异常信息："+e.Message+"，时间：" + DateTime.Now + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
                ViewBag.ReturnValue = e.ToString();
                return View();
                throw;
            }
        }
    }
}