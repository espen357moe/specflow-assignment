using NUnit.Framework;
using SpecflowDemo;
using TechTalk.SpecFlow;

namespace Tests.Spec.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {        
        private Calculator Calculator { get; }
        private decimal Num1 { get; set; }
        private decimal Num2 { get; set; }
        private decimal ActualResult { get; set; }                

        public CalculatorStepDefinitions()
        {                        
            Calculator = new Calculator();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(decimal number)
        {
            Num1 = number;                        
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(decimal number)
        {
            Num2 = number;            
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {            
            ActualResult = Calculator.Add(Num1, Num2);          
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(decimal expectedResult)
        {
            Assert.AreEqual(expectedResult, ActualResult);
        }
    }
}
