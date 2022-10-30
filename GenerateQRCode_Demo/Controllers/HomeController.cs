using GenerateQRCode_Demo.Interfaces;
using GenerateQRCode_Demo.Models;
using IronBarCode;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing;

namespace GenerateQRCode_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly IQRGeneratorService _service;
        public HomeController(IWebHostEnvironment environment , IQRGeneratorService qRGeneratorService)
        {
            _environment = environment;
            _service = qRGeneratorService;
        }

        public IActionResult CreateQRCode()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateQRCode(Product product)
        {
            try
            {
                string imageUrl = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}"+ "/GeneratedQRCode/" + "test";
                _service.GeneratePDF(product);
                ViewBag.QrCodeUri = imageUrl;
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }      
    }
}