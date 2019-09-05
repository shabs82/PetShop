using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PetShop.Core.DomainServices;
using PetShop.Core.Entity;

namespace PetShop.Core.ApplicationServices.Services
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _petRepository;//create a variable petRepo as petService is dependent on pet repository.

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public void CreatePet(string type, string name, DateTime birthday, DateTime solddate, string colour, string previousOwner, double price)
        {
            _petRepository.CreatePet(type,  name,  birthday,  solddate,  colour,  previousOwner,  price);
        }

        public void DeletePet(int iD)
        {
           _petRepository.DeletePet(iD);
        }

        public List<Pet> GetPets()
        {
            return _petRepository.GetPets().ToList();//convert. to list
        }

        public void UpdatePet(int iD, string type, string name, DateTime birthday, DateTime solddate, string colour, string previousOwner, double price)
        {
            _petRepository.UpdatePet(iD, type, name, birthday, solddate, colour, previousOwner, price);
        }

        public void SearchPet(int id)
        {

        }

        //public void initData()
        //{
        //    _petRepository.initData();
        //}
    }
}
