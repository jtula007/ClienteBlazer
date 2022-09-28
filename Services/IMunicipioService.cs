using DeptosES.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeptosES.ClienteBlazor.Services
{
    public interface IMunicipioService
    {
        Task<IEnumerable<Municipio>> GetAll();
        Task<IEnumerable<Municipio>> GetByDepartamento(int idDepto);
        Task<Municipio> GetById(int id);
    }
}
