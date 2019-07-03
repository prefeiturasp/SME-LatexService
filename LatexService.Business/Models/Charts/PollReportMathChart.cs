using System;

namespace LatexService.Business.Models.Charts
{
    public class PollReportMathChart : Abstracts.LatexComponent
    {
        #region ==================== ATTRIBUTES ====================

        public string ChartName
        {
            get
            {
                CheckCreateAttribute("$var_chart_name$");

                return (attributes["$var_chart_name$"]);
            }
            set
            {
                CheckCreateAttribute("$var_chart_name$");
                CheckCreateAttribute("$var_chart_ideia_data$");
                CheckCreateAttribute("$var_chart_resultado_data$");

                attributes["$var_chart_name$"] = value;
                attributes["$var_chart_ideia_data$"] = string.Format("{0}Ideia", value.Replace(" ", "").Replace("-", ""));
                attributes["$var_chart_resultado_data$"] = string.Format("{0}Resultado", value.Replace(" ", "").Replace("-", ""));
            }
        }

        public string DataName
        {
            get
            {
                CheckCreateAttribute("$var_chart_ideia_data$");
                CheckCreateAttribute("$var_chart_resultado_data$");

                return (attributes["$var_chart_ideia_data$"].Replace("Ideia", ""));
            }
            set
            {
                CheckCreateAttribute("$var_chart_ideia_data$");
                CheckCreateAttribute("$var_chart_resultado_data$");

                attributes["$var_chart_ideia_data$"] = string.Format("{0}Ideia", value.Replace(" ", "").Replace("-", ""));
                attributes["$var_chart_resultado_data$"] = string.Format("{0}Resultado", value.Replace(" ", "").Replace("-", ""));
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

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportMathChart()
        : base()
        { }

        public PollReportMathChart(string filePath)
            : base(filePath)
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}