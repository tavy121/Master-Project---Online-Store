using BookStore.Models.DTOs.VM;
using BookStore.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Web.Controllers
{
    [Route("[Controller]")]
    public class ProductTypeController : Controller
    {
        private readonly IProductTypeService service;

        public ProductTypeController(IProductTypeService service)
        {
            this.service = service;
        }


        //pt read
        [HttpGet]
        public IActionResult Index()
        {
            var list = service.GetAllProductType();
            return View(list);
        }

        //create
        [HttpGet]
        [Route("New")]
        public IActionResult New()
        {
            var dto = new ProductTypeVM();
            return View(dto);
        }

        [HttpPost]
        [Route("New")]
        public IActionResult New(ProductTypeVM dto)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "There were some error in your form");
                return View(dto);
            }

            service.AddProductType(dto);

            return View("Index", service.GetAllProductType());
        }

        //editare
        [HttpGet]
        [Route("Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var dto = service.GetProductType(id);
            return View(dto);
        }

        [HttpPost]
        [Route("Edit/{id}")]
        public IActionResult Edit(int id,ProductTypeVM dto)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "There were some error in your form");
                return View(dto);
            }

            service.UpdateProductType(id,dto);

            return View("Index", service.GetAllProductType());
        }

        //delete
        [HttpDelete]//facem cu JQUERY SI NE PERMITE
        [Route("Delete/{id}")]
        public JsonResult Delete(int id)
        {
            service.DeleteProductType(id);
            return Json(new { success = true, message = "Delete success" });
        }
    }
}
