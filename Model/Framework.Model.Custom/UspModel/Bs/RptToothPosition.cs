using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ������(����)
    /// </summary>
    [Serializable]
   
    public partial class RptToothPosition:BaseModel{
         
        /// <summary>
        /// ������λ
        /// </summary>
        public string ToothPositionLT { get; set; }
        /// <summary>
        /// ������λ
        /// </summary>
        public string ToothPositionRT { get; set; }
        /// <summary>
        /// ������λ
        /// </summary>
        public string ToothPositionLB { get; set; }
        /// <summary>
        /// ������λ
        /// </summary>
        public string ToothPositionRB { get; set; }
        /// <summary>
        /// ��ʾ���� ���顢��ϵ����ݵȵ�
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// ��Դ ���顢���
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// �Ƿ�ϴ��
        /// </summary>
        public bool IsClearTooths { get; set; }

        /// <summary>
        /// ������λ�����ڴ�ӡ����
        /// </summary>
        public string ToothPosition { get; set; }

    }
}



