

using System;
namespace Orm.Model
{
    /// <summary>
    /// �����շѷ�ʽ - ʵ����
    /// </summary>
    public partial class OuInvoicePay : BaseModel
    {

        private string _code;
        private string _payWayName;

        /// <summary>
        /// ����
        /// </summary>
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        /// <summary>
        /// ֧������
        /// </summary>
        public string PayWayName
        {
            get { return _payWayName; }
            set { _payWayName = value; }
        }

    }
}


