
using System.ComponentModel;
using System.Reflection;

namespace enumPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("omar", 123, Gender.MALE, CarType.BASIC);
            User user2 = new User("aisha", 120, Gender.FEMALE,CarType.PREMIUM);

            Console.WriteLine((int)user1.carType);

            //foreach(Gender gender in Enum.GetValues(typeof(Gender)))
            //{
            //    Console.WriteLine(gender.ToString());
            //}

            Console.WriteLine((int)Gender.FEMALE);
            Console.WriteLine((int)CarType.VAN);
            string description = getEnumDescription(CarType.VAN);
            Console.WriteLine(description);


            int ordinalValue = 200;
            CarType type = (CarType)ordinalValue;
            Console.WriteLine(type.ToString());

        }

        private static string getEnumDescription(Enum enums)
        {
            var field = enums.GetType().GetField(enums.ToString());
            var attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
            return attribute != null ? attribute.Description : enums.ToString();
        }
    }
}