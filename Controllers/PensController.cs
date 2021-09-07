using Microsoft.AspNetCore.Mvc;
using pensnewStore.Models;
using pensnewStore.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pensnewStore.Controllers
{
    [Route("[controller]/[action]")]
    public class PensController : Controller
    {
        private IProductRepository _productRepository;

        public PensController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [Route("~/Pens")]  
        [Route("~/")]
        // returnbre
        public ViewResult Index()
        {
            var model =_productRepository.GetallProducts();
            return View(model);
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        /// <summary>
        ///  making sure you can use the view to view your data
        /// </summary>
        /// <returns></returns>

        // the parameter is the productid id is null use the default value of 006
        [Route("{ProductId?}")]
        public ViewResult Details(int? ProductId)
        {
           // this will be fixed
            //storing the model in the view data//
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Product = _productRepository.GetProduct(ProductId?? 006),
                 PageTitle = "Product Details"

            };
            return View(homeDetailsViewModel);
        }
         
        public string ContactUs()
        {
            return "Find out more";
        }
    }
}