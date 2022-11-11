using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class QLKS_DA1_DbContext : DbContext
    {
        public QLKS_DA1_DbContext()
        {

        }

        public QLKS_DA1_DbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // thuc hien rang buoc ket noi
            base.OnConfiguring(optionsBuilder
                .UseSqlServer("Data Source=LAPTOP-DAV1LO0Q\\SQLEXPRESS;Initial Catalog=QLKS_DuAn1_Lan2;Persist Security Info=True;User ID=hiepnt;Password=hiepa8k57tn "));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // apply config cho cac model
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
