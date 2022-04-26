using DevInSales.Core.Entities;
using DevInSales.Core.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DevInSales.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController:ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPut("{id}")]
        public ActionResult AtualizarProduto(Product product,int id) {
            var produto  = _productService.ObterProductPorId(id);
            // var produto = new Product("asdasd",2);
            if(produto == null ) 
                return NotFound();
            if(!ModelState.IsValid || product.Name.ToLower() == "string") 
                return BadRequest("O objeto tem que ser construido com um nome e nome tem que ser diferente de string");
            if(_productService.ProdutoExiste(product.Name)) 
                return BadRequest("objeto já existe");

            return Ok(produto);
        }
    }
}