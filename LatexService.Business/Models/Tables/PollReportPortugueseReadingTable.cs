using System;

namespace LatexService.Business.Models.Tables
{
    public class PollReportPortugueseReadingTable : Abstracts.LatexComponent
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

        public decimal N1_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_n1_percentage$");

                return (Convert.ToDecimal(attributes["$var_n1_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_n1_percentage$");

                attributes["$var_n1_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal N2_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_n2_percentage$");

                return (Convert.ToDecimal(attributes["$var_n2_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_n2_percentage$");

                attributes["$var_n2_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal N3_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_n3_percentage$");

                return (Convert.ToDecimal(attributes["$var_n3_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_n3_percentage$");

                attributes["$var_n3_percentage$"] = string.Format("{0:.##}", value);
            }
        }

        public decimal N4_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_n4_percentage$");

                return (Convert.ToDecimal(attributes["$var_n4_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_n4_percentage$");

                attributes["$var_n4_percentage$"] = string.Format("{0:.##}", value);
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

        public PollReportPortugueseReadingTable()
            : base()
        { }

        public PollReportPortugueseReadingTable(string filePath)
            : base(filePath)
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}