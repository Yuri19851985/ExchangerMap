using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudulExchange.Entity
{
    public class BankInfo
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public virtual Bank Bank { get; set; }
    }
}
