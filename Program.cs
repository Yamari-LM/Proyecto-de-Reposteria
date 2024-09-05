using System;

class Reposteria
{
    static void Main(string[] Args)
    {
        Console.WriteLine("BIENVENIDO A REPOSTERIA LISETH");
        Console.WriteLine();
        Console.WriteLine("FAVOR INGRESE SU NOMBRE");
        string Nombre = Console.ReadLine();
        Console.WriteLine("FAVOR INGRESE SU EDAD");
        int Edad = Convert.ToInt32(Console.ReadLine());

        double total = 0;
        bool continuarCompra = true;

        while (continuarCompra)
        {
            Console.WriteLine("ELIJA LA SECCIÓN DE SU PRODUCTO");
            Console.WriteLine("K. PASTELES");
            Console.WriteLine("S. POSTRES PEQUEÑOS");
            Console.WriteLine("Y. CAFÉS");
            Console.WriteLine("L. HELADOS");
            Console.WriteLine("X. FRAPPÉS");
            Console.WriteLine("C. SALIR");

            string SECCION = Console.ReadLine();
            double PRECIO = 0;
            double IMPUESTO = 0;
            double DESCUENTO = 0;
            int CANTIDAD = 0;

            if (SECCION == "C")
            {
                continuarCompra = false;
                Console.WriteLine($"Total a pagar: {total} Lps");
                Console.WriteLine("¡Gracias, vuelva pronto!");
                continue;
            }

            Console.WriteLine("FAVOR INGRESE LA CANTIDAD");
            CANTIDAD = Convert.ToInt32(Console.ReadLine());

            if (CANTIDAD > 100)
            {
                Console.WriteLine("La cantidad máxima por transacción es 100 productos.");
                continue;
            }

            string PRODUCTO = "";

            if (SECCION == "K")
            {
                Console.WriteLine("ESTAS SON LAS OPCIONES QUE TENEMOS EN ESTA SECCIÓN:");
                Console.WriteLine("A. VAINILLA 15 Lps ");
                Console.WriteLine("B. 3 LECHES 20 Lps");
                Console.WriteLine("C. FERRERO 54 Lps");
                Console.WriteLine("D. OREO 60 Lps");
                Console.WriteLine("E. ZANAHORIA 30 Lps");
                PRODUCTO = Console.ReadLine();

                if (PRODUCTO == "A")
                {
                    PRECIO = 15;
                }
                else if (PRODUCTO == "B")
                {
                    PRECIO = 20;
                }
                else if (PRODUCTO == "C")
                {
                    PRECIO = 54;
                }
                else if (PRODUCTO == "D")
                {
                    PRECIO = 60;
                }
                else if (PRODUCTO == "E")
                {
                    PRECIO = 30;
                }
                else Console.WriteLine("No tenemos el producto seleccionado");

                IMPUESTO = 1;
            }
            else if (SECCION == "S")
            {
                Console.WriteLine("ESTAS SON LAS OPCIONES QUE TENEMOS EN ESTA SECCIÓN:");
                Console.WriteLine("A. BROWNIES 10 Lps ");
                Console.WriteLine("B. MINI PASTELES 10 Lps");
                Console.WriteLine("C. MINI PAYS 10 Lps");
                Console.WriteLine("D. OREO 10 Lps");
                PRODUCTO = Console.ReadLine();

                if (PRODUCTO == "A")
                {
                    PRECIO = 10;
                }
                else if (PRODUCTO == "B")
                {
                    PRECIO = 10;
                }
                else if (PRODUCTO == "C")
                {
                    PRECIO = 10;
                }
                else if (PRODUCTO == "D")
                {
                    PRECIO = 10;
                }
                else if (PRODUCTO == "E")
                {
                    PRECIO = 10;
                }
                else Console.WriteLine("No tenemos el producto seleccionado");

                IMPUESTO = 2;
            }
            else if (SECCION == "Y")
            {
                Console.WriteLine("ESTAS SON LAS OPCIONES QUE TENEMOS EN ESTA SECCIÓN:");
                Console.WriteLine("A. AMERICANO 12 Lps ");
                Console.WriteLine("B. CAPUCHINO 10 Lps");
                Console.WriteLine("C. LATTE 14 Lps");
                Console.WriteLine("D. ESPRESSO 10 Lps");
                Console.WriteLine("E. MACCHIATO 10 Lps");
                PRODUCTO = Console.ReadLine();

                if (PRODUCTO == "A")
                {
                    PRECIO = 12;
                }
                else if (PRODUCTO == "B")
                {
                    PRECIO = 10;
                }
                else if (PRODUCTO == "C")
                {
                    PRECIO = 14;
                }
                else if (PRODUCTO == "D")
                {
                    PRECIO = 10;
                }
                else if (PRODUCTO == "E")
                {
                    PRECIO = 10;
                }
                else Console.WriteLine("No tenemos el producto seleccionado");

                IMPUESTO = 0.09;
            }
            else if (SECCION == "L")
            {
                Console.WriteLine("ESTAS SON LAS OPCIONES QUE TENEMOS EN ESTA SECCIÓN:");
                Console.WriteLine("A. CHOCOLATE 5 Lps ");
                Console.WriteLine("B. MORA 9 Lps");
                Console.WriteLine("C. MANGO 8 Lps");
                Console.WriteLine("D. CHICLE 10 Lps");
                Console.WriteLine("E. CEREZA 9 Lps");
                PRODUCTO = Console.ReadLine();

                if (PRODUCTO == "A")
                {
                    PRECIO = 5;
                }
                else if (PRODUCTO == "B")
                {
                    PRECIO = 9;
                }
                else if (PRODUCTO == "C")
                {
                    PRECIO = 8;
                }
                else if (PRODUCTO == "D")
                {
                    PRECIO = 10;
                }
                else if (PRODUCTO == "E")
                {
                    PRECIO = 9;
                }
                else Console.WriteLine("No tenemos el producto seleccionado");

                IMPUESTO = 2;
            }
            else if (SECCION == "X")
            {
                Console.WriteLine("ESTAS SON LAS OPCIONES QUE TENEMOS EN ESTA SECCIÓN:");
                Console.WriteLine("A. FRESA-KIWI 13 Lps ");
                Console.WriteLine("B. MANGO-PIÑA 15 Lps");
                Console.WriteLine("C. SANDÍA-FRESA 18 Lps");
                Console.WriteLine("D. NUTELLA-FERRERO 10 Lps");
                Console.WriteLine("E. CEREZA 19 Lps");
                PRODUCTO = Console.ReadLine();

                if (PRODUCTO == "A")
                {
                    PRECIO = 13;
                }
                else if (PRODUCTO == "B")
                {
                    PRECIO = 15;
                }
                else if (PRODUCTO == "C")
                {
                    PRECIO = 18;
                }
                else if (PRODUCTO == "D")
                {
                    PRECIO = 10;
                }
                else if (PRODUCTO == "E")
                {
                    PRECIO = 19;
                }
                else Console.WriteLine("No tenemos el producto seleccionado");

                IMPUESTO = 3;
            }

            double subtotal = PRECIO * CANTIDAD;
            double montoImpuesto = subtotal * IMPUESTO;
            double descuento = 0;

            if (CANTIDAD > 10)
            {
                DESCUENTO = subtotal * 3;
            }

            double precioFinal = subtotal + montoImpuesto - descuento;
            total += precioFinal;

            Console.WriteLine($"Subtotal: {subtotal} Lps");
            Console.WriteLine($"Impuesto: {montoImpuesto} Lps");
            Console.WriteLine($"Descuento: {descuento} Lps");
            Console.WriteLine($"Total a pagar por el producto: {precioFinal} Lps");
            Console.WriteLine();
        }
    }
}

