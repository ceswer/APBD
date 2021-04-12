using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task05.Models;

namespace Task05.Services
{
    public interface IDbService
    {
        Task<int> AddProductToWarehouseAsync(ProductWarehouse productWarehouse);
    }
}
