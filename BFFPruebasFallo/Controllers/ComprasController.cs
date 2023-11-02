using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.ModeloEntrada;
using Modelo.ModeloSalida;
using Servicio.Repositorio;

namespace BFFPruebasFallo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComprasController : Controller
    {
        public readonly ComprasRepositorio ComprasRepositorio;

        private readonly ILogger<ComprasController> _logger;

        public ComprasController(ILogger<ComprasController> logger)
        {
            _logger = logger;
            ComprasRepositorio = new ComprasRepositorio();
        }

        [HttpGet("{clienteId}")]
        public async Task<List<ComprasEntidad>> GetComprasCliente(int clienteId)
        {
            var clientes = await ComprasRepositorio.ConsultarCompras(clienteId);
            return clientes;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ComprasModelo clienteModelo)
        {
            await ComprasRepositorio.AgregarCompra(clienteModelo);

            return StatusCode(201);
        }

        [HttpDelete("{clienteId}")]
        public async Task<IActionResult> Delete(int clienteId)
        {
            await ComprasRepositorio.EliminarCompra(clienteId);

            return StatusCode(201);
        }
    }
}
