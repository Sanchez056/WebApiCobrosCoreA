using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCobrosCore.Models;

namespace WebApiCobrosCore.DAL
{
    public class WebApiCobrosDb : DbContext
    {
        public WebApiCobrosDb(DbContextOptions<WebApiCobrosDb> options) : base(options)
        {

        }

        public DbSet<Cobros> Cobros { get; set; }
    }
}
