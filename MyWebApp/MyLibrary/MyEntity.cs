using System;
using System.Collections.Generic;

namespace MyLibrary
{
    public class MyEntity
    {
        public List<MyValueObject> GetList()
        {
            return new List<MyValueObject>
                   {
                       new MyValueObject {Name = "Hyuk", Company = "LP", Url = new Uri("http://www.lp.com"),},
                       new MyValueObject {Name = "Amit", Company = "SI", Url = new Uri("http://www.si.com"),},
                       new MyValueObject {Name = "Armen", Company = "PCL", Url = new Uri("http://www.pcl.com"),},
                       new MyValueObject {Name = "Ravi", Company = "ESL", Url = new Uri("http://www.esl.com"),},
                   };
        } 
    }
}
