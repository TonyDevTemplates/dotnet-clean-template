using System;
using System.Collections.Generic;
using CleanTemplate.Application.Common;
using CleanTemplate.Domain.Entities.Forecasts;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;

namespace CleanTemplate.UnitTest.App.Features.Forecast
{
    [TestFixture]
    internal class ForecastTestBase
    {
        protected Mock<IForecastDbContext> ForecastDbStub;


        private Mock<IForecastDbContext> CreatePbxStorageMock()
        {
            var forecast = new WeatherForecast
            {
                Temperature = 10,
                Wind = "WEST",
                Clouds = "LOW",
                Summary = "Summary",
                ForecastDate = new DateTime(2020, 10, 10),
                Id = Guid.NewGuid()
            };
            var forecasts = new List<WeatherForecast> { forecast };

            var mockSet = new Mock<DbSet<WeatherForecast>>();

            var storageMock = new Mock<IForecastDbContext>();
            storageMock.Setup(x => x.WeatherForecasts).Returns(mockSet.Object);


            return storageMock;
        }


        [SetUp]
        public void SetUp()
        {
            ForecastDbStub = CreatePbxStorageMock();
        }

        [TearDown]
        public void TearDown()
        {
            ForecastDbStub = null;
        }
    }
}
