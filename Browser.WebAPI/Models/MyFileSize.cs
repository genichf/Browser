using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class MyFileSize
    {
        public double Size { get; set; }

        public MyFileSize() { }
        public MyFileSize(double size)
        {
            Size = size;
        }
    }
}