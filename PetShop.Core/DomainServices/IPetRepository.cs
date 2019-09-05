using System;
using System.Collections.Generic;
using System.Text;
using PetShop.Core.Entity;

namespace PetShop.Core.DomainServices
{
    public interface IPetRepository 
    {

        void CreatePet(string type, string name, DateTime birthday, DateTime soldDate, string colour, string previousOwner, double price);
        IEnumerable<Pet> GetPets();//read pets in crud.
        void UpdatePet(int id ,string type, string name, DateTime birthday, DateTime soldDate, string colour, string previousOwner, double price);
        void DeletePet(int iD);
        //void initData();
    }
}
