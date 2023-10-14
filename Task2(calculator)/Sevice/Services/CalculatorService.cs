using System;
namespace Sevice.Services
{
	public class CalculatorService
	{
		public string Calculator(double a, double b, string operation)
		{

			switch(operation){
				case "+":
					return (a + b).ToString();
				case "-":
					return (a - b).ToString();
				case "/":
					return (a/b).ToString();
				case "*":
					return (a * b).ToString();
				default:
					return "Please enter proper operator";
			}
		}
	}
}

