using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MudulExchange.Entity;

namespace MudulExchange.Context
{
    public class ExchangeContext : DbContext
    {
        public ExchangeContext():base("ExchangeConnectionString")
        {
        }
        public ExchangeContext(string ConectionString) : base(ConectionString)
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new Initializer());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankInfo> BankInfos { get; set; }
    }
}
