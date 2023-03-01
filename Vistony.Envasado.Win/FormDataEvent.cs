using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistony.AddonName.Win.Asistentes;

namespace Vistony.AddonName.Win
{
    class FormDataEvent
    {
        public void SB1_Application_FormDataEvent(ref SAPbouiCOM.BusinessObjectInfo BusinessObjectInfo, out bool BubbleEvent)
        {
            BubbleEvent = true;

            switch (BusinessObjectInfo.FormTypeEx)
            {
                case "65211":
                    Orden_Fabricacion.formEvent(ref BusinessObjectInfo, out BubbleEvent);
                    break;
            }
        }
    }
}
