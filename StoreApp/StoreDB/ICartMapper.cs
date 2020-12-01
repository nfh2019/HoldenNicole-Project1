﻿using StoreDB.Entities;
using StoreDB.Models;
using System.Collections.Generic;

namespace StoreDB
{
    /// <summary>
    /// maps cart in model and entities
    /// </summary>
    public interface ICartMapper
    {
        CartsModel ParseCarts(Carts carts);
        Carts ParseCarts(CartsModel carts);
        ICollection<Carts> ParseCarts(List<CartsModel> carts);
        List<CartsModel> ParseCarts(ICollection<Carts> carts);
    }
}
