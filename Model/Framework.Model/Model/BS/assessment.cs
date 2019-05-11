using System;

namespace Orm.Model
{
    /// <summary>
    /// ������
    /// </summary>
    [Serializable]
    public partial class Assessment : BaseModel
    {

        string _assessmentName;


        /// <summary>
        /// ��������
        /// </summary>
        public string Name
        {
            get { return _assessmentName; }
            set { _assessmentName = value; }
        }

        int _orderby;
        /// <summary>
        /// ����
        /// </summary>
        public int Orderby
        {
            get { return _orderby; }
            set { _orderby = value; }
        }

        string _pyCode = string.Empty;
        /// <summary>
        /// ƴ����
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        string _wbCode = string.Empty;
        /// <summary>
        /// �����
        /// </summary>
        public string WbCode
        {
            get { return _wbCode; }
            set { _wbCode = value; }
        }
    }
}



