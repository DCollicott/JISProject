using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JISProject.Engine;


namespace JISProject.App.Models
{

    public class CalcModel
    {
        // Input
        public string Equation { get; set; }

        // Output
        public string Result { get; set; }


        public CalcModel()
        {
        }


        public CalcModel(string Equation)
        {
            this.Equation = Equation;
        }


        public void Process()
        {
            var elements = Equation.Split(' ');

            // Here's where I would build the equation using PrimitiveEntry (for digits) and
            // OperationEntry (for more than a simple x + y equation) and process it.
            // This is where I hit four hours.

            Result = Equation + " = ???";
            Equation = "";
        }
    }
}

