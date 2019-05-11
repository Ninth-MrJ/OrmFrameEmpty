using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ��Ʒ����б�
    /// </summary>
    [Serializable]
    #region class of Model:RKBillInfoQry
    /// <summary>
    /// This object represents the properties and methods of a RKBillInfo.
    /// </summary>
    public class RKBillInfoQry : BaseModel
    {
         
        private string _voucherNo = String.Empty;
        private string _pNo = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _manufactureryName = String.Empty;
        private double _drugNum;
        private string _unitName = String.Empty;
        private double _stockPrice;
        private double _totalPrice;
        private double _retailPrice;
        private double _totalRetail;
        private double _deltaAmount;
        private DateTime _produceDate =DateTime.Now.Date;
        private DateTime _limitDate = DateTime.Now.AddYears(1).Date;
        private string _billNo = String.Empty;
        private DateTime _operTime;
        private DateTime _signTime;
        private bool _isSign;
        private string _inBatchNo = String.Empty;
        private string _billId;
        private string _itemId;
        private string _unitId;
        private string _houseId;
        private string _compId;
        private string _operId;
        private string _signOperId;
        private double _addPercent;
        private string _passNo = String.Empty;
        private string _proAreaName = String.Empty;
        private int _proAreaId;
        private string _manuId;
        private double _priceHighLine;
        private string _f1 = String.Empty;   //������

        private string _regNo = String.Empty;
        private string _importUnit = String.Empty;
        private string _reportNo = String.Empty;
        private string _makeinArea = String.Empty;
        private bool _isSelect;
        private string _barCode = "";
        private int _tYear = 0;
        private int _tMonth = 0;

        /// <summary>
        /// ��Ʒ����б�
        /// </summary>
        public RKBillInfoQry()
        {
        }


        #region Public Properties

        /// <summary>
        /// ע��֤��
        /// </summary>
        public string RegNo
        {
            get { return _regNo; }
            set { _regNo = value; }
        }

        /// <summary>
        /// ���ڼ��鵥λ
        /// </summary>
        public string ImportUnit
        {
            get { return _importUnit; }
            set { _importUnit = value; }
        }

        /// <summary>
        /// �������
        /// </summary>
        public string ReportNo
        {
            get { return _reportNo; }
            set { _reportNo = value; }
        }

        /// <summary>
        /// ������
        /// </summary>
        public string MakeinArea
        {
            get { return _makeinArea; }
            set { _makeinArea = value; }
        }

        /// <summary>
        /// ��Ʊ��
        /// </summary>
        public string VoucherNo
        {
            get { return _voucherNo; }
            set { _voucherNo = value; }
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
        /// ���
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
        /// ����
        /// </summary>
        public double DrugNum
        {
            get { return _drugNum; }
            set { _drugNum = value; }
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
        /// ʵ��
        /// </summary>
        public double StockPrice
        {
            get { return _stockPrice; }
            set { _stockPrice = value; }
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
        /// ���ۼ�
        /// </summary>
        public double RetailPrice
        {
            get { return _retailPrice; }
            set { _retailPrice = value; }
        }

        /// <summary>
        /// ���۽��
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }

        /// <summary>
        /// ӯ���ܽ��
        /// </summary>
        public double DeltaAmount
        {
            get { return _deltaAmount; }
            set { _deltaAmount = value; }
        }

        /// <summary>
        /// ��������
        /// </summary>
        public DateTime ProduceDate
        {
            get { return _produceDate; }
            set { _produceDate = value; }
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
        /// ���ݺ�
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
        /// �������
        /// </summary>
        public DateTime SignTime
        {
            get { return _signTime; }
            set { _signTime = value; }
        }

        /// <summary>
        /// �Ƿ�����ˣ�0:δ���,1:�����
        /// </summary>
        public bool IsSign
        {
            get { return _isSign; }
            set { _isSign = value; }
        }

        /// <summary>
        /// ҩƷ����ID
        /// </summary>
        public string InBatchNo
        {
            get { return _inBatchNo; }
            set { _inBatchNo = value; }
        }

        /// <summary>
        /// ��ⵥID
        /// </summary>
        public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
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
        /// ʹ�õ�λ��С��λ��
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
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
        /// ҽҩ��˾ID
        /// </summary>
        public string CompId
        {
            get { return _compId; }
            set { _compId = value; }
        }

        /// <summary>
        /// ����ԱID
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }

        /// <summary>
        /// �����Id 
        /// </summary>
        public string SignOperId
        {
            get { return _signOperId; }
            set { _signOperId = value; }
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
        /// �۸����ָ��
        /// </summary>
        public double PriceHighLine
        {
            get { return _priceHighLine; }
            set { _priceHighLine = value; }
        }

        /// <summary>
        /// ��׼�ĺ�
        /// </summary>
        public string PassNo
        {
            get { return _passNo; }
            set { _passNo = value; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string ProAreaName
        {
            get { return _proAreaName; }
            set { _proAreaName = value; }
        }

        /// <summary>
        /// ����ID
        /// </summary>
        public int ProAreaId
        {
            get { return _proAreaId; }
            set { _proAreaId = value; }
        }
    

        /// <summary>
        /// ������ID
        /// </summary>
        public string ManuId
        {
            get { return _manuId; }
            set { _manuId = value; }
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
        /// ������
        /// </summary>
        public string BarCode
        {
            get { return _barCode; }
            set { _barCode = value; }
        }

        /// <summary>
        ///������-�� 
        /// </summary>
        public int TMonth
        {
            get { return _tMonth; }
            set { _tMonth = value; }
        }

        /// <summary>
        /// ������-��
        /// </summary>
        public int TYear
        {
            get { return _tYear; }
            set { _tYear = value; }
        }
        #endregion
    }
    #endregion
}







