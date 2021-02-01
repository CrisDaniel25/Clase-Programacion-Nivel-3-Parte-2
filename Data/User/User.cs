using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea_2.Data
{
    public class User
    {
       public Result results {get; set;}
    }

    public class Result
    {
        public string gender {get; set;}
        public Name name {get; set;}
    }

    public class Name 
    {
        public string title {get; set;}
        public string first {get; set;}
        public string last {get; set;}
    }
}