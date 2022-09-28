using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeptosES.ClienteBlazor.Models
{
    public class Municipio
    {
        public int Id { get; set; }
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Imagen { get; set; }
    }
}
