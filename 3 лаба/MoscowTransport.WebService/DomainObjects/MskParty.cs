using System;
using System.Collections.Generic;
using System.Text;

namespace Partys.DomainObjects
{
    public class MskParty : DomainObject
    {
        public string Name { get; set; }

        public string WebSite { get; set; }

        public string TimeZone { get; set; }

    }
}
