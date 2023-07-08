using Forxap.Framework.Extensions;
using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Vistony.AddonName.BO;

namespace Vistony.AddonName.DAL
{
    public static class CorreoOutlook
    {

        public static List<Data> ListtransferDocumentabecera_Mensaje = new List<Data>();
        public static Cabecera_Mensaje ObtenerCabecera()
        {
            List<Cabecera_Mensaje> ListtransferDocument = new List<Cabecera_Mensaje>();
            Cabecera_Mensaje transferDocument = new Cabecera_Mensaje();

            transferDocument.Data = ListtransferDocumentabecera_Mensaje;
            return transferDocument;
        }

        public static void EnviarCorreoOffice365(SAPbouiCOM.Form oForm, Recordset recordset, string DocNum,
                                string departamento, string DT1, string DT2, string DT3, string JefeArea,
                                string Asunto_Correo, string Cuerpo_Correo, string UsuarioSolicitante,string TextoDetalle,string DocNumOF)
        {
            /*TEXTO*/
            string TextoAprobador = System.IO.File.ReadAllText(@"Files\Texto_Correo.txt");


            //Conexión a a la Plataforma de Microsofot Office 365 para enviar correo.
            var smtp = new System.Net.Mail.SmtpClient("smtp.office365.com");
            var mail = new System.Net.Mail.MailMessage();
            string userFrom = "admin@vistony.com"; //Mi cuenta de Office 365.
            // IMPORTANTE : Este Usuario mail.From, debe coincidir con el de NetworkCredential(), sino se genera error.
            mail.From = new System.Net.Mail.MailAddress(userFrom);

            /*Recorrido de Jefe Area*/
            string JefeAreaDistribucion = string.Format("CALL P_VIS_OBTENERJEFE_AREA('{0}')", departamento);
            recordset.DoQuery(JefeAreaDistribucion);
            string CambiarJefeArea = TextoAprobador;
            string CambiarUsuarioSol = CambiarJefeArea.Replace("@UsuarioLab", UsuarioSolicitante);
            
            string CambiarDetalle = CambiarUsuarioSol.Replace("@Detalle", TextoDetalle.Replace("..", "\n"));
            string CambioNumeroDoc = CambiarDetalle.Replace("@NumDocumento", DocNumOF);
            //Correos Destino a los que les enviaré mail.

            /*Recorrido de correo*/
            string StrHANA = string.Format("CALL P_VIS_OBTENERCORREO_NOTIFI('{0}')", departamento);
            SAPbouiCOM.DataTable oDatatable;
            oDatatable = oForm.GetDataTable(DT1);
            oDatatable.ExecuteQuery(StrHANA);

            /*Recorrido de Telefonos*/
            string StrHANATelefono = string.Format("CALL P_VIS_OBTENER_TELEFONO_OHEM_PRODUCCION()");
            SAPbouiCOM.DataTable oDatatableTelefono;
            oDatatableTelefono = oForm.GetDataTable(DT3);
            oDatatableTelefono.ExecuteQuery(StrHANATelefono);

            for (int rowTelef = 0; rowTelef < oDatatableTelefono.Rows.Count; rowTelef++)
            {
                Data transferDocumentDetalls2 = new Data();
                transferDocumentDetalls2.NumeroTelf = "51" + Convert.ToString(oDatatableTelefono.GetString("Telefono", rowTelef));
                transferDocumentDetalls2.Mensaje = CambioNumeroDoc;
                ListtransferDocumentabecera_Mensaje.Add(transferDocumentDetalls2);
            }

             mail.To.Add("administracion.produccion@nogasa.com.pe");
           // mail.To.Add("william.aragon@nogasa.com.pe");
            mail.CC.Add("control.calidad@nogasa.com.pe");
            mail.Subject = Asunto_Correo;//Asunto del Correo
            mail.Body = CambioNumeroDoc;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;

            //Credenciales que se utilizan, cuando se autentica al correo de Office 365.
            smtp.Credentials = new System.Net.NetworkCredential(userFrom, ConfigurationManager.AppSettings.Get("PassWordAdminOutlook"));
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            smtp.Send(mail);

        }

        public static void EnviarCorreoOffice365_ENV(SAPbouiCOM.Form oForm, Recordset recordset, string DocNum,
                               string departamento, string DT1, string DT2, string DT3, string JefeArea,
                               string Asunto_Correo, string Cuerpo_Correo, string UsuarioSolicitante, string TextoDetalle, string DocNumOF)
        {

            try
            {
                /*TEXTO*/
                string TextoAprobador = System.IO.File.ReadAllText(@"Files\Texto_Correo.txt");


                //Conexión a a la Plataforma de Microsofot Office 365 para enviar correo.
                var smtp = new System.Net.Mail.SmtpClient("smtp.office365.com");
                var mail = new System.Net.Mail.MailMessage();
                string userFrom = "notificaciones@nogasa.com.pe"; //Mi cuenta de Office 365.
                // IMPORTANTE : Este Usuario mail.From, debe coincidir con el de NetworkCredential(), sino se genera error.
                mail.From = new System.Net.Mail.MailAddress(userFrom);

                /*Recorrido de Jefe Area*/
                // string JefeAreaDistribucion = string.Format("CALL P_VIS_OBTENERJEFE_AREA('{0}')", departamento);
                // recordset.DoQuery(JefeAreaDistribucion);
                string CambiarJefeArea = TextoAprobador;
                string CambiarUsuarioSol = CambiarJefeArea.Replace("@UsuarioLab", UsuarioSolicitante);

                string CambiarDetalle = CambiarUsuarioSol.Replace("@Detalle", TextoDetalle.Replace("..", "\n"));
                string CambioNumeroDoc = CambiarDetalle.Replace("@NumDocumento", DocNumOF);
                //Correos Destino a los que les enviaré mail.

                /*Recorrido de correo*/
                string StrHANA = string.Format("CALL P_VIS_OBTENERCORREO_NOTIFI('{0}')", departamento);
                SAPbouiCOM.DataTable oDatatable;
                oDatatable = oForm.GetDataTable(DT1);
                oDatatable.ExecuteQuery(StrHANA);

                /*Recorrido de Telefonos*/
                string StrHANATelefono = string.Format("CALL P_VIS_OBTENER_TELEFONO_OHEM_PRODUCCION()");
                SAPbouiCOM.DataTable oDatatableTelefono;
                oDatatableTelefono = oForm.GetDataTable(DT3);
                oDatatableTelefono.ExecuteQuery(StrHANATelefono);

                for (int rowTelef = 0; rowTelef < oDatatableTelefono.Rows.Count; rowTelef++)
                {
                    Data transferDocumentDetalls2 = new Data();
                    transferDocumentDetalls2.NumeroTelf = "51" + Convert.ToString(oDatatableTelefono.GetString("Telefono", rowTelef));
                    transferDocumentDetalls2.Mensaje = CambioNumeroDoc;
                    ListtransferDocumentabecera_Mensaje.Add(transferDocumentDetalls2);
                }

                mail.To.Add("administracion.produccion@nogasa.com.pe");
                 // mail.To.Add("william.aragon@nogasa.com.pe");
                mail.CC.Add("control.calidad@nogasa.com.pe");
                mail.Subject = Asunto_Correo;//Asunto del Correo
                mail.Body = CambioNumeroDoc;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;

                //Credenciales que se utilizan, cuando se autentica al correo de Office 365.
                smtp.Credentials = new System.Net.NetworkCredential(userFrom, ConfigurationManager.AppSettings.Get("PassWordAdminOutlook"));
                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                smtp.Send(mail);
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
