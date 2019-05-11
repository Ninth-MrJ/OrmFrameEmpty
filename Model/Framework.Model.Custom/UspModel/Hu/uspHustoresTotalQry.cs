using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ����ѯ���룬������ϸ��
    /// </summary>
    [Serializable]
    #region class of Model:uspHustoresTotalQry
    /// <summary>
    /// This object represents the properties and methods of a uspHustoresTotal.
    /// </summary>
    public class uspHustoresTotalQry : BaseModel
    {

        private string _unitId;
        private string _unitName = String.Empty;
        private string _itemCode = String.Empty;
        private string _spec = String.Empty;
        private string _manuId;
        private string _itemName = String.Empty;
        private double _stockNumSun;
        private double _totalPrice;
        private double _totalRetail;
        private double _underLineKc;
        private double _uperLineKc;
        /// <summary>
        /// ����ѯ���룬������ϸ��
        /// </summary>
        public uspHustoresTotalQry()
        {
        }


        #region Public Properties
        /// <summary>
        /// ��λID
        /// </summary>
        public string UnitId
        {
            get { return _unitId; }
            set { _unitId = value; }
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
        /// ��Ŀ����
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
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
        /// ��ҩ��˾ID
        /// </summary>
        public string ManuId
        {
            get { return _manuId; }
            set { _manuId = value; }
        }
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        /// <summary>
        /// �������
        /// </summary>
        public double StockNumSum
        {
            get { return _stockNumSun; }
            set { _stockNumSun = value; }
        }
        /// <summary>
        /// �ܼ�
        /// </summary>
        public double TotalPrice
        {
            get { return _totalPrice; }
            set { _totalPrice = value; }
        }
        /// <summary>
        /// �����ܶ� 
        /// </summary>
        public double TotalRetail
        {
            get { return _totalRetail; }
            set { _totalRetail = value; }
        }
        /// <summary>
        /// /��澯������
        /// </summary>
        public double UnderLineKc
        {
            get { return _underLineKc; }
            set { _underLineKc = value; }
        }
        /// <summary>
        /// ��澯������
        /// </summary>
        public double UperLineKc
        {
            get { return _uperLineKc; }
            set { _uperLineKc = value; }
        }


        /// <summary>
        /// ������
        /// </summary>
        public int RowCount { get; set; }
        #endregion
    }
    #endregion
}







