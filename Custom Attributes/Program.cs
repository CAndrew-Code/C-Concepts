using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Custom_Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class Developer : System.Attribute
    {
        private string developerName;
        private bool isReviewed;
        private string message;

        public Developer(string developerName, bool isReviewed, string message)
        {
            this.developerName = developerName;
            this.isReviewed = isReviewed;
            this.message = message;
        }

        public string DeveloperName { get=> developerName; set=> developerName = value; }
        public bool IsReviewed { get=> isReviewed; set=> isReviewed = value; }
        public string Message { get=> message; set=> message = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MemberInfo info = typeof(Cars);
            object[] attributes = info.GetCustomAttributes(true);
            for (int i = 0; i < attributes.Length; i++)
            {
                Console.WriteLine(attributes[i]);
            }
        }
    }
    [Developer("Colin", false,"This needs to be complete by Friday")]
    [Obsolete]
    class Cars
    {

    }
}
