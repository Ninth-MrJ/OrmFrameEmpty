using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// �������� ����
    /// </summary>
    [Serializable]
    #region class of Model:RptCKBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a RptCKBillInfo.
    /// </summary>
    public class RptCKBillInfoQry : BaseModel
    {
         
        private string _billNo = String.Empty;
        private DateTime _operTime;
        private string _outMemo = String.Empty;
        private string _billId;
        private string _inBatchId;
        private string _itemId;
        private double _drugNum;
        private double _retailPrice;
        private double _stockPrice;
        private string _houseName = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private string _unitName = String.Empty;
        private double _totalPrice;
        private double _totalRetail;
        private string _pNo = String.Empty;
        private string _roomName = String.Empty;
        private DateTime _signTime;
        private string _signName = String.Empty;
        private string _operName = String.Empty;
        private DateTime _limitDate;
        private string _f1 = String.Empty;
        private string _f2 = String.Empty;
        private string _f3 = String.Empty;
        private string _f4 = String.Empty;

        /// <summary>
        /// �������� ����
        /// </summary>
        public RptCKBillInfoQry()
        {
        }



        #region Public Properties
        /// <summary>
        ///����ID
        /// </summary>
            public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
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
        /// ����
        /// </summary>
        public string OutMemo
        {
            get { return _outMemo; }
            set { _outMemo = value; }
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
        /// ����No
        /// </summary>
        public string F2
        {
            get { return _f2; }
            set { _f2 = value; }
        }
       
        /// <summary>
        /// ҩƷ����ID
        /// </summary>
        public string InBatchId
        {
            get { return _inBatchId; }
            set { _inBatchId = value; }
        }
        /// <summary>
        /// ��ĿID
        /// </summary>
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }
        /// <summary>
        /// ҩƷ����
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
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
        /// ����(����)��.
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
        }
        /// <summary>
        /// ��Ŀ����
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
        /// ��Ŀ���
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }
        /// <summary>
        /// �����̳���
        /// </summary>
        public string ManufactureryName
        {
            get { return _manufactureryName; }
            set { _manufactureryName = value; }
        }
        /// <summary>
        /// ��λ����
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }
        /// <summary>
        /// ������
        /// (����(����)��.*ҩƷ����)
        /// </summary>
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
        /// <summary>
        /// ���۽��
        /// (���ۼ�*ҩƷ����)
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }
        /// <summary>
        /// �������
        /// </summary>
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public string RoomName
        {
            get { return _roomName; }
            set { _roomName = value; }
        }

        /// <summary>
        /// �������
        /// </summary>
        public DateTime SignTime
        {
            get { return _signTime; }
            set { _signTime = value; }
        }

        /// <summary>
        /// �����
        /// </summary>
        public string SignName
        {
            get { return _signName; }
            set { _signName = value; }
        }

        /// <summary>
        /// ������
        /// </summary>
        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
        }
        /// <summary>
        /// ʧЧ����
        /// </summary>
        public DateTime LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }
        /// <summary>
        /// ҩ����(Ҳ�У��ֿ���)
        /// </summary>
        public string HouseName
        {
            get { return _houseName; }
            set { _houseName = value; }
        }
        /// <summary>
        /// �ֿ�ID
        /// </summary>
        public string HouseId
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
        /// ���Ŀ������
        /// </summary>
        public string RoomId
        {
            get;
            set;

        }

        /// <summary>
        /// ����ID
        /// </summary>
        public string OperId
        {
            get;
            set;
        }
        #endregion
    }
    #endregion
}







