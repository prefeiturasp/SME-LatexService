using System.Collections.Generic;

namespace LatexService.Business.Models.Tables
{
    public class PollReportMathMultiplicationClassTable : Abstracts.LatexComponent
    {
        #region ==================== ATTRIBUTES ====================

        public string Test_Name
        {
            get
            {
                CheckCreateAttribute("$var_test_name$");

                return (attributes["$var_test_name$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test_name$");

                attributes["$var_test_name$"] = value;
            }
        }

        public string ItemTemplatePath { get; set; }

        public List<PollReportMathMultiplicationClassItem> Items { get; set; } = new List<PollReportMathMultiplicationClassItem>();

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportMathMultiplicationClassTable()
            : base()
        { }

        public PollReportMathMultiplicationClassTable(string filePath)
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

    public class PollReportMathMultiplicationClassItem : Abstracts.LatexComponent
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

        public string Test_Idea
        {
            get
            {
                CheckCreateAttribute("$var_test_idea$");

                return (attributes["$var_test_idea$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test_idea$");

                attributes["$var_test_idea$"] = value;
            }
        }

        public string Test_Result
        {
            get
            {
                CheckCreateAttribute("$var_test_result$");

                return (attributes["$var_test_result$"]);
            }
            set
            {
                CheckCreateAttribute("$var_test_result$");

                attributes["$var_test_result$"] = value;
            }
        }

        #endregion ==================== ATTRIBUTES ====================
    }
}