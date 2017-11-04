using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaKaApp
{
    /// <summary>
    /// 实体类wx_org_cardrecordlist。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Table("wx_org_cardrecordlist")]
    [Serializable]
    public class wx_org_cardrecordlist : Entity
    {
        #region Model
        private int _id;
        private string _userName;//中文名

        private string _UserLoginName; //登录名
        private string _userNo;
        private DateTime _dakeriqi;
        private DateTime _dakashijian;
        private string _latitude;
        private string _longitude;
        private string _zwAddress;
        private string _xcDistance;
        private int _guizeID;
        private int _isSync;
        private int _isdel;
        private int _isEff;
        private int _Company_Key;
        private string _Phone;
        private int _DaKaRule;

        /// <summary>
        /// 
        /// </summary>
        [Field("id")]
        public int id
        {
            get { return _id; }
            set
            {
                this.OnPropertyValueChange("id");
                this._id = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("userName")]
        public string userName
        {
            get { return _userName; }
            set
            {
                this.OnPropertyValueChange("userName");
                this._userName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("userNo")]
        public string userNo
        {
            get { return _userNo; }
            set
            {
                this.OnPropertyValueChange("userNo");
                this._userNo = value;
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
        [Field("dakeriqi")]
        public DateTime dakeriqi
        {
            get { return _dakeriqi; }
            set
            {
                this.OnPropertyValueChange("dakeriqi");
                this._dakeriqi = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("dakashijian")]
        public DateTime dakashijian
        {
            get { return _dakashijian; }
            set
            {
                this.OnPropertyValueChange("dakashijian");
                this._dakashijian = value;
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
        [Field("zwAddress")]
        public string zwAddress
        {
            get { return _zwAddress; }
            set
            {
                this.OnPropertyValueChange("zwAddress");
                this._zwAddress = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("xcDistance")]
        public string xcDistance
        {
            get { return _xcDistance; }
            set
            {
                this.OnPropertyValueChange("xcDistance");
                this._xcDistance = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("guizeID")]
        public int guizeID
        {
            get { return _guizeID; }
            set
            {
                this.OnPropertyValueChange("guizeID");
                this._guizeID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("isSync")]
        public int isSync
        {
            get { return _isSync; }
            set
            {
                this.OnPropertyValueChange("isSync");
                this._isSync = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("isdel")]
        public int isdel
        {
            get { return _isdel; }
            set
            {
                this.OnPropertyValueChange("isdel");
                this._isdel = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("isEff")]
        public int isEff
        {
            get { return _isEff; }
            set
            {
                this.OnPropertyValueChange("isEff");
                this._isEff = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Field("DaKaRule")]
        public int DaKaRule
        {
            get { return _DaKaRule; }
            set
            {
                this.OnPropertyValueChange("DaKaRule");
                this._DaKaRule = value;
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
				_.id,
			};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
				_.id,
				_.userName,
				_.userNo,
				_.dakeriqi,
				_.dakashijian,
				_.latitude,
				_.longitude,
				_.zwAddress,
				_.xcDistance,
				_.guizeID,
				_.isSync,
				_.isdel,
				_.isEff,
                _.Company_Key,
                _.Phone,
                _.DaKaRule,
                _.UserLoginName
            };
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
				this._id,
				this._userName,
				this._userNo,
				this._dakeriqi,
				this._dakashijian,
				this._latitude,
				this._longitude,
				this._zwAddress,
				this._xcDistance,
				this._guizeID,
				this._isSync,
				this._isdel,
				this._isEff,
                this._Company_Key,
                this._Phone,
                this._DaKaRule,
                this._UserLoginName
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
            public readonly static Field All = new Field("*", "wx_org_cardrecordlist");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field id = new Field("id", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field userName = new Field("userName", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field userNo = new Field("userNo", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field dakeriqi = new Field("dakeriqi", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field dakashijian = new Field("dakashijian", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field latitude = new Field("latitude", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field longitude = new Field("longitude", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field zwAddress = new Field("zwAddress", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field xcDistance = new Field("xcDistance", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field guizeID = new Field("guizeID", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field isSync = new Field("isSync", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field isdel = new Field("isdel", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field isEff = new Field("isEff", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Company_Key = new Field("Company_Key", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Phone = new Field("Phone", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DaKaRule = new Field("DaKaRule", "wx_org_cardrecordlist", "");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UserLoginName = new Field("UserLoginName", "wx_org_cardrecordlist", "");
        }

        #endregion
    }

}
