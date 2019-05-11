using System;

namespace Orm.Model.Custom
{
    /// <summary>
    ///����(��,��)��
    /// </summary>
    [Serializable]
    #region class of Model:uspHuInAndOutQry
    /// <summary>
    /// This object represents the properties and methods of a uspSelectHuNotAuthorize.
    /// </summary>
    public class uspHuInAndOutQry : BaseModel
    {

        private string _billNo = String.Empty;
        private string _houseId;
        private string _operId;
        private string _operName;
        private DateTime _operTime;
        private bool _isSign;
        private double _retailTotle;
        private double _stockTotle;
        private string _type = String.Empty;
        private int _lsActType;
        private DateTime _signTime;
        private string _name = String.Empty;
        private bool _isSelected = false;
        private string _pNo = String.Empty;
        private string _itemCodey;
        private int _cons;

        public int PageNumber { get; set; }
        public string Depotid { get; set; }

        public int HasInvo { get; set; }

        public string RoomName { get; set; }//ҩ��
        public string CompName { get; set; }//��Ӧ��

        public string Memo { get; set; }
        public string Reason { get; set; }

        public string DispUnit { get; set; }


        /// <summary>
        ///����(��,��)��
        /// </summary>
        public uspHuInAndOutQry()
        {
        }

        #region Public Properties
        /// <summary>
        /// ���ݺ�
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }
        /// <summary>
        /// �ֿ�Id 
        /// </summary>
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }
        /// <summary>
        /// ������ID
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }
        /// <summary>
        /// ����������
        /// </summary>
        public string OperName
        {
            get { return _operName; }
            set { _operName = value; }
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
        /// �Ƿ�����ˣ�0:δ���,1:�����.
        /// </summary>
        public bool IsSign
        {
            get { return _isSign; }
            set { _isSign = value; }
        }
        /// <summary>
        /// �����ܽ��
        /// </summary>
        public double RetailTotle
        {
            get { return _retailTotle; }
            set { _retailTotle = value; }
        }
        /// <summary>
        /// �����ܽ��
        /// </summary>
        public double StockTotle
        {
            get { return _stockTotle; }
            set { _stockTotle = value; }
        }

        /// <summary>
        /// ���ʱ�� 
        /// </summary>
        public DateTime SignTime
        {
            get { return _signTime; }
            set { _signTime = value; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public int LsActType
        {
            get { return _lsActType; }
            set { _lsActType = value; }
        }
        /// <summary>
        ///�Ƿ�ѡ�е���
        /// </summary>
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; }
        }
        /// <summary>
        /// ���(��������)
        /// </summary>
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string PNo
        {
            get
            {
                return _pNo;
            }

            set
            {
                _pNo = value;
            }
        }
        /// <summary>
        /// ��Ŀ���
        /// </summary>
        public string ItemCodey
        {
            get
            {
                return _itemCodey;
            }

            set
            {
                _itemCodey = value;
            }
        }

        /// <summary>
        /// �ŵ�����
        /// </summary>
        public string LocName { get; set; }

        /// <summary>
        /// �ŵ�����
        /// </summary>
        public int Cons { get; set; }
        #endregion
    }
    #endregion
}







