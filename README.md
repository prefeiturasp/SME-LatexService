# SME-LatexService
Serviço para gerar PDFs (relatórios) através do LaTeX utilizando .NET Core v2.2

# LatexService.Business
Essa camada tem a funcionalidade de utilizar os templates em LaTeX, juntamente com o C# como linguagem intermediária, aplicando-os em um conjunto de dados para gerar o relatório desejado.
Para que este processo seja possível, é necessário criar as receitas dos templates do LaTeX:
- LatexService.Business.Models.Recipes


# LatexService.API
API simples para redirecionar as requisições nas corretas receitas
