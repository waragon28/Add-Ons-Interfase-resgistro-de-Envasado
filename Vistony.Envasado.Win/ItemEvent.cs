using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistony.AddonName.Win.Asistentes;

namespace Vistony.AddonName.Win
{
    class ItemEvent
    {
        public void SB1_Application_ItemEvent(String formUID, ref SAPbouiCOM.ItemEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;

            switch (pVal.FormTypeEx)
            {

                case "65211":
                   //Orden_Fabricacion.itemEvent(ref pVal, out BubbleEvent);
                    break;
                
            }

        }

    }
}
