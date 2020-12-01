﻿using StoreDB.Entities;
using StoreDB.Models;
using System.Collections.Generic;

namespace StoreDB
{
    public interface ILineItemsMapper
    {
        LineItems ParseLineItem(LineItemModel lineItem);
        ICollection<LineItems> ParseLineItem(List<LineItemModel> lineItem);
        LineItemModel ParseLineItem(LineItems lineItem);
        List<LineItemModel> ParseLineItem(ICollection<LineItems> lineItem);
    }
}
