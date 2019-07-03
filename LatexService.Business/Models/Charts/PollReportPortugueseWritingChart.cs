using System;

namespace LatexService.Business.Models.Charts
{
    public class PollReportPortugueseWritingChart : Abstracts.LatexComponent
    {
        #region ==================== ATTRIBUTES ====================

        public int PS_Value
        {
            get
            {
                CheckCreateAttribute("$var_ps_value$");

                return (Convert.ToInt32(attributes["$var_ps_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_ps_value$");

                attributes["$var_ps_value$"] = value.ToString();
            }
        }

        public int SSV_Value
        {
            get
            {
                CheckCreateAttribute("$var_ssv_value$");

                return (Convert.ToInt32(attributes["$var_ssv_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_ssv_value$");

                attributes["$var_ssv_value$"] = value.ToString();
            }
        }

        public int SCV_Value
        {
            get
            {
                CheckCreateAttribute("$var_scv_value$");

                return (Convert.ToInt32(attributes["$var_scv_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_scv_value$");

                attributes["$var_scv_value$"] = value.ToString();
            }
        }

        public int SA_Value
        {
            get
            {
                CheckCreateAttribute("$var_sa_value$");

                return (Convert.ToInt32(attributes["$var_sa_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_sa_value$");

                attributes["$var_sa_value$"] = value.ToString();
            }
        }

        public int A_Value
        {
            get
            {
                CheckCreateAttribute("$var_a_value$");

                return (Convert.ToInt32(attributes["$var_a_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_a_value$");

                attributes["$var_a_value$"] = value.ToString();
            }
        }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportPortugueseWritingChart()
            : base()
        { }

        public PollReportPortugueseWritingChart(string filePath)
            : base(filePath)
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}