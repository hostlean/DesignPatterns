using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteCreatorA creatorA = new ConcreteCreatorA();

            ConcreteCreatorB creatorB = new ConcreteCreatorB();

            creatorB.CreateProduct();

            creatorA.CreateProduct();

        }
    }
    
    public abstract class Creator
    {
        public abstract IProduct CreateProduct();
    }
    
    
    public interface IProduct
    {
        public void CreatedMessage();
    }
    
    
    public class ConcreteCreatorA : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
    
    
    public class ConcreteCreatorB : Creator
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
    
    
    public class ConcreteProductA : IProduct
    {

        public ConcreteProductA()
        {
            CreatedMessage();
        }
        
        public void CreatedMessage()
        {
            Console.WriteLine("Product A is created.");
        }
    }
    
    
    public class ConcreteProductB : IProduct
    {
        public ConcreteProductB()
        {
            CreatedMessage();
        }
        
        public void CreatedMessage()
        {
            Console.WriteLine("Product B is created.");
        }
    }
    
    
    
    
    
    
    
}