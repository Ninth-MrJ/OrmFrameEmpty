using System;

namespace Orm.Model.Custom
{


    /// <summary>
    /// �������
    /// </summary>
    [Serializable]
    public partial class uspBsPatient:BaseModel{
        
                
        private string _cardNo = string.Empty;
        private string _name = string.Empty;
        private string _sex = string.Empty;        
        private DateTime _birthDate;        
        private string _company = string.Empty;
        private string _occupation = string.Empty;
        private string _mobile = string.Empty;
        private string _email = string.Empty;
        private string _phone = string.Empty;        
        private string _idCardNo = string.Empty;       
        private string _phoneHome = string.Empty;        
        private string _ageString = string.Empty; 
        private string _webusercode = string.Empty;
        private string _medicareNo = string.Empty;
        private string _personHistory = string.Empty;
        private string _sensitive = string.Empty;
        private string _doctorName = string.Empty;
        private string _doctorName1 = string.Empty;
        private string _linkmanName = string.Empty;
        private string _linkmanPhone = string.Empty;
        private string _hospitalizationTimes;

        /// <summary>
        /// ���סԺ������ת�ﲡ��
        /// </summary>
        public string HospitalizationTimes
        {
            get { return _hospitalizationTimes; }
            set { _hospitalizationTimes = value; }
        }
        /// <summary>
        /// Ĭ�Ϲ��췽��.
        /// </summary>
        public uspBsPatient()
        {
            //SetStringValue();
        }        

        /// <summary>
        /// ��ͥ�绰
        /// </summary>
        public string PhoneHome
        {
            get { return this._phoneHome; }
            set { this._phoneHome = value; }
        }
           
        
        /// <summary>
        /// ����.
        /// </summary>
        public string CardNo
        {
            get
            {
                return this._cardNo;
            }
            set
            {
                this._cardNo=value;
            }
        }        
        
        /// <summary>
        /// ��������.
        /// </summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name=value;
            }
        }        
        
        /// <summary>
        /// �����Ա�
        /// </summary>
        public string Sex
        {
            get
            {
                return this._sex;
            }
            set
            {
                this._sex=value;
            }
        }        
        
        /// <summary>
        /// ����.
        /// </summary>
        public DateTime BirthDate
        {
            get
            {
                return this._birthDate;
            }
            set
            {
                this._birthDate=value;
            }
        }        
       
        
       
         
        /// <summary>
        /// ��ͥ��ַ.
        /// </summary>
        public string Address
        {
            get;
            set;
        }        
        
              
        
        /// <summary>
        /// ������λ.
        /// </summary>
        public string Company
        {
            get
            {
                if (_company == null)
                {
                    _company = " ";
                }
                return this._company;
            }
            set
            {
                this._company=value;
            }
        }        
        
        /// <summary>
        /// ְ��.
        /// </summary>
        public string Occupation
        {
            get
            {
                if (_occupation == null)
                {
                    _occupation = " ";
                }
                return this._occupation;
            }
            set
            {
                this._occupation=value;
            }
        }        
        
        /// <summary>
        /// �ֻ�����.
        /// </summary>
        public string Mobile
        {
            get
            {
                if (_mobile == null)
                {
                    _mobile = " ";
                }
                return this._mobile;
            }
            set
            {
                this._mobile=value;
            }
        }

        /// <summary>
        /// �绰����.
        /// </summary>
        public string Phone
        {
            get
            {
                if (_phone == null)
                {
                    _phone = " ";
                }
                return this._phone;
            }
            set
            {
                this._phone = value;
            }
        } 
        
        /// <summary>
        /// ��������.
        /// </summary>
        public string Email
        {
            get
            {
                if (_email == null)
                {
                    _email = " ";
                }
                return this._email;
            }
            set
            {
                this._email=value;
            }
        }        
         
        
        
        
       
        
        /// <summary>
        /// ֤������
        /// </summary>
        public string CertificateCardType
        {
            get;
            set;
        }         
        
        
        /// <summary>
        /// ���֤��.
        /// </summary>
        public string IdCardNo
        {
            get
            {
                if (_idCardNo == null)
                {
                    _idCardNo = " ";
                }
                return this._idCardNo;
            }
            set
            {
                this._idCardNo=value;
            }
        }        
        
        
        /// <summary>
        /// ҽ��֤��/ҽ����.
        /// </summary>
        public string MedicareNo
        {
            get
            {
                if (_medicareNo == null)
                {
                    _medicareNo = " ";
                }
                return this._medicareNo;
            }
            set
            {
                this._medicareNo=value;
            }
        }          
         
       
        /// <summary>
        /// ����ʷ.
        /// </summary>
        public string PersonHistory
        {
            get
            {
                if (_personHistory == null)
                {
                    _personHistory = " ";
                }
                return this._personHistory;
            }
            set
            {
                this._personHistory=value;
            }
        }
        /// <summary>
        /// ����ҩ��
        /// </summary>
        public string Sensitive
        {
            get {
                if (_sensitive == null)
                {
                    _sensitive = " ";                    
                }
                return this._sensitive;
            }
            set { this._sensitive = value; }
        }
        /// <summary>
        /// �����ַ���.
        /// </summary>
        public string AgeString
        {
            get
            {
                if (_ageString == null)
                {
                    _ageString = " ";
                }
                return this._ageString;
            }
            set
            {
                this._ageString=value;
            }
        }

        /// <summary>
        /// ��ͥסַ
        /// </summary>
        public string HomeAddress { get; set; }

        

        /// <summary>
        /// ��Ƭ
        /// </summary>
        public byte[] PatientPhoto { get; set; } 

        /// <summary>
        /// ��վƽ̨�Ĳ���Ψһ��
        /// </summary>
        public string WebUserCode
        {
            get
            { 
                return this._webusercode;
            }
            set
            {
                this._webusercode = value;
            }
        }

        /// <summary>
        /// ѧУ
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// ��ͥ����
        /// </summary>
        public string FamilyBackGround { get; set; }

        /// <summary>
        /// ��Ȥ����
        /// </summary>
        public string Hobby { get; set; }

        /// <summary>
        /// ΢�ź�
        /// </summary>
        public string WeChatNo { get; set; }

        /// <summary>
        /// ������Դ
        /// </summary>
        public string PatientSource { get; set; }

        /// <summary>
        /// ����ҽ��
        /// </summary>
        public string DoctorName
        {
            get
            {
                return this._doctorName;
            }
            set
            {
                this._doctorName = value;
            }
        }


        /// <summary>
        /// ת��ҽ��
        /// </summary>
        public string DoctorName1
        {
            get
            {
                return this._doctorName1;
            }
            set
            {
                this._doctorName1 = value;
            }
        }

        /// <summary>
        /// ����״��
        /// </summary>
        public string HealthCondition { get; set; }

        /// <summary>
        /// ����Ƿ��
        /// </summary>
        public double CurrentArrears { get; set; }

        /// <summary>
        /// �ֻ��绰
        /// </summary>
        public string MobileOrPhone { get; set; }
        /// <summary>
        /// �Ƿ��Ա
        /// </summary>
        public bool IsVip { get; set; } 

        /// <summary>
        /// ��Ա����
        /// </summary>
        public string VipCardNo
        {
            get;
            set;
        }
        /// <summary>
        /// ��ԱID
        /// </summary>
        public string  VipCardID
        {
            get;
            set;
        }
        /// <summary>
        /// ��Ա�ȼ�
        /// </summary>
        public string VipLevel
        {
            get;
            set;
        }

        /// <summary>
        /// ��ϵ�˵ĵ绰.
        /// </summary>
        public string LinkmanPhone
        {
            get
            {
                if (_linkmanPhone == null)
                {
                    _linkmanPhone = " ";
                }
                return this._linkmanPhone;
            }
            set
            {
                this._linkmanPhone = value;
            }
        }

        /// <summary>
        /// ��ϵ��.
        /// </summary>
        public string LinkmanName
        {
            get
            {
                if (_linkmanName == null)
                {
                    _linkmanName = " ";
                }
                return this._linkmanName;
            }
            set
            {
                this._linkmanName = value;
            }
        }
        /// <summary>
        /// ������ID
        /// 
        /// </summary>
        public string  IntroduceUserId { get; set; }

        /// <summary>
        /// ����������
        /// </summary>
        public string IntroduceUserName { get; set; }
    }
}



