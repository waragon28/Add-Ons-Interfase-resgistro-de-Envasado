using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAPbouiCOM;
using Vistony.AddonName.BLL;

namespace Vistony.AddonName.BLL
{
   public static class Alert_BLL
    {
        public static void AlertasADD(SAPbouiCOM.Form oForm, string DocNum, string ObjectTabla,
           string TitleMessage, string AreaAlert, string DT, string CampoQueryUserAlert, string ColumnName,
           string TituloNotification, string TextoNotificacion,string DocNumOF)
        {
            Alert_DAL.AlertasADD(oForm, DocNum, ObjectTabla, TitleMessage, AreaAlert, DT, CampoQueryUserAlert,
                 ColumnName, TituloNotification, TextoNotificacion, DocNumOF);
        }

    }
}
