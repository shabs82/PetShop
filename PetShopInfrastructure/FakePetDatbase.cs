using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using PetShop.Core.Entity;
using PetShopInfrastructure.Repositories;

namespace PetShopInfrastructure
{
    public static class FakePetDatabase
    {

        private static List<Pet> pets;// Ienumerable is a interface used by List.
        private static int id = 1;// create a variable as id will be iterated 
        public static void InitialiseData()
        {
            Pet pet1 = new Pet()
                { ID = id++,
                  Name = " Trump",
                  Type = "Donkey",
                  Birthday = DateTime.Parse("21/11/2018"),
                  SoldDate = DateTime.Parse("23/11/2018"),
                  Colour = "Orange",
                  PreviousOwner = "Nedas",
                  Price =  6,
                };

            Pet pet2 = new Pet()
            {
                ID = id++,
                Name = " Bojo",
                Type = "Rhino",
                Birthday = DateTime.Parse("21/8/2018"),
                SoldDate = DateTime.Parse("23/8/2018"),
                Colour = "WierdPink",
                PreviousOwner = "Greg",
                Price = 8

            };

            Pet pet3 = new Pet()
            {
                ID = id++,
                Name = " Sugar",
                Type = "Ape",
                Birthday = DateTime.Parse("1/4/2012"),
                SoldDate = DateTime.Parse("15/4/2012"),
                Colour = "Green",
                PreviousOwner = "David",
                Price = 16

            };
            List<Pet> petsList = new List<Pet>();
            petsList.Add(pet1);
            petsList.Add(pet2);
            petsList.Add(pet3);

            pets = petsList;//pets is IEnumerable which is an interface.
        }

        public static IEnumerable<Pet> SelectAll()
        {
            return pets;
        }

        public static void InsertInto(Pet pet)
        {
            pet.ID = id++;
            pets.Add(pet);
        }

        public static Pet DeletePet(int id)
        {
            var petFound = pets.FirstOrDefault(pet => pet.ID == id);
            pets.Remove(petFound);
            return petFound;
        }



        public static void UpdatePets(List<Pet> pets)
        {
            pets = pets;
        }

    }
}
