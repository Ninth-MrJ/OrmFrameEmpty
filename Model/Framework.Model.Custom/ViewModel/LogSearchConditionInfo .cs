using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ��־��ѯ��������
    /// </summary>
    [Serializable]
    public class LogSearchConditionInfo 
    {
        /// <summary>
        /// �ֿ�ID
        /// </summary>
        public string HouseId {get;set;}
        /// <summary>
        /// ����ID
        /// </summary>
        public string RoomId { get; set; }
        /// <summary>
        /// ����
        /// </summary>
        public string PNo { get; set; }
        /// <summary>
        /// ��Ʒ���
        /// </summary>
        public string  ItemCode {get;set;}
        /// <summary>
        /// ��ѯ�Ŀ�ʼʱ��
        /// </summary>
        public DateTime HappenTimeBegin { get; set; }
        /// <summary>
        /// ��ѯ�Ľ���ʱ��
        /// </summary>
        public DateTime HappenTimeEnd { get; set; }
        /// <summary>
        /// ��������
        /// </summary>
        public int ActType { get; set; }
        /// <summary>
        /// ҽԺID
        /// </summary>
        public int HospitalID { get; set; }
        /// <summary>
        /// �Ƿ��ҳ
        /// </summary>
        public bool isPaging { get; set; }
        /// <summary>
        /// ��ʾ����
        /// </summary>
        public int PageNumber { get; set; }
        /// <summary>
        /// ҳ��
        /// </summary>
        public int PageSize { get; set; }

        public string DimItem { get; set; }
    }
}
