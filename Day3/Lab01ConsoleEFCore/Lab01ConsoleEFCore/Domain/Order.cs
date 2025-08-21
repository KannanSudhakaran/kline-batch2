using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01ConsoleEFCore.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public decimal TotalAmount { get;set; }

        public string Description { get; set; } = string.Empty;

        public Customer Customer { get; set; } = null!;

        public override string ToString()
        {
            return $" id: {this.Id} , total {this.TotalAmount} , des: {this.Description}";
        }

    }
}
