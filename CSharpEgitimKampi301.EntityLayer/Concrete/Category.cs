using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}

/*
 Field-Variable-Property
 */

/*
  int x; --> Field (Direk sınıfın içersinde tanımlı ise)
  public int y {get; set;} => Property (get set kullanarak değişkene erişilioyrsa)
  int z; =>  Variable (Method içerisinde tanımlı ise değişken)
*/