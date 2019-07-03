using System.Collections.Generic;

namespace LatexService.Business.Models.Recipes
{
    public class PollReportMathNumbersClass : Abstracts.Recipe
    {
        #region ==================== ATTRIBUTES ====================

        public Models.HeadersFooters.PollReport HeaderFooter { get; set; }
        public Models.Tables.PollReportMathNumbersClassTable Table { get; set; }
        public List<Models.Charts.PollReportMathNumbersChart> Charts { get; set; }
        public Models.Charts.PollReportMathNumbers2Chart Chart2 { get; set; }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportMathNumbersClass()
        {
            Name = "pollReportMathNumbersClass";
        }

        #endregion ==================== CONSTRUCTORS ====================

        #region ==================== METHODS ====================

        public override void CreateLatex()
        {
            HeaderFooter.LoadFromFile(string.Format("{0}{1}", TemplatePath, "header-footer/poll-report.tex"));
            CheckCreateAttribute("headerFooter", HeaderFooter.ToString());

            Table.ItemTemplatePath = string.Format("{0}{1}", TemplatePath, "tables/class/poll-report-math-numbers-item.tex");
            Table.LoadFromFile(string.Format("{0}{1}", TemplatePath, "tables/class/poll-report-math-numbers.tex"));
            CheckCreateAttribute("table", Table.ToString());

            for (int i = 0; i < Charts.Count; i++)
            {
                Charts[i].LoadFromFile(string.Format("{0}{1}", TemplatePath, "charts/poll-report-math-numbers.tex"));
                CheckCreateAttribute(string.Format("chart{0}", i), Charts[i].ToString());
            }

            Chart2.LoadFromFile(string.Format("{0}{1}", TemplatePath, "charts/poll-report-math-numbers2.tex"));
            CheckCreateAttribute("chart6", Chart2.ToString());

            base.CreateLatex();
        }

        #endregion ==================== METHODS ====================
    }
}