using System;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ����ѯ��������
    /// </summary>
    [Serializable]
    public class StockSearchConditionInfo 
    {     
        /// <summary>
        /// ҽԺID
        /// </summary>
        public int HospitalID { get; set; }
        /// <summary>
        /// �ֿ�ID
        /// </summary>
        public string HouseId {get;set;}
        /// <summary>
        /// ����ID
        /// </summary>
        public string RoomId { get; set; }
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public string  ItemCode {get;set;}
        /// <summary>
        /// ��Ʒ����
        /// </summary>
        public string ItemName { get; set; }
        /// <summary>
        /// ��˾ID
        /// </summary>
        public string CompId { get;set;}
        /// <summary>
        /// ��ѯ�Ŀ�ʼ�¼�
        /// </summary>
        public DateTime StoreDateBegin {get;set;}
        /// <summary>
        /// ��ѯ�Ľ����¼�
        /// </summary>
        public DateTime StoreDateEnd { get; set; }
        /// <summary>
        /// ���޵Ŀ�ʼʱ��
        /// </summary>
        public DateTime LimitDateBegin { get; set; }
        /// <summary>
        /// ���޵Ľ���ʱ��
        /// </summary>
        public DateTime LimitDateEnd { get; set; }
        /// <summary>
        /// �Ƿ��������ʱ��
        /// </summary>
        public bool IsSearchStoreDate { get; set; }
        /// <summary>
        /// �Ƿ���������ʱ��
        /// </summary>
        public bool IsSearchLimitDate { get; set; }
        /// <summary>
        /// �Ƿ���������
        /// </summary>
        public bool IsSearchUnderLineKc { get; set; }
        /// <summary>
        /// �Ƿ���������
        /// </summary>
        public bool IsSearchUperLineKc { get; set; }
        /// <summary>
        /// ��Ŀ��ϴ���ID
        /// </summary>
        public string GroupMainID { get; set; }
        /// <summary>
        /// ��ϲ�ѯ ���� 
        /// </summary>
        public string DimItem { get; set; }
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

   
    }
}
