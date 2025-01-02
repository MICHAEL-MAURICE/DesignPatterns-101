using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattens.Singleton
{
    public sealed class Singleton
    {
        private static Singleton Instance = null;
        private static readonly object padlock = new object();

        private Singleton()
        {
        }


        public static Singleton GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                    }
                    return Instance;
                }
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message+"  "+ padlock);
        }


    }
}
