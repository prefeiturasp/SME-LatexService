using System;

namespace LatexService.Business.Models.Tables
{
    public class PollReportPortugueseWritingTable : Abstracts.LatexComponent
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

        public int Total_Value
        {
            get
            {
                CheckCreateAttribute("$var_total_value$");

                return (Convert.ToInt32(attributes["$var_total_value$"]));
            }
            set
            {
                CheckCreateAttribute("$var_total_value$");

                attributes["$var_total_value$"] = value.ToString();
            }
        }

        public decimal PS_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_ps_percentage$");

                return (Convert.ToDecimal(attributes["$var_ps_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_ps_percentage$");

                attributes["$var_ps_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal SSV_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_ssv_percentage$");

                return (Convert.ToDecimal(attributes["$var_ssv_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_ssv_percentage$");

                attributes["$var_ssv_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal SCV_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_scv_percentage$");

                return (Convert.ToDecimal(attributes["$var_scv_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_scv_percentage$");

                attributes["$var_scv_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal SA_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_sa_percentage$");

                return (Convert.ToDecimal(attributes["$var_sa_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_sa_percentage$");

                attributes["$var_sa_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal A_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_a_percentage$");

                return (Convert.ToDecimal(attributes["$var_a_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_a_percentage$");

                attributes["$var_a_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal Total_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_total_percentage$");

                return (Convert.ToDecimal(attributes["$var_total_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_total_percentage$");

                attributes["$var_total_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportPortugueseWritingTable()
            : base()
        { }

        public PollReportPortugueseWritingTable(string filePath)
            : base(filePath)
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}