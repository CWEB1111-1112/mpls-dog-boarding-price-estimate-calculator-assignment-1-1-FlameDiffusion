using System;

namespace assignment_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Estimate est = new Estimate("all done");


            
            est.dogName = Console.ReadLine();
            Console.WriteLine("how much does your dog weight");
            est.dogWeight = Console.ReadLine();
            Console.WriteLine("how long do you want to stay");
            est.numDays = Console.ReadLine();
            Console.WriteLine("do you want bathing and grooming type A, if you want just bathing type C, else type N ");
            est.addon = Console.ReadLine();
            est.stay();  
            est.ToString();
            
        }
    }

    class Estimate{

        public Estimate(string value){
            Console.WriteLine(value);
        }
 
        int overnight = 75;
        int total;
        public string dogName {get; set;}
        public string dogWeight {get; set;}
        public string numDays {get; set;}
        public string addon {get; set;}
        
        public void stay(){
            if(addon =="A"){
                overnight = 165;
                total = overnight * Convert.ToInt32(numDays);
                Console.WriteLine("your total is: " + total);
            }else if(addon =="C"){
                overnight = 112;
                total = overnight * Convert.ToInt32(numDays);
                Console.WriteLine("your total is: " + total);
            }else if(addon == "N"){
               total = overnight * Convert.ToInt32(numDays);
               Console.WriteLine("your total is: " + total);
            }else{
                Console.WriteLine("Error try again");
            }
        }


    }

    class owner{

    }
}
