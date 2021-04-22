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
    
    
    //Creator subclasses will override the Creator class' methods
    public abstract class Creator
    {
        public abstract IProduct CreateProduct();
    }
    
    
    //Product classes will override this interface's methods;
    public interface IProduct
    {
        public void CreatedMessage();
    }
    
    
    //Concrete creator classes will create the related products
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
    
    //These are different products but they are using the same interface
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