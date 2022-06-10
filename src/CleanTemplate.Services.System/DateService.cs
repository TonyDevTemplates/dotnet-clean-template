using System;
using CleanTemplate.Application.Common;

namespace CleanTemplate.Services.System
{
    public class DateService: IDateService
    {
        public DateTime Now => DateTime.Now;
    }
}
