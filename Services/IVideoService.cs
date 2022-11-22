using DeptosES.ClienteBlazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeptosES.ClienteBlazor.Services
{
    public interface IVideoService
    {
        Task<IEnumerable<Video>> GetAll();
        Task<Video> GetById(int id);
    }
}
