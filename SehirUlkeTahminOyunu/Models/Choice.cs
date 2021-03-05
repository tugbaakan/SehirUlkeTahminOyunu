using System;
using System.Collections.Generic;
using System.Text;

namespace SehirUlkeTahminOyunu.Models
{
    public class Choice<T>
    {
        public char Letter { get; set; }

        public string Description { get; set; }
        public T ChoiceClass {get; set;}
        public bool IsAnswer { get; set; }

    }
}
