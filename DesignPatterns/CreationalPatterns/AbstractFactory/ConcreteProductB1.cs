namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class ConcreteProductB1 : IAbstractProductB
    {
        string IAbstractProductB.UsefulFunctionB() => "The result of the product B1.";

        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B1 collaborator with the ({result})";
        }
    }
}