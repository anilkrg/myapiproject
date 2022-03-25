using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myapiproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using myapiproject.Contract.Response;

namespace myapiproject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public AppDBContext DBContext { get; }
        private ApiResponse response = new ApiResponse();
        public ProductsController(AppDBContext dBContext)
        {
            DBContext = dBContext;
        }
        [HttpGet]
        [Route("GetProducts")]
        public IActionResult GetProducts()
        {
            var products = DBContext.Products.ToList();
            response.Ok = true;
            response.message = "Product List found !";
            response.Status = 200;
            response.Data = products;
            return Ok(response);
        }
        [HttpPost]
        [Route("CreateProduct")]
        public IActionResult CreateProduct(Products products )
        {
            try
            {
                DBContext.Products.Add(products);
                DBContext.SaveChanges();
                response.Ok = true;
                response.message = "Product created sucessfully !";
                response.Status = 200;
                response.Data = products;
                return Ok(response);
            }
            catch (Exception)
            {
                response.message = "Product List found !";
                response.Status = 500;
                response.Ok = false;
            }
            return Ok(response);

        }
    }
}
