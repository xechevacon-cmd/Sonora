string nombrePlan = "";
int opcion;
double precio = 0;
string nombreCliente;
int opcionModalidad;
int serviciosAdicionales;
bool descargasElegidas = false;
bool audioElegido = false;
bool listasCompartidas = false;
int numeroExtras = 0;
double preciosExtras = 0;
int modalidadContratacion;
double descuento = 0;
int mesesContratados = 0;
double total = 0;
double totalMesesContratados;
double totalConDescuento = 0;
double dineroEntregado = 0;
double cambio = 0;
int operacion = 0;
double ingresosTotales = 0;
double importeMedio = 0;
double importeMayor = 0;
string clienteMayorImporte = "";

// FASE 1: Menú principal.
do
{
    Console.WriteLine("=======================  ♫ SONORA ♫  =======================");
    Console.WriteLine();
    Console.WriteLine("                     - Panel de gestión -                   ");
    Console.WriteLine();
    Console.WriteLine("============================================================");
    Console.WriteLine();
    Console.WriteLine("                  ¿Qué te gustaría hacer hoy?                ");
    Console.WriteLine();
    Console.WriteLine("1. Registrar nueva suscripción");
    Console.WriteLine("2. Consultar resumen de ventas");
    Console.WriteLine("3. Salir");
    Console.WriteLine();
    Console.WriteLine("============================================================");

    Console.Write("Selecciona una opción: ");
    opcion = int.Parse(Console.ReadLine()!);

    switch (opcion)
    {
        case 1:
            // FASE 2: Datos del cliente.
            Console.WriteLine("============== NUEVA SUSCRIPCIÓN ==============");
            do
            {
                descargasElegidas = false;
                audioElegido = false;
                listasCompartidas = false;

                numeroExtras = 0;
                preciosExtras = 0;
                totalConDescuento = 0;

                Console.Write("Introduce el nombre del cliente: ");
                nombreCliente = Console.ReadLine()!;

                if (string.IsNullOrWhiteSpace(nombreCliente))
                {
                    Console.WriteLine("El nombre no puede estar vacío.");
                }
            } while (string.IsNullOrWhiteSpace(nombreCliente));

            // FASE 3: Selección deL plan.
            do
            {
                Console.WriteLine("=============== PLANES ===============");
                Console.WriteLine();
                Console.WriteLine("1. Sonora Basic");
                Console.WriteLine("2. Sonora Premium");
                Console.WriteLine("3. Sonora Family");

                Console.Write("Selecciona una modalidad: ");
                opcionModalidad = int.Parse(Console.ReadLine()!);

                if (opcionModalidad < 1 || opcionModalidad > 3)
                {
                    Console.WriteLine("Opción no válida.");
                }
            } while (opcionModalidad < 1 || opcionModalidad > 3);

            switch (opcionModalidad)
            {
                case 1:
                    nombrePlan = "Sonora Basic";
                    precio = 4.99;
                    break;

                case 2:
                    nombrePlan = "Sonora Premium";
                    precio = 7.99;
                    break;

                case 3:
                    nombrePlan = "Sonora Family";
                    precio = 12.99;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (opcionModalidad >= 1 && opcionModalidad <= 3)
            {
                Console.WriteLine("Plan elegido: " + nombrePlan);
                Console.WriteLine("Precio mensual: " + precio + " €");
            }

            // FASE 4: Servicios adicionales.
            do
            {
                Console.WriteLine("=============== SERVICIOS ADICIONALES ===============");
                Console.WriteLine();
                Console.WriteLine("1. Descargar sin conexión (2,00 €)");
                Console.WriteLine("2. Audio de alta calidad (1,50 €)");
                Console.WriteLine("3. Listas compartidas con hasta 3 personas (5,00 €)");
                Console.WriteLine("4. Finalizar selección");

                Console.Write("Selecciona uno o varios servicios adicionales: ");
                serviciosAdicionales = int.Parse(Console.ReadLine()!);

                switch (serviciosAdicionales)
                {
                    case 1:
                        if (descargasElegidas == false)
                        {
                            descargasElegidas = true;
                            numeroExtras++;
                            preciosExtras += 2.00;

                            Console.WriteLine("Descargas sin conexión añadidas.");
                        }
                        else
                        {
                            Console.WriteLine("Este extra ya está seleccionado.");
                        }
                        break;

                    case 2:
                        if (audioElegido == false)
                        {
                            audioElegido = true;
                            numeroExtras++;
                            preciosExtras += 1.50;

                            Console.WriteLine("Audio de calidad añadido.");
                        }
                        else
                        {
                            Console.WriteLine("Este extra ya está seleccionado.");
                        }
                        break;

                    case 3:
                        if (listasCompartidas == false)
                        {
                            listasCompartidas = true;
                            numeroExtras++;
                            preciosExtras += 5.00;

                            Console.WriteLine("Servicio de listas compartidas añadido.");
                        }
                        else
                        {
                            Console.WriteLine("Este extra ya está seleccionado.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Selección de servicios adicionales finalizada...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                //CÓDIGO ACTUALIZADO: mostrar selección
                if (serviciosAdicionales != 4)
                {
                    Console.WriteLine("Número de extras: " + numeroExtras);
                    Console.WriteLine("Coste provisional: " + preciosExtras.ToString("F2") + " €");
                }
            } while (serviciosAdicionales != 4);


            Console.WriteLine("Número de extras elegidos: " + numeroExtras);
            Console.WriteLine("Precio total de los extras: " + preciosExtras.ToString("F2") + " €");

            // FASE 5: Modalidad de contratación.
            do
            {
                Console.WriteLine("=============== MODALIDAD DE CONTRATACIÓN ===============");
                Console.WriteLine();
                Console.WriteLine("1. Mensual");
                Console.WriteLine("2. Anual (15% de descuento)");

                Console.Write("Selecciona una modalidad de contratación: ");
                modalidadContratacion = int.Parse(Console.ReadLine()!);

                if (modalidadContratacion < 1 || modalidadContratacion > 2)
                {
                    Console.Write("Opción no valida.");
                }

            } while (modalidadContratacion < 1 || modalidadContratacion > 2);

            switch (modalidadContratacion)
            {
                case 1:
                    do
                    {
                        Console.Write("¿Cuántos meses?: ");
                        mesesContratados = int.Parse(Console.ReadLine()!);

                        if (mesesContratados <= 0)
                        {
                            Console.WriteLine("Debes contratar al menos un mes.");
                        }
                    } while (mesesContratados <= 0);
                    descuento = 0;
                    Console.WriteLine("Modalidad elegida: Mensual.");
                    break;

                case 2:
                    mesesContratados = 12;
                    descuento = 0.15;
                    Console.WriteLine("Modalidad elegida: Anual");
                    Console.WriteLine("Se aplicará un 15% de descuento.");
                    break;
            }
            total = precio + preciosExtras;
            totalMesesContratados = total * mesesContratados;

            if (modalidadContratacion == 2)
            {
                totalConDescuento = totalMesesContratados * descuento;
                totalMesesContratados -= totalConDescuento;
            }

            // FASE 6: Cálculo del importe.
            Console.WriteLine("==================== PAGO ====================");
            Console.WriteLine();

            Console.WriteLine("Precio del plan:" + (precio * mesesContratados).ToString("F2") + " €");
            Console.WriteLine("Precio de extras: " + (preciosExtras * mesesContratados).ToString("F2") + " €");
            Console.WriteLine("Subtotal: " + (total * mesesContratados).ToString("F2") + " €");

            if(modalidadContratacion == 2)
            {
                Console.WriteLine("Subtotal: " + totalConDescuento.ToString("F2") + " €");

            }
            Console.WriteLine("TOTAL A PAGAR: " + totalMesesContratados.ToString("F2") + " €");
            Console.WriteLine("===============================================");
            do
            {
                Console.Write("Introduce el dinero entregado: ");
                dineroEntregado = double.Parse(Console.ReadLine()!);

                if (Math.Round(dineroEntregado,2) < Math.Round(totalMesesContratados, 2))
                {
                    Console.WriteLine("Dinero insuficiente");
                }
            } while (dineroEntregado < totalMesesContratados);

            cambio = dineroEntregado - totalMesesContratados;
            operacion++;

            ingresosTotales += totalMesesContratados;

            if (totalMesesContratados > importeMayor)
            {
                importeMayor = totalMesesContratados;
                clienteMayorImporte = nombreCliente;
            }


            Console.WriteLine("Pago realizado correctamente.");
            Console.WriteLine("Cambio: " + cambio.ToString("F2") + " €");

            // FASE 7: Justificante.
            Console.WriteLine("=======================  ♫ SONORA - JUSTIFICANTE ♫  =======================");
            Console.WriteLine();
            Console.WriteLine("Número de operación: " + operacion);
            Console.WriteLine("Cliente: " + nombreCliente);
            Console.WriteLine();
            Console.WriteLine("Plan: " + nombrePlan);
            if (modalidadContratacion == 1)
            {
                Console.WriteLine("Modalidad: Mensual");
            }
            else
            {
                Console.WriteLine("Modalidad: Anual");
            }
            Console.WriteLine();
            Console.WriteLine("Extras:");
            if (numeroExtras == 0)
            {
                Console.WriteLine("No se han contratado extras.");
            }
            else
            {
                if (descargasElegidas == true)
                {
                    Console.WriteLine("Descargas sin conexión");
                }
                if (audioElegido == true)
                {
                    Console.WriteLine("Audio de alta calidad");
                }
                if (listasCompartidas == true)
                {
                    Console.WriteLine("Listas compartidas con hasta 3 personas.");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Precio del plan: " + (precio * mesesContratados).ToString("F2") + " €");
            Console.WriteLine("Precio de extras: " + (preciosExtras * mesesContratados).ToString("F2") + " €");
            Console.WriteLine("Subtotal: " + (total * mesesContratados).ToString("F2") + " €");
            if (modalidadContratacion == 2)
            {
                Console.WriteLine("Descuento anual (15 %): " + totalConDescuento.ToString("F2") + " €");
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL: " + totalMesesContratados.ToString("F2") + " €");
            Console.WriteLine("Dinero entregado: " + dineroEntregado.ToString("F2") + " €");
            Console.Write("Cambio: " + cambio.ToString("F2") + " €");

            break;

        case 2:
            // FASE 8: Resumen de ventas.
            Console.WriteLine("=======================  RESUMEN DE VENTAS  =======================");
            Console.WriteLine();

            if (operacion == 0)
            {
                Console.WriteLine("Todavía no hay operaciones registradas.");
            }
            else
            {
                importeMedio = ingresosTotales / operacion;

                Console.WriteLine("Suscripciones contratadas: " + operacion);
                Console.WriteLine();

                Console.WriteLine("Ingreso totales: " + ingresosTotales.ToString("F2") + " €");
                Console.WriteLine("Importe medio: " + importeMedio.ToString("F2") + " €");
                Console.WriteLine();

                Console.WriteLine("Contratación de mayor importe: ");
                Console.WriteLine("Cliente: " + clienteMayorImporte);
                Console.WriteLine("Importe: " + importeMayor.ToString("F2") + " €");

            }
            Console.WriteLine();
            Console.WriteLine("==================================================================");
            break;

        case 3:
            Console.WriteLine("========================  ¡HASTA PRONTO!  ========================");
            Console.WriteLine();

            Console.WriteLine("Suscripciones registradas: " + operacion);
            Console.WriteLine("Ingresos totales: " + ingresosTotales.ToString("F2") + " €");
            Console.WriteLine();
            Console.WriteLine("=================================================================");
            break;

        default:
            Console.WriteLine("Opción no válida.");
            break;
    }

} while (opcion != 3);