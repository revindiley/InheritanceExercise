using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
        }
        public bool IsColdBlooded { get; set; }
        public bool HasScales { get; set; }
        public string Color { get; set; }
        public string Environment { get; set; }

        public Reptile(bool isColdBlooded, bool hasScales, string color, string environment, string name, int age, int legs, bool hasBackbone)
        {
            IsColdBlooded = isColdBlooded;
            HasScales = hasScales;
            Color = color;
            Environment = environment;
            Name = name;
            Age = age;
            Legs = legs;
            HasBackBone= hasBackbone;

        }
    }

}
