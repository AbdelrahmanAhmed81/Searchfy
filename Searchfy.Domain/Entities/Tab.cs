using Searchfy.Domain.Contracts;
using System;
using System.Collections.Generic;

namespace Searchfy.Domain.Entities
{
    public class Tab : ITab
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Keywords { get; set; }
        public string Artist { get; set; }
        public IEnumerable<INote> Notes { get; set; }
    }
}
