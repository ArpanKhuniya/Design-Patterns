//// Payment Interface
//using System.Security.Cryptography.X509Certificates;

//public interface IPayment
//{
//    public void MakePayment();
//}

//// Classes
//public class UPI : IPayment
//{
//    public void MakePayment() { }
//}

//public class NetBanking : IPayment
//{
//    public void MakePayment() { }
//}
//public class CreditCard : IPayment
//{
//    public void MakePayment() { }
//}

//// Select Strategy
////public class Strategy {

////    private IPayment paymentMethod;
////    public void SelectStrategy(IPayment payment) {
////        paymentMethod = payment;
////    }

////}

//// Main program

////class Program
////{
////    public static void Main(string[] args)
////    {
////        IPayment UpiPayment = new UPI();
////        UpiPayment.MakePayment();

////        IPayment NetBankingPayment = new UPI();
////        NetBankingPayment.MakePayment();

        
////    }
////}