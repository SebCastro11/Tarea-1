using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appEP2_SebastianCastroNunez
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string[] proveedores = new string[0];
            String[] flores = { "Rosa", "Girasol", "Tulipán", "Clavel", "Lirio" };
            int op, CantProv, cantFlores;
            double subtotal, total, IVA;
            string proveedor, look_Flor, look_Prov, precioun;

          
            op = 0;
            total = 0;
            cantFlores = 0;
            subtotal = 0;
            CantProv = 0;
            IVA = 0;
            proveedor = "";
            precioun = string.Empty;
            look_Flor = string.Empty;
            look_Prov = string.Empty;


            while (op != 5) 
            {

                Console.Clear();

                Console.WriteLine("**** Victoria's Flower Shop ****");
                Console.WriteLine(" 1. Ver Flores \n 2. Ingresar proveedores \n 3. Ver Proveedores \n 4. Pedido \n 5. Salir");

                Console.WriteLine("Ingrese la opcion deseada: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        Console.Clear();                        

                        Console.WriteLine("**** Lista de Flores ****");

                        Console.WriteLine(flores[0]);
                        Console.WriteLine(flores[1]);
                        Console.WriteLine(flores[2]);
                        Console.WriteLine(flores[3]);
                        Console.WriteLine(flores[4]);

                        Console.WriteLine(" ");
                        Console.WriteLine("Presione una tecla para volver al menu. ");
                        Console.ReadKey();
                        break;


                    case 2:

                        Console.Clear();                        

                        Console.WriteLine("Ingrese la cantidad de proveedores: ");
                        CantProv = int.Parse(Console.ReadLine());

                        proveedores = new string[CantProv];

                        for (int i = 0; i < proveedores.Length; i++)
                        {
                            Console.WriteLine("Ingrese el nombre del proveedor " + (i + 1));
                            proveedor = Console.ReadLine();

                            proveedores[i] = proveedor;

                        }

                        break;


                    case 3:

                        Console.Clear();                        

                        Console.WriteLine("**** Lista de Proveedores ****");

                        for (int i = 0; i < proveedores.Length; i++)
                        {
                            Console.WriteLine(proveedores[i]);

                        }

                        Console.WriteLine(" ");
                        Console.WriteLine("Presione una tecla para volver al menu. ");
                        Console.ReadKey();
                        break;


                    case 4:

                        Console.Clear();

                        Console.WriteLine("Ingrese la flor que desea:");
                        look_Flor = Console.ReadLine();

                        Console.WriteLine("Ingrese el proveedor que desea:");
                        look_Prov = Console.ReadLine();

                        for (int i = 0; i < flores.Length; i++)
                        {
                            if (flores[i] == look_Flor)
                            {
                                for (int j = 0; j < proveedores.Length; j++)
                                {
                                    if (proveedores[i] == look_Prov)
                                    {                                        
                                        break;
                                        
                                    } else
                                    {
                                        
                                        Console.WriteLine("No se puede procesar su pedido.");
                                        Console.ReadKey();

                                        break;
                                    }

                                }

                            }
                            else
                            {
                                Console.WriteLine("No se puede procesar su pedido.");
                                Console.ReadKey();

                                break;
                            }
                        }

                        Console.Clear() ;

                        Console.WriteLine("Ingrese la cantidad de flores: ");
                        cantFlores = int.Parse(Console.ReadLine());

                        Console.ReadKey();

                        if (look_Flor == "Rosa")
                        {
                            precioun = "600";
                            subtotal = cantFlores * 600;

                        }
                        else if (look_Flor == "Girasol")
                        {
                            precioun = "1200";
                            subtotal = cantFlores * 1200;

                        }
                        else if (look_Flor == "Tulipán")
                        {
                            precioun = "3000";
                            subtotal = cantFlores * 3000;

                        }
                        else if (look_Flor == "Clavel")
                        {
                            precioun = "2500";
                            subtotal = cantFlores * 2500;

                        }
                        else if (look_Flor == "Lirio")
                        {

                            precioun = "1500";
                            subtotal = cantFlores * 1500;

                        }

                        IVA = subtotal * 0.02;

                        total = subtotal + IVA;

                        Console.Clear();

                        Console.WriteLine("     Victoria's Flower Shop ");
                        Console.WriteLine(" ");

                        Console.WriteLine("Proveedor: " + look_Prov);
                        Console.WriteLine("Tipo de flor: " + look_Flor);
                        Console.WriteLine("Cantidad: " + cantFlores);
                        Console.WriteLine("Proveedor: " + look_Prov);
                        Console.WriteLine("Precio por unidad: " + precioun);
                        Console.WriteLine("Subtotal: " + subtotal);
                        Console.WriteLine("IVA: " + IVA);
                        Console.WriteLine("Total: " + total);

                        Console.WriteLine(" ");
                        Console.WriteLine("¡Muchas gracias por su preferencia!");

                        Console.ReadKey();




                        break;


                    case 5:

                        Console.Clear () ;
                        Console.WriteLine("Saliendo... ");
                        Console.ReadKey();


                        break;


                    default:
                        Console.WriteLine("Seleccione una opcion valida.");

                        Console.ReadKey ();

                        break;
                }
            
            
            
            
            }


        }
    }
}
