using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton instance = null;

        private Singleton(String name = "Default name")
        {
            Name = name;
        }

        public static Singleton GetInstance()
        {
            return instance ?? (instance = new Singleton());
        }        

        public string Name { get; private set; }

        public void SetName(string newName)
        {
            Name = newName;
        }
    }
}
