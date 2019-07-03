using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LatexService.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        /// <summary>
        /// Método para gerar a receita (recipe) para todos os tipos existentes (polimorfismo)
        /// </summary>
        /// <param name="recipe">Receita necessária para gerar o tipo correto de relatório</param>
        /// <returns>Não retorna valor, contudo gera o arquivo PDF no servidor</returns>
        private async Task CreateRecipe(Business.Models.Abstracts.Recipe recipe)
        {
            Business.Methods.CleanTempFiles(recipe.ResultPath, recipe.TemplatePath, recipe.Name);
            await Business.Methods.CreateRecipe(recipe);
        }

        /// <summary>
        /// Método para gerar o pdf à partir de uma recipe de Relatório de Sondagem - Portugues Consolidado (Escrita)
        /// </summary>
        /// <param name="recipe">Recipe da Sondagem de Português (valores)</param>
        /// <returns>Retorna o PDF gerado à partir da recipe</returns>
        [HttpPost]
        public async Task<IActionResult> PollReportPortugueseWriting([FromBody] Business.Models.Recipes.PollReportPortugueseWriting recipe)
        {
            try
            {
                await CreateRecipe(recipe);

                return (new PhysicalFileResult(string.Format("{0}{1}.pdf", recipe.ResultPath, recipe.Name), "application/pdf"));
            }
            catch (Exception error)
            {
                return (StatusCode(500, error));
            }
        }

        /// <summary>
        /// Método para gerar o pdf à partir de uma recipe de Relatório de Sondagem - Portugues Consolidado (Leitura)
        /// </summary>
        /// <param name="recipe">Recipe da Sondagem de Português (valores)</param>
        /// <returns>Retorna o PDF gerado à partir da recipe</returns>
        [HttpPost]
        public async Task<IActionResult> PollReportPortugueseReading([FromBody] Business.Models.Recipes.PollReportPortugueseReading recipe)
        {
            try
            {
                await CreateRecipe(recipe);

                return (new PhysicalFileResult(string.Format("{0}{1}.pdf", recipe.ResultPath, recipe.Name), "application/pdf"));
            }
            catch (Exception error)
            {
                return (StatusCode(500, error));
            }
        }

        /// <summary>
        /// Método para gerar o pdf à partir de uma recipe de Relatório de Sondagem - Português da Classe (Escrita)
        /// </summary>
        /// <param name="recipe">Recipe da Sondagem de Português da Classe (valores)</param>
        /// <returns>Retorna o PDF gerado à partir da recipe</returns>
        [HttpPost]
        public async Task<IActionResult> PollReportPortugueseWritingClass([FromBody] Business.Models.Recipes.PollReportPortugueseWritingClass recipe)
        {
            try
            {
                await CreateRecipe(recipe);

                return (new PhysicalFileResult(string.Format("{0}{1}.pdf", recipe.ResultPath, recipe.Name), "application/pdf"));
            }
            catch (Exception error)
            {
                return (StatusCode(500, error));
            }
        }

        /// <summary>
        /// Método para gerar o pdf à partir de uma recipe de Relatório de Sondagem - Português da Classe (Leitura)
        /// </summary>
        /// <param name="recipe">Recipe da Sondagem de Português da Classe (valores)</param>
        /// <returns>Retorna o PDF gerado à partir da recipe</returns>
        [HttpPost]
        public async Task<IActionResult> PollReportPortugueseReadingClass([FromBody] Business.Models.Recipes.PollReportPortugueseReadingClass recipe)
        {
            try
            {
                await CreateRecipe(recipe);

                return (new PhysicalFileResult(string.Format("{0}{1}.pdf", recipe.ResultPath, recipe.Name), "application/pdf"));
            }
            catch (Exception error)
            {
                return (StatusCode(500, error));
            }
        }

        /// <summary>
        /// Método para gerar o pdf à partir de uma recipe de Relatório de Sondagem - Matemática Consolidado (Aditivo)
        /// </summary>
        /// <param name="recipe">Recipe da Sondagem de Matemática (valores)</param>
        /// <returns>Retorna o PDF gerado à partir da recipe</returns>
        [HttpPost]
        public async Task<IActionResult> PollReportMathSum([FromBody] Business.Models.Recipes.PollReportMathSum recipe)
        {
            try
            {
                await CreateRecipe(recipe);

                return (new PhysicalFileResult(string.Format("{0}{1}.pdf", recipe.ResultPath, recipe.Name), "application/pdf"));
            }
            catch (Exception error)
            {
                return (StatusCode(500, error));
            }
        }

        /// <summary>
        /// Método para gerar o pdf à partir de uma recipe de Relatório de Sondagem - Matemática Consolidado (Multiplicativo)
        /// </summary>
        /// <param name="recipe">Recipe da Sondagem de Matemática (valores)</param>
        /// <returns>Retorna o PDF gerado à partir da recipe</returns>
        [HttpPost]
        public async Task<IActionResult> PollReportMathMultiplication([FromBody] Business.Models.Recipes.PollReportMathMultiplication recipe)
        {
            try
            {
                await CreateRecipe(recipe);

                return (new PhysicalFileResult(string.Format("{0}{1}.pdf", recipe.ResultPath, recipe.Name), "application/pdf"));
            }
            catch (Exception error)
            {
                return (StatusCode(500, error));
            }
        }

        /// <summary>
        /// Método para gerar o pdf à partir de uma recipe de Relatório de Sondagem - Matemática Consolidado (Números)
        /// </summary>
        /// <param name="recipe">Recipe da Sondagem de Matemática (valores)</param>
        /// <returns>Retorna o PDF gerado à partir da recipe</returns>
        [HttpPost]
        public async Task<IActionResult> PollReportMathNumbers([FromBody] Business.Models.Recipes.PollReportMathNumbers recipe)
        {
            try
            {
                await CreateRecipe(recipe);

                return (new PhysicalFileResult(string.Format("{0}{1}.pdf", recipe.ResultPath, recipe.Name), "application/pdf"));
            }
            catch (Exception error)
            {
                return (StatusCode(500, error));
            }
        }

        /// <summary>
        /// Método para gerar o pdf à partir de uma recipe de Relatório de Sondagem - Matemática da Classe (Aditivo)
        /// </summary>
        /// <param name="recipe">Recipe da Sondagem de Matemática da Classe (valores)</param>
        /// <returns>Retorna o PDF gerado à partir da recipe</returns>
        [HttpPost]
        public async Task<IActionResult> PollReportMathSumClass([FromBody] Business.Models.Recipes.PollReportMathSumClass recipe)
        {
            try
            {
                await CreateRecipe(recipe);

                return (new PhysicalFileResult(string.Format("{0}{1}.pdf", recipe.ResultPath, recipe.Name), "application/pdf"));
            }
            catch (Exception error)
            {
                return (StatusCode(500, error));
            }
        }

        /// <summary>
        /// Método para gerar o pdf à partir de uma recipe de Relatório de Sondagem - Matemática da Classe (Multiplicativo)
        /// </summary>
        /// <param name="recipe">Recipe da Sondagem de Matemática da Classe (valores)</param>
        /// <returns>Retorna o PDF gerado à partir da recipe</returns>
        [HttpPost]
        public async Task<IActionResult> PollReportMathMultiplicationClass([FromBody] Business.Models.Recipes.PollReportMathMultiplicationClass recipe)
        {
            try
            {
                await CreateRecipe(recipe);

                return (new PhysicalFileResult(string.Format("{0}{1}.pdf", recipe.ResultPath, recipe.Name), "application/pdf"));
            }
            catch (Exception error)
            {
                return (StatusCode(500, error));
            }
        }

        /// <summary>
        /// Método para gerar o pdf à partir de uma recipe de Relatório de Sondagem - Matemática da Classe (Números)
        /// </summary>
        /// <param name="recipe">Recipe da Sondagem de Matemática da Classe (valores)</param>
        /// <returns>Retorna o PDF gerado à partir da recipe</returns>
        [HttpPost]
        public async Task<IActionResult> PollReportMathNumbersClass([FromBody] Business.Models.Recipes.PollReportMathNumbersClass recipe)
        {
            try
            {
                await CreateRecipe(recipe);

                return (new PhysicalFileResult(string.Format("{0}{1}.pdf", recipe.ResultPath, recipe.Name), "application/pdf"));
            }
            catch (Exception error)
            {
                return (StatusCode(500, error));
            }
        }
    }
}