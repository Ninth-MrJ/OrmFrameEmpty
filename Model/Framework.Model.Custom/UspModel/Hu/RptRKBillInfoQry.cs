using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ��Ʒ����б� ����
    /// </summary>
    [Serializable]
    #region class of Model:RptRKBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a RptRKBillInfo.
    /// </summary>
    public class RptRKBillInfoQry : BaseModel
    {
         
        private string _voucherNo = String.Empty;
        private string _pNo = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private double _drugNum;
        private double _priceHighLine;
        private double _addPercent;
        private string _unitName = String.Empty;
        private double _stockPrice;
        private double _totalPrice;
        private double _retailPrice;
        private double _totalRetail;
        private string _billNo = String.Empty;
        private DateTime _operTime;
        private string _inBatchNo = String.Empty;
        private string _billId;
        private string _companyName = String.Empty;
        private string _houseName = String.Empty;
        private string _operName = String.Empty;
        private string _signName = String.Empty;
        private string _areaName = String.Empty;
        private string _manuId;
        private string _f1 = String.Empty;
        private string _f2 = String.Empty;
        private string _limitDate = String.Empty;
        private string _memo = String.Empty;

        /// <summary>
        /// ��Ʒ����б� ����
        /// </summary>
        public RptRKBillInfoQry()
        {
        }




        #region Public Properties
        /// <summary>
        /// ��Ʊ��.
        /// </summary>
        public string VoucherNo
        {
            get { return _voucherNo; }
            set { _voucherNo = value; }
        }
        /// <summary>
        /// ������ID ����bsmanufacturer
        /// </summary>
        public string ManuId
        {
            get { return _manuId; }
            set { _manuId = value; }
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
        /// ����
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        /// <summary>
        /// ���
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
        }
        /// <summary>
        /// �۸��������
        /// </summary>
        public double PriceHighLine
        {
            get { return _priceHighLine; }
            set { _priceHighLine = value; }
        }
        /// <summary>
        /// �ӳ���
        /// </summary>
        public double AddPercent
        {
            get { return _addPercent; }
            set { _addPercent = value; }
        }
        /// <summary>
        ///��λ����
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }
        /// <summary>
        /// ʵ��.
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
        }
        /// <summary>
        /// �ܽ��
        /// (ʵ��*����)
        /// </summary>
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
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
        /// �ܽ��
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }
        /// <summary>
        /// ���ݺ�.
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }
        /// <summary>
        /// .����ʱ��
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }
        /// <summary>
        /// ��ˮ��
        /// </summary>
        public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
        }
        /// <summary>
        /// ����ID
        /// </summary>
        public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }
        /// <summary>
        /// ҽҩ��˾��
        /// </summary>
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        /// <summary>
        /// ҩ����
        /// </summary>
        public string HouseName
        {
            get { return _houseName; }
            set { _houseName = value; }
        }
        /// <summary>
        /// �Ʊ���
        /// </summary>
        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string SignName
        {
            get { return _signName; }
            set { _signName = value; }
        }
        /// <summary>
        /// ��
        /// </summary>
        public string AreaName
        {
            get { return _areaName; }
            set { _areaName = value; }
        }
        public string F1
        {
            get { return _f1; }
            set { _f1 = value; }
        }
        /// <summary>
        /// ���
        /// </summary>
        public string F2
        {
            get { return _f2; }
            set { _f2 = value; }
        }
        /// <summary>
        /// ��ʽ��ע
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
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
        /// ��ĿID
        /// </summary>
        public string ItemId
        {
            get;
            set;
        }
        /// <summary>
        /// ��λID
        /// </summary>
        public string UnitId
        {
            get;
            set;
        }
        /// <summary>
        /// ҽҩ��˾Id 
        /// </summary>
        public string CompId
        {
            get;
            set;
        }
        /// <summary>
        ///�ֿ�ID
        /// </summary>
        public string HouseId
        {
            get;
            set;
        }
        /// <summary>
        /// �����ID
        /// </summary>
        public string SignOperId
        {
            get;
            set;
        } 
        #endregion
    }
    #endregion
}







