using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IService<Product> _serviceProduct;

        public ProductsController(IMapper mapper, IService<Product> serviceProduct)
        {
            _mapper = mapper;
            _serviceProduct = serviceProduct;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _serviceProduct.GetAllAsync();
            var mappedData = _mapper.Map<List<ProductDto>>(data.ToList());
            return Ok(CustomResponseDto<List<ProductDto>>.Succsess(statusCode: 200, data: mappedData));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var data = await _serviceProduct.GetById(id);
            var mappedData = _mapper.Map<ProductDto>(data);
            return Ok(CustomResponseDto<ProductDto>.Succsess(statusCode: 200, data: mappedData));
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductDto dto)
        {
            var mappedData = _mapper.Map<Product>(dto);
            await _serviceProduct.AddAsync(mappedData);
            return Ok(CustomResponseDto<ProductDto>.Succsess(statusCode: 201, data: dto));
        }
    }
}
