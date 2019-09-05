using System;
using System.Collections.Generic;
using System.Text;

namespace PetShop.Core.Entity
{ 
   // public enum AnimalType { Donkey , Rhino ,Fish , Ape}
   public class Pet
    {
        public int  ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime SoldDate { get; set; }
        public string Colour { get; set; }
        public string PreviousOwner { get; set; }
        public double Price { get; set; }
    }
}
