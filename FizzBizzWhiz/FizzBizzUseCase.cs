using System;
using NUnit;
using NUnit.Framework;

namespace FizzBizzWhiz
{
	[TestFixture]
	public class FizzBizzWhiz
	{
		[TestCase(1, "1")]
		[TestCase(2, "2")]
		[TestCase(4, "4")]
		public void GivenNaturalNumber_IsNotDivisibleBy3or5_shouldReturnNumber(int number, string expected)
		{
			//act
			var actual = FizzBuzz(number);

			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestCase(3, "Fizz")]
		[TestCase(6, "Fizz")]
		[TestCase(9, "Fizz")]
		public void GivenNaturalNumber_IsDivisbleBy3_ShouldReturnFizz(int number, string expected)
		{
			//act
			var actual = FizzBuzz(number);

			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestCase(5, "Buzz")]//arrange
		[TestCase(10, "Buzz")]
		[TestCase(20, "Buzz")]
		public void GivenNaturalNumber_IsDivisibleBy5_ShouldReturnBuzz(int number, string expected)
		{
			//act
			var actual = FizzBuzz(number);

			//assert
			Assert.AreEqual(expected, actual);
		}

		[TestCase(15, "FizzBuzz")]//arrange
		[TestCase(30, "FizzBuzz")]
		[TestCase(75,"FizzBuzz")]
		public void GivenNaturalNumber_IsDivisbleBy3And5_shouldReturnFizzBuzz(int number, string expected)
		{
			//act
			var actual = FizzBuzz(number);

			//assert
			Assert.AreEqual(expected, actual);
		}

		private string FizzBuzz(int number)
		{
			if (number % 5 == 0 && number % 3 == 0)
				return "FizzBuzz";
			else if (number % 3 == 0)
				return "Fizz";
			else if (number % 5 == 0)
				return "Buzz";
			else
				return number.ToString();
		
		}
	}
}
