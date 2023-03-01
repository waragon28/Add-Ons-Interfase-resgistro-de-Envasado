using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistony.AddonName.BO;

namespace Vistony.AddonName.BLL
{
    public static class MENSAJE_BLL
    {
        public static void EnviarSMS(SAPbouiCOM.EditText RespuestMensaje)
        {
            DAL.SMS.EnviarSMS();
        }

        public static OWOR_UPDATE_STATUS OWOR_UPDATE_STATUS(int AbsoluteEntry, string U_VIS_Sample1, string U_VIS_Fecha_Entrega_M1,
            string U_VIS_Hora_Entrega_M1, string U_VIS_Fecha_Aproba_Lab, string U_VIS_Hora_Aproba_Lab, double U_VIS_Density, double Peso_Optimo, double Peso_Maximo)
        {
            
                return DAL.SMS.OWOR_UPDATE_STATUS(AbsoluteEntry, U_VIS_Sample1, U_VIS_Fecha_Entrega_M1,
                               U_VIS_Hora_Entrega_M1, U_VIS_Fecha_Aproba_Lab, U_VIS_Hora_Aproba_Lab, U_VIS_Density,Peso_Optimo,Peso_Maximo);
            


        }
    }
}
