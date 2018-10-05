using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Json1
{
    class Persondeser
    {
       
            public string name { get; set; }
            public int age { get; set; }
            public override string ToString()
            {
                return string.Format("Name:{0} \nAge:{1}", name, age);
            }
    }
    class Program2
    {
        static void Main(string[] args)
        {
          //  string JSONstring = File.ReadAllText(@"F:\bzrt\JSON.json");

            JavaScriptSerializer ser = new JavaScriptSerializer();
            //Person p1 = ser.Deserialize<Person>(JSONstring);
            //Console.WriteLine(p1);

            Person p2 = new Person() { name="Anji", age=23};
            string outputJSON = ser.Serialize(p2);
            Console.WriteLine(outputJSON);
           // File.WriteAllText(@"F:\bzrt\Output.json",outputJSON);
            Console.Read();
        }
    }
}
