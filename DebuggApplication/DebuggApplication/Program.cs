using System;
using System.Diagnostics;

namespace DebuggApplication{

    public class Debugclass { 
    
            public void debug ()
        {

            string userResponse = Console.ReadLine();
            int name;
            if (Convert.ToBoolean(int.Parse(userResponse)))
            {

                Console.WriteLine("The entered value is a integer");

            }



        }
        public static void Main(string[] args) {


            Debugclass d = new Debugclass();        
            d.debug();
        }


    }



}