using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class MyDrive
    {
        public string Name { get; set; }

        public MyDrive() { }
        public MyDrive(string name)
        {
            Name = name;
        }
    }
}