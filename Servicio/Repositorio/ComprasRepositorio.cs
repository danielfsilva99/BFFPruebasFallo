using Dapper;
using Modelo.ModeloEntrada;
using Modelo.ModeloSalida;
using Modelo.Repositorio;
using Servicio.Contexto;
using System.Data;

namespace Servicio.Repositorio
{
    public class ComprasRepositorio : ICompras
    {
        private ContextoConexion contexto;

        public ComprasRepositorio()
        {
            contexto = new ContextoConexion();
        }

        public Task<bool> AgregarCompra(ComprasModelo comprasModelo)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ComprasEntidad>> ConsultarCompras(int idCliente)
        {
            using (IDbConnection db = contexto.connection)
            {
                var parameters = new DynamicParameters();
                parameters.Add("@id_cliente", idCliente, DbType.Int32);
                var result = await db.QueryAsync<ComprasEntidad>("ConsultarComprasPorCliente", parameters, commandType: CommandType.StoredProcedure);
                List<ComprasEntidad> compras = result.ToList();

                return compras;
            }
        }

        public Task<bool> EliminarCompra(int compra)
        {
            throw new NotImplementedException();
        }
    }
}
