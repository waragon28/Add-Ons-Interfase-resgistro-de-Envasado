using SAPbobsCOM;
using SAPbouiCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistony.AddonName.BO;
using Vistony.AddonName.BLL;

namespace Vistony.AddonName.BLL
{
    public class Control_EnvasadoBLL
    {

        Control_EnvasadoDAL control_envasadoDAL = new Control_EnvasadoDAL();

        public void ObtenerOT_Trasvase(string DocNum, Recordset recordset, string EditText1)
        {
            control_envasadoDAL.ObtenerOT_Trasvase(DocNum, recordset, EditText1);
        }

        public VIS_OWOR_ENV_C ObtenerCabecera(string DocEntry,string DocNum, string U_VIS_APRO_DOC, string U_VIS_FEC_APRO,
            string U_VIS_HOR_APRO, string U_VIS_NOM_REP, double U_VIS_PESO_OPTIM, double U_VIS_PESO_MAX,
            string U_VIS_UND_MED, string U_VIS_OT_MEZCLA,
            string U_VIS_LOTE_PT, string U_VIS_FIR_LAB_AP, string U_VIS_PRE_LIMP1,
            string U_VIS_PRE_LIMP2, string U_VIS_PRE_LIMP3, string U_VIS_HOR_ENTR_MU_INI, string U_VIS_HOR_APRO_MU_INI,
            string U_VIS_FIR_LAP_MU_INI, string U_VIS_HOR_ENTR_MU_FIN, string U_VIS_HOR_APRO_MU_FIN, string U_VIS_FIR_LAP_MU_FIN,
            string U_VIS_NUM_TANQUE, string U_VIS_OT_ENVASADO, 
            string U_VIS_FECHA_P1,
            string U_VIS_HORA_INI_P1, string U_VIS_HORA_FIN_P1, string U_VIS_ENV_P1,
            string U_VIS_ETI_P1, string U_VIS_ENC1_P1, string U_VIS_ENC2_P1,
            string U_VIS_OP1_P1, string U_VIS_OP2_P1, string U_VIS_MAR1_P1,
            string U_VIS_MAR2_P1, string U_VIS_COD_REG_BAL_P1,string U_VIS_PRES_P1,
            string U_VIS_CANTIDAD_P1, Grid Grid1, 
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
            return control_envasadoDAL.ObtenerCabecera(DocEntry, DocNum, U_VIS_APRO_DOC, U_VIS_FEC_APRO,
                  U_VIS_HOR_APRO, U_VIS_NOM_REP, U_VIS_PESO_OPTIM, U_VIS_PESO_MAX,
                  U_VIS_UND_MED, U_VIS_OT_MEZCLA,
                  U_VIS_LOTE_PT, U_VIS_FIR_LAB_AP, U_VIS_PRE_LIMP1,
                  U_VIS_PRE_LIMP2, U_VIS_PRE_LIMP3, U_VIS_HOR_ENTR_MU_INI, U_VIS_HOR_APRO_MU_INI,
                  U_VIS_FIR_LAP_MU_INI, U_VIS_HOR_ENTR_MU_FIN, U_VIS_HOR_APRO_MU_FIN, U_VIS_FIR_LAP_MU_FIN,
                 U_VIS_NUM_TANQUE, U_VIS_OT_ENVASADO, 
                 
                 U_VIS_FECHA_P1,
                 U_VIS_HORA_INI_P1, U_VIS_HORA_FIN_P1, U_VIS_ENV_P1,
                 U_VIS_ETI_P1, U_VIS_ENC1_P1, U_VIS_ENC2_P1,
                 U_VIS_OP1_P1, U_VIS_OP2_P1, U_VIS_MAR1_P1,
                 U_VIS_MAR2_P1, U_VIS_COD_REG_BAL_P1, U_VIS_PRES_P1, U_VIS_CANTIDAD_P1, Grid1,
                 
                 U_VIS_FECHA_P2,
                 U_VIS_HORA_INI_P2, U_VIS_HORA_FIN_P2, U_VIS_ENV_P2,
                 U_VIS_ETI_P2, U_VIS_ENC1_P2, U_VIS_ENC2_P2,
                 U_VIS_OP1_P2, U_VIS_OP2_P2, U_VIS_MAR1_P2,
                 U_VIS_MAR2_P2, U_VIS_COD_REG_BAL_P2, U_VIS_PRES_P2, U_VIS_CANTIDAD_P2,
                  
                 U_VIS_FECHA_P3,
                 U_VIS_HORA_INI_P3,  U_VIS_HORA_FIN_P3,  U_VIS_ENV_P3,
                 U_VIS_ETI_P3,  U_VIS_ENC1_P3,  U_VIS_ENC2_P3,
                 U_VIS_OP1_P3,  U_VIS_OP2_P3,  U_VIS_MAR1_P3,
                 U_VIS_MAR2_P3,  U_VIS_COD_REG_BAL_P3,  U_VIS_PRES_P3,
                 U_VIS_CANTIDAD_P3
        );
        }

        public void ObtenerMaterialesParaMateriales(SAPbouiCOM.DataTable oDatatable,
           SAPbouiCOM.Grid Grid1, SAPbouiCOM.Form oForm,
          string DocNum, string DT)
        {
            control_envasadoDAL.ObtenerMaterialesParaMateriales(oDatatable, Grid1, oForm, DocNum, DT);
        }

        public void ObtenerMaterialesParaMateriales_Linea(SAPbouiCOM.DataTable oDatatable,
        SAPbouiCOM.Grid Grid1, SAPbouiCOM.Form oForm,
        string DocNum, string DT)
        {
            control_envasadoDAL.ObtenerMaterialesParaMateriales_Linea(oDatatable, Grid1, oForm, DocNum, DT);
        }



    }
}
