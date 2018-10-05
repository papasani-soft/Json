using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
namespace Json1
{
   public partial class WebForm1 :System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Employee employee1 = new Employee
            {
                firstName = "hari",
                lastName = "hhai",
                gender = "Male",
                salary = 5000
            };
            Employee employee2 = new Employee
            {
                firstName = "sara",
                lastName = "venu",
                gender = "Male",
                salary = 6000
            };
            List<Employee> listEmployee = new List<Employee>();
            listEmployee.Add(employee1);
            listEmployee.Add(employee2);

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
           string jsonString= javaScriptSerializer.Serialize(listEmployee);
        }
    }
}
