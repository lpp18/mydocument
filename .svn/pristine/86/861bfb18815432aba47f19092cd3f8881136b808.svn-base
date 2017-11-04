using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaKaApp
{
    /// <summary>
    /// 实体类wx_org_dkrulemx。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("wx_org_dkrulemx")]
    [Serializable]
    public partial class wx_org_DKruleMX : Entity
    {
        #region Model
        private int _ID;
        private string _UserName;
        private int _DKRule;
        private DateTime _AddTime;
        private int _isDelete;
        private int _Company_Key;
        private string _Phone;
        private string _UserLoginName;

        /// <summary>
        /// 
        /// </summary>
        [Field("ID")]
        public int ID
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
        [Field("Phone")]
        public string Phone
        {
            get { return _Phone; }
            set
            {
                this.OnPropertyValueChange("Phone");
                this._Phone = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Field("UserName")]
        public string UserName
        {
            get { return _UserName; }
            set
            {
                this.OnPropertyValueChange("UserName");
                this._UserName = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Field("DKRule")]
        public int DKRule
        {
            get { return _DKRule; }
            set
            {
                this.OnPropertyValueChange("DKRule");
                this._DKRule = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("AddTime")]
        public DateTime AddTime
        {
            get { return _AddTime; }
            set
            {
                this.OnPropertyValueChange("AddTime");
                this._AddTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("isDelete")]
        public int isDelete
        {
            get { return _isDelete; }
            set
            {
                this.OnPropertyValueChange("isDelete");
                this._isDelete = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("Company_Key")]
        public int Company_Key
        {
            get { return _Company_Key; }
            set
            {
                this.OnPropertyValueChange("Company_Key");
                this._Company_Key = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Field("UserLoginName")]
        public string UserLoginName
        {
            get { return _UserLoginName; }
            set
            {
                this.OnPropertyValueChange("UserLoginName");
                this._UserLoginName = value;
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
				_.UserName,
				_.DKRule,
				_.AddTime,
				_.isDelete,
                _.Company_Key,
                _.Phone,
                _.UserLoginName
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._UserName,
				this._DKRule,
				this._AddTime,
				this._isDelete,
                this._Company_Key,
                this._Phone,
                this._UserLoginName,
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
            public readonly static Field All = new Field("*", "wx_org_dkrulemx");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ID = new Field("ID", "wx_org_dkrulemx", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UserName = new Field("UserName", "wx_org_dkrulemx", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DKRule = new Field("DKRule", "wx_org_dkrulemx", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "wx_org_dkrulemx", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field isDelete = new Field("isDelete", "wx_org_dkrulemx", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Company_Key = new Field("Company_Key", "wx_org_dkrulemx", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Phone = new Field("Phone", "wx_org_dkrulemx", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UserLoginName = new Field("UserLoginName", "wx_org_dkrulemx", "");
        }
        #endregion
    }

}
