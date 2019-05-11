using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ��Ʒ��������
    /// </summary>
    [Serializable]
    #region class of Model:CKBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a CKBillInfo.
    /// </summary>
    public class CKBillInfoQry : BaseModel
    {
         
        private string _billNo = String.Empty;
        private string _houseId;
        private string _roomId;
        private string _applyId;
        private string _operId;
        private DateTime _operTime;
        private string _outMemo = String.Empty;
        private bool _yFSign;
        private string _yFOperId;
        private DateTime _yFOperTime;
        private bool _isSign;
        private DateTime _signTime;
        private DateTime _limitDate;
        private string _signOperId;
        private string _applyNo = String.Empty;
        private string  _billId;
        private string _inBatchId;
        public string _inBatchNo = String.Empty;
        private string _itemId;
        private string _unitId;
        private double _drugNum;
        private double _retailPrice;
        private double _stockPrice;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private string _unitName = String.Empty;
        private double _totalPrice;
        private double _totalRetail;
        private double _deltaAmount;
        private double _deltaPrice;
        private string _pNo = String.Empty;
        private bool _isSelect;
        private bool _isStockNum;
        private double _stockNum;

        /// <summary>
        /// ��Ʒ��������
        /// </summary>
        public CKBillInfoQry()
        {
        }

        /// <summary>
        /// ��ˮ��
        /// </summary>
        public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
        }

        #region Public Properties
        /// <summary>
        /// ����ID
        /// </summary>
            public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
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
        /// ���Ŀ������
        /// </summary>
        public string RoomId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }

        /// <summary>
        /// ҩ����ҩ���뵥ID
        /// </summary>
        public string ApplyId
        {
            get { return _applyId; }
            set { _applyId = value; }
        }

        /// <summary>
        /// �Ʊ���ID
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
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
        /// ���ⱸע
        /// </summary>
        public string OutMemo
        {
            get { return _outMemo; }
            set { _outMemo = value; }
        }

        /// <summary>
        /// ҩ��ȷ�ϱ�־
        /// </summary>
        public bool YFSign
        {
            get { return _yFSign; }
            set { _yFSign = value; }
        }

        /// <summary>
        /// ������
        /// </summary>
        public string YFOperId
        {
            get { return _yFOperId; }
            set { _yFOperId = value; }
        }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime YFOperTime
        {
            get { return _yFOperTime; }
            set { _yFOperTime = value; }
        }

        /// <summary>
        /// �Ƿ�����ˣ�0:δ���,1:�����.
        /// </summary>
        public bool IsSign
        {
            get { return _isSign; }
            set { _isSign = value; }
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
        /// ʧЧ����
        /// </summary>
        public DateTime LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
        }

        /// <summary>
        /// �����
        /// </summary>
        public string SignOperId
        {
            get { return _signOperId; }
            set { _signOperId = value; }
        }
        /// <summary>
        /// ���뵥��
        /// </summary>
        public string ApplyNo
        {
            get { return _applyNo; }
            set { _applyNo = value; }
        }

        /// <summary>
        /// ����ID
        /// </summary>
        public string  BillId
        {
            get { return _billId; }
            set { _billId = value; }
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
        /// ��λID
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
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
        /// ���ۼ�
        /// </summary>
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }
        /// <summary>
        /// �����
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
        }
        /// <summary>
        /// ��Ʒ���
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
        /// ����������
        /// </summary>
        public string ManufactureryName
        {
            get { return _manufactureryName; }
            set { _manufactureryName = value; }
        }
        /// <summary>
        /// ��λ
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }

        /// <summary>
        /// �ܽ��
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }

        public double DeltaAmount
        {
            get { return _deltaAmount; }
            set { _deltaAmount = value; }
        }

        public double DeltaPrice
        {
            get { return _deltaPrice; }
            set { _deltaPrice = value; }
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
        /// �Ƿ�ѡ��
        /// </summary>
        public bool IsSelect
        {
            get { return _isSelect; }
            set { _isSelect = value; }
        }

        /// <summary>
        /// ���ִ���ҩ���뵥�����ǿ���Ƿ��㹻.
        /// </summary>
        public bool IsStockNum
        {
            get { return _isStockNum; }
            set { _isStockNum = value; }
        }
        /// <summary>
        /// ���
        /// </summary>
        public double StockNum
        {
            get { return _stockNum; }
            set { _stockNum = value; }
        }
        #endregion
    }
    #endregion
}







