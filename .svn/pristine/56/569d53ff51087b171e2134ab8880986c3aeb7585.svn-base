using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowApp
{
    /// <summary>
    /// 实体类WX_ORG_SmsCodeTemporary 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class WX_ORG_SmsCodeTemporary : Entity
    {
        public WX_ORG_SmsCodeTemporary() : base("wx_org_smscodetemporary") { }

        #region Model
        private string _ID;
        private string _Phone;
        private string _Smstext;
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
        public string Phone
        {
            get { return _Phone; }
            set
            {
                this.OnPropertyValueChange(_.Phone, _Phone, value);
                this._Phone = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Smstext
        {
            get { return _Smstext; }
            set
            {
                this.OnPropertyValueChange(_.Smstext, _Smstext, value);
                this._Smstext = value;
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
				_.Phone,
				_.Smstext};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._Phone,
				this._Smstext};
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._ID = DataUtils.ConvertValue<string>(reader["ID"]);
            this._Phone = DataUtils.ConvertValue<string>(reader["Phone"]);
            this._Smstext = DataUtils.ConvertValue<string>(reader["Smstext"]);
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._ID = DataUtils.ConvertValue<string>(row["ID"]);
            this._Phone = DataUtils.ConvertValue<string>(row["Phone"]);
            this._Smstext = DataUtils.ConvertValue<string>(row["Smstext"]);
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
            public readonly static Field All = new Field("*", "wx_org_smscodetemporary");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ID = new Field("ID", "wx_org_smscodetemporary", "ID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Phone = new Field("Phone", "wx_org_smscodetemporary", "Phone");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Smstext = new Field("Smstext", "wx_org_smscodetemporary", "Smstext");
        }
        #endregion


    }

}
