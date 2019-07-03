using System;

namespace LatexService.Business.Models.Tables
{
    public class PollReportMathTable : Abstracts.LatexComponent
    {
        #region ==================== ATTRIBUTES ====================

        public string TableName
        {
            get
            {
                CheckCreateAttribute("$var_table_name$");

                return (attributes["$var_table_name$"]);
            }
            set
            {
                CheckCreateAttribute("$var_table_name$");

                attributes["$var_table_name$"] = value;
            }
        }

        public int Ideia_Acertou_Value
        {
            get
            {
                CheckCreateAttribute("$var_ideia_acertou_value$");

                return (Convert.ToInt32(attributes["$var_ideia_acertou_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_ideia_acertou_value$");

                attributes["$var_ideia_acertou_value$"] = value.ToString();
            }
        }

        public int Ideia_Errou_Value
        {
            get
            {
                CheckCreateAttribute("$var_ideia_errou_value$");

                return (Convert.ToInt32(attributes["$var_ideia_errou_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_ideia_errou_value$");

                attributes["$var_ideia_errou_value$"] = value.ToString();
            }
        }

        public int Ideia_NaoResolveu_Value
        {
            get
            {
                CheckCreateAttribute("$var_ideia_naoresolveu_value$");

                return (Convert.ToInt32(attributes["$var_ideia_naoresolveu_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_ideia_naoresolveu_value$");

                attributes["$var_ideia_naoresolveu_value$"] = value.ToString();
            }
        }

        public int Ideia_Total_Value
        {
            get
            {
                CheckCreateAttribute("$var_ideia_total_value$");

                return (Convert.ToInt32(attributes["$var_ideia_total_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_ideia_total_value$");

                attributes["$var_ideia_total_value$"] = value.ToString();
            }
        }

        public int Resultado_Acertou_Value
        {
            get
            {
                CheckCreateAttribute("$var_resultado_acertou_value$");

                return (Convert.ToInt32(attributes["$var_resultado_acertou_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_resultado_acertou_value$");

                attributes["$var_resultado_acertou_value$"] = value.ToString();
            }
        }

        public int Resultado_Errou_Value
        {
            get
            {
                CheckCreateAttribute("$var_resultado_errou_value$");

                return (Convert.ToInt32(attributes["$var_resultado_errou_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_resultado_errou_value$");

                attributes["$var_resultado_errou_value$"] = value.ToString();
            }
        }

        public int Resultado_NaoResolveu_Value
        {
            get
            {
                CheckCreateAttribute("$var_resultado_naoresolveu_value$");

                return (Convert.ToInt32(attributes["$var_resultado_naoresolveu_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_resultado_naoresolveu_value$");

                attributes["$var_resultado_naoresolveu_value$"] = value.ToString();
            }
        }

        public int Resultado_Total_Value
        {
            get
            {
                CheckCreateAttribute("$var_resultado_total_value$");

                return (Convert.ToInt32(attributes["$var_resultado_total_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_resultado_total_value$");

                attributes["$var_resultado_total_value$"] = value.ToString();
            }
        }

        public decimal Ideia_Acertou_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_ideia_acertou_percentage$");

                return (Convert.ToDecimal(attributes["$var_ideia_acertou_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_ideia_acertou_percentage$");

                attributes["$var_ideia_acertou_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal Ideia_Errou_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_ideia_errou_percentage$");

                return (Convert.ToDecimal(attributes["$var_ideia_errou_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_ideia_errou_percentage$");

                attributes["$var_ideia_errou_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal Ideia_NaoResolveu_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_ideia_naoresolveu_percentage$");

                return (Convert.ToDecimal(attributes["$var_ideia_naoresolveu_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_ideia_naoresolveu_percentage$");

                attributes["$var_ideia_naoresolveu_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal Ideia_Total_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_ideia_total_percentage$");

                return (Convert.ToDecimal(attributes["$var_ideia_total_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_ideia_total_percentage$");

                attributes["$var_ideia_total_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal Resultado_Acertou_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_resultado_acertou_percentage$");

                return (Convert.ToDecimal(attributes["$var_resultado_acertou_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_resultado_acertou_percentage$");

                attributes["$var_resultado_acertou_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal Resultado_Errou_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_resultado_errou_percentage$");

                return (Convert.ToDecimal(attributes["$var_resultado_errou_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_resultado_errou_percentage$");

                attributes["$var_resultado_errou_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal Resultado_NaoResolveu_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_resultado_naoresolveu_percentage$");

                return (Convert.ToDecimal(attributes["$var_resultado_naoresolveu_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_resultado_naoresolveu_percentage$");

                attributes["$var_resultado_naoresolveu_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal Resultado_Total_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_resultado_total_percentage$");

                return (Convert.ToDecimal(attributes["$var_resultado_total_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_resultado_total_percentage$");

                attributes["$var_resultado_total_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportMathTable()
            : base()
        { }

        public PollReportMathTable(string filePath)
            : base(filePath)
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}