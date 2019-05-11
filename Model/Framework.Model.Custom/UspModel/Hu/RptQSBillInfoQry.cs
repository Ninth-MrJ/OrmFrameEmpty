using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ���� �ɹ��ƻ��б�
    /// </summary>
    [Serializable]
    #region class of Model:RptQSBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a RptQSBillInfo.
    /// </summary>
    public class RptQSBillInfoQry : BaseModel
    {
         
        private string _billId;
        private string _billNo = String.Empty;
        private DateTime _applyTime;
        private DateTime _valideTime;
        private string _applyIdea = String.Empty;
        private string _applyHander = String.Empty;
        private DateTime _operTime;
        private string  _unitId;
        private double _drugNum;
        private double _stockPrice;
        private double _retailPrice;
        private string _unitName = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private double _totalPrice;
        private double _totalRetail;
        private double _stockNum;
        private string _houseName = String.Empty;
        private string _userName = String.Empty;
        private string _companyName = String.Empty;
        private string _manufacturerName = String.Empty;
        private DateTime _orderByTime; //����ʱ��

        /// <summary>
        /// ���� �ɹ��ƻ��б�
        /// </summary>
        public RptQSBillInfoQry()
        {
        }


        #region Public Properties
        /// <summary>
        /// �ɹ��ƻ���ID
        /// </summary>
         public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }

        /// <summary>
        /// �ɹ����ݺ�
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime ApplyTime
        {
            get { return _applyTime; }
            set { _applyTime = value; }
        }
        /// <summary>
        /// ��Ч����
        /// </summary>
        public DateTime ValideTime
        {
            get { return _valideTime; }
            set { _valideTime = value; }
        }
        /// <summary>
        /// �������
        /// </summary>
        public string ApplyIdea
        {
            get { return _applyIdea; }
            set { _applyIdea = value; }
        }
  
        /// <summary>
        /// ������
        /// </summary>
        public string ApplyHander
        {
            get { return _applyHander; }
            set { _applyHander = value; }
        }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
        }
        /// <summary>
        /// ��λID
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
        }

        /// <summary>
        /// �ɹ�����
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
        }
        /// <summary>
        /// �ɹ���
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
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
        /// ��λ��
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
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
        /// ��Ŀ���
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
        /// �ɹ����
        /// (�ɹ���*�ɹ�����)
        /// </summary>
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
        /// <summary>
        /// ���۽��
        /// (���ۼ�*�ɹ�����)
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }
        /// <summary>
        /// ��浥λ��(��λ)
        /// </summary>
        public double StockNum
        {
            get { return _stockNum; }
            set { _stockNum = value; }
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
        /// �û�����
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
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
        /// �����̳���
        /// </summary>
        public string ManufacturerName
        {
            get { return _manufacturerName; }
            set { _manufacturerName = value; }
        }
        /// <summary>
        /// ҽҩ��˾ID
        /// </summary>
        public int CompId
        {
            get;
            set; 
        }
        /// <summary>
        /// ��ĿID
        /// </summary>
        public string ItemId { get ; set; }

        /// <summary>
        /// �ֿ�ID
        /// </summary>
        public int HouseId
        {
            get;
            set;
        }
        /// <summary>
        /// ������ID
        /// </summary>
        public int OperId
        {
            get;
            set;
        }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime OrderByTime
        {
            get { return _orderByTime; }
            set { _orderByTime = value; }
        }
        #endregion
    }
    #endregion
}







