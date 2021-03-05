using System;
using System.Collections.Generic;
using System.Text;

namespace SehirUlkeTahminOyunu.Models
{
    public class Question<T>
    {
        public string Description { get; set; }
        public T ChoiceClass { get; set; }
      
    }
}
