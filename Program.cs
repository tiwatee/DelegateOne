namespace DelegatesOne
{
    internal class Program
    {
        /// <summary>
        /// a predicate to check if username is equal to likelyUsername.
        ///  a predicate is to return true or false
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Predicate<Names> dUserCount = x => x.UserName == (x.FirstName + "." + x.LastName); //a predicate delegate


            Names obj = new Names(); // An instance of the class Names
            obj.FirstName = "Jay";
            obj.LastName = "Tuk";
            obj.UserName = "Jay.Tuk";
            Console.WriteLine("The condition is " + dUserCount(obj));// This is to console out true or false if
                                                                     // username and likely username are equal


            Names person2 = new Names(); // Another instance of the class Names
            person2.FirstName = "Kai";
            person2.LastName = "Ichinose";
            person2.UserName = "KaiIchinose";
            Console.WriteLine("The condition is " + dUserCount(person2));
        }
    }


    class Names
    {
        /// <summary>
        /// A class that contains the properties used in the predicate delegate
        /// </summary>
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
    }
}