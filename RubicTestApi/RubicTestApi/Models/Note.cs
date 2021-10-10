using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubicTestApi.Models
{
    public class Note//таблица, на её основе б созд-ся бд
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreateTime { get; set; }

    }
}
