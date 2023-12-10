using System.ComponentModel.DataAnnotations;

namespace kursatch.Models
{
    public class GraphModel
    {
        [Required(ErrorMessage = "Please enter an equation.")]
        public string Equation { get; set; }

        public string ChartData { get; set; }
    }
}
