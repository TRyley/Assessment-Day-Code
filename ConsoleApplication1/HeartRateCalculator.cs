using System;

namespace Assessment
{
    public class HeartRateCalculator
    {
        public void Run() {
            Console.WriteLine("Enter resting heart rate: ");
            String restingHeartRate = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            String age = Console.ReadLine();

            Console.WriteLine("Age: "+age+", Resting heart rate: "+restingHeartRate+"\n");

            Console.WriteLine("Intensity\t|Heart rate|\n");
            Console.WriteLine("-----------|----------|\n");

            CalculateIntensity(restingHeartRate, age);

            Console.ReadLine();
        }
        public void CalculateIntensity(string restingHeartRate, string age)
        {
            //Target heart rate = (((220 - age) - resting heart rate) * intensity) + resting heart rate

            for (var i = 55; i <= 95; i++)
            {
                if (i % 5 == 0)
                {
                    int ageint = Convert.ToInt16(age);
                    int rhrint = Convert.ToInt16(restingHeartRate);
                    int targetHeartRate = (((220 - ageint) - rhrint) * i) + rhrint; /*think this math is wrong, age 20 with 65 rhr gives 7490 heart rate at 55%*/
                    Console.WriteLine(   i+"%     |   "+targetHeartRate+"    |\n");
                }
            }
        }
    }
}