﻿using System.Collections.Generic;
using WiredBraingCoffee.DataAccess.Model;

namespace WiredBraingCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop
            {
                Location = "Frankfurt",
                BeansInStockInKg = 107,
                PaperCupsInStock = 350
            };
            yield return new CoffeeShop
            {
                Location = "Frieburg",
                BeansInStockInKg = 23,
                PaperCupsInStock = 250
            };
            yield return new CoffeeShop
            {
                Location = "Munich",
                BeansInStockInKg = 56,
                PaperCupsInStock = 427
            };
        }
    }
}
