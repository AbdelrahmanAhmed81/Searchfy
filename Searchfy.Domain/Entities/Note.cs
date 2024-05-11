using Searchfy.Domain.Contracts;
using System.Collections.Generic;

namespace Searchfy.Domain.Entities
{
    public class Note : INote
    {
        public IEnumerable<ITimeFrame> TimeFrames { get ; set; }
    }
}
