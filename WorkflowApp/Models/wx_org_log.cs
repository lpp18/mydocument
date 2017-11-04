using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowApp
{
    /// <summary>
    /// 实体类wx_org_log。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("wx_org_log")]
    [Serializable]
    public partial class wx_org_log : Entity
    {
        #region Model
        private string _ID;
        private string _BillNo;
        private string _ServerID;
        private string _Project;
        private string _ModelId;
        private string _ProcessID;
        private string _taskId;
        private string _UserloginNameCookie;
        private string _Processing_Code;
        private string _strApproveNote;
        private string _zhuanbanren;
        private string _huiqianren;
        private string _strXmlDoc;
        private string _Returnstate;
        private DateTime? _AddTime;

        /// <summary>
        /// 
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
        /// 
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
        /// 
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
        /// 
        /// </summary>
        [Field("Project")]
        public string Project
        {
            get { return _Project; }
            set
            {
                this.OnPropertyValueChange("Project");
                this._Project = value;
            }
        }
        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        [Field("taskId")]
        public string taskId
        {
            get { return _taskId; }
            set
            {
                this.OnPropertyValueChange("taskId");
                this._taskId = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("UserloginNameCookie")]
        public string UserloginNameCookie
        {
            get { return _UserloginNameCookie; }
            set
            {
                this.OnPropertyValueChange("UserloginNameCookie");
                this._UserloginNameCookie = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Processing_Code")]
        public string Processing_Code
        {
            get { return _Processing_Code; }
            set
            {
                this.OnPropertyValueChange("Processing_Code");
                this._Processing_Code = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("strApproveNote")]
        public string strApproveNote
        {
            get { return _strApproveNote; }
            set
            {
                this.OnPropertyValueChange("strApproveNote");
                this._strApproveNote = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("zhuanbanren")]
        public string zhuanbanren
        {
            get { return _zhuanbanren; }
            set
            {
                this.OnPropertyValueChange("zhuanbanren");
                this._zhuanbanren = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("huiqianren")]
        public string huiqianren
        {
            get { return _huiqianren; }
            set
            {
                this.OnPropertyValueChange("huiqianren");
                this._huiqianren = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("strXmlDoc")]
        public string strXmlDoc
        {
            get { return _strXmlDoc; }
            set
            {
                this.OnPropertyValueChange("strXmlDoc");
                this._strXmlDoc = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Returnstate")]
        public string Returnstate
        {
            get { return _Returnstate; }
            set
            {
                this.OnPropertyValueChange("Returnstate");
                this._Returnstate = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("AddTime")]
        public DateTime? AddTime
        {
            get { return _AddTime; }
            set
            {
                this.OnPropertyValueChange("AddTime");
                this._AddTime = value;
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
				_.BillNo,
				_.ServerID,
				_.Project,
				_.ModelId,
				_.ProcessID,
				_.taskId,
				_.UserloginNameCookie,
				_.Processing_Code,
				_.strApproveNote,
				_.zhuanbanren,
				_.huiqianren,
				_.strXmlDoc,
				_.Returnstate,
				_.AddTime,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._BillNo,
				this._ServerID,
				this._Project,
				this._ModelId,
				this._ProcessID,
				this._taskId,
				this._UserloginNameCookie,
				this._Processing_Code,
				this._strApproveNote,
				this._zhuanbanren,
				this._huiqianren,
				this._strXmlDoc,
				this._Returnstate,
				this._AddTime,
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
            public readonly static Field All = new Field("*", "wx_org_log");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ID = new Field("ID", "wx_org_log", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BillNo = new Field("BillNo", "wx_org_log", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ServerID = new Field("ServerID", "wx_org_log", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Project = new Field("Project", "wx_org_log", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ModelId = new Field("ModelId", "wx_org_log", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ProcessID = new Field("ProcessID", "wx_org_log", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field taskId = new Field("taskId", "wx_org_log", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UserloginNameCookie = new Field("UserloginNameCookie", "wx_org_log", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Processing_Code = new Field("Processing_Code", "wx_org_log", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field strApproveNote = new Field("strApproveNote", "wx_org_log", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field zhuanbanren = new Field("zhuanbanren", "wx_org_log", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field huiqianren = new Field("huiqianren", "wx_org_log", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field strXmlDoc = new Field("strXmlDoc", "wx_org_log", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Returnstate = new Field("Returnstate", "wx_org_log", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "wx_org_log", "");
        }
        #endregion
    }

}
