﻿using H.Core.Enumerations;
using H.Core.Services.StorageService;
using Moq;

namespace H.Avalonia.ViewModels.ComponentViews.OtherAnimals.Tests
{
    [TestClass]
    public class GoatsComponentViewModelTests
    {
        private GoatsComponentViewModel _viewModel;
        private IStorageService _mockStorageService;
        private Mock<IStorageService> _mock;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
        }

        [TestInitialize]
        public void TestInitialize()
        {
            _mock = new Mock<IStorageService>();
            _mockStorageService = _mock.Object;
            _viewModel = new GoatsComponentViewModel(_mockStorageService);
        }

        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void TestConstructorSettingViewName()
        {
            string expectedName = "Goats";
            Assert.AreEqual(expectedName, _viewModel.ViewName);
        }

        [TestMethod]
        public void TestConstructorSettingAnimalType()
        {
            AnimalType expectedAnimalType = AnimalType.Goats;
            Assert.AreEqual(expectedAnimalType, _viewModel.OtherAnimalType);
        }
    }
}