﻿using StoreDB.Entities;
using StoreDB.Models;
using System.Collections.Generic;

namespace StoreDB
{
    /// <summary>
    /// mapping inventory model and entity
    /// </summary>
    public interface IInventoryMapper
    {
        Inventory ParseInventory(InventoryModel inventory);
        ICollection<Inventory> ParseInventory(List<InventoryModel> inventory);
        InventoryModel ParseInventory(Inventory inventory);
        List<InventoryModel> ParseInventory(ICollection<Inventory> inventory);
    }
}
