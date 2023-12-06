using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaTuto.Data;

namespace PizzaTuto.Services
{
   public class PizzaService
    {
        public Task<Pizza[]> GetPizzasAsync()
        {
            return Task.FromResult(new Pizza[0]);
        }
    }
}