using AspNetMVC.LabExercise1.Models;
using System.Collections.Generic;

namespace AspNetMVC.LabExercise1.Services
{
    public class ProductService
    {
        private List<Product> products;
        public ProductService()
        {
            products = new List<Product>();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Honda Brio",
                Description = "BrioHonda Brio 2022 is a 5 Seater Hatchback available " +
                "between a price range of ₱601,000 - ₱735,000 in the Philippines. " +
                "It is available in 5 colors, 4 variants, 1 engine, and 2 " +
                "transmissions option: Manual and CVT in the Philippines. " +
                "It has a ground clearance of 137 mm and dimensions is " +
                "3815 mm L x 1680 mm W x 1485 mm H. Over 45 users have reviewed " +
                "Brio on basis of Features, Mileage, seating comfort, and engine performance. " +
                "The lowest monthly installment starts from ₱31,000 (for 60 months). " +
                "Brio top competitors are Wigo, Raize, Mirage and Jazz.",
                Quantity = 20,
                Price = 735_000M
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Toyota Hilux",
                Description = "Toyota Hilux 2022 is a 3 and 5 Seater Pickup Trucks available " +
                "between a price range of ₱843,000 - ₱1.985 Million in the Philippines. " +
                "It is available in 5 colors, 14 variants, 2 engine, and 2 transmissions " +
                "option: Manual and Automatic in the Philippines. The Hilux dimensions is " +
                "5320 mm L x 1900 mm W x 1815 mm H. Over 45 users have reviewed Hilux on basis " +
                "of Features, Mileage, seating comfort, and engine performance. " +
                "The lowest monthly installment starts from ₱189,400 (for 60 months). " +
                "Hilux top competitors are Navara, Strada, Ranger Raptor and D-Max.",
                Quantity = 7,
                Price = 1_985_000M
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Toyota Innova",
                Description = "InnovaToyota Innova 2022 is a 8 Seater MPV available " +
                "between a price range of ₱1.186 - ₱1.739 Million in the Philippines. " +
                "It is available in 5 colors, 6 variants, 1 engine, and 2 transmissions " +
                "option: Manual and Automatic in the Philippines. The Innova dimensions " +
                "is 4735 mm L x 1830 mm W x 1795 mm H. Over 52 users have reviewed Innova " +
                "on basis of Features, Mileage, seating comfort, and engine performance. " +
                "The lowest monthly installment starts from ₱114,000 (for 60 months). " +
                "Innova top competitors are Avanza, Rush, Fortuner and Okavango.",
                Quantity = 11,
                Price = 1_739_000M
            });
            products.Add(new Product()
            {
                Id = 4,
                Name = "Ford Mustang",
                Description = "Ford Mustang 2022 is a 4 Seater Coupe available " +
                "between a price range of ₱2.948 - ₱7.76 Million in the Philippines. " +
                "It is available in 8 colors, 4 variants, 3 engine, and 1 transmissions " +
                "option: Automatic in the Philippines. The Mustang dimensions is " +
                "4784 mm L x 2080 mm W x 1391 mm H. Over 42 users have reviewed " +
                "Mustang on basis of Features, Mileage, seating comfort, " +
                "and engine performance. The lowest monthly installment starts " +
                "from ₱258,000 (for 60 months). Mustang top competitors are Camaro, " +
                "MX-5 RF, 370Z and BRZ 2022.",
                Quantity = 3,
                Price = 7_760_000M
            });
            products.Add(new Product()
            {
                Id = 5,
                Name = "BMW X4BMW",
                Description = "BMW X4 2022 is a 5 Seater SUV available at a price of " +
                "₱9.69 Million in the Philippines. The X4 dimensions is " +
                "4758 mm L x 2138 mm W x 1620 mm H. Over 7 users have reviewed " +
                "X4 on basis of Features, Mileage, seating comfort, and engine " +
                "performance. X4 top competitors are X7, F-PACE, Range Rover Sport and LX.",
                Quantity = 3,
                Price = 9_960_000M
            });
        }

        public decimal GetGrandTotal()
        {
            decimal grandTotal = 0;
            foreach (var product in products)
            {
                grandTotal += product.TotalAmount;
            }
           return grandTotal;
        }
        public List<Product> GetCatalog()
        {
            return products;
        }
    }
}
