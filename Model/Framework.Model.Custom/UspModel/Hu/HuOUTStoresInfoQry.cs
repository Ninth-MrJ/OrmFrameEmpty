using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// �����¼
    /// </summary>
    [Serializable]
    #region class of Model:HuOUTStoresInfoQry
    /// <summary>
    /// This object represents the properties and methods of a HuOUTStoresInfo.
    /// </summary>
    public class HuOUTStoresInfoQry : BaseModel
    {
         
        private string _inBatchNo = String.Empty;
        private string _houseId;
        private string _itemId;
        private string _pNo = String.Empty;
        private string _unitId;
        private string _compId;
        private double _stockNum;
        private double _instoreNum;
        private double _stockPrice;
        private double _retailPrice;
        private DateTime _storeDate;
        private DateTime _produceDate;
        private DateTime _limitDate;
        private bool _isBalance;
        private bool _isNewin;
        private bool _isBid;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private string _unitName = String.Empty;
        private double _totalPrice;
        private double _totalRetail;

        /// <summary>
        /// �����¼
        /// </summary>
        public HuOUTStoresInfoQry()
        {
        }



        #region Public Properties
        /// <summary>
        /// ����¼(��ˮ��)
        /// </summary>
            public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
        }
        /// <summary>
        /// ҩ��ID(�ֿ�ID)
        /// </summary>
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }
        /// <summary>
        /// ҩƷID
        /// </summary>
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        /// <summary>
        /// ����¼����
        /// </summary>
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
        }
        /// <summary>
        /// ����¼��λID
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }
        /// <summary>
        /// ����¼ҽҩ��˾ID
        /// </summary>
        public string CompId
        {
            get { return _compId; }
            set { _compId = value; }
        }
        /// <summary>
        /// ����¼��浥λ��(��λ).
        /// </summary>
        public double StockNum
        {
            get { return _stockNum; }
            set { _stockNum = value; }
        }
        /// <summary>
        /// �������.
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
        /// ���ۼ�.
        /// </summary>
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }
        /// <summary>
        ///�������
        /// </summary>
        public DateTime StoreDate
        {
            get { return _storeDate; }
            set { _storeDate = value; }
        }
        /// <summary>
        /// ��������.
        /// </summary>
        public DateTime ProduceDate
        {
            get { return _produceDate; }
            set { _produceDate = value; }
        }
        /// <summary>
        /// ʧ������.
        /// </summary>
        public DateTime LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }
        /// <summary>
        /// ���.
        /// </summary>
        public bool IsBalance
        {
            get { return _isBalance; }
            set { _isBalance = value; }
        }
        /// <summary>
        /// �Ƿ������.
        /// </summary>
        public bool IsNewin
        {
            get { return _isNewin; }
            set { _isNewin = value; }
        }
        /// <summary>
        /// �Ƿ��б�.
        /// </summary>
        public bool IsBid
        {
            get { return _isBid; }
            set { _isBid = value; }
        }
        /// <summary>
        /// ����.
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }
        /// <summary>
        /// ���.
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        /// <summary>
        /// ���.
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }
        /// <summary>
        /// ����������.
        /// </summary>
        public string ManufactureryName
        {
            get { return _manufactureryName; }
            set { _manufactureryName = value; }
        }
        /// <summary>
        /// ��λ.
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }
        /// <summary>
        /// ����(����)���
        /// ����(����)��*��浥λ��(��λ).
        /// </summary>
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
        /// <summary>
        /// ���۽��
        /// ���ۼ�*��浥λ��(��λ).
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }
        #endregion
    }
    #endregion
}







