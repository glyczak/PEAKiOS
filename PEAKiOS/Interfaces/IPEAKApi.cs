using System.Collections.Generic;
using System.Threading.Tasks;
using PEAKiOS.Models;
using Refit;

namespace PEAKiOS.Interfaces
{
    [Headers("User-Agent: PEAKiOS")]
    public interface IPEAKApi
    {
        [Get("/modules")]
        Task<List<Module>> GetModules();
    }
}