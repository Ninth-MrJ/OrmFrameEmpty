//by lwl
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Model.Custom
{
    /// <summary>
    /// ҽ����չ��
    /// </summary>
    [Serializable]
    public class uspOuDoctorQry : BaseModel  
    {
       
        /// <summary>
        /// ����id
        /// </summary>
        public string DepartmentID { get; set; }

        /// <summary>
        /// ҽ������
        /// </summary>
        public string Name
        {
            get;
            set;
        }
         
        /// <summary>
        /// �Һ����
        /// </summary>
        public string RegTypeId
        {
            get;
            set;
        } 
        
        /// <summary>
        /// ����ID
        /// </summary>
        public string  LocationId
        {
            get;
            set;
        } 
        
        /// <summary>
        /// ���ID
        /// </summary>
        public string TimeSpanId
        {
            get;
            set;
        }

        public int HospitalId { get; set; }   
        /// <summary>
        /// ͣ���־��ȡ����
        /// </summary>
        public bool IsCancel { get; set; }


        private DateTime _scheduleDate;
        /// <summary>
        /// ��������
        /// </summary>
        public DateTime ScheduleDate
        {
            get { return _scheduleDate; }
            set { this._scheduleDate = value; }
        }

        private string _timeBegin;  //��ʼʱ��

        private string _timeEnd;  //����ʱ��

        /// <summary>
        /// ��ʼʱ��
        /// </summary>
        public string TimeBegin
        {
            get { return _timeBegin; }
            set { _timeBegin = value; }
        }

        /// <summary>
        /// ����ʱ��
        /// </summary>
        public string TimeEnd
        {
            get { return _timeEnd; }
            set { _timeEnd = value; }
        }
 
        /// <summary>
        /// ���ID
        /// </summary>
        public string OuDocRegTypeGUID
    {
            get;
            set;
        }

        /// <summary>
        /// ���Ű�ƻ�ID
        /// </summary>
        public string WeekPlanID { get; set; }
        public string RoleId { get; set; }
    }
}

