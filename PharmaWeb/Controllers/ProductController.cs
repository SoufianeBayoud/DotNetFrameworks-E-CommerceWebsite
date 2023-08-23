using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PharmaWeb.Data;
using PharmaWeb.Models;
using PharmaWeb.Models.ViewModels;
using PharmaWeb.Service;
using System;
using System.IO;
using System.Web;

namespace PharmaWeb.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        private readonly ApplicationDbContext dbContext;
        private readonly IWebHostEnvironment webHostEnvironment;


        public ProductController(IProductService productService, IWebHostEnvironment hostEnvironment, ApplicationDbContext context)
        {
            _service = productService;
            webHostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            return View(_service.GetAllProducts());
        }

        [AllowAnonymous]
        public IActionResult Shop()
        {
            return View(_service.GetAllProducts());
        }


        [Authorize(Policy = "AdminOnly")]
        public IActionResult Create()
        {
            CreateProductCommand cmd = new CreateProductCommand();
            PopulateViewModel(cmd);

            return View(cmd);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "AdminOnly")]
        //Create a new product
        public IActionResult Create(CreateProductCommand model)
        {
            if (ModelState.IsValid)
            {
                model.ImagePath = $"/images/Product/{UploadedFile(model)}";
                int id = _service.CreateProduct(model);
                return RedirectToAction("Succes");

            }

            PopulateViewModel(model);
            return View(model);
        }

        public IActionResult Succes()
        {
            return View();
        }


        [HttpGet]
        [AllowAnonymous]
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product pr = _service.GetProductById(id.Value);

            if (pr == null)
            {
                return NotFound();
            }

            return View(pr);
        }

 
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "AdminOnly")]
        //Delete a product
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            _service.DeleteProduct(id.Value);

            return RedirectToAction("Index");
        }

        [Authorize(Policy = "AdminOnly")]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var updateCommand = _service.GetProductForUpdate(id.Value);

            if (updateCommand == null)
            {
                return NotFound();
            }

            PopulateViewModel(updateCommand);

            return View(updateCommand);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy = "AdminOnly")]
        //Edit a product
        public IActionResult Edit(int id, UpdateProductCommand cmd)
        {
            if (id != cmd.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                cmd.ImagePath = $"/images/Product/{UploadedFile(cmd)}";
                _service.UpdateProduct(cmd);
                return RedirectToAction("Index");
            }

            PopulateViewModel(cmd);

            return View(cmd);
        }

        [AllowAnonymous]
        //Search a specific product
        public IActionResult Search(string searchString, int? productCategory, bool productNumberFilter, bool nameFilter)
        {
            var categories = _service.GetAllCategory();
            var product = _service.GetAllProducts();


            if (!string.IsNullOrEmpty(searchString))
            {
                if (productNumberFilter == true)
                {
                    product = product.Where(x => x.Productnumber.Contains(searchString));
                }
                if (nameFilter == true)
                {
                    product = product.Where(x => x.Name.Contains(searchString));
                }
                if (productNumberFilter == true && nameFilter == true)
                {
                    product = product.Where(x => x.Name.Contains(searchString) || x.Productnumber.Contains(searchString));
                }
                else 
                {
                    product = product.Where(x => x.Name.Contains(searchString));
                }
            }

            if (productCategory != null)
            {
                product = product.Where(x => x.Category.Id == productCategory);
            }

            var ProductCategoryVM = new SearchProductModel()
            {
                Categories = new SelectList(categories, nameof(Category.Id), nameof(Category.Name)),
                Products = product.ToList()
            };

            return View(ProductCategoryVM);
        }


        // Methode to upload a file
            private string UploadedFile(EditProductBase model)
            {
            string uniqueFileName = null;

            if (model.ProfileImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images", "Product");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProfileImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
            }

        private void PopulateViewModel(EditProductBase editProduct)
        {
            editProduct.Categorys = _service.GetAllCategory();
        }

    }
}
