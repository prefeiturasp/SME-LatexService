using System.Collections.Generic;

namespace LatexService.Business.Models.Tables
{
    public class PollReportMathSumClassTable : Abstracts.LatexComponent
    {
        #region ==================== ATTRIBUTES ====================

        public string Test1_Name
        {
            get
            {
                CheckCreateAttribute("$var_test1_name$");

                return (attributes["$var_test1_name$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test1_name$");

                attributes["$var_test1_name$"] = value;
            }
        }

        public string Test2_Name
        {
            get
            {
                CheckCreateAttribute("$var_test2_name$");

                return (attributes["$var_test2_name$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test2_name$");

                attributes["$var_test2_name$"] = value;
            }
        }

        public string Test3_Name
        {
            get
            {
                CheckCreateAttribute("$var_test3_name$");

                return (attributes["$var_test3_name$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test3_name$");

                attributes["$var_test3_name$"] = value;
            }
        }

        public string ItemTemplatePath { get; set; }

        public List<PollReportMathSumClassItem> Items { get; set; } = new List<PollReportMathSumClassItem>();

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportMathSumClassTable()
            : base()
        { }

        public PollReportMathSumClassTable(string filePath)
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

    public class PollReportMathSumClassItem : Abstracts.LatexComponent
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

                attributes["$var_y1$"] = ((index * 0.8) + 0.3).ToString();
                attributes["$var_y2$"] = ((index * 0.8) + 1.1).ToString();
                attributes["$var_y3$"] = ((index * 0.8) + 0.7).ToString();
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

        public string Test1_Idea
        {
            get
            {
                CheckCreateAttribute("$var_test1_idea$");

                return (attributes["$var_test1_idea$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test1_idea$");

                attributes["$var_test1_idea$"] = value;
            }
        }

        public string Test1_Result
        {
            get
            {
                CheckCreateAttribute("$var_test1_result$");

                return (attributes["$var_test1_result$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test1_result$");

                attributes["$var_test1_result$"] = value;
            }
        }

        public string Test2_Idea
        {
            get
            {
                CheckCreateAttribute("$var_test2_idea$");

                return (attributes["$var_test2_idea$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test2_idea$");

                attributes["$var_test2_idea$"] = value;
            }
        }

        public string Test2_Result
        {
            get
            {
                CheckCreateAttribute("$var_test2_result$");

                return (attributes["$var_test2_result$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test2_result$");

                attributes["$var_test2_result$"] = value;
            }
        }

        public string Test3_Idea
        {
            get
            {
                CheckCreateAttribute("$var_test3_idea$");

                return (attributes["$var_test3_idea$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test3_idea$");

                attributes["$var_test3_idea$"] = value;
            }
        }

        public string Test3_Result
        {
            get
            {
                CheckCreateAttribute("$var_test3_result$");

                return (attributes["$var_test3_result$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test3_result$");

                attributes["$var_test3_result$"] = value;
            }
        }

        #endregion ==================== ATTRIBUTES ====================
    }
}