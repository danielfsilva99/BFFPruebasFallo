using Modelo.ModeloEntrada;
using Modelo.ModeloSalida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Repositorio
{
    public interface ICompras
    {
        Task<List<ComprasEntidad>> ConsultarCompras(int idCliente);

        Task<bool> AgregarCompra(ComprasModelo comprasModelo);

        Task<bool> EliminarCompra(int compra);

    }
}
