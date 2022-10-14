using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Coffee_Culture.Data;

namespace Coffee_Culture.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Coffee_CultureContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Coffee_CultureContext>>()))
            {
                if (context.CoffeeBean.Any())
                {
                    return;
                }
                context.CoffeeBean.AddRange(
                    new CoffeeBean
                    {
                        Types_Of_Coffee = "Arabica Coffee",
                        Manufacture_Date = DateTime.Parse("2022-07-14"),
                        Production_Country = "Brazil",
                        Roasting = "Dark Roast",
                        Price = 12.99M,
                        Description_Of_Product = "It is Arabica Coffee, This coffee's origin is Ethopia," +
                        "but now the foremost production Countries are Brazil, Guatemala, Honduras, Columbia and Peru.",
                        Packaging = "Whole Beans",
                        Rating = 4

                    },

                    new CoffeeBean
                    {
                        Types_Of_Coffee = "Robusta Coffee",
                        Manufacture_Date = DateTime.Parse("2022-06-04"),
                        Production_Country = "West African",
                        Roasting = "Lightly Roast",
                        Price = 14.99M,
                        Description_Of_Product = "This Coffee grown in Africa, Indonesia and India it is the second most consumed coffee in world",
                        Packaging = "Grounded Coffee",
                        Rating = 3
                    },

                    new CoffeeBean
                    {
                        Types_Of_Coffee = "Liberica Coffee",
                        Manufacture_Date = DateTime.Parse("2022-08-16"),
                        Production_Country = "Malasiya",
                        Roasting = "Sinter Roasting",
                        Price = 09M,
                        Description_Of_Product = "This Coffee grown in Africa and Malasiya, it is not popular Coffee Beans Around the Globe ",
                        Packaging = "Powedered Coffee",
                        Rating = 1
                    },

                    new CoffeeBean
                    {
                        Types_Of_Coffee = "Excelsa Coffee",
                        Manufacture_Date = DateTime.Parse("2022-03-09"),
                        Production_Country = "Southeast Asia",
                        Roasting = " Brisket Roast",
                        Price = 10M,
                        Description_Of_Product = "This Coffee grown in Southeast Asia, Vietnam, Philippines and India, This is also not so preffered coffee. ",
                        Packaging = "Whole Bean Coffee",
                        Rating = 2

                    },

                    new CoffeeBean
                    {
                        Types_Of_Coffee = "Peaberry Coffee",
                        Manufacture_Date = DateTime.Parse("2022-02-03"),
                        Production_Country = "Tanzania",
                        Roasting = "Tri-tip Roast",
                        Price = 11.99M,
                        Description_Of_Product = "This Coffee grown in Tanzania, this coffee is a full bodied coffee with a chocolatry aroma and a Wine-like finish.",
                        Packaging = "Powdered Coffee",
                        Rating = 3
                    },

                    new CoffeeBean
                    {
                        Types_Of_Coffee = "Mocha Java Coffee",
                        Manufacture_Date = DateTime.Parse("2022-08-09"),
                        Production_Country = "Indonesia",
                        Roasting = "Rib Roast",
                        Price = 7.99M,
                        Description_Of_Product = "Mocha java is the World's oldest coffee blend, combining two of the best premium coffee beans with complementary tasting type.",
                        Packaging = "Grounded Coffee",
                        Rating = 2
                    },

                    new CoffeeBean
                    {
                        Types_Of_Coffee = "Sulawesi Toraja Coffee",
                        Manufacture_Date = DateTime.Parse("2022-05-02"),
                        Production_Country = "Indonesia",
                        Roasting = "Clod Roast",
                        Price = 19.99M,
                        Description_Of_Product = "This coffee beans are spicy and flavourful. it tends to land on the warmer side of spices.",
                        Packaging = "Grounded Coffee",
                        Rating = 3
                    },

                    new CoffeeBean
                    {
                        Types_Of_Coffee = "Hawaii Kona Coffee",
                        Manufacture_Date = DateTime.Parse("2022-06-08"),
                        Production_Country = "Hawaii",
                        Roasting = "Pot Roast",
                        Price = 16M,
                        Description_Of_Product = "This cultivated on the slopes of hualalai and Mauna Loa in north and south Kona districts of the Bog island and Hawaii.",
                        Packaging = "Powdered Coffee",
                        Rating = 1
                    },

                    new CoffeeBean
                    {
                        Types_Of_Coffee = "Nicaraguan Coffee",
                        Manufacture_Date = DateTime.Parse("2022-09-07"),
                        Production_Country = "West African",
                        Roasting = "Dark Roast",
                        Price = 13.19M,
                        Description_Of_Product = "This plants primarily consist of Arabica varieties leading to an overall higher quality of the beans from the regions.",
                        Packaging = "Whole bean Coffee",
                        Rating = 4
                    },
                     new CoffeeBean
                     {
                         Types_Of_Coffee = "Ethiopian Harrar Coffee",
                         Manufacture_Date = DateTime.Parse("2022-07-06"),
                         Production_Country = "Southern Ethiopia",
                         Roasting = "Lightly Roast",
                         Price = 06.99M,
                         Description_Of_Product = "These are one of the oldest still in production. this beans are harvested and processed by hand not only" +
                         "this bean used for coffee but the shells are also used to make Ethiopian tea.",
                         Packaging = "Grounded Coffee", 
                         Rating = 4
                     }

                );
                context.SaveChanges();
            }
        }
    }
}
