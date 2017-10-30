using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PEAKiOS.Models;
using Refit;

namespace PEAKiOS
{
    [Headers("User-Agent: PEAK Refit App")]
    public interface IPEAKApi
    {
        [Get("/api/modules")]
        Task<List<Module>> GetModules();
    }
}