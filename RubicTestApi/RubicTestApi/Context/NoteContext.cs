using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RubicTestApi.Models;

namespace RubicTestApi.Context
{
    public class NoteContext : DbContext
    {
        public NoteContext(DbContextOptions<NoteContext> options) : base(options)//нужно чтоб работал 
        {

        }
        public DbSet<Note> Notes { get; set; }//входит в таблицу Note в бд
    }
}
