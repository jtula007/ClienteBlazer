using DeptosES.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeptosES.ClienteBlazor.Services
{
    public interface IAudioService
    {
        Task<IEnumerable<Audio>> GetAll();
        Task<Audio> GetById(int id);
    }
}
