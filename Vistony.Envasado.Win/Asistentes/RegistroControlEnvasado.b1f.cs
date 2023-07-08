using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;
using Forxap.AddonName.UI.Win;
using Forxap.Framework.Extensions;
using System.Threading;
using Forxap.Framework.UI;
using Vistony.AddonName.BO;
using Vistony.AddonName.BLL;
using Newtonsoft.Json;
using RestSharp;
using Forxap.AddonName.UI.Constans;
using SAPbouiCOM;

namespace Vistony.AddonName.Win.Asistentes
{
    [FormAttribute("Vistony.AddonName.Win.Asistentes.RegistroControlEnvasado", "Asistentes/RegistroControlEnvasado.b1f")]
    class RegistroControlEnvasado : UserFormBase
    {
        public RegistroControlEnvasado()
        {
        }
        public string usuario = Sb1Globals.UserName;
        public SAPbouiCOM.DataTable oDataTable;

        public string DocNum { get; set; }
        public double PesoOptimo { get; set; }
        public string HoraAprobadaMuestraFinal { get; set; }
        public string HoraEntrMuestraFinal { get; set; }
        public double MaximoOptimo { get; set; }
        public string Correlativo { get; set; }
        public string TanqueOT { get; set; }
        public string HoraOP { get; set; }
        public string NumOT_Envasado { get; set; }
        public string DocEntryOP { get; set; }
        public string FechaCreacionOP { get; set; }
        public string AprobCalidadOP { get; set; }
        public string Muestra1OP { get; set; }
        public string DocEntryOT { get; set; }
        public SAPbouiCOM.Matrix oMatrix;
        private SAPbouiCOM.Grid Grid1;
        public SAPbouiCOM.Form oForm;
        Control_EnvasadoBLL control_envasadoBLL = new Control_EnvasadoBLL();

        public int PaneLevel = 0;
        public int PaneMax = 3;

        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.OptionBtn OptionBtn0;
        private SAPbouiCOM.OptionBtn OptionBtn1;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.OptionBtn OptionBtn2;
        private SAPbouiCOM.OptionBtn OptionBtn3;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.StaticText StaticText6;
        private SAPbouiCOM.StaticText StaticText7;
        private SAPbouiCOM.StaticText StaticText8;
        private SAPbouiCOM.EditText EditText3;
        private SAPbouiCOM.StaticText StaticText9;
        private SAPbouiCOM.StaticText StaticText10;
        private SAPbouiCOM.StaticText StaticText11;
        private SAPbouiCOM.EditText EditText4;
        private SAPbouiCOM.EditText EditText5;
        private SAPbouiCOM.StaticText StaticText12;
        private SAPbouiCOM.OptionBtn OptionBtn8;
        private SAPbouiCOM.OptionBtn OptionBtn9;
        private SAPbouiCOM.StaticText StaticText13;
        private SAPbouiCOM.StaticText StaticText14;
        private SAPbouiCOM.StaticText StaticText15;
        private SAPbouiCOM.StaticText StaticText16;
        private SAPbouiCOM.StaticText StaticText17;
        private SAPbouiCOM.EditText EditText6;
        private SAPbouiCOM.EditText EditText7;
        private SAPbouiCOM.OptionBtn OptionBtn10;
        private SAPbouiCOM.OptionBtn OptionBtn11;
        private SAPbouiCOM.StaticText StaticText18;
        private SAPbouiCOM.StaticText StaticText19;
        private SAPbouiCOM.StaticText StaticText20;
        private SAPbouiCOM.StaticText StaticText21;
        private SAPbouiCOM.EditText EditText8;
        private SAPbouiCOM.EditText EditText9;
        private SAPbouiCOM.EditText EditText10;
        private SAPbouiCOM.EditText EditText11;
        private SAPbouiCOM.StaticText StaticText23;
        private SAPbouiCOM.StaticText StaticText24;
        private SAPbouiCOM.Button Button1;
        private SAPbouiCOM.StaticText StaticText27;
        private SAPbouiCOM.EditText EditText13;
        private SAPbouiCOM.StaticText StaticText28;
        private SAPbouiCOM.EditText EditText14;
        private SAPbouiCOM.Grid Grid2;
        private SAPbouiCOM.Folder Folder0;
        private SAPbouiCOM.Folder Folder1;
        private SAPbouiCOM.Folder Folder2;

        private SAPbouiCOM.StaticText StaticText29;
        private SAPbouiCOM.EditText EditText15;
        private SAPbouiCOM.StaticText StaticText30;
        private SAPbouiCOM.StaticText StaticText31;
        private SAPbouiCOM.StaticText StaticText32;
        private SAPbouiCOM.EditText EditText16;
        private SAPbouiCOM.EditText EditText17;
        private SAPbouiCOM.StaticText StaticText33;
        private SAPbouiCOM.StaticText StaticText34;
        private SAPbouiCOM.EditText EditText18;
        private SAPbouiCOM.EditText EditText19;
        private SAPbouiCOM.StaticText StaticText35;
        private SAPbouiCOM.StaticText StaticText36;
        private SAPbouiCOM.EditText EditText20;
        private SAPbouiCOM.EditText EditText21;
        private SAPbouiCOM.StaticText StaticText37;
        private SAPbouiCOM.StaticText StaticText38;
        private SAPbouiCOM.StaticText StaticText39;
        private SAPbouiCOM.StaticText StaticText40;
        private SAPbouiCOM.EditText EditText22;
        private SAPbouiCOM.EditText EditText23;
        private SAPbouiCOM.EditText EditText24;
        private SAPbouiCOM.EditText EditText25;
        private SAPbouiCOM.EditText EditText26;
        private SAPbouiCOM.EditText EditText27;
        private SAPbouiCOM.StaticText StaticText41;
        private SAPbouiCOM.StaticText StaticText42;
        private SAPbouiCOM.Button Button3;
        private SAPbouiCOM.EditText EditText28;
        private SAPbouiCOM.StaticText StaticText43;
        private SAPbouiCOM.StaticText StaticText44;
        private SAPbouiCOM.StaticText StaticText45;
        private SAPbouiCOM.EditText EditText29;
        private SAPbouiCOM.StaticText StaticText46;
        private SAPbouiCOM.StaticText StaticText47;
        private SAPbouiCOM.StaticText StaticText48;
        private SAPbouiCOM.EditText EditText30;
        private SAPbouiCOM.EditText EditText31;
        private SAPbouiCOM.StaticText StaticText49;
        private SAPbouiCOM.StaticText StaticText50;
        private SAPbouiCOM.EditText EditText32;
        private SAPbouiCOM.EditText EditText33;
        private SAPbouiCOM.StaticText StaticText51;
        private SAPbouiCOM.StaticText StaticText52;
        private SAPbouiCOM.EditText EditText34;
        private SAPbouiCOM.EditText EditText35;
        private SAPbouiCOM.StaticText StaticText53;
        private SAPbouiCOM.StaticText StaticText54;
        private SAPbouiCOM.StaticText StaticText55;
        private SAPbouiCOM.StaticText StaticText56;
        private SAPbouiCOM.EditText EditText36;
        private SAPbouiCOM.EditText EditText37;
        private SAPbouiCOM.EditText EditText38;
        private SAPbouiCOM.EditText EditText39;
        private SAPbouiCOM.EditText EditText40;
        private SAPbouiCOM.EditText EditText41;
        private SAPbouiCOM.StaticText StaticText57;
        private SAPbouiCOM.StaticText StaticText58;
        private SAPbouiCOM.Button Button4;
        private SAPbouiCOM.EditText EditText42;
        private SAPbouiCOM.StaticText StaticText59;
        private SAPbouiCOM.StaticText StaticText60;
        private SAPbouiCOM.StaticText StaticText61;
        private SAPbouiCOM.EditText EditText43;
        private SAPbouiCOM.StaticText StaticText62;
        private SAPbouiCOM.StaticText StaticText63;
        private SAPbouiCOM.StaticText StaticText64;
        private SAPbouiCOM.EditText EditText44;
        private SAPbouiCOM.EditText EditText45;
        private SAPbouiCOM.StaticText StaticText65;
        private SAPbouiCOM.StaticText StaticText66;
        private SAPbouiCOM.EditText EditText46;
        private SAPbouiCOM.EditText EditText47;
        private SAPbouiCOM.StaticText StaticText67;
        private SAPbouiCOM.StaticText StaticText68;
        private SAPbouiCOM.EditText EditText48;
        private SAPbouiCOM.EditText EditText49;
        private SAPbouiCOM.StaticText StaticText69;
        private SAPbouiCOM.StaticText StaticText70;
        private SAPbouiCOM.StaticText StaticText71;
        private SAPbouiCOM.StaticText StaticText72;
        private SAPbouiCOM.EditText EditText50;
        private SAPbouiCOM.EditText EditText51;
        private SAPbouiCOM.EditText EditText52;
        private SAPbouiCOM.EditText EditText53;
        private SAPbouiCOM.EditText EditText54;
        private SAPbouiCOM.EditText EditText55;
        private SAPbouiCOM.StaticText StaticText73;
        private SAPbouiCOM.StaticText StaticText74;
        private SAPbouiCOM.Button Button5;
        private SAPbouiCOM.EditText EditText56;
        private SAPbouiCOM.StaticText StaticText75;
        private SAPbouiCOM.StaticText StaticText76;

        public RegistroControlEnvasado(string docnum, string numOT_Envasado, string DocEntryOP, string FechaCreacionOP,
            string AprobCalidadOP, string Muestra1OP, string HoraOPt, string DocEntryOT, string TanqueOT, int Correlativo, double PesoOptimo, double PesoMaximo,
            string HoraAprobadaMuestraFinal, string HoraEntrMuestraFinal, string Hora_Entrega_Linea, string Hora_Aprobada_Linea)
        {

            DocNum = docnum;
            NumOT_Envasado = numOT_Envasado;
            EditText11.Value = numOT_Envasado;
            EditText14.Value = docnum;
            EditText59.Value = docnum;
            EditText60.Value = numOT_Envasado;

            EditText8.Value = Convert.ToString(PesoOptimo);
            EditText9.Value = Convert.ToString(PesoMaximo);
            
            EditText13.Value = TanqueOT;
            EditText57.Value = Convert.ToString(Correlativo);

            EditText61.Value = DocEntryOT;
            EditText62.Value = DocEntryOP;
            

            EditText57.Value = "2";//Convert.ToString(Correlativo);
            

            if (FechaCreacionOP != "30/12/1899 00:00:00")
            {
                EditText0.Value = Convert.ToDateTime(FechaCreacionOP).ToString("yyyyMMdd");
            }

            try
            {
                EditText1.Value = HoraOPt;

                EditText6.Value = HoraAprobadaMuestraFinal;//.Substring(0, 2) + ":" + HoraAprobadaMuestraFinal.Substring(2, 2);

                EditText7.Value = HoraEntrMuestraFinal;//.Substring(0, 2) + ":" + HoraEntrMuestraFinal?.Substring(2, 2);

                EditText4.Value = Hora_Entrega_Linea;//.Substring(0, 2) + ":" + Hora_Entrega_Linea?.Substring(2, 2);


                EditText5.Value = Hora_Aprobada_Linea;//.Substring(0, 2) + ":" + Hora_Aprobada_Linea?.Substring(2, 2);

            }
            catch (Exception)
            {

               // throw;
            }

           

            EditText10.Value = "KG";


            if (EditText7.Value != "")
            {
                OptionBtn10.Selected = true;
            }
            else
            {
                OptionBtn11.Selected = true;
            }

            if (EditText5.Value != "")
            {
                OptionBtn8.Selected = true;
            }
            else
            {
                OptionBtn9.Selected = true;
            }


            if (AprobCalidadOP == "S")
            {
                OptionBtn0.Selected = true;
                OptionBtn2.Selected = true;
            }
            else
            {
                OptionBtn1.Selected = true;
                OptionBtn3.Selected = true;
            }

            OptionBtn0.Item.Enabled = false;
            OptionBtn1.Item.Enabled = false;
            OptionBtn2.Item.Enabled = false;
            OptionBtn3.Item.Enabled = false;
            OptionBtn10.Item.Enabled = false;
            OptionBtn11.Item.Enabled = false;

            string strHANA = "";
            SAPbouiCOM.DataTable udt;

            strHANA = string.Format("CALL P_VIST_ADDON_CONTROL_ENVASADO('{0}')", DocNum);
            udt = oForm.DataSources.DataTables.Item("DT_2");

            udt.ExecuteQuery(strHANA);
            //udt = oForm.GetDataTable("DT_2");
            oMatrix = oForm.GetMatrix("Item_191");

            SAPbouiCOM.Columns oColumns;
            oColumns = oMatrix.Columns;
            var colItems = udt.Columns;
            SAPbouiCOM.Column oColumn;

            oColumns = oMatrix.Columns;

            if (udt.Columns.Count == 0)
            {
                colItems.Add("Código", BoFieldsType.ft_Rate);
                colItems.Add("Descripción", BoFieldsType.ft_Rate);
                colItems.Add("Cantidad", BoFieldsType.ft_Rate);
                colItems.Add("Requerimiento", BoFieldsType.ft_Rate);
                colItems.Add("Devolución", BoFieldsType.ft_Rate);
                colItems.Add("Merma", BoFieldsType.ft_Rate);
                oMatrix.AddRow(1, -1);
            }

            oMatrix.Columns.Item("Col_0").DataBind.SetBound(true, "@VIS_OWOR_ENV_D", "U_VIS_COD_ENV");
            oMatrix.Columns.Item("Col_1").DataBind.SetBound(true, "@VIS_OWOR_ENV_D", "U_VIS_DESC_ENV");
            oMatrix.Columns.Item("Col_2").DataBind.SetBound(true, "@VIS_OWOR_ENV_D", "U_VIS_CANTIDAD");
            oMatrix.Columns.Item("Col_3").DataBind.SetBound(true, "@VIS_OWOR_ENV_D", "U_VIS_REQUERIDO_EV");
            oMatrix.Columns.Item("Col_4").DataBind.SetBound(true, "@VIS_OWOR_ENV_D", "U_VIS_DEV_EV");
            oMatrix.Columns.Item("Col_5").DataBind.SetBound(true, "@VIS_OWOR_ENV_D", "U_VIS_MERMA_EV");

            //oMatrix.FlushToDataSource();
            //source.Clear();
            //source.InsertRecord(source.Size);
            //source.Offset = source.Size - 1;


           // oForm.SetEditText("Item_9",udt.GetString("Código", 0),true);

            for (int oRows = 0; oRows < udt.Rows.Count; oRows++)
            {
                SAPbouiCOM.DBDataSource oDatasource = oForm.GetDBDataSource("@VIS_OWOR_ENV_D");
                int rowCount = 0;

                rowCount = oDatasource.Offset;

                rowCount = rowCount + 1;

                oDatasource.InsertRecord(oDatasource.Size);
                oDatasource.Offset = oDatasource.Size - 1;
                oMatrix.AddRow(1, rowCount);

                oDatasource.SetValue("U_VIS_COD_ENV", oRows, udt.GetString("Código", oRows));
                oDatasource.SetValue("U_VIS_DESC_ENV", oRows, udt.GetString("Descripción", oRows));
                oDatasource.SetValue("U_VIS_CANTIDAD", oRows, udt.GetString("Cantidad", oRows));
                oDatasource.SetValue("U_VIS_REQUERIDO_EV", oRows, udt.GetString("Requerimiento", oRows));
                oDatasource.SetValue("U_VIS_DEV_EV", oRows, udt.GetString("Devolución", oRows));
                oDatasource.SetValue("U_VIS_MERMA_EV", oRows, udt.GetString("Merma", oRows));
            }


            oMatrix.Columns.Item("Col_0").Editable = false;
            oMatrix.Columns.Item("Col_1").Editable = false;
            oMatrix.Columns.Item("Col_2").Editable = false;

            oMatrix.LoadFromDataSource();
            oMatrix.AutoResizeColumns();

            EditText6.Item.Enabled = true;
            EditText4.Item.Enabled = true;
            EditText38.Value = "";
        }

        public RegistroControlEnvasado(string docnum, string numOT_Envasado, string DocEntryOP, 
                                       string FechaCreacionOP,string AprobCalidadOP, string Muestra1OP,
                                       string HoraOPt, string DocEntryOT, string TanqueOT, int Correlativo, 
                                       double PesoOptimo, double PesoMaximo,string HoraAprobadaMuestraFinal,
                                       string HoraEntrMuestraFinal, string Hora_Entrega_Linea,string Hora_Aprobada_Linea,
                                       string U_VIS_NOM_REP, string U_VIS_UND_MED,string U_VIS_ENV_P1,
                                       string U_VIS_ETI_P1, string U_VIS_ENC1_P1, string U_VIS_ENC2_P1, 
                                       string U_VIS_OP1_P1, string U_VIS_OP2_P1,string U_VIS_MAR1_P1, 
                                       string U_VIS_MAR2_P1,string U_VIS_FECHA_P1,string U_VIS_HORA_INI_P1,
                                       string U_VIS_HORA_FIN_P1, string U_VIS_PRES_P1,string U_VIS_CANTIDAD_P1, 
                                       string U_VIS_COD_REG_BAL_P1,string U_VIS_PRE_LIMP1, string U_VIS_PRE_LIMP2,
                                       string U_VIS_PRE_LIMP3, string U_VIS_ENV_P2,string U_VIS_ETI_P2,string U_VIS_ENC1_P2, 
                                       string U_VIS_ENC2_P2, string U_VIS_OP1_P2, string U_VIS_OP2_P2, string U_VIS_MAR1_P2,
                                       string U_VIS_MAR2_P2, string U_VIS_FECHA_P2,string U_VIS_HORA_INI_P2, string U_VIS_HORA_FIN_P2,
                                       string U_VIS_PRES_P2, string U_VIS_CANTIDAD_P2, string U_VIS_COD_REG_BAL_P2,string U_VIS_ENV_P3, 
                                       string U_VIS_ETI_P3, string U_VIS_ENC1_P3,string U_VIS_ENC2_P3, string U_VIS_OP1_P3, 
                                       string U_VIS_OP2_P3, string U_VIS_MAR1_P3, string U_VIS_MAR2_P3, string U_VIS_FECHA_P3,
                                       string U_VIS_HORA_INI_P3,string U_VIS_HORA_FIN_P3, string U_VIS_PRES_P3, string U_VIS_CANTIDAD_P3, 
                                       string U_VIS_COD_REG_BAL_P3)
        {
        
            DocNum = docnum;
            NumOT_Envasado = numOT_Envasado;
            EditText11.Value = numOT_Envasado;
            EditText14.Value = docnum;
            EditText59.Value = docnum ;
            EditText60.Value = numOT_Envasado;

            EditText8.Value = Convert.ToString(PesoOptimo);
            EditText9.Value = Convert.ToString(PesoMaximo);

            EditText2.Value = U_VIS_NOM_REP;
            Button7.Item.Enabled = false;
            EditText10.Value = U_VIS_UND_MED;
            EditText13.Value = TanqueOT;
            EditText57.Value = Convert.ToString(Correlativo);

            EditText61.Value = DocEntryOT;
            EditText62.Value = DocEntryOP;

            if (U_VIS_PRE_LIMP1=="Si")
            {
                ComboBox0.Select("Si");
            }
            else
            {
                ComboBox0.Select("No");
            }

            EditText3.Value = U_VIS_PRE_LIMP2;
            if (U_VIS_PRE_LIMP3 == "Si")
            {
                ComboBox1.Select("Si");
            }
            else
            {
                ComboBox1.Select("No");
            }
          //EditText15.Value = Convert.ToDateTime(U_VIS_FECHA_P1).ToString("yyyyMMdd");
            EditText16.Value = U_VIS_HORA_INI_P1;
            EditText17.Value = U_VIS_HORA_FIN_P1;

            EditText26.Value = U_VIS_PRES_P1;
            EditText27.Value = U_VIS_CANTIDAD_P1;
            EditText28.Value = U_VIS_COD_REG_BAL_P1;
            EditText18.Value = U_VIS_ENV_P1;
            EditText19.Value = U_VIS_ETI_P1;
            EditText20.Value = U_VIS_ENC1_P1;
            EditText21.Value = U_VIS_ENC2_P1;
            EditText22.Value = U_VIS_OP1_P1;
            EditText23.Value = U_VIS_OP2_P1;
            EditText24.Value = U_VIS_MAR1_P1;
            EditText25.Value = U_VIS_MAR2_P1;

          //EditText29.Value = Convert.ToDateTime(U_VIS_FECHA_P2).ToString("yyyyMMdd");
            EditText30.Value = U_VIS_HORA_INI_P2;
            EditText31.Value = U_VIS_HORA_FIN_P2;
            EditText32.Value = U_VIS_ENV_P2;
            EditText33.Value = U_VIS_ETI_P2;
            EditText34.Value = U_VIS_ENC1_P2;
            EditText35.Value = U_VIS_ENC2_P2;
            EditText36.Value = U_VIS_OP1_P2;
            EditText37.Value = U_VIS_OP2_P2;
            EditText38.Value = U_VIS_MAR1_P2;
            EditText39.Value = U_VIS_MAR2_P2;
            EditText40.Value = U_VIS_PRES_P2;
            EditText41.Value = U_VIS_CANTIDAD_P2;
            EditText42.Value = U_VIS_COD_REG_BAL_P2;

          //EditText43.Value = Convert.ToDateTime(U_VIS_FECHA_P3).ToString("yyyyMMdd");
            EditText44.Value = U_VIS_HORA_INI_P3;
            EditText45.Value = U_VIS_HORA_FIN_P3;
            EditText46.Value = U_VIS_ENV_P3;
            EditText47.Value = U_VIS_ETI_P3;
            EditText48.Value = U_VIS_ENC1_P3;
            EditText49.Value = U_VIS_ENC2_P3;
            EditText50.Value = U_VIS_OP1_P3;
            EditText51.Value = U_VIS_OP2_P3;
            EditText52.Value = U_VIS_MAR1_P3;
            EditText53.Value = U_VIS_MAR2_P3;
            EditText54.Value = U_VIS_PRES_P3;
            EditText55.Value = U_VIS_CANTIDAD_P3;
            EditText56.Value = U_VIS_COD_REG_BAL_P3;
            OptionBtn1.GroupWith("Item_2");
            OptionBtn0.Selected=true;

           if (FechaCreacionOP != "30/12/1899 00:00:00")
            {
                EditText0.Value = Convert.ToDateTime(FechaCreacionOP).ToString("yyyyMMdd");
            }
            if (U_VIS_FECHA_P1 != "30/12/1899 00:00:00")
            {
                EditText15.Value = Convert.ToDateTime(U_VIS_FECHA_P1).ToString("yyyyMMdd");
            }
            if (U_VIS_FECHA_P3 != "30/12/1899 00:00:00")
            {
                EditText43.Value = Convert.ToDateTime(U_VIS_FECHA_P3).ToString("yyyyMMdd");
            }
            if (U_VIS_FECHA_P2 != "30/12/1899 00:00:00")
            {
                EditText29.Value = Convert.ToDateTime(U_VIS_FECHA_P2).ToString("yyyyMMdd");
            }

             if (HoraOPt==null)
             {
                 HoraOPt = "";
             }
             if (HoraAprobadaMuestraFinal == null)
             {
                 HoraAprobadaMuestraFinal = "";
             }
             if (HoraEntrMuestraFinal == null)
             {
                 HoraEntrMuestraFinal = "";
             }
             if (Hora_Entrega_Linea == null)
             {
                 Hora_Entrega_Linea = "";
             }
             if (Hora_Aprobada_Linea == null)
             {
                 Hora_Aprobada_Linea = "";
             }
             
                EditText1.Value = HoraOPt;
                EditText6.Value = HoraAprobadaMuestraFinal;
                EditText7.Value = HoraEntrMuestraFinal;
                EditText4.Value = Hora_Entrega_Linea;
                EditText5.Value = Hora_Aprobada_Linea;
           

            if (EditText7.Value != "")
            {
                OptionBtn10.Selected = true;
            }
            else
            {
                OptionBtn11.Selected = true;
            }

            if (EditText5.Value != "")
            {
                OptionBtn8.Selected = true;
            }
            else
            {
                OptionBtn9.Selected = true;
            }


            if (AprobCalidadOP == "S")
            {
                OptionBtn0.Selected = true;
                OptionBtn2.Selected = true;
            }
            else
            {
                OptionBtn1.Selected = true;
                OptionBtn3.Selected = true;
            }

            OptionBtn0.Item.Enabled = false;
            OptionBtn1.Item.Enabled = false;
            OptionBtn2.Item.Enabled = false;
            OptionBtn3.Item.Enabled = false;
            OptionBtn10.Item.Enabled = false;
            OptionBtn11.Item.Enabled = false;

            string strHANA = "";
            SAPbouiCOM.DataTable udt;

            strHANA = string.Format("CALL P_VIST_ADDON_GET_CONTROL_ENVASADO('{0}')", docnum);
            udt = oForm.DataSources.DataTables.Item("DT_2");

            udt.ExecuteQuery(strHANA);
            oMatrix = oForm.GetMatrix("Item_191");

            SAPbouiCOM.Columns oColumns;
            oColumns = oMatrix.Columns;
            var colItems = udt.Columns;

            oColumns = oMatrix.Columns;

            oForm.SetEditText("Item_9", udt.GetString("U_VIS_NOM_REP", 0), true);
            oForm.SetEditText("Item_19", udt.GetString("U_VIS_PRE_LIMP2", 0), true);

            oMatrix.Columns.Item("Col_0").DataBind.SetBound(true, "@VIS_OWOR_ENV_D", "U_VIS_COD_ENV");
            oMatrix.Columns.Item("Col_1").DataBind.SetBound(true, "@VIS_OWOR_ENV_D", "U_VIS_DESC_ENV");
            oMatrix.Columns.Item("Col_2").DataBind.SetBound(true, "@VIS_OWOR_ENV_D", "U_VIS_CANTIDAD");
            oMatrix.Columns.Item("Col_3").DataBind.SetBound(true, "@VIS_OWOR_ENV_D", "U_VIS_REQUERIDO_EV");
            oMatrix.Columns.Item("Col_4").DataBind.SetBound(true, "@VIS_OWOR_ENV_D", "U_VIS_DEV_EV");
            oMatrix.Columns.Item("Col_5").DataBind.SetBound(true, "@VIS_OWOR_ENV_D", "U_VIS_MERMA_EV");

            for (int oRows = 0; oRows < udt.Rows.Count; oRows++)
            {
                SAPbouiCOM.DBDataSource oDatasource = oForm.GetDBDataSource("@VIS_OWOR_ENV_D");
                int rowCount = 0;

                rowCount = oDatasource.Offset;

                rowCount = rowCount + 1;

                oDatasource.InsertRecord(oDatasource.Size);
                oDatasource.Offset = oDatasource.Size - 1;
                oMatrix.AddRow(1, rowCount);

                oDatasource.SetValue("U_VIS_COD_ENV", oRows, udt.GetString("U_VIS_COD_ENV", oRows));
                oDatasource.SetValue("U_VIS_DESC_ENV", oRows, udt.GetString("U_VIS_DESC_ENV", oRows));
                oDatasource.SetValue("U_VIS_CANTIDAD", oRows, udt.GetString("U_VIS_CANTIDAD", oRows));
                oDatasource.SetValue("U_VIS_REQUERIDO_EV", oRows, udt.GetString("U_VIS_REQUERIDO_EV", oRows));
                oDatasource.SetValue("U_VIS_DEV_EV", oRows, udt.GetString("U_VIS_DEV_EV", oRows));
                oDatasource.SetValue("U_VIS_MERMA_EV", oRows, udt.GetString("U_VIS_MERMA_EV", oRows));
                oMatrix.AutoResizeColumns();
            }

            oMatrix.Item.Enabled = false;

            oMatrix.LoadFromDataSource();
            oMatrix.AutoResizeColumns();
            //  ButtonEditable();
            oForm.Mode = BoFormMode.fm_VIEW_MODE;
        }


        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("1").Specific));
            this.Button0.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button0_ClickBefore);
            this.Button0.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button0_ClickAfter);
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_1").Specific));
            this.OptionBtn0 = ((SAPbouiCOM.OptionBtn)(this.GetItem("Item_2").Specific));
            this.OptionBtn1 = ((SAPbouiCOM.OptionBtn)(this.GetItem("Item_3").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_4").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_5").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_6").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_7").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_8").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_9").Specific));
            this.EditText2.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText2_ClickAfter);
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_10").Specific));
            this.OptionBtn2 = ((SAPbouiCOM.OptionBtn)(this.GetItem("Item_11").Specific));
            this.OptionBtn3 = ((SAPbouiCOM.OptionBtn)(this.GetItem("Item_12").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_13").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_14").Specific));
            //                              this.OptionBtn4.ClickAfter += new SAPbouiCOM._IOptionBtnEvents_ClickAfterEventHandler(this.OptionBtn4_ClickAfter);
            //                              this.OptionBtn5.ClickAfter += new SAPbouiCOM._IOptionBtnEvents_ClickAfterEventHandler(this.OptionBtn5_ClickAfter);
            this.StaticText7 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_17").Specific));
            this.StaticText8 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_18").Specific));
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("Item_19").Specific));
            this.EditText3.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText3_ClickAfter);
            //                             this.OptionBtn6.ClickAfter += new SAPbouiCOM._IOptionBtnEvents_ClickAfterEventHandler(this.OptionBtn6_ClickAfter);
            //                              this.OptionBtn7.ClickAfter += new SAPbouiCOM._IOptionBtnEvents_ClickAfterEventHandler(this.OptionBtn7_ClickAfter);
            this.StaticText9 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_22").Specific));
            this.StaticText10 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_23").Specific));
            this.StaticText11 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_24").Specific));
            this.EditText4 = ((SAPbouiCOM.EditText)(this.GetItem("Item_25").Specific));
            this.EditText4.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText4_ClickAfter);
            this.EditText5 = ((SAPbouiCOM.EditText)(this.GetItem("Item_26").Specific));
            this.EditText5.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText5_ClickAfter);
            this.StaticText12 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_27").Specific));
            this.OptionBtn8 = ((SAPbouiCOM.OptionBtn)(this.GetItem("Item_28").Specific));
            this.OptionBtn8.ClickBefore += new SAPbouiCOM._IOptionBtnEvents_ClickBeforeEventHandler(this.OptionBtn8_ClickBefore);
            this.OptionBtn9 = ((SAPbouiCOM.OptionBtn)(this.GetItem("Item_29").Specific));
            this.OptionBtn9.ClickAfter += new SAPbouiCOM._IOptionBtnEvents_ClickAfterEventHandler(this.OptionBtn9_ClickAfter);
            this.StaticText13 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_30").Specific));
            this.StaticText14 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_31").Specific));
            this.StaticText15 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_32").Specific));
            this.StaticText16 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_33").Specific));
            this.StaticText17 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_34").Specific));
            this.EditText6 = ((SAPbouiCOM.EditText)(this.GetItem("Item_35").Specific));
            this.EditText6.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText6_ClickAfter);
            this.EditText7 = ((SAPbouiCOM.EditText)(this.GetItem("Item_36").Specific));
            this.OptionBtn10 = ((SAPbouiCOM.OptionBtn)(this.GetItem("Item_38").Specific));
            this.OptionBtn11 = ((SAPbouiCOM.OptionBtn)(this.GetItem("Item_39").Specific));
            this.StaticText18 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_40").Specific));
            this.StaticText19 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_41").Specific));
            this.StaticText20 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_42").Specific));
            this.StaticText21 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_43").Specific));
            this.EditText8 = ((SAPbouiCOM.EditText)(this.GetItem("Item_44").Specific));
            this.EditText9 = ((SAPbouiCOM.EditText)(this.GetItem("Item_45").Specific));
            this.EditText10 = ((SAPbouiCOM.EditText)(this.GetItem("Item_46").Specific));
            this.EditText10.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.EditText10_ChooseFromListAfter);
            this.EditText11 = ((SAPbouiCOM.EditText)(this.GetItem("Item_48").Specific));
            this.StaticText23 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_49").Specific));
            this.StaticText24 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_50").Specific));
            this.Grid1 = ((SAPbouiCOM.Grid)(this.GetItem("Item_37").Specific));
            this.Grid1.ClickAfter += new SAPbouiCOM._IGridEvents_ClickAfterEventHandler(this.Grid1_ClickAfter);
            this.StaticText27 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_56").Specific));
            this.EditText13 = ((SAPbouiCOM.EditText)(this.GetItem("Item_57").Specific));
            this.EditText13.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText13_ClickAfter);
            this.StaticText28 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_58").Specific));
            this.EditText14 = ((SAPbouiCOM.EditText)(this.GetItem("Item_59").Specific));
            this.EditText14.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText14_ClickAfter);
            this.Grid2 = ((SAPbouiCOM.Grid)(this.GetItem("Item_60").Specific));
            this.Folder0 = ((SAPbouiCOM.Folder)(this.GetItem("Item_62").Specific));
            this.Folder0.ClickAfter += new SAPbouiCOM._IFolderEvents_ClickAfterEventHandler(this.Folder0_ClickAfter);
            this.Folder1 = ((SAPbouiCOM.Folder)(this.GetItem("Item_63").Specific));
            this.Folder1.ClickBefore += new SAPbouiCOM._IFolderEvents_ClickBeforeEventHandler(this.Folder1_ClickBefore);
            this.Folder1.ClickAfter += new SAPbouiCOM._IFolderEvents_ClickAfterEventHandler(this.Folder1_ClickAfter);
            this.Folder2 = ((SAPbouiCOM.Folder)(this.GetItem("Item_64").Specific));
            this.Folder2.ClickAfter += new SAPbouiCOM._IFolderEvents_ClickAfterEventHandler(this.Folder2_ClickAfter);
            this.StaticText29 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_65").Specific));
            this.EditText15 = ((SAPbouiCOM.EditText)(this.GetItem("Item_66").Specific));
            this.EditText15.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText15_ClickAfter);
            this.StaticText30 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_67").Specific));
            this.StaticText31 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_68").Specific));
            this.StaticText32 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_69").Specific));
            this.EditText16 = ((SAPbouiCOM.EditText)(this.GetItem("Item_70").Specific));
            this.EditText16.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText16_ClickAfter);
            this.EditText17 = ((SAPbouiCOM.EditText)(this.GetItem("Item_71").Specific));
            this.EditText17.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText17_ClickAfter);
            this.StaticText33 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_72").Specific));
            this.StaticText34 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_73").Specific));
            this.EditText18 = ((SAPbouiCOM.EditText)(this.GetItem("Item_74").Specific));
            this.EditText18.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText18_ClickAfter);
            this.EditText19 = ((SAPbouiCOM.EditText)(this.GetItem("Item_75").Specific));
            this.EditText19.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText19_ClickAfter);
            this.StaticText35 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_76").Specific));
            this.StaticText36 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_77").Specific));
            this.EditText20 = ((SAPbouiCOM.EditText)(this.GetItem("Item_78").Specific));
            this.EditText20.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText20_ClickAfter);
            this.EditText21 = ((SAPbouiCOM.EditText)(this.GetItem("Item_79").Specific));
            this.EditText21.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText21_ClickAfter);
            this.StaticText37 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_80").Specific));
            this.StaticText38 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_81").Specific));
            this.StaticText39 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_82").Specific));
            this.StaticText40 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_83").Specific));
            this.EditText22 = ((SAPbouiCOM.EditText)(this.GetItem("Item_84").Specific));
            this.EditText22.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText22_ClickAfter);
            this.EditText23 = ((SAPbouiCOM.EditText)(this.GetItem("Item_85").Specific));
            this.EditText23.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText23_ClickAfter);
            this.EditText24 = ((SAPbouiCOM.EditText)(this.GetItem("Item_86").Specific));
            this.EditText24.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText24_ClickAfter);
            this.EditText25 = ((SAPbouiCOM.EditText)(this.GetItem("Item_87").Specific));
            this.EditText25.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText25_ClickAfter);
            this.EditText26 = ((SAPbouiCOM.EditText)(this.GetItem("Item_88").Specific));
            this.EditText26.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText26_ClickAfter);
            this.EditText27 = ((SAPbouiCOM.EditText)(this.GetItem("Item_89").Specific));
            this.StaticText41 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_90").Specific));
            this.StaticText42 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_91").Specific));
            this.Button3 = ((SAPbouiCOM.Button)(this.GetItem("Item_92").Specific));
            this.Button3.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button3_ChooseFromListAfter);
            this.EditText28 = ((SAPbouiCOM.EditText)(this.GetItem("Item_93").Specific));
            this.EditText28.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText28_ClickAfter);
            this.StaticText43 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_94").Specific));
            this.StaticText44 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_95").Specific));
            this.StaticText45 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_96").Specific));
            this.EditText29 = ((SAPbouiCOM.EditText)(this.GetItem("Item_97").Specific));
            this.StaticText46 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_98").Specific));
            this.StaticText47 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_99").Specific));
            this.StaticText48 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_100").Specific));
            this.EditText30 = ((SAPbouiCOM.EditText)(this.GetItem("Item_101").Specific));
            this.EditText30.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText30_ClickAfter);
            this.EditText31 = ((SAPbouiCOM.EditText)(this.GetItem("Item_102").Specific));
            this.EditText31.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText31_ClickAfter);
            this.StaticText49 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_103").Specific));
            this.StaticText50 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_104").Specific));
            this.EditText32 = ((SAPbouiCOM.EditText)(this.GetItem("Item_105").Specific));
            this.EditText32.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText32_ClickAfter);
            this.EditText33 = ((SAPbouiCOM.EditText)(this.GetItem("Item_106").Specific));
            this.EditText33.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText33_ClickAfter);
            this.StaticText51 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_107").Specific));
            this.StaticText52 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_108").Specific));
            this.EditText34 = ((SAPbouiCOM.EditText)(this.GetItem("Item_109").Specific));
            this.EditText34.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText34_ClickAfter);
            this.EditText35 = ((SAPbouiCOM.EditText)(this.GetItem("Item_110").Specific));
            this.EditText35.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText35_ClickAfter);
            this.StaticText53 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_111").Specific));
            this.StaticText54 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_112").Specific));
            this.StaticText55 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_113").Specific));
            this.StaticText56 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_114").Specific));
            this.EditText36 = ((SAPbouiCOM.EditText)(this.GetItem("Item_115").Specific));
            this.EditText36.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText36_ClickAfter);
            this.EditText37 = ((SAPbouiCOM.EditText)(this.GetItem("Item_116").Specific));
            this.EditText37.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText37_ClickAfter);
            this.EditText38 = ((SAPbouiCOM.EditText)(this.GetItem("Item_117").Specific));
            this.EditText38.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText38_ClickAfter);
            this.EditText39 = ((SAPbouiCOM.EditText)(this.GetItem("Item_118").Specific));
            this.EditText39.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText39_ClickAfter);
            this.EditText40 = ((SAPbouiCOM.EditText)(this.GetItem("Item_119").Specific));
            this.EditText40.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText40_ClickAfter);
            this.EditText41 = ((SAPbouiCOM.EditText)(this.GetItem("Item_120").Specific));
            this.EditText41.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText41_ClickAfter);
            this.StaticText57 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_121").Specific));
            this.StaticText58 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_122").Specific));
            this.Button4 = ((SAPbouiCOM.Button)(this.GetItem("Item_123").Specific));
            this.Button4.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button4_ChooseFromListAfter);
            this.EditText42 = ((SAPbouiCOM.EditText)(this.GetItem("Item_124").Specific));
            this.EditText42.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText42_ClickAfter);
            this.StaticText59 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_125").Specific));
            this.StaticText60 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_126").Specific));
            this.StaticText61 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_127").Specific));
            this.EditText43 = ((SAPbouiCOM.EditText)(this.GetItem("Item_128").Specific));
            this.EditText43.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText43_ClickAfter);
            this.StaticText62 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_129").Specific));
            this.StaticText63 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_130").Specific));
            this.StaticText64 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_131").Specific));
            this.EditText44 = ((SAPbouiCOM.EditText)(this.GetItem("Item_132").Specific));
            this.EditText45 = ((SAPbouiCOM.EditText)(this.GetItem("Item_133").Specific));
            this.StaticText65 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_134").Specific));
            this.StaticText66 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_135").Specific));
            this.EditText46 = ((SAPbouiCOM.EditText)(this.GetItem("Item_136").Specific));
            this.EditText46.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText46_ClickAfter);
            this.EditText47 = ((SAPbouiCOM.EditText)(this.GetItem("Item_137").Specific));
            this.StaticText67 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_138").Specific));
            this.StaticText68 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_139").Specific));
            this.EditText48 = ((SAPbouiCOM.EditText)(this.GetItem("Item_140").Specific));
            this.EditText49 = ((SAPbouiCOM.EditText)(this.GetItem("Item_141").Specific));
            this.StaticText69 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_142").Specific));
            this.StaticText70 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_143").Specific));
            this.StaticText71 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_144").Specific));
            this.StaticText72 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_145").Specific));
            this.EditText50 = ((SAPbouiCOM.EditText)(this.GetItem("Item_146").Specific));
            this.EditText51 = ((SAPbouiCOM.EditText)(this.GetItem("Item_147").Specific));
            this.EditText52 = ((SAPbouiCOM.EditText)(this.GetItem("Item_148").Specific));
            this.EditText53 = ((SAPbouiCOM.EditText)(this.GetItem("Item_149").Specific));
            this.EditText53.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText53_ClickAfter);
            this.EditText54 = ((SAPbouiCOM.EditText)(this.GetItem("Item_150").Specific));
            this.EditText54.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText54_ClickAfter);
            this.EditText55 = ((SAPbouiCOM.EditText)(this.GetItem("Item_151").Specific));
            this.EditText55.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText55_ClickAfter);
            this.StaticText73 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_152").Specific));
            this.StaticText74 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_153").Specific));
            this.Button5 = ((SAPbouiCOM.Button)(this.GetItem("Item_154").Specific));
            this.Button5.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button5_ChooseFromListAfter);
            this.EditText56 = ((SAPbouiCOM.EditText)(this.GetItem("Item_155").Specific));
            this.EditText56.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText56_ClickAfter);
            this.StaticText75 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_156").Specific));
            this.StaticText76 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_157").Specific));
            this.Button6 = ((SAPbouiCOM.Button)(this.GetItem("2").Specific));
            this.Folder3 = ((SAPbouiCOM.Folder)(this.GetItem("Item_159").Specific));
            this.EditText57 = ((SAPbouiCOM.EditText)(this.GetItem("Item_160").Specific));
            this.EditText57.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText57_ClickAfter);
            this.StaticText25 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_161").Specific));
            this.StaticText26 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_162").Specific));
            this.EditText58 = ((SAPbouiCOM.EditText)(this.GetItem("Item_163").Specific));
            this.LinkedButton0 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_164").Specific));
            this.LinkedButton1 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_165").Specific));
            this.Folder4 = ((SAPbouiCOM.Folder)(this.GetItem("Item_166").Specific));
            this.Button7 = ((SAPbouiCOM.Button)(this.GetItem("Item_47").Specific));
            this.Button7.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button7_ClickAfter);
            this.Button7.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button7_ChooseFromListAfter);
            this.EditText59 = ((SAPbouiCOM.EditText)(this.GetItem("Item_52").Specific));
            this.LinkedButton2 = ((SAPbouiCOM.LinkedButton)(this.GetItem("Item_167").Specific));
            this.Button8 = ((SAPbouiCOM.Button)(this.GetItem("Item_168").Specific));
            this.Button8.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button8_ChooseFromListAfter);
            this.Button9 = ((SAPbouiCOM.Button)(this.GetItem("Item_169").Specific));
            this.Button9.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button9_ClickAfter);
            this.Button9.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button9_ChooseFromListAfter);
            this.Button10 = ((SAPbouiCOM.Button)(this.GetItem("Item_170").Specific));
            this.Button10.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button10_ClickAfter);
            this.Button10.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button10_ChooseFromListAfter);
            this.Button11 = ((SAPbouiCOM.Button)(this.GetItem("Item_171").Specific));
            this.Button11.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button11_ClickAfter);
            this.Button11.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button11_ChooseFromListAfter);
            this.Button12 = ((SAPbouiCOM.Button)(this.GetItem("Item_172").Specific));
            this.Button12.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button12_ClickAfter);
            this.Button12.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button12_ChooseFromListAfter);
            this.Button13 = ((SAPbouiCOM.Button)(this.GetItem("Item_173").Specific));
            this.Button13.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button13_ClickAfter);
            this.Button13.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button13_ChooseFromListAfter);
            this.Button14 = ((SAPbouiCOM.Button)(this.GetItem("Item_174").Specific));
            this.Button14.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button14_ClickAfter);
            this.Button14.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button14_ChooseFromListAfter);
            this.Button15 = ((SAPbouiCOM.Button)(this.GetItem("Item_175").Specific));
            this.Button15.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button15_ClickAfter);
            this.Button15.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button15_ChooseFromListAfter);
            this.Button16 = ((SAPbouiCOM.Button)(this.GetItem("Item_176").Specific));
            this.Button16.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button16_ClickAfter);
            this.Button16.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button16_ChooseFromListAfter);
            this.Button17 = ((SAPbouiCOM.Button)(this.GetItem("Item_177").Specific));
            this.Button17.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button17_ClickAfter);
            this.Button17.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button17_ChooseFromListAfter);
            this.Button18 = ((SAPbouiCOM.Button)(this.GetItem("Item_178").Specific));
            this.Button18.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button18_ClickAfter);
            this.Button18.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button18_ChooseFromListAfter);
            this.Button19 = ((SAPbouiCOM.Button)(this.GetItem("Item_179").Specific));
            this.Button19.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button19_ClickAfter);
            this.Button19.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button19_ChooseFromListAfter);
            this.Button20 = ((SAPbouiCOM.Button)(this.GetItem("Item_180").Specific));
            this.Button20.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button20_ClickAfter);
            this.Button20.ClickBefore += new SAPbouiCOM._IButtonEvents_ClickBeforeEventHandler(this.Button20_ClickBefore);
            this.Button20.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button20_ChooseFromListAfter);
            this.Button21 = ((SAPbouiCOM.Button)(this.GetItem("Item_181").Specific));
            this.Button21.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button21_ClickAfter);
            this.Button21.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button21_ChooseFromListAfter);
            this.Button22 = ((SAPbouiCOM.Button)(this.GetItem("Item_182").Specific));
            this.Button22.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button22_ClickAfter);
            this.Button22.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button22_ChooseFromListAfter);
            this.Button23 = ((SAPbouiCOM.Button)(this.GetItem("Item_183").Specific));
            this.Button23.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button23_ClickAfter);
            this.Button23.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button23_ChooseFromListAfter);
            this.Button24 = ((SAPbouiCOM.Button)(this.GetItem("Item_184").Specific));
            this.Button24.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button24_ClickAfter);
            this.Button24.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button24_ChooseFromListAfter);
            this.Button2 = ((SAPbouiCOM.Button)(this.GetItem("Item_53").Specific));
            this.Button2.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button2_ClickAfter);
            this.Button2.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button2_ChooseFromListAfter);
            this.Button25 = ((SAPbouiCOM.Button)(this.GetItem("Item_54").Specific));
            this.Button25.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button25_ClickAfter);
            this.Button25.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button25_ChooseFromListAfter);
            this.Button26 = ((SAPbouiCOM.Button)(this.GetItem("Item_185").Specific));
            this.Button26.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button26_ClickAfter);
            this.Button26.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button26_ChooseFromListAfter);
            this.Button27 = ((SAPbouiCOM.Button)(this.GetItem("Item_186").Specific));
            this.Button27.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button27_ClickAfter);
            this.Button27.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button27_ChooseFromListAfter);
            this.Button28 = ((SAPbouiCOM.Button)(this.GetItem("Item_187").Specific));
            this.Button28.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button28_ClickAfter);
            this.Button28.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button28_ChooseFromListAfter);
            this.Button29 = ((SAPbouiCOM.Button)(this.GetItem("Item_188").Specific));
            this.Button29.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button29_ClickAfter);
            this.Button29.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button29_ChooseFromListAfter);
            this.Button30 = ((SAPbouiCOM.Button)(this.GetItem("Item_189").Specific));
            this.Button30.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button30_ClickAfter);
            this.Button30.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button30_ChooseFromListAfter);
            this.Button31 = ((SAPbouiCOM.Button)(this.GetItem("Item_190").Specific));
            this.Button31.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button31_ClickAfter);
            this.Button31.ChooseFromListAfter += new SAPbouiCOM._IButtonEvents_ChooseFromListAfterEventHandler(this.Button31_ChooseFromListAfter);
            this.Matrix0 = ((SAPbouiCOM.Matrix)(this.GetItem("Item_191").Specific));
            this.StaticText22 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_192").Specific));
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_196").Specific));
            this.ComboBox1 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_197").Specific));
            this.EditText61 = ((SAPbouiCOM.EditText)(this.GetItem("Item_0").Specific));
            this.EditText62 = ((SAPbouiCOM.EditText)(this.GetItem("Item_15").Specific));
            this.EditText60 = ((SAPbouiCOM.EditText)(this.GetItem("Item_55").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
            this.LoadAfter += new SAPbouiCOM.Framework.FormBase.LoadAfterHandler(this.Form_LoadAfter);
        }

        private void Form_LoadAfter(SAPbouiCOM.SBOItemEventArg pVal)
        {
            // throw new System.NotImplementedException();

        }

        private void OnCustomInitialize()
        {
            oForm = SAPbouiCOM.Framework.Application.SBO_Application.Forms.Item(this.UIAPIRawForm.UniqueID);
            oForm.ScreenCenter();
            EditText58.Value = DateTime.Now.Date.ToString("yyyyMMdd");

            OptionBtn0.GroupWith("Item_3");
            OptionBtn2.GroupWith("Item_12");
            OptionBtn10.GroupWith("Item_39");
            OptionBtn8.GroupWith("Item_29");
            OptionBtn9.GroupWith("Item_28");

            Folder0.Select();
        }

        private SAPbouiCOM.Button Button0;

        private void Button0_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {

        }

        private void Button1_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {

        }

        private void Button2_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_23", "dept", "25");
        }

        private void Folder0_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            Folder0.AutoPaneSelection = true;
        }

        private void Folder1_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            OptionBtn8.Selected = true;
            Folder1.AutoPaneSelection = true;
            if (EditText5.Value != "")
            {
                OptionBtn8.Selected = true;
            }
            else
            {
                OptionBtn9.Selected = true;
            }

        }

        private void Folder2_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            Folder2.AutoPaneSelection = true;

        }

        private void EditText10_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText10.Value = chooseFromListEvent.SelectedObjects.GetValue("UomCode", 0).ToString();

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Form_ClickAfter(SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }


        private void EditText13_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText14_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText15_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText16_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText17_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText18_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText19_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText20_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText21_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText22_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText23_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText24_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText25_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText28_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void Button3_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText26.Value = chooseFromListEvent.SelectedObjects.GetValue("UomCode", 0).ToString();

                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void EditText26_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void Button4_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText40.Value = chooseFromListEvent.SelectedObjects.GetValue("UomCode", 0).ToString();

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Button5_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText54.Value = chooseFromListEvent.SelectedObjects.GetValue("UomCode", 0).ToString();

                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void Grid1_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText30_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText31_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText32_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText34_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText35_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText33_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText36_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText37_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText38_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText39_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText42_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText40_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText41_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText54_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText43_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText53_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText55_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText56_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private SAPbouiCOM.Button Button6;
        private SAPbouiCOM.Folder Folder3;
        private SAPbouiCOM.EditText EditText57;
        private SAPbouiCOM.StaticText StaticText25;
        private SAPbouiCOM.StaticText StaticText26;
        private SAPbouiCOM.EditText EditText58;
        private SAPbouiCOM.LinkedButton LinkedButton0;
        private SAPbouiCOM.LinkedButton LinkedButton1;
        private SAPbouiCOM.Folder Folder4;
        private SAPbouiCOM.Button Button7;

        private void Button7_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText2.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private SAPbouiCOM.EditText EditText59;
        private LinkedButton LinkedButton2;
        private Button Button8;

        private void Button8_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText3.Value = chooseFromListEvent.SelectedObjects.GetValue("ItemName", 0).ToString();

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void EditText3_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private Button Button9;
        private Button Button10;
        private Button Button11;
        private Button Button12;
        private Button Button13;
        private Button Button14;
        private Button Button15;
        private Button Button16;

        private void Button11_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText18.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Button10_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText19.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Button15_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText20.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void Button16_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText21.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void Button9_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText22.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void Button12_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText23.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Button13_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText24.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Button14_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText25.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private Button Button17;
        private Button Button18;
        private Button Button19;
        private Button Button20;
        private Button Button21;
        private Button Button22;
        private Button Button23;
        private Button Button24;

        private void Button17_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText32.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void Button21_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText33.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }

        }

        private void Button20_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText34.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Button19_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText35.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Button18_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText36.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Button22_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText37.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Button23_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText38.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void Button24_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText39.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void EditText4_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void EditText5_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void OptionBtn8_ClickBefore(object sboObject, SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();
        }

        private void OptionBtn9_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private Button Button2;
        private Button Button25;
        private Button Button26;
        private Button Button27;
        private Button Button28;
        private Button Button29;
        private Button Button30;
        private Button Button31;

        private void EditText46_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }
        private void Button2_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText46.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }

        }
        private void Button25_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText47.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }

        }
        private void Button26_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText48.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }

        }
        private void Button27_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText49.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }

        }
        private void Button28_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText50.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }

        }
        private void Button31_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText51.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }

        }
        private void Button30_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText52.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }

        }
        private void Button29_ChooseFromListAfter(object sboObject, SBOItemEventArg pVal)
        {

            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {

                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText53.Value = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString() +
                            " " + chooseFromListEvent.SelectedObjects.GetValue("middleName", 0).ToString() + " " + chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString(); ;

                    }
                }
            }
            catch (Exception)
            {

            }

        }
        private void Button29_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_30", "dept", "25");
        }
        private void Button0_ClickBefore(object sboObject, SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //  throw new System.NotImplementedException();

        }

        private Matrix Matrix0;

        private void EditText2_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private void Folder1_ClickBefore(object sboObject, SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            //throw new System.NotImplementedException();
            OptionBtn8.Selected = true;
        }

        private StaticText StaticText22;

        private void OptionBtn4_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            //EditText61.Value = "Si";
        }

        private void OptionBtn5_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            //EditText61.Value = "No";

        }

        private void OptionBtn6_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            // EditText62.Value = "Si";
        }

        private void OptionBtn7_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            // EditText62.Value = "No";

        }

        private ComboBox ComboBox0;
        private ComboBox ComboBox1;
        public void ChooseFromList_Empleados(string CFL_ ,string Alias,string condicion)
        {
            //throw new System.NotImplementedException();
            SAPbouiCOM.ChooseFromList cfl = oForm.ChooseFromLists.Item(CFL_);
            SAPbouiCOM.Conditions cons = cfl.GetConditions();
            SAPbouiCOM.Condition con;
            con = cons.Add();
            con.Alias = Alias;
            con.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
            con.CondVal = condicion;
            cfl.SetConditions(cons);
        }

        private void Button7_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
            ChooseFromList_Empleados("CFL_4", "dept", "25");
        }

        private void Button11_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_6", "dept", "25");

        }

        private void Button10_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_7", "dept", "25");
        }

        private void Button15_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_8", "dept", "25");
        }

        private void Button16_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_9", "dept", "25");
        }

        private void Button9_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_10", "dept", "25");
        }

        private void Button12_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_11", "dept", "25");

        }

        private void Button13_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_12", "dept", "25");
        }

        private void Button14_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_13", "dept", "25");
        }

        private void Button17_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_14", "dept", "25");
        }

        private void Button21_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_15", "dept", "25");
        }

        private void Button20_ClickBefore(object sboObject, SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
           // throw new System.NotImplementedException();

        }

        private void Button20_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_16", "dept", "25");
        }

        private void Button19_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_17", "dept", "25");
        }

        private void Button18_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_18", "dept", "25");
        }

        private void Button22_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_19", "dept", "25");
        }

        private void Button23_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_20", "dept", "25");
        }

        private void Button24_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_21", "dept", "25");
        }

        private void Button25_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_24", "dept", "25");
        }

        private void Button26_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_25", "dept", "25");

        }

        private void Button27_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_26", "dept", "25");
        }

        private void Button28_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_27", "dept", "25");
        }

        private void Button31_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_28", "dept", "25");

        }

        private void Button30_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            ChooseFromList_Empleados("CFL_29", "dept", "25");

        }

        private void EditText57_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private EditText EditText61;
        private EditText EditText62;
        private EditText EditText60;

        private void EditText6_ClickAfter(object sboObject, SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }
    }
}
