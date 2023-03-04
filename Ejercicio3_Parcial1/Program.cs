namespace Ejercicio3_Parcial1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dado un mes ingresado por el usuario, muestra un mensaje de buena suerte, utiliza estructuras switch

            Console.WriteLine("Ingrese un Mes: ");
            string mes = Console.ReadLine();

            switch (mes.ToLower())
            {
                case "enero":
                    Console.WriteLine("Buena suerte con tu Inicio de Año");
                    break;
                case "febrero":
                    Console.WriteLine("Buena suerte con San Valentin");
                    break;
                case "marzo":
                    Console.WriteLine("Buena suerte con la primavera");
                    break;
                case "abril":
                    Console.WriteLine("Felices pascuas");
                    break;
                case "mayo":
                    Console.WriteLine("Feliz dia de la Madre");
                    break;
                case "junio":
                    Console.WriteLine("Feliz dia del Padre");
                    break;
                case "julio":
                    Console.WriteLine("Buena suerte en el Verano");
                    break;
                case "agosto":
                    Console.WriteLine("Que tengas un mes lleno de bendiciones");
                    break;
                case "septiembre":
                    Console.WriteLine("Feliz dia de la Independencia");
                    break;
                case "octubre":
                    Console.WriteLine("Buena suerte en Halloween");
                    break;
                case "noviembre":
                    Console.WriteLine("Feliz Cumpleaños");
                    break;
                case "diciembre":
                    Console.WriteLine("Buena suerte en las fiestas navideñas");
                    break;
                    default:
                    Console.WriteLine("El Mes que introdujiste es invalido");
                    break;
            }
            Console.ReadLine();
        }
    }
}