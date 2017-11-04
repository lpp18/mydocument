using ApplicationModel;
using ApplicationModel.Models;
using RCSApplication.Models;
using ReceiptApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RCSApplication.Controllers
{
    public class ReceiptHomeController : Controller
    {
        // GET: Receipt/Home
        //服务名称
        string ServiceName = "ReceiptHomeController";
        ApplicationModel.Models.Common.ReturnMsg rm = new ApplicationModel.Models.Common.ReturnMsg();
        /// <summary>
        /// 发票列表
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.IsSupperAdmin = IsSupperAdmin();
            return View();
        }
        /// <summary>
        /// 发票详情
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult ReceiptDetails(string id)
        {
            receiptinfo receipt = new receiptinfo();
            if (id != "")
            {
                receipt = QueryReceipt(id);
            }
            ViewBag.IsSupperAdmin = IsSupperAdmin();
            if (!IsSupperAdmin())
            {
                return Redirect("../ReceiptHome/Share?id=" + receipt.id);
            }
            return View(receipt);
        }
        /// <summary>
        /// 分享
        /// </summary>
        /// <returns></returns>
        public ActionResult Share(string id)
        {
            receiptinfo receipt = new receiptinfo();
            if (id != "")
            {
                receipt = QueryReceipt(id);
                return View(receipt);
            }
            return View();
        }
        /// <summary>
        /// 发票新增
        /// </summary>
        /// <returns></returns>
        public ActionResult AddReceipt()
        {
            //非管理员，跳转index页面
            if (!IsSupperAdmin())
            {
                ViewBag.IsSupperAdmin = IsSupperAdmin();
                return Redirect("../ReceiptHome/index");
            }
            HttpContext.Session["RandomNum"] = Guid.NewGuid().ToString() + DateTime.Now.ToString();
            return View();
        }
        /// <summary>
        /// 跳转页面，此方法暂不使用
        /// </summary>
        /// <param name="RandomNum"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult SkipPage(string RandomNum, string id)
        {
            if (HttpContext.Session["RandomNum"] == null)
            {
                return ReceiptDetails(id);
            }
            else if (HttpContext.Session["RandomNum"] != null && HttpContext.Session["RandomNum"].ToString() == "FED477CF-2037-47D1-BCE9-2D70C7D82B49")
            {
                return Redirect("../ReceiptHome/Share?id=" + id);
            }
            return null;
        }
        /// <summary>
        /// 清空session，ajax调用,此方法暂不使用
        /// </summary>
        public void ClearSession()
        {
            HttpContext.Session.Remove("RandomNum");
        }
        /// <summary>
        /// 此方法暂不使用
        /// </summary>
        public void WriteSession()
        {
            HttpContext.Session["RandomNum"] = "FED477CF-2037-47D1-BCE9-2D70C7D82B49";
        }
        /// <summary>
        /// 获取发票信息列表,ajax请求使用
        /// </summary>
        /// <returns></returns>
        public JsonResult GetReceiptList()
        {
            List<receiptinfo> receiptList = new List<receiptinfo>();
            try
            {
                receiptList = DB.Context.From<receiptinfo>().Where(receiptinfo._.IsDelete == 0).ToList();
            }
            catch (Exception e)
            {
                rm.Success = false;
                rm.Message = "查询信息出错,刷新界面后重试!";
                rm.error = e.Message;
                ServiceName = "GetReceiptList";
                string LogBody = "---执行服务出现错误，异常信息:" + e.Message + ",时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
                return Json(rm);
            }
            return Json(receiptList);
        }

        /// <summary>
        /// 删除发票信息
        /// </summary>
        /// <param name="id">发票id</param>
        /// <returns></returns>
        public JsonResult DelReceipt(string id)
        {
            try
            {
                receiptinfo receip = new receiptinfo();
                receip.id = id != "" ? Convert.ToInt32(id) : 0;
                receip.IsDelete = 1;
                //执行受影响行数
                int RowCount = 0;
                RowCount = DB.Context.Update<receiptinfo>(receip);
                if (RowCount > 0)
                {
                    rm.Success = true;
                    rm.Message = "发票删除成功!";
                }
                else
                {
                    rm.Success = false;
                    rm.Message = "发票删除失败,刷新界面后重试!";
                }
            }
            catch (Exception e)
            {
                rm.Success = false;
                rm.Message = "服务器处理出错,刷新界面后重试!";
                rm.error = e.Message;
                //写入异常日志
                ServiceName = "DelReceipt";
                string LogBody = "---执行服务出现错误，异常信息:" + e.Message + ",删除id:" + id + ",时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
            }
            return Json(rm);
        }
        /// <summary>
        /// 添加发票信息
        /// </summary>
        /// <param name="Receipt"></param>
        /// <returns></returns>
        public JsonResult AddReceiptInfo(receiptinfo Receipt)
        {
            try
            {
                //string QRCodePath = CreateReceiptQRCode(Receipt);
                //Receipt.QRCode = QRCodePath!=""? QRCodePath : "";
                //发票编号
                int id = 0;
                Receipt.Creator = GetUserName();
                id = DB.Context.Insert<receiptinfo>(Receipt);
                if (id > 0)
                {
                    //生成发票地址二维码
                    string ReceiptQRCode = new QRCode().CreateQRCode(Common.GetAppSetting("ServerDomain") + "/Receipt/ReceiptHome/Share?id=" + id, 20);
                    Task.Factory.StartNew(() =>
                    {
                        CreateReceipeInfoAddressQRCode(id, ReceiptQRCode);
                    });
                    rm.Success = true;
                    rm.Message = ReceiptQRCode;
                }
                else
                {
                    rm.Success = false;
                    rm.Message = "发票添加失败,请刷新界面后重试!";
                }
            }
            catch (Exception e)
            {
                rm.Success = false;
                rm.Message = "服务器处理出错，请刷新界面后重试!";
                rm.error = e.Message;
                //写入异常日志
                ServiceName = "AddReceipt";
                string LogBody = "---执行服务出现错误，异常信息:" + e.Message + ",时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
                return Json(rm);
            }
            return Json(rm);
        }
        /// <summary>
        /// 添加根据发票详细信息页地址生成的二维码信息
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ReceiptQRCode"></param>
        private void CreateReceipeInfoAddressQRCode(int id, string ReceiptQRCode)
        {
            DB.Context.Update<receiptinfo>(receiptinfo._.QRCode, ReceiptQRCode, receiptinfo._.id == id);
        }

        /// <summary>
        /// 更新发票信息
        /// </summary>
        /// <param name="Receipt"></param>
        /// <returns></returns>
        public JsonResult UpdateReceipt(receiptinfo Receipt)
        {
            try
            {
                if (Receipt != null && Receipt.id != 0)
                {
                    //执行受影响行数
                    int RowCount = 0;
                    Receipt.LastUpdateTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    RowCount = DB.Context.Update<receiptinfo>(Receipt);
                    if (RowCount > 0)
                    {
                        rm.Success = true;
                        rm.Message = "发票信息修改成功!";
                    }
                    else
                    {
                        rm.Success = false;
                        rm.Message = "发票信息修改失败,请退出界面稍后重试!";
                    }
                }
                else
                {
                    rm.Success = false;
                    rm.Message = "发票信息修改失败,参数id为空，请退出界面稍后重试!";
                }
            }
            catch (Exception e)
            {
                rm.Success = false;
                rm.Message = "服务器处理出错，请退出界面稍后重试!";
                rm.error = e.Message;
                //写入异常日志
                ServiceName = "UpdateReceipt";
                string LogBody = "---执行服务出现错误，异常信息:" + e.Message + ",更新参数id:" + Receipt.id + ",时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
            }
            return Json(rm);
        }


        /// <summary>
        /// 查询发票信息根据发票id
        /// </summary>
        /// <param name="id">根据id查询</param>
        /// <returns></returns>
        public receiptinfo QueryReceipt(string id)
        {
            List<receiptinfo> receiptList = new List<receiptinfo>();
            try
            {
                if (id != null && id != "")
                {
                    receiptList = DB.Context.From<receiptinfo>().Where(receiptinfo._.id == Convert.ToInt32(id)).ToList();

                }
            }
            catch (Exception e)
            {
                rm.Success = false;
                rm.Message = "查询发票信息错误，请刷新后重试！";
                rm.error = e.Message;
                //写入日志
                ServiceName = "ReceiptDetails_QueryReceiptById";
                string LogBody = "---执行服务出现错误，异常信息:" + e.Message + ",查询参数 Id:" + id + ",时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
                return null;
            }
            if (receiptList.Count > 0)
            {
                return receiptList[0];
            }
            return null;
        }
        /// <summary>
        /// 生成发票二维码,字符串类型，根据需求，暂不使用此方法
        /// </summary>
        /// <param name="Receipt"></param>
        /// <returns></returns>
        public string CreateReceiptQRCode(receiptinfo Receipt)
        {
            string QRCodePath = "";
            if (Receipt != null)
            {
                string Sign = "</>";
                string QRCodeContent = "$01";
                string CRC = Receipt.CompanyName + Sign + Receipt.DutyParagraph + Sign + Receipt.Address + Sign + Receipt.Tel + Sign + Receipt.BankOfDeposit + Sign + Receipt.BankAccount + Sign;
                Base64 base64 = new Base64();
                string Base64Str = base64.Encode(CRC + CRC_16.getCrc16Code(CRC));
                QRCodeContent += Base64Str + "$";
                QRCodeContent += CRC + CRC_16.getCrc16Code(CRC) + "$";
                QRCodePath = new QRCode().CreateQRCode(QRCodeContent, 20);
            }
            return QRCodePath;
        }
        /// <summary>
        /// 获取用户权限，ajax请求使用
        /// </summary>
        /// <returns></returns>
        public JsonResult GetUserPower()
        {

            try
            {
                List<users> list = DB.Context.From<users>().Where(users._.UserLoginName == UserloginNameCookie() && users._.IsDelete == 0).ToList();
                if (list.Count > 0)
                {
                    rm.Success = true;
                    rm.Message = "1";
                }
                else
                {
                    rm.Success = false;
                    rm.Message = "";
                }
            }
            catch (Exception e)
            {
                rm.Success = false;
                rm.Message = "";
                rm.error = e.Message;
                //写入异常日志
                ServiceName = "GetUserPower";
                string LogBody = "---执行服务出现错误，异常信息:" + e.Message + ",时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
            }
            return Json(rm);
        }
        /// <summary>
        /// 是否为管理员
        /// </summary>
        /// <returns></returns>
        public bool IsSupperAdmin()
        {
            bool Result = false;
            try
            {
                List<users> list = DB.Context.From<users>().Where(users._.UserLoginName == UserloginNameCookie() && users._.IsDelete == 0).ToList();
                if (list.Count > 0)
                {
                    Result = true;
                }
                else
                {
                    Result = false;
                }
            }
            catch (Exception e)
            {
                Result = false;
                //写入异常日志
                ServiceName = "IsSupperAdmin";
                string LogBody = "---执行服务出现错误，异常信息:" + e.Message + ",时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
            }
            return Result;
        }
        /// <summary>
        /// 定义公用的  cookie
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// 获取用户中文名
        /// </summary>
        /// <returns></returns>
        public string GetUserName()
        {
            List<WX_ORG_USER> list = DB.Context.From<WX_ORG_USER>().Where(WX_ORG_USER._.UserLoginName == UserloginNameCookie()).ToList();
            return list.Count > 0 ? list[0].Name : "";
        }

        /// <summary>
        /// java和飞信对接C#微信H5接口
        /// </summary>    guid
        /// <returns></returns>
        public ActionResult RcsLogin()
        {
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
                        List<WX_ORG_USER> listuser = selectuserS1(JavaAndNetLogins.FirstOrDefault().Phone);
                        if (listuser.Count() == 0)
                        {
                            ViewBag.ReturnValue = "你没有权限，请联系管理员";
                            return View();
                        }
                        else
                        {
                            //把获取到的用户信息插入到cookice中
                            HttpCookie cookie = new HttpCookie("UserloginNameCookie");
                            cookie.Value = listuser.FirstOrDefault().UserLoginName;
                            cookie.Expires = DateTime.Now.AddDays(14);
                            Response.Cookies.Add(cookie);
                            //根据获取到的 GUID 删除
                            int JavaAndNetLoginDelete = DB.Context.Delete<JavaAndNetLogin>(JavaAndNetLogin._.ID == guid);
                            //操作成功后进行页面跳转
                             if (VisitType == "FP")
                            {
                                return RedirectToAction("../ReceiptHome/index");  //发票信息
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
                //写入异常日志
                ServiceName = "_RcsLogin";
                string LogBody = "---执行服务出现错误，异常信息:" + e.Message + ",时间:" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
                ViewBag.ReturnValue = e.ToString();
                return View();
                throw;
            }
        }
        /// <summary>
        /// 根据用户输入的手机号查询相应的用户数据
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <returns></returns>
        public static List<WX_ORG_USER> selectuserS1(string phone)
        {
            try
            {
                List<WX_ORG_USER> dts = DB.Context.From<WX_ORG_USER>().Where(WX_ORG_USER._.Cellphone == phone
                    && WX_ORG_USER._.UserLoginName != "zuoyuanyuan1"
                    && WX_ORG_USER._.UserLoginName != "lijianghua1"
                    && WX_ORG_USER._.UserLoginName != "yangrongqing1"
                    && WX_ORG_USER._.UserLoginName != "zhangxiaoming1"
                    && WX_ORG_USER._.UserLoginName != "bbs"
                    && WX_ORG_USER._.UserLoginName != "liling1"
                    && WX_ORG_USER._.UserLoginName != "tuzhisen1"
                    && WX_ORG_USER._.UserLoginName != "liuchunming1"
                    && WX_ORG_USER._.UserLoginName != "yangdapeng1"
                    ).ToList();
                return dts;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}