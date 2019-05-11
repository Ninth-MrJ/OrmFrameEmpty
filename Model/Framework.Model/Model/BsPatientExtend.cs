using System;

namespace Orm.Model
{
    /// <summary>
    ///���˱�
    /// </summary>
    
    public partial class BsPatient
    { 
        /// <summary>
        /// ��������
        /// </summary>
        public string PatType { get; set; }

        /// <summary>
        /// ҽԺ����
        /// </summary>
        public string HosPitalName { get; set; }

        private string _locationid;
        /// <summary>
        /// �������id  
        /// BsPatient���е�LocationId �ֶ�ɾ����  ������������ϸ����еõ�֤ʵ
        /// �����Ҫ����ҽԺ �����ouhosinfo  ���� inhosinfo
        /// </summary>
        public string LocationId
        {
            get
            {
                return this._locationid;
            }
            set
            {
                this._locationid = value;
            }
        }

        /// <summary>
        /// ��Ƭ
        /// </summary>
        public byte[] Photo { get; set; }

        private string _pyCode;
        /// <summary>
        /// ƴ����
        /// </summary>
        public string PyCode
        {
            get { return _pyCode; }
            set { _pyCode = value; }
        }

        private string _wbCode;
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



