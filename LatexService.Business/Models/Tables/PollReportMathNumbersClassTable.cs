using System.Collections.Generic;

namespace LatexService.Business.Models.Tables
{
    public class PollReportMathNumbersClassTable : Abstracts.LatexComponent
    {
        #region ==================== ATTRIBUTES ====================

        public string ItemTemplatePath { get; set; }

        public List<PollReportMathNumbersClassItem> Items { get; set; } = new List<PollReportMathNumbersClassItem>();

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportMathNumbersClassTable()
            : base()
        { }

        public PollReportMathNumbersClassTable(string filePath)
            : base(filePath)
        { }

        #endregion ==================== CONSTRUCTORS ====================

        #region ==================== METHODS ====================

        public override void Compile()
        {
            string items = "";

            for (int i = 0; i < Items.Count; i++)
            {
                Items[i].Index = i;
                Items[i].LoadFromFile(ItemTemplatePath);
                items += string.Format("{0}\n", Items[i].ToString());
            }

            CheckCreateAttribute("$var_items$");

            attributes["$var_items$"] = items;

            base.Compile();
        }

        #endregion ==================== METHODS ====================
    }

    public class PollReportMathNumbersClassItem : Abstracts.LatexComponent
    {
        #region ==================== ATTRIBUTES ====================

        private int index;

        public int Index
        {
            get
            {
                return (index);
            }
            set
            {
                index = value;

                CheckCreateAttribute("$var_y1$");
                CheckCreateAttribute("$var_y2$");
                CheckCreateAttribute("$var_y3$");

                attributes["$var_y1$"] = ((index * 1.25) + 0.3).ToString();
                attributes["$var_y2$"] = ((index * 1.25) + 1.55).ToString();
                attributes["$var_y3$"] = ((index * 1.25) + 0.9).ToString();
            }
        }

        public string EolCode
        {
            get
            {
                CheckCreateAttribute("$var_cod_eol$");

                return (attributes["$var_cod_eol$"]);
            }
            set
            {
                CheckCreateAttribute("$var_cod_eol$");

                attributes["$var_cod_eol$"] = value;
            }
        }

        public string Name
        {
            get
            {
                CheckCreateAttribute("$var_name$");

                return (attributes["$var_name$"]);
            }
            set
            {
                CheckCreateAttribute("$var_name$");

                attributes["$var_name$"] = value;
            }
        }

        public string Test1_Value
        {
            get
            {
                CheckCreateAttribute("$var_test1_value$");

                return (attributes["$var_test1_value$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test1_value$");

                attributes["$var_test1_value$"] = value;
            }
        }

        public string Test2_Value
        {
            get
            {
                CheckCreateAttribute("$var_test2_value$");

                return (attributes["$var_test2_value$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test2_value$");

                attributes["$var_test2_value$"] = value;
            }
        }

        public string Test3_Value
        {
            get
            {
                CheckCreateAttribute("$var_test3_value$");

                return (attributes["$var_test3_value$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test3_value$");

                attributes["$var_test3_value$"] = value;
            }
        }

        public string Test4_Value
        {
            get
            {
                CheckCreateAttribute("$var_test4_value$");

                return (attributes["$var_test4_value$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test4_value$");

                attributes["$var_test4_value$"] = value;
            }
        }

        public string Test5_Value
        {
            get
            {
                CheckCreateAttribute("$var_test5_value$");

                return (attributes["$var_test5_value$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test5_value$");

                attributes["$var_test5_value$"] = value;
            }
        }

        public string Test6_Value
        {
            get
            {
                CheckCreateAttribute("$var_test6_value$");

                return (attributes["$var_test6_value$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test6_value$");

                attributes["$var_test6_value$"] = value;
            }
        }

        public string Test7_Value
        {
            get
            {
                CheckCreateAttribute("$var_test7_value$");

                return (attributes["$var_test7_value$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test7_value$");

                attributes["$var_test7_value$"] = value;
            }
        }

        #endregion ==================== ATTRIBUTES ====================
    }
}