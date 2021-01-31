using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemory());

            foreach (var car in carManager.GetAll())
            {
                
            }
        }
    }
}
