using System;
using System.Collections.Generic;

#nullable disable

namespace APIServiceTest.Models
{
    public partial class Name
    {
        public long Id { get; set; }
        public string Name1 { get; set; }

        public static implicit operator string(Name v)
        {
            throw new NotImplementedException();
        }
    }
}
