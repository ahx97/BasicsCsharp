using System;

namespace Basics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const byte sample1 = 0x3A;
            byte sample2 = 58;
            int heartRate = 85;
            double deposits = 135002796;
            const float acceleration = 9.800F;
            const float mass = 14.6F;
            double distance = 129.763001;
            bool exspensive = true;
            bool lost = true;
            int choice = 2;
            const char integral = '\u222B';

            const string greeting = "Hello";
            string name = "Karen";


            if(sample1.Equals(sample2)){
                Console.WriteLine("They are equal!");
            }else{
                Console.WriteLine("Theyre not equal!");
            }

            if(heartRate >= 40 && heartRate < 80){
                Console.WriteLine("Heart rate is normal");
            }else{
                Console.WriteLine("heart rate in not normal");
            }

            if(deposits >= 100000000){
                Console.WriteLine("you are exceedingly wealthy");
            }else{
                Console.WriteLine("sorry you are poor");
            }

            float force = mass * acceleration;
            Console.WriteLine("Force= " + force);
            Console.WriteLine(distance + " is the distance");

            if(lost == true && exspensive == true){
                Console.WriteLine("I am really sorry! I will get the manageer.");
            }else{
                Console.WriteLine("Here is coupon for 10% off.");
            }

            switch(choice){
                case 1:
                    Console.WriteLine("Choice 1");
                    break;

                case 2:
                    Console.WriteLine("choice 2");
                    break;
                case 4:
                    Console.WriteLine("choice 3");
                    break;
                default:
                    Console.WriteLine("you made an unknown choice");
                    break;

            }

            Console.WriteLine(integral + " is an integral");

            for (int i = 5; i < 11; i++){
                Console.WriteLine("i = " + i);
            }

            int age = 0;

            while(age < 6){
                Console.WriteLine("age = " + age);
                ++age;
            }

            Console.WriteLine(greeting + name);

            /*

            */

        }
    }
}
