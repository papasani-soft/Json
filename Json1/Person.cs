using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
namespace Json1
{ 
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public override string ToString()
        {
            return string.Format("Name:{0} \nAge:{1}", name, age);
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            string JSONstring = File.ReadAllText(@"F:\bzrt\JSON.json");
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Person p1 = ser.Deserialize<Person>(JSONstring);
            Console.WriteLine(p1);
            Console.Read();
        }
    }
}
