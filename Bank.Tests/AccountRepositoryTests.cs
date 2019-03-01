using System;
using System.Collections.Generic;
using Bank.ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank.Tests
{
    [TestClass]
    public class AccountRepositoryTests
    {
        AccountRepository _accountRepo;
        List<Account> _accounts;

        [TestInitialize]
        public void Arrange()
        {
            _accountRepo = new AccountRepository();
            _accounts = new List<Account>();

            Person person = new Person("Larry", "Wagner", new DateTime(2000, 09, 20), 1233428888);
            Person personTwo = new Person("Sam", "Wagner", new DateTime(2000, 09, 20), 1112228888);
            Person personThree = new Person("Larry", "Wagner", new DateTime(2000, 09, 20), 1333334448);
            Person personFour = new Person("Larry", "Wagner", new DateTime(2000, 09, 20), 1233248888);
            _accountRepo.CreateAccount(person, "Test1!", 500m, 500m);
            _accountRepo.CreateAccount(personTwo, "Test2!", 500m, 500m);
            _accountRepo.CreateAccount(personThree, "Test3!", 500m, 500m);
            _accountRepo.CreateAccount(personFour, "Test4!", 500m, 500m);
        }

        [TestMethod]
        public void AccountRepository_CreateAccount_ReturnTrue()
        {
            // Arrange
            Arrange();
            Person person = new Person("Larry", "Wagner", new DateTime(2000, 09, 20),1233428888);

            // Act
            bool actual = _accountRepo.CreateAccount(person, "Test1!", 500m, 500m);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void AccountRepository_CreateAccount_ReturnFalse()
        {
            // Arrange
            Arrange();
            Person person = new Person("Larry", "Wagner", new DateTime(2000, 09, 20),1233428888);

            // Act
            bool actual = _accountRepo.CreateAccount(person, "Test1!", 50m, 500m);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void AccountRepository_CreateAccount_AddToListReturnTrue()
        {
            // Arrange
            Arrange();
            Person person = new Person("Larry", "Wagner", new DateTime(2000, 09, 20),1233428888);

            // Act
            bool actual = _accountRepo.CreateAccount(person, "Test1!", 50m, 500m);

            // Assert
            Assert.AreEqual(true, actual);
        }

        [DataTestMethod]
        [DataRow(1233430917, "Test1!")]
        [DataRow(1112230917, "Test2!")]
        [DataRow(1333336477, "Test3!")]
        [DataRow(1233250917, "Test4!")]
        public void AccountRepository_GetUserAccount_ReturnAccount(int x, string y)
        {
            Arrange();
            Account account = _accountRepo.GetUserAccount(x, y);
            Assert.AreEqual(x, account.AccountNumber);
        }
    }
}
