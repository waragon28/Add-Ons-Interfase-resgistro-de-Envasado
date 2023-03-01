using Forxap.Framework.UI;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistony.AddonName.BO;

namespace Vistony.AddonName.DAL
{
    public static class SMS
    {

        public static void EnviarSMS()
        {

            try
            {
                Cabecera_Mensaje ObtenerCabecera2 = new Cabecera_Mensaje();

                ObtenerCabecera2 = CorreoOutlook.ObtenerCabecera();

                RestClient client = new RestClient("http://192.168.254.20:88/vs1.0/sms");
                RestRequest request = new RestRequest(Method.POST);
                string JsonObtenerCabezera = JsonConvert.SerializeObject(ObtenerCabecera2);
                string dataReq = JsonObtenerCabezera;
                IRestResponse result = client.Execute(request.AddJsonBody(dataReq));

                if (result.StatusDescription == "OK")
                {
                    Sb1Messages.ShowSuccess("Se envio el mensaje de texto con exito...");
                }
                else
                {
                    Sb1Messages.ShowError(result.Content);
                }
            }
            catch (Exception)
            {

                //Sb1Messages.ShowError(e.ToString());
            }
        }

        public static OWOR_UPDATE_STATUS OWOR_UPDATE_STATUS(int AbsoluteEntry, string U_VIS_Sample1, string U_VIS_Fecha_Entrega_M1,
            string U_VIS_Hora_Entrega_M1, string U_VIS_Fecha_Aproba_Lab, string U_VIS_Hora_Aproba_Lab, double U_VIS_Density, double Peso_Optimo, double Peso_Maximo)
        {
            OWOR_UPDATE_STATUS updateOWOR = new OWOR_UPDATE_STATUS();
            updateOWOR.AbsoluteEntry = AbsoluteEntry;
            updateOWOR.U_VIS_Sample1 = U_VIS_Sample1;
            updateOWOR.U_VIS_Fecha_Entrega_M1 = U_VIS_Fecha_Entrega_M1;
            updateOWOR.U_VIS_Hora_Entrega_M1 = U_VIS_Hora_Entrega_M1;
            updateOWOR.U_VIS_Fecha_Aproba_Lab = U_VIS_Fecha_Aproba_Lab;
            updateOWOR.U_VIS_Hora_Aproba_Lab = U_VIS_Hora_Aproba_Lab;
            updateOWOR.U_VIS_Density = U_VIS_Density;
            updateOWOR.U_VIS_PesoOptimo_Lab = Peso_Optimo;
            updateOWOR.U_VIS_PesoMaximo_Lab= Peso_Maximo;
            return updateOWOR;
        }
    }
}
