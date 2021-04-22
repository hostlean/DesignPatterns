using System;
using System.Runtime.CompilerServices;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var cp = new ConcretePrototype(5);
            var sp = new SubclassPrototype(3, 4);
            var clone1 = cp.Clone();
            var clone2 = sp.Clone();

            Console.WriteLine( cp.GetNumber() );
            Console.WriteLine( sp.GetNumber() );
            Console.WriteLine( clone1.GetNumber() );
            Console.WriteLine( clone2.GetNumber() );
        }
    }

    public interface IPrototype
    {
        public IPrototype Clone();

        public int GetNumber();
        

    }

    public class ConcretePrototype : IPrototype
    {
        private int _number;


        public ConcretePrototype(int number)
        {
            _number = number;
        }
        
        public ConcretePrototype(ConcretePrototype prototype)
        {
            _number = prototype._number;
        }
        
        public IPrototype Clone()
        {
            return new ConcretePrototype(this);
        }

        public int GetNumber()
        {
            return _number;
        }
    }

    public class SubclassPrototype : ConcretePrototype
    {
        private int _number2;

        public SubclassPrototype(int number, int number2) : base(number)
        {
            _number2 = number2;
        }
        
        public SubclassPrototype(SubclassPrototype prototype) : base(prototype)
        {
            _number2 = prototype._number2;
        }

        public int GetNumber2()
        {
            return _number2;
        }

    }
    
    
}