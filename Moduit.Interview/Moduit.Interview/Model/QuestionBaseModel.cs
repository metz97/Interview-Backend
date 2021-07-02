using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moduit.Interview.Model
{
    public class QuestionBaseModel
    {
        public int id { get; set; }
        public int category { get; set; }
        public List<string> tags { get; set; }
        public DateTime createdAt { get; set; }
    }
}
