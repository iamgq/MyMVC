

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyMVC.Models;

namespace MyMVC.DataAccessLayer
{

    public class SalesERPDAL : DbContext
    {
        public SalesERPDAL() : base("SalesERPDB")
        {
        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }
    }


}
