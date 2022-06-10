﻿using FluentValidation;

namespace CleanTemplate.Application.Features.Forecast.Commands
{
    public class AddNewForecastValidation : AbstractValidator<AddNewForecastCommand>
    {
        public AddNewForecastValidation()
        {
            RuleFor(x => x.CreationData.Summary).NotEmpty();
        }
    }
}
