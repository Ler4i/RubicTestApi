using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RubicTestApi.Models;

namespace RubicTestApi.Controllers
{
    public class BudgetContext : DbContext
    {
        public BudgetContext(DbContextOptions<BudgetContext> options)
            : base(options)
        { 

        }
        public DbSet<Budget> Budgets { get; set; }//будет "бегать" по БД
    }
}
