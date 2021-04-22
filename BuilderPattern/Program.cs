using System;

namespace BuilderPattern
{
    class Program
    {
        public static int ProductNumber;
        
        static void Main(string[] args)
        {
            var builder1 = new ConcreteBuilder1();
            var builder2 = new ConcreteBuilder2();
            
            
            var d = new Director(builder1);
            d.Make(Director.BuildingType.Regular);
            builder1.GetResult();

            d.ChangeBuilder(builder2);
            d.Make(Director.BuildingType.Simple);
            builder2.GetResult();

            d.Make(Director.BuildingType.Advenced); 
            builder2.GetResult();
            
            d.ChangeBuilder(builder1);
            d.Make(Director.BuildingType.Advenced);
            builder1.GetResult();


        }
    }


    public class Director
    {
        private IBuilder _builder;

        public enum BuildingType
        {
            Simple,
            Regular,
            Advenced
        }

        private BuildingType _bType;

        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void ChangeBuilder(IBuilder builder)
        {
            _builder = builder;
        }

        public void Make(BuildingType type)
        {
            _bType = type;
            _builder.Reset();

            switch (_bType)
            {
                case BuildingType.Simple:
                    _builder.BuildStepA();
                    break;
                case BuildingType.Regular:
                    _builder.BuildStepA();
                    _builder.BuildStepB();
                    break;
                case BuildingType.Advenced:
                    _builder.BuildStepA();
                    _builder.BuildStepB();
                    _builder.BuildStepC();
                    break;
            }
        }
    }
    

    public interface IBuilder
    {
        public void Reset();

        public void BuildStepA();

        public void BuildStepB();

        public void BuildStepC();

    }

    public class ConcreteBuilder1 : IBuilder
    {
        private Product1 _result;
        
        public void Reset()
        {
            _result = new Product1();
        }

        public void BuildStepA()
        {
            _result.SetFeatureA();
        }

        public void BuildStepB()
        {
            _result.SetFeatureB();
        }

        public void BuildStepC()
        {
            _result.SetFeatureC();
        }

        public Product1 GetResult()
        {
            _result.ShowFeatures();
            return _result;
        }
        
    }
    
    public class ConcreteBuilder2 : IBuilder
    {
        private Product2 _result;
        
        public void Reset()
        {
            _result = new Product2();
        }

        public void BuildStepA()
        {
            _result.SetFeatureA();
        }

        public void BuildStepB()
        {
            _result.SetFeatureB();
        }

        public void BuildStepC()
        {
            _result.SetFeatureC();
        }

        public Product2 GetResult()
        {
            _result.ShowFeatures();
            return _result;
        }
        
    }

    public class Product1
    {
        private bool _hasA, _hasB, _hasC;

        private int count;

        public Product1()
        {
            count = Program.ProductNumber;
            Program.ProductNumber += 1;
        }

        public void SetFeatureA() => _hasA = true;

        public void SetFeatureB() =>  _hasB = true;

        public void SetFeatureC() =>  _hasC = true;

        public void ShowFeatures()
        {
            Console.WriteLine("\n");
            if(_hasA)
                Console.WriteLine($"Product type 1 num {count} Has 'A' Feature");
            if(_hasB)
                Console.WriteLine($"Product type 1 num {count}  Has 'B' Feature");
            if(_hasC)
                Console.WriteLine($"Product type 1 num {count}  Has 'C' Feature");
            
        }
    }

    public class Product2
    {
        private bool _hasA, _hasB, _hasC;

        private int count;

        public Product2()
        {
            count = Program.ProductNumber;
            Program.ProductNumber += 1;
        }
        
        public void SetFeatureA() => _hasA = true;

        public void SetFeatureB() =>  _hasB = true;

        public void SetFeatureC() =>  _hasC = true;

        public void ShowFeatures()
        {
            Console.WriteLine("\n");

            if(_hasA)
                Console.WriteLine($"Product type 2 num {count} Has 'A' Feature");
            if(_hasB)
                Console.WriteLine($"Product type 2 num {count}  Has 'B' Feature");
            if(_hasC)
                Console.WriteLine($"Product type 2 num {count}  Has 'C' Feature");

        }
        
    }
    
    
    
}