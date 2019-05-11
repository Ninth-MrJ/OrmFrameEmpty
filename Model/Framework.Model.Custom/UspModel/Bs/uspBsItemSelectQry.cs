using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    [Serializable]
    #region class of Model:uspBsItemSelectQry
    /// <summary>
    ///��ѯ��Ŀ��ؼ�����
    /// </summary>
    public class uspBsItemSelectQry : BaseModel
    {
         
        private string _code = String.Empty;
        private string _name = String.Empty;
        private string _longDesc = String.Empty;
        private string _engDesc = String.Empty;
        private string _wbCode = String.Empty;
        private string _pyCode = String.Empty;
        private string _groupMainId;
        private string _groupSubId;
        private string _spec = String.Empty;
        private string _unitInId;
        private string _unitDiagId;
        private string _unitDiagName = String.Empty;
        private double _priceDiag;
        private double _dosage;
        private string _unitTakeId;
        private string _unitTakeName = String.Empty;
        private string _feeMzId;
        private string _feeMzName = String.Empty;
        private bool _isRpForbid;
        private string _memo = String.Empty;
        private bool _isActive;
        private double _underLineKc;
        private double _uperLineKc;
        private double _normalLineKc;
        private string _formId;
        private string _drugFormName = String.Empty;
        private string _manuId;
        private string _manufacturerName = String.Empty;
        private double _retailPriceKc;
        private double _stockPriceKc;
        private int _orderBy;
        public uspBsItemSelectQry()
        {
        }
        #region Public Properties
       
        /// <summary>
        /// ���
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        /// <summary>
        /// ����
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
        /// ���顣���������BsGroup.GUID 
        /// </summary>
        public string GroupMainId
        {
            get { return _groupMainId; }
            set { _groupMainId = value; }
        }
       
        /// <summary>
        /// ���顣���������BsGroupSub.GUID
        /// </summary>
        public string GroupSubId
        {
            get { return _groupSubId; }
            set { _groupSubId = value; }
        }
       
        /// <summary>
        /// ���
        /// </summary>
        public string Spec
        {
            get { return _spec; }
            set { _spec = value; }
        }
        public string UnitInId
        {
            get { return _unitInId; }
            set { _unitInId = value; }
        }
        /// <summary>
        /// ���ﵥλ�����������BsUnit..GUID.
        /// </summary>
        public string UnitDiagId
        {
            get { return _unitDiagId; }
            set { _unitDiagId = value; }
        }
        /// <summary>
        /// ���ﵥλ����
        /// </summary>
        public string UnitDiagName
        {
            get { return _unitDiagName; }
            set { _unitDiagName = value; }
        }
        /// <summary>
        /// ����۸�
        /// </summary>
        public double PriceDiag
        {
            get { return _priceDiag; }
            set { _priceDiag = value; }
        }
       
      
        /// <summary>
        /// ����
        /// </summary>
        public double Dosage
        {
            get { return _dosage; }
            set { _dosage = value; }
        }
        /// <summary>
        /// ���õ�λ�����������BsUnit.GUID
        /// </summary>
        public string UnitTakeId
        {
            get { return _unitTakeId; }
            set { _unitTakeId = value; }
        }
        /// <summary>
        /// ���õ�λ����
        /// </summary>
        public string UnitTakeName
        {
            get { return _unitTakeName; }
            set { _unitTakeName = value; }
        }
       
        /// <summary>
        /// �����շ�������������BsMzFeety.GUID
        /// </summary>
        public string FeeMzId
        {
            get { return _feeMzId; }
            set { _feeMzId = value; }
        }
        /// <summary>
        /// �����շ��������
        /// </summary>
        public string FeeMzName
        {
            get { return _feeMzName; }
            set { _feeMzName = value; }
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
        /// ��ע.
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
        /// <summary>
        /// ��Ч��־.
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        /// <summary>
        /// ��澯������.
        /// </summary>
        public double UnderLineKc
        {
            get { return _underLineKc; }
            set { _underLineKc = value; }
        }
        /// <summary>
        /// ��澯������.
        /// </summary>
        public double UperLineKc
        {
            get { return _uperLineKc; }
            set { _uperLineKc = value; }
        }
        /// <summary>
        /// �ɹ�ά�ֿ����.
        /// </summary>
        public double NormalLineKc
        {
            get { return _normalLineKc; }
            set { _normalLineKc = value; }
        }
        /// <summary>
        /// ����.
        /// </summary>
        public string FormId
        {
            get { return _formId; }
            set { _formId = value; }
        }

        public string DrugFormName
        {
            get { return _drugFormName; }
            set { _drugFormName = value; }
        }
        /// <summary>
        /// ������ID ����bsmanufacturer.
        /// </summary>
        public string ManuId
        {
            get { return _manuId; }
            set { _manuId = value; }
        }


        /// <summary>
        /// ����������
        /// </summary>
        public string ManufacturerName
        {
            get { return _manufacturerName; }
            set { _manufacturerName = value; }
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
        /// �����.
        /// </summary>
        public double StockPriceKc
        {
            get { return _stockPriceKc; }
            set { _stockPriceKc = value; }
        }
 
        /// <summary>
        /// ��ʾ˳��.
        /// </summary>
        public int OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

      
        #endregion
    }
    #endregion
}







