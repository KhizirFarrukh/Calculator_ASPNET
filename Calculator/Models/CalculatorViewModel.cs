using System.Collections.Generic;

namespace Calculator.Models
{
    public class CalculatorViewModel
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public string Operation { get; set; }
        public List<string> OperationList { get; set; } = new List<string>() { "+", "-", "*", "/" };
        public int? Result { get; set; }
    }
}
