using Business.Abstract;
using Business.Concrete;
using Business.Constants;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Rental rental = new Rental { CarId = 3, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(3) };
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            {
                if (rentalManager.IsCarBusy(rental.CarId))
                    Console.WriteLine(Messages.CarBusy);
                else
                { 
                rentalManager.Add(rental);
                    Console.WriteLine(Messages.CarRented);
                }
            }
            





            //TestGetCarDetails();
            //TestCarAdd();

            //TestGetCarsByColorId();

            Console.WriteLine("---------------------------");

            //TestGetCarsByBrandId();

            Console.WriteLine("---------------------------");

            //TestGetColorById();

            Console.WriteLine("---------------------------");

            //TestAddBrand();


            //TestCarGetAll();
        }

        

        private static void TestGetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var c in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(c.Id + " - " + c.CarName + " - " + c.BrandName + " - " + c.ColorName + " - " + c.DailyPrice);
                }
            }
        }

        private static void TestCarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var c in carManager.GetAll().Data)
                {
                    Console.WriteLine(c.Description);
                }
            }
        }

        private static void TestAddBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { Name = "Porsche" });
        }

        private static void TestGetColorById()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var c in colorManager.GetAll().Data)
                {
                    Console.WriteLine(c.Name);
                }
            }
        }

        private static CarManager TestGetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByBrandId(1);
            if (result.Success)
            {
                foreach (var c in carManager.GetCarsByBrandId(1).Data)
                {
                    Console.WriteLine(c.Description);
                }
            }
            return carManager;
        }

        private static void TestGetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarsByColorId(1);
            foreach (var c in carManager.GetCarsByColorId(1).Data)
            {
                Console.WriteLine(c.Description);
            }
        }

        private static CarManager TestCarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { Description = "a", DailyPrice = 0 });
            Console.WriteLine("---------------------------");
            return carManager;
        }
    }
}
