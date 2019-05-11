using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    #region class of Model:uspBsItemMiniQry
    /// <summary>
    /// This object represents the properties and methods of a uspBsItemMini.
    /// </summary>
    /// 
    [Serializable]
    public class uspBsItemMiniQry : BaseModel
    {
        protected string _code = String.Empty;
        protected string _wbCode = String.Empty;
        protected string _pyCode = String.Empty;
        protected string _strokeCode = String.Empty;
        protected string _otherCode = String.Empty;
        protected string _name = String.Empty;
        protected string _longDesc = String.Empty;
        protected string _engDesc = String.Empty;
        protected string _spec = String.Empty;
        protected string _unitInName = String.Empty;
        protected int _lsGfType;
        protected bool _isRpForbid;
        protected string _f3 = String.Empty;
        protected string _f4 = String.Empty;
        protected bool _optionPrice;
        protected bool _isSpecial;
        protected bool _isSpecSum;
        protected int _lsRpType;
        protected bool _isActive;
        protected string _unitDiagName = String.Empty;
        protected double _priceIn;
        protected double _priceDiag;
        protected string _memo = String.Empty;
        protected int _orderBy;
        protected string _multiName = String.Empty;
        protected string _multiPy = String.Empty;
        protected string _multiWb = String.Empty;
        protected string _unitDiagId;
        protected string _manuId;
        protected string _manufacturerName;
        protected double _stockPriceKc;
        protected double _underlineKc;
        protected double _retailPriceKc;
        protected int _tMonth;
        protected int _tYear;


        public uspBsItemMiniQry()
        {
        }
        /// <summary>
        /// ���ۼ۸�.
        /// </summary>
        public double RetailPriceKc
        {
            get { return _retailPriceKc; }
            set { _retailPriceKc = value; }
        }

        /// <summary>
        /// �������
        /// </summary>
        public double UnderLineKc
        {
            get
            {
                return this._underlineKc;
            }
            set
            {
                this._underlineKc = value;
            }
        }


        /// <summary>
        /// �����.
        /// </summary>
        public double StockPriceKc
        {
            get
            {
                return this._stockPriceKc;
            }
            set
            {
                this._stockPriceKc = value;
            }
        }

        /// <summary>
        /// ����ID.
        /// </summary>
        public string ManuId
        {
            get
            {
                return this._manuId;
            }
            set
            {
                this._manuId = value;
            }
        }

        public string ManufacturerName
        {
            get { return _manufacturerName; }
            set { _manufacturerName = value; }
        }

        #region Public Properties

        /// <summary>
        /// ����
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// �����
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }

        /// <summary>
        /// ƴ����
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
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
        /// ȫ��
        /// </summary>
        public string LongDesc
        {
            get { return _longDesc; }
            set { _longDesc = value; }
        }

        /// <summary>
        /// Ӣ����
        /// </summary>
        public string EngDesc
        {
            get { return _engDesc; }
            set { _engDesc = value; }
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
        /// ��ֹ�ٴ���ҩ.
        /// </summary>
        public bool IsRpForbid
        {
            get { return _isRpForbid; }
            set { _isRpForbid = value; }
        }


        /// <summary>
        /// ��ʾ˳��
        /// </summary>
        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }


        /// <summary>
        /// ��Ч��־
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>
        /// ������λ
        /// </summary>
        public string UnitDiagName
        {
            get { return _unitDiagName; }
            set { _unitDiagName = value; }
        }



        public double PriceDiag
        {
            get { return _priceDiag; }
            set { _priceDiag = value; }
        }

        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }

        public string UnitDiagId
        {
            get { return _unitDiagId; }
            set { _unitDiagId = value; }
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





