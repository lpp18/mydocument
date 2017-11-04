using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dos.ORM;
using System.Data;

namespace WorkflowApp
{
    /// <summary>
	/// 实体类wx_org_process 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
    public class wx_org_process : Entity
    {
        public wx_org_process() : base("wx_org_process") { }

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
        private string _selecttextcontenthtml;
        private bool? _IsTips;
        /// <summary>
        /// 
        /// </summary>
        public string ID
        {
            get { return _ID; }
            set
            {
                this.OnPropertyValueChange(_.ID, _ID, value);
                this._ID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ServerID
        {
            get { return _ServerID; }
            set
            {
                this.OnPropertyValueChange(_.ServerID, _ServerID, value);
                this._ServerID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ModelId
        {
            get { return _ModelId; }
            set
            {
                this.OnPropertyValueChange(_.ModelId, _ModelId, value);
                this._ModelId = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ProcessID
        {
            get { return _ProcessID; }
            set
            {
                this.OnPropertyValueChange(_.ProcessID, _ProcessID, value);
                this._ProcessID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ProcessData
        {
            get { return _ProcessData; }
            set
            {
                this.OnPropertyValueChange(_.ProcessData, _ProcessData, value);
                this._ProcessData = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Approvers
        {
            get { return _Approvers; }
            set
            {
                this.OnPropertyValueChange(_.Approvers, _Approvers, value);
                this._Approvers = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BillNo
        {
            get { return _BillNo; }
            set
            {
                this.OnPropertyValueChange(_.BillNo, _BillNo, value);
                this._BillNo = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BillTitle
        {
            get { return _BillTitle; }
            set
            {
                this.OnPropertyValueChange(_.BillTitle, _BillTitle, value);
                this._BillTitle = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? BillTime
        {
            get { return _BillTime; }
            set
            {
                this.OnPropertyValueChange(_.BillTime, _BillTime, value);
                this._BillTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BillEmpLoginName
        {
            get { return _BillEmpLoginName; }
            set
            {
                this.OnPropertyValueChange(_.BillEmpLoginName, _BillEmpLoginName, value);
                this._BillEmpLoginName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BillEmpName
        {
            get { return _BillEmpName; }
            set
            {
                this.OnPropertyValueChange(_.BillEmpName, _BillEmpName, value);
                this._BillEmpName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? Status
        {
            get { return _Status; }
            set
            {
                this.OnPropertyValueChange(_.Status, _Status, value);
                this._Status = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? SyncTime
        {
            get { return _SyncTime; }
            set
            {
                this.OnPropertyValueChange(_.SyncTime, _SyncTime, value);
                this._SyncTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string selecttextcontenthtml
        {
            get { return _selecttextcontenthtml; }
            set
            {
                this.OnPropertyValueChange(_.selecttextcontenthtml, _selecttextcontenthtml, value);
                this._selecttextcontenthtml = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsTips
        {
            get { return _IsTips; }
            set
            {
                this.OnPropertyValueChange(_.IsTips, _IsTips, value);
                this._IsTips = value;
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
                _.ID};
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
                _.selecttextcontenthtml,
                _.IsTips};
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
                this._selecttextcontenthtml,
                this._IsTips};
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._ID = DataUtils.ConvertValue<string>(reader["ID"]);
            this._ServerID = DataUtils.ConvertValue<string>(reader["ServerID"]);
            this._ModelId = DataUtils.ConvertValue<string>(reader["ModelId"]);
            this._ProcessID = DataUtils.ConvertValue<string>(reader["ProcessID"]);
            this._ProcessData = DataUtils.ConvertValue<string>(reader["ProcessData"]);
            this._Approvers = DataUtils.ConvertValue<string>(reader["Approvers"]);
            this._BillNo = DataUtils.ConvertValue<string>(reader["BillNo"]);
            this._BillTitle = DataUtils.ConvertValue<string>(reader["BillTitle"]);
            this._BillTime = DataUtils.ConvertValue<DateTime?>(reader["BillTime"]);
            this._BillEmpLoginName = DataUtils.ConvertValue<string>(reader["BillEmpLoginName"]);
            this._BillEmpName = DataUtils.ConvertValue<string>(reader["BillEmpName"]);
            this._Status = DataUtils.ConvertValue<bool?>(reader["Status"]);
            this._SyncTime = DataUtils.ConvertValue<DateTime?>(reader["SyncTime"]);
            this._selecttextcontenthtml = DataUtils.ConvertValue<string>(reader["selecttextcontenthtml"]);
            this._IsTips = DataUtils.ConvertValue<bool?>(reader["IsTips"]);
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._ID = DataUtils.ConvertValue<string>(row["ID"]);
            this._ServerID = DataUtils.ConvertValue<string>(row["ServerID"]);
            this._ModelId = DataUtils.ConvertValue<string>(row["ModelId"]);
            this._ProcessID = DataUtils.ConvertValue<string>(row["ProcessID"]);
            this._ProcessData = DataUtils.ConvertValue<string>(row["ProcessData"]);
            this._Approvers = DataUtils.ConvertValue<string>(row["Approvers"]);
            this._BillNo = DataUtils.ConvertValue<string>(row["BillNo"]);
            this._BillTitle = DataUtils.ConvertValue<string>(row["BillTitle"]);
            this._BillTime = DataUtils.ConvertValue<DateTime?>(row["BillTime"]);
            this._BillEmpLoginName = DataUtils.ConvertValue<string>(row["BillEmpLoginName"]);
            this._BillEmpName = DataUtils.ConvertValue<string>(row["BillEmpName"]);
            this._Status = DataUtils.ConvertValue<bool?>(row["Status"]);
            this._SyncTime = DataUtils.ConvertValue<DateTime?>(row["SyncTime"]);
            this._selecttextcontenthtml = DataUtils.ConvertValue<string>(row["selecttextcontenthtml"]);
            this._IsTips = DataUtils.ConvertValue<bool?>(row["IsTips"]);
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
            public readonly static Field All = new Field("*", "wx_org_process");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ID = new Field("ID", "wx_org_process", "ID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ServerID = new Field("ServerID", "wx_org_process", "ServerID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ModelId = new Field("ModelId", "wx_org_process", "ModelId");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ProcessID = new Field("ProcessID", "wx_org_process", "ProcessID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ProcessData = new Field("ProcessData", "wx_org_process", "ProcessData");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Approvers = new Field("Approvers", "wx_org_process", "Approvers");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BillNo = new Field("BillNo", "wx_org_process", "BillNo");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BillTitle = new Field("BillTitle", "wx_org_process", "BillTitle");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BillTime = new Field("BillTime", "wx_org_process", "BillTime");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BillEmpLoginName = new Field("BillEmpLoginName", "wx_org_process", "BillEmpLoginName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BillEmpName = new Field("BillEmpName", "wx_org_process", "BillEmpName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Status = new Field("Status", "wx_org_process", "Status");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SyncTime = new Field("SyncTime", "wx_org_process", "SyncTime");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field selecttextcontenthtml = new Field("selecttextcontenthtml", "wx_org_process", "selecttextcontenthtml");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsTips = new Field("IsTips", "wx_org_process", "IsTips");
        }
        #endregion
    }
}
