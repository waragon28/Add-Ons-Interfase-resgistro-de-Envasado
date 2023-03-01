using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;
using SAPbobsCOM;
using Forxap.AddonName.UI.Win;
using Forxap.Framework.Extensions;
using Forxap.Framework.UI;
using Forxap.AddonName.UI.Constans;
using Vistony.AddonName.BLL.Configuracion;
using Newtonsoft.Json;
using Vistony.AddonName.BLL;
using Vistony.AddonName.BO;

namespace Vistony.AddonName.Win.Asistentes
{
    [FormAttribute("65211", "Asistentes/Orden_Fabricacion.b1f")]
    class Orden_Fabricacion : SystemFormBase
    {
        public static SAPbouiCOM.Form oForm;
        public string usuario = Sb1Globals.UserName;
        public static string usuarioLogin = Sb1Globals.UserName;

        string DocEntryOP;
        string AprobCalidadOP;
        string DocEntryOT;
        string TanqueOT;
        string TypoListMaterial;
        string FechaApro_Lab;
        string HoraApro_Lab;
        string Code_VIS_OWOR_ENV = "";
        double PesoOptimo = 0;
        double MaximoOptimo = 0;
        int Correlativo = 0;
        string HoraAprobadaMuestraFinal;
        string HoraEntrMuestraFinal;
        string Hora_Entrega_Linea;
        string Hora_Aprobada_Linea;
        string U_VIS_PRE_LIMP1;
        string U_VIS_PRE_LIMP2;
        string U_VIS_PRE_LIMP3;
        string U_VIS_ENV_P1;
        string U_VIS_ETI_P1;
        string U_VIS_ENC1_P1;
        string U_VIS_ENC2_P1;
        string U_VIS_OP1_P1;
        string U_VIS_OP2_P1;
        string U_VIS_MAR1_P1;
        string U_VIS_MAR2_P1;
        string U_VIS_FECHA_P1;
        string U_VIS_HORA_INI_P1;
        string U_VIS_HORA_FIN_P1;
        string U_VIS_PRES_P1;
        string U_VIS_CANTIDAD_P1;
        string U_VIS_COD_REG_BAL_P1;
        string U_VIS_NOM_REP;
        string U_VIS_UND_MED;
        string U_VIS_ENV_P2;
        string U_VIS_ETI_P2;
        string U_VIS_ENC1_P2;
        string U_VIS_ENC2_P2;
        string U_VIS_OP1_P2;
        string U_VIS_OP2_P2;
        string U_VIS_MAR1_P2;
        string U_VIS_MAR2_P2;
        string U_VIS_FECHA_P2;
        string U_VIS_HORA_INI_P2;
        string U_VIS_HORA_FIN_P2;
        string U_VIS_PRES_P2;
        string U_VIS_CANTIDAD_P2;
        string U_VIS_COD_REG_BAL_P2;
        string OT_MEZCLA = "";
        string U_VIS_ENV_P3;
        string U_VIS_ETI_P3;
        string U_VIS_ENC1_P3;
        string U_VIS_ENC2_P3;
        string U_VIS_OP1_P3;
        string U_VIS_OP2_P3;
        string U_VIS_MAR1_P3;
        string U_VIS_MAR2_P3;
        string U_VIS_FECHA_P3;
        string U_VIS_HORA_INI_P3;
        string U_VIS_HORA_FIN_P3;
        string U_VIS_PRES_P3;
        string U_VIS_CANTIDAD_P3;
        string U_VIS_COD_REG_BAL_P3;
         Recordset recordset;
     

        private SAPbouiCOM.Button Button0;



        public void ObtenerOT_Trasvase(string DocNum, Recordset recordset)
        {
            string StrHANA = string.Empty;
            StrHANA = string.Format("SELECT DISTINCT a.\"DocEntry\",a.\"U_SYP_OP_ENV\" \"OT_Referencia\" " +
                "FROM OWOR a where \"DocNum\" = '{0}' ", DocNum);
            recordset.DoQuery(StrHANA);
            OT_MEZCLA = recordset.Fields.Item("OT_Referencia").Value.ToString();
            DocEntryOT = recordset.Fields.Item("DocEntry").Value.ToString();
        }
        public void ObtenerOP_Mezcla(string OP_Mezcla, Recordset recordset)
        {
            try
            {
                string StrHANA = string.Empty;
                StrHANA = string.Format("SELECT a.\"DocEntry\",\"U_VIS_Fecha_Aproba_Lab\" ," +
                                        "\"U_VIS_Hora_Aproba_Lab\", \"U_VIS_PesoOptimo_Lab\",\"U_VIS_PesoMaximo_Lab\", " +
                                        "a.\"U_VIS_HoraApr_Mu_Fin\",a.\"U_VIS_HoraEntr_Mu_Fin\", " +
                                        "a.\"U_VIS_Approved\" as \"Estado de Aprobación(Aprob.Calidad)\"," +
                                        "a.\"U_VIS_HoraEnt_Mu_Ini_Linea\"," +
                                        "a.\"U_VIS_HoraApr_Mu_Linea\"," +
                                        "a.\"U_VIS_Sample1\" as \"Estado de Aprobación(Muestra1)\",\"U_VIS_TypeListMtl\" FROM OWOR a where  a.\"DocNum\" = '{0}' ", OP_Mezcla);

                recordset.DoQuery(StrHANA);
                DocEntryOP = recordset.Fields.Item("DocEntry").Value.ToString();
                TypoListMaterial = recordset.Fields.Item("U_VIS_TypeListMtl").Value.ToString();
                AprobCalidadOP = recordset.Fields.Item("Estado de Aprobación(Aprob.Calidad)").Value.ToString();
                FechaApro_Lab = recordset.Fields.Item("U_VIS_Fecha_Aproba_Lab").Value.ToString();
                HoraApro_Lab = recordset.Fields.Item("U_VIS_Hora_Aproba_Lab").Value.ToString();
                PesoOptimo = Convert.ToDouble(recordset.Fields.Item("U_VIS_PesoOptimo_Lab").Value.ToString());
                MaximoOptimo = Convert.ToDouble(recordset.Fields.Item("U_VIS_PesoMaximo_Lab").Value.ToString());
                HoraAprobadaMuestraFinal = recordset.Fields.Item("U_VIS_HoraApr_Mu_Fin").Value.ToString();
                HoraEntrMuestraFinal = recordset.Fields.Item("U_VIS_HoraEntr_Mu_Fin").Value.ToString();
                Hora_Entrega_Linea = recordset.Fields.Item("U_VIS_HoraEnt_Mu_Ini_Linea").Value.ToString();
                Hora_Aprobada_Linea = recordset.Fields.Item("U_VIS_HoraApr_Mu_Linea").Value.ToString();
            }
            catch (Exception)
            {

                //throw;
            }


        }
        public void ObtenerTanqueOT(string DocNumOP, Recordset recordset)
        {
            string StrHANA = string.Empty;
            StrHANA = string.Format("SELECT T1.\"ItemCode\"  FROM OWOR T0 " +
                "INNER JOIN WOR1 T1 ON T1.\"DocEntry\" = T0.\"DocEntry\" " +
                "INNER JOIN ORSC T2 ON T2.\"VisResCode\" = T1.\"ItemCode\" and T2.\"ResGrpCod\" = '3' " +
                "where T0.\"DocNum\" = '{0}' ", DocNumOP);

            recordset.DoQuery(StrHANA);
            TanqueOT = recordset.Fields.Item("ItemCode").Value.ToString();
        }
        public void ObtenerVIS_OWOR_ENV(string DocNumOP, Recordset recordset)
        {
            string StrHANA = string.Empty;
            StrHANA = string.Format("SELECT * FROM \"@VIS_OWOR_ENV_C\" where \"U_VIS_OT_ENVASADO\" = '{0}' ", DocNumOP);

            recordset.DoQuery(StrHANA);
            Code_VIS_OWOR_ENV = recordset.Fields.Item("DocEntry").Value.ToString();
            U_VIS_NOM_REP = recordset.Fields.Item("U_VIS_NOM_REP").Value.ToString();
            U_VIS_UND_MED = recordset.Fields.Item("U_VIS_UND_MED").Value.ToString();
        }
        public void ObtenerDocNum(Recordset recordset)
        {
            string StrHANA = string.Empty;
            StrHANA = string.Format("SELECT * " +
                                    "FROM \"@VIS_OWOR_ENV_C\" where \"U_VIS_OT_ENVASADO\" = '{0}' ", oForm.GetString("18"));

            recordset.DoQuery(StrHANA);
            Correlativo = Convert.ToInt32(recordset.Fields.Item("DocNum").Value.ToString());
            U_VIS_ENV_P1 = recordset.Fields.Item("U_VIS_ENV_P1").Value.ToString();
            U_VIS_ETI_P1 = recordset.Fields.Item("U_VIS_ETI_P1").Value.ToString();
            U_VIS_ENC1_P1 = recordset.Fields.Item("U_VIS_ENC1_P1").Value.ToString();
            U_VIS_ENC2_P1 = recordset.Fields.Item("U_VIS_ENC2_P1").Value.ToString();
            U_VIS_OP1_P1 = recordset.Fields.Item("U_VIS_OP1_P1").Value.ToString();
            U_VIS_OP2_P1 = recordset.Fields.Item("U_VIS_OP2_P1").Value.ToString();
            U_VIS_MAR1_P1 = recordset.Fields.Item("U_VIS_MAR1_P1").Value.ToString();
            U_VIS_MAR2_P1 = recordset.Fields.Item("U_VIS_MAR2_P1").Value.ToString();
            U_VIS_FECHA_P1 = recordset.Fields.Item("U_VIS_FECHA_P1").Value.ToString();
            U_VIS_HORA_INI_P1 = recordset.Fields.Item("U_VIS_HORA_INI_P1").Value.ToString();
            U_VIS_HORA_FIN_P1 = recordset.Fields.Item("U_VIS_HORA_FIN_P1").Value.ToString();
            U_VIS_PRES_P1 = recordset.Fields.Item("U_VIS_PRES_P1").Value.ToString();
           U_VIS_CANTIDAD_P1 = recordset.Fields.Item("U_VIS_CANTIDAD_P1").Value.ToString();
            U_VIS_COD_REG_BAL_P1 = recordset.Fields.Item("U_VIS_COD_REG_BAL_P1").Value.ToString();

            U_VIS_ENV_P2 = recordset.Fields.Item("U_VIS_ENV_P2").Value.ToString();
            U_VIS_ETI_P2 = recordset.Fields.Item("U_VIS_ETI_P2").Value.ToString();
            U_VIS_ENC1_P2 = recordset.Fields.Item("U_VIS_ENC1_P2").Value.ToString();
            U_VIS_ENC2_P2 = recordset.Fields.Item("U_VIS_ENC2_P2").Value.ToString();
            U_VIS_OP1_P2 = recordset.Fields.Item("U_VIS_OP1_P2").Value.ToString();
            U_VIS_OP2_P2 = recordset.Fields.Item("U_VIS_OP2_P2").Value.ToString();
            U_VIS_MAR1_P2 = recordset.Fields.Item("U_VIS_MAR1_P2").Value.ToString();
            U_VIS_MAR2_P2 = recordset.Fields.Item("U_VIS_MAR2_P2").Value.ToString();
            U_VIS_FECHA_P2 = recordset.Fields.Item("U_VIS_FECHA_P2").Value.ToString();
            U_VIS_HORA_INI_P2 = recordset.Fields.Item("U_VIS_HORA_INI_P2").Value.ToString();
            U_VIS_HORA_FIN_P2 = recordset.Fields.Item("U_VIS_HORA_FIN_P2").Value.ToString();
            U_VIS_PRES_P2 = recordset.Fields.Item("U_VIS_PRES_P2").Value.ToString();
            U_VIS_CANTIDAD_P2 = recordset.Fields.Item("U_VIS_CANTIDAD_P2").Value.ToString();
            U_VIS_COD_REG_BAL_P2 = recordset.Fields.Item("U_VIS_COD_REG_BAL_P2").Value.ToString();

            U_VIS_ENV_P3 = recordset.Fields.Item("U_VIS_ENV_P3").Value.ToString();
            U_VIS_ETI_P3 = recordset.Fields.Item("U_VIS_ETI_P3").Value.ToString();
            U_VIS_ENC1_P3 = recordset.Fields.Item("U_VIS_ENC1_P3").Value.ToString();
            U_VIS_ENC2_P3 = recordset.Fields.Item("U_VIS_ENC2_P3").Value.ToString();
            U_VIS_OP1_P3 = recordset.Fields.Item("U_VIS_OP1_P3").Value.ToString();
            U_VIS_OP2_P3 = recordset.Fields.Item("U_VIS_OP2_P3").Value.ToString();
            U_VIS_MAR1_P3 = recordset.Fields.Item("U_VIS_MAR1_P3").Value.ToString();
            U_VIS_MAR2_P3 = recordset.Fields.Item("U_VIS_MAR2_P3").Value.ToString();
            U_VIS_FECHA_P3 = recordset.Fields.Item("U_VIS_FECHA_P3").Value.ToString();
            U_VIS_HORA_INI_P3 = recordset.Fields.Item("U_VIS_HORA_INI_P3").Value.ToString();
            U_VIS_HORA_FIN_P3 = recordset.Fields.Item("U_VIS_HORA_FIN_P3").Value.ToString();
            U_VIS_PRES_P3 = recordset.Fields.Item("U_VIS_PRES_P3").Value.ToString();
            U_VIS_CANTIDAD_P3 = recordset.Fields.Item("U_VIS_CANTIDAD_P3").Value.ToString();
            U_VIS_COD_REG_BAL_P3 = recordset.Fields.Item("U_VIS_COD_REG_BAL_P3").Value.ToString();

            U_VIS_PRE_LIMP1 = recordset.Fields.Item("U_VIS_PRE_LIMP1").Value.ToString();
            U_VIS_PRE_LIMP2 = recordset.Fields.Item("U_VIS_PRE_LIMP2").Value.ToString();
            U_VIS_PRE_LIMP3 = recordset.Fields.Item("U_VIS_PRE_LIMP3").Value.ToString();
        }
        public Orden_Fabricacion()
        {
        }
        public static void formEvent(ref SAPbouiCOM.BusinessObjectInfo BusinessObjectInfo, out bool BubbleEvent)
        {
            BubbleEvent = true;
            SAPbouiCOM.Form oForm = null;
            string DocNum = string.Empty;
            string DocNumOF = string.Empty;
            string Muestra_1 = string.Empty;
            string Muestra_2 = string.Empty;
            string Muestra_3 = string.Empty;
            string Aprobacion = string.Empty;
            string TipoOF = string.Empty;
            string NumEnv = string.Empty;
            string Descripcion = string.Empty;
            oForm = SAPbouiCOM.Framework.Application.SBO_Application.Forms.Item(BusinessObjectInfo.FormUID);
            DocNum = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("DocEntry", 0);
            DocNumOF = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("DocNum", 0);
            TipoOF = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_TypeListMtl", 0);
            NumEnv = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_SYP_OP_ENV", 0);
            Descripcion = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("ProdName", 0);
            if (BusinessObjectInfo.ActionSuccess && !BusinessObjectInfo.BeforeAction)
            {

            }
           else if (BusinessObjectInfo.EventType == SAPbouiCOM.BoEventTypes.et_FORM_DATA_UPDATE)
            {
                string GetDepa = string.Format("SELECT \"Department\" FROM \"OUSR\" WHERE \"USER_CODE\" = '{0}'", 
                    usuarioLogin);
                Recordset recordsetDep = (Recordset)Sb1Globals.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                recordsetDep.DoQuery(GetDepa);

                //19
                if (recordsetDep.Fields.Item("Department").Value.ToString()== "19")
                {
                    if (TipoOF == "EN" || TipoOF == "MZ")
                    {
                        Muestra_1 = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Sample1", 0);

                        string StrHANA = string.Empty;
                        StrHANA = string.Format("CALL P_VIS_OBTENERDATOS_USER('{0}')", usuarioLogin);
                        string NombreUserLogin;
                        Recordset recordset2 = (Recordset)Sb1Globals.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                        recordset2.DoQuery(StrHANA);
                        NombreUserLogin = Convert.ToString(recordset2.Fields.Item("U_NAME").Value.ToString());

                        string U_VIS_Sample1 = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Sample1", 0);
                        string U_VIS_Fecha_Entrega_M1 = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Fecha_Entrega_M1", 0);
                        string U_VIS_Hora_Entrega_M1 = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Hora_Entrega_M1", 0);
                        string U_VIS_Fecha_Aproba_Lab = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Fecha_Aproba_Lab", 0);
                        string U_VIS_Hora_Aproba_Lab = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Hora_Aproba_Lab", 0);
                        double U_VIS_Density =  Convert.ToDouble(oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Density", 0));

                        string Texto = "";
                        string Aprobacion_1 = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Sample1", 0);
                        string Aprobacion_2 = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Sample2", 0);
                        string Aprobacion_3 = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Approved", 0);
                        string Mensaje_1 = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Mensaje1", 0);
                        string Mensaje_2 = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Mensaje2", 0);
                        string Mensaje_3 = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Mensaje3", 0);
                        string Query1 = string.Empty;

                        string Fecha_Ent_M1 = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Fecha_Entrega_M1", 0);
                        string Hora_Ent_M1 = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Hora_Entrega_M1", 0);

                        string Hora_Apro_M1 = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Hora_Aproba_Lab", 0);
                        string Fecha_Apro_M1 = oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Fecha_Aproba_Lab", 0);
                        double Densidad = Convert.ToDouble(oForm.DataSources.DBDataSources.Item("OWOR").GetValue("U_VIS_Density", 0));


                        if (TipoOF == "EN")
                        {
                            Query1 = string.Format("CALL P_VIS_ADD_ENV_GET_OF('{0}','{1}')", TipoOF, NumEnv);
                        }

                        if (TipoOF == "MZ")
                        {
                            Query1 = string.Format("CALL P_VIS_ADD_ENV_GET_OF('{0}','{1}')", TipoOF, DocNumOF );
                        }
                        SAPbouiCOM.DataTable oDT = oForm.GetDataTable("DT_5");
                        oDT.ExecuteQuery(Query1);
                        for (int row = 0; row < oDT.Rows.Count; row++)
                        {
                            if (oDT.Rows.Count==1)
                            {
                                StrHANA = string.Format("CALL P_VIS_OBTENERDATOS_USER('{0}')", usuarioLogin);

                                /*ALTERTA*/
                                 BLL.Alert_BLL.AlertasADD(oForm, DocNum, "202", "Actualizacion de Envasado", "Producción", "DT_0", "USER_CODE", "Orden de Fabricación", "Orden de Fabricacion", Texto, DocNumOF);

                                if (Aprobacion_1 == "S")
                                {
                                    Texto += "➤ La muestra Nº 1 fue Aprobada " + "..";
                                }
                                else if (Aprobacion_1 == "N")
                                {
                                    Texto += "➤ La muestra Nº 1 fue Rechazado .. Mensaje : " + Mensaje_1 + "....";
                                }
                                else
                                {
                                    Texto += "➤ La muestra Nº 1 sin Actualizar ..";
                                }

                                if (Aprobacion_2 == "S")
                                {
                                    Texto += "➤ La muestra Nº 2 fue Aprobada" + "..";
                                }
                                else if (Aprobacion_2 == "N")
                                {
                                    Texto += "➤ La muestra Nº 2 fue Rechazado .. Mensaje : " + Mensaje_2 + "....";
                                }
                                else
                                {
                                    Texto += "➤ La muestra Nº 2 sin Actualizar ..";
                                }

                                if (Aprobacion_3 == "S")
                                {
                                    Texto += "➤ La muestra Nº 3 fue Aprobada" + "..";
                                }
                                else if (Aprobacion_3 == "N")
                                {
                                    Texto += "➤ La muestra Nº 3 fue Rechazado .. Mensaje : " + Mensaje_3 + "....";
                                }
                                else
                                {
                                    Texto += "➤ La muestra Nº 3 sin Actualizar ..";
                                }

                                string titulo = "";

                                if (Aprobacion_1 == "S" && Aprobacion_2 == "S" && Aprobacion_3 == "S")
                                {
                                    titulo = "Aprobado";
                                }
                                else if (Aprobacion_1 == "N" && Aprobacion_2 == "N" && Aprobacion_3 == "N")
                                {
                                    titulo = "Rechazado";
                                }
                                else if(Aprobacion_1 == "N" || Aprobacion_2 == "N" || Aprobacion_3 == "N")
                                {
                                    titulo = "Observado";
                                }
                                else if(Aprobacion_1 == "S" || Aprobacion_2 == "S" || Aprobacion_3 == "S")
                                {
                                    titulo = "Liberado";
                                }

                                string NombreProd = oDT.GetString("ProdName", row);
                                string ItemCodeProd = oDT.GetString("ItemCode", row);

                                Recordset recordset3 = null;
                                string QueryPesoOptimo = string.Format("CALL P_VIS_ADD_ENV_GET_PESO_OPTIMO('{0}','{1}')", ItemCodeProd, U_VIS_Density);
                                recordset3 = (Recordset)Sb1Globals.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                                recordset3.DoQuery(QueryPesoOptimo);
                                string PesoOptimo = Convert.ToString(recordset3.Fields.Item("Peso Optimo").Value.ToString());

                                Recordset recordset4 = null;
                                string QueryPesoMaximo = string.Format("CALL P_VIS_ADD_ENV_GET_PESO_MAXIMO('{0}','{1}')", ItemCodeProd, PesoOptimo);
                                recordset4 = (Recordset)Sb1Globals.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                                recordset4.DoQuery(QueryPesoMaximo);
                                string PesoMaximo = Convert.ToString(recordset4.Fields.Item("Peso Maximo").Value.ToString());



                                OWOR_UPDATE_STATUS obj = MENSAJE_BLL.OWOR_UPDATE_STATUS(Convert.ToInt32(oDT.GetString("DocEntry", row)),
                                      U_VIS_Sample1, U_VIS_Fecha_Entrega_M1, U_VIS_Hora_Entrega_M1, U_VIS_Fecha_Aproba_Lab,
                                      U_VIS_Hora_Aproba_Lab, U_VIS_Density, Convert.ToDouble(PesoOptimo), Convert.ToDouble(PesoMaximo)
                                   );
                                string jsonData = JsonConvert.SerializeObject(obj);

                                Forxap.Framework.ServiceLayer.Methods methods = new Forxap.Framework.ServiceLayer.Methods();
                                dynamic restResponse;
                                restResponse = methods.PATCH("ProductionOrders", Convert.ToInt32(oDT.GetString("DocEntry", row)), jsonData);
                                dynamic json2 = JsonConvert.DeserializeObject(restResponse.Content.ToString());

                                    /*CORREO*/
                                    CorreoOutlook_BLL.EnviarCorreoOffice365(oForm, recordset2, DocNum,
                                               "Producción", "DT_1", "DT_2", "DT_3", "",
                                               titulo+" OF. Nº " + DocNumOF+" "+ Descripcion, "", NombreUserLogin, Texto, DocNumOF + " - " + Descripcion);
                                    /*SMS*/
                                   DAL.SMS.EnviarSMS();
                                }
                                else if (oDT.Rows.Count > 1)
                            {
                                string DocEntryOF = string.Empty;
                                string DocNumOF1 = string.Empty;

                                DocEntryOF = oDT.GetString("DocEntry",row);
                                DocNumOF1 = oDT.GetString("DocNum",row);
                                string NombreProd = oDT.GetString("ProdName", row);
                                string ItemCodeProd = oDT.GetString("ItemCode", row);
                                StrHANA = string.Format("CALL P_VIS_OBTENERDATOS_USER('{0}')", usuarioLogin);

                                 Aprobacion_1 = oDT.GetString("U_VIS_Sample1", row);
                                 Aprobacion_2 = oDT.GetString("U_VIS_Sample2", row);
                                 Aprobacion_3 = oDT.GetString("U_VIS_Approved", row);
                                 Mensaje_1 = oDT.GetString("U_VIS_Mensaje1", row);
                                 Mensaje_2 = oDT.GetString("U_VIS_Mensaje2", row);
                                 Mensaje_3 =oDT.GetString("U_VIS_Mensaje3", row);
                                /*ALTERTA*/
                                BLL.Alert_BLL.AlertasADD(oForm, DocEntryOF, "202", "Actualizacion de Envasado", "Producción", "DT_0", "USER_CODE", "Orden de Fabricación", "Orden de Fabricacion", Texto, DocNumOF1);
                                if (Aprobacion_1 == "S")
                                {
                                    Texto += "➤ La muestra Nº 1 fue Aprobada " + "..";
                                }
                                else if (Aprobacion_1 == "N")
                                {
                                    Texto += "➤ La muestra Nº 1 fue Rechazado .. Mensaje : " + Mensaje_1 + "....";
                                }
                                else
                                {
                                    Texto += "➤ La muestra Nº 1 sin Actualizar ..";
                                }

                                if (Aprobacion_2 == "S")
                                {
                                    Texto += "➤ La muestra Nº 2 fue Aprobada" + "..";
                                }
                                else if (Aprobacion_2 == "N")
                                {
                                    Texto += "➤ La muestra Nº 2 fue Rechazado .. Mensaje : " + Mensaje_2 + "....";
                                }
                                else
                                {
                                    Texto += "➤ La muestra Nº 2 sin Actualizar ..";
                                }

                                if (Aprobacion_3 == "S")
                                {
                                    Texto += "➤ La muestra Nº 3 fue Aprobada" + "..";
                                }
                                else if (Aprobacion_3 == "N")
                                {
                                    Texto += "➤ La muestra Nº 3 fue Rechazado .. Mensaje : " + Mensaje_3 + "....";
                                }
                                else
                                {
                                    Texto += "➤ La muestra Nº 3 sin Actualizar ..";
                                }

                                string titulo = "";

                                if (Aprobacion_1 == "S" && Aprobacion_2 == "S" && Aprobacion_3 == "S")
                                {
                                    titulo = "Aprobado";
                                }
                                else if (Aprobacion_1 == "N" && Aprobacion_2 == "N" && Aprobacion_3 == "N")
                                {
                                    titulo = "Rechazado";
                                }
                                else if (Aprobacion_1 == "N" || Aprobacion_2 == "N" || Aprobacion_3 == "N")
                                {
                                    titulo = "Observado";
                                }
                                else if (Aprobacion_1 == "S" || Aprobacion_2 == "S" || Aprobacion_3 == "S")
                                {
                                    titulo = "Liberado";
                                }
                                Recordset recordset3 = null;
                                string QueryPesoOptimo =  string.Format("CALL P_VIS_ADD_ENV_GET_PESO_OPTIMO('{0}','{1}')", ItemCodeProd, U_VIS_Density);
                                recordset3 = (Recordset)Sb1Globals.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                                recordset3.DoQuery(QueryPesoOptimo);
                                string PesoOptimo = Convert.ToString(recordset3.Fields.Item("Peso Optimo").Value.ToString());

                                Recordset recordset4 = null;
                                string QueryPesoMaximo = string.Format("CALL P_VIS_ADD_ENV_GET_PESO_MAXIMO('{0}','{1}')", ItemCodeProd, PesoOptimo);
                                recordset4 = (Recordset)Sb1Globals.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                                recordset4.DoQuery(QueryPesoMaximo);
                                string PesoMaximo = Convert.ToString(recordset4.Fields.Item("Peso Maximo").Value.ToString());
                               


                                OWOR_UPDATE_STATUS obj = MENSAJE_BLL.OWOR_UPDATE_STATUS(Convert.ToInt32(oDT.GetString("DocEntry", row)),
                                      U_VIS_Sample1,U_VIS_Fecha_Entrega_M1,U_VIS_Hora_Entrega_M1 , U_VIS_Fecha_Aproba_Lab ,
                                      U_VIS_Hora_Aproba_Lab ,U_VIS_Density,Convert.ToDouble(PesoOptimo),Convert.ToDouble(PesoMaximo)
                                   );
                                string jsonData = JsonConvert.SerializeObject(obj);

                                Forxap.Framework.ServiceLayer.Methods methods = new Forxap.Framework.ServiceLayer.Methods();
                                    dynamic restResponse;
                                    restResponse = methods.PATCH("ProductionOrders", Convert.ToInt32(oDT.GetString("DocEntry", row)), jsonData);
                                    dynamic json2 = JsonConvert.DeserializeObject(restResponse.Content.ToString());

                                    if (restResponse.StatusCode.ToString() == "" || restResponse.StatusCode.ToString() == "NoContent")
                                    {
                                    /*CORREO*/
                                    CorreoOutlook_BLL.EnviarCorreoOffice365_ENV(oForm, recordset2, DocNum,
                                                                       "Producción", "DT_1", "DT_2", "DT_3", "",
                                                                         titulo + " OF. Nº " + DocNumOF + " " + NombreProd, "", 
                                                                         NombreUserLogin, Texto, DocNumOF + " - " + NombreProd);
                                    /*SMS*/
                                      DAL.SMS.EnviarSMS();
                                }

                                Texto = "";
                            }
                        }

                      


                    }
                }
            }

           }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_0").Specific));
            this.Button0.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button0_ClickAfter);
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
        }

        private void OnCustomInitialize()
        {
            oForm = SAPbouiCOM.Framework.Application.SBO_Application.Forms.Item(this.UIAPIRawForm.UniqueID);
            int PosicionbotonLeft = oForm.GetButton("2").Item.Left;
            int PosicionbotonTop = oForm.GetButton("2").Item.Top;
            int WidthButton = oForm.GetButton("2").Item.Width;
            int HeigthButton = oForm.GetButton("2").Item.Height;

            Button0.Item.Left = PosicionbotonLeft + 80;
            Button0.Item.Top = PosicionbotonTop;
            Button0.Item.Height = HeigthButton;
        }

        private void Button0_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            recordset = (Recordset)Sb1Globals.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            string DocNum = oForm.GetString("18").ToString();
            ObtenerOT_Trasvase(oForm.GetString("18").ToString(), recordset);
            ObtenerOP_Mezcla(OT_MEZCLA, recordset);
            ObtenerTanqueOT(oForm.GetString("18"), recordset);
            ObtenerVIS_OWOR_ENV(oForm.GetString("18"), recordset);
            if (Code_VIS_OWOR_ENV == "0")
            {
                if (TypoListMaterial == "MZ")
                {
                    if (AprobCalidadOP == "S")
                    {
                        RegistroControlEnvasado registrocontrolenvasado = new RegistroControlEnvasado(oForm.GetString("18"), OT_MEZCLA, DocEntryOP, FechaApro_Lab,
                                                                        AprobCalidadOP, "", HoraApro_Lab, DocEntryOT, TanqueOT, Correlativo, PesoOptimo,
                                                                        MaximoOptimo, HoraAprobadaMuestraFinal, HoraEntrMuestraFinal, Hora_Entrega_Linea, Hora_Aprobada_Linea);

                        registrocontrolenvasado.Show();
                    }
                    else
                    {
                        Sb1Messages.ShowWarning("No aprobado por Laboratorio");
                    }

                }
                else
                {
                    Sb1Messages.ShowWarning("La orden de fabricacion debe ser de tipo Envase");
                }

            }
            else
            {
                var MessageBoxAler = Sb1Messages.ShowMessageBox(AddonMessageInfo.Message005);


                if (MessageBoxAler == 1)
                {

                    ObtenerDocNum(recordset);

                    RegistroControlEnvasado registrocontrolenvasado =
                                        new RegistroControlEnvasado(oForm.GetString("18"), OT_MEZCLA, DocEntryOP, FechaApro_Lab,
                                                        AprobCalidadOP, "", HoraApro_Lab, DocEntryOT, TanqueOT, Correlativo, PesoOptimo,
                                                        MaximoOptimo, HoraAprobadaMuestraFinal, HoraEntrMuestraFinal, Hora_Entrega_Linea,
                                                        Hora_Aprobada_Linea, "", "",/* U_VIS_NOM_REP, U_VIS_UND_MED,*/ U_VIS_ENV_P1, U_VIS_ETI_P1, U_VIS_ENC1_P1,
                                                        U_VIS_ENC2_P1, U_VIS_OP1_P1, U_VIS_OP2_P1, U_VIS_MAR1_P1, U_VIS_MAR2_P1, U_VIS_FECHA_P1,
                                                        U_VIS_HORA_INI_P1, U_VIS_HORA_FIN_P1, U_VIS_PRES_P1, U_VIS_CANTIDAD_P1, U_VIS_COD_REG_BAL_P1,
                                                        U_VIS_PRE_LIMP1, U_VIS_PRE_LIMP2, U_VIS_PRE_LIMP3,
                                                        U_VIS_ENV_P2, U_VIS_ETI_P2, U_VIS_ENC1_P2,
                                                        U_VIS_ENC2_P2, U_VIS_OP1_P2, U_VIS_OP2_P2, U_VIS_MAR1_P2, U_VIS_MAR2_P2, U_VIS_FECHA_P2,
                                                        U_VIS_HORA_INI_P2, U_VIS_HORA_FIN_P2, U_VIS_PRES_P2, U_VIS_CANTIDAD_P2, U_VIS_COD_REG_BAL_P2,

                                                        U_VIS_ENV_P3, U_VIS_ETI_P3, U_VIS_ENC1_P3,
                                                        U_VIS_ENC2_P3, U_VIS_OP1_P3, U_VIS_OP2_P3, U_VIS_MAR1_P3, U_VIS_MAR2_P3, U_VIS_FECHA_P3,
                                                        U_VIS_HORA_INI_P3, U_VIS_HORA_FIN_P3, U_VIS_PRES_P3, U_VIS_CANTIDAD_P3, U_VIS_COD_REG_BAL_P3);

                    registrocontrolenvasado.Show();
                }

            }

        }


    }
}
