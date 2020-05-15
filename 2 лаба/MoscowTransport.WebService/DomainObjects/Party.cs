using System;
using System.Collections.Generic;
using System.Text;

namespace Partys.DomainObjects
{
    public class Party: DomainObject
    {
        public string Place { get; set; }

        public string Name { get; set; }

        public string District { get; set; }

        public string Area { get; set; }

        public string Adress { get; set; }

        public string Time { get; set; }

        public string AreaPlace { get; set; }

        public static implicit operator string(Party v)
        {
            throw new NotImplementedException();
        }
    }
    }
