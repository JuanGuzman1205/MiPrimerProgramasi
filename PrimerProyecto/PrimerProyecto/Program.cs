/*Enunciado:
 * Ingresar por pantalla 2 números y calcular las 4 operaciones aritméticas con dichos números.
 * Imprimir en pantalla el resultado de cada operacion*/

//1ro: definir el nombre de mi clase
public class MiPrimerPrograma
{

    static void Main(string[] args)
    {
        //2do. Declaracion de variables (Datos de entrada)
        int num1, num2, suma, resta, producto, Cociente ; //Quemar codigo: poner valores directamente a las variables sin pedirlos desde la consola

        //3ro. Pedir los valores por pantalla (consola)
        Console.Write("Ingrese su primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        //4to. Calculos (Procesos)
        suma = num1 + num2;
        resta = num1 - num2;
        producto = num1 * num2;
        Cociente = num1 / num2;

        //5to. Imprimir los resultados (Datos de salida)
        Console.Write("La suma es: " + suma );
        Console.Write("\n");
        Console.Write("La resta es: " + resta);
        Console.Write("\n");
        Console.Write("El producto es: " + producto);
        Console.Write("\n");
        Console.Write("El cociente es: " + Cociente);
    }
    

    

}