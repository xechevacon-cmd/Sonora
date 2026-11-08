using System.Collections;

int opcion;
int opcionSuscripcion;
int opcionModalidad;
int opcionPerfil;
int opcionPreferencias;
int opcionGenero;
double saldoUsuario = 100.50;
string nombre = "Luis";
string correo = "luis.c.l@gmail.com";
string nombreUsuario = "luis.c.l";
string fechaRegistro = "02/04/2025";
int puntos = 100;

do
{
    Console.WriteLine("=======================  ♫ SONORA ♫  =======================");
    Console.WriteLine();
    Console.WriteLine("              ¡Bienvenido a tu espacio musical!              ");
    Console.WriteLine();
    Console.WriteLine("=============================================================");

    Console.WriteLine("                  ¿Qué te gustaría haer hoy?                 ");
    Console.WriteLine();
    Console.WriteLine("1. Suscripciones");
    Console.WriteLine("2. Mi perfil");
    Console.WriteLine("3. Mis pagos");
    Console.WriteLine("4. Mi actividad");
    Console.WriteLine("5. Mis recibos");
    Console.WriteLine("6. Preferencias");
    Console.WriteLine("7.Salir");
    Console.WriteLine();
    Console.WriteLine("============================================================");

    Console.Write("Selecciona una opción");
    opcion = int.Parse(Console.ReadLine()!);

    switch (opcion)
    {
        case 1:
            Console.WriteLine("============== SUSCRIPCIONES ==============");
            Console.WriteLine();
            Console.WriteLine("    ¡Encuentra el plan perfecto para ti!   ");
            Console.WriteLine("1. Explorar modalidades");
            Console.WriteLine("2. Volver al menú principal");
            Console.WriteLine();
            Console.Write("Selecciona una opción");
            opcionSuscripcion = int.Parse(Console.ReadLine()!);

            switch (opcionSuscripcion)
            {
                case 1:
                    Console.WriteLine("=============== MODALIDADES ===============");
                    Console.WriteLine();
                    Console.WriteLine("1. Sonora Basic");
                    Console.WriteLine("2. Sonora Premium");
                    Console.WriteLine("3. Sonora Family");
                    Console.WriteLine("4. Sonora Studio");
                    opcionModalidad = int.Parse(Console.ReadLine()!);

                    switch (opcionModalidad)
                    {
                        case 1:
                            Console.WriteLine("Has elegido Sonoro Basic");
                            Console.WriteLine("Precio: 4,99 €");
                            if (saldoUsuario >= 4.99)
                            {
                                saldoUsuario -= 4.99;
                                Console.WriteLine("¡Suscripción contratada!");
                                Console.WriteLine("Saldo restante: " + saldoUsuario + " €");
                            }
                            else
                            {
                                Console.WriteLine("No tienes saldo suficiente.");
                            }
                            break;
                        
                        case 2:
                            Console.WriteLine("Has elegido Sonora Premium");
                            Console.WriteLine("Precio: 9,99 €");
                            if (saldoUsuario >= 9.99)
                            {
                                saldoUsuario -= 9.99;
                                Console.WriteLine("¡Suscripción contratada!");
                                Console.WriteLine("Saldo restante: " + saldoUsuario + " €");
                            }
                            else
                            {
                                Console.WriteLine("No tienes saldo suficiente.");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Has elegido Sonoro Family");
                            Console.WriteLine("Precio: 14,99 €");
                            if (saldoUsuario >= 14.99)
                            {
                                saldoUsuario -= 14.99;
                                Console.WriteLine("¡Suscripción contratada!");
                                Console.WriteLine("Saldo restante: " + saldoUsuario + " €");
                            }
                            else
                            {
                                Console.WriteLine("No tienes saldo suficiente.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Has elegido Sonoro Studio");
                            Console.WriteLine("Precio: 12,99 €");
                            if (saldoUsuario >= 12.99)
                            {
                                saldoUsuario -= 12.99;
                                Console.WriteLine("¡Suscripción contratada!");
                                Console.WriteLine("Saldo restante: " + saldoUsuario + " €");
                            }
                            else
                            {
                                Console.WriteLine("No tienes saldo suficiente.");
                            }
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                break;
                case 2:
                    Console.WriteLine("Volviendo al menú principal...");
                    break;
            }
            
            break;

            case 2:
            Console.WriteLine("============== MI PERFIL ==============");
            Console.WriteLine();
            Console.WriteLine("1. Consultar mis datos");
            Console.WriteLine("2. Editar mis preferencias");
            Console.WriteLine("2. Volver al menú principal");
            Console.WriteLine();
            Console.Write("Selecciona una opción");
            opcionPerfil = int.Parse(Console.ReadLine()!);

            switch (opcionPerfil)
            {
                case 1:
                    Console.WriteLine("============== MIS DATOS ==============");ç
                    Console.WriteLine();
                    Console.WriteLine("Nombre: " + nombre);
                    Console.WriteLine("Correo electrónico: " + correo);
                    Console.WriteLine("Nombre de usuario: " + nombreUsuario);
                    Console.WriteLine("Fecha de registro: " + fechaRegistro);
                    Console.WriteLine("Puntos: " + puntos);
                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine("============== EDITAR MIS PREFERENCIAS ==============");ç
                    Console.WriteLine();
                    Console.WriteLine("1. Cambiar género musical favorito");
                    Console.WriteLine("2. Activar / desactivar notificaciones");
                    Console.WriteLine("3. Activar / desactivar modo privado");
                    Console.WriteLine("4. Volver al perfil");
                    Console.WriteLine();
                    Console.Write("Selecciona una opción");
                    opcionPreferencias = int.Parse(Console.ReadLine()!);

                    switch (opcionPreferencias)
                    {
                        case 1:
                        Console.WriteLine("============== ELIGE TU GÉNERO FAVORITO ==============");ç
                        Console.WriteLine();
                        Console.WriteLine("1. Pop");
                        Console.WriteLine("2. Rock");
                        Console.WriteLine("3. Electrónica");
                        Console.WriteLine("4. Hip-Hop / Rap");
                        Console.WriteLine("5. Jazz");
                        Console.WriteLine("6. Clásica");
                        Console.WriteLine("7. Indie");
                        Console.WriteLine("8. Volver");
                        Console.WriteLine();
                        Console.Write("Selecciona una opción");
                        opcionGenero = int.Parse(Console.ReadLine()!);

                        switch(opcionGenero)
                        {
                            case 1:
                                Console.WriteLine("Género favorito actualizado");
                                Console.WriteLine("Género favorito: Pop");
                                break;

                            case 2:
                                Console.WriteLine("Género favorito actualizado");
                                Console.WriteLine("Género favorito: Rock");
                                break;

                            case 3:
                                Console.WriteLine("Género favorito actualizado");
                                Console.WriteLine("Género favorito: Electrónica");
                                break;

                            case 4:
                                Console.WriteLine("Género favorito actualizado");
                                Console.WriteLine("Género favorito: Hip-Hop / Rap");
                                break;

                            case 5:
                                Console.WriteLine("Género favorito actualizado");
                                Console.WriteLine("Género favorito: Jazz");
                                break;

                            case 6:
                                Console.WriteLine("Género favorito actualizado");
                                Console.WriteLine("Género favorito: Clásica");
                                break;

                            case 7:
                                Console.WriteLine("Género favorito actualizado");
                                Console.WriteLine("Género favorito: Indie");
                                break;

                            case 8:
                                Console.WriteLine("Volviendo al menú anterior ....");
                                break;

                            default:
                                Console.WriteLine("Opción no válida");
                                break;
                        case  2:

                        }
                    }
            }



























    }

}while(true);
