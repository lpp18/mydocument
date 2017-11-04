using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaKaApp
{
    /// <summary>
    /// 实体类wx_org_dakarule。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("wx_org_dakarule")]
    [Serializable]
    public partial class wx_org_DaKaRule : Entity
    {
        #region Model
        private int _ID;
        private string _Name;
        private string _MaxXCJL;
        private string _latitude;
        private string _longitude;
        private DateTime _AddTime;
        private int _isDelete;
        private int _Company_Key;

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
        [Field("Name")]
        public string Name
        {
            get { return _Name; }
            set
            {
                this.OnPropertyValueChange("Name");
                this._Name = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("MaxXCJL")]
        public string MaxXCJL
        {
            get { return _MaxXCJL; }
            set
            {
                this.OnPropertyValueChange("MaxXCJL");
                this._MaxXCJL = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("latitude")]
        public string latitude
        {
            get { return _latitude; }
            set
            {
                this.OnPropertyValueChange("latitude");
                this._latitude = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("longitude")]
        public string longitude
        {
            get { return _longitude; }
            set
            {
                this.OnPropertyValueChange("longitude");
                this._longitude = value;
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
				_.Name,
				_.MaxXCJL,
				_.latitude,
				_.longitude,
				_.AddTime,
				_.isDelete,
                _.Company_Key,
			};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._Name,
				this._MaxXCJL,
				this._latitude,
				this._longitude,
				this._AddTime,
				this._isDelete,
                this._Company_Key,
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
            public readonly static Field All = new Field("*", "wx_org_dakarule");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ID = new Field("ID", "wx_org_dakarule", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Name = new Field("Name", "wx_org_dakarule", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MaxXCJL = new Field("MaxXCJL", "wx_org_dakarule", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field latitude = new Field("latitude", "wx_org_dakarule", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field longitude = new Field("longitude", "wx_org_dakarule", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "wx_org_dakarule", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field isDelete = new Field("isDelete", "wx_org_dakarule", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Company_Key = new Field("Company_Key", "wx_org_dakarule", "");
        }
        #endregion
    }

}
