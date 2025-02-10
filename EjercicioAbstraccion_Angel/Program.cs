
using EjercicioAbstraccion_Angel;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Seleccione la formula que desea calcular:");
            Console.WriteLine("1. Área del triángulo");
            Console.WriteLine("2. Convertir de metros a kilometros");
            Console.WriteLine("3. Convertir de dolares a lempiras ");
            Console.WriteLine("4. Salir");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la base del triangulo: ");
                    double baseTriangulo = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    double alturaTriangulo = double.Parse(Console.ReadLine());
                    Formulas areaTriangulo = new AreaTriangulo(baseTriangulo, alturaTriangulo);
                    areaTriangulo.Imprimir();
                    break;
                case 2:
                    Console.Write("Ingrese los metros: ");
                    double metros = double.Parse(Console.ReadLine());
                    Formulas metrosAKilometros = new MetrosAKilometros(metros);
                    metrosAKilometros.Imprimir();
                    break;
                case 3:
                    Console.Write("Ingrese la cantidad de dólares: ");
                    double dolares = double.Parse(Console.ReadLine());
                    Formulas dolaresALempiras = new DolaresALempiras(dolares);
                    dolaresALempiras.Imprimir();

                    break;
                case 4:
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}
