using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptApplication
{
    /// <summary>
	/// 实体类users 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
    public class users : Entity
    {
        public users() : base("users") { }

        #region Model
        private int _id;
        private string _UserName;
        private string _UserLoginName;
        private string _Tel;
        private DateTime? _CreateTime;
        private string _LastUpdateTime;
        private int? _IsDelete;
        /// <summary>
        /// auto_increment
        /// </summary>
        public int id
        {
            get { return _id; }
            set
            {
                this.OnPropertyValueChange(_.id, _id, value);
                this._id = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            get { return _UserName; }
            set
            {
                this.OnPropertyValueChange(_.UserName, _UserName, value);
                this._UserName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserLoginName
        {
            get { return _UserLoginName; }
            set
            {
                this.OnPropertyValueChange(_.UserLoginName, _UserLoginName, value);
                this._UserLoginName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Tel
        {
            get { return _Tel; }
            set
            {
                this.OnPropertyValueChange(_.Tel, _Tel, value);
                this._Tel = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateTime
        {
            get { return _CreateTime; }
            set
            {
                this.OnPropertyValueChange(_.CreateTime, _CreateTime, value);
                this._CreateTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string LastUpdateTime
        {
            get { return _LastUpdateTime; }
            set
            {
                this.OnPropertyValueChange(_.LastUpdateTime, _LastUpdateTime, value);
                this._LastUpdateTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? IsDelete
        {
            get { return _IsDelete; }
            set
            {
                this.OnPropertyValueChange(_.IsDelete, _IsDelete, value);
                this._IsDelete = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的标识列
        /// </summary>
        public override Field GetIdentityField()
        {
            return _.id;
        }
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                _.id};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.id,
                _.UserName,
                _.UserLoginName,
                _.Tel,
                _.CreateTime,
                _.LastUpdateTime,
                _.IsDelete};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._id,
                this._UserName,
                this._UserLoginName,
                this._Tel,
                this._CreateTime,
                this._LastUpdateTime,
                this._IsDelete};
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._id = DataUtils.ConvertValue<int>(reader["id"]);
            this._UserName = DataUtils.ConvertValue<string>(reader["UserName"]);
            this._UserLoginName = DataUtils.ConvertValue<string>(reader["UserLoginName"]);
            this._Tel = DataUtils.ConvertValue<string>(reader["Tel"]);
            this._CreateTime = DataUtils.ConvertValue<DateTime?>(reader["CreateTime"]);
            this._LastUpdateTime = DataUtils.ConvertValue<string>(reader["LastUpdateTime"]);
            this._IsDelete = DataUtils.ConvertValue<int?>(reader["IsDelete"]);
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._id = DataUtils.ConvertValue<int>(row["id"]);
            this._UserName = DataUtils.ConvertValue<string>(row["UserName"]);
            this._UserLoginName = DataUtils.ConvertValue<string>(row["UserLoginName"]);
            this._Tel = DataUtils.ConvertValue<string>(row["Tel"]);
            this._CreateTime = DataUtils.ConvertValue<DateTime?>(row["CreateTime"]);
            this._LastUpdateTime = DataUtils.ConvertValue<string>(row["LastUpdateTime"]);
            this._IsDelete = DataUtils.ConvertValue<int?>(row["IsDelete"]);
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
            public readonly static Field All = new Field("*", "users");
            /// <summary>
            /// auto_increment
            /// </summary>
            public readonly static Field id = new Field("id", "users", "auto_increment");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UserName = new Field("UserName", "users", "UserName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UserLoginName = new Field("UserLoginName", "users", "UserLoginName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Tel = new Field("Tel", "users", "Tel");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CreateTime = new Field("CreateTime", "users", "CreateTime");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field LastUpdateTime = new Field("LastUpdateTime", "users", "LastUpdateTime");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsDelete = new Field("IsDelete", "users", "IsDelete");
        }
        #endregion


    }


}
