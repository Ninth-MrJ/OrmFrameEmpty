using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    ///���ҩƷ��Ч��Ԥ��������
    /// </summary>
    [Serializable]
    public partial class uspHuStoreExpireDateWarningQry : BaseModel
    {
        
        protected string _inBatchNo;
        protected string _code;
        protected string _name;
        protected string _spce;
        protected string _houseUnitName;
        protected string _companyName;
        protected bool _selected;
        protected string _storeDate;
        protected string _produceDate;
        protected string _limitDate;
        protected double _aheadAlert;
        protected double _stockNum;
        protected double _instoreNum;
        protected double _stockPrice;
        protected string _houseId;
        protected string _houseName;
        protected string _pNo;
        protected string _storesItemID;
        protected string _manuName;
        protected double _retailPrice;



        /// <summary>
        /// ��ˮ��
        /// </summary>
        public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
        }

        /// <summary>
        /// ����
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// ���
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// ���
        /// </summary>
        public string Spce
        {
            get { return _spce; }
            set { _spce = value; }
        }

        /// <summary>
        /// ��λ
        /// </summary>
        public string HouseUnitName
        {
            get { return _houseUnitName; }
            set { _houseUnitName = value; }
        }

        /// <summary>
        /// ҽҩ��˾����
        /// </summary>
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        /// <summary>
        /// �Ƿ�ѡ��
        /// </summary>
        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }

        /// <summary>
        /// �������
        /// </summary>
        public string StoreDate
        {
            get { return _storeDate; }
            set { _storeDate = value; }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public string ProduceDate
        {
            get { return _produceDate; }
            set { _produceDate = value; }
        }

        /// <summary>
        /// ʧЧ����
        /// </summary>
        public string LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }

        /// <summary>
        /// ʧЧ����ǰ��ʾ������.
        /// </summary>
        public double AheadAlert
        {
            get { return _aheadAlert; }
            set { _aheadAlert = value; }
        }

        /// <summary>
        /// ��浥λ��(��λ).
        /// </summary>
        public double StockNum
        {
            get { return _stockNum; }
            set { _stockNum = value; }
        }


        /// <summary>
        /// �������
        /// </summary>
        public double InstoreNum
        {
            get { return _instoreNum; }
            set { _instoreNum = value; }
        }


        /// <summary>
        /// ����(����)��.
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
        }

        /// <summary>
        /// ҩ��ID
        /// </summary>
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }

        /// <summary>
        /// ҩ������
        /// </summary>
        public string HouseName
        {
            get { return _houseName; }
            set { _houseName = value; }
        }

        /// <summary>
        /// ����
        /// </summary>
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
        }

        /// <summary>
        /// ҩƷID
        /// </summary>
        public string StoresItemID
        {
            get { return _storesItemID; }
            set { _storesItemID = value; }
        }

        /// <summary>
        /// ����������
        /// </summary>
        public string ManuName
        {
            get { return _manuName; }
            set { _manuName = value; }
        }

        /// <summary>
        /// ���ۼ�
        /// </summary>
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }
        /// <summary>
        /// ��浥λ
        /// </summary>
        public int HouseUnit { get; set; }
        /// <summary>
        /// ҽҩ��˾id
        /// </summary>
        public int CompanyId { get; set; }
        /// <summary>
        /// ������id
        /// </summary>
        public int ManuId { set; get; }
    }
}

