using System;
using CleanTemplate.Application.Common;
using FluentAssertions;
using Moq;
using NUnit.Framework;

namespace CleanTemplate.UnitTest.Infrastructure.Services
{
    [TestFixture]
    internal class SystemDateTimeServiceTests
    {
        private Mock<IDateService> _dateService;

        [SetUp]
        public void Setup()
        {
            _dateService = CreateDateServiceStub();
        }

        private static Mock<IDateService> CreateDateServiceStub()
        {
            var dateStub = new Mock<IDateService>();

            dateStub.Setup(x => x.Now).Returns(new DateTime(1010, 10, 10));

            return dateStub;
        }

        [TearDown]
        public void Destroy()
        {
            _dateService = null;
        }

        [Test]
        public void GetNow_GetPredictedNowDate_ReturnDate()
        {
            var expected = new DateTime(1010, 10, 10);
            var testStub = _dateService.Object;

            var result = testStub.Now;

            result.Should().BeCloseTo(expected);
        }
    }
}
