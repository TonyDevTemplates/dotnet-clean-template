using System;
using System.Threading;
using System.Threading.Tasks;
using CleanTemplate.Application.Features.Forecast.Commands;
using CleanTemplate.Domain.Entities.Forecasts;
using FluentAssertions;
using NUnit.Framework;


namespace CleanTemplate.UnitTest.App.Features.Forecast.Commands
{
    [TestFixture]
    internal class AddNewForecastCommandHandlerTests : ForecastTestBase
    {
        [Test]
        public async Task AddNewForecast_AddForecastAndGetId_ReturnAddedId()
        {
            var creationData = new WeatherForecastCreation
            {
                Wind = "WEST",
            };
            var command = new AddNewForecastCommand("FakeUser", creationData);
            var handler = new AddNewForecastCommandHandler(ForecastDbStub.Object);

            var result = await handler.Handle(command, CancellationToken.None);

            result.Should().Be(Guid.Empty);
        }
    }
}