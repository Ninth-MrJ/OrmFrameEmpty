using System;

namespace Orm.Model
{
    /// <summary>
    ///��������
    /// </summary>
    [Serializable]
    public partial class BsDrugForm : BaseModel
    {
        private string _code;
        private string _name;
        private bool _isReject;
        private bool _isSave;
        private string _wbCode;
        private string _pyCode;
        private int _orderBy;
        private bool _isActive;
        private int _iconIndex;
        private long _iSONETotality;
        private DateTime _modiTime;
        private string _modiOperId;
        private string _yBCode;
        private string _upCode;
        private bool _isPecial;
        private bool _isTOForm;
        private bool _isNotAutoBackDrug;

        /// <summary>
        /// Ĭ�Ϲ��췽��.
        /// </summary>
        public BsDrugForm()
        {
        }

        /// <summary>
        /// ����ID.
        /// </summary>
        [Collumn(HeaderName = "���", RelatedTableType = null)]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }

        /// <summary>
        /// ����.
        /// </summary>
        [Collumn(HeaderName = "����", RelatedTableType = null)]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        /// <summary>
        /// �Ƿ�ע���.
        /// </summary>
        [Collumn(HeaderName = "�Ƿ�ע���", RelatedTableType = null)]
        public bool IsReject
        {
            get
            {
                return this._isReject;
            }
            set
            {
                this._isReject = value;
            }
        }

        /// <summary>
        /// �Ƿ��ʡ��ҩ.
        /// </summary>
        [Collumn(HeaderName = "�Ƿ��ʡ��ҩ", RelatedTableType = null)]
        public bool IsSave
        {
            get
            {
                return this._isSave;
            }
            set
            {
                this._isSave = value;
            }
        }

        /// <summary>
        /// �����.
        /// </summary>
        [Collumn(HeaderName = "�����", RelatedTableType = null)]
        public string WbCode
        {
            get
            {
                return this._wbCode;
            }
            set
            {
                this._wbCode = value;
            }
        }

        /// <summary>
        /// ƴ����.
        /// </summary>
        [Collumn(HeaderName = "ƴ����", RelatedTableType = null)]
        public string PyCode
        {
            get
            {
                return this._pyCode;
            }
            set
            {
                this._pyCode = value;
            }
        }

        /// <summary>
        /// ��ʾ˳��.
        /// </summary>
        [Collumn(HeaderName = "��ʾ˳��", RelatedTableType = null)]
        public int OrderBy
        {
            get
            {
                return this._orderBy;
            }
            set
            {
                this._orderBy = value;
            }
        }

        /// <summary>
        /// ��Ч��־.
        /// </summary>
        [Collumn(HeaderName = "��Ч��־", RelatedTableType = null)]
        public bool IsActive
        {
            get
            {
                return this._isActive;
            }
            set
            {
                this._isActive = value;
            }
        }

        /// <summary>
        /// .ͼ��
        /// </summary>
        [Collumn(HeaderName = "ͼ��", IsShow = false, RelatedTableType = null)]
        public int IconIndex
        {
            get
            {
                return this._iconIndex;
            }
            set
            {
                this._iconIndex = value;
            }
        }

        /// <summary>
        /// F4�Ƿ��Զ��շ�1��.
        /// </summary>
        [Collumn(HeaderName = "�Ƿ��Զ��շ�", RelatedTableType = null)]
        public long ISONETotality
        {
            get
            {
                return this._iSONETotality;
            }
            set
            {
                this._iSONETotality = value;
            }
        }

        /// <summary>
        /// ����޸�ʱ��.
        /// </summary>
        [Collumn(HeaderName = "ModiTime", RelatedTableType = null, IsShow = false)]
        public DateTime ModiTime
        {
            get
            {
                return this._modiTime;
            }
            set
            {
                this._modiTime = value;
            }
        }

        /// <summary>
        /// ����޸���.
        /// </summary>
        [Collumn(HeaderName = "ModiOperId", RelatedTableType = null, IsShow = false)]
        public string ModiOperId
        {
            get
            {
                return this._modiOperId;
            }
            set
            {
                this._modiOperId = value;
            }
        }

        /// <summary>
        /// ҽ����.
        /// </summary>
        [Collumn(HeaderName = "ҽ����", RelatedTableType = null)]
        public string YBCode
        {
            get
            {
                return this._yBCode;
            }
            set
            {
                this._yBCode = value;
            }
        }

        /// <summary>
        /// �ϱ���.
        /// </summary>
        [Collumn(HeaderName = "�ϱ���", RelatedTableType = null)]
        public string UpCode
        {
            get
            {
                return this._upCode;
            }
            set
            {
                this._upCode = value;
            }
        }
        public bool IsPecial
        {
            get { return _isPecial; }
            set { _isPecial = value; }
        }
        /// <summary>
        /// �Ƿ�ڷ�
        /// </summary>	
        public bool IsTOForm
        {
            get { return _isTOForm; }
            set { _isTOForm = value; }
        }

        public bool IsNotAutoBackDrug
        {
            get { return _isNotAutoBackDrug; }
            set { _isNotAutoBackDrug = value; }
        }
    }
}



