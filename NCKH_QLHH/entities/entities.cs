using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCKH_QLHH.entities
{
    public class entities
    {
        private int id;
        private string Product;
        private int Price;
        private string Ex;
        private int Quanlity;
        private int Total;
        entities(int id, string Product, int Price, string Ex, int Quanlity, int Total)
        {
           this.id = id;
            this.Product = Product;
            this.Price = Price;
            this.Quanlity = Quanlity;
            this.Total = Total;
            this.Ex = Ex;
        }
    }
}
