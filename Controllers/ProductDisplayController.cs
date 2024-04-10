using CloudDevelopment.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CloudDevelopment.Controllers
{
    public class ProductDisplayController : Controller
    {
        public IActionResult Index(int userID)
        {
            // Get all products from the database
            List<ProductDisplayModel> products = GetProductsFromDatabase();

            // Pass products to the view
            ViewBag.Products = products;

            // Pass userID to the view (if needed)
            ViewData["userID"] = userID;

            return View();
        }

        // Method to fetch products from the database
        private List<ProductDisplayModel> GetProductsFromDatabase()
        {
            // Implement your logic to fetch products from the database
            // For demonstration, let's assume we have a list of products
            List<ProductDisplayModel> products = new List<ProductDisplayModel>
            {
                new ProductDisplayModel { ProductID = 1, ProductName = "Product 1", ProductPrice = 10.99m, ProductCategory = "Category 1", ProductAvailability = true },
                new ProductDisplayModel { ProductID = 2, ProductName = "Product 2", ProductPrice = 20.99m, ProductCategory = "Category 2", ProductAvailability = false },
                // Add more products as needed
            };

            return products;
        }
    }
}

