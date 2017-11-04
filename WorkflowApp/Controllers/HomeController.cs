﻿using ApplicationModel;
using ApplicationModel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkflowApp.Models;
using WorkflowApp.SvcWorkflowMWF;
using WorkflowApp.Models;

namespace WorkflowApp.Controllers
{
    public class HomeController : Controller
    {
        public string ServiceName = "WorkflowController";
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
        #region
        // GET: Workflow/Home
        public ActionResult index()
        {
            return View();
        }

        public ActionResult Goout()
        {
            return View();
        }


        public ActionResult bumphdetails()
        {
            return View();
        }

        public ActionResult GWQBTuiHui()
        {
            return View();
        }

        public ActionResult invoice()
        {
            return View();
        }

        public ActionResult seal()
        {
            return View();
        }


        public ActionResult Reimbursement()
        {
            return View();
        }

        public ActionResult SendMessage()
        {
            return View();
        }

        public ActionResult AttachmentUpdateUrl()
        {
            return View();
        }

        public ActionResult GWQBtransaction()
        {
            return View();
        }


        public ActionResult dayOff()
        {
            return View();
        }


        public ActionResult Checkwork()
        {
            return View();
        }


        public ActionResult BusinessCard()
        {
            return View();
        }

        public ActionResult overtime()
        {
            return View();
        }

        public ActionResult AbusinessTravel()
        {
            return View();
        }

        public ActionResult GHHDSQ()
        {
            return View();
        }

        public ActionResult JPBG()
        {
            return View();
        }

        public ActionResult TXKQ()
        {
            return View();
        }

        public ActionResult WBBG()
        {
            return View();
        }

        public ActionResult WBDC()
        {
            return View();
        }

        public ActionResult WBLC()
        {
            return View();
        }

        public ActionResult Meeting()
        {
            return View();
        }

        public ActionResult JobCard()
        {
            return View();
        }

        public ActionResult Train()
        {
            return View();
        }
        /// <summary>
        /// 合同评审
        /// </summary>
        /// <returns></returns>
        public ActionResult ContractReview()
        {
            return View();
        }
        /// <summary>
        /// 采购请购
        /// </summary>
        /// <returns></returns>
        public ActionResult Purchase()
        {
            return View();
        }
        /// <summary>
        /// 薪酬
        /// </summary>
        /// <returns></returns>
        public ActionResult Remuneration()
        {
            return View();
        }
        /// <summary>
        /// 员工变动
        /// </summary>
        /// <returns></returns>
        public ActionResult EmployeeTurnOver()
        {
            return View();
        }
        /// <summary>
        /// 员工离职
        /// </summary>
        /// <returns></returns>
        public ActionResult EmployeeLeave()
        {
            return View();
        }
        /// <summary>
        /// 员工入职
        /// </summary>
        /// <returns></returns>
        public ActionResult EmployeeEntry()
        {
            return View();
        }
        /// <summary>
        /// 员工转正
        /// </summary>
        /// <returns></returns>
        public ActionResult EmployeeRegular()
        {
            return View();
        }
        /// <summary>
        /// 招聘需求申请
        /// </summary>
        /// <returns></returns>
        public ActionResult RecruitmentRequirements()
        {
            return View();
        }
        /// <summary>
        /// 卓学平台资源申请
        /// </summary>
        /// <returns></returns>
        public ActionResult ZhuoXuePingTaiResource()
        {
            return View();
        }
        /// <summary>
        /// 领导信息评审
        /// </summary>
        /// <returns></returns>
        public ActionResult LeadInformationReview()
        {
            return View();
        }
        /// <summary>
        /// 租车申请
        /// </summary>
        /// <returns></returns>
        public ActionResult RentCar()
        {
            return View();
        }
        /// <summary>
        /// 方案决策
        /// </summary>
        /// <returns></returns>
        public ActionResult FAJZ()
        {
            return View();
        }
        /// <summary>
        /// 结果确认
        /// </summary>
        /// <returns></returns>
        public ActionResult JGQR()
        {
            return View();
        }
        /// <summary>
        /// 内容发布
        /// </summary>
        /// <returns></returns>
        public ActionResult NRFB()
        {
            return View();
        }
        /// <summary>
        /// 公司用车
        /// </summary>
        /// <returns></returns>
        public ActionResult GSYC()
        {
            return View();
        }
        /// <summary>
        /// 通知发布
        /// </summary>
        /// <returns></returns>
        public ActionResult TZFB()
        {
            return View();
        }
        /// <summary>
        /// 因公出国
        /// </summary>
        /// <returns></returns>
        public ActionResult YGCG()
        {
            return View();
        }
        /// <summary>
        /// 虚拟结算
        /// </summary>
        /// <returns></returns>
        public ActionResult XNJS()
        {
            return View();
        }
        /// <summary>
        /// 劳动合同
        /// </summary>
        /// <returns></returns>
        public ActionResult LDHT()
        {
            return View();
        }

        /// <summary>
        /// 办公用品
        /// </summary>
        /// <returns></returns>
        public ActionResult BGYP()
        {
            return View();
        }
        /// <summary>
        /// 网络资源
        /// </summary>
        /// <returns></returns>
        public ActionResult WLZY()
        {
            return View();
        }
        /// <summary>
        /// 报备收入
        /// </summary>
        /// <returns></returns>
        public ActionResult BBSR()
        {
            return View();
        }
        /// <summary>
        /// 报备支出
        /// </summary>
        /// <returns></returns>
        public ActionResult BBZC()
        {
            return View();
        }
        /// <summary>
        /// 报备非收支
        /// </summary>
        /// <returns></returns>
        public ActionResult BBFSZ()
        {
            return View();
        }

        /// <summary>
        /// 采购预审
        /// </summary>
        /// <returns></returns>
        public ActionResult CGYS()
        {
            return View();
        }

        /// <summary>
        /// 已处理待办页面
        /// </summary>
        /// <returns></returns>
        public ActionResult DocumentProcessed()
        {
            return View();
        }
        /// <summary>
        /// 普通待办详细页
        /// </summary>
        /// <returns></returns>
        public ActionResult DBDetails()
        {
            return View();
        }
        /// <summary>
        /// 公文详情页
        /// </summary>
        /// <returns></returns>
        public ActionResult DocumentDetails()
        {
            return View();
        }
        /// <summary>
        /// 公文待阅
        /// </summary>
        /// <returns></returns>
        public ActionResult DocumentToRead()
        {
            return View();
        }
        /// <summary>
        /// 公文回退
        /// </summary>
        /// <returns></returns>
        public ActionResult DocumentReturn()
        {
            return View();
        }
        #endregion
        //1、根据单号查询一条待办数据
        public JsonResult select_bumphdetails()
        {
            var billNo = Request["billNo"];
            var count = DB.Context.From<wx_org_process>()
                .Where(d => d.BillNo == billNo && d.Approvers == UserloginNameCookie())
                .ToList();
            return Json(count);
        }

        //public JsonResult selectt_processnew(int page, int count)
        //{
        //    var processlist = DB.Context.From<wx_org_process>()
        //        .Where(d => d.Approvers == UserloginNameCookie() && d.BillTitle != "" && d.Status == false &&
        //        (d.ModelId == "97028"      //公文
        //        || d.ModelId == "38926"    //发票
        //        || d.ModelId == "7281"     //报销
        //        || d.ModelId == "332373"   //印章
        //        || d.ModelId == "7559"     //请假
        //        || d.ModelId == "440370"   //公文
        //        || d.ModelId == "233206"   //公文
        //        || d.ModelId == "183443"   //外出
        //        || d.ModelId == "181382"   //考勤
        //        || d.ModelId == "7575"     //名片
        //        || d.ModelId == "440871"   //公文
        //        || d.ModelId == "440839"   //公文
        //        || d.ModelId == "261242"   //公文
        //        || d.ModelId == "237386"   //公文
        //        || d.ModelId == "216219"   //公文
        //        || d.ModelId == "183445"   //加班
        //        || d.ModelId == "7573"   //出差申请
        //        || d.ModelId == "184002"   //工卡申请
        //        || d.ModelId == "374334"   //会议申请
        //        || d.ModelId == "22283"   //培训申请
        //        || d.ModelId == "164584"  //工会活动申请
        //        || d.ModelId == "35876"   //机票变更
        //        || d.ModelId == "364244"   //弹性考勤
        //        || d.ModelId == "343373"   //外包变更
        //        || d.ModelId == "239336"   //外包到场
        //        || d.ModelId == "243670"   //外包离场
        //        || d.ModelId == "163755"   //合同评审
        //        || d.ModelId == "266961"   //采购请购
        //        || d.ModelId == "181943"   //薪酬
        //        || d.ModelId == "9597"   //员工变动
        //        || d.ModelId == "10788"   //员工离职
        //        || d.ModelId == "10767"   //员工入职
        //        || d.ModelId == "41556"   //员工转正
        //        || d.ModelId == "181603"   //招聘需求申请
        //        || d.ModelId == "411557"   //卓学平台资源申请
        //        || d.ModelId == "181943"   //薪酬
        //        || d.ModelId == "270494"   //方案决策
        //        || d.ModelId == "270497"   //结果确认
        //        || d.ModelId == "181846"   //内容发布
        //        || d.ModelId == "19788"   //公司用车
        //        || d.ModelId == "326448"   //通知发布
        //        || d.ModelId == "11058"   //因公出国
        //        || d.ModelId == "205944"   //领导信息评审
        //        || d.ModelId == "37931"   //租车申请
        //        || d.ModelId == "62487"   //虚拟结算
        //        || d.ModelId == "27195"   //劳动合同
        //        || d.ModelId == "23966"   //采购预审
        //        || d.ModelId == "7542"   //办公用品
        //        || d.ModelId == "129472"   //网络资源
        //        || d.ModelId == "661089"   //报备收入
        //        || d.ModelId == "661091"   //报备支出
        //        || d.ModelId == "661086"   //报备非收支
        //        ) && d.IsTips != true && !d.ProcessData.Contains("申请人出差返回")).Union(DB.Context.From<wx_org_process_ucml>().Where(d => d.Approvers == UserloginNameCookie() && d.Status == false))
        //        .OrderBy(wx_org_process._.BillTime.Asc)
        //        .Page(count, page)
        //        .ToList();
        //    return Json(processlist);
        //}
        
        /// <summary>
        /// 2、查询待办数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public JsonResult WorkflowProcess(int page, int count)
        {
            List<wx_org_process> processlist = DB.Context.From<wx_org_process>()
                .Where(d => d.Approvers == UserloginNameCookie() && d.BillTitle != "" && d.Status == false
                && (
                   d.ModelId == "38926"    //发票
                || d.ModelId == "7281"     //报销
                || d.ModelId == "332373"   //印章
                || d.ModelId == "7559"     //请假
                || d.ModelId == "183443"   //外出
                || d.ModelId == "181382"   //考勤
                || d.ModelId == "7575"     //名片
                || d.ModelId == "183445"   //加班
                || d.ModelId == "7573"   //出差申请
                || d.ModelId == "184002"   //工卡申请
                || d.ModelId == "374334"   //会议申请
                || d.ModelId == "22283"   //培训申请
                || d.ModelId == "164584"  //工会活动申请
                || d.ModelId == "35876"   //机票变更
                || d.ModelId == "364244"   //弹性考勤
                || d.ModelId == "343373"   //外包变更
                || d.ModelId == "239336"   //外包到场
                || d.ModelId == "243670"   //外包离场
                || d.ModelId == "163755"   //合同评审
                || d.ModelId == "266961"   //采购请购
                || d.ModelId == "181943"   //薪酬
                || d.ModelId == "9597"   //员工变动
                || d.ModelId == "10788"   //员工离职
                || d.ModelId == "10767"   //员工入职
                || d.ModelId == "41556"   //员工转正
                || d.ModelId == "181603"   //招聘需求申请
                || d.ModelId == "411557"   //卓学平台资源申请
                || d.ModelId == "270494"   //方案决策
                || d.ModelId == "270497"   //结果确认
                || d.ModelId == "181846"   //内容发布
                || d.ModelId == "19788"   //公司用车
                || d.ModelId == "326448"   //通知发布
                || d.ModelId == "11058"   //因公出国
                || d.ModelId == "205944"   //领导信息评审
                || d.ModelId == "37931"   //租车申请
                || d.ModelId == "62487"   //虚拟结算
                || d.ModelId == "27195"   //劳动合同
                || d.ModelId == "23966"   //采购预审
                || d.ModelId == "7542"   //办公用品
                || d.ModelId == "129472"   //网络资源
                || d.ModelId == "661089"   //报备收入
                || d.ModelId == "661091"   //报备支出
                || d.ModelId == "661086"   //报备非收支
                )
                && d.IsTips != true
                && !d.ProcessData.Contains("申请人出差返回")
                )
                .OrderBy(wx_org_process._.BillTime.Asc)
                .Page(count, page)
                .ToList();
            
            return Json(processlist);
        }

        /// <summary>
        /// 3、查询公文流程
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public JsonResult DocumentProcess(int page, int count)
        {
            List<wx_org_process> processlist = DB.Context.From<wx_org_process>()
                .Where(d => d.Approvers == UserloginNameCookie()
                && d.BillTitle != ""
                && d.Status == false
                && (d.ModelId == "97028"      //公文
                || d.ModelId == "440370"   //公文
                || d.ModelId == "233206"   //公文
                || d.ModelId == "440871"   //公文
                || d.ModelId == "440839"   //公文
                || d.ModelId == "261242"   //公文
                || d.ModelId == "237386"   //公文
                || d.ModelId == "216219"   //公文
                )
                //&& d.IsTips != true 
                )
                .OrderBy(wx_org_process._.BillTime.Asc)
                .Page(count, page)
                .ToList();
            return Json(processlist);
        }
        //4、待办及公文签报审批
        public string SvcWorkflowMWFs()
        {
            try
            {
                var BillNo = Request["BillNo"];  //流程编号
                var strApproveNote = Request["strApproveNote"];  //处理意见

                var ServerID = Request["ServerID"];   // serverid
                var Project = Request["Project"];  //  peoject
                var taskId = Request["taskId"];   // taskid
                var ModelId = Request["ModelId"];   // modelid
                var ProcessID = Request["ProcessID"];  // peocesid
                var xuanzerenID = Request["xuanzerenID"];  // 选择人ID
                var Processing_Code = Request["Processing_Code"];   // 审批方式
                var liuchengType = Request["liuchengType"];    //流程TYPE   退回其他审批人：0    征求他人意见：1       驳回流程穿0     审批流程穿1
                var zhuanbanren = "";   //转办
                var huiqianren = "";    //会签
                string strXmlDoc = "";
                if (liuchengType == "1" && (
                    ModelId == "440370"
                    || ModelId == "97028"
                    || ModelId == "233206"
                    || ModelId == "440871"
                    || ModelId == "440839"
                    || ModelId == "261242"
                    || ModelId == "237386"
                    || ModelId == "216219"
                    ))
                {
                    string codename = Request["Processing_CodeName"];
                    strXmlDoc += SetTextValue("Root/f_SelectiveMode", codename);
                    if (codename == "送控股总经理审批")
                    {
                        strXmlDoc += SetTextValue("Root/CustomData/f_cljg", "2");
                        strXmlDoc += SetTextValue("Root/CustomData/f_glc_id", xuanzerenID); //选择领导的域账号
                        strXmlDoc += SetTextValue("Root/CustomData/f_glc_jb", "1");
                    }
                    else if (codename == "送董事长审批")
                    {
                        strXmlDoc += SetTextValue("Root/CustomData/f_cljg", "2");
                        strXmlDoc += SetTextValue("Root/CustomData/f_glc_id", "wangzhengyu"); //选择领导的域账号
                        strXmlDoc += SetTextValue("Root/CustomData/f_glc_jb", "1");
                    }
                    else if (codename == "送总经理审批")
                    {
                        strXmlDoc += SetTextValue("Root/CustomData/f_cljg", "2");
                        strXmlDoc += SetTextValue("Root/CustomData/f_glc_id", "wanghongyu"); //选择领导的域账号
                        strXmlDoc += SetTextValue("Root/CustomData/f_glc_jb", "1");
                    }
                    else if (codename == "终审发文")
                    {
                        try
                        {
                            List<WX_ORG_USER> dts = DB.Context.From<WX_ORG_USER>().Where(WX_ORG_USER._.UserLoginName == UserloginNameCookie()).ToList();
                            strXmlDoc += SetTextValue("Root/CustomData/f_qfr", dts.FirstOrDefault().Name);  //中文姓名
                        }
                        catch (Exception)
                        {
                            strXmlDoc += SetTextValue("Root/CustomData/f_qfr", UserloginNameCookie());  //域账号
                        }
                    }
                }
                strXmlDoc += SetTextValue("Root/CustomData/f_ApprveLoginName_MobilePhone", UserloginNameCookie());

                //审批通过   :   1
                //退回到起点，AppValue=2    //退回至起点
                //退回其他已审批人，AppValue=8，相当于会签，       
                //向上呈报，AppValue=1，相当于审批通过，
                //征求他人意见，AppValue=8，相当于会签
                //转办他人，AppValue=5  转办
                //liuchengType=0   驳回会签

                //会签=8    流程type=0
                if (Processing_Code == "8" && liuchengType == "0")
                {
                    //会签人赋值
                    huiqianren = xuanzerenID;
                    //xml之进行复值
                    strXmlDoc += SetTextValue("Root/f_Is_TH", "1");
                }   //会签=8     流程type=1
                else if (Processing_Code == "8" && liuchengType == "1")   //征求他人意见
                {
                    //会签人赋值
                    huiqianren = xuanzerenID;
                    //xml进行复值
                    strXmlDoc += SetTextValue("Root/f_hqxx", "1");
                    strXmlDoc += SetTextValue("Root/f_hqlx", "2");
                }
                else if (Processing_Code == "5")
                {
                    zhuanbanren = xuanzerenID;
                }
                //审批通过时，没写审批意见择审批意见默认为“同意”
                if (strApproveNote.Trim() == "" && Processing_Code == "1")
                {
                    strApproveNote = "同意";
                }

                wx_org_log log = new wx_org_log();
                log.BillNo = BillNo;
                log.huiqianren = xuanzerenID;
                log.ID = Guid.NewGuid().ToString();
                log.ModelId = ModelId;
                log.ProcessID = ProcessID;
                log.Processing_Code = Processing_Code;
                log.Project = Project;
                log.ServerID = ServerID;
                log.strApproveNote = strApproveNote;
                log.strXmlDoc = strXmlDoc.Substring(0, strXmlDoc.Length - 1);
                log.taskId = taskId;
                log.zhuanbanren = xuanzerenID;
                log.UserloginNameCookie = UserloginNameCookie();
                log.AddTime = DateTime.Now;

                if (UserloginNameCookie() == "weizetong")
                {
                    log.Returnstate = "6";
                }
                else
                {
                    log.Returnstate = "2";
                }
                //处理成功后修改审批状态
                var deleteReturn = DB.Context.Update<wx_org_process>(wx_org_process._.Status, true, wx_org_process._.BillNo == BillNo);
                var deleteReturns = DB.Context.Insert<wx_org_log>(log);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.Message;
                throw;
            }
        }
        //5、公文待阅处理
        public string SvcWorkflowToRead()
        {
            try
            {
                var BillNo = Request["BillNo"];  //流程编号
                var ServerID = Request["ServerID"];   // serverid
                var Project = Request["Project"];  //  peoject
                var ModelId = Request["ModelId"];   // modelid
                var ProcessID = Request["ProcessID"];  // processid
                using (SvcWorkflowMWFClient svc = new SvcWorkflowMWFClient())
                {
                    if (svc.GWYY(ServerID, Project, ModelId, ProcessID, UserloginNameCookie()))
                    {
                        wx_org_log log = new wx_org_log();
                        log.BillNo = BillNo;
                        log.ID = Guid.NewGuid().ToString();
                        log.ModelId = ModelId;
                        log.ProcessID = ProcessID;
                        log.Project = Project;
                        log.ServerID = ServerID;
                        log.UserloginNameCookie = UserloginNameCookie();
                        log.AddTime = DateTime.Now;
                        //处理成功后修改审批状态
                        var deleteReturn = DB.Context.Update<wx_org_process>(wx_org_process._.Status, true, wx_org_process._.BillNo == BillNo && wx_org_process._.Approvers == UserloginNameCookie());
                        var deleteReturns = DB.Context.Insert<wx_org_log>(log);

                        return "OK";
                    }
                }
                return "NO";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        /// <summary>
        /// 6、查询已处理待办数据
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public JsonResult WorkflowProcess_Processed(int page, int count)
        {
            List<wx_org_process_processed> processlist = DB.Context.From<wx_org_process_processed>()
                .Where(d => d.Approvers == UserloginNameCookie() && d.BillTitle != "" && d.Status == true
                && (
                   d.ModelId == "38926"    //发票
                || d.ModelId == "7281"     //报销
                || d.ModelId == "332373"   //印章
                || d.ModelId == "7559"     //请假
                || d.ModelId == "183443"   //外出
                || d.ModelId == "181382"   //考勤
                || d.ModelId == "7575"     //名片
                || d.ModelId == "183445"   //加班
                || d.ModelId == "7573"   //出差申请
                || d.ModelId == "184002"   //工卡申请
                || d.ModelId == "374334"   //会议申请
                || d.ModelId == "22283"   //培训申请
                || d.ModelId == "164584"  //工会活动申请
                || d.ModelId == "35876"   //机票变更
                || d.ModelId == "364244"   //弹性考勤
                || d.ModelId == "343373"   //外包变更
                || d.ModelId == "239336"   //外包到场
                || d.ModelId == "243670"   //外包离场
                || d.ModelId == "163755"   //合同评审
                || d.ModelId == "266961"   //采购请购
                || d.ModelId == "181943"   //薪酬
                || d.ModelId == "9597"   //员工变动
                || d.ModelId == "10788"   //员工离职
                || d.ModelId == "10767"   //员工入职
                || d.ModelId == "41556"   //员工转正
                || d.ModelId == "181603"   //招聘需求申请
                || d.ModelId == "411557"   //卓学平台资源申请
                || d.ModelId == "270494"   //方案决策
                || d.ModelId == "270497"   //结果确认
                || d.ModelId == "181846"   //内容发布
                || d.ModelId == "19788"   //公司用车
                || d.ModelId == "326448"   //通知发布
                || d.ModelId == "11058"   //因公出国
                || d.ModelId == "205944"   //领导信息评审
                || d.ModelId == "37931"   //租车申请
                || d.ModelId == "62487"   //虚拟结算
                || d.ModelId == "27195"   //劳动合同
                || d.ModelId == "23966"   //采购预审
                || d.ModelId == "7542"   //办公用品
                || d.ModelId == "129472"   //网络资源
                || d.ModelId == "661089"   //报备收入
                || d.ModelId == "661091"   //报备支出
                || d.ModelId == "661086"   //报备非收支
                )
                && d.IsTips != true
                && !d.ProcessData.Contains("申请人出差返回")
                )
                .OrderBy(wx_org_process_processed._.BillTime.Asc)
                .Page(count, page)
                .ToList();

            return Json(processlist);
        }

        /// <summary>
        /// 7、查询已处理公文流程
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public JsonResult DocumentProcess_Processed(int page, int count)
        {
            List<wx_org_process_processed> processlist = DB.Context.From<wx_org_process_processed>()
                .Where(d => d.Approvers == UserloginNameCookie()
                && d.BillTitle != ""
                && d.Status == true
                && (d.ModelId == "97028"      //公文
                || d.ModelId == "440370"   //公文
                || d.ModelId == "233206"   //公文
                || d.ModelId == "440871"   //公文
                || d.ModelId == "440839"   //公文
                || d.ModelId == "261242"   //公文
                || d.ModelId == "237386"   //公文
                || d.ModelId == "216219"   //公文
                )
                )
                .OrderBy(wx_org_process_processed._.BillTime.Asc)
                .Page(count, page)
                .ToList();
            return Json(processlist);
        }
        //8、查询已处理待办详情
        public JsonResult QueryProcessedDocument()
        {
            var billNo = Request["billNo"];
            var count = DB.Context.From<wx_org_process_processed>()
                .Where(d => d.BillNo == billNo && d.Approvers == UserloginNameCookie())
                .ToList();
            return Json(count);
        }
        
        /// <summary>
        /// 9、查询流程集合，未处理
        /// </summary>
        /// <returns></returns>
        public string QueryProcessAssemble()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(new DAL().QueryProcessAssemble(UserloginNameCookie()));
        }
        /// <summary>
        /// 9、查询流程集合，已处理
        /// </summary>
        /// <returns></returns>
        public string QueryProcessAssemble_Processed()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(new DAL().QueryProcessAssemble_Processed(UserloginNameCookie()));
        }
        /// <summary>
        /// 根据ModelId待办查询流程，未处理
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <param name="ModelId"></param>
        /// <returns></returns>
        public  JsonResult QueryProcessByModelId(int page, int count,string ModelId)
        {
            List<wx_org_process> processlist = DB.Context.From<wx_org_process>()
                .Where(d => d.Approvers == UserloginNameCookie() && d.BillTitle != "" && d.Status == false&&d.ModelId==ModelId
                && d.IsTips != true
                && !d.ProcessData.Contains("申请人出差返回")
                )
                .OrderBy(wx_org_process._.BillTime.Asc)
                .Page(count, page)
                .ToList();

            return Json(processlist);
        }
        /// <summary>
        /// 根据ModelId待办查询流程,已处理
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <param name="ModelId"></param>
        /// <returns></returns>
        public JsonResult QueryProcessByModelId_Processed(int page, int count, string ModelId)
        {
            List<wx_org_process_processed> processlist = DB.Context.From<wx_org_process_processed>()
                .Where(d => d.Approvers == UserloginNameCookie() && d.BillTitle != "" && d.Status == true && d.ModelId == ModelId
                && d.IsTips != true
                && !d.ProcessData.Contains("申请人出差返回")
                )
                .OrderBy(wx_org_process_processed._.BillTime.Asc)
                .Page(count, page)
                .ToList();

            return Json(processlist);
        }
        /// <summary>
        /// 根据待办标题或审批人查询待办流程，未处理
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <param name="ModelId"></param>
        /// <returns></returns>
        public JsonResult QueryProcessByName(int page, int count, string Name)
        {
            List<wx_org_process> processlist = DB.Context.From<wx_org_process>()
                .Where(d => d.Approvers == UserloginNameCookie() && d.BillTitle != "" && d.Status == false && (
                d.BillTitle.Contains(Name)||d.BillEmpName.Contains(Name))
                && d.IsTips != true
                && !d.ProcessData.Contains("申请人出差返回")
                && (
                   d.ModelId == "38926"    //发票
                || d.ModelId == "7281"     //报销
                || d.ModelId == "332373"   //印章
                || d.ModelId == "7559"     //请假
                || d.ModelId == "183443"   //外出
                || d.ModelId == "181382"   //考勤
                || d.ModelId == "7575"     //名片
                || d.ModelId == "183445"   //加班
                || d.ModelId == "7573"   //出差申请
                || d.ModelId == "184002"   //工卡申请
                || d.ModelId == "374334"   //会议申请
                || d.ModelId == "22283"   //培训申请
                || d.ModelId == "164584"  //工会活动申请
                || d.ModelId == "35876"   //机票变更
                || d.ModelId == "364244"   //弹性考勤
                || d.ModelId == "343373"   //外包变更
                || d.ModelId == "239336"   //外包到场
                || d.ModelId == "243670"   //外包离场
                || d.ModelId == "163755"   //合同评审
                || d.ModelId == "266961"   //采购请购
                || d.ModelId == "181943"   //薪酬
                || d.ModelId == "9597"   //员工变动
                || d.ModelId == "10788"   //员工离职
                || d.ModelId == "10767"   //员工入职
                || d.ModelId == "41556"   //员工转正
                || d.ModelId == "181603"   //招聘需求申请
                || d.ModelId == "411557"   //卓学平台资源申请
                || d.ModelId == "270494"   //方案决策
                || d.ModelId == "270497"   //结果确认
                || d.ModelId == "181846"   //内容发布
                || d.ModelId == "19788"   //公司用车
                || d.ModelId == "326448"   //通知发布
                || d.ModelId == "11058"   //因公出国
                || d.ModelId == "205944"   //领导信息评审
                || d.ModelId == "37931"   //租车申请
                || d.ModelId == "62487"   //虚拟结算
                || d.ModelId == "27195"   //劳动合同
                || d.ModelId == "23966"   //采购预审
                || d.ModelId == "7542"   //办公用品
                || d.ModelId == "129472"   //网络资源
                || d.ModelId == "661089"   //报备收入
                || d.ModelId == "661091"   //报备支出
                || d.ModelId == "661086"   //报备非收支
                )
                )
                .OrderBy(wx_org_process._.BillTime.Asc)
                .Page(count, page)
                .ToList();
            return Json(processlist);
        }
        /// <summary>
        /// 根据待办标题或审批人查询待办流程，已处理
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public JsonResult QueryProcessByName_Processed(int page, int count, string Name)
        {
            List<wx_org_process_processed> processlist = DB.Context.From<wx_org_process_processed>()
                .Where(d => d.Approvers == UserloginNameCookie() && d.BillTitle != "" && d.Status == true && (
                d.BillTitle.Contains(Name) || d.BillEmpName.Contains(Name))
                && d.IsTips != true
                && !d.ProcessData.Contains("申请人出差返回")
                && (
                   d.ModelId == "38926"    //发票
                || d.ModelId == "7281"     //报销
                || d.ModelId == "332373"   //印章
                || d.ModelId == "7559"     //请假
                || d.ModelId == "183443"   //外出
                || d.ModelId == "181382"   //考勤
                || d.ModelId == "7575"     //名片
                || d.ModelId == "183445"   //加班
                || d.ModelId == "7573"   //出差申请
                || d.ModelId == "184002"   //工卡申请
                || d.ModelId == "374334"   //会议申请
                || d.ModelId == "22283"   //培训申请
                || d.ModelId == "164584"  //工会活动申请
                || d.ModelId == "35876"   //机票变更
                || d.ModelId == "364244"   //弹性考勤
                || d.ModelId == "343373"   //外包变更
                || d.ModelId == "239336"   //外包到场
                || d.ModelId == "243670"   //外包离场
                || d.ModelId == "163755"   //合同评审
                || d.ModelId == "266961"   //采购请购
                || d.ModelId == "181943"   //薪酬
                || d.ModelId == "9597"   //员工变动
                || d.ModelId == "10788"   //员工离职
                || d.ModelId == "10767"   //员工入职
                || d.ModelId == "41556"   //员工转正
                || d.ModelId == "181603"   //招聘需求申请
                || d.ModelId == "411557"   //卓学平台资源申请
                || d.ModelId == "270494"   //方案决策
                || d.ModelId == "270497"   //结果确认
                || d.ModelId == "181846"   //内容发布
                || d.ModelId == "19788"   //公司用车
                || d.ModelId == "326448"   //通知发布
                || d.ModelId == "11058"   //因公出国
                || d.ModelId == "205944"   //领导信息评审
                || d.ModelId == "37931"   //租车申请
                || d.ModelId == "62487"   //虚拟结算
                || d.ModelId == "27195"   //劳动合同
                || d.ModelId == "23966"   //采购预审
                || d.ModelId == "7542"   //办公用品
                || d.ModelId == "129472"   //网络资源
                || d.ModelId == "661089"   //报备收入
                || d.ModelId == "661091"   //报备支出
                || d.ModelId == "661086"   //报备非收支
                )
                )
                .OrderBy(wx_org_process_processed._.BillTime.Asc)
                .Page(count, page)
                .ToList();
            return Json(processlist);
        }
        /// <summary>
        /// 根据待办标题或审批人查询公文流程，未处理
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public JsonResult QueryDocumentProcessByName(int page, int count, string Name)
        {
            List<wx_org_process> processlist = DB.Context.From<wx_org_process>()
                .Where(d => d.Approvers == UserloginNameCookie() && d.BillTitle != "" && d.Status == false && (
                d.BillTitle.Contains(Name) || d.BillEmpName.Contains(Name))
                && (d.ModelId == "97028"      //公文
                || d.ModelId == "440370"   //公文
                || d.ModelId == "233206"   //公文
                || d.ModelId == "440871"   //公文
                || d.ModelId == "440839"   //公文
                || d.ModelId == "261242"   //公文
                || d.ModelId == "237386"   //公文
                || d.ModelId == "216219"   //公文
                )
                )
                .OrderBy(wx_org_process._.BillTime.Asc)
                .Page(count, page)
                .ToList();
            return Json(processlist);
        }
        /// <summary>
        /// 根据待办标题或审批人查询公文流程，已处理
        /// </summary>
        /// <param name="page"></param>
        /// <param name="count"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public JsonResult QueryDocumentProcessByName_Processed(int page, int count, string Name)
        {
            List<wx_org_process_processed> processlist = DB.Context.From<wx_org_process_processed>()
                .Where(d => d.Approvers == UserloginNameCookie() && d.BillTitle != "" && d.Status == true && (
                d.BillTitle.Contains(Name) || d.BillEmpName.Contains(Name))
                && (d.ModelId == "97028"      //公文
                || d.ModelId == "440370"   //公文
                || d.ModelId == "233206"   //公文
                || d.ModelId == "440871"   //公文
                || d.ModelId == "440839"   //公文
                || d.ModelId == "261242"   //公文
                || d.ModelId == "237386"   //公文
                || d.ModelId == "216219"   //公文
                )
                )
                .OrderBy(wx_org_process_processed._.BillTime.Asc)
                .Page(count, page)
                .ToList();
            return Json(processlist);
        }
        public JsonResult getFile()
        {
            var file = Request["file"];
            List<string> xiaofei = JsonConvert.DeserializeObject<List<string>>(file);//前台获取到json字符串序列化到实体类
            List<fileHelper> fileli = new List<fileHelper>();
            foreach (var item in xiaofei)
            {
                fileHelper fi = new fileHelper();
                string[] filezhi = item.Split(',');
                fi.name = filezhi[1];
                //把路径\替换
                string Field15 = filezhi[0].Replace("\\", "/");
                string url = "";
                if (filezhi[3] == "7281" && filezhi[2] == "3")  //报销附件路径转换
                {
                    url = "http://eipex.aspirehld.com/ExUploadFiles/" + Field15.Substring(Field15.IndexOf("SUBMIT"), Field15.Length - Field15.IndexOf("SUBMIT")).Replace("SUBMIT//", "");
                }
                else
                {
                    url = GetUrl(filezhi[2]) + Field15.Substring(Field15.IndexOf(filezhi[3]), Field15.Length - Field15.IndexOf(filezhi[3]));
                }
                fi.url = url;
                fileli.Add(fi);
            }
            return Json(fileli);
        }

        public class fileHelper
        {
            public string name;
            public string url;
        }


        //根据  serverID获取http 路径
        public string GetUrl(string serverID)
        {
            var result = "";
            switch (serverID)
            {
                case "1":
                    result = "http://10.2.3.55/CwFile/";
                    break;
                case "3":
                    result = "http://eipwf.aspirehld.com/UploadFiles/";
                    break;
                case "5":
                    result = "http://wfweb.test.aspirecn.com/CwFile/";
                    break;
                case "7":
                    result = "http://eipwf.aspirecn.com/CwFile/";
                    break;
                case "11":
                    result = "http://eipwf.aspirecn.com/CwFile/";
                    break;
                case "21":
                    result = "http://web01.dev.aspirecn.com/CwFile/";
                    break;
                case "22":
                    result = "http://10.2.8.10/UploadFiles/";
                    break;
                default:
                    result = "http://10.2.3.55/CwFile/";
                    break;
            }
            return result;
        }



        public string SetTextValue(string str_XmlPath, string str_Value)
        {
            try
            {
                var strXmlDoc = "";
                strXmlDoc += str_XmlPath;
                strXmlDoc += "^" + str_Value + "|";
                return strXmlDoc;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public string SendMes()
        {
            string result = "OK";
            try
            {
                DataTable processdt = DB.Context.FromSql("select a.*,b.Cellphone from (select Approvers,count(ID) as num from wx_org_process where status=0 group by Approvers) as a inner join wx_org_user b on a.Approvers=b.UserLoginName").ToDataTable();
                foreach (DataRow dr in processdt.Rows)
                {
                    //if (dr["Approvers"].ToString() == "likuo" || dr["Approvers"].ToString() == "penghanguo")
                    //{
                    //进行发送短信验证码入库
                    WX_ORG_SmsCodeTemporary Temporary = new WX_ORG_SmsCodeTemporary();
                    Temporary.ID = Guid.NewGuid().ToString();
                    Temporary.Phone = dr["Cellphone"].ToString();
                    Temporary.Smstext = "尊敬的领导，您好！公司新版移动办公客户端产品“和飞信-负一屏”已正式发布。该产品是一款着力于改善企业工作和沟通的企业移动化产品，主要功能包括‘我的待办’、‘企业新闻’、‘公告信息’、‘考勤打卡’和‘企业通讯录’等模块。目前您还有" + dr["num"] + "条待办未处理，如果您无法在PC端操作审批流程时，可以直接登录“和飞信-负一屏”移动客户端完成相关流程审批。信息系统解决方案部";
                    DB.Context.Insert<WX_ORG_SmsCodeTemporary>(Temporary);
                    //}
                }
            }
            catch (Exception ex)
            {
                ServiceName += "_SendMes()";
                string LogBody = "---发送短信(待办提醒)报错, 时间：" + DateTime.Now + "错误：" + ex.ToString() + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
                result = "";
            }
            return result;
        }

        public string UpdateAttachmentUrl()
        {
            string result = "NULL";
            try
            {
                string key = Request["key"].ToString();

            }
            catch (Exception ex)
            {
                ServiceName += "_UpdateAttachmentUrl()";
                string LogBody = "---同步附件失败，清空文件地址时报错 时间：" + DateTime.Now + "错误：" + ex.ToString() + "---\r\n";
                Common.WriteLogFile(Common.getErrorLogFile(ServiceName), LogBody);
                result = ex.ToString();
            }
            return result;
        }


        public JsonResult selectAttachment()
        {
            var sid = Request["sid"];
            var mid = Request["mid"];
            var pid = Request["pid"];
            var count = DB.Context.From<wx_org_attachment>()
                .Where(d => d.Sid == sid && d.Mid == mid && d.Pid == pid && d.Status == 1 && d.IsDelete == 0)
                .ToList();

            return Json(count);
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
                            if (VisitType == "H")
                            {
                                return Redirect("../Home/index");  //发票信息
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
                string LogBody = "---执行服务出现错误，异常信息:" + e.Message + ",时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "---\r\n";
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

        public ActionResult DocumentList()
        {
            return View();
        }
    }
}