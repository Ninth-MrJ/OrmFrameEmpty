using System;

namespace Orm.Model
{
    /// <summary>
    ///BPͨ������
    /// </summary>
    [Serializable]
    public partial class BsCommonName : BaseModel
    {
        /// <summary>
        ///BPͨ������
        /// </summary>
        public BsCommonName()
        {
        }

        string _commonName;
        /// <summary>
        /// ͨ����
        /// </summary>
        public string CommonName
        {
            get
            {
                return _commonName;
            }
            set
            {
                _commonName = value;
            }
        }
    }
}



