using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationModel
{
    /// <summary>
    /// 实体类javaandnetlogin。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("javaandnetlogin")]
    [Serializable]
    public partial class JavaAndNetLogin : Entity
    {
        #region Model
        private string _ID;
        private string _Phone;
        private DateTime _AddTime;

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
				_.Phone,
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
				this._Phone,
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
            public readonly static Field All = new Field("*", "javaandnetlogin");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ID = new Field("ID", "javaandnetlogin", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Phone = new Field("Phone", "javaandnetlogin", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field AddTime = new Field("AddTime", "javaandnetlogin", "");
        }
        #endregion
    }


}
