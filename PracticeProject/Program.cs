// See https://aka.ms/new-console-template for more information
global using PracticeProject.Model;
using FactoryPattern.AbstractFactoryImplementation;
using FactoryPattern.ConcreateLabFactory;

Console.WriteLine("Hello, World!");
CustomerModel customerModel = new CustomerModel();
customerModel.Id = 1;

LabFactory labFactory = new ConcreteLabFactory();
var s = labFactory.GetLab("OM");
s.GetUDF();

ILabFctory labFctory = new CRLLabFactory().GetLabInstance();
Console.WriteLine(labFctory.GeneratedResult());



#region Problem with Code is If more concreate product added then need to add more switch in Concreate Creator
//interface Product
//{

//}

//class ConcreteProductA : Product
//{
//}

//class ConcreteProductB : Product
//{
//}

//abstract class Creator
//{
//    public abstract Product FactoryMethod(string type);
//}

//class ConcreteCreator : Creator
//{
//    public override Product FactoryMethod(string type)
//    {
//        switch (type)
//        {
//            case "A": return new ConcreteProductA();
//            case "B": return new ConcreteProductB();
//            default: throw new ArgumentException("Invalid type", "type");
//        }
//    }
//} 
#endregion