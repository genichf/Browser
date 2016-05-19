using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class MyFile
    {
        public string Name { get; set; }
        public string Path { get; set; }
        //public double Size { get; set; }

        public MyFile() { }
        public MyFile(string name, string path/*, double size*/)
        {
            Name = name;
            Path = path;
            //Size = size;
        }
    }
}