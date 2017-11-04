using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;

namespace WorkflowApp
{
    /// <summary>
    /// 实体类wx_org_process_ucml。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("wx_org_process_ucml")]
    [Serializable]
    public partial class wx_org_process_ucml : Entity
    {
        #region Model
        private string _ID;
        private string _ServerID;
        private string _ModelId;
        private string _ProcessID;
        private string _ProcessData;
        private string _Approvers;
        private string _BillNo;
        private string _BillTitle;
        private DateTime? _BillTime;
        private string _BillEmpLoginName;
        private string _BillEmpName;
        private bool? _Status;
        private DateTime? _SyncTime;
        private string _selecttextContentHtml;
        private bool? _IsTips;

        /// <summary>
        /// 从电子流同步的待办，包含xml信息和审批日志
        /// </summary>
        [Field("ID")]
        public string ID
        {
            get { return _ID; }
            set
            {
                this.OnPropertyValueChange("ID");
                this._ID = value;
            }
        }
        /// <summary>
        /// sid
        /// </summary>
        [Field("ServerID")]
        public string ServerID
        {
            get { return _ServerID; }
            set
            {
                this.OnPropertyValueChange("ServerID");
                this._ServerID = value;
            }
        }
        /// <summary>
        /// mid
        /// </summary>
        [Field("ModelId")]
        public string ModelId
        {
            get { return _ModelId; }
            set
            {
                this.OnPropertyValueChange("ModelId");
                this._ModelId = value;
            }
        }
        /// <summary>
        /// pid
        /// </summary>
        [Field("ProcessID")]
        public string ProcessID
        {
            get { return _ProcessID; }
            set
            {
                this.OnPropertyValueChange("ProcessID");
                this._ProcessID = value;
            }
        }
        /// <summary>
        /// json格式，包含processdata表中的xmldata字段和审批日志表中的字段
        /// </summary>
        [Field("ProcessData")]
        public string ProcessData
        {
            get { return _ProcessData; }
            set
            {
                this.OnPropertyValueChange("ProcessData");
                this._ProcessData = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Approvers")]
        public string Approvers
        {
            get { return _Approvers; }
            set
            {
                this.OnPropertyValueChange("Approvers");
                this._Approvers = value;
            }
        }
        /// <summary>
        /// 提单编号
        /// </summary>
        [Field("BillNo")]
        public string BillNo
        {
            get { return _BillNo; }
            set
            {
                this.OnPropertyValueChange("BillNo");
                this._BillNo = value;
            }
        }
        /// <summary>
        /// 单提标题
        /// </summary>
        [Field("BillTitle")]
        public string BillTitle
        {
            get { return _BillTitle; }
            set
            {
                this.OnPropertyValueChange("BillTitle");
                this._BillTitle = value;
            }
        }
        /// <summary>
        /// 提单时间
        /// </summary>
        [Field("BillTime")]
        public DateTime? BillTime
        {
            get { return _BillTime; }
            set
            {
                this.OnPropertyValueChange("BillTime");
                this._BillTime = value;
            }
        }
        /// <summary>
        /// 提单人账号
        /// </summary>
        [Field("BillEmpLoginName")]
        public string BillEmpLoginName
        {
            get { return _BillEmpLoginName; }
            set
            {
                this.OnPropertyValueChange("BillEmpLoginName");
                this._BillEmpLoginName = value;
            }
        }
        /// <summary>
        /// 提单人姓名
        /// </summary>
        [Field("BillEmpName")]
        public string BillEmpName
        {
            get { return _BillEmpName; }
            set
            {
                this.OnPropertyValueChange("BillEmpName");
                this._BillEmpName = value;
            }
        }
        /// <summary>
        /// 状态：false-未审批；true-已审批
        /// </summary>
        [Field("Status")]
        public bool? Status
        {
            get { return _Status; }
            set
            {
                this.OnPropertyValueChange("Status");
                this._Status = value;
            }
        }
        /// <summary>
        /// 同步时间
        /// </summary>
        [Field("SyncTime")]
        public DateTime? SyncTime
        {
            get { return _SyncTime; }
            set
            {
                this.OnPropertyValueChange("SyncTime");
                this._SyncTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("selecttextContentHtml")]
        public string selecttextContentHtml
        {
            get { return _selecttextContentHtml; }
            set
            {
                this.OnPropertyValueChange("selecttextContentHtml");
                this._selecttextContentHtml = value;
            }
        }

        /// <summary>
        /// 待阅：false-代办；true-待阅
        /// </summary>
        [Field("IsTips")]
        public bool? IsTips
        {
            get { return _IsTips; }
            set
            {
                this.OnPropertyValueChange("IsTips");
                this._Status = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
				_.ID,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.ID,
				_.ServerID,
				_.ModelId,
				_.ProcessID,
				_.ProcessData,
				_.Approvers,
				_.BillNo,
				_.BillTitle,
				_.BillTime,
				_.BillEmpLoginName,
				_.BillEmpName,
				_.Status,
				_.SyncTime,
				_.selecttextContentHtml,
				_.IsTips,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._ServerID,
				this._ModelId,
				this._ProcessID,
				this._ProcessData,
				this._Approvers,
				this._BillNo,
				this._BillTitle,
				this._BillTime,
				this._BillEmpLoginName,
				this._BillEmpName,
				this._Status,
				this._SyncTime,
				this._selecttextContentHtml,
				this._IsTips,
			};
        }
        /// <summary>
        /// 是否是v1.10.5.6及以上版本实体。
        /// </summary>
        /// <returns></returns>
        public override bool V1_10_5_6_Plus()
        {
            return true;
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// * 
            /// </summary>
            public readonly static Field All = new Field("*", "wx_org_process_ucml");
            /// <summary>
            /// 从电子流同步的待办，包含xml信息和审批日志
            /// </summary>
            public readonly static Field ID = new Field("ID", "wx_org_process_ucml", "从电子流同步的待办，包含xml信息和审批日志");
            /// <summary>
            /// sid
            /// </summary>
            public readonly static Field ServerID = new Field("ServerID", "wx_org_process_ucml", "sid");
            /// <summary>
            /// mid
            /// </summary>
            public readonly static Field ModelId = new Field("ModelId", "wx_org_process_ucml", "mid");
            /// <summary>
            /// pid
            /// </summary>
            public readonly static Field ProcessID = new Field("ProcessID", "wx_org_process_ucml", "pid");
            /// <summary>
            /// json格式，包含processdata表中的xmldata字段和审批日志表中的字段
            /// </summary>
            public readonly static Field ProcessData = new Field("ProcessData", "wx_org_process_ucml", "json格式，包含processdata表中的xmldata字段和审批日志表中的字段");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Approvers = new Field("Approvers", "wx_org_process_ucml", "");
            /// <summary>
            /// 提单编号
            /// </summary>
            public readonly static Field BillNo = new Field("BillNo", "wx_org_process_ucml", "提单编号");
            /// <summary>
            /// 单提标题
            /// </summary>
            public readonly static Field BillTitle = new Field("BillTitle", "wx_org_process_ucml", "单提标题");
            /// <summary>
            /// 提单时间
            /// </summary>
            public readonly static Field BillTime = new Field("BillTime", "wx_org_process_ucml", "提单时间");
            /// <summary>
            /// 提单人账号
            /// </summary>
            public readonly static Field BillEmpLoginName = new Field("BillEmpLoginName", "wx_org_process_ucml", "提单人账号");
            /// <summary>
            /// 提单人姓名
            /// </summary>
            public readonly static Field BillEmpName = new Field("BillEmpName", "wx_org_process_ucml", "提单人姓名");
            /// <summary>
            /// 状态：false-未审批；true-已审批
            /// </summary>
            public readonly static Field Status = new Field("Status", "wx_org_process_ucml", "状态：false-未审批；true-已审批");
            /// <summary>
            /// 同步时间
            /// </summary>
            public readonly static Field SyncTime = new Field("SyncTime", "wx_org_process_ucml", "同步时间");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field selecttextContentHtml = new Field("selecttextContentHtml", "wx_org_process_ucml", "");
            /// <summary>
            /// 待阅：false-代办true-待阅
            /// </summary>
            public readonly static Field IsTips = new Field("IsTips", "wx_org_process_ucml", "待阅：false-代办true-待阅");
        }
        #endregion
    }
}
