﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelExpertsData
{
    /// <summary>
    /// repository of methods to work  with ProductsSuppliers table
    /// </summary>
    public static class ProductsSupplierDB
    {
        /// <summary>
        /// retrieves ProductsSupplier data
        /// </summary>
        /// <returns>list of lightweight product supplier objects</returns>
        public static List<ProductsSupplierDTO> GetProductsSuppliers()
        {
            List<ProductsSupplierDTO> productsSupplier = new List<ProductsSupplierDTO>();// empty list
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                productsSupplier = db.ProductsSuppliers.
                    OrderBy(p => p.ProductSupplierId).
                    Select(p => new ProductsSupplierDTO()
                    {
                        ProductSupplierId = p.ProductSupplierId,
                        ProductId = p.ProductId,
                        SupplierId = p.SupplierId,
                    }).ToList();
            }
            return productsSupplier;
        }

        /// <summary>
        /// find product supplier by primary key value
        /// </summary>
        /// <param name="productSupplierId">id of the product supplier to find</param>
        /// <returns>found product supplier or null</returns>
        public static ProductsSupplier FindProductsSupplier(int productSupplierId)
        {
            ProductsSupplier productSupplier = null;
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                productSupplier = db.ProductsSuppliers.Find(productSupplierId);
            }
            return productSupplier;
        }

        /// <summary>
        /// get list of product supplier codes
        /// </summary>
        /// <returns> list of product supplier IDs</returns>
        public static List<int> GetProductSupplierId()
        {
            List<int> codes = new List<int>();
            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                codes = db.ProductsSuppliers.Select(p => p.ProductSupplierId).ToList();
            }
            return codes;
        }

        /// <summary>
        /// adds new product
        /// </summary>
        /// <param name="newProd">product to add</param>
        public static void AddProductsSupplier(ProductsSupplier newProd)
        {
            if (newProd != null)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    db.ProductsSuppliers.Add(newProd);
                    db.SaveChanges();
                }
            }
        }

        /// <summary>
        ///  update existing product with new data 
        /// </summary>
        /// <param name="newProdData">new product data</param>
        public static void UpdateProductsSupplier(ProductsSupplier newProdSupData)
        {
            if (newProdSupData != null)
            {
                using (TravelExpertsContext db = new TravelExpertsContext())
                {
                    // find the product to update in this context
                    ProductsSupplier prodSup = db.ProductsSuppliers.Find(newProdSupData.ProductSupplierId);
                    if (prodSup != null) // it still exists
                    {
                        // code does not  change
                        prodSup.ProductId = newProdSupData.ProductId;
                        prodSup.SupplierId = newProdSupData.SupplierId;
                        db.SaveChanges();
                    }
                }
            }
        }

        public static string FindProduct(int productSupplierId)
        {
            string product = null;
            ProductsSupplier productSupplier = FindProductsSupplier(productSupplierId);
            int prodId = Convert.ToInt16(productSupplier.ProductId);

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                product = db.Products.FirstOrDefault(p => p.ProductId == prodId).ProdName;
            }

            return product;
        }

        public static string FindSupplier(int productSupplierId)
        {
            string supplier = null;
            ProductsSupplier productSupplier = FindProductsSupplier(productSupplierId);
            int supId = Convert.ToInt16(productSupplier.SupplierId);

            using (TravelExpertsContext db = new TravelExpertsContext())
            {
                supplier = db.Suppliers.FirstOrDefault(s => s.SupplierId == supId).SupName;
            }

            return supplier;
        }
    }
}
