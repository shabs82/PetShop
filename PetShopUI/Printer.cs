using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using PetShop.Core.ApplicationServices;
using PetShop.Core.Entity;
using PetShopInfrastructure;
using PetShopInfrastructure.Repositories;

namespace PetShopUI
{
    class Printer : IPrinter
    {
        private readonly IPetService _petService;

        PetRepository petRepo = new PetRepository();

        public Printer(IPetService petService)
        {
            _petService = petService;
           // _petService.initData();
        }

        public void StartUI()
        {

            Console.WriteLine("1: Add Pet");
            Console.WriteLine("2: show Pets");
            Console.WriteLine("3: Remove Pet");
            Console.WriteLine("4: Edit Pet");
            Console.WriteLine("5: Search Pets");
            Console.WriteLine("6: Exit");
            GetUserInput();
        }

        private void ShowPets()
        {
            List<Pet> newList = _petService.GetPets(); //added to the List<>
            foreach (var petToList in newList)
            {
                Console.WriteLine($"{petToList.ID} {petToList.Name} {petToList.Type} {petToList.Birthday} {petToList.Colour} {petToList.PreviousOwner} {petToList.SoldDate} {petToList.Price}  ");
            }
        }

        private void GetUserInput()
        {
            var userSelection = Convert.ToInt32(Console.ReadLine());
            while (userSelection != 5)
            {
                switch (userSelection)
                {
                    case 1:
                        CreatePet();

                        break;

                    case 2:
                        ShowPets();

                        break;

                    case 3:
                        DeletePet();
                        

                        break;
                    case 4:
                        EditPet();

                        break;
                    case 5:
                        break;

                    case 6:
                        Environment.Exit(-1);
                        break;
                    default:
                        break;






                }
                
                while (!int.TryParse(Console.ReadLine(), out userSelection))
                {
                    Console.WriteLine("please insert selection: ");
                }
            }


            
        }

        private void DeletePet()
        {
            Console.Write("Insert the id : ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("please insert a id : ");
            }
            _petService.DeletePet(id);
        }

        private void CreatePet()
        {
            Console.Write("get the name: ");
            string name = Console.ReadLine();
            Console.Write("specify the type: ");
            string type = Console.ReadLine();
            Console.Write("get the birthday: ");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            Console.Write("get the SoldDate: ");
            DateTime SoldDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("get the colour: ");
            string colour = Console.ReadLine();
            Console.Write("get the PreviousOwner: ");
            string PreviousOwner = Console.ReadLine();
            Console.Write("get the Price: ");
            double price = Convert.ToInt32(Console.ReadLine());
            petRepo.CreatePet(type, name, birthday, SoldDate, colour, PreviousOwner, price);
            Console.WriteLine("A Pet has been added to the database.");

        }

        private void EditPet()
        {
            Console.Write("get the ID : ");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.Write("get the name: ");
            string name = Console.ReadLine();
            Console.Write("specify the type: ");
            string type = Console.ReadLine();
            Console.Write("get the birthday: ");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            Console.Write("get the SoldDate: ");
            DateTime soldDate = Convert.ToDateTime(Console.ReadLine());
            Console.Write("get the colour: ");
            string colour = Console.ReadLine();
            Console.Write("get the PreviousOwner: ");
            string previousOwner = Console.ReadLine();
            Console.Write("get the Price: ");
            double price = Convert.ToInt32(Console.ReadLine());
            _petService.UpdatePet(id ,type, name, birthday, soldDate, colour, previousOwner, price);
            Console.WriteLine("A Pet has been updated to the database.");
        }
    }
}
