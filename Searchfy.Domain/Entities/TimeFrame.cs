using Searchfy.Domain.Contracts;

namespace Searchfy.Domain.Entities
{
    public class TimeFrame : ITimeFrame
    {
        public string[] Hits { get; set; } = new string[6];
    }
}
