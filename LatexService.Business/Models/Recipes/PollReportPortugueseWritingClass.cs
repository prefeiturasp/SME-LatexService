namespace LatexService.Business.Models.Recipes
{
    public class PollReportPortugueseWritingClass : Abstracts.Recipe
    {
        #region ==================== ATTRIBUTES ====================

        public Models.HeadersFooters.PollReport HeaderFooter { get; set; }
        public Models.Tables.PollReportPortugueseClassTable Table { get; set; }
        public Models.Charts.PollReportPortugueseWritingChart Chart { get; set; }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportPortugueseWritingClass()
        {
            Name = "pollReportPortugueseWritingClass";
        }

        #endregion ==================== CONSTRUCTORS ====================

        #region ==================== METHODS ====================

        public override void CreateLatex()
        {
            HeaderFooter.LoadFromFile(string.Format("{0}{1}", TemplatePath, "header-footer/poll-report.tex"));
            CheckCreateAttribute("headerFooter", HeaderFooter.ToString());

            Table.ItemTemplatePath = string.Format("{0}{1}", TemplatePath, "tables/class/poll-report-portuguese-item.tex");
            Table.LoadFromFile(string.Format("{0}{1}", TemplatePath, "tables/class/poll-report-portuguese.tex"));
            CheckCreateAttribute("table", Table.ToString());

            Chart.LoadFromFile(string.Format("{0}{1}", TemplatePath, "charts/poll-report-portuguese-writing.tex"));
            CheckCreateAttribute("chart", Chart.ToString());

            base.CreateLatex();
        }

        #endregion ==================== METHODS ====================
    }
}