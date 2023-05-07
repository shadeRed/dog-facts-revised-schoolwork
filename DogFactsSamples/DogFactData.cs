using System;
using System.Collections.Generic;

namespace DogFactsSamples
{
    public class DogFactData
    {
        public DogFactData()
        {
        }
        public static IEnumerable<DogFactData> All { private set; get; }
        public string TheFact { get; set; }
        public string ShortFact { get; set; }
        static DogFactData()
        {
            List<DogFactData> all = new List<DogFactData>();
            all.Add(new DogFactData() { TheFact = "My favorite color is purple", ShortFact = "Favorite Color" });
            all.Add(new DogFactData() { TheFact = "I have a black cat named Jinx", ShortFact = "Pet Cat" });
            all.Add(new DogFactData() { TheFact = "My favorite programming language is JavaScript", ShortFact = "Favorite Programming Language" });
            all.Add(new DogFactData() { TheFact = "I am 21 years old", ShortFact = "How old" });
            all.Add(new DogFactData() { TheFact = "My at-home computer setup collectively costs more than $2000", ShortFact = "Too Expensive" });
            All = all;

        }
    }
}