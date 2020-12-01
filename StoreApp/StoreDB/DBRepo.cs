using Microsoft.EntityFrameworkCore;
using StoreDB;
using StoreDB.Entities;
using StoreDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreUI
{
    public class DBRepo : ICustomerRepo, ILocationRepo, ICartRepo, IOrderRepo, IStoreRepo
    {
        private readonly ixdssaucContext context;
        private readonly IMapper mapper;
        public IMapper Mapper;

        public ixdssaucContext Context { get; set; }

        public DBRepo(ixdssaucContext storeContext, IMapper mapper)
        {
            this.context = storeContext;
            this.mapper = mapper;
        }

        public DBRepo()
        {
        }

        #region cart methods
        public void AddCart(CartsModel cartsModel)
        {
            context.Carts.Add(mapper.ParseCarts(cartsModel));
            context.SaveChanges();
        }
        public CartsModel GetCartID(int id)
        {
            return mapper.ParseCarts(
                context.Carts
                .First(c => c.Customer == id)
                );
        } 
        public void AddProductToCart(CartItemModel cartItem)
        {
            context.CartItems.Add(mapper.ParseCartItem(cartItem));
            context.SaveChanges();
        }
        
        public LineItemModel AddToOrder(LineItemModel cartItem)
        {
            context.LineItems.Add(mapper.ParseLineItem(cartItem));
            context.SaveChanges();
            return null;
        }
        public void UpdateCartItems(CartItemModel cartItem)
        {
            context.CartItems.Update(mapper.ParseCartItem(cartItem));
            context.SaveChangesAsync();
        }

        public void DeleteProductInCart(CartItemModel cartItems)
        {
            context.CartItems.Remove(mapper.ParseCartItem(cartItems));
            context.SaveChanges();
        }
        public void DeleteCart(CartsModel carts)
        {
            context.Carts.Remove(mapper.ParseCarts(carts));
            context.SaveChanges();
        }
        public List<CartItemModel> GetAllProductsInCartByCartID(int id)
        {
            List<CartItemModel> cart = (List<CartItemModel>)context.CartItems.Where(i => i.Cart == id);
            List<CartItemModel> carts = (List<CartItemModel>)mapper.ParseCartItem(cart);
            return carts;
        } 
        public List<LineItemModel> GetAllProductsInOrderByID(int id)
        {
            return mapper.ParseLineItem(
                context.LineItems
                .Where(i => i.Id == id)
                .ToList());
        }
        public void PlaceOrder(OrderModel order)
        {
            context.Orders.Add(mapper.ParseOrder(order));
            context.SaveChanges();
        }

        #endregion

        #region inventory methods
        public ProductModel GetProductByID(int id)
        {
            return mapper.ParseProducts(
                context.Products
                .First(i => i.Id == id)
                );
        }
        public List<ProductModel> ViewAllProductsPriceHighToLow(InventoryModel inventory)
        {
            return mapper.ParseProducts(
                context.Products
                .Where(i => i.Id == inventory.productID)
                .OrderBy(i => i.Price)
                .ToList());
        }
        public List<ProductModel> ViewAllProductsPriceLowToHigh(InventoryModel inventory)
        {
            return mapper.ParseProducts(
                context.Products
                .Where(i => i.Id == inventory.productID)
                .OrderByDescending(i => i.Price)
                .ToList());
        }
        public List<InventoryModel> ViewAllInventoryAtLocationSortByID(int id)
        {
            return mapper.ParseInventory(
                context.Inventory
                .Where(i => i.Location == id)
                .OrderBy(i => i.Product)
                .ToList()
            );
        }
        public List<InventoryModel> ViewAllInventoryAtLocationSortByQuantityAscending(int id)
        {
            return mapper.ParseInventory(
                context.Inventory
                .Where(i => i.Location == id)
                .OrderBy(i => i.Quantity)
                .ToList()
            );
        }
        public List<InventoryModel> ViewAllInventoryAtLocationSortByQuantityDescending(int id)
        {
            return mapper.ParseInventory(
                context.Inventory
                .Where(i => i.Location == id)
                .OrderByDescending(i => i.Quantity)
                .ToList()
            );
        }

        public void AddProductToLocation(InventoryModel inventory)
        {
            ProductModel item = new ProductModel();
            LocationModel location = new LocationModel();
            context.Products.Add(mapper.ParseProducts(item));
            context.Locations.Add(mapper.ParseLocation(location));
            context.SaveChanges();
        }
        public void DeleteProductAtLocation(InventoryModel inventory)
        {
            ProductModel item = new ProductModel();
            LocationModel location = new LocationModel();
            context.Products.Remove(mapper.ParseProducts(item));
            context.Locations.Remove(mapper.ParseLocation(location));
            context.SaveChanges();
        }
        #endregion

        #region customer methods
        public CustomerModels GetCustomerByID(int id)
        {
            try
            {
                var customers = context.Customer.First(c => c.Id == id);
                CustomerModels customer = mapper.ParseCustomer(customers);
                return customer;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                System.Console.WriteLine("This customer id does not exist try again");
            }
            return null;
        }

        public CustomerModels GetCustomerByName(string name)
        {
                return mapper.ParseCustomer(
                    context.Customer
                    .First(c => c.Username == name)
                );
            
        }

        public CustomerModels GetCustomerByEmail(string email)
        {
            try
            {
                return mapper.ParseCustomer(
                    context.Customer
                    .FirstOrDefault(c => c.Email == email)
                );
            }
            catch (InvalidOperationException)
            {
                System.Console.WriteLine("This email is not registered try again");
            }
            return null;
        }

        public void AddCustomer(CustomerModels customer)
        {
            context.Customer.Add(mapper.ParseCustomer(customer));
            context.SaveChanges();
        }

        public List<CustomerModels> GetAllCustomersOrderByUsername()
        {
            return mapper.ParseCustomer(
                context.Customer
                .OrderBy(i => i.Username)
                .ToList()
            );
        }

        public List<CustomerModels> GetAllCustomersOrderByOrders()
        {
            return mapper.ParseCustomer(
                context.Customer
                .OrderBy(i => i.Orders)
                .ToList()
            );
        }
        public List<OrderModel> GetAllOrdersByCustomerIDDateAscending(int id)
        {
            try
            {
                return mapper.ParseOrder(
                    context.Orders
                    .Where(c => c.Customer == id)
                    .OrderBy(c => c.OrderDate)
                    .ToList()
                );
            }
            catch (System.InvalidOperationException)
            {
                System.Console.WriteLine("This customer does not have any order history yet");
                return null;
            }
        }
        public OrderModel GetOrderByID(LocationModel location, CustomerModels customer)
        {
            return mapper.ParseOrder(
                context.Orders
                .First(o => o.Location == location.ID && o.Customer == customer.ID));
        }
        public List<OrderModel> GetAllOrdersByCustomerIDDateDescending(int id)
        {
            try
            {
                return mapper.ParseOrder(
                    context.Orders
                    .Where(c => c.Customer == id)
                    .OrderByDescending(c => c.OrderDate)
                    .ToList()
                );
            }
            catch (System.InvalidOperationException)
            {
                System.Console.WriteLine("This customer does not have any order history yet");
                return null;
            }
        }

        public void AddOrder(OrderModel order)
        {
            context.Orders.Add(mapper.ParseOrder(order));
            context.SaveChanges();
        }

        public List<OrderModel> GetAllOrdersByCustomerIDPriceAscending(int id)
        {
            try
            {
                return mapper.ParseOrder(
                    context.Orders
                    .Where(c => c.Customer == id)
                    .OrderBy(c => c.Price)
                    .ToList()
                );
            }
            catch (System.InvalidOperationException)
            {
                System.Console.WriteLine("This customer does not have any order history yet");
                return null;
            }
        }
        public List<OrderModel> GetAllOrdersByCustomerIDPriceDescending(int id)
        {
            try
            {
                return mapper.ParseOrder(
                    context.Orders
                    .Where(c => c.Customer == id)
                    .OrderByDescending(c => c.Price)
                    .ToList()
                );
            }
            catch (System.InvalidOperationException)
            {
                System.Console.WriteLine("This customer does not have any order history yet");
                return null;
            }
        }
        public List<OrderModel> GetAllOrdersByCustomerID(int id)
        {
            try
            {
                List<OrderModel> order = (List<OrderModel>)context.Orders.Where(c => c.Customer == id);
                List<OrderModel> orders = (List<OrderModel>)ParseOrder(order);
                return orders;
            }
            catch (System.InvalidOperationException)
            {
                System.Console.WriteLine("This customer does not have any order history yet");
                return null;
            }
        }

        private List<OrderModel> ParseOrder(List<OrderModel> order)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region location methods
        public ManagerModel GetManagerByName(string name)
        {
            return mapper.ParseManager(
                context.Managers
                .First(m => m.Username == name));
        }
        public LocationModel GetLocationByID(int id)
        {
            return mapper.ParseLocation(
                context.Locations
                .First(l => l.Id == id)
            );
        }
        public LocationModel GetLocationByName(string name)
        {
            return mapper.ParseLocation(
                context.Locations
                .First(l => l.Name == name)
            );
        }
        public List<LocationModel> GetAllLocations()
        {
            return mapper.ParseLocation(
                context.Locations
                .ToList()
            );
        }
        public List<OrderModel> GetAllOrdersByLocationID(int id)
        {
            return mapper.ParseOrder(
                    context.Orders
                    .Where(c => c.Location == id)
                    .ToList()
                );
        }
        public List<OrderModel> GetAllOrdersByLocationIDDateDescending(int id)
        {
            return mapper.ParseOrder(
                context.Orders
                .Where(l => l.Location == id)
                .OrderByDescending(l => l.OrderDate)
                .ToList()
            );
        }
        public List<OrderModel> GetAllOrdersByLocationIDDateAscending(int id)
        {
            return mapper.ParseOrder(
                context.Orders
                .Where(l => l.Location == id)
                .OrderBy(l => l.OrderDate)
                .ToList()
            );
        }
        public List<OrderModel> GetAllOrdersByLocationIDPriceAscending(int id)
        {
            return mapper.ParseOrder(
                context.Orders
                .Where(l => l.Location == id)
                .OrderBy(l => l.Price)
                .ToList()
            );
        }
        public List<OrderModel> GetAllOrdersByLocationIDPriceDescending(int id)
        {
            return mapper.ParseOrder(
                context.Orders
                .Where(l => l.Location == id)
                .OrderByDescending(l => l.Price)
                .ToList()
            );
        }

        public List<InventoryModel> ViewAllProductsAtLocation(int id)
        {
            return mapper.ParseInventory(
                context.Inventory
                .Where(i => i.Location == id)
                .ToList()
            );
        }
        #endregion
    }
}