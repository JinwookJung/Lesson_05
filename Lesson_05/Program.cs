using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREATING ARRAY
            string[] carMakeList = { "Honda", "BMW", "Mercedes", "Jeep", "Ford" };

            string[] tempCarMakeList = new string[5];

            Random rnd = new Random();

            int randomCar;





            randomCar = rnd.Next(6);
            Console.WriteLine("My random car is {0}", randomCar);

            //Assign cell s from one to another
            for (int index = 0; index < tempCarMakeList.Length; index++)
            {
                randomCar = generateRandomCar(rnd);
                tempCarMakeList[index] = carMakeList[index];
            }


                //Alternate way to declare and initialize an array
                //string[] carMakeList = new string[6];
                //carMakeList[0] = "Honda";
                //carMakeList[1] = "BMW";
                //carMakeList[0] = "Mercedes";
                //carMakeList[0] = "Jeep";
                //carMakeList[0] = "Ford";
                //carMakeList[0] = "Jagure";

                //Output the value of 
                for (int index = 0; index < carMakeList.Length; index++)
                {
                   //PRINT OUT THE ELEMENT OF ARRAY ONE BY ONE FROM [0] = "Honda"
                    Console.WriteLine(carMakeList[index]);
                }

                for (int index = 0; index < tempCarMakeList.Length; index++)
                {
                    
                    Console.WriteLine(tempCarMakeList[index]);
                }
                

                //CAN CHANGE ELEMENT OF ARRAY
                carMakeList[0] = "Jagure";
            
            //ALTERNATIVE METHOD TO LOOP THROUGH 
            int i = 0;
            while (i < carMakeList.Length)
            {
                Console.WriteLine(carMakeList[i]);
                i++;
            }
            
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++");
            Console.WriteLine("Please enter the key to exit...");
            Console.ReadKey();
        }
    }
}
