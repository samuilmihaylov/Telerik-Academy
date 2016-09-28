namespace Cars.Tests.JustMock
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Telerik.JustMock;

    using Cars.Contracts;
    using Cars.Data;

    [TestClass]
    public class CarsRepositoryTest
    {
        [TestMethod]
        public void CarsRepository_TotalCars_ShouldReturnTotalCarsProperly()
        {
            // Arrange
            var mockedCollection = Mock.Create<IList<ICar>>();
            Mock.Arrange(() => mockedCollection.Count).OccursOnce();

            var mockedDataBase = Mock.Create<IDatabase>();
            Mock.Arrange(() => mockedDataBase.Cars).Returns(mockedCollection);

            var testCarRepository = new CarsRepository(mockedDataBase);

            // Act
            var act = testCarRepository.TotalCars;

            // Assert
            Mock.Assert(mockedCollection);
        }

        [TestMethod]
        public void CarsRepository_AddMethod_ShouldThrowArgumentNullException_IfCarIsNull()
        {
            // Arrange
            var testCarRepository = new CarsRepository();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => testCarRepository.Add(null));
        }

        [TestMethod]
        public void CarsRepository_CallRemoveMethod_ShouldThrowArgumentNullException_IfCarIsNull()
        {
            // Arrange
            var testCarRepository = new CarsRepository();

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => testCarRepository.Remove(null));
        }

        [TestMethod]
        public void CarsRepository_RemoveMethod_ShouldRemoveCarProperly()
        {
            // Arrange
            var mockedCar = Mock.Create<ICar>();

            var mockedCollection = Mock.Create<IList<ICar>>();
            Mock.Arrange(() => mockedCollection.Remove(mockedCar)).OccursOnce();

            var mockedDatabase = Mock.Create<IDatabase>();
            Mock.Arrange(() => mockedDatabase.Cars).Returns(mockedCollection);

            var testCarRepository = new CarsRepository(mockedDatabase);

            // Act
            testCarRepository.Remove(mockedCar);

            // Assert
            Mock.Assert(mockedCollection);
        }

        [TestMethod]
        public void CarsRepository_GetByIdMethod_ShouldThrowArgumentException_IfCarWithThatIdDoNotExsist()
        {
            // Arrange
            var numberOfCars = 5;
            var testCollection = new List<ICar>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var mockedCar = Mock.Create<ICar>();
                Mock.Arrange(() => mockedCar.Id).Returns(i);

                testCollection.Add(mockedCar);
            }

            var mockedDatabase = Mock.Create<IDatabase>();
            Mock.Arrange(() => mockedDatabase.Cars).Returns(testCollection);

            var testCarRepository = new CarsRepository(mockedDatabase);

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => testCarRepository.GetById(numberOfCars + 5));
        }

        [TestMethod]
        public void CarsRepository_GetByIdMethod_ShouldProperlyReturnResult()
        {
            // Arrange
            var numberOfCars = 5;
            var random = new Random();

            var testCollection = new List<ICar>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var car = Mock.Create<ICar>();
                Mock.Arrange(() => car.Id).Returns(i);

                testCollection.Add(car);
            }

            var mockedDatabase = Mock.Create<IDatabase>();
            Mock.Arrange(() => mockedDatabase.Cars).Returns(testCollection);

            var testCarRepository = new CarsRepository(mockedDatabase);

            // Act
            var expected = random.Next(numberOfCars);

            // Assert
            Assert.AreEqual(expected, testCarRepository.GetById(expected).Id);
        }

        [TestMethod]
        public void CarsRepository_AllMethod_ShouldProperslyReturnResult()
        {
            // Arrange
            var testCollection = new List<ICar>();

            var mockedCar = Mock.Create<ICar>();
            testCollection.Add(mockedCar);

            var mockedDatabase = Mock.Create<IDatabase>();
            Mock.Arrange(() => mockedDatabase.Cars).Returns(testCollection);

            var testCarRepository = new CarsRepository(mockedDatabase);

            // Act
            var expectedList = new List<ICar>(testCollection);

            bool areEquals = expectedList.TrueForAll(x => testCarRepository.All().Contains(x));

            // Assert
            Assert.IsTrue(areEquals);
        }

        [TestMethod]
        public void CarsRepository_SortBtYear_ShouldReturnSortedCollectionByYear()
        {
            var numberOfCars = 10;
            var random = new Random();

            var testCollection = new List<ICar>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var mockedCar = Mock.Create<ICar>();
                Mock.Arrange(() => mockedCar.Year).Returns(1990 + random.Next(10));
                testCollection.Add(mockedCar);
            }

            var mockedDatabase = Mock.Create<IDatabase>();
            Mock.Arrange(() => mockedDatabase.Cars).Returns(testCollection);

            var testCarRepository = new CarsRepository(mockedDatabase);

            var expected = testCollection
                            .OrderByDescending(x => x.Year)
                            .ToList();

            var result = testCarRepository.SortedByYear().ToList();

            bool areEquals = expected.Count == result.Count;

            // if count is diferent no use to check 1 by 1 
            if (areEquals)
            {
                for (int i = 0; i < numberOfCars; i++)
                {
                    if (!expected[i].Equals(result[i]))
                    {
                        areEquals = false;
                    }
                }
            }

            Assert.IsTrue(areEquals);
        }

        [TestMethod]
        public void CarsRepository_SortedByMake_ShouldReturnSortedByMakeCollection()
        {
            var numberOfCars = 10;
            var random = new Random();

            var testCollection = new List<ICar>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var mockedCar = Mock.Create<ICar>();
                var make = new string((char)(65 + random.Next(26)), random.Next(10));

                if (i % 2 == 0)
                {
                    make = make.ToUpper();
                }

                Mock.Arrange(() => mockedCar.Make).Returns(make);

                testCollection.Add(mockedCar);
            }

            var mockedDatabase = Mock.Create<IDatabase>();
            Mock.Arrange(() => mockedDatabase.Cars).Returns(testCollection);

            var testCarRepository = new CarsRepository(mockedDatabase);

            var expected = testCollection
                            .OrderBy(x => x.Make)
                            .ToList();

            var result = testCarRepository
                            .SortedByMake()
                            .ToList();

            var areEquls = expected.Count == result.Count;

            if (areEquls)
            {
                for (int i = 0; i < numberOfCars; i++)
                {
                    if (!expected[i].Equals(result[i]))
                    {
                        areEquls = false;
                    }
                }
            }

            Assert.IsTrue(areEquls);
        }

        [TestMethod]
        public void CarsRepository_SearchMethod_ShouldReturnOriginalCollection_IfConditionIsNull()
        {
            var numberOfCars = 10;

            var testCollection = new List<ICar>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var mockedCar = Mock.Create<ICar>();
                testCollection.Add(mockedCar);
            }

            var mockDb = Mock.Create<IDatabase>();
            Mock.Arrange(() => mockDb.Cars).Returns(testCollection);

            var repo = new CarsRepository(mockDb);

            var expected = testCollection;

            var result = repo.Search(null).ToList();

            var areEquls = expected.Count == result.Count;

            if (areEquls)
            {
                for (int i = 0; i < numberOfCars; i++)
                {
                    if (!expected[i].Equals(result[i]))
                    {
                        areEquls = false;
                    }
                }
            }

            Assert.IsTrue(areEquls);
        }

        [TestMethod]
        public void CarsRepository_SearchMethod_ShouldReturnOriginalCollection_IfConditionIsStringEmpty()
        {
            var numberOfCars = 10;

            var testCollection = new List<ICar>();

            for (int i = 0; i < numberOfCars; i++)
            {
                var mockedCar = Mock.Create<ICar>();
                testCollection.Add(mockedCar);
            }

            var mockedDatabase = Mock.Create<IDatabase>();
            Mock.Arrange(() => mockedDatabase.Cars).Returns(testCollection);

            var repo = new CarsRepository(mockedDatabase);

            var expected = testCollection;

            var result = repo.Search(string.Empty).ToList();

            var areEquls = expected.Count == result.Count;

            if (areEquls)
            {
                for (int i = 0; i < numberOfCars; i++)
                {
                    if (!expected[i].Equals(result[i]))
                    {
                        areEquls = false;
                    }
                }
            }

            Assert.IsTrue(areEquls);
        }

        [TestMethod]
        public void CarsRepository_SearchMethod_ShouldMatchMakeAndModelInSameTime_AndReturnProperResult()
        {
            // :D 
            int MagicNumberThatScaleCarsCreated = 5;
            var valid = "valid";
            var notValid = "NotValid";
            var testCollection = new List<ICar>();

            for (int i = 0; i < MagicNumberThatScaleCarsCreated + 1; i++)
            {
                var mockedCar = Mock.Create<ICar>();
                Mock.Arrange(() => mockedCar.Make).Returns(valid);
                Mock.Arrange(() => mockedCar.Model).Returns(notValid);
                testCollection.Add(mockedCar);
            }

            for (int i = 0; i < MagicNumberThatScaleCarsCreated - 1; i++)
            {
                var mockedCar = Mock.Create<ICar>();
                Mock.Arrange(() => mockedCar.Make).Returns(notValid);
                Mock.Arrange(() => mockedCar.Model).Returns(valid);
                testCollection.Add(mockedCar);
            }

            for (int i = 0; i < MagicNumberThatScaleCarsCreated; i++)
            {
                var mockedCar = Mock.Create<ICar>();
                Mock.Arrange(() => mockedCar.Make).Returns(valid);
                Mock.Arrange(() => mockedCar.Model).Returns(valid);
                testCollection.Add(mockedCar);
            }

            for (int i = 0; i < MagicNumberThatScaleCarsCreated; i++)
            {
                var mockedCar = Mock.Create<ICar>();
                Mock.Arrange(() => mockedCar.Make).Returns(notValid);
                Mock.Arrange(() => mockedCar.Model).Returns(notValid);
                testCollection.Add(mockedCar);
            }

            var mockedDatabase = Mock.Create<IDatabase>();
            Mock.Arrange(() => mockedDatabase.Cars).Returns(testCollection);

            var repo = new CarsRepository(mockedDatabase);

            Assert.AreEqual(3 * MagicNumberThatScaleCarsCreated, repo.Search(valid).Count);
        }

        [TestMethod]
        public void CarsRepository_SearchMethod_ShouldReturnEmptyCollection_IfNoMatch()
        {
            // :D 
            int MagicNumberThatScaleCarsCreated = 5;
            var valid = "valid";
            var notValid = "NotValid";
            var testCollection = new List<ICar>();

            for (int i = 0; i < MagicNumberThatScaleCarsCreated; i++)
            {
                var mockedCar = Mock.Create<ICar>();
                Mock.Arrange(() => mockedCar.Make).Returns(notValid);
                Mock.Arrange(() => mockedCar.Model).Returns(notValid);
                testCollection.Add(mockedCar);
            }

            var mockedDatabase = Mock.Create<IDatabase>();
            Mock.Arrange(() => mockedDatabase.Cars).Returns(testCollection);

            var repo = new CarsRepository(mockedDatabase);

            Assert.AreEqual(0, repo.Search(valid).Count);
        }
    }
}

