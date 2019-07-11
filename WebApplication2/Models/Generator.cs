using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public static class Generator
    {
        static Random rnd = new Random();
        public static string generator(string charset, int size)
        {
            string output = "";
            for(int i = 0; i < size; i++)
            {
                output = String.Concat(charset[rnd.Next(0, charset.Length)],output); 
            }
            return output;
        }

    }
}