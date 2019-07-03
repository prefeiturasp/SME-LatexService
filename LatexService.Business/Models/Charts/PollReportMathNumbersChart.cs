using System;

namespace LatexService.Business.Models.Charts
{
    public class PollReportMathNumbersChart : Abstracts.LatexComponent
    {
        #region ==================== ATTRIBUTES ====================

        public string DataName
        {
            get
            {
                CheckCreateAttribute("$var_chart_left_data$");
                CheckCreateAttribute("$var_chart_right_data$");

                return (attributes["$var_chart_left_data$"].Replace("left", ""));
            }
            set
            {
                CheckCreateAttribute("$var_chart_left_data$");
                CheckCreateAttribute("$var_chart_right_data$");

                attributes["$var_chart_left_data$"] = string.Format("{0}Left", value.Replace(" ", "").Replace("-", ""));
                attributes["$var_chart_right_data$"] = string.Format("{0}Right", value.Replace(" ", "").Replace("-", ""));
            }
        }

        public string Chart1Name
        {
            get
            {
                CheckCreateAttribute("$var_chart1_name$");

                return (attributes["$var_chart1_name$"]);
            }
            set
            {
                CheckCreateAttribute("$var_chart1_name$");

                attributes["$var_chart1_name$"] = value;
            }
        }

        public int True1_Value
        {
            get
            {
                CheckCreateAttribute("$var_true1_value$");

                return (Convert.ToInt32(attributes["$var_true1_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_true1_value$");

                attributes["$var_true1_value$"] = value.ToString();
            }
        }

        public int False1_Value
        {
            get
            {
                CheckCreateAttribute("$var_false1_value$");

                return (Convert.ToInt32(attributes["$var_false1_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_false1_value$");

                attributes["$var_false1_value$"] = value.ToString();
            }
        }

        public string Chart2Name
        {
            get
            {
                CheckCreateAttribute("$var_chart2_name$");

                return (attributes["$var_chart2_name$"]);
            }
            set
            {
                CheckCreateAttribute("$var_chart2_name$");

                attributes["$var_chart2_name$"] = value;
            }
        }

        public int True2_Value
        {
            get
            {
                CheckCreateAttribute("$var_true2_value$");

                return (Convert.ToInt32(attributes["$var_true2_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_true2_value$");

                attributes["$var_true2_value$"] = value.ToString();
            }
        }

        public int False2_Value
        {
            get
            {
                CheckCreateAttribute("$var_false2_value$");

                return (Convert.ToInt32(attributes["$var_false2_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_false2_value$");

                attributes["$var_false2_value$"] = value.ToString();
            }
        }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportMathNumbersChart()
            : base()
        { }

        public PollReportMathNumbersChart(string filePath)
            : base(filePath)
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}