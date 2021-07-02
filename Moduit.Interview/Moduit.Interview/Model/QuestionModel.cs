using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moduit.Interview.Model
{
    public class QuestionModel : QuestionBaseModel
    {
        public string title { get; set; }
        public string description { get; set; }
        public string footer { get; set; }
    }
}
