using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CreditCard.Test.Model
{
    public class CreditCardApplicationEvaluatorShould
    {
        private const int ExpectedLowIncomeThreshhold = 20_000;
        private const int ExpectedHighIncomeThreashhold = 100_000;

        [Theory]
        [InlineData(ExpectedHighIncomeThreashhold)]
        [InlineData(ExpectedHighIncomeThreashhold+1)]
        [InlineData(int.MaxValue)]
        public void AcceptAllHighIncomeApplicants(int income)
        {
            //var sut = new CreditCardApplicationEvaluator();
        }
    }
}
