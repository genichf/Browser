using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class MyDirectory
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public MyDirectory() { }
        public MyDirectory(string name, string path)
        {
            Name = name;
            Path = path;
        }
    }
}