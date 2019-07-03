using System;

namespace LatexService.Business.Models.Tables
{
    public class PollReportMathNumbersTable : Abstracts.LatexComponent
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

        public decimal True_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_true_percentage$");

                return (Convert.ToDecimal(attributes["$var_true_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_true_percentage$");

                attributes["$var_true_percentage$"] = string.Format("{0:.##}", value);
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

        public decimal False_Percentage
        {
            get
            {
                CheckCreateAttribute("$var_false_percentage$");

                return (Convert.ToDecimal(attributes["$var_false_percentage$"]));
            }
            set
            {
                CheckCreateAttribute("$var_false_percentage$");

                attributes["$var_false_percentage$"] = string.Format("{0:.##}", value);
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

        public PollReportMathNumbersTable()
            : base()
        { }

        public PollReportMathNumbersTable(string filePath)
            : base(filePath)
        { }

        #endregion ==================== CONSTRUCTORS ====================
    }
}