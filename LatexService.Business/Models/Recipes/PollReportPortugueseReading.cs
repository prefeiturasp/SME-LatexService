namespace LatexService.Business.Models.Recipes
{
    public class PollReportPortugueseReading : Abstracts.Recipe
    {
        #region ==================== ATTRIBUTES ====================

        public Models.HeadersFooters.PollReport HeaderFooter { get; set; }
        public Models.Tables.PollReportPortugueseReadingTable Table { get; set; }
        public Models.Charts.PollReportPortugueseReadingChart Chart { get; set; }

        #endregion ==================== ATTRIBUTES ====================

        #region ==================== CONSTRUCTORS ====================

        public PollReportPortugueseReading()
        {
            Name = "pollReportPortugueseReading";
        }

        #endregion ==================== CONSTRUCTORS ====================

        #region ==================== METHODS ====================

        public override void CreateLatex()
        {
            HeaderFooter.LoadFromFile(string.Format("{0}{1}", TemplatePath, "header-footer/poll-report.tex"));
            Table.LoadFromFile(string.Format("{0}{1}", TemplatePath, "tables/poll-report-portuguese-reading.tex"));
            Chart.LoadFromFile(string.Format("{0}{1}", TemplatePath, "charts/poll-report-portuguese-reading.tex"));

            CheckCreateAttribute("headerFooter", HeaderFooter.ToString());
            CheckCreateAttribute("table", Table.ToString());
            CheckCreateAttribute("chart", Chart.ToString());

            base.CreateLatex();
        }

        #endregion ==================== METHODS ====================
    }
}