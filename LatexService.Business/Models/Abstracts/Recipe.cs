using System.Collections.Generic;
using System.IO;

namespace LatexService.Business.Models.Abstracts
{
    public abstract class Recipe
    {
        #region ==================== ATTRIBUTES ====================

        private const string TEMPLATE_PATH = @"/srv/www/latexService/latexTemplates/";
        private const string RESULT_PATH = @"/srv/www/latexService/result/";

        protected Dictionary<string, string> components = new Dictionary<string, string>();

        public string Name { get; protected set; }

        public string TemplatePath
        {
            get
            {
                return (TEMPLATE_PATH);
            }
        }

        public string ResultPath
        {
            get
            {
                return (RESULT_PATH);
            }
        }

        #endregion ==================== ATTRIBUTES ====================



        #region ==================== METHODS ====================

        protected void CheckCreateAttribute(string attributeName, string component)
        {
            if (components.ContainsKey(attributeName) == false)
                components.Add(attributeName, component);
        }

        public virtual void CreateLatex()
        {
            string filePath = string.Format("{0}{1}.tex", TemplatePath, Name);

            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine(@"\documentclass{report}");
                sw.WriteLine(@"\input{/srv/www/latexService/latexTemplates/packages/poll-report}");
                sw.WriteLine(@"\input{/srv/www/latexService/latexTemplates/colors/poll-report}");

                bool chartSection = false;

                foreach (KeyValuePair<string, string> item in components)
                {
                    if (item.Key == "headerFooter")
                    {
                        sw.WriteLine(item.Value);
                        sw.WriteLine(@"\begin{document}");
                        sw.WriteLine(@"\section*{Relatório de Sondagem - Planilha}");
                    }
                    else if (item.Key.StartsWith("chart") && chartSection == false)
                    {
                        sw.WriteLine(@"\section*{Relatório de Sondagem - Gráficos}");
                        sw.WriteLine(item.Value);
                        chartSection = true;
                    }
                    else
                        sw.WriteLine(item.Value);
                }

                sw.WriteLine(@"\end{document}");
            }
        }

        #endregion ==================== METHODS ====================
    }
}