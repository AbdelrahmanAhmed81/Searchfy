using System;
using System.Collections.Generic;

namespace Searchfy.Domain.Contracts
{
    public interface ITab
    {
        Guid Id { get; set; }
        string Name { get; set; }
        IEnumerable<string> Keywords { get; set; }
        string Artist { get; set; }
        IEnumerable<INote> Notes { get; set; }

    }
}
