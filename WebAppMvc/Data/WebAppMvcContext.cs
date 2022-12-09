using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppMvc.Models;

namespace WebAppMvc.Data
{
    public class WebAppMvcContext : DbContext
    {
        public WebAppMvcContext (DbContextOptions<WebAppMvcContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppMvc.Models.Department> Department { get; set; } = default!;
    }
}
