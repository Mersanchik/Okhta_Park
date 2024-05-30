using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParkEntities _db = new ParkEntities();
            foreach (var dish in _db.Employees)
            {
                string path = @"F:\Производственная практика\Брюханова" + dish.PhotoPath; // Путь к картинкам + их названия
                byte[] imageInBytes = System.IO.File.ReadAllBytes(path); // в массив байт
                dish.Image = imageInBytes; // массив байт в таблицу
            }
            _db.SaveChanges();

        }
    }
}
