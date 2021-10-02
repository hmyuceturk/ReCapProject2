using Business.Abstract;
using Business.Concrete;
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
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var c in carManager.GetCarDetails())
            {
                Console.WriteLine(c.Id+" - "+c.CarName +" - "+ c.BrandName + " - "+ c.ColorName + " - "+ c.DailyPrice);
            }

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

        private static void TestCarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
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
            foreach (var c in colorManager.GetAll())
            {
                Console.WriteLine(c.Name);
            }
        }

        private static CarManager TestGetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var c in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine(c.Description);
            }

            return carManager;
        }

        private static void TestGetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var c in carManager.GetCarsByColorId(1))
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
