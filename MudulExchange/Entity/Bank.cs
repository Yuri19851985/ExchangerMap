using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudulExchange.Entity
{
    public class Bank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public double usdSell { get; set; }
        public double usdBuy { get; set; }
        public double eurSell { get; set; }
        public double eurBuy { get; set; }
        public double rurSell { get; set; }
        public double rurBuy { get; set; }
        public virtual ICollection<BankInfo> BankInfos { get; set; }
    }
}
