using System.Collections.Generic;

namespace Searchfy.Domain.Contracts
{
    public interface INote
    {
        IEnumerable<ITimeFrame> TimeFrames { get; set; }
    }
}
