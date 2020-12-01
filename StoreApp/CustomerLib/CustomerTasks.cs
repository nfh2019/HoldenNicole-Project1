﻿using StoreDB.Models;
using StoreUI;
using System;

namespace CustomerLib
{
    public delegate void CustomerDel();
    public class CustomerTasks : ICustomerOperations
    {
        public event CustomerDel placedOrder;
        public DBRepo dBRepo;

        /// <summary>
        /// section used to allow customer to place order
        /// </summary>
        public void PlaceOrder(OrderModel order)
        {
            Console.WriteLine("Opened Cart");
            dBRepo.PlaceOrder(order);
            Console.WriteLine("Hope you found everything you were looking for today!");
            Console.WriteLine("Come back to Sports Authenticated soon!");
            OnPlacedOrder();// call to notify all subscribers
        }
        // make sure events are binded to handlers
        public void OnPlacedOrder()
        {
            if (placedOrder != null)
            {
                placedOrder();// raises event
            }
        }
        /// <summary>
        /// retrieves products in cart
        /// </summary>
        public void GetProducts(int id)
        {
            Console.WriteLine("Getting items in your cart");
            dBRepo.GetAllProductsInCartByCartID(id);
        }

        public event CustomerDel OrderHistory;
        /// <summary>
        /// section used to retrieve customer order history
        /// </summary>
        public void orderHistory()
        {
            Console.WriteLine("Retrieving your order history");
            Console.WriteLine("Order history acquired hit enter to see it:");
            OrderHistory();
        }
        /// <summary>
        /// checking for bound events
        /// </summary>
        public void OnOrderHistory()
        {
            if (OrderHistory != null)
            {
                OrderHistory();
            }
        }
        /// <summary>
        /// retrieves customer order history
        /// </summary>
        public void CustomerOrderHistory(CustomerModels customer)
        {
            Console.WriteLine("Getting Order History for you");
            dBRepo.GetAllOrdersByCustomerIDDateAscending(customer.ID); //return list "orderHistory"
        }

    }
}