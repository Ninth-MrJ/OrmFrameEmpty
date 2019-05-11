using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ��־��ѯ��������
    /// </summary>
    [Serializable]
    public class BillSearchConditionInfo 
    {
        /// <summary>
        /// �ֿ�ID 
        /// </summary>
        public string HouseId {get;set;}
        /// <summary>
        /// ��Ŀ(��Ʒ)
        /// </summary>
        public string ItemId { get; set; }
        /// <summary>
        /// ����ⵥ��
        /// </summary>
        public string BillNo { get;set;}
        /// <summary>
        /// ��������
        /// </summary>
        public int LsActType { get; set; }
        public string Type { get; set; }
        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        public DateTime HappenTimeBegin { get; set; }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime HappenTimeEnd { get; set; }

        /// <summary>
        /// �Ƿ����
        /// </summary>
        public bool IsSign { get; set; }

    }
}
