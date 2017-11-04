using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace RCSApplication.Models
{
    /// <summary>
    /// 实体类receiptinfo 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class receiptinfo : Entity
    {
        public receiptinfo() : base("receiptinfo") { }

        #region Model
        private int _id;
        private string _CompanyName;
        private string _DutyParagraph;
        private string _Address;
        private string _Tel;
        private string _BankOfDeposit;
        private string _BankAccount;
        private string _QRCode;
        private string _Creator;
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
        public string CompanyName
        {
            get { return _CompanyName; }
            set
            {
                this.OnPropertyValueChange(_.CompanyName, _CompanyName, value);
                this._CompanyName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DutyParagraph
        {
            get { return _DutyParagraph; }
            set
            {
                this.OnPropertyValueChange(_.DutyParagraph, _DutyParagraph, value);
                this._DutyParagraph = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            get { return _Address; }
            set
            {
                this.OnPropertyValueChange(_.Address, _Address, value);
                this._Address = value;
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
        public string BankOfDeposit
        {
            get { return _BankOfDeposit; }
            set
            {
                this.OnPropertyValueChange(_.BankOfDeposit, _BankOfDeposit, value);
                this._BankOfDeposit = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BankAccount
        {
            get { return _BankAccount; }
            set
            {
                this.OnPropertyValueChange(_.BankAccount, _BankAccount, value);
                this._BankAccount = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QRCode
        {
            get { return _QRCode; }
            set
            {
                this.OnPropertyValueChange(_.QRCode, _QRCode, value);
                this._QRCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Creator
        {
            get { return _Creator; }
            set
            {
                this.OnPropertyValueChange(_.Creator, _Creator, value);
                this._Creator = value;
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
                _.CompanyName,
                _.DutyParagraph,
                _.Address,
                _.Tel,
                _.BankOfDeposit,
                _.BankAccount,
                _.QRCode,
                _.Creator,
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
                this._CompanyName,
                this._DutyParagraph,
                this._Address,
                this._Tel,
                this._BankOfDeposit,
                this._BankAccount,
                this._QRCode,
                this._Creator,
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
            this._CompanyName = DataUtils.ConvertValue<string>(reader["CompanyName"]);
            this._DutyParagraph = DataUtils.ConvertValue<string>(reader["DutyParagraph"]);
            this._Address = DataUtils.ConvertValue<string>(reader["Address"]);
            this._Tel = DataUtils.ConvertValue<string>(reader["Tel"]);
            this._BankOfDeposit = DataUtils.ConvertValue<string>(reader["BankOfDeposit"]);
            this._BankAccount = DataUtils.ConvertValue<string>(reader["BankAccount"]);
            this._QRCode = DataUtils.ConvertValue<string>(reader["QRCode"]);
            this._Creator = DataUtils.ConvertValue<string>(reader["Creator"]);
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
            this._CompanyName = DataUtils.ConvertValue<string>(row["CompanyName"]);
            this._DutyParagraph = DataUtils.ConvertValue<string>(row["DutyParagraph"]);
            this._Address = DataUtils.ConvertValue<string>(row["Address"]);
            this._Tel = DataUtils.ConvertValue<string>(row["Tel"]);
            this._BankOfDeposit = DataUtils.ConvertValue<string>(row["BankOfDeposit"]);
            this._BankAccount = DataUtils.ConvertValue<string>(row["BankAccount"]);
            this._QRCode = DataUtils.ConvertValue<string>(row["QRCode"]);
            this._Creator = DataUtils.ConvertValue<string>(row["Creator"]);
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
            public readonly static Field All = new Field("*", "receiptinfo");
            /// <summary>
            /// auto_increment
            /// </summary>
            public readonly static Field id = new Field("id", "receiptinfo", "auto_increment");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CompanyName = new Field("CompanyName", "receiptinfo", "CompanyName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DutyParagraph = new Field("DutyParagraph", "receiptinfo", "DutyParagraph");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Address = new Field("Address", "receiptinfo", "Address");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Tel = new Field("Tel", "receiptinfo", "Tel");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BankOfDeposit = new Field("BankOfDeposit", "receiptinfo", "BankOfDeposit");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BankAccount = new Field("BankAccount", "receiptinfo", "BankAccount");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field QRCode = new Field("QRCode", "receiptinfo", "QRCode");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Creator = new Field("Creator", "receiptinfo", "Creator");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CreateTime = new Field("CreateTime", "receiptinfo", "CreateTime");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field LastUpdateTime = new Field("LastUpdateTime", "receiptinfo", "LastUpdateTime");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsDelete = new Field("IsDelete", "receiptinfo", "IsDelete");
        }
        #endregion


    }
}