using System;
using System.Collections.Generic;
using MiddleLayer;

namespace FactoryCustomer
{
    public static class Factory //Simple Factory Design Pattern
    {
        private static Dictionary<string, CustomerBase> custs = new Dictionary<string, CustomerBase>();
        
        public static CustomerBase AddCustomer(string TypeCust)
        {
            //Lazy Loading Design Pattern
            if(custs.Count == 0)
            {
                custs.Add("Customer", new Customer());
                custs.Add("Lead", new Lead());
            }

            // RIP replace if with polymorphism Design Pattern
            return custs[TypeCust];
        }
        

    }
}
