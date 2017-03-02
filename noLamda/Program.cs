using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace noLamda
{
    class Program
    {
        #region Class Definitions
        public class Customer
        {
            public string First { get; set; }
            public string Last { get; set; }
            public string State { get; set; }
            public double Price { get; set; }
            public string[] Purchases { get; set; }
        }

        public class Distributor
        {
            public string Name { get; set; }
            public string State { get; set; }
        }

        public class CustDist
        {
            public string custName { get; set; }
            public string distName { get; set; }
        }

        public class CustDistGroup
        {
            public string custName { get; set; }
            public IEnumerable<string> distName { get; set; }
        }
        #endregion

        #region Create data sources

        static List<Customer> customers = new List<Customer>
        {
            new Customer {First = "Cailin", Last = "Alford", State = "GA", Price = 930.00, Purchases = new string[] {"Panel 625", "Panel 200"}},
            new Customer {First = "Theodore", Last = "Brock", State = "AR", Price = 2100.00, Purchases = new string[] {"12V Li"}},
            new Customer {First = "Jerry", Last = "Gill", State = "MI", Price = 585.80, Purchases = new string[] {"Bulb 23W", "Panel 625"}},
            new Customer {First = "Owens", Last = "Howell", State = "GA", Price = 512.00, Purchases = new string[] {"Panel 200", "Panel 180"}},
            new Customer {First = "Adena", Last = "Jenkins", State = "OR", Price = 2267.80, Purchases = new string[] {"Bulb 23W", "12V Li", "Panel 180"}},
            new Customer {First = "Medge", Last = "Ratliff", State = "GA", Price = 1034.00, Purchases = new string[] {"Panel 625"}},
            new Customer {First = "Sydney", Last = "Bartlett", State = "OR", Price = 2105.00, Purchases = new string[] {"12V Li", "AA NiMH"}},
            new Customer {First = "Malik", Last = "Faulkner", State = "MI", Price = 167.80, Purchases = new string[] {"Bulb 23W", "Panel 180"}},
            new Customer {First = "Serena", Last = "Malone", State = "GA", Price = 512.00, Purchases = new string[] {"Panel 180", "Panel 200"}},
            new Customer {First = "Hadley", Last = "Sosa", State = "OR", Price = 590.20, Purchases = new string[] {"Panel 625", "Bulb 23W", "Bulb 9W"}},
            new Customer {First = "Nash", Last = "Vasquez", State = "OR", Price = 10.20, Purchases = new string[] {"Bulb 23W", "Bulb 9W"}},
            new Customer {First = "Joshua", Last = "Delaney", State = "WA", Price = 350.00, Purchases = new string[] {"Panel 200"}}
        };

        static List<Distributor> distributors = new List<Distributor>
        {
            new Distributor {Name = "Edgepulse", State = "UT"},
            new Distributor {Name = "Jabbersphere", State = "GA"},
            new Distributor {Name = "Quaxo", State = "FL"},
            new Distributor {Name = "Yakijo", State = "OR"},
            new Distributor {Name = "Scaboo", State = "GA"},
            new Distributor {Name = "Innojam", State = "WA"},
            new Distributor {Name = "Edgetag", State = "WA"},
            new Distributor {Name = "Leexo", State = "HI"},
            new Distributor {Name = "Abata", State = "OR"},
            new Distributor {Name = "Vidoo", State = "TX"}
        };

        static double[] exchange = { 0.89, 0.65, 120.29 };

        static double[] ExchangedPrices = {827.70, 604.50, 111869.70,
                                        1869.00, 1,365.00, 252609.00,
                                        521.36, 380.77, 70465.88,
                                        455.68, 332.80, 61588.48,
                                        2018.34, 1474.07, 272793.66,
                                        920.26, 672.10, 124379.86,
                                        1873.45, 1368.25, 253210.45,
                                        149.34, 109.07, 20184.66,
                                        455.68, 332.80, 61588.48,
                                        525.28, 383.63, 70995.16,
                                        9.08, 6.63, 1226.96,
                                        311.50, 227.50, 42101.50};

        static string[] Purchases = {  "Panel 625", "Panel 200",
                                    "12V Li",
                                    "Bulb 23W", "Panel 625",
                                    "Panel 200", "Panel 180",
                                    "Bulb 23W", "12V Li", "Panel 180",
                                    "Panel 625",
                                    "12V Li", "AA NiMH",
                                    "Bulb 23W", "Panel 180",
                                    "Panel 180", "Panel 200",
                                    "Panel 625", "Bulb 23W", "Bulb 9W",
                                    "Bulb 23W", "Bulb 9W",
                                    "Panel 200"
                                 };
        #endregion

        //static void Main(string[] args)
        //{
        //    CustomersFromOR();
        //    AllExchangedPricesLessThan();
        //    CustomersFromGAAndTheirPurchases();
        //    AllFirstNames();
        //    AllFullNames();
        //    AllStateAbbreviationsThatAreTheSame();
        //    FirstThreeCustomers();
        //    SortCustomersAlphabeticallyByFirstname();
        //    SortCustomersByLengthOfLastname();
        //    SortAListOfCustomersByPriceFromHighestToLowest();
        //    SortCustomersFirstByLengthOfFirstNameAndThenByLastNameAlphabetically();
        //    Console.ReadKey();
        //}
        public static string CustomersFromGAAndTheirPurchases()
        {
            string s = "Customers From GA:\n\n";
            
            foreach (Customer c in customers)
            {
                if (c.State == "GA")
                {
                    foreach (string d in c.Purchases)
                        s = s + c.First + " " + c.Last + " " + d + "\n";

                }
            }
            return s;
        }
        public static string CustomersFromOR()
        {
            string s = "Customers From OR:\n\n";
            
            foreach (Customer c in customers)
            {
                if (c.State == "OR")
                {
                    s = s + c.First + " " + c.Last + "\n";

                }
            }
            return s;
        }
        public static string AllExchangedPricesLessThan()
        {
            string s = "Prices Less Than 1000:\n\n";
            
            foreach (Customer c in customers)
            {
                if (c.Price < 1000)
                {
                    s = s + c.First + " " + c.Last + " " + c.Price + "\n";
                    
                }
            }
            return s;
        }
        public static string AllFirstNames()
        {
            string s = "Firstnames Of All Customers:\n\n";
           
            foreach (Customer c in customers)
            {

                s = s + c.First +"\n";

            }
            return s;
        }
        static List<string> fullNames = new List<string>();
        public static string AllFullNames()
        {
            string s = "Fullnames Of All Customers:\n\n";
           
            foreach (Customer c in customers)
            {
                fullNames.Add(c.First + " " + c.Last);
            }
            foreach (string f in fullNames)
            {
                s=s+f+"\n";
            }
            return s;
        }
        public static string AllStateAbbreviationsThatAreTheSame()
        {
            //Not working

            List<Customer> states = new List<Customer>();
            string g = "States:\n\n";
            foreach (Customer c in customers)
            {
                foreach (Distributor d in distributors)
                {
                    if (c.State == d.State)
                    {
                        foreach (Customer s in states)
                        {
                            if (d.State == s.State)
                            {

                            }
                            else
                            {
                                g = g + s.State + "\n";
                                states.Add(c);
                            }

                        }
                    }
                }
            }
            return g;
        }
        public static string FirstThreeCustomers()
        {

            List<Customer> firstThree = new List<Customer>();
            string s = "First Three Customers:\n\n";
            for (int i = 0; i < 3; i++)
            {
                firstThree.Add(customers[i]);
            }
            foreach (Customer f in firstThree)
            {
                s = s + f.First + " " + f.Last + "\n";

            }
            return s;
        }
        public static string SortCustomersAlphabeticallyByFirstname()
        {
            string s= "Sorted Customers Alphabetically:\n\n";
            fullNames.Sort();
            foreach (string f in fullNames)
            {
                s = s + f + "\n";
            }

            return s;

        }
        public static string SortCustomersByLengthOfLastname()
        {

            string s= "Sorted Customers By Lenght Of Last Name:\n\n";
            List<Customer> length = new List<Customer>();
            foreach (Customer c in customers)
            {
                length.Add(c);
            }
            length.Sort(CompareByLength);
            foreach (Customer l in length)
            {
                s = s + l.First + " " + l.Last + "\n";

            }

            return s;
        }

        private static int CompareByLength(Customer c, Customer c1)
        {
            int x = c.Last.Length.CompareTo(c1.Last.Length);
            if (x != 0)
            {
                return x;
            }
            else
            {
                return c.Last.CompareTo(c1.Last);
            }
        }

        public static string SortAListOfCustomersByPriceFromHighestToLowest()
        {
            string s = "Sorted Customers By Price:\n\n";
            List<Customer> price = new List<Customer>();
            foreach (Customer c in customers)
            {
                price.Add(c);
            }
            price.Sort(CompareByPrice);
            foreach (Customer p in price)
            {
                s = s + p.First + " " + p.Last + " " + p.Price + "\n";

            }
            return s;
        }

        private static int CompareByPrice(Customer c, Customer c1)
        {
            return c1.Price.CompareTo(c.Price);
        }
        public static string SortCustomersFirstByLengthOfFirstNameAndThenByLastNameAlphabetically()
        {
            //dosen't sort alphabeticlly
            string s = "Sorted Customers by Length Of First Name \n And Then By Last Name Alphabetically:\n\n";
            List<Customer> lengthAndAlphabetically = new List<Customer>();
            foreach (Customer c in customers)
            {
                lengthAndAlphabetically.Add(c);
            }
            lengthAndAlphabetically.Sort(CompareByLengthAndAlphabetically);
            foreach (Customer la in lengthAndAlphabetically)
            {
                s = s + la.First + " " + la.Last + "\n";

            }
            return s;
        }

        private static int CompareByLengthAndAlphabetically(Customer c, Customer c1)
        {
            int x = c1.First.Length.CompareTo(c.First.Length);
            if (x != 0)
            {

                return x;
            }
            else
            {
                return c1.First.CompareTo(c.First);
            }

        }
    }
}

