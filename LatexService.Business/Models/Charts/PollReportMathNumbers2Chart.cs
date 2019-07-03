using System;

namespace LatexService.Business.Models.Charts
{
    public class PollReportMathNumbers2Chart : Abstracts.LatexComponent
    {
        #region ==================== ATTRIBUTES ====================

        public string DataName
        {
            get
            {
                CheckCreateAttribute("$var_chart_data$");

                return (attributes["$var_chart_data$"]);
            }
            set
            {
                CheckCreateAttribute("$var_chart_data$");

                attributes["$var_chart_data$"] = string.Format("{0}Data", value.Replace(" ", "").Replace("-", ""));
            }
        }

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

                attributes["$var_chart_name$"] = value;
            }
        }

        public int True_Value
        {
            get
            {
                CheckCreateAttribute("$var_true_value$");

                return (Convert.ToInt32(attributes["$var_true_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_true_value$");

                attributes["$var_true_value$"] = value.ToString();
            }
        }

        public int False_Value
        {
            get
            {
                CheckCreateAttribute("$var_false_value$");

                return (Convert.ToInt32(attributes["$var_false_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_false_value$");

                attributes["$var_false_value$"] = value.ToString();
            }
        }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportMathNumbers2Chart()
            : base()
        { }

        public PollReportMathNumbers2Chart(string filePath)
            : base(filePath)
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}