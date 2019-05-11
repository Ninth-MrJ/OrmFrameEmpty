using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// �������б���Ϣ
    /// (��Ʒ����,�˻س���,��Ʒ����,�������,��Ʒ���,��ӯ���,�̿�����,��������,�����˿�,�������,�ɹ��ƻ�)
    /// </summary>
    [Serializable]
    #region class of Model:uspSelectHuNotAuthorizeQry
    /// <summary>
    /// This object represents the properties and methods of a uspSelectHuNotAuthorize.
    /// </summary>
    public class uspSelectHuNotAuthorizeQry : BaseModel
    {
         
        private string _billNo = String.Empty;
        private string _houseId;
        private string _operId;
        private DateTime _operTime;
        private bool _isSign;
        private double _retailTotle;
        private double _stockTotle;
        private string _type = String.Empty;
        private int _lsActType;
        private DateTime _signTime;
        private string _name = String.Empty;
        private string _memo = String.Empty;
        /// <summary>
        /// �������б���Ϣ
        /// (��Ʒ����,�˻س���,��Ʒ����,�������,��Ʒ���,��ӯ���,�̿�����,��������,�����˿�,�������,�ɹ��ƻ�)
        /// </summary>
        public uspSelectHuNotAuthorizeQry()
        {
        }



        #region Public Properties
        /// <summary>
        /// ���ݱ��
        /// </summary>
        public string BillNo
        {
            get { return _billNo; }
            set { _billNo = value; }
        }
        /// <summary>
        /// �ֿ�ID
        /// </summary>
        public string HouseId
        {
            get { return _houseId; }
            set { _houseId = value; }
        }
        /// <summary>
        /// �Ƶ���
        /// </summary>
        public string OperId
        {
            get { return _operId; }
            set { _operId = value; }
        }
        /// <summary>
        /// �û�����
        /// </summary>
        public string OperName { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime OperTime
        {
            get { return _operTime; }
            set { _operTime = value; }
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
        /// ����
        /// (���磺�����˿�,�������,�ɹ��ƻ�..)
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
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
        /// �����ʱ��
        /// </summary>
        public DateTime SignTime
        {
            get { return _signTime; }
            set { _signTime = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// ���ⱸע
        /// </summary>
        public string Memo
        {
            get { return _memo; }
            set { _memo = value; }
        }
        
        #endregion
    }
    #endregion
}







