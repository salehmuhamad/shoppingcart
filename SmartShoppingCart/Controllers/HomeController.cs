using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SmartShoppingCart.Controllers
{
    public class HomeController : ApiController
    {
        [Route("api/GetProducts")]
        [HttpGet]
        public List<Product> GetProducts()
        {
            var db = new ShoppingCartEntities();
            db.Configuration.ProxyCreationEnabled = false;

            return db.Products.ToList();
        }
    }
}
