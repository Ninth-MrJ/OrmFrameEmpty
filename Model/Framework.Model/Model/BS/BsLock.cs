using System;

namespace Orm.Model
{
    [Serializable]
    /// <summary>
    ///
    /// </summary>
    public partial class BsLock : BaseModel
    {
        string _ouhosinfoId;
        int _version;
        /// <summary>
        /// Ĭ�Ϲ��췽��.
        /// </summary>
        public BsLock()
        {
        }
        /// <summary>
        /// ����id
        /// </summary>
        public string OuhosinfoId
        {
            get { return _ouhosinfoId; }
            set { _ouhosinfoId = value; }
        }
        /// <summary>
        /// �汾 ÿ�α���+1
        /// </summary>
        public int Version
        {
            get { return _version; }
            set { _version = value; }
        }
    }
}



