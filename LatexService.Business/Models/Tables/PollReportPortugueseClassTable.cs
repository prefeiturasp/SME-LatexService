using System.Collections.Generic;

namespace LatexService.Business.Models.Tables
{
    public class PollReportPortugueseClassTable : Abstracts.LatexComponent
    {
        #region ==================== ATTRIBUTES ====================

        public string ItemTemplatePath { get; set; }

        public List<PollReportPortugueseClassItem> Items { get; set; } = new List<PollReportPortugueseClassItem>();

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportPortugueseClassTable()
            : base()
        { }

        public PollReportPortugueseClassTable(string filePath)
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

    public class PollReportPortugueseClassItem : Abstracts.LatexComponent
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

                attributes["$var_y1$"] = ((index * 0.7) + 0.3).ToString();
                attributes["$var_y2$"] = ((index * 0.7) + 1).ToString();
                attributes["$var_y3$"] = ((index * 0.7) + 0.65).ToString();
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

        public string Value
        {
            get
            {
                CheckCreateAttribute("$var_value$");

                return (attributes["$var_value$"]);
            }
            set
            {
                CheckCreateAttribute("$var_value$");

                attributes["$var_value$"] = value;
            }
        }

        #endregion ==================== ATTRIBUTES ====================
    }
}