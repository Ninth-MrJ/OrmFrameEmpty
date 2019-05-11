using System;

namespace Orm.Model.Custom
{
    /// <summary>
    ///�շѵ������
    /// </summary>
    [Serializable]
   
    public partial class uspOuInvoiceQry : BaseModel
    {


        private string _invoNo;
        private string _mzRegId;
        private string _patId;
        private DateTime _invoTime;
        private double _beprice;
        private double _factGet;
        private double _insurance;
        private double _paySelf;
        private double _amountPay;
        private double _addFee;
        private string _tallyNo;
        private string _remark;
        private DateTime _operTime;
        private string _operId;
        private bool _isCancel;
        private DateTime _cancelOperTime;
        private string _cancelOperId;
        private string _cancelMemo;
        private string _invoLastId;
        private int _reAmount;
        private string _feeSubId;
        private string _reAmountMemo;
        private string _feeMainId;
        private string _patTypeId;
        private DateTime _reAmountDate;
        private DateTime _tallyTime;
        private DateTime _cancelTallyTime;
        private string _hospitalId;
        private string _ybIllId;
        private string _locationId;
        private string _doctorId;
        private DateTime _checkTime;
        private DateTime _cancelCheckTime;
        private string _hOSTName;
        private string _tallyOperId;
        private string _tallyCancelOperId;
        private string _yBRegNO;
        private string _arrearsTypeId;
        private string _doctorName = String.Empty;
        private string _patientName = String.Empty;
        private double _accountAmount;


        public string LocationName { get; set; }

        /// <summary>
        /// Ĭ�Ϲ��췽��.
        /// </summary>
        public uspOuInvoiceQry()
        {
        }

        /// <summary>
        /// �տʽ�����ܶ����
        /// </summary>
        public string PayWays { get; set; }
      
        /// <summary>
        /// �տ�������
        /// </summary>
        public string OperName { get; set; }
     
        /// <summary>
        /// ��ʿ����
        /// </summary>
        public string NurseName { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// ��Ʊ����.
        /// </summary>
        public string InvoNo
        {
            get
            {
                return this._invoNo;
            }
            set
            {
                this._invoNo = value;
            }
        }

        /// <summary>
        /// ������ˮ�š����������OuHosInfo.GUID.
        /// </summary>
        public string MzRegId
        {
            get
            {
                return this._mzRegId;
            }
            set
            {
                this._mzRegId = value;
            }
        }

        /// <summary>
        /// ����ID����Ӧ��Patient��Pat_Id.
        /// </summary>
        public string PatId
        {
            get
            {
                return this._patId;
            }
            set
            {
                this._patId = value;
            }
        }

        /// <summary>
        /// ��Ʊʱ�䡣���������Bspatient.GUID.
        /// </summary>
        public DateTime InvoTime
        {
            get
            {
                return this._invoTime;
            }
            set
            {
                this._invoTime = value;
            }
        }

        /// <summary>
        /// Ӧ������ܽ�.
        /// </summary>
        public double Beprice
        {
            get
            {
                return this._beprice;
            }
            set
            {
                this._beprice = value;
            }
        }

        /// <summary>
        /// �Ը�������DiscSelfǰ�Ľ�.
        /// </summary>
        public double FactGet
        {
            get
            {
                return this._factGet;
            }
            set
            {
                this._factGet = value;
            }
        }

        /// <summary>
        /// ҽ��/��ҽ���ʽ��.
        /// </summary>
        public double Insurance
        {
            get
            {
                return this._insurance;
            }
            set
            {
                this._insurance = value;
            }
        }

        /// <summary>
        /// ���˽ɷѽ��.
        /// </summary>
        public double PaySelf
        {
            get
            {
                return this._paySelf;
            }
            set
            {
                this._paySelf = value;
            }
        }

        /// <summary>
        /// Ӧ��������DiscSelf��Ľ�.
        /// </summary>
        public double AmountPay
        {
            get
            {
                return this._amountPay;
            }
            set
            {
                this._amountPay = value;
            }
        }

        /// <summary>
        /// ������.
        /// </summary>
        public double AddFee
        {
            get
            {
                return this._addFee;
            }
            set
            {
                this._addFee = value;
            }
        }

        /// <summary>
        /// ���Ѽ��ʵ���.
        /// </summary>
        public string TallyNo
        {
            get
            {
                return this._tallyNo;
            }
            set
            {
                this._tallyNo = value;
            }
        }

        /// <summary>
        /// �˿ע.
        /// </summary>
        public string Remark
        {
            get
            {
                return this._remark;
            }
            set
            {
                this._remark = value;
            }
        }

        /// <summary>
        /// �Ǽ�ʱ��.
        /// </summary>
        public DateTime OperTime
        {
            get
            {
                return this._operTime;
            }
            set
            {
                this._operTime = value;
            }
        }

        /// <summary>
        /// �Ǽ���.
        /// </summary>
        public string OperId
        {
            get
            {
                return this._operId;
            }
            set
            {
                this._operId = value;
            }
        }

        /// <summary>
        /// �Ƿ�ע��.
        /// </summary>
        public bool IsCancel
        {
            get
            {
                return this._isCancel;
            }
            set
            {
                this._isCancel = value;
            }
        }

        /// <summary>
        /// ע������.
        /// </summary>
        public DateTime CancelOperTime
        {
            get
            {
                return this._cancelOperTime;
            }
            set
            {
                this._cancelOperTime = value;
            }
        }

        /// <summary>
        /// �շѲ���Ա.
        /// </summary>
        public string CancelOperId
        {
            get
            {
                return this._cancelOperId;
            }
            set
            {
                this._cancelOperId = value;
            }
        }

        /// <summary>
        /// �˿ע.
        /// </summary>
        public string CancelMemo
        {
            get
            {
                return this._cancelMemo;
            }
            set
            {
                this._cancelMemo = value;
            }
        }

        /// <summary>
        /// �˷ѵ�ԭ��Ʊ�����������OuInvoice.GUID.
        /// </summary>
        public string InvoLastId
        {
            get
            {
                return this._invoLastId;
            }
            set
            {
                this._invoLastId = value;
            }
        }


       

      
      

        
      

        /// <summary>
        /// ��ԺID.
        /// </summary>
        public string HospitalId
        {
            get
            {
                return this._hospitalId;
            }
            set
            {
                this._hospitalId = value;
            }
        }

        /// <summary>
        /// ���ⲡ��ID.
        /// </summary>
        public string YbIllId
        {
            get
            {
                return this._ybIllId;
            }
            set
            {
                this._ybIllId = value;
            }
        }

        /// <summary>
        /// ����id
        /// </summary>
        public string LocationId
        {
            get
            {
                return this._locationId;
            }
            set
            {
                this._locationId = value;
            }
        }

        /// <summary>
        /// ҽ��ID
        /// </summary>
        public string DoctorId
        {
            get
            {
                return this._doctorId;
            }
            set
            {
                this._doctorId = value;
            }
        }

        /// <summary>
        /// ����ʱ��.
        /// </summary>
        public DateTime CheckTime
        {
            get
            {
                return this._checkTime;
            }
            set
            {
                this._checkTime = value;
            }
        }

        /// <summary>
        /// ����ʱ��.
        /// </summary>
        public DateTime CancelCheckTime
        {
            get
            {
                return this._cancelCheckTime;
            }
            set
            {
                this._cancelCheckTime = value;
            }
        }

        /// <summary>
        /// F1�ϴ�����վ.
        /// </summary>
        public string HOSTName
        {
            get
            {
                return this._hOSTName;
            }
            set
            {
                this._hOSTName = value;
            }
        }

        /// <summary>
        /// ������.
        /// </summary>
        public string TallyOperId
        {
            get
            {
                return this._tallyOperId;
            }
            set
            {
                this._tallyOperId = value;
            }
        }

        /// <summary>
        /// ȡ��������.
        /// </summary>
        public string TallyCancelOperId
        {
            get
            {
                return this._tallyCancelOperId;
            }
            set
            {
                this._tallyCancelOperId = value;
            }
        }

        /// <summary>
        /// F7ҽ����ˮ��.
        /// </summary>
        public string YBRegNO
        {
            get
            {
                return this._yBRegNO;
            }
            set
            {
                this._yBRegNO = value;
            }
        }
        /// <summary>
        /// ���ڼ�¼����ҩ����ҩ������ҩ����ҩ
        /// </summary>
        public string IsRecord { get; set; }

        /// <summary>
        /// �Żݻ
        /// </summary>
        public string ScaleID { get; set; }
        /// <summary>
        /// �����ۿ�
        /// </summary>
        public double DiscountNum { get; set; }
        /// <summary>
        /// ����Ƿ��
        /// </summary>
        public double CurrentArrears { get; set; }

        /// <summary>
        /// �Ƿ��ӡ
        /// </summary>
        public bool IsPrintInvoice { get; set; }

        /// <summary>
        /// ҽ��
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
        /// ��������
        /// </summary>
        public string PatientName
        {
            get
            {
                return this._patientName;
            }
            set
            {
                this._patientName = value;
            }
        }
        /// <summary>
        /// �˷ѷ���
        /// </summary>
        public string ArrearsTypeId 
        {
            get
            {
                return this._arrearsTypeId;
            }
            set
            {
                this._arrearsTypeId = value;
            }
        }
        /// <summary>
        /// ���˽��
        /// </summary>
        public double AccountAmount
        {
            get
            {
                return this._accountAmount;
            }
            set
            {
                this._accountAmount = value;
            }
        }

        /// <summary>
        /// ���η���
        /// </summary>
        public double CurrentPay { get; set; }
        /// <summary>
        /// �ϴ�Ƿ��
        /// </summary>
        public double PreviousArrears { get; set; }

        public bool  IsHideIllness { get; set; }
        /// <summary>
        /// �Ƿ����
        /// </summary>
        public bool IsTally { get; set; }
        /// <summary>
        /// �Ƿ������
        /// </summary>
        public bool IsVerify { get; set; }
        /// <summary>
        /// �Ƿ��շ�
        /// </summary>
        public bool IsCharge { get; set; }
        /// <summary>
        /// ������
        /// </summary>
        public int RowCount { get; set; }
        
    }
}



