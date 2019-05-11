using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// �ӹ�������
    /// </summary>
    [Serializable]
    /// <summary>
    /// WorkSheet
    /// </summary>
    public partial class RptWorkSheet:BaseModel{

        private string _patId;
        private string _patName;    
        private string _toothPosition;        
        private string  _processingFactory;
        private string _processingFactoryName;
        private string  _salesMan;
        private string _salesManName;
        private string  _orderType;
        private string _orderTypeName;
        private string  _restoration;
        private string _restorationName;
        private string  _colorimetric;
        private string _colorimetricName;
        private double _amount;
        private int _repairType;
        private string _billNo;
        private string _doctorId;
        private string _doctorName;
        private double _priceIn;
        private double _price;
        private DateTime _sendTime = DateTime.Now;
        private string  _emergencyType;
        private string _emergencyTypeName;
        private DateTime _finishTime = DateTime.Now;
        private DateTime _tryoutTime = DateTime.Now;
        private string _memo;
        private int _attachment;
        private string _attachmentName;
        /// <summary>
        /// ����λ
        /// </summary>
        public string LeftTopTooth { get; set; }
        /// <summary>
        /// ����λ
        /// </summary>
        public string LeftBottonTooth { get; set; }
        /// <summary>
        /// ����λ
        /// </summary>
        public string RightTopTooth { get; set; }
        /// <summary>
        /// ����λ
        /// </summary>
        public string RightBottonTooth { get; set; }
        /// <summary>
        /// �ܽ��
        /// </summary>
        public int TotalAmount { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime OperTime { get; set; }
        /// <summary>
        /// δ�깤
        /// </summary>
        public DateTime NoDoTime { get; set; }
        /// <summary>
        /// ���깤
        /// </summary>
        public DateTime DoneTime{ get; set; }
        /// <summary>
        /// ��ȡ��
        /// </summary>
        public DateTime GetOutime { get; set; }
        /// <summary>
        /// �Դ�
        /// </summary>
        public DateTime WearTime{ get; set; }
        /// <summary>
        /// �Ѵ���
        /// </summary>
        public DateTime TakeOutime{ get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public DateTime ReturnTime{ get; set; }
        /// <summary>
        /// ����ID
        /// </summary>
        public string WorkTypeId { get; set; }

        /// <summary>
        /// Ĭ�Ϲ��췽��.
        /// </summary>
        public RptWorkSheet()
        {
        }

        /// <summary>
        /// �ӹ���.
        /// </summary>
        public string PatID
        {
            get { return this._patId; }
            set { this._patId = value; }
        }
        /// <summary>
        /// ����.
        /// </summary>
        public string PatName
        {
            get { return this._patName; }
            set { this._patName = value; }
        }

        /// <summary>
        /// ��λ.
        /// </summary>
        public string ToothPosition
        {
            get { return this._toothPosition; }
            set { this._toothPosition = value; }
        }

        /// <summary>
        /// �ӹ���.
        /// </summary>
        public string  ProcessingFactory
        {
            get { return this._processingFactory; }
            set { this._processingFactory = value; }
        }

        /// <summary>
        /// �ӹ�������.
        /// </summary>
        public string ProcessingFactoryName
        {
            get { return this._processingFactoryName; }
            set { this._processingFactoryName = value; }
        }

        /// <summary>
        /// ҵ��Ա.
        /// </summary>
        public string  SalesMan
        {
            get { return this._salesMan; }
            set { this._salesMan = value; }
        }

        /// <summary>
        /// ҵ��ԱName.
        /// </summary>
        public string SalesManName
        {
            get { return this._salesManName; }
            set { this._salesManName = value; }
        }

        /// <summary>
        /// ��������.
        /// </summary>
        public string  OrderType
        {
            get { return this._orderType; }
            set { this._orderType = value; }
        }

        /// <summary>
        /// ��������Name.
        /// </summary>
        public string OrderTypeName
        {
            get { return this._orderTypeName; }
            set { this._orderTypeName = value; }
        }

        /// <summary>
        /// �޸���.
        /// </summary>
        public string  Restoration
        {
            get { return this._restoration; }
            set { this._restoration = value; }
        }

        /// <summary>
        /// �޸���Name.
        /// </summary>
        public string RestorationName
        {
            get { return this._restorationName; }
            set { this._restorationName = value; }
        }

        /// <summary>
        /// ��ɫ.
        /// </summary>
        public  string   Colorimetric
        {
            get { return this._colorimetric; }
            set { this._colorimetric = value; }
        }

        /// <summary>
        /// ��ɫName.
        /// </summary>
        public string ColorimetricName
        {
            get { return this._colorimetricName; }
            set { this._colorimetricName = value; }
        }

        /// <summary>
        /// ����.
        /// </summary>
        public double Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        /// <summary>
        /// ������.
        /// </summary>
        public int RepairType
        {
            get { return this._repairType; }
            set { this._repairType = value; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public int Attachment
        {
            get { return this._attachment; }
            set { this._attachment = value; }
        }
        /// <summary>
        /// ����Name
        /// </summary>
        public string AttachmentName
        {
            get { return this._attachmentName; }
            set { this._attachmentName = value; }
        }

        /// <summary>
        /// ����.
        /// </summary>
        public string BillNo
        {
            get { return this._billNo; }
            set { this._billNo = value; }
        }

        /// <summary>
        /// ҽ��Id.
        /// </summary>
        public string DoctorId
        {
            get { return this._doctorId; }
            set { this._doctorId = value; }
        }
        /// <summary>
        /// ҽ��Name.
        /// </summary>
        public string DoctorName
        {
            get { return this._doctorName; }
            set { this._doctorName = value; }
        }
        /// <summary>
        ///  �ܼ۸�.
        /// </summary>
        public double PriceIn
        {
            get { return this._priceIn; }
            set { this._priceIn = value; }
        }
        /// <summary>
        /// ��Ʒ�۸�
        /// </summary>
        public double Price
        {
            get { return this._price; }
            set { this._price= value; }
        }

        /// <summary>
        /// �ͼ�����.
        /// </summary>
        public DateTime SendTime
        {
            get { return this._sendTime; }
            set { this._sendTime = value; }
        }

        /// <summary>
        /// �����̶�.
        /// </summary>
        public  string  EmergencyType
        {
            get { return this._emergencyType; }
            set { this._emergencyType = value; }
        }

        /// <summary>
        /// �����̶�Name.
        /// </summary>
        public string EmergencyTypeName
        {
            get { return this._emergencyTypeName; }
            set { this._emergencyTypeName = value; }
        }


        /// <summary>
        /// ���ʱ��.
        /// </summary>
        public DateTime FinishTime
        {
            get { return this._finishTime; }
            set { this._finishTime = value; }
        }

        /// <summary>
        /// �Դ�����.
        /// </summary>
        public DateTime TryoutTime
        {
            get { return this._tryoutTime; }
            set { this._tryoutTime = value; }
        }

        /// <summary>
        /// ��ע.
        /// </summary>
        public string Memo
        {
            get { return this._memo; }
            set { this._memo = value; }
        }
        /// <summary>
        /// �ܺ�
        /// </summary>
        public double Count { get; set; }

        /// <summary>
        /// ����id
        /// </summary>
        public string HosId { get; set; }

        /// <summary>
        /// �ӹ���״̬
        /// </summary>
        public string WorkTypeName { get; set; }

        

    }
}



