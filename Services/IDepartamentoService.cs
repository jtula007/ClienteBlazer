using DeptosES.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeptosES.ClienteBlazor.Services
{
    public interface IDepartamentoService
    {
        Task<IEnumerable<Departamento>> GetAll();
    }
}
