using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Browser.WebAPI.Utilites
{
    public static class Utilites
    {
        public static double ConvertBytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }
    }
}