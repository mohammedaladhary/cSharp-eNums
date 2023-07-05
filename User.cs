using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumPractice
{
    internal class User
    {
        public string Name { get; set; }
        public int id { get; set; }

        public Gender gender { get; set; }

        public CarType carType { get; set; }

        public User(string Name, int id, Gender gender, CarType carType)
        {
            this.Name = Name;
            this.id = id;
            this.gender = gender;
            this.carType = carType;
        }
    }

    enum Gender
    {
        MALE,
        FEMALE,
        OTHER

    }

    enum CarType
    {
        [Description("this is BASIC")]
        BASIC = 100,
        [Description("this is PREMIUM ")]
        PREMIUM = 200,
        [Description("this is VAN ")]
        VAN = 150,
        [Description("this isULTRA_PREMIUM")]
        ULTRA_PREMIUM = 250,


    }
}