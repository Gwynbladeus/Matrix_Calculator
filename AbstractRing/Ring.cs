using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMatrixTypes
{
    public abstract class Ring
    {
        public Ring(String str) { 
           ConvertToRing(str);
        }
        public Ring() {

        }
        public abstract void Add(Ring obj);
        public abstract void Multiply(Ring obj);
        public abstract String AsString();
        public abstract void ConvertToRing(String str);
        public abstract String GetName();
        public abstract String[] GetParameters();
        public bool CheckEquality(Ring obj)
        {
            if (this.GetType() == obj.GetType())
            {
                return true;
            }
            return false;
        }
        public Ring Copy()
        {
            return (Ring)this.MemberwiseClone();
        }
        public abstract Ring GetRandomElem(Random rand);
    }
}
