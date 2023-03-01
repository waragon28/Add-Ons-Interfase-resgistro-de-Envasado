using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forxap.AddonName.UI.Constans
{
    public class AddonMessageInfo
    {

        public const string AddonName = "Interfaz Registro de Control de Envasado ";

        public const string SAPNotRunning = AddonName + "SAP Business One, no se encuentra corriendo ";
        
        public const string StartLoading = AddonName + "Iniciando Carga ..." ;
        public const string FinishLoading = AddonName + "Carga Finalizada ...";
        public const string Message100 = AddonName + "No se obtuvo la OT DE MEZCLA";
        public const string Message001 = "Agregando registro de control de envasado";
        public const string Message002 = "Se genero Correctamente el registro de control de envazado : ";
        public const string Message003 = "Datos insuficientes";
        public const string Message004 = "Se generara el registro de control de envasado \n ¿ Desea continuar ?";
        public const string Message005 = "Ya se genero su registo de envase \n ¿ Desea Visualizarlo ?";
        public const string QueryGetOF = "CALL P_VIS_ADD_ENV_GET_OF('{0}','{1}')";

    }// fin de la clase


}// fin del namespace
