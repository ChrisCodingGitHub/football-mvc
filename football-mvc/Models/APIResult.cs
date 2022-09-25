using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace football_mvc.Models
{
    public class APIResult<T> where T: class
    {
        public int Status { get; set; }
        public int Count { get; set; }
        public T[] Data { get; set; }
    }
}
