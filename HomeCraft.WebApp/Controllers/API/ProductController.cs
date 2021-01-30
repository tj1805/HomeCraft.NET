using AutoMapper;
using HomeCraft.Core.Models;
using HomeCraft.Core.Response;
using HomeCraft.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeCraft.WebApp.Controllers.API
{
    [Produces("application/json", "application/xml")]
    [Consumes("application/json")]
    [Route("api/product")]
    [ApiController]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class ProductController : ControllerBase
    {
        private readonly IProductsRepository _productsRespository;
        private readonly IMapper _mapper;

        public ProductController(IProductsRepository productsRespository, IMapper mapper)
        {
            _productsRespository = productsRespository
                 ?? throw new ArgumentNullException(nameof(productsRespository));
            _mapper = mapper
                 ?? throw new ArgumentNullException(nameof(mapper));
        }


        /// <summary>
        /// Get all products in the database
        /// </summary>
        /// <returns>All products available in the database</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            var productEntity = await _productsRespository.GetProductsAsync();
            // map destination to source
            return Ok(_mapper.Map<IEnumerable<ProductDTO>>(productEntity));
        }


        /// <summary>
        /// Get a single product from the database
        /// </summary>
        /// <param name="id">The id of the product to get</param>
        /// <returns>The requested product</returns>
        /// <response code="200">Returns the requested product</response>
        [HttpGet("{id}", Name = "GetProduct")]
        public async Task<IActionResult> GetProduct(Guid id)
        {
            var productEntity = await _productsRespository.GetProductAsync(id);
            if (productEntity == null)
                return NotFound();
            // map destination to source
            return Ok(_mapper.Map<ProductDTO>(productEntity));
        }

        /// <summary>
        /// Add a single Product to the database
        /// </summary>
        /// <param name="product"></param>
        /// <returns>The added Product</returns>
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] ProductForCreation product)
        {
            // destination to source
            var productEntity = _mapper.Map<Product>(product);
            _productsRespository.Addproduct(productEntity);
            await _productsRespository.SaveChangesAsync();
            // destination to source
            var productResponse = _mapper.Map<ProductDTO>(productEntity);
            return CreatedAtRoute("GetProduct", new { id = productEntity.Id }, productResponse);
            //return CreatedAtRoute("GetProduct", new { id = productEntity.Id }, _mapper.Map<ProductResponse>(productEntity));
        }

        /// <summary>
        /// Delete a single product from the database
        /// </summary>
        /// <param name="id">The id of the product to delete</param>
        /// <returns></returns>
        /// <response code="204">No Content</response>
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteProduct(Guid id)
        {
            var productentity = await _productsRespository.GetProductAsync(id);
            if (productentity == null)
                return NotFound();
            _productsRespository.DeleteProduct(productentity);
            await _productsRespository.SaveChangesAsync();
            return NoContent();
        }

    }
}
