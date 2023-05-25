using Microsoft.AspNetCore.Mvc;
using Service.InfraStructure.Dto;
using Service.InfraStructure.Implement;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoIdentidadController : Controller
    {
        private readonly TipoIdentidadAppService _service = new();

        [HttpGet]
        public List<TipoIdentidadDto> GetAll()
        {
            return _service.GetAll();
        }
        [Route("{id}")]
        [HttpGet]
        public TipoIdentidadDto GetById([FromQuery] int id)
        {
            return _service.GetById(id);
        }
    }
}
