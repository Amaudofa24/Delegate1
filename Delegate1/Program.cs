using System;

namespace DelegateOne
{
    internal class Program
    {
        public static object? FineChic { get; private set; }
        public delegate bool Predicate(TClass t);
        static void Main(string[] args)
        {
            //var likelyUsername = t.FirstName + "." + t.LastName;
            Delegate classwork = (TClass t) =>
            {

                if (t.UserName == FineChic)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

 

     
        }
        

        
            
           
            
    }
}



