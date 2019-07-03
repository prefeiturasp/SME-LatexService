using System;

namespace LatexService.Business.Models.Charts
{
    public class PollReportPortugueseReadingChart : Abstracts.LatexComponent
    {
        #region ==================== ATTRIBUTES ====================

        public int N1_Value
        {
            get
            {
                CheckCreateAttribute("$var_n1_value$");

                return (Convert.ToInt32(attributes["$var_n1_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_n1_value$");

                attributes["$var_n1_value$"] = value.ToString();
            }
        }

        public int N2_Value
        {
            get
            {
                CheckCreateAttribute("$var_n2_value$");

                return (Convert.ToInt32(attributes["$var_n2_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_n2_value$");

                attributes["$var_n2_value$"] = value.ToString();
            }
        }

        public int N3_Value
        {
            get
            {
                CheckCreateAttribute("$var_n3_value$");

                return (Convert.ToInt32(attributes["$var_n3_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_n3_value$");

                attributes["$var_n3_value$"] = value.ToString();
            }
        }

        public int N4_Value
        {
            get
            {
                CheckCreateAttribute("$var_n4_value$");

                return (Convert.ToInt32(attributes["$var_n4_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_n4_value$");

                attributes["$var_n4_value$"] = value.ToString();
            }
        }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportPortugueseReadingChart()
            : base()
        { }

        public PollReportPortugueseReadingChart(string filePath)
            : base(filePath)
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}