using System;

namespace Orm.Model
{
    /// <summary>
    /// ��������
    /// </summary> 
    [Serializable]
     public partial class BsDisclaimer : BaseModel
    {
        byte[] _detail;
        /// <summary>
        /// ����������ϸ
        /// </summary>
        public byte[] Detail
        {
            get { return _detail; }
            set { _detail = value; }
        }
    }
}



