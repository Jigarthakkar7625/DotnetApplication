using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    public enum days
    {
        Sunday = 10,
        Monday = 15,
        Tuesday = 18,
        Wednesday,
        Thursday,
        Friday,
        Saturday = 22

    }

    public enum Gender
    {
        [Description("This is MALE")]
        Male,
        [Description("This is FEMALE")]
        Female,
        T

    }

    public enum AuthorLevels
    {
        [Description("No level")]
        None,
        [Description("Starter")]
        Bronze,
        [Description("Intermediate")]
        Golden,
        [Description("Advance")]
        Platinum
    }
    public static class Demo2
    {

        public static int PI = 3;
        //public int UserIdDemo2 { get; set; }
        //public string UserNameDemo2 { get; set; }

        //public void checkRefDemo2()
        //{
        //    Demo2 demo3 = new Demo2();
        //    //Demo2 demo2 = new Demo2();
        //    int a = 10;
        //    demo3.UserNameDemo2 = "Manthan";
        //    demo3.checkRefDemo3(demo3);
        //    Console.WriteLine("jigar");
        //}


        //public static string GetEnumDescription(this Enum enumValue)
        //{
        //    var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

        //    var descriptionAttributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

        //    return descriptionAttributes.Length > 0 ? descriptionAttributes[0].Description : enumValue.ToString();

        //}
        public static string test()
        {
            return "";

        }
    }
}
