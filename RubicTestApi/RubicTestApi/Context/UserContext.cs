using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RubicTestApi.Models;

namespace RubicTestApi.Context
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)//нужно чтоб работал 
        {

        }
        public DbSet<User> Users { get; set; }//входит в таблицу User в бд
    }
}
