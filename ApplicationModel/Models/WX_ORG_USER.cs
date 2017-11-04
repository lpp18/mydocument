using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationModel
{
    /// <summary>
    /// 实体类WX_ORG_USER 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class WX_ORG_USER : Entity
    {
        public WX_ORG_USER() : base("wx_org_user") { }

        #region Model
        private string _ID;
        private string _Name;
        private string _UserNo;
        private string _Cellphone;
        private string _TelephoneNumber;
        private string _EmailAddress;
        private string _Company;
        private string _DeptName_1;
        private string _DeptName_2;
        private string _DeptName_3;
        private string _Department;
        private string _Position;
        private int _isuse;
        private DateTime _indate;
        private string _DeptName_4;
        private string _UserLoginName;
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
        public string Name
        {
            get { return _Name; }
            set
            {
                this.OnPropertyValueChange(_.Name, _Name, value);
                this._Name = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserNo
        {
            get { return _UserNo; }
            set
            {
                this.OnPropertyValueChange(_.UserNo, _UserNo, value);
                this._UserNo = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Cellphone
        {
            get { return _Cellphone; }
            set
            {
                this.OnPropertyValueChange(_.Cellphone, _Cellphone, value);
                this._Cellphone = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TelephoneNumber
        {
            get { return _TelephoneNumber; }
            set
            {
                this.OnPropertyValueChange(_.TelephoneNumber, _TelephoneNumber, value);
                this._TelephoneNumber = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EmailAddress
        {
            get { return _EmailAddress; }
            set
            {
                this.OnPropertyValueChange(_.EmailAddress, _EmailAddress, value);
                this._EmailAddress = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Company
        {
            get { return _Company; }
            set
            {
                this.OnPropertyValueChange(_.Company, _Company, value);
                this._Company = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DeptName_1
        {
            get { return _DeptName_1; }
            set
            {
                this.OnPropertyValueChange(_.DeptName_1, _DeptName_1, value);
                this._DeptName_1 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DeptName_2
        {
            get { return _DeptName_2; }
            set
            {
                this.OnPropertyValueChange(_.DeptName_2, _DeptName_2, value);
                this._DeptName_2 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DeptName_3
        {
            get { return _DeptName_3; }
            set
            {
                this.OnPropertyValueChange(_.DeptName_3, _DeptName_3, value);
                this._DeptName_3 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Department
        {
            get { return _Department; }
            set
            {
                this.OnPropertyValueChange(_.Department, _Department, value);
                this._Department = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Position
        {
            get { return _Position; }
            set
            {
                this.OnPropertyValueChange(_.Position, _Position, value);
                this._Position = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int isuse
        {
            get { return _isuse; }
            set
            {
                this.OnPropertyValueChange(_.isuse, _isuse, value);
                this._isuse = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime indate
        {
            get { return _indate; }
            set
            {
                this.OnPropertyValueChange(_.indate, _indate, value);
                this._indate = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DeptName_4
        {
            get { return _DeptName_4; }
            set
            {
                this.OnPropertyValueChange(_.DeptName_4, _DeptName_4, value);
                this._DeptName_4 = value;
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
				_.Name,
				_.UserNo,
				_.Cellphone,
				_.TelephoneNumber,
				_.EmailAddress,
				_.Company,
				_.DeptName_1,
				_.DeptName_2,
				_.DeptName_3,
				_.Department,
				_.Position,
				_.isuse,
				_.indate,
				_.DeptName_4,
				_.UserLoginName};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._ID,
				this._Name,
				this._UserNo,
				this._Cellphone,
				this._TelephoneNumber,
				this._EmailAddress,
				this._Company,
				this._DeptName_1,
				this._DeptName_2,
				this._DeptName_3,
				this._Department,
				this._Position,
				this._isuse,
				this._indate,
				this._DeptName_4,
				this._UserLoginName};
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._ID = DataUtils.ConvertValue<string>(reader["ID"]);
            this._Name = DataUtils.ConvertValue<string>(reader["Name"]);
            this._UserNo = DataUtils.ConvertValue<string>(reader["UserNo"]);
            this._Cellphone = DataUtils.ConvertValue<string>(reader["Cellphone"]);
            this._TelephoneNumber = DataUtils.ConvertValue<string>(reader["TelephoneNumber"]);
            this._EmailAddress = DataUtils.ConvertValue<string>(reader["EmailAddress"]);
            this._Company = DataUtils.ConvertValue<string>(reader["Company"]);
            this._DeptName_1 = DataUtils.ConvertValue<string>(reader["DeptName_1"]);
            this._DeptName_2 = DataUtils.ConvertValue<string>(reader["DeptName_2"]);
            this._DeptName_3 = DataUtils.ConvertValue<string>(reader["DeptName_3"]);
            this._Department = DataUtils.ConvertValue<string>(reader["Department"]);
            this._Position = DataUtils.ConvertValue<string>(reader["Position"]);
            this._isuse = DataUtils.ConvertValue<int>(reader["isuse"]);
            this._indate = DataUtils.ConvertValue<DateTime>(reader["indate"]);
            this._DeptName_4 = DataUtils.ConvertValue<string>(reader["DeptName_4"]);
            this._UserLoginName = DataUtils.ConvertValue<string>(reader["UserLoginName"]);
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._ID = DataUtils.ConvertValue<string>(row["ID"]);
            this._Name = DataUtils.ConvertValue<string>(row["Name"]);
            this._UserNo = DataUtils.ConvertValue<string>(row["UserNo"]);
            this._Cellphone = DataUtils.ConvertValue<string>(row["Cellphone"]);
            this._TelephoneNumber = DataUtils.ConvertValue<string>(row["TelephoneNumber"]);
            this._EmailAddress = DataUtils.ConvertValue<string>(row["EmailAddress"]);
            this._Company = DataUtils.ConvertValue<string>(row["Company"]);
            this._DeptName_1 = DataUtils.ConvertValue<string>(row["DeptName_1"]);
            this._DeptName_2 = DataUtils.ConvertValue<string>(row["DeptName_2"]);
            this._DeptName_3 = DataUtils.ConvertValue<string>(row["DeptName_3"]);
            this._Department = DataUtils.ConvertValue<string>(row["Department"]);
            this._Position = DataUtils.ConvertValue<string>(row["Position"]);
            this._isuse = DataUtils.ConvertValue<int>(row["isuse"]);
            this._indate = DataUtils.ConvertValue<DateTime>(row["indate"]);
            this._DeptName_4 = DataUtils.ConvertValue<string>(row["DeptName_4"]);
            this._UserLoginName = DataUtils.ConvertValue<string>(row["UserLoginName"]);
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
            public readonly static Field All = new Field("*", "wx_org_user");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ID = new Field("ID", "wx_org_user", "ID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Name = new Field("Name", "wx_org_user", "Name");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UserNo = new Field("UserNo", "wx_org_user", "UserNo");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Cellphone = new Field("Cellphone", "wx_org_user", "Cellphone");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TelephoneNumber = new Field("TelephoneNumber", "wx_org_user", "TelephoneNumber");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field EmailAddress = new Field("EmailAddress", "wx_org_user", "EmailAddress");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Company = new Field("Company", "wx_org_user", "Company");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DeptName_1 = new Field("DeptName_1", "wx_org_user", "DeptName_1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DeptName_2 = new Field("DeptName_2", "wx_org_user", "DeptName_2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DeptName_3 = new Field("DeptName_3", "wx_org_user", "DeptName_3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Department = new Field("Department", "wx_org_user", "Department");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Position = new Field("Position", "wx_org_user", "Position");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field isuse = new Field("isuse", "wx_org_user", "isuse");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field indate = new Field("indate", "wx_org_user", "indate");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DeptName_4 = new Field("DeptName_4", "wx_org_user", "DeptName_4");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UserLoginName = new Field("UserLoginName", "wx_org_user", "UserLoginName");
        }
        #endregion





    }


}
