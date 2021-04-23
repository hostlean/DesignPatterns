using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        private static IAbstractFactory _factory;
        static void Main(string[] args)
        {
            _factory = new ConcreteFactory1();

            _factory.CreateProductA();

            _factory = new ConcreteFactory2();

            _factory.CreateProductB();
            
        }
    }


    
    public interface IAbstractFactory
    {
        public ProductA CreateProductA();

        public ProductB CreateProductB();

    }

    public class ConcreteFactory1 : IAbstractFactory
    {
        public ProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public ProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }

    public class ConcreteFactory2 : IAbstractFactory
    {
        public ProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public ProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
    
    
    public abstract class ProductA
    {
        public ProductA()
        {
            CreatedMessage();
        }

        public abstract void CreatedMessage();
        
    }
    
    public abstract class ProductB
    {
        public ProductB()
        {
            CreatedMessage();
        }

        public abstract void CreatedMessage();
    }

    public class ConcreteProductA1 : ProductA
    {
        public override void CreatedMessage()
        {
            Console.WriteLine("Product A1 is created.");
        }
    }
    
    public class ConcreteProductB1 : ProductB
    {
        public override void CreatedMessage()
        {
            Console.WriteLine("Product B1 is created.");
        }
    }
    
    
    public class ConcreteProductA2 : ProductA
    {
        public override void CreatedMessage()
        {
            Console.WriteLine("Product A2 is created.");
        }
    }

    public class ConcreteProductB2 : ProductB
    {
        public override void CreatedMessage()
        {
            Console.WriteLine("Product B2 is created.");
        }
    }
    
    
    
    
}