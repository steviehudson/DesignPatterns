namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class ConcreteProductB2 : IAbstractProductB
    {
        string IAbstractProductB.UsefulFunctionB() => "The result of the product B2.";

        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UsefulFunctionA();

            return $"The result of the B2 collaborator with the ({result})";
        }
    }
}