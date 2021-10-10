using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubicTestApi.Models
{
    public class Blob
    {
        public int Id { get; set; }
        public byte[] Context { get; set; }
        public string Extension { get; set; }


    }
}
