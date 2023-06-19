using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class SingletonClass
    {
        //This variable is going to store the Singleton Instance
        private static SingletonClass? Instance = null;
        //The following Static Method is going to return the Singleton Instance
        public static SingletonClass CreateInstance()
        {
            //If the variable instance is null, then create the Singleton instance 
            //else return the already created singleton instance
            //This version is not thread safe
            if (Instance == null)
            {
                Instance = new SingletonClass();
                Console.WriteLine("Instance created!");
            }
            else
            {
                Console.WriteLine("Instance already exist");
            }
            
            //Return the Singleton Instance
            return Instance;
        }
        //Constructor is Private means, from outside the class we cannot create an instance of this class
        private SingletonClass()
        {
            
        }
    }
}
