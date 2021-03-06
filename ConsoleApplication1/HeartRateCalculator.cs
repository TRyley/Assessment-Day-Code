using System;
using System.Threading;

namespace Assessment
{
    public class HeartRateCalculator
    {
        public HeartRateCalculator()
        {
            Run();
        }
        private void Seperate()
        {
            Write("__________________________", 5);
            Write("__________________________", 5);
            Write("", 0);
        }
        private bool CheckEntered(string query)
        {
            int i;
            bool result = Int32.TryParse(query, out i);

            if (i <= 0 || i >= 200)
            {
                Write("Pretty sure thats not possible, \n", 20);
                return false;
            }
            return result;
        }
        private void Run()
        {
            bool repeat = true;
            while (repeat)
            {
                string entered = null;
                bool isCorrectValue = false;
                while (!isCorrectValue)
                {
                    Write("Enter Your Age:", 20);
                    entered = Console.ReadLine();
                    isCorrectValue = CheckEntered(entered);
                }
                float age = (float)Convert.ToDouble(entered);

                entered = null;
                isCorrectValue = false;
                while (!isCorrectValue)
                {
                    Write("Enter Your Resting Heart Rate (bpm):", 20);
                    entered = Console.ReadLine();
                    isCorrectValue = CheckEntered(entered);
                }
                float restHeartRate = (float)Convert.ToDouble(entered);

                AnimateSpinner();

                Calculate(age, restHeartRate);

                Write("", 0);
                Write("Type 'y' to repeat, any other input will close the app", 20);

                var input = Console.ReadLine();

                if (input.ToUpper() != "Y")
                {
                    repeat = false;
                }
                else
                {
                    Seperate();
                }
            }
            Write("Have a good day!", 20);
            Thread.Sleep(1000);
        }
        private void AnimateSpinner()
        {
            int timer = 0;

            Random rnd = new Random();
            int timerCompare = rnd.Next(12, 64);

            Spinner loader = new Spinner();

            while (timer < timerCompare)//Gives the impression of calculations being done, purely for effect.
            {
                Thread.Sleep(100);
                loader.Run();
                timer++;
            }
            Console.CursorVisible = true;
        }
        private void Calculate(float age, float rhr)
        {
            Write("Intensity   |   Heart Rate", 20);
            Write("--------------------------", 5);
            for (float i = 55; i <= 95; i++)
            {
                if (i % 5 == 0)
                {
                    float intensity = i / 100;

                    var target = Math.Floor((((220 - age) - rhr) * intensity) + rhr);

                    Write("    " + i + "%     |     " + target + "     ", 20);
                }
            }
        }
        private void Write(string text, int wait)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(wait);
            }
            Console.Write('\n');
        }
    }
}