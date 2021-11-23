using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp1.Entities {
    class ImportedProduct : Product {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsfee) : base(name, price) {
            CustomsFee=customsfee;
            }
        public override string PriceTag() {
            return Name + " $"+ TotalPrice().ToString("F2",CultureInfo.InvariantCulture) + "(Customs fee: $ )" + CustomsFee;
            }
        public double TotalPrice() {
            return Price+CustomsFee;
            }
        }
    }
