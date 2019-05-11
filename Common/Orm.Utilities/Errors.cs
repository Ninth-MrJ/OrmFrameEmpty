using System;
using System.Collections;


namespace Orm.Utilities
{
    /// <summary>
    /// Summary description for Errors.
    /// </summary>
    /// <remarks>by Simon 2006-1-3</remarks>
    public class Errors
    {
        public const int SUCCESS = 1;
        /// <summary>
        /// ϵͳ����,����ԭ��
        /// </summary>
        public const int ERROR_Authorize_FAILED = -1000;
        /// <summary>
        /// ��˴���
        /// </summary>
		public const int ERROR_FAILD = -1;
        /// <summary>
        /// ���벻���Ϲ���
        /// </summary>
        public const int ERROR_PASSWORD_FAIL = -5;
        /// <summary>
        /// �Ƿ�����ظ�
        /// </summary>
        public const int ERROR_SQL_DUPLICATE = -20;
        /// <summary>
        /// Email�Ѿ���ע���
        /// </summary>
        public const int ERROR_EMAIL_DUPLICATE = -25;
        /// <summary>
        /// �û������ܰ��������ַ�
        /// </summary>
        public const int ERROR_INVALID_USERNAME = -30;
        /// <summary>
        /// ����SQL����
        /// </summary>
        public const int ERROR_SQL_FAILD = -100;
        /// <summary>
        /// ɾ��ʧ��
        /// </summary>
        public const int ERROR_DELETE_FAILED = -200;
        /// <summary>
        /// ɾ��ʱ���ӽڵ�
        /// </summary>
        public const int ERROR_DELETE_HASCHILD = -300;
        /// <summary>
        /// ������Ч
        /// </summary>
        public const int ERROR_PARAMETER_INVALID = -400;
        /// <summary>
        /// SQL������ô���
        /// </summary>
        public const int ERROR_SQL_REFERENCE = -500;
        /// <summary>
        /// ��Ч����
        /// </summary>
        public const int ERROR_SQL_INVALIDOBJECT = -600;

        /// <summary>
        /// ɾ�����ʱʹ�ã���ʾ�û����������ɾ��
        /// </summary>
        public const int ERROR_DELETE_NOTHING = -700;
        /// <summary>
        /// ���ýڲ��Ϸ�������������
        /// </summary>
        public const int ERROR_ItemTemplateConfigError = -800;

        /// <summary>
        /// ģ����������
        /// </summary>
        public const int ERROR_TemplateHasAttributes = -900;

        /// <summary>
        /// �����ļ��ϼ�¼��Ϊ0
        /// </summary>
        public const int OPERATOR_LISTCOUNT_ZERO = 222;
        /// <summary>
        /// ģ��Ϊ��
        /// </summary>
        public const int TEMPLATE_NULL = -2000;
        /// <summary>
        /// ģ���ʽ��Ч
        /// </summary>
        public const int TEMPLATE_INVALID = -2100;
        /// <summary>
        /// ģ��û����ģ��
        /// </summary>
        public const int TEMPLATE_NONEITEM = -2200;

        #region private static int GetSQLExceptionCode(System.Data.SqlClient.SqlException ex)
        /// <summary>
        /// ��׽SQL Exception
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        private static int GetSQLExceptionCode(System.Data.SqlClient.SqlException ex)
        {
            if (ex == null) return ERROR_SQL_FAILD;
            Hashtable ht = new Hashtable();
            ht.Add(547, ERROR_SQL_REFERENCE);
            ht.Add(208, ERROR_SQL_INVALIDOBJECT);
            if (ht[ex.Number] == null) return ERROR_SQL_FAILD;
            return Int32.Parse(ht[ex.Number].ToString());
        }
        #endregion

        #region private static int GetSystemExceptionCode(System.Exception ex)
        //��׽System Exception
        private static int GetSystemExceptionCode(System.Exception ex)
        {
            return ERROR_FAILD;
        }
        #endregion

        #region public static int GetExceptionCode(System.Exception ex)
        /// <summary>
        /// ����Exception Code
        /// </summary>
        /// <param name="ex"></param>
        /// <returns></returns>
        public static int GetExceptionCode(System.Exception ex)
        {

            System.Type type = ex.GetType();

            if (type.FullName == "System.Data.SqlClient.SqlException")
            {
                System.Data.SqlClient.SqlException sqlex = (System.Data.SqlClient.SqlException)ex;
                return GetSQLExceptionCode(sqlex);
            }
            return GetSystemExceptionCode(ex);
        }
        #endregion

        /// <summary>
        /// �õ�������Ϣ
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string GetErrorMessage(int number)
        {
            Hashtable ht = new Hashtable();
            ht.Add(SUCCESS, "�����ɹ�");
            ht.Add(ERROR_FAILD, "����ʧ��");
            ht.Add(ERROR_PASSWORD_FAIL, "���벻����Ҫ��");
            ht.Add(ERROR_INVALID_USERNAME, "�û������ܰ��������ַ�");
            ht.Add(ERROR_SQL_DUPLICATE, "�����Ѿ�����");
            ht.Add(ERROR_EMAIL_DUPLICATE, "Email�Ѿ���ע���");
            ht.Add(ERROR_SQL_FAILD, "���ݿ������������");
            ht.Add(ERROR_DELETE_FAILED, "ɾ��ʧ��");
            ht.Add(ERROR_DELETE_HASCHILD, "����Ŀ���ӽڵ㣬����ɾ���ӽڵ㣬���ܼ���");
            ht.Add(ERROR_PARAMETER_INVALID, "����Ĳ�����Ч");
            ht.Add(ERROR_SQL_REFERENCE, "����Ŀ�Ѿ�ʹ�ã�����ɾ��;����û���ҵ���Ӧ������ֵ");
            ht.Add(ERROR_SQL_INVALIDOBJECT, "SQLϵͳ��������ϵͳ����Ա��ϵ");
            ht.Add(ERROR_DELETE_NOTHING, "���������ɾ��");
            ht.Add(ERROR_ItemTemplateConfigError, "���ýڲ��Ϸ�������������");
            ht.Add(ERROR_TemplateHasAttributes, "ģ����������");

            //ģ��
            ht.Add(TEMPLATE_NULL, "ģ�岻��Ϊ��");
            ht.Add(TEMPLATE_INVALID, "ģ���ʽ��Ч");
            ht.Add(TEMPLATE_NONEITEM, "ģ��û����ģ��");
            ht.Add(ERROR_Authorize_FAILED, "��˴���");
            if (ht[number] == null) return "����ʧ��";
            return ht[number].ToString();
        }
    }
}
