using LatexService.Business.Extensions;
using System.Threading.Tasks;

namespace LatexService.Business
{
    public static class Methods
    {
        public static void CleanTempFiles(string resultPath, string templatePath, string fileName)
        {
            string command = string.Format("latexmk -C -output-directory={0} {1}{2}.tex", resultPath, templatePath, fileName);
            command.Bash();
        }

        public static async Task<bool> CreatePDF(string resultPath, string templatePath, string fileName)
        {
            string resultFilePath = string.Format("{0}{1}.pdf", resultPath, fileName);
            bool createFile = false;

            while (System.IO.File.Exists(resultFilePath) == false)
            {
                if (createFile == false)
                {
                    string command = string.Format("latexmk -pdf -output-directory={0} {1}{2}.tex", resultPath, templatePath, fileName);
                    command.Bash();
                    createFile = true;
                }
                else
                    await Task.Delay(100);
            }

            return (true);
        }

        public static void CreateLatex(Models.Abstracts.Recipe recipe)
        {
            recipe.CreateLatex();
        }

        public static async Task<bool> CreateRecipe(Models.Abstracts.Recipe recipe)
        {
            recipe.CreateLatex();

            return (await CreatePDF(recipe.ResultPath, recipe.TemplatePath, recipe.Name));
        }
    }
}