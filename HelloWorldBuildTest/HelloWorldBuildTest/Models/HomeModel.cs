using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldBuildTest.Models
{
    public class HomeModel
    {
        public string name;
        public DateTime date;
        public string message;

        public void GetMessage()
        {
            date = DateTime.Now;
            message = "Hello " + name + ", the date is " + date;
        }
    }
}