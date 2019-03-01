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
        }

        [TestMethod]
        public void AccountRepository_CreateAccount_ReturnTrue()
        {
            // Arrange
            Arrange();
            Person person = new Person("Larry", "Wagner", new DateTime(2000, 09, 20),"123-342-8888");

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
            Person person = new Person("Larry", "Wagner", new DateTime(2000, 09, 20),"123-342-8888");

            // Act
            bool actual = _accountRepo.CreateAccount(person, "Test1!", 50m, 500m);

            // Assert
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        public void AccountRepository_CreateAccount_AddToList()
        {
            // Arrange
            Arrange();
            Person person = new Person("Larry", "Wagner", new DateTime(2000, 09, 20),"123-342-8888");

            // Act
            bool actual = _accountRepo.CreateAccount(person, "Test1!", 50m, 500m);

            // Assert
            Assert.AreEqual(false, actual);
        }
    }
}
