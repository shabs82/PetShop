using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.Entity;

namespace PetShop.Core.ApplicationServices
{
    public interface IPetService
    {
        void CreatePet(int id, string type, string name,DateTime birthday, DateTime soldDate, string colour , string previousOwner ,double price);
        List<Pet> GetPets();
        void UpdatePet(int iD, string type, string name, DateTime birthday, DateTime soldDate, string colour, string previousOwner, double price);
        void DeletePet(int iD);

        void SearchPet(int id);
        
    }
}
