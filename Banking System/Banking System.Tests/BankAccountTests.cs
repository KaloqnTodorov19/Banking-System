using NUnit.Framework;
using System;

namespace Banking_System.Tests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        //Tested
        public void DepositShouldIncreaseBalance()
        {
            {
                BankAccount bankAccount = new BankAccount(123);
                decimal depositAmount = 100;

                bankAccount.Deposit(depositAmount);

                Assert.AreEqual(depositAmount, bankAccount.Balance);
            }
        }
        [Test]
        //Tested
        public void AccountInicizlizeWhithPositiveValue()
        {
            {
                BankAccount bankAccount = new BankAccount(123, 2000m);

                Assert.AreEqual(2000m, bankAccount.Balance);
            }
        }
        [TestCase(100)]
        [TestCase(3500)]
        [TestCase(2400)]
        //Tested
        public void DepositShouldIncreaseBalanceAll(decimal depositAmount)
        {
            {
                BankAccount bankAccount = new BankAccount(123);

                bankAccount.Deposit(depositAmount);

                Assert.AreEqual(depositAmount, bankAccount.Balance);
            }
        }
        [Test]
        //Tested
        public void NegativeAmountShouldThrowInvalidOperationExceptions()
        {
            {
                BankAccount bankAccount = new BankAccount(123);
                decimal depositAmount = -100;

                Assert.Throws<InvalidOperationException>(() =>
                bankAccount.Deposit(depositAmount));
            }
        }
        [Test]
        //Tested
        public void NegativeAmountShouldThrowInvalidOperationExceptionsWithMessage()
        {
            {
                BankAccount bankAccount = new BankAccount(123);
                decimal depositAmount = -100;

                var ex = Assert.Throws<InvalidOperationException>(() =>
                bankAccount.Deposit(depositAmount));

                Assert.AreEqual("Negative amount", ex.Message);
            }
        }
    }
}