using BankingStuff;
using System;
using Xunit;

namespace BankingTest
{
    public class BasicTests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void Test2()
        {
            var account = new BankAccount("Ken", 10000);


            //Test for a negativ balance

            Assert.Throws<InvalidOperationException>(

                () => account.MakeWithdrawal(75000, 
                      DateTime.Now, "Attempt to withdraw")
                );
        }

        [Fact]
        public void Test3()
        {
            //Test that the initial balance must be positive.
            Assert.Throws<ArgumentOutOfRangeException>(
                
                () => new BankAccount("invalid", -55)

                );
        }
    }
}