using System;

namespace planheist  {
    public class HeistReport {
        public HeistReport()
        {
            SuccessCount = 0;
            FailureCount = 0;
        }
        public int SuccessCount {get; set;}
        public int FailureCount {get; set;}
        public void Print()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Results");
            Console.WriteLine("-----------------");
            Console.WriteLine($"Successes: {this.SuccessCount}");
            Console.WriteLine($"Failures: {this.FailureCount}");
        }
    }
}