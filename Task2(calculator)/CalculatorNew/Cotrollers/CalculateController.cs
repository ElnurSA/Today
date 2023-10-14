using System;
using Sevice.Services;

namespace CalculatorNew.Cotrollers
{
	public class CalculateController
	{

		private CalculatorService _calculateService;

		public CalculateController()
		{
			_calculateService = new CalculatorService();
		}
		public void Calculate()
		{


			

			Console.WriteLine("Enter first number:");
			Num1: string num1 = Console.ReadLine();

			double number1;

			bool isTrue = double.TryParse(num1, out number1);

			if (!isTrue)
			{
				Console.WriteLine("Please enter correct number:");
				goto Num1;
			}

			Console.WriteLine("Choose one of the operators: + - / *");

			string operation = Console.ReadLine();

			Console.WriteLine("Enter second number:");

		Num2: string num2 = Console.ReadLine();

			double number2;

			bool isTrue2 = double.TryParse(num2, out number2);

			if (!isTrue2)
			{
				Console.WriteLine("Please enter correct number: ");
				goto Num2;
			}

			string result = _calculateService.Calculator(number1, number2, operation);

			Console.WriteLine(result);
		}
	}
}

