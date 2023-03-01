using Forxap.Framework.Extensions;
using Forxap.Framework.UI;
using SAPbobsCOM;
using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistony.AddonName.BO;

namespace Vistony.AddonName.BLL
{
    public  class Control_EnvasadoDAL
    {
        public void ObtenerOT_Trasvase(string DocNum, Recordset recordset, string EditText1)
        {


            if (recordset == null)
            {

            }
            string StrHANA = string.Empty;
            StrHANA = string.Format("SELECT DISTINCT a.\"U_SYP_OP_ENV\" \"OT_Referencia\" FROM OWOR a where \"DocNum\" = '{0}' ", DocNum);

            recordset.DoQuery(StrHANA);
            string OT_MEZCLA = recordset.Fields.Item("OT_Referencia").Value.ToString();

            EditText1 = OT_MEZCLA;

        }
        public VIS_OWOR_ENV_C ObtenerCabecera(string DocEntry,string DocNum, string U_VIS_APRO_DOC, string U_VIS_FEC_APRO,
        string U_VIS_HOR_APRO, string U_VIS_NOM_REP, double U_VIS_PESO_OPTIM, double U_VIS_PESO_MAX,
        string U_VIS_UND_MED, string U_VIS_OT_MEZCLA,
        string U_VIS_LOTE_PT, string U_VIS_FIR_LAB_AP, string U_VIS_PRE_LIMP1,
        string U_VIS_PRE_LIMP2, string U_VIS_PRE_LIMP3, string U_VIS_HOR_ENTR_MU_INI, string U_VIS_HOR_APRO_MU_INI,
        string U_VIS_FIR_LAP_MU_INI, string U_VIS_HOR_ENTR_MU_FIN, 
        string U_VIS_HOR_APRO_MU_FIN, string U_VIS_FIR_LAP_MU_FIN,
        string U_VIS_NUM_TANQUE, string U_VIS_OT_ENVASADO, 
        
        string U_VIS_FECHA_P1,
        string U_VIS_HORA_INI_P1, string U_VIS_HORA_FIN_P1, string U_VIS_ENV_P1,
        string U_VIS_ETI_P1, string U_VIS_ENC1_P1, string U_VIS_ENC2_P1,
        string U_VIS_OP1_P1, string U_VIS_OP2_P1, string U_VIS_MAR1_P1,
        string U_VIS_MAR2_P1, string U_VIS_COD_REG_BAL_P1,string U_VIS_PRES_P1,string U_VIS_CANTIDAD_P1,Grid Grid1,

        string U_VIS_FECHA_P2,
        string U_VIS_HORA_INI_P2, string U_VIS_HORA_FIN_P2, string U_VIS_ENV_P2,
        string U_VIS_ETI_P2, string U_VIS_ENC1_P2, string U_VIS_ENC2_P2,
        string U_VIS_OP1_P2, string U_VIS_OP2_P2, string U_VIS_MAR1_P2,
        string U_VIS_MAR2_P2, string U_VIS_COD_REG_BAL_P2, string U_VIS_PRES_P2,
        string U_VIS_CANTIDAD_P2,

        string U_VIS_FECHA_P3,
        string U_VIS_HORA_INI_P3, string U_VIS_HORA_FIN_P3, string U_VIS_ENV_P3,
        string U_VIS_ETI_P3, string U_VIS_ENC1_P3, string U_VIS_ENC2_P3,
        string U_VIS_OP1_P3, string U_VIS_OP2_P3, string U_VIS_MAR1_P3,
        string U_VIS_MAR2_P3, string U_VIS_COD_REG_BAL_P3, string U_VIS_PRES_P3,
        string U_VIS_CANTIDAD_P3)
        {

            VIS_OWOR_ENV_C vis_owor_env_c_TransferDocument = new VIS_OWOR_ENV_C();
            List<VIS_OWOR_ENV_C> vis_owor_env_c_List = new List<VIS_OWOR_ENV_C>();
            //Guid code = Guid.NewGuid();
            vis_owor_env_c_TransferDocument.DocEntry = DocEntry;
            vis_owor_env_c_TransferDocument.DocNum = DocNum;
            //vis_owor_env_c_TransferDocument.U_VIS_APRO_DOC = U_VIS_APRO_DOC;
            //vis_owor_env_c_TransferDocument.U_VIS_FEC_APRO = U_VIS_FEC_APRO;
            //vis_owor_env_c_TransferDocument.U_VIS_HOR_APRO = U_VIS_HOR_APRO;
            vis_owor_env_c_TransferDocument.U_VIS_NOM_REP = U_VIS_NOM_REP;
            //vis_owor_env_c_TransferDocument.U_VIS_PESO_OPTIM = U_VIS_PESO_OPTIM;
            //vis_owor_env_c_TransferDocument.U_VIS_PESO_MAX = U_VIS_PESO_MAX;
            vis_owor_env_c_TransferDocument.U_VIS_UND_MED = U_VIS_UND_MED;
            vis_owor_env_c_TransferDocument.U_VIS_OT_MEZCLA = U_VIS_OT_MEZCLA;
            vis_owor_env_c_TransferDocument.U_VIS_LOTE_PT = U_VIS_LOTE_PT;
            //vis_owor_env_c_TransferDocument.U_VIS_FIR_LAB_AP = U_VIS_FIR_LAB_AP;
            vis_owor_env_c_TransferDocument.U_VIS_PRE_LIMP1 = U_VIS_PRE_LIMP1;
            vis_owor_env_c_TransferDocument.U_VIS_PRE_LIMP2 = U_VIS_PRE_LIMP2;
            vis_owor_env_c_TransferDocument.U_VIS_PRE_LIMP3 = U_VIS_PRE_LIMP3;
            //vis_owor_env_c_TransferDocument.U_VIS_HOR_ENTR_MU_INI = U_VIS_HOR_ENTR_MU_INI;
            //vis_owor_env_c_TransferDocument.U_VIS_HOR_APRO_MU_INI = U_VIS_HOR_APRO_MU_INI;
            //vis_owor_env_c_TransferDocument.U_VIS_FIR_LAP_MU_INI = U_VIS_FIR_LAP_MU_INI;
            //vis_owor_env_c_TransferDocument.U_VIS_HOR_ENTR_MU_FIN = U_VIS_HOR_ENTR_MU_FIN;
            //vis_owor_env_c_TransferDocument.U_VIS_HOR_APRO_MU_FIN = U_VIS_HOR_APRO_MU_FIN;
            //vis_owor_env_c_TransferDocument.U_VIS_FIR_LAP_MU_FIN = U_VIS_FIR_LAP_MU_FIN;
            vis_owor_env_c_TransferDocument.U_VIS_NUM_TANQUE = U_VIS_NUM_TANQUE;
            vis_owor_env_c_TransferDocument.U_VIS_OT_ENVASADO = U_VIS_OT_ENVASADO;

            vis_owor_env_c_TransferDocument.U_VIS_FECHA_P1 = U_VIS_FECHA_P1;
            vis_owor_env_c_TransferDocument.U_VIS_HORA_INI_P1 = U_VIS_HORA_INI_P1;
            vis_owor_env_c_TransferDocument.U_VIS_HORA_FIN_P1 = U_VIS_HORA_FIN_P1;
            vis_owor_env_c_TransferDocument.U_VIS_ENV_P1 = U_VIS_ENV_P1;
            vis_owor_env_c_TransferDocument.U_VIS_ETI_P1 = U_VIS_ETI_P1;
            vis_owor_env_c_TransferDocument.U_VIS_ENC1_P1 = U_VIS_ENC1_P1;
            vis_owor_env_c_TransferDocument.U_VIS_ENC2_P1 = U_VIS_ENC2_P1;
            vis_owor_env_c_TransferDocument.U_VIS_OP1_P1 = U_VIS_OP1_P1;
            vis_owor_env_c_TransferDocument.U_VIS_OP2_P1 = U_VIS_OP2_P1;
            vis_owor_env_c_TransferDocument.U_VIS_MAR1_P1 = U_VIS_MAR1_P1;
            vis_owor_env_c_TransferDocument.U_VIS_MAR2_P1 = U_VIS_MAR2_P1;
            vis_owor_env_c_TransferDocument.U_VIS_COD_REG_BAL_P1 = U_VIS_COD_REG_BAL_P1;
            vis_owor_env_c_TransferDocument.U_VIS_PRES_P1 = U_VIS_PRES_P1;
            vis_owor_env_c_TransferDocument.U_VIS_CANTIDAD_P1 = U_VIS_CANTIDAD_P1;

            vis_owor_env_c_TransferDocument.U_VIS_FECHA_P2 = U_VIS_FECHA_P2;
            vis_owor_env_c_TransferDocument.U_VIS_HORA_INI_P2 = U_VIS_HORA_INI_P2;
            vis_owor_env_c_TransferDocument.U_VIS_HORA_FIN_P2 = U_VIS_HORA_FIN_P2;
            vis_owor_env_c_TransferDocument.U_VIS_ENV_P2 = U_VIS_ENV_P2;
            vis_owor_env_c_TransferDocument.U_VIS_ETI_P2 = U_VIS_ETI_P2;
            vis_owor_env_c_TransferDocument.U_VIS_ENC1_P2 = U_VIS_ENC1_P2;
            vis_owor_env_c_TransferDocument.U_VIS_ENC2_P2 = U_VIS_ENC2_P2;
            vis_owor_env_c_TransferDocument.U_VIS_OP1_P2 = U_VIS_OP1_P2;
            vis_owor_env_c_TransferDocument.U_VIS_OP2_P2 = U_VIS_OP2_P2;
            vis_owor_env_c_TransferDocument.U_VIS_MAR1_P2 = U_VIS_MAR1_P2;
            vis_owor_env_c_TransferDocument.U_VIS_MAR2_P2 = U_VIS_MAR2_P2;
            vis_owor_env_c_TransferDocument.U_VIS_COD_REG_BAL_P2 = U_VIS_COD_REG_BAL_P2;
            vis_owor_env_c_TransferDocument.U_VIS_PRES_P2 = U_VIS_PRES_P2;
            vis_owor_env_c_TransferDocument.U_VIS_CANTIDAD_P2 = U_VIS_CANTIDAD_P2;

            vis_owor_env_c_TransferDocument.U_VIS_FECHA_P3 = U_VIS_FECHA_P3;
            vis_owor_env_c_TransferDocument.U_VIS_HORA_INI_P3 = U_VIS_HORA_INI_P3;
            vis_owor_env_c_TransferDocument.U_VIS_HORA_FIN_P3 = U_VIS_HORA_FIN_P3;
            vis_owor_env_c_TransferDocument.U_VIS_ENV_P3 = U_VIS_ENV_P3;
            vis_owor_env_c_TransferDocument.U_VIS_ETI_P3 = U_VIS_ETI_P3;
            vis_owor_env_c_TransferDocument.U_VIS_ENC1_P3 = U_VIS_ENC1_P3;
            vis_owor_env_c_TransferDocument.U_VIS_ENC2_P3 = U_VIS_ENC2_P3;
            vis_owor_env_c_TransferDocument.U_VIS_OP1_P3 = U_VIS_OP1_P3;
            vis_owor_env_c_TransferDocument.U_VIS_OP2_P3 = U_VIS_OP2_P3;
            vis_owor_env_c_TransferDocument.U_VIS_MAR1_P3 = U_VIS_MAR1_P3;
            vis_owor_env_c_TransferDocument.U_VIS_MAR2_P3 = U_VIS_MAR2_P3;
            vis_owor_env_c_TransferDocument.U_VIS_COD_REG_BAL_P3 = U_VIS_COD_REG_BAL_P3;
            vis_owor_env_c_TransferDocument.U_VIS_PRES_P3 = U_VIS_PRES_P3;
            vis_owor_env_c_TransferDocument.U_VIS_CANTIDAD_P3 = U_VIS_CANTIDAD_P3;

            vis_owor_env_c_TransferDocument.VIS_OWOR_ENV_DCollection = ObtenerDetalle(Grid1, DocNum.ToString());

            return vis_owor_env_c_TransferDocument;
        }

        public List<VIS_OWOR_ENV_DCollection> ObtenerDetalle(SAPbouiCOM.Grid dt, string DocEntry)
        {

            List<VIS_OWOR_ENV_DCollection> vis_owor_env_d_DocumentDetallsList = new List<VIS_OWOR_ENV_DCollection>();

            for (int oRows = 0; oRows < dt.Rows.Count; oRows++)
            {
                VIS_OWOR_ENV_DCollection vis_owor_env_d_DocumentDetalls = new VIS_OWOR_ENV_DCollection();

                vis_owor_env_d_DocumentDetalls.DocEntry = DocEntry;
                vis_owor_env_d_DocumentDetalls.U_VIS_COD_ENV = Convert.ToString(dt.DataTable.GetValue("Codigó", oRows));
                vis_owor_env_d_DocumentDetalls.U_VIS_DESC_ENV = Convert.ToString(dt.DataTable.GetValue("Descripción", oRows));
                vis_owor_env_d_DocumentDetalls.U_VIS_CANTIDAD = Convert.ToString(dt.DataTable.GetValue("Cantidad", oRows));
                vis_owor_env_d_DocumentDetalls.U_VIS_REQUERIDO_EV = Convert.ToString(dt.DataTable.GetValue("Requerimiento", oRows));
                vis_owor_env_d_DocumentDetalls.U_VIS_DEV_EV = Convert.ToString(dt.DataTable.GetValue("Devolución", oRows));
                vis_owor_env_d_DocumentDetalls.U_VIS_MERMA_EV = Convert.ToString(dt.DataTable.GetValue("Merma", oRows));

                vis_owor_env_d_DocumentDetallsList.Add(vis_owor_env_d_DocumentDetalls);

            }

            return vis_owor_env_d_DocumentDetallsList;

        }

        public void ObtenerMaterialesParaMateriales(SAPbouiCOM.DataTable oDatatable,
           SAPbouiCOM.Grid Grid1, SAPbouiCOM.Form oForm,
          string DocNum, string DT)
        {
            try
            {
                string strHANA = "";
                strHANA = string.Format(" CALL P_VIST_ADDON_CONTROL_ENVASADO('{0}')", DocNum);
                oDatatable = oForm.DataSources.DataTables.Item(DT);
                oDatatable.ExecuteQuery(strHANA);
                Grid1.AutoResizeColumns();
                Grid1.AssignLineNro();
            }
            catch (Exception EX)
            {
                Sb1Messages.ShowError(string.Format(EX.ToString()));
            }

        }
        public void ObtenerMaterialesParaMateriales_Linea(SAPbouiCOM.DataTable oDatatable,
        SAPbouiCOM.Grid Grid1, SAPbouiCOM.Form oForm,
        string DocNum, string DT)
        {
            try
            {
                string strHANA = "";
                strHANA = string.Format(" CALL P_VIST_ADDON_CONTROL_ENVASADO_LINEA('{0}')", DocNum);
                oDatatable = oForm.DataSources.DataTables.Item(DT);
                oDatatable.ExecuteQuery(strHANA);
                Grid1.AutoResizeColumns();
                Grid1.AssignLineNro();
            }
            catch (Exception EX)
            {
                Sb1Messages.ShowError(string.Format(EX.ToString()));
            }

        }

    }
}
