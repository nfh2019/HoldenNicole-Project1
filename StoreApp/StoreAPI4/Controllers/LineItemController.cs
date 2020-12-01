﻿using CustomerLib;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using OrdersLib;
using StoreDB;
using StoreDB.Models;
using System;
using System.Collections.Generic;

namespace StoreAPI4.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("_allowed")]
    public class LineItemController : ControllerBase
    {
        private readonly CartItemService cartItemService;
        private readonly OrdersService ordersService;
        private readonly CustomerService customerService;
        
        public LineItemController(CartItemService cartItemService, OrdersService ordersService, CustomerService customerService)
        {
            this.cartItemService = cartItemService;
            this.ordersService = ordersService;
            this.customerService = customerService;
        }
        [HttpPost("add")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult AddLineItem(LineItemModel lineItem)
        {
            try
            {
                ordersService.AddToOrder(lineItem);
                int id = lineItem.ID;
                return CreatedAtAction("AddLineItem", lineItem);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("get/{id}")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult GetAllLineItemsByOrder(int id)
        {
            try
            {
                List<LineItemModel> items = ordersService.GetAllProductsInOrderByID(id);
                List<LineItemModel> item = items;
                return Ok(items);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
