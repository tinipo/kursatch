using Microsoft.AspNetCore.Mvc;
using kursatch.Models;

public class GraphController : Controller
{
    public IActionResult Index()
    {
        var model = new GraphModel();
        return View(model);
    }

    [HttpPost]
    public IActionResult GenerateGraph(GraphModel model)
    {
        if (ModelState.IsValid)
        {
            if (!string.IsNullOrEmpty(model.Equation))
            {
                model.ChartData = GetChartData(model.Equation);
            }
            else
            {
                ModelState.AddModelError(nameof(model.Equation), "Please enter an equation.");
            }
        }

        return View("Index", model);
    }

    private string GetChartData(string equation)
    {
        // Здесь вы можете написать код для генерации данных графика
        // В примере, я просто возвращаю статические данные для линейного графика
        return "{ labels: [1, 2, 3], datasets: [{ label: 'Graph', data: [2, 4, 6] }] }";
    }
}
