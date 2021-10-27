using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Visitor - Start\n");

            WareHouse wareHouse = Initialize();

            Console.WriteLine("\n----------------InformationVisitor:");
            InformationVisitor informationVisitor = new InformationVisitor();
            foreach (Shelf shelf in wareHouse.Shelves)
            {
                shelf.Accept(informationVisitor);
            }

            Console.WriteLine(informationVisitor.StringBuilder.ToString());

            Console.WriteLine("\n----------------ProductCounterVisitor:");

            ProductCounterVisitor productCounterVisitor = new ProductCounterVisitor();
            foreach (Shelf shelf in wareHouse.Shelves)
            {
                shelf.Accept(productCounterVisitor);
            }

            Console.WriteLine($"NoteBooks: {productCounterVisitor.Notebooks}");
            Console.WriteLine($"Smartphones: {productCounterVisitor.Smartphones}");
            Console.WriteLine($"Tvs: {productCounterVisitor.Tvs}");

            Console.WriteLine("\nVisitor - End");
        }

        public static WareHouse Initialize()
        {
            WareHouse wareHouse = new WareHouse();

            Shelf shelf_A = new Shelf("Shelf_A");
            shelf_A.Products.Add(new Product("Samsung 500", 100, ProductType.SMARTPHONE));
            shelf_A.Products.Add(new Product("IPhone 10", 800, ProductType.SMARTPHONE));
            shelf_A.Products.Add(new Product("Panasonic A", 250, ProductType.TV));

            Shelf shelf_B = new Shelf("Shelf_B");
            shelf_B.Products.Add(new Product("Samsung A13", 100, ProductType.NOTEBOOK));
            shelf_B.Products.Add(new Product("Lenovo Thinkpad", 400, ProductType.NOTEBOOK));

            wareHouse.Shelves.Add(shelf_A);
            wareHouse.Shelves.Add(shelf_B);

            return wareHouse;
        }
    }
}
