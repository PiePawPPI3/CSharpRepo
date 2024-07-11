using System;

namespace Sprint2
{
    class Task_1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value for your weight (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value for your height (m): ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2);

            Console.WriteLine($"Your weight: {weight}, height: {height}, and current BMI: {bmi}");

            if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("Weight is correct");
            }
            else if (bmi > 24.9)
            {
                Console.WriteLine("You are obese");
            }
            else
            {
                Console.WriteLine("You're underweight");
            }
        }
    }
}

// namespace Sprint2
// {
//     class Task_1
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("task_2");

//         }
//     }
// }