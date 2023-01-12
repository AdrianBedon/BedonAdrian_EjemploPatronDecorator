using BedónAdrián_EjemploPatronDecorator;

Cliente cliente = new Cliente();

var simple = new ComponenteConcreto();
Console.WriteLine("Cliente: Obtuve un componente simple: ");
cliente.ClienteCode(simple);
Console.WriteLine();

DecoratorConcretoA decoratorA = new DecoratorConcretoA(simple);
DecoratorConcretoB decoratorB = new DecoratorConcretoB(decoratorA);
Console.WriteLine("Cliente: Ahora obtuve un componente decorated: ");
cliente.ClienteCode(decoratorB);