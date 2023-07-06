
using System;
using System.ComponentModel;
using System.Reflection;

namespace enumPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("omar", 123, Gender.MALE, CarType.BASIC);
            User user2 = new User("aisha", 120, Gender.FEMALE, CarType.PREMIUM);

            //Console.WriteLine((int)user1.carType);

            ////foreach(Gender gender in Enum.GetValues(typeof(Gender)))
            ////{
            ////    Console.WriteLine(gender.ToString());
            ////}

            //Console.WriteLine((int)Gender.FEMALE);
            //Console.WriteLine((int)CarType.VAN);
            //string description = getEnumDescription(CarType.VAN);
            //Console.WriteLine(description);


            //int ordinalValue = 200;
            //CarType type = (CarType)ordinalValue;
            //Console.WriteLine(type.ToString());

            //------------------------A1-weekdays-------------------
            //Console.Write("Enter a day of the week: ");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, out DaysOfWeek dayOfWeek))
            //{
            //    switch (dayOfWeek)
            //    {
            //        case DaysOfWeek.Sunday:
            //            Console.WriteLine("It's weekday.");
            //            break;
            //        case DaysOfWeek.Monday:
            //            Console.WriteLine("It's weekday.");
            //            break;
            //        case DaysOfWeek.Tuesday:
            //            Console.WriteLine("It's weekday.");
            //            break;
            //        case DaysOfWeek.Wednesday:
            //            Console.WriteLine("It's weekday.");
            //            break;
            //        case DaysOfWeek.Thursday:
            //            Console.WriteLine("It's a weekday.");
            //            break;
            //        case DaysOfWeek.Friday:
            //            Console.WriteLine("It's weekend.");
            //            break;
            //        case DaysOfWeek.Saturday:
            //            Console.WriteLine("It's weekend.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid day of the week.");
            //}

            //------------------------T2-------------------

            //Console.WriteLine("Enter a size of of your shirt: ");
            //string enterSize = Console.ReadLine();
            //ClothingSize size;

            //if (Enum.TryParse(enterSize, true, out size))
            //{
            //    if (size == ClothingSize.SMALL)
            //    {
            //        Console.WriteLine("Your size is Small.");
            //    }
            //    else if (size == ClothingSize.MEDIUM)
            //    {
            //        Console.WriteLine("Your size is Medium.");
            //    }
            //    else if (size == ClothingSize.LARGE)
            //    {
            //        Console.WriteLine("Your size is Large.");
            //    }
            //    else if (size == ClothingSize.XLARGE)
            //    {
            //        Console.WriteLine("Your size is XLarge.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("That is not a valid clothing size.");
            //}
            ////---------------T3----------------
            //Console.Write("Enter your color: ");
            //string inputColor = Console.ReadLine();
            //FavoriteColor favoriteColor = (FavoriteColor)Enum.Parse(typeof(FavoriteColor), inputColor);

            //if (favoriteColor == FavoriteColor.Red)
            //{
            //    Console.WriteLine("Your favorite color is red");
            //}
            //else if (favoriteColor == FavoriteColor.Blue)
            //{
            //    Console.WriteLine("Your favorite color is Blue");
            //}
            //else if (favoriteColor == FavoriteColor.Green)
            //{
            //    Console.WriteLine("Your favorite color is Green");
            //}
            //else
            //{
            //    Console.WriteLine("That is not a valid favorite color.");
            //}
            //---------T4------------------
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            convertInt convert = (convertInt)num;
                if (convert == convertInt.Alpha)
                {
                    Console.WriteLine(convert);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        private static string getEnumDescription(Enum enums)
        {
            var field = enums.GetType().GetField(enums.ToString());
            var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute != null ? attribute.Description : enums.ToString();
        }
        
        //------------------------A1-weekdays-------------------
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        public enum ClothingSize
        {
            SMALL,
            MEDIUM,
            LARGE,
            XLARGE,
            XXLARGE
        }
        public enum FavoriteColor
        {
            Red,
            Blue,
            Green,
            White
        }
        public enum convertInt
        {
            Alpha = 10,
            Beta = 28,
            Delta = 35,
        }
    }
}