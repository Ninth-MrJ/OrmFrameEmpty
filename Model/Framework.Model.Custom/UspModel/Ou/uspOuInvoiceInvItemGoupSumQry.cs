using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary> 
    /// �շѷ�Ʊ������Ϣ
    /// </summary>
    [Serializable]
    #region class of Model:uspOuInvoiceInvItemGoupSumQry
   
    public class uspOuInvoiceInvItemGoupSumQry : BaseModel  
    {
         
        private string _name = String.Empty;
        private string _invItemId;
        private double _amount;
        private double _amountFact;
        private double _amountSelf;
        private double _amountTally;
        private double _amountPay;
        private double _amountJZ;
        private double _amountZF;

        public uspOuInvoiceInvItemGoupSumQry()
        {

        }
        #region Public Properties
        /// <summary>
        /// ����
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// ��Ʊ��Ŀid
        /// </summary>
        public string InvItemId
        {
            get { return _invItemId; }
            set { _invItemId = value; }
        }
        /// <summary>
        ///���
        /// </summary>
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        /// <summary>
        /// Ӧ�����
        /// </summary>
        public double AmountFact
        {
            get { return _amountFact; }
            set { _amountFact = value; }
        }
        /// <summary>
        /// ���
        /// </summary>
        public double AmountSelf
        {
            get { return _amountSelf; }
            set { _amountSelf = value; }
        }
        /// <summary>
        //���ͳ��
        /// </summary>
        public double AmountTally
        {
            get { return _amountTally; }
            set { _amountTally = value; }
        }
        /// <summary>
        /// ֧�����
        /// </summary>
        public double AmountPay
        {
            get { return _amountPay; }
            set { _amountPay = value; }
        }
        /// <summary>
        /// ʵ�ս��-Ӧ�ս��
        /// </summary>
        public double AmountJZ
        {
            get { return _amountJZ; }
            set { _amountJZ = value; }
        }
        /// <summary>
        /// Ӧ�����-���
        /// </summary>
        public double AmountZF
        {
            get { return _amountZF; }
            set { _amountZF = value; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string PatName { get; set; }
        /// <summary>
        /// ҽ������
        /// </summary>
        public string DoctorName { get; set; }
        /// <summary>
        /// ����������
        /// </summary>
        public string OperName { get; set; }
        #endregion
    }
    #endregion
}







