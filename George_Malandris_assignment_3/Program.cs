using George_Malandris_assignment_3.CheckOut;
using George_Malandris_assignment_3.Enums;
using George_Malandris_assignment_3.Interfaces;
using George_Malandris_assignment_3.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace George_Malandris_assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct tshirt1 = new TShirt(Color.BLUE, Size.XS, Fabric.COTTON);
            IProduct tshirt2 = new TShirt(Color.RED, Size.L, Fabric.CASHMERE);
            IProduct tshirt3 = new TShirt(Color.INDIGO, Size.XL, Fabric.POLYESTER);
            IProduct tshirt4 = new TShirt(Color.RED, Size.XXL, Fabric.SILK);
            IProduct tshirt5 = new TShirt(Color.VIOLET, Size.S, Fabric.COTTON);

            Cashier cashier = new Cashier(tshirt1, new Payment(PaymentMethod.DebitCard));

            cashier.CheckOut();

            cashier = new Cashier(tshirt2, new Payment(PaymentMethod.Cash));

            cashier.CheckOut();

            cashier = new Cashier(tshirt3, new Payment(PaymentMethod.BankTransfer));

            cashier.CheckOut();

            cashier = new Cashier(tshirt4, new Payment(PaymentMethod.Cash));

            cashier.CheckOut();

            cashier = new Cashier(tshirt5, new Payment(PaymentMethod.DebitCard));

            cashier.CheckOut();
        }
    }
}
