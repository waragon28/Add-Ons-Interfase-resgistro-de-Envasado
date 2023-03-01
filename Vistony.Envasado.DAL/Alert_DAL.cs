using Forxap.Framework.Extensions;
using Forxap.Framework.UI;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistony.AddonName.BO;

namespace Vistony.AddonName.BLL
{
    public static class Alert_DAL
    {
        public static void AlertasADD(SAPbouiCOM.Form oForm,string DocNum,string ObjectTabla,
            string TitleMessage,string AreaAlert,string DT,string CampoQueryUserAlert,string ColumnName,
            string TituloNotification,string TextoNotificacion,string DocNumOF)
        {

            List<Alert.Messagedataline> ObjAlertaMessagedataline = new List<Alert.Messagedataline>();
            Alert.Messagedataline ListObjAlertaRecipientcollection = new Alert.Messagedataline();
            ListObjAlertaRecipientcollection.Object = ObjectTabla;
            ListObjAlertaRecipientcollection.ObjectKey = DocNum;
            ListObjAlertaRecipientcollection.Value = TitleMessage;
            ObjAlertaMessagedataline.Add(ListObjAlertaRecipientcollection);

            List<Alert.Recipientcollection> ObjRecipientcollection = new List<Alert.Recipientcollection>();

            string StrHANA = string.Format("CALL P_VIS_OBTENER_LIST_USU_ALERT('{0}')", AreaAlert);
            SAPbouiCOM.DataTable oDatatable;
            oDatatable = oForm.GetDataTable(DT);
            oDatatable.ExecuteQuery(StrHANA);
            for (int i = 0; i < oDatatable.Rows.Count; i++)
            {

                Alert.Recipientcollection ListObjRecipientcollection = new Alert.Recipientcollection();
                ListObjRecipientcollection.SendInternal = "tYES";
                ListObjRecipientcollection.UserCode = oDatatable.GetString(CampoQueryUserAlert, i);

                ObjRecipientcollection.Add(ListObjRecipientcollection);
            }

            List<Alert.Messagedatacolumn> ObjMessageDataColumns = new List<Alert.Messagedatacolumn>();
            Alert.Messagedatacolumn ListObjMessageDataColumns = new Alert.Messagedatacolumn();
            ListObjMessageDataColumns.ColumnName = ColumnName;
            ListObjMessageDataColumns.Link = "tYES";
            ListObjMessageDataColumns.ColumnName = ColumnName;
            ListObjMessageDataColumns.MessageDataLines = ObjAlertaMessagedataline;
            ObjMessageDataColumns.Add(ListObjMessageDataColumns);

            Alert.Rootobject alert = new Alert.Rootobject
            {
                MessageDataColumns = ObjMessageDataColumns,
                RecipientCollection = ObjRecipientcollection,
                Subject = TituloNotification, /*Titulo de la Notificacion*/
                Text = TextoNotificacion /*Comentario*/
            };

            string JsonAlert = JsonConvert.SerializeObject(alert);

            IRestResponse responsde;
            Forxap.Framework.ServiceLayer.Methods Methods = new Forxap.Framework.ServiceLayer.Methods();
            responsde = Methods.POST("Messages", JsonAlert.ToString());

            string Respuesta = responsde.StatusDescription;

            if (responsde.StatusDescription == "Created")
            {
                Sb1Messages.ShowSuccess("Se envio la Alerta ");
            }
            else
            {
                Sb1Messages.ShowError(responsde.Content);
            }
        }


    }
}
