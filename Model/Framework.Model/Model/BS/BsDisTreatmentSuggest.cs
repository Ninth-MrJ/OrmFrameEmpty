using System;

namespace Orm.Model
{
    /// <summary>
    /// �������ƽ���
    /// </summary>
    [Serializable]
    public partial class BsDisTreatmentSuggest : BaseModel
    {
        string _name;
        /// <summary>
        /// ��������
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        string _describe;
        /// <summary>
        /// ������������
        /// </summary>
        public string Describe
        {
            get { return _describe; }
            set { _describe = value; }
        }
    }
}



