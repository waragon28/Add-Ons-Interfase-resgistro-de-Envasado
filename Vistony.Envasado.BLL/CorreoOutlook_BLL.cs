using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistony.AddonName.DAL;

namespace Vistony.AddonName.BLL.Configuracion
{
    public static class CorreoOutlook_BLL
    {
        public static void EnviarCorreoOffice365(SAPbouiCOM.Form oForm, Recordset recordset, string DocNum,
                                string departamento, string DT1, string DT2, string DT3, string JefeArea,
                                string Asunto_Correo, string Cuerpo_Correo,string UsuarioSolicitante, string TextoDetalle,string DocNumOF)
        {

            CorreoOutlook.EnviarCorreoOffice365(oForm, recordset, DocNum,departamento, DT1, DT2, DT3, JefeArea,
                                Asunto_Correo, Cuerpo_Correo,UsuarioSolicitante,TextoDetalle, DocNumOF);
        }

        public static void EnviarCorreoOffice365_ENV(SAPbouiCOM.Form oForm, Recordset recordset, string DocNum,
                       string departamento, string DT1, string DT2, string DT3, string JefeArea,
                       string Asunto_Correo, string Cuerpo_Correo, string UsuarioSolicitante, string TextoDetalle, string DocNumOF)
        {
             CorreoOutlook.EnviarCorreoOffice365_ENV(oForm, recordset, DocNum, departamento, DT1, DT2, DT3, JefeArea,
                                Asunto_Correo, Cuerpo_Correo, UsuarioSolicitante, TextoDetalle, DocNumOF);
        }
      
    }
}
