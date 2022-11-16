using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Test
{
    public class FactoryLibrary
    {
        //create מנויים
        //create תשלומים
        //create פרטי השאלה
        //...
    }
    //מחלקת ספרנים
    public class Librarians
    {

    }
    //מחלקת מזכירות
    public class Secretary
    {

    }
    //ממשק פרטי השאלה בספריה
    public interface ILibraryLoan
    {

    }
    //מחלקת נושאי ספרים
    public class BookSubject : ILibraryLoan
    {

    }
    //מחלקת ספרים
    public class Book:BookSubject
    {

    }
    //מחלקת דיסקים
    public class Disk : ILibraryLoan
    {

    }
    //מחלקת סרטים
    public class Movie : ILibraryLoan
    {

    }
    //מחלקת מנויים
    public class Subscription
    {
       List< ILibraryLoan> libraryLoans = new List< ILibraryLoan>();
        List<Fines> fines = new List< Fines>();
    }
    // מחלקת מנויים חד פעמי
    public class OneTimeSubscription:Subscription
    {

    }
    // מחלקת מנויים קבועים
    public class permanentSubscription : Subscription
    {

    }
    //מחלקת תשלומים
    public class Payments
    {
        public List<Promotions> promotions = new List<Promotions>();
    }
    //מחלקת הוראת קבע
    public class DirectOrder:Payments
    {

    }
    //מחלקת מזומן
    public class Cash : Payments
    {

    }
    //מחלקת צק
    public class Check : Payments
    {

    }
    //מחלקת אשראי
    public class Credit : Payments
    {

    }
    //מחלקת קנסות
    public class Fines
    {

    }
    public class Promotions
    {

    }
    public class Library
    {
        public Secretary[] Secretary;
        public Librarians[] Librarians;
        public ILibraryLoan[] libraryLoan;
        public Subscription[] Subscription;
        public Payments[] payments;


    }
    internal class exercise_11_Project
    {
        public void Run()
        {

        }
    }
}
