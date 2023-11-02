using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ModeloSalida
{
    public class ComprasModelo
    {
     public int  id_cliente { get; set; }

	 public DateTime fecha_compra { get; set; }
	
     public string detalle { get; set; }
    }
}
