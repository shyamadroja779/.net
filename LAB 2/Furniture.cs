using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    internal class Furniture
    {
        public string material;
        public decimal price;

        public void SetFurnitureDetails()
        {
            Console.Write("Enter material: ");
            material = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter price: ");
            price = Convert.ToDecimal(Console.ReadLine());
        }

        public void DisplayFurnitureDetails()
        {
            Console.WriteLine($"Material: {material}");
            Console.WriteLine($"Price: {price:N2}");
        }
    }
        class Table : Furniture
        {
            public double Height;
            public double surface_area;

            public void SetTableDetails()
            {
                SetFurnitureDetails();

                Console.Write("Enter height: ");
                Height = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter surface area: ");
                surface_area = Convert.ToDouble(Console.ReadLine());
            }

            public void DisplayTableDetails()
            {
                DisplayFurnitureDetails();
                Console.WriteLine($"Height: {Height:N2}");
                Console.WriteLine($"Surface Area: {surface_area:N2}");
            }
        }
    }

