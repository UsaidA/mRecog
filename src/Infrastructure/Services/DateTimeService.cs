using mRecog.Application.Common.Interfaces;

namespace mRecog.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
