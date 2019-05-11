using System;

namespace Orm.Model.Custom
{
    /// <summary>
    ///����̵��б�
    /// </summary>
    [Serializable]
    #region class of Model:uspHuInventoriesDeatilQry
    /// <summary>
    /// This object represents the properties and methods of a uspHuInventoriesDeatil.
    /// </summary>
    public class uspHuInventoriesDeatilQry : BaseModel
    {
         
        private string _inBatchId;
        private string _itemId;
        private string _compId;
        private string _groupId;
        private string _compName;
        private string _unitId;
        private string _unitName;
        private double _balanceNum;
        private double _stcokNum;
        private double _instoreNum;
        private double _checkNum;
        private double _pkNum;
        private double _stockPrice;
        private double _retailPrice;
        private string _compare = String.Empty;
        private bool _isBalance;
        private double _retailPricePk;
        private double _stockPricePk;
        private double _retailPriceCheck;
        private double _stockPriceCheck;
        private double _retailPriceStcok;
        private double _stockPriceStcok;
        private string _state = String.Empty;
        private string _itemCode = String.Empty;
        private string _itemName = String.Empty;
        private string _spec = String.Empty;
        private string _pNo = String.Empty;
        private string _isGSJ = String.Empty;
        private int _formId;
        private string _billId;
        private bool _isAdjust;
        private double _buyIn;
        private double _backIn;
        private double _otherIn;
        private double _deptOut;
        private double _backOut;
        private double _saleOut;
        private double _loseOut;
        private double _adjustAmouUp;
        private double _adjustAmouDn;
        private DateTime _limitDate;
        private bool _isOnlyForSys;
        /// <summary>
        ///����̵��б�
        /// </summary>
        public uspHuInventoriesDeatilQry()
        {
        }



        #region Public Properties

        /// <summary>
        /// ҩƷ����ID
        /// </summary>
            public string InBatchId
        {
            get { return _inBatchId; }
            set { _inBatchId = value; }
        }

        /// <summary>
        /// ʧ������
        /// </summary>
        public DateTime LimitDate
        {
            get { return _limitDate; }
            set { _limitDate = value; }
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
        /// ҽҩ��˾ID.
        /// </summary>
        public string CompId
        {
            get { return _compId; }
            set { _compId = value; }
        }
        /// <summary>
        /// ���顣���������BsGroup.GUID.
        /// </summary>
        public string GroupId
        {
            get { return _groupId; }
            set { _groupId = value; }
        }

        /// <summary>
        /// ҽҩ��˾����.
        /// </summary>
        public string CompName
        {
            get { return _compName; }
            set { _compName = value; }
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
        /// ��λ
        /// </summary>
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }
        /// <summary>
        /// �������
        /// </summary>
        public double BalanceNum
        {
            get { return _balanceNum; }
            set { _balanceNum = value; }
        }
        /// <summary>
        /// �������
        /// </summary>
        public double StcokNum
        {
            get { return _stcokNum; }
            set { _stcokNum = value; }
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
        /// �̵�����
        /// </summary>
        public double CheckNum
        {
            get { return _checkNum; }
            set { _checkNum = value; }
        }
        /// <summary>
        /// �̿�����
        /// </summary>
        public double PkNum
        {
            get { return _pkNum; }
            set { _pkNum = value; }
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
        /// �Ƚ�
        /// </summary>
        public string Compare
        {
            get { return _compare; }
            set { _compare = value; }
        }
        /// <summary>
        /// �Ƿ���
        /// </summary>
        public bool IsBalance
        {
            get { return _isBalance; }
            set { _isBalance = value; }
        }

        /// <summary>
        /// ���ۿ�����
        /// (���ۼ�*���̵�����-���������)
        /// </summary>
        public double RetailPricePk
        {
            get { return _retailPricePk; }
            set { _retailPricePk = value; }
        }
        /// <summary>
        /// ����۸��̿�
        /// (���루��������*���̵�����-���������)
        /// </summary>
        public double StockPricePk
        {
            get { return _stockPricePk; }
            set { _stockPricePk = value; }
        }

        /// <summary>
        /// ��ʵ���
        /// (���ۼ�*�̵�����)
        /// </summary>
        public double RetailPriceCheck
        {
            get { return _retailPriceCheck; }
            set { _retailPriceCheck = value; }
        }

        /// <summary>
        /// �������
        /// (���루��������*�̵�����
        /// </summary>
        public double StockPriceCheck
        {
            get { return _stockPriceCheck; }
            set { _stockPriceCheck = value; }
        }

        /// <summary>
        /// ���۽��ۻ���
        /// (���ۼ�*�������)
        /// </summary>
        public double RetailPriceStcok
        {
            get { return _retailPriceStcok; }
            set { _retailPriceStcok = value; }
        }

        /// <summary>
        /// �������
        /// (���루��������*�������)
        /// </summary>
        public double StockPriceStcok
        {
            get { return _stockPriceStcok; }
            set { _stockPriceStcok = value; }
        }

        /// <summary>
        /// ״̬
        /// (��ӯ��������ӯ��)
        /// </summary>
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        /// <summary>
        /// ����
        /// (��Ŀ����)
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }

        /// <summary>
        /// ���(ָ����Ŀ)
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
        public string PNo
        {
            get { return _pNo; }
            set { _pNo = value; }
        }

        
        /// <summary>
        /// ����ID
        /// </summary>
        public int FormId
        {
            get { return _formId; }
            set { _formId = value; }
        }

        /// <summary>
        /// �̵�����ID
        /// </summary>
        public string BillId
        {
            get { return _billId; }
            set { _billId = value; }
        }

        /// <summary>
        /// �۸��Ƿ������
        /// </summary>
        public bool IsAdjust
        {
            get { return _isAdjust; }
            set { _isAdjust = value; }
        }

        /// <summary>
        /// �Թ����
        /// </summary>
        public double BuyIn
        {
            get { return _buyIn; }
            set { _buyIn = value; }
        }

        /// <summary>
        /// ҩ����ҩ
        /// </summary>
        public double BackIn
        {
            get { return _backIn; }
            set { _backIn = value; }
        }

        /// <summary>
        /// �������
        /// </summary>
        public double OtherIn
        {
            get { return _otherIn; }
            set { _otherIn = value; }
        }
        /// <summary>
        /// ҩ�ⷢҩ
        /// </summary>
        public double DeptOut
        {
            get { return _deptOut; }
            set { _deptOut = value; }
        }
        /// <summary>
        /// ��ҩ����
        /// </summary>
        public double BackOut
        {
            get { return _backOut; }
            set { _backOut = value; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public double SaleOut
        {
            get { return _saleOut; }
            set { _saleOut = value; }
        }
        /// <summary>
        /// �������
        /// </summary>
        public double LoseOut
        {
            get { return _loseOut; }
            set { _loseOut = value; }
        }
        /// <summary>
        /// �µ�����
        /// </summary>
        public double AdjustAmouUp
        {
            get { return _adjustAmouUp; }
            set { _adjustAmouUp = value; }
        }
        /// <summary>
        /// �ϵ�����
        /// </summary>
        public double AdjustAmouDn
        {
            get { return _adjustAmouDn; }
            set { _adjustAmouDn = value; }
        }
        #endregion
        /// <summary>
        /// �Ƿ���
        /// </summary>
        public bool IsOnlyForSys
        {
            get { return _isOnlyForSys; }
            set { _isOnlyForSys = value; }
        }

        private string _code = string.Empty;
        /// <summary>
        /// ����
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private DateTime _checkTime;
        /// <summary>
        /// �̵�ʱ��
        /// </summary>
        public DateTime CheckTime
        {
            get { return _checkTime; }
            set { _checkTime = value; }
        }


        private double _stcokNumDeep;
        /// <summary>
        /// ��������
        /// </summary>
        public double StcokNumDeep
        {
            get { return _stcokNumDeep; }
            set { _stcokNumDeep = value; }
        }
    }
    #endregion
}







