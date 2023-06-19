using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonThreadSafe
{
    public sealed class SingletonThreadSafeClass
    {      
        //This variable is going to store the Singleton Instance
        private static SingletonThreadSafeClass? Instance = null;

        //To use the lock, we need to create one variable
        private static readonly object Instancelock = new object();

        //The following Static Method is going to return the Singleton Instance and inform us about existence of singleton
        public static SingletonThreadSafeClass CreateInstance()
        {
            Console.WriteLine("Checking if instance already exists...");
            if (Instance == null)
            {
                
                //locking the resource
                //Possible only for one thread
                lock (Instancelock)
                { 
                    
                    if (Instance == null)
                    {
                        Instance = new SingletonThreadSafeClass();
                        Console.WriteLine("Instance created!");
                    }
                } 
                //Critical Section End
                //Once the thread releases the lock, the other thread allows entering into the critical section
                //But only one thread is allowed to enter the critical section
                //Return the Singleton Instance
              }
            else
            {
                Console.WriteLine("Instance already exists!");
            }

             return Instance;
        }

        private SingletonThreadSafeClass()
        {
            
        }      
    }
}

