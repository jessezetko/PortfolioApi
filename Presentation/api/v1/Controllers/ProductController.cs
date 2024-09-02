using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using PortfolioApi.Domain.Models;
using PortfolioApi.Features.Product.Commands.Create;
using PortfolioApi.Features.Product.Commands.Delete;
using PortfolioApi.Features.Product.Queries.Get;
using Swashbuckle.AspNetCore.Annotations;

namespace PortfolioApi.Presentation.api.v1.Controllers
{
    [EnableRateLimiting("fixed")]
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<Product> _logger;
        private readonly IMediator _mediator;

        public ProductController(ILogger<Product> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var result = await _mediator.Send(new GetProductQuery());
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [SwaggerResponse(201, "Product Created")]
        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {
            try
            {
                await _mediator.Send(new CreateProductCommand { Product = product });
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int productId)
        {
            try
            {
                await _mediator.Send(new DeleteProductCommand { Id = productId });
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(500, ex.Message);
            }
        }
    }
}