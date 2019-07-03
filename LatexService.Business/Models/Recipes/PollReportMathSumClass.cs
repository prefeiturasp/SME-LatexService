using System.Collections.Generic;

namespace LatexService.Business.Models.Recipes
{
    public class PollReportMathSumClass : Abstracts.Recipe
    {
        #region ==================== ATTRIBUTES ====================

        public Models.HeadersFooters.PollReport HeaderFooter { get; set; }
        public Models.Tables.PollReportMathSumClassTable Table { get; set; }
        public List<Models.Charts.PollReportMathChart> Charts { get; set; }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportMathSumClass()
        {
            Name = "pollReportMathSumClass";
        }

        #endregion ==================== CONSTRUCTORS ====================

        #region ==================== METHODS ====================

        public override void CreateLatex()
        {
            HeaderFooter.LoadFromFile(string.Format("{0}{1}", TemplatePath, "header-footer/poll-report.tex"));
            CheckCreateAttribute("headerFooter", HeaderFooter.ToString());

            Table.ItemTemplatePath = string.Format("{0}{1}", TemplatePath, "tables/class/poll-report-math-sum-item.tex");
            Table.LoadFromFile(string.Format("{0}{1}", TemplatePath, "tables/class/poll-report-math-sum.tex"));
            CheckCreateAttribute("table", Table.ToString());

            for (int i = 0; i < Charts.Count; i++)
            {
                Charts[i].LoadFromFile(string.Format("{0}{1}", TemplatePath, "charts/poll-report-math.tex"));
                CheckCreateAttribute(string.Format("chart{0}", i), Charts[i].ToString());
            }

            base.CreateLatex();
        }

        #endregion ==================== METHODS ====================
    }
}