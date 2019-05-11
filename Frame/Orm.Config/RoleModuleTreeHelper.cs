using Orm.Model.Custom;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Orm.Config
{
    /// <summary>
    /// ��ɫģ��/Ȩ����״�ṹ������
    /// </summary>
    public class RoleModuleTreeHelper
    {
        private RoleModuleTreeHelper()
        {


        }

        #region ȫ�ֱ���

        private readonly static string[] assemblyNames =
        {
            "Orm.MainWindow",
            "Orm.Client.HuRmSystem",
            "Orm.Client.OuPatient",
           "Orm.Client.SystemMaintenance",
            "Orm.Client.DataAnalysis",
            "Orm.Client.Treatment",
           "Orm.Client.FrontDesk",
            "Orm.Client.HomeHealth",
            "Orm.Client.Base",
             #region SystemMaintenance���������
            //"SystemMaintenance_Plugln_ChangedLog",//�޸���־��ѯ
            //"SystemMaintenance_Plugln_FrmInvoiceManage",//��Ʊ����
            //"SystemMaintenance_Plugln_FrmDictionaryMaintain1",//��Ŀ�ֵ�ά���ۺ�
            //"SystemMaintenance_Plugln_FrmRecordTemplate",//����ģ��ά��
            //"SystemMaintenance_Plugln_FrmLocation",//������Ϣ
            //"SystemMaintenance_Plugln_FrmComboMaintain",//����ײ�ά��
            //"SystemMaintenance_Plugln_FrmMaintenanceIndex",//װ�ش���
            //"SystemMaintenance_Plugln_FrmHospitalUnionManage",//ҽ�������
            //"SystemMaintenance_Plugln_UcBackupRestore",//���ݱ���
            //"SystemMaintenance_Plugln_SysSettingMaintain",//��������ά��
            //"SystemMaintenance_Plugln_FrmStaffMaintain",//�˺Ź���
            //"SystemMaintenance_Plugln_FrmRecipeTemplate",//����ģ��ά��
            //"SystemMaintenance_Plugln_FrmLocalParSetting",//ϵͳ����
            //"SystemMaintenance_Plugln_FrmPhysicalPackage",//����ײ�ά��
            //"SystemMaintenance_Plugln_FrmBasicListMaintain",//������ά��
            //"SystemMaintenance_Plugln_FrmJurisdictionSet",//Ȩ������
            //"SystemMaintenance_Plugln_FrmDiagnoseAdvise",//��Ͻ���ά��
            //"SystemMaintenance_Plugln_FrmLocationSetting",//������ά��
            //"SystemMaintenance_Plugln_FrmKunShanDictionary",//��ǻ��Ŀ�ֵ�
            //"SystemMaintenance_Plugln_FrmRecordSphrase",//��ǻ����ģ��ά��
            //"SystemMaintenance_Plugln_FrmDictionaryMaintain1",//�ۺ���Ŀ�ֵ�ά��
            //"SystemMaintenance_Plugln_FrmSpecialist",//ר�ҹ���
            //"SystemMaintenance_Plugln_FrmAppeal",//�ƶ�ר��
            #endregion
              #region FrontDesk���������
             // "FrontDesk_PlugIn_FrmExecute",
             // "FrontDesk_PlugIn_Newarchives",
             // "FrontDesk_PlugIn_FrmNewistally",
             //"FrontDesk_PlugIn_DistributeMedicine",
             //"FrontDesk_PlugIn_FrmCashierReportSet",
             //"FrontDesk_PlugIn_FrmNewEditBooking",
             //"FrontDesk_PlugIn_FrmDocumentQuery",
             //"FrontDesk_PlugIn_FrmPatientQuery",
             //"FrontDesk_PlugIn_FrmCashier",
             // "FrontDesk_PlugIn_Nurseindex",//װ�ش���
             // "FrontDesk_PlugIn_Reciprocalmg_AiDing",
             // "FrontDesk_PlugIn_Scheduling",
             // "FrontDesk_PlugIn_FrmKunShanVIPManagement",
            #endregion
              #region HuRmSystem���������
             // "HuRmSystem_Plugln_FrmApply",
             // "HuRmSystem_Plugln_FrmBillSearch",
             // "HuRmSystem_Plugln_FrmBuyPlan",
             //"HuRmSystem_Plugln_FrmDocument",
             //"HuRmSystem_Plugln_FrmInventory",
             //"HuRmSystem_Plugln_FrmInventoryModify",
             //"HuRmSystem_Plugln_FrmInventoryQuery",
             //"HuRmSystem_Plugln_FrmLogQuery",
             //"HuRmSystem_Plugln_FrmOutBound",
             // "HuRmSystem_Plugln_FrmOutStockAlarm",
             // "HuRmSystem_Plugln_FrmStorage",
             // "HuRmSystem_Plugln_FrmValidityAlert",
             // "HuRmSystem_Plugln_instrument",
             // "HuRmSystem_Plugln_Inventoryindex",
            #endregion

            #region HomeHealth���������

            //"HomeHealth_Plugln_FrmOrderManage",//�ɹ���
            //"HomeHealth_Plugln_FrmLifeService",//�������
            //"HomeHealth_Plugln_FrmInformFamilyMember",//֪ͨ����
            //"HomeHealth_Plugln_FrmHealthManagement",//����������
            //"HomeHealth_Plugln_HomeHealthIndex",//װ�ش���



            #endregion



        };
        /// <summary>
        /// �����ռ����Ƽ���
        /// </summary>
        private readonly static string[] namespaceNames = {
            "Orm.MainWindow",
            "Orm.MainWindow.DataAnalysis",
            "Orm.MainWindow.HomePage",
            "Orm.Client.HuRmSystem",
            "Orm.Client.OuPatient",
            "Orm.Client.SystemMaintenance",
            "Orm.MainWindow.DoctorPatientCommunication",
            "Orm.Client.DataAnalysis",
            "Orm.Client.Treatment",
           "Orm.Client.FrontDesk",
            "Orm.Client.HomeHealth",
            "Orm.Client.Base",
            #region SystemMaintenance���������
            //"SystemMaintenance_Plugln_FrmKunShanDictionaryMaintain",
            //"SystemMaintenance_Plugln_FrmHospitalUnionManage",//ҽ�������
            //"SystemMaintenance_Plugln_ChangedLog",//�޸���־��ѯ
            //"SystemMaintenance_Plugln_FrmInvoiceManage",//��Ʊ����
            //"SystemMaintenance_Plugln_FrmRecordTemplate",//����ģ��ά��
            //"SystemMaintenance_Plugln_FrmLocation",//������Ϣ
            //"SystemMaintenance_Plugln_FrmComboMaintain",//����ײ�ά��
            //"SystemMaintenance_Plugln_FrmMaintenanceIndex",//װ�ش���
            //"SystemMaintenance_Plugln_SysSettingMaintain",//��������ά��
            //"SystemMaintenance_Plugln_UcBackupRestore",//���ݱ���
            //"SystemMaintenance_Plugln_FrmStaffMaintain",//�˺Ź���
            //"SystemMaintenance_Plugln_FrmRecipeTemplate",//����ģ��ά��
            //"SystemMaintenance_Plugln_FrmLocalParSetting",//ϵͳ����
            //"SystemMaintenance_Plugln_FrmPhysicalPackage",//����ײ�ά��
            //"SystemMaintenance_Plugln_FrmBasicListMaintain",//������ά��
            //"SystemMaintenance_Plugln_FrmJurisdictionSet",//Ȩ������
            //"SystemMaintenance_Plugln_FrmDiagnoseAdvise",//��Ͻ���ά��
            //"SystemMaintenance_Plugln_FrmLocationSetting",//������ά��
            //"SystemMaintenance_Plugln_FrmKunShanDictionary",//��ǻ��Ŀ�ֵ�
            //"SystemMaintenance_Plugln_FrmDictionaryMaintain1",//�ۺ���Ŀ�ֵ�ά��
            //"SystemMaintenance_Plugln_FrmRecordSphrase",//��ǻ����ģ��ά��
            ////"SystemMaintenance_Plugln_FrmSpecialist",//ר�ҹ���
            ////"SystemMaintenance_Plugln_FrmAppeal",//�ƶ�ר��
            #endregion
               #region FrontDesk���������
          //  "FrontDesk_PlugIn_FrmExecute",
          //"FrontDesk_PlugIn_Newarchives",
          //"FrontDesk_PlugIn_FrmNewistally",
          //  "FrontDesk_PlugIn_DistributeMedicine",
          //  "FrontDesk_PlugIn_FrmCashierReportSet",
          //  "FrontDesk_PlugIn_FrmNewEditBooking",
          //  "FrontDesk_PlugIn_FrmDocumentQuery",
          //"FrontDesk_PlugIn_FrmPatientQuery",
          //"FrontDesk_PlugIn_FrmCashier",
          //  "FrontDesk_PlugIn_Nurseindex",//װ�ش���
          //"FrontDesk_PlugIn_Reciprocalmg_AiDing",
          //"FrontDesk_PlugIn_Scheduling",
          //  "FrontDesk_PlugIn_FrmKunShanVIPManagement",
            #endregion
            #region HuRmSystem���������
             // "HuRmSystem_Plugln_FrmApply",
             // "HuRmSystem_Plugln_FrmBillSearch",
             // "HuRmSystem_Plugln_FrmBuyPlan",
             //"HuRmSystem_Plugln_FrmDocument",
             //"HuRmSystem_Plugln_FrmInventory",
             //"HuRmSystem_Plugln_FrmInventoryModify",
             //"HuRmSystem_Plugln_FrmInventoryQuery",
             //"HuRmSystem_Plugln_FrmLogQuery",
             //"HuRmSystem_Plugln_FrmOutBound",
             // "HuRmSystem_Plugln_FrmOutStockAlarm",
             // "HuRmSystem_Plugln_FrmStorage",
             // "HuRmSystem_Plugln_FrmValidityAlert",
             // "HuRmSystem_Plugln_instrument",
             // "HuRmSystem_Plugln_Inventoryindex",
            #endregion
             #region HomeHealth���������

            //"HomeHealth_Plugln_FrmOrderManage",//�ɹ���
            //"HomeHealth_Plugln_FrmLifeService",//�������
            //"HomeHealth_Plugln_FrmInformFamilyMember",//֪ͨ����
            //"HomeHealth_Plugln_FrmHealthManagement",//����������
            //"HomeHealth_Plugln_HomeHealthIndex",//װ�ش���



            #endregion


        };

        private static System.Reflection.Assembly[] assemblies = null;

        #endregion

        #region ���ⷽ��

        /// <summary>
        /// ��ȡ��״Ȩ������
        /// </summary>
        /// <param name="lstUspRoleModule"></param>
        /// <returns></returns>
        public static Collection<TreeClass<uspRoleModuleQry>> GetTreeViewRoleModule(List<uspRoleModuleQry> lstUspRoleModule)
        {
            var tempLstQry = lstUspRoleModule.Where(q => q.ParentID == "0" || string.IsNullOrEmpty(q.ParentID)).ToList();
            lstUspRoleModule.RemoveAll(q => q.ParentID == "0" || string.IsNullOrEmpty(q.ParentID));
            int count = tempLstQry.Count();
            var tempLstTreeClass = new Collection<TreeClass<uspRoleModuleQry>>();
            for (int i = 0; i < count; i++)
            {
                tempLstTreeClass.Add(TreeViewRoleModuleQry(tempLstQry[i], lstUspRoleModule));
            }
            return tempLstTreeClass;
        }


        /// <summary>
        /// ��ȡ��״�ṹ��Ȩ����ʾ
        /// </summary>
        /// <param name="qry"></param>
        private static TreeClass<uspRoleModuleQry> TreeViewRoleModuleQry(uspRoleModuleQry qry, List<uspRoleModuleQry> lstQry)
        {
            if (lstQry == null)
            {
                return null;//�ض�
            }
            var tempLstQry = lstQry.Where(q => q.ParentID == qry.ID).ToList();
            lstQry.RemoveAll(q => q.ParentID == qry.ID);

            int count = tempLstQry.Count;
            var tempLstTreeClass = new Collection<TreeClass<uspRoleModuleQry>>();
            for (int i = 0; i < count; i++)
            {
                var temp = TreeViewRoleModuleQry(tempLstQry[i], lstQry);
                tempLstTreeClass.Add(temp);
            }
            var tempTreeClass = new TreeClass<uspRoleModuleQry>
            {
                Key = qry,
                Value = tempLstTreeClass
            };
            return tempTreeClass;
        }


        /// <summary>
        /// ��ȡ��ص�չʾģ��(DisplayModule)
        /// </summary>
        /// <param name="lstTcDisplayModule"></param>
        /// <returns></returns>
        public static List<Orm.Model.Custom.DisplayModule> GetListDisplayModule(List<Orm.Model.Custom.TreeClass<Orm.Model.Custom.DisplayModule>> lstTcDisplayModule)
        {
            var tempLstDisplayModule = new List<Orm.Model.Custom.DisplayModule>();
            if (lstTcDisplayModule == null)
            {
                return tempLstDisplayModule;
            }
            //int count = Orm.Config.UserProfiles.CurrentAuthority.Count;
            int count = lstTcDisplayModule.Count;
            for (int i = 0; i < count; i++)
            {
                if (lstTcDisplayModule[i].Key.EntityName != null)
                {
                    lstTcDisplayModule[i].Key.CreateElement = CreateElement;
                    tempLstDisplayModule.Add(lstTcDisplayModule[i].Key);
                }
            }
            return tempLstDisplayModule;
        }

        private static object CreateElement(string entityName)
        {
            return SelectFrameworkElement(entityName);
        }

        public static System.Windows.FrameworkElement SelectFrameworkElement(string entityName, params object[] args)
        {
            return FromEntityNameToTypeObject<System.Windows.FrameworkElement>(entityName, args);
        }


        public static System.Windows.Window SelectWindow(string entityName, params object[] args)
        {
            return FromEntityNameToTypeObject<System.Windows.Window>(entityName, args);
        }

        static T FromEntityNameToTypeObject<T>(string entityName, params object[] args) where T : System.Windows.FrameworkElement
        {
            if (assemblies == null)
            {
                int length = assemblyNames.Length;
                assemblies = new System.Reflection.Assembly[length];
                for (int index = 0; index < length; index++)
                {
                    assemblies[index] = AppDomain.CurrentDomain.Load(assemblyNames[index]);
                }
            }

            int act = assemblies.Length;
            T tempTypeObject = null;
            bool flag = true;
            if (!String.IsNullOrEmpty(entityName))
            {
                if (entityName.Split('.').Count() > 1)
                {
                    flag = false;
                }
                try
                {
                    for (int i = 0; i < act; i++)
                    {
                        if (flag)
                        {
                            tempTypeObject = SelectFrameworkElement<T>(assemblies[i], namespaceNames, entityName, args);
                        }
                        else
                        {
                            tempTypeObject = SelectFrameworkElement<T>(assemblies[i], entityName, args);
                        }
                        if (tempTypeObject != null)
                        {
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.ToString() + entityName);
                }
            }
            return tempTypeObject;
        }

        static T SelectFrameworkElement<T>(System.Reflection.Assembly assembly, string[] namespaceNames, string entityName, params object[] args) where T : System.Windows.FrameworkElement
        {
            if (assembly == null)
            {
                return null;
            }
            Object obj = null;
            int tempLength = namespaceNames.Length;
            for (int i = 0; i < tempLength; i++)
            {
                var type = assembly.GetType(string.Format("{0}.{1}", namespaceNames[i], entityName));
                if (type != null)
                {
                    obj = Activator.CreateInstance(type, args);
                }
                if (obj is T)
                {
                    return obj as T;
                }
            }
            return null;
        }



        static T SelectFrameworkElement<T>(System.Reflection.Assembly assembly, string entityName, params object[] args) where T : System.Windows.FrameworkElement
        {
            if (assembly == null)
            {
                return null;
            }
            var type = assembly.GetType(entityName);
            Object obj = null;
            if (type != null)
            {
                obj = Activator.CreateInstance(type, args);
            }
            if (obj is T)
            {
                return obj as T;
            }
            return null;
        }
        #endregion
    }
}
