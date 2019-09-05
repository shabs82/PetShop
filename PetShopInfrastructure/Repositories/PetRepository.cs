using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.DomainServices;
using PetShop.Core.Entity;

namespace PetShopInfrastructure.Repositories
{
    public class PetRepository : IPetRepository
    {
        

        public void CreatePet(string type, string name, DateTime birthday, DateTime soldDate, string colour,
            string previousOwner, double price)
        {
            Pet pet1 = new Pet()
            {
                Name = name,
                Type = type,
                Birthday = birthday,
                SoldDate = soldDate,
                Colour = colour,
                PreviousOwner = previousOwner,
                Price = price,
            };
            FakePetDatabase.InsertInto(pet1);
        }

        public void DeletePet(int id)
        {
            Pet petToDelete = null;
            foreach (Pet p in GetPets())
            {
                if (p.ID == id)
                {
                    petToDelete = p;
                }
            }

            if (petToDelete != null)
            {
                FakePetDatabase.DeletePet(petToDelete.ID);
            }
        }


        public IEnumerable<Pet> GetPets()
        {
            return FakePetDatabase.SelectAll();
        }

        //public void initData()
        //{
        //    _pets = FakePetDatabase.InitialiseData();
        //}
        public void UpdatePet(int id , string type, string name, DateTime birthday, DateTime soldDate, string colour,
            string previousOwner, double price)
        {
            foreach (Pet p in GetPets())
            {
                if (p.ID == id)
                {
                    p.Type = type;
                    p.Name = name;
                    p.Birthday = birthday;
                    p.SoldDate = soldDate;
                    p.Colour = colour;
                    p.PreviousOwner = previousOwner;
                    p.Price = price;
                }
            }
        }
    }
}
