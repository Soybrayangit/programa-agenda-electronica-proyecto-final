using System;

namespace ProyectoFinal
{

    class AgendaElectronica
    {
        static void Main(string[] args)
        {
            int opt = 0;
            bool CONTINUAR = true;

            while (CONTINUAR == true)
            {
                //BIENVENIDO AL MENU PRINCIPAL 

                Console.WriteLine("████████╗███████╗  ██████╗░░█████╗░███╗░░░███╗░█████╗░░██████╗  ██╗░░░░░░█████╗░");
                Console.WriteLine("╚══██╔══╝██╔════╝  ██╔══██╗██╔══██╗████╗░████║██╔══██╗██╔════╝  ██║░░░░░██╔══██╗");
                Console.WriteLine("░░░██║░░░█████╗░░  ██║░░██║███████║██╔████╔██║██║░░██║╚█████╗░  ██║░░░░░███████║");
                Console.WriteLine("░░░██║░░░██╔══╝░░  ██║░░██║██╔══██║██║╚██╔╝██║██║░░██║░╚═══██╗  ██║░░░░░██╔══██║");
                Console.WriteLine("░░░██║░░░███████╗  ██████╔╝██║░░██║██║░╚═╝░██║╚█████╔╝██████╔╝  ███████╗██║░░██║");
                Console.WriteLine("░░░╚═╝░░░╚══════╝  ╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝░╚════╝░╚═════╝░  ╚══════╝╚═╝░░╚═╝");

                Console.WriteLine("██████╗░██╗███████╗███╗░░██╗██╗░░░██╗███████╗███╗░░██╗██╗██████╗░░█████╗░██╗");
                Console.WriteLine("██╔══██╗██║██╔════╝████╗░██║██║░░░██║██╔════╝████╗░██║██║██╔══██╗██╔══██╗██║");
                Console.WriteLine("██████╦╝██║█████╗░░██╔██╗██║╚██╗░██╔╝█████╗░░██╔██╗██║██║██║░░██║███████║██║");
                Console.WriteLine("██╔══██╗██║██╔══╝░░██║╚████║░╚████╔╝░██╔══╝░░██║╚████║██║██║░░██║██╔══██║╚═╝");
                Console.WriteLine("██████╦╝██║███████╗██║░╚███║░░╚██╔╝░░███████╗██║░╚███║██║██████╔╝██║░░██║██╗");
                Console.WriteLine("╚═════╝░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚══╝╚═╝╚═════╝░╚═╝░░╚═╝╚═╝");

                Console.WriteLine("Presione cualquier tecla para acceder al menu principal:");
                Console.ReadKey();
                Console.Clear();


                Console.WriteLine("██████╗░██╗███████╗███╗░░██╗██╗░░░██╗███████╗███╗░░██╗██╗██████╗░░█████╗░░██████╗░░░░██╗░█████╗░░██████╗");
                Console.WriteLine("██╔══██╗██║██╔════╝████╗░██║██║░░░██║██╔════╝████╗░██║██║██╔══██╗██╔══██╗██╔════╝░░░██╔╝██╔══██╗██╔════╝");
                Console.WriteLine("██████╦╝██║█████╗░░██╔██╗██║╚██╗░██╔╝█████╗░░██╔██╗██║██║██║░░██║██║░░██║╚█████╗░░░██╔╝░███████║╚█████╗░");
                Console.WriteLine("██╔══██╗██║██╔══╝░░██║╚████║░╚████╔╝░██╔══╝░░██║╚████║██║██║░░██║██║░░██║░╚═══██╗░██╔╝░░██╔══██║░╚═══██╗");
                Console.WriteLine("██████╦╝██║███████╗██║░╚███║░░╚██╔╝░░███████╗██║░╚███║██║██████╔╝╚█████╔╝██████╔╝██╔╝░░░██║░░██║██████╔╝");
                Console.WriteLine("╚═════╝░╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═╝░░╚══╝╚═╝╚═════╝░░╚════╝░╚═════╝░╚═╝░░░░╚═╝░░╚═╝╚═════╝░");

                Console.WriteLine("░█████╗░██╗░░░░░  ███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗");
                Console.WriteLine("██╔══██╗██║░░░░░  ████╗░████║██╔════╝████╗░██║██║░░░██║");
                Console.WriteLine("███████║██║░░░░░  ██╔████╔██║█████╗░░██╔██╗██║██║░░░██║");
                Console.WriteLine("██╔══██║██║░░░░░  ██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║");
                Console.WriteLine("██║░░██║███████╗  ██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝");
                Console.WriteLine("╚═╝░░╚═╝╚══════╝  ╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░");

                Console.WriteLine("██████╗░██████╗░██╗███╗░░██╗░█████╗░██╗██████╗░░█████╗░██╗░░░░░  ██████╗░███████╗");
                Console.WriteLine("██╔══██╗██╔══██╗██║████╗░██║██╔══██╗██║██╔══██╗██╔══██╗██║░░░░░  ██╔══██╗██╔════╝");
                Console.WriteLine("██████╔╝██████╔╝██║██╔██╗██║██║░░╚═╝██║██████╔╝███████║██║░░░░░  ██║░░██║█████╗░░");
                Console.WriteLine("██╔═══╝░██╔══██╗██║██║╚████║██║░░██╗██║██╔═══╝░██╔══██║██║░░░░░  ██║░░██║██╔══╝░░");
                Console.WriteLine("██║░░░░░██║░░██║██║██║░╚███║╚█████╔╝██║██║░░░░░██║░░██║███████╗  ██████╔╝███████╗");
                Console.WriteLine("╚═╝░░░░░╚═╝░░╚═╝╚═╝╚═╝░░╚══╝░╚════╝░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚══════╝  ╚═════╝░╚══════╝");

                Console.WriteLine("███████╗██╗░░░██╗███╗░░██╗░█████╗░██╗░█████╗░███╗░░██╗░█████╗░██╗░░░░░██╗██████╗░░█████╗░██████╗░███████╗░██████╗");
                Console.WriteLine("██╔════╝██║░░░██║████╗░██║██╔══██╗██║██╔══██╗████╗░██║██╔══██╗██║░░░░░██║██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔════╝");
                Console.WriteLine("█████╗░░██║░░░██║██╔██╗██║██║░░╚═╝██║██║░░██║██╔██╗██║███████║██║░░░░░██║██║░░██║███████║██║░░██║█████╗░░╚█████╗░");
                Console.WriteLine("██╔══╝░░██║░░░██║██║╚████║██║░░██╗██║██║░░██║██║╚████║██╔══██║██║░░░░░██║██║░░██║██╔══██║██║░░██║██╔══╝░░░╚═══██╗");
                Console.WriteLine("██║░░░░░╚██████╔╝██║░╚███║╚█████╔╝██║╚█████╔╝██║░╚███║██║░░██║███████╗██║██████╔╝██║░░██║██████╔╝███████╗██████╔╝");
                Console.WriteLine("╚═╝░░░░░░╚═════╝░╚═╝░░╚══╝░╚════╝░╚═╝░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░╚══════╝╚═════╝░");

                

                //--------------MENU PRINCIPAL------------------
                
                Console.WriteLine("Presione [1] para Contactos");
                Console.WriteLine("Presione [2] para Eventos");
                Console.WriteLine("Presione [3] para Aplicaciones");
                Console.WriteLine("Presione [4] para Salir");

                Console.Write("\nIngrese la opción deseada: ");
                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        #region Contactos
                        Console.Clear();
                        string nombreContacto;
                        string apellidoContacto;
                        string telefono;
                        string direccion;
                        string email;
                        bool seguirContacto = true;
                        int numContacto = 0;

                        while (seguirContacto == true)
                        {
                            int OPCCONTACTO = 0;

                            Console.WriteLine("\t¿Qué proceso desea realizar?");
                            Console.WriteLine("Presione [1] para registar contacto");
                            Console.WriteLine("Presione [2] para editar contacto");
                            Console.WriteLine("Presione [3] para borrar contacto");
                            Console.WriteLine("Presione [4] para buscar contacto");
                            Console.WriteLine("Presione [5] para Salir");
                            
                            OPCCONTACTO = Convert.ToInt32(Console.ReadLine());

                            switch (OPCCONTACTO)
                            {
                                case 1:       //REGISTAR CONTACTO
                                    Console.Clear();    
                                    Console.WriteLine("\t*Ingrese el nombre del contacto que desea registar--");
                                    nombreContacto = Console.ReadLine()!;
                                    Console.WriteLine("\t|Ingrese el apellido de {0}-->", nombreContacto);
                                    apellidoContacto = Console.ReadLine()!;
                                    Console.WriteLine("\t--Ingrese el telefono de {0}-->", nombreContacto);
                                    telefono = Console.ReadLine()!;
                                    Console.WriteLine("\t--Ingrese la direccion de {0}-->", nombreContacto);
                                    direccion = Console.ReadLine()!;
                                    Console.WriteLine("\t--Ingrese el email de {0}-->", nombreContacto);
                                    email = Console.ReadLine()!;
                                    LlenarYEditarContacto(nombreContacto, apellidoContacto, telefono, direccion, email, numContacto);
                                    numContacto++;
                                    Console.Clear();
                                    break;

                                case 2:         //EDITAR CONTACTO
                                    Console.Clear();
                                    Console.WriteLine("Cual contacto desea editar?");
                                    for (int i = 0; i < numContacto; i++)
                                    {
                                        Console.WriteLine(i + " " + ArrayDB.NombresContactos[i]);
                                    }
                                    Console.Write("Ingrese su opcion: ");
                                    int OPC = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("\t|Ingrese el nuevo nombre del contacto--");
                                    nombreContacto = Console.ReadLine()!;
                                    Console.WriteLine("\t|Ingrese el apellido de {0}-->", nombreContacto);
                                    apellidoContacto = Console.ReadLine()!;
                                    Console.WriteLine("\t|Ingrese el telefono de {0}-->", nombreContacto);
                                    telefono = Console.ReadLine()!;
                                    Console.WriteLine("\t|Ingrese el direccion de {0}-->", nombreContacto);
                                    direccion = Console.ReadLine()!;
                                    Console.WriteLine("\t|Ingrese el email de {0}-->", nombreContacto);
                                    email = Console.ReadLine()!;
                                    LlenarYEditarContacto(nombreContacto, apellidoContacto, telefono, direccion, email, OPC);
                                    Console.Clear();
                                    break;

                                case 3:         //BORRAR CONTACTO 
                                    Console.Clear();
                                    Console.Write("¿Cual contacto desea borrar?\n");
                                    for (int i = 0; i < numContacto; i++)
                                    {
                                        Console.WriteLine(i + " " + ArrayDB.NombresContactos[i]);
                                    }
                                    OPC = Convert.ToInt32(Console.ReadLine());
                                    BorrarContacto(OPC);
                                    Console.Clear();
                                    break;

                                case 4:         //BUSCAR CONTACTO POR REFERENCIA
                                    Console.Clear();
                                    Console.WriteLine("Escriba la informacion precisa del contacto que desea buscar : ya sea por el nombre, apellido, telefono, direccion o gmail");
                                    Console.WriteLine("****************************ES SENSIBLE A LAS MINUSCULAS Y MAYUSCULAS*******************************");
                                    string BUSCAR = Console.ReadLine()!;
                                    int BUSCARNUM = 0;
                                    if (ArrayDB.NombresContactos.Contains(BUSCAR) == true)
                                    {
                                        foreach (string a in ArrayDB.NombresContactos)
                                        {
                                            if (a == BUSCAR)
                                            {
                                                Console.WriteLine("\nNombre del contacto: " + ArrayDB.NombresContactos[BUSCARNUM]);
                                                Console.WriteLine("Apellido del contacto: " + ArrayDB.ApellidoContactos[BUSCARNUM]);
                                                Console.WriteLine("Telefono del contacto: " + ArrayDB.TelefonoContactos[BUSCARNUM]);
                                                Console.WriteLine("direccion del contacto: " + ArrayDB.DireccionContactos[BUSCARNUM]);
                                                Console.WriteLine("Gmail del contacto: " + ArrayDB.GmailContactos[BUSCARNUM] + "\n");
                                            }
                                            else
                                            {
                                                BUSCARNUM++;
                                            }
                                        }
                                    }
                                    else if (ArrayDB.ApellidoContactos.Contains(BUSCAR) == true)
                                    {
                                        foreach (string a in ArrayDB.ApellidoContactos)
                                        {
                                            if (a == BUSCAR)
                                            {
                                                Console.WriteLine("Nombre del contacto: " + ArrayDB.NombresContactos[BUSCARNUM]);
                                                Console.WriteLine("Apellido del contacto: " + ArrayDB.ApellidoContactos[BUSCARNUM]);
                                                Console.WriteLine("Telefono del contacto: " + ArrayDB.TelefonoContactos[BUSCARNUM]);
                                                Console.WriteLine("direccion del contacto: " + ArrayDB.DireccionContactos[BUSCARNUM]);
                                                Console.WriteLine("Gmail del contacto: " + ArrayDB.GmailContactos[BUSCARNUM] + "\n");
                                            }
                                            else
                                            {
                                                BUSCARNUM++;
                                            }
                                        }
                                    }
                                    else if (ArrayDB.TelefonoContactos.Contains(BUSCAR) == true)
                                    {
                                        foreach (string a in ArrayDB.TelefonoContactos)
                                        {
                                            if (a == BUSCAR)
                                            {
                                                Console.WriteLine("Nombre del contacto: " + ArrayDB.NombresContactos[BUSCARNUM]);
                                                Console.WriteLine("Apellido del contacto: " + ArrayDB.ApellidoContactos[BUSCARNUM]);
                                                Console.WriteLine("Telefono del contacto: " + ArrayDB.TelefonoContactos[BUSCARNUM]);
                                                Console.WriteLine("direccion del contacto: " + ArrayDB.DireccionContactos[BUSCARNUM]);
                                                Console.WriteLine("Gmail del contacto: " + ArrayDB.GmailContactos[BUSCARNUM] + "\n");
                                            }
                                            else
                                            {
                                                BUSCARNUM++;
                                            }
                                        }
                                    }
                                    else if (ArrayDB.GmailContactos.Contains(BUSCAR) == true)
                                    {
                                        foreach (string a in ArrayDB.GmailContactos)
                                        {
                                            if (a == BUSCAR)
                                            {
                                                Console.WriteLine("Nombre del contacto: " + ArrayDB.NombresContactos[BUSCARNUM]);
                                                Console.WriteLine("Apellido del contacto: " + ArrayDB.ApellidoContactos[BUSCARNUM]);
                                                Console.WriteLine("Telefono del contacto: " + ArrayDB.TelefonoContactos[BUSCARNUM]);
                                                Console.WriteLine("direccion del contacto: " + ArrayDB.DireccionContactos[BUSCARNUM]);
                                                Console.WriteLine("Gmail del contacto: " + ArrayDB.GmailContactos[BUSCARNUM] + "\n");
                                            }
                                            else
                                            {
                                                BUSCARNUM++;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Acabamos de realizar la busqueda y parece que el contacto que ingreso no esta registrado");
                                    }

                                    break;

                                case 5:
                                    seguirContacto = false;
                                    break;
                            }

                        }
                        Console.Clear();
                        #endregion    //sirve para terminar una region
                        break;
                    case 2:
                          
                        #region eventos
                        Console.Clear();
                        string nom;
                        string fec;
                        string hor;
                        string lug;
                        bool seguir = true;
                        int NUM = 0;

                        while (seguir == true)
                        {
                            int opc = 0;

                            Console.WriteLine("¿Qué desea hacer?\n");
                            Console.WriteLine("Presione [1] para Introducir un evento");
                            Console.WriteLine("Presione [2] para Editar evento");
                            Console.WriteLine("Presione [3] para Eliminar evento");
                            Console.WriteLine("Presione [4] para Buscar evento");
                            Console.WriteLine("Presione [5] para Salir");
                            opc = Convert.ToInt32(Console.ReadLine());

                            switch (opc)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("\t|Ingrese el nombre del evento--");
                                    nom = Console.ReadLine()!;
                                    Console.WriteLine("\t|Ingrese la fecha del evento en este formato dia/mes/año--");
                                    fec = Console.ReadLine()!;
                                    Console.WriteLine("\t|Ingrese la hora del evento en este formato hh:mm--");
                                    hor = Console.ReadLine()!;
                                    Console.WriteLine("\t|Ingrese el lugar del -->", nom);
                                    lug = Console.ReadLine()!;
                                    AGREGARYEDITAR(nom, fec, hor, lug, NUM);
                                    NUM++;
                                    Console.Clear();
                                    break;

                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Cual evento desea editar? ");
                                    for (int i = 0; i < NUM; i++)
                                    {
                                        Console.WriteLine(i + " " + ArrayDB.Nombres[i]);
                                    }
                                    Console.Write("Ingrese el numero que esta al lado del evento para realizar la edicion:");
                                    int OPC = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("\t|Ingrese el nombre del evento: ");
                                    nom = Console.ReadLine()!;
                                    Console.WriteLine("\t|Ingrese la fecha del evento en este formato dia/mes/año: ");
                                    fec = Console.ReadLine()!;
                                    Console.WriteLine("\t|Ingrese la hora del evento en este formato hh:mm: ");
                                    hor = Console.ReadLine()!;
                                    Console.WriteLine("\t|Ingrese el lugar del evento: ");
                                    lug = Console.ReadLine()!;
                                    AGREGARYEDITAR(nom, fec, hor, lug, OPC);
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.Write("¿Cual evento desea eliminar? \n");
                                    for (int i = 0; i < NUM; i++)
                                    {
                                        Console.WriteLine(i + " " + ArrayDB.Nombres[i]);
                                    }
                                    OPC = Convert.ToInt32(Console.ReadLine());
                                    BorrarEvento(OPC);
                                    Console.Clear();
                                    break;
                                case 4:
                                    Console.Clear();
                                    Console.Write("Escriba la informacion del evento que sea buscar. Puede escribir: nombre del evento, fecha, hora o el lugar.");
                                    Console.WriteLine(":");
                                    string BUSCAR = Console.ReadLine()!;
                                    int BUSCARNUM = 0;
                                    if (ArrayDB.Nombres.Contains(BUSCAR) == true)
                                    {
                                        foreach (string a in ArrayDB.Nombres)
                                        {
                                            if (a == BUSCAR)
                                            {
                                                Console.WriteLine("\nNombre del evento: " + ArrayDB.Nombres[BUSCARNUM]);
                                                Console.WriteLine("Fecha del evento: " + ArrayDB.Fechas[BUSCARNUM]);
                                                Console.WriteLine("Hora del evento: " + ArrayDB.Horas[BUSCARNUM]);
                                                Console.WriteLine("Lugar del evento: " + ArrayDB.Lugares[BUSCARNUM] + "\n");
                                            }
                                            else
                                            {
                                                BUSCARNUM++;
                                            }
                                        }
                                    }
                                    else if (ArrayDB.Fechas.Contains(BUSCAR) == true)
                                    {
                                        foreach (string a in ArrayDB.Fechas)
                                        {
                                            if (a == BUSCAR)
                                            {
                                                Console.WriteLine("Nombre del evento: " + ArrayDB.Nombres[BUSCARNUM]);
                                                Console.WriteLine("Fecha del evento: " + ArrayDB.Fechas[BUSCARNUM]);
                                                Console.WriteLine("Hora del evento: " + ArrayDB.Horas[BUSCARNUM]);
                                                Console.WriteLine("Lugar del evento: " + ArrayDB.Lugares[BUSCARNUM] + "\n");
                                            }
                                            else
                                            {
                                                BUSCARNUM++;
                                            }
                                        }
                                    }
                                    else if (ArrayDB.Horas.Contains(BUSCAR) == true)
                                    {
                                        foreach (string a in ArrayDB.Horas)
                                        {
                                            if (a == BUSCAR)
                                            {
                                                Console.WriteLine("Nombre del evento: " + ArrayDB.Nombres[BUSCARNUM]);
                                                Console.WriteLine("Fecha del evento: " + ArrayDB.Fechas[BUSCARNUM]);
                                                Console.WriteLine("Hora del evento: " + ArrayDB.Horas[BUSCARNUM]);
                                                Console.WriteLine("Lugar del evento: " + ArrayDB.Lugares[BUSCARNUM] + "\n");
                                            }
                                            else
                                            {
                                                BUSCARNUM++;
                                            }
                                        }
                                    }
                                    else if (ArrayDB.Lugares.Contains(BUSCAR) == true)
                                    {
                                        foreach (string a in ArrayDB.Lugares)
                                        {
                                            if (a == BUSCAR)
                                            {
                                                Console.WriteLine("Nombre del evento: " + ArrayDB.Nombres[BUSCARNUM]);
                                                Console.WriteLine("Fecha del evento: " + ArrayDB.Fechas[BUSCARNUM]);
                                                Console.WriteLine("Hora del evento: " + ArrayDB.Horas[BUSCARNUM]);
                                                Console.WriteLine("Lugar del evento: " + ArrayDB.Lugares[BUSCARNUM] + "\n");
                                            }
                                            else
                                            {
                                                BUSCARNUM++;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hemos realizado la busqueda del evento y no se encuentra dicho evento");
                                    }

                                    break;

                                case 5:
                                    seguir = false;
                                    break;
                                default:
                                    Console.WriteLine("Ingrese una opción valida por favor.");
                                    break;

                            }

                        }

                        #endregion
                        //Utilizamos endregion para terminar 
                        Console.Clear();
                        break;

                    case 3:
                        #region Modulo Utilitario
                        
                        int MODOUTILI;

                        //----------------MENU DE UTILIDADES----------------
                        Console.Clear();
                        do //do para mantener el modo utilitario abierto
                        {
                            Console.WriteLine("\t[BIENVENIDO AL MODULO DE UTILIDADES]\n");
                            Console.WriteLine("--------- [MODULO UTILITARIO] ------------");
                            Console.WriteLine("|                                        |");
                            Console.WriteLine("|Presione [1] Convertidor De Temperaturas|");
                            Console.WriteLine("|Presione [2] Convertidor de Divisas     |");
                            Console.WriteLine("|Presione [3] Calculadoras               |");
                            Console.WriteLine("|Presione [4] Volver al menú principal   |");
                            Console.WriteLine("|                                        |");
                            Console.WriteLine("----------------------------------------\n");
                            Console.Write("Ingrese la opción deseada : ");
                            
                            MODOUTILI = int.Parse(Console.ReadLine()!);

                            switch (MODOUTILI)//switch para modulo utilitario
                            {
                                case 1:
                                    Console.Clear();              //SECCION DE CONVERSOR DE TEMPERATURAS
                                    int AUXGRADOS, AUXGRADOS2;
                                    
                                    do
                                    {
                                        Console.WriteLine("-------------[Convertidor de Temperaturas]--------------\n");
                                        Console.WriteLine("--------------- [Eliga las Temperaturas] ---------------");
                                        Console.WriteLine("|                                                      |");
                                        Console.WriteLine("| [1] Celsius                   | [1] Celsius          |");
                                        Console.WriteLine("| [2] Fahrenheit                | [2] Fahrenheit       |");
                                        Console.WriteLine("| [3] Kelvin                    | [3] Kelvin           |");
                                        Console.WriteLine("| [4] Volver al menú utilitario                        |");
                                        Console.WriteLine("|                                                      |");
                                        Console.WriteLine("--------------------------------------------------------");
                                        Console.Write("Seleccione la primera opción : ");
                                        
                                        AUXGRADOS = int.Parse(Console.ReadLine()!);

                                        if (AUXGRADOS == 4)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Para volver al menú de utilitario presione [ENTER]");
                                            Console.ReadKey();
                                            Console.Clear();
                                            AUXGRADOS = 4;
                                        }
                                        else
                                        {
                                            Console.Write("Seleccione la segunda opción : ");
                                            AUXGRADOS2 = int.Parse(Console.ReadLine()!);

                                            if (AUXGRADOS2 != AUXGRADOS)
                                            {
                                                switch (AUXGRADOS)
                                                {
                                                    case 1: //convetir celsius
                                                        Celsius(AUXGRADOS2);
                                                        Console.WriteLine("Para volver a seleccionar presione [ENTER]");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case 2:
                                                        Fahrenheit(AUXGRADOS2);
                                                        Console.WriteLine("Para volver a seleccionar presione [ENTER]");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case 3:
                                                        Kelvin(AUXGRADOS2);
                                                        Console.WriteLine("Para volver a seleccionar presione [ENTER]");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;

                                                    default:
                                                        Console.Clear();
                                                        int OPCAUX6;
                                                        Console.WriteLine("****************************************");
                                                        Console.WriteLine("| !Por favor, ingrese una de           |");
                                                        Console.WriteLine("| las opciones disponibles!            |");
                                                        Console.WriteLine("|                                      |");
                                                        Console.WriteLine("|Presione [1] Volver al menú principal |");
                                                        Console.WriteLine("|Presione [2] Volver al menú Utilitario|");
                                                        Console.WriteLine("****************************************");
                                                        OPCAUX6 = int.Parse(Console.ReadLine()!);

                                                        if (OPCAUX6 == 1) //aqui use un condicional para continuar temperaturas o volver al menú utilitario
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Para volver al menú de temperaturas presione [ENTER]");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        }
                                                        else
                                                        {
                                                            if (OPCAUX6 == 2)
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Para volver al menú Utiliario presione [ENTER]");
                                                                Console.ReadKey();
                                                                AUXGRADOS = 4;
                                                                Console.Clear();
                                                            };
                                                        }
                                                        break;
                                                };
                                            }
                                            else //else : No pueden ser iguales las opciones
                                            {
                                                Console.Clear();
                                                Console.WriteLine("!!Las temperaturas no pueden ser iguales!!");
                                                Console.WriteLine("Por favor ingrese una temperatura diferente a la seleccionada");
                                                Console.WriteLine("!!PRESIONE [ENTER] PARA VOLVER A SELECCIONAR LAS TEMPERATURAS!!");
                                                Console.ReadKey();
                                                Console.Clear();
                                            }
                                        }
                                    } while (AUXGRADOS != 4);

                                    break;

                                
                                case 2:
                                    Console.Clear();
                                    int OPCIONSELEC, OPCIONSELEC2;          //CONVERSOR DE DIVISAS

                                    do
                                    {
                                        Console.WriteLine("---------------[Convertidor de divisas]-----------------\n");
                                        Console.WriteLine("------------------ [Eliga las divisas] -----------------");
                                        Console.WriteLine("|                                                      |");
                                        Console.WriteLine("| [1] Dolar                 | [1] Dolar                |");
                                        Console.WriteLine("| [2] Euro                  | [2] Euro                 |");
                                        Console.WriteLine("| [3] Bitcoin               | [3] Bitcoin              |");
                                        Console.WriteLine("| [4] Peso Dominicano       | [4] Peso Dominicano      |");
                                        Console.WriteLine("|                                                      |");
                                        Console.WriteLine("| [5] Para volver al menú utilitario                   |");
                                        Console.WriteLine("|                                                      |");
                                        Console.WriteLine("--------------------------------------------------------");
                                        Console.Write("Seleccione la primera modenea: ");
                                        OPCIONSELEC = int.Parse(Console.ReadLine()!);

                                        if (OPCIONSELEC == 5)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Para volver al menú de utilitario presione [ENTER]");
                                            Console.ReadKey();
                                            Console.Clear();
                                            OPCIONSELEC = 5;
                                        }
                                        else
                                        {
                                            Console.Write("Seleccione la segunda divisa : ");
                                            OPCIONSELEC2 = int.Parse(Console.ReadLine()!);

                                            if (OPCIONSELEC2 != OPCIONSELEC)
                                            {
                                                switch (OPCIONSELEC)
                                                {
                                                    case 1: //convetir dolares
                                                        Fundolar(OPCIONSELEC2);
                                                        Console.WriteLine("Para volver a seleccionar presione [ENTER]");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case 2: //convetir euros
                                                        FunEuro(OPCIONSELEC2);
                                                        Console.WriteLine("Para volver a seleccionar presione [ENTER]!!");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case 3: //convetir francos
                                                        FunBitcoin(OPCIONSELEC2);
                                                        Console.WriteLine("Para volver a seleccionar presione [ENTER]");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;
                                                    case 4: //convetir pesos
                                                        FunPesos(OPCIONSELEC2);
                                                        Console.WriteLine("Para volver a seleccionar presione [ENTER]");
                                                        Console.ReadKey();
                                                        Console.Clear();
                                                        break;

                                                    default: //seleccion incorrecta de opciones divisas
                                                        Console.Clear();
                                                        int OPCAUX5; //Variable para seleccion incorrecta (Divisas)
                                                        Console.WriteLine("*************************************");
                                                        Console.WriteLine("| !Por favor, seleccione una de     |");
                                                        Console.WriteLine("| las opciones disponibles!         |");
                                                        Console.WriteLine("|                                   |");
                                                        Console.WriteLine("|[1] Volver al menú de atras        |");
                                                        Console.WriteLine("|[2] Volver al menú Utilitario      |");
                                                        Console.WriteLine("*************************************");
                                                        OPCAUX5 = int.Parse(Console.ReadLine()!);

                                                        if (OPCAUX5 == 1)
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Para volver al menú de divisas presione [ENTER]");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                        }
                                                        else
                                                        {
                                                            if (OPCAUX5 == 2)
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Para volver al menú Utiliario presione [ENTER]");
                                                                Console.ReadKey();
                                                                OPCIONSELEC = 5;
                                                                Console.Clear();
                                                            };
                                                        }
                                                        break;
                                                };
                                            }
                                            else //Las opciones iguales no pueden ser validas.
                                            {
                                                Console.Clear();
                                                Console.WriteLine("!!Las divisas no pueden ser iguales!!");
                                                Console.WriteLine("Por favor ingrese una divisa diferente a la seleccionada");
                                                Console.WriteLine("!!PRESIONE ENTER PARA VOLVER A SELECCIONAR LAS DIVISAS!!");
                                                Console.ReadKey();
                                                Console.Clear();
                                            };
                                        };

                                    } while (OPCIONSELEC != 5);
                                    break;

                                //CALCULADORAS  
                                case 3:
                                    Console.Clear();
                                    //Menú PARA calculadora
                                    int OPCCAL;
                                    do
                                    {
                                        Console.WriteLine("--------- [Calculadoras] -----------------");
                                        Console.WriteLine("|                                        |");
                                        Console.WriteLine("| [1] Calculadora                        |");
                                        Console.WriteLine("| [2] Cal. Interes simple y compuesto    |");
                                        Console.WriteLine("| [3] Volver al menú Utiliario           |");
                                        Console.WriteLine("|                                        |");
                                        Console.WriteLine("------------------------------------------\n");
                                        Console.Write("Ingrese la opción deseada : ");
                                        OPCCAL = int.Parse(Console.ReadLine()!);

                                        switch (OPCCAL)  //Switch seleccion de calculadora
                                        {
                                            //calculadora simple
                                            case 1:
                                                Console.Clear();
                                                int OPCCALSIM; //Variable para calculadora simple
                                                do //ciclo para mantener calculadora simple abierta
                                                {
                                                    Console.WriteLine("---------- [Calculadora] -------------");
                                                    Console.WriteLine("|                                    |");
                                                    Console.WriteLine("| [1] Para Sumar                     |");
                                                    Console.WriteLine("| [2] Para restar                    |");
                                                    Console.WriteLine("| [3] Para Multiplicar               |");
                                                    Console.WriteLine("| [4] Para Dividir                   |");
                                                    Console.WriteLine("| [5] Volver al menú de calculadoras |");
                                                    Console.WriteLine("|                                    |");
                                                    Console.WriteLine("--------------------------------------\n");
                                                    Console.Write("Ingrese la opción deseada : ");
                                                    OPCCALSIM = int.Parse(Console.ReadLine()!);

                                                    switch (OPCCALSIM) //Switch calculadora simple 
                                                    {
                                                        case 1: //suma
                                                            suma();
                                                            Console.WriteLine("Para volver a seleccionar presione [ENTER]");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            break;
                                                        case 2: //resta
                                                            resta();
                                                            Console.WriteLine("Para volver a seleccionar presione [ENTER]");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            break;
                                                        case 3: //multiplicacion
                                                            multiplicacion();
                                                            Console.WriteLine("Para volver a seleccionar presione [ENTER]");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            break;
                                                        case 4: //Division
                                                            division();
                                                            Console.WriteLine("Para volver a seleccionar presione [ENTER]");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            break;
                                                        case 5: //Case para volver al menú anterior (Calculadora simple)
                                                            Console.Clear();
                                                            Console.WriteLine("Para volver al menú de calculadoras presione [ENTER]");
                                                            Console.ReadKey();
                                                            OPCCALSIM = 5;
                                                            Console.Clear();
                                                            break;

                                                        default:
                                                            //seleccion incorrecta de opciones 
                                                            Console.Clear();
                                                            int OPCAUX1; //Variable para seleccion incorrecta (Cal simple)
                                                            Console.WriteLine("*************************************");
                                                            Console.WriteLine("| !Por favor, seleccione una de     |");
                                                            Console.WriteLine("| las opciones disponibles!         |");
                                                            Console.WriteLine("|                                   |");
                                                            Console.WriteLine("| [1] Volver al menú de atras       |");
                                                            Console.WriteLine("| [2] Volver al menú Utilitario     |");
                                                            Console.WriteLine("*************************************");
                                                            OPCAUX1 = int.Parse(Console.ReadLine()!);

                                                            if (OPCAUX1 == 1) //condicional para continuar calculadora simple o volver al menú utilitario
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Para volver al menú de calculadora presione [ENTER]");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                            }
                                                            else
                                                            {
                                                                if (OPCAUX1 == 2)
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Para volver al menú Utiliario presione [ENTER]");
                                                                    Console.ReadKey();
                                                                    OPCCALSIM = 5;
                                                                    OPCCAL = 3;
                                                                    Console.Clear();
                                                                };
                                                            }
                                                            break;
                                                    };
                                                }
                                                while (OPCCALSIM != 5); //ciclo que mantiene la calculadora simple abierta
                                                break;

                                            //calculadora de interes simple y compuesto 
                                            case 2:
                                                //Variable para menú de intereses
                                                Console.Clear();
                                                int CALINT;
                                                do
                                                {
                                                    Console.WriteLine("***********[Calculadora de intereses]*************");
                                                    Console.WriteLine("|                                                |");
                                                    Console.WriteLine("| [1] Interes simple                             |");
                                                    Console.WriteLine("| [2] Interes compuesto                          |");
                                                    Console.WriteLine("| [3] Volver atras                               |");
                                                    Console.WriteLine("**************************************************\n");
                                                    Console.Write("Ingrese la opción deseada : ");
                                                    CALINT = int.Parse(Console.ReadLine()!);
                                                    Console.Clear();

                                                    switch (CALINT)
                                                    {
                                                        case 1:
                                                            Interesimple();
                                                            Console.WriteLine("Para volver a seleccionar presione [ENTER]");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            break;
                                                        case 2:
                                                            Interescompuesto();
                                                            Console.WriteLine("Para volver a seleccionar presione [ENTER]");
                                                            Console.ReadKey();
                                                            Console.Clear();
                                                            break;
                                                        case 3:
                                                            Console.Clear();
                                                            int SUBMENU;
                                                            Console.WriteLine("*************************************");
                                                            Console.WriteLine("| Selecione una accion a tomar:     |");
                                                            Console.WriteLine("| [1] Menu de Calculadoras          |");
                                                            Console.WriteLine("| [2] Menú Utilitario               |");
                                                            Console.WriteLine("*************************************");
                                                            SUBMENU = int.Parse(Console.ReadLine()!);

                                                            if (SUBMENU == 1) //condicional para continuar calculadora intereses o volver al menú utilitario
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Para volver al menú de intereses presione [ENTER]");
                                                                Console.ReadKey();
                                                                Console.Clear();
                                                            }
                                                            else
                                                            {
                                                                if (SUBMENU == 2)
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Para volver al menú Utiliario presione [ENTER]");
                                                                    Console.ReadKey();
                                                                    OPCCAL = 3;
                                                                    Console.Clear();
                                                                };
                                                            }
                                                            break;
                                                    }

                                                } while (CALINT != 3); //ciclo que mantiene el menú de intereses abierto
                                                break;

                                            case 3:
                                                Console.Clear();
                                                Console.WriteLine("Para volver al menú Utiliario presione [ENTER]");
                                                Console.ReadKey();
                                                OPCCAL = 3;
                                                Console.Clear();
                                                break;

                                            default: //seleccion incorrecta en menú de calculadoras
                                                Console.Clear();
                                                int OPCAUX3; //Variable para seleccion incorrecta (Menu calculadoras)
                                                Console.WriteLine("*************************************");
                                                Console.WriteLine("| !Por favor, seleccione una de     |");
                                                Console.WriteLine("| las opciones disponibles!         |");
                                                Console.WriteLine("|                                   |");
                                                Console.WriteLine("| [1] Volver al menú de atras       |");
                                                Console.WriteLine("| [2] Volver al menú Utilitario     |");
                                                Console.WriteLine("*************************************");
                                                OPCAUX3 = int.Parse(Console.ReadLine()!);

                                                if (OPCAUX3 == 1) //condicion para volver al menú de calculadoras o al utilitario
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Para volver al menú de anterior presione [ENTER]");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    if (OPCAUX3 == 2)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("Para volver al menú Utiliario presione [ENTER]");
                                                        Console.ReadKey();
                                                        OPCCAL = 3;
                                                        Console.Clear();
                                                    };
                                                }
                                                break;
                                        }
                                    }
                                    while (OPCCAL != 3); //ciclo que mantiene el menú de calculadoras abierto
                                    break;

                                case 4: //Case para volver al menu principal (Modo utilitario)
                                    Console.Clear();
                                    Console.WriteLine("Para volver al menú principal presione [ENTER]");
                                    Console.ReadKey();
                                    Console.Clear();
                                    MODOUTILI = 4;
                                    break;

                                default://seleccion incorrecta en modo utilitario
                                    Console.Clear();
                                    int OPCAUX4; //Variable para seleccion incorrecta (Menu Utilitario)
                                    
                                    Console.WriteLine("*************************************");
                                    Console.WriteLine("| !Por favor, seleccione una de     |");
                                    Console.WriteLine("| las opciones disponibles!         |");
                                    Console.WriteLine("|                                   |");
                                    Console.WriteLine("| [1] Volver al menú Utilitario     |");
                                    Console.WriteLine("| [2] Volver al menú principal      |");
                                    Console.WriteLine("*************************************");
                                    
                                    OPCAUX4 = int.Parse(Console.ReadLine()!);

                                    if (OPCAUX4 == 1)//condicion para volver al menú principal o al utilitario
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Para volver al menú Utiliario presione [ENTER]");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        if (OPCAUX4 == 2)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Para volver al menú principal presione [ENTER]");
                                            Console.ReadKey();
                                            MODOUTILI = 4;
                                            Console.Clear();
                                        };
                                    }
                                    break;
                            };
                        } while (MODOUTILI != 4);//while para manterner el modo utilitario abierto 

                        #endregion
                        break;
                    case 4:
                        CONTINUAR = false;
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion que sea valida.");
                        break;
                }
            }
        }

        //Metodo para llenar y editar los eventos
        public static void AGREGARYEDITAR(string Nombre, string Fecha, string Hora, string Lugar, int NUM)
        {

            ArrayDB.Nombres[NUM] = Nombre;
            ArrayDB.Fechas[NUM] = Fecha;
            ArrayDB.Horas[NUM] = Hora;
            ArrayDB.Lugares[NUM] = Lugar;


        }

        //Metodo para borrar el contenido de un evento
        public static void BorrarEvento(int NUM)
        {
            ArrayDB.Nombres[NUM] = "";
            ArrayDB.Fechas[NUM] = "";
            ArrayDB.Horas[NUM] = "";
            ArrayDB.Lugares[NUM] = "";


        }
        //Metodo para borrar un contacto
        public static void BorrarContacto(int NUM)
        {
            ArrayDB.NombresContactos[NUM] = " ";
            ArrayDB.ApellidoContactos[NUM] = " ";
            ArrayDB.TelefonoContactos[NUM] = " ";
            ArrayDB.GmailContactos[NUM] = " ";
        }
        public static void LlenarYEditarContacto(string Nombre, string Apellido, string Telefono, string Direccion, string Gmail, int NUM)
        {
            ArrayDB.NombresContactos[NUM] = Nombre;
            ArrayDB.ApellidoContactos[NUM] = Apellido;
            ArrayDB.DireccionContactos[NUM] = Direccion;
            ArrayDB.TelefonoContactos[NUM] = Telefono;
            ArrayDB.GmailContactos[NUM] = Gmail;
        }

        public static class ArrayDB
        {
            //Arrays para los contactos
            public static string[] NombresContactos = new string[25];
            public static string[] ApellidoContactos = new string[25];
            public static string[] DireccionContactos = new string[25];
            public static string[] TelefonoContactos = new string[25];
            public static string[] GmailContactos = new string[25];

            //Arrays para los eventos
            public static string[] Nombres = new string[25];
            public static string[] Fechas = new string[25];
            public static string[] Horas = new string[25];
            public static string[] Lugares = new string[25];



        }


        //----------------FUNCIONES PARA EL  COVERSOR DE TEMPERATURAS-----------

        static void Celsius(int AUXGRADOS2)//Funcion para convertir de celcius a otra 
        {
            double CELSIUS1;

            if (AUXGRADOS2 == 2) //Condicional para convetir de una temp a otra (Celsius)
            {
                double RCELSIUS;
                Console.Clear();
                Console.WriteLine("***********°C | °F*************");
                Console.Write("Ingrese los grados °C: ");
                CELSIUS1 = double.Parse(Console.ReadLine()!);
                double CelFar = (CELSIUS1 * 9 / 5) + 32; 
                RCELSIUS = Math.Round(CelFar, 2); 
                Console.Clear();
                Console.WriteLine("Celsius a Fahrenheit");
                Console.WriteLine(CELSIUS1 + " °C = " + RCELSIUS + " °F\n");
            }
            else
            {
                if (AUXGRADOS2 == 3)//Condicional para convetir de una temp a otra (Celsius)
                {
                    double RCELSIUS;
                    Console.Clear();
                    Console.WriteLine("************°C | K**************");
                    Console.Write("Ingrese los grados °C: ");
                    CELSIUS1 = double.Parse(Console.ReadLine()!);
                    double CELKEL = CELSIUS1 + 273.15;
                    RCELSIUS = Math.Round(CELKEL, 2); //redondeado decimal
                    Console.Clear();
                    Console.WriteLine("Celsius a Kelvin");
                    Console.WriteLine(CELSIUS1 + " °C = " + RCELSIUS + " K\n");
                }
            };
        }

        static void Fahrenheit(int AUXGRADOS2)
        {
            double FARENHEIT1;

            if (AUXGRADOS2 == 1)//Condicional para convetir de una temp a otra (Fah)
            {
                double RFARENHEIT;
                Console.Clear();
                Console.WriteLine("************°F | °C*************");
                Console.Write("Ingrese los grados °F: ");
                FARENHEIT1 = double.Parse(Console.ReadLine()!);
                double FahCel = (FARENHEIT1 - 32) * 5 / 9; 
                RFARENHEIT = Math.Round(FahCel, 2); 
                Console.Clear();
                Console.WriteLine("Fahrenheit a Celsius");
                Console.WriteLine(FARENHEIT1 + " °F = " + RFARENHEIT + " °C\n");
            }
            else
            {
                if (AUXGRADOS2 == 3)
                {
                    double RFARENHEIT;
                    Console.Clear();
                    Console.WriteLine("*************°F | K************");
                    Console.Write("Ingrese los grados °F: ");
                    FARENHEIT1 = double.Parse(Console.ReadLine()!);
                    double FAHKEL = (FARENHEIT1 - 32) * 5 / 9 + 273.15;
                    RFARENHEIT = Math.Round(FAHKEL, 2);
                    Console.Clear();
                    Console.WriteLine("Fahrenheit a Kelvin");
                    Console.WriteLine(FARENHEIT1 + " °F = " + RFARENHEIT + " K\n");
                }
            };
        }

        static void Kelvin(int AUXGRADOS2)
        {
            double KELVINGRA;//grados que va a introducir el usuario

            if (AUXGRADOS2 == 1)//Condicional para convetir de una temp a otra (Celsius)
            {
                double RKELVIN;
                Console.Clear();
                Console.WriteLine("***********K | °C***********");
                Console.Write("Ingrese los grados K: ");
                KELVINGRA = double.Parse(Console.ReadLine()!);
                double KELCEL = KELVINGRA - 273.15;
                RKELVIN = Math.Round(KELCEL, 2);
                Console.Clear();
                Console.WriteLine("Kelvin a Celsius");
                Console.WriteLine(KELVINGRA + " K = " + RKELVIN + " °C\n");
            }
            else
            {
                if (AUXGRADOS2 == 2)
                {
                    double RKELVIN;
                    Console.Clear();
                    Console.WriteLine("***********K | °F***********");
                    Console.Write("Ingrese los grados K: ");
                    KELVINGRA = double.Parse(Console.ReadLine()!);
                    double KELFAH = (KELVINGRA - 273.15) * 9 / 5 + 32;
                    RKELVIN = Math.Round(KELFAH, 2);
                    Console.Clear();
                    Console.WriteLine("Kelvin a Fahrenheit");
                    Console.WriteLine(KELVINGRA + " K = " + RKELVIN + " °F\n");
                }
            };

        }

        //----------------FUNCIONES CONVERSOR DE MONEDAS----------------

        static void Fundolar(int OPCIONSELEC2)//funcion dolar
        {
            double Dolars;//Dolares que va a introducir el usuario

            if (OPCIONSELEC2 == 2) //condicionales para convertir con seleccion de segunda divisa
            {
                Console.Clear();
                Console.WriteLine("************USD | EUR************");
                Console.Write("Ingrese la cantidad de dolares $ : ");
                Dolars = double.Parse(Console.ReadLine()!);
                double DolarEuro = Dolars * 0.91; //dolar a euro: 0.91 euro 
                if (Dolars > 1 || Dolars < 1)
                {
                    Console.WriteLine(Dolars + " Dólares estadounidenses = \n" + DolarEuro + " Euros");
                }
                else
                {
                    Console.WriteLine(Dolars + " Dólar estadounidense = \n" + DolarEuro + " Euros");
                };
                Console.WriteLine("\n1 USD = 0.91 EUR");
                Console.WriteLine("1 EUR = 1.10 USD\n");
            }
            else
            {
                if (OPCIONSELEC2 == 3)
                {
                    Console.Clear();
                    Console.WriteLine("************USD | BTC************");
                    Console.Write("Ingrese la cantidad de dolares $ : ");
                    Dolars = double.Parse(Console.ReadLine()!);
                    double DolarBitcoin = Dolars * 28231.16;///Dolar a Bitcoin: 28,231.16 Bitcoin 
                    if (Dolars > 1 || Dolars < 1)
                    {
                        Console.WriteLine(Dolars + " Dólares estadounidenses = \n" + DolarBitcoin + " Bitcoin");
                    }
                    else
                    {
                        Console.WriteLine(Dolars + " Dólares estadounidenses = \n" + DolarBitcoin + " Bitcoin");
                    };
                    Console.WriteLine("\n1 USD = 0.000035 BTC");
                    Console.WriteLine("1 Bitcoin = 28231.16 USD\n");
                }
                else
                {
                    if (OPCIONSELEC2 == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("************USD | DOP************");
                        Console.Write("Ingrese la cantidad de dolares $ : ");
                        Dolars = double.Parse(Console.ReadLine()!);
                        double DolarPeso = Dolars * 54.60; //dolar a peso: 54.60 peso
                        if (Dolars > 1 || Dolars < 1)
                        {
                            Console.WriteLine(Dolars + " Dólares estadounidenses = \n" + DolarPeso + " Pesos Dominicanos");
                        }
                        else
                        {
                            Console.WriteLine(Dolars + " Dólar estadounidense = \n" + DolarPeso + " Pesos Dominicanos");
                        };
                        Console.WriteLine("\n1 USD = 54.60 DOP");
                        Console.WriteLine("1 DOP = 0.018 USD\n");
                    }
                }

            }
        }

        static void FunEuro(int OPCIONSELEC2)
        {
            double Euros;
            if (OPCIONSELEC2 == 1)//condicionales para convertir con seleccion de segunda divisa
            {
                Console.Clear();
                Console.WriteLine("***********EUR | USD************");
                Console.Write("Ingrese la cantidad de Euros € : ");
                Euros = double.Parse(Console.ReadLine()!);
                double EuroDolar = Euros * 1.10; //Euro a dolar: 1.10 dolares 
                if (Euros > 1 || Euros < 1)
                {
                    Console.WriteLine(Euros + " Euros = \n" + EuroDolar + " Dólares estadounidenses");
                }
                else
                {
                    Console.WriteLine(Euros + " Euro = \n" + EuroDolar + " Dólares estadounidenses");
                };
                Console.WriteLine("\n1 EUR = 1.10 USD");
                Console.WriteLine("1 USD = 0.91 EUR\n");
            }
            else
            {
                if (OPCIONSELEC2 == 3)
                {
                    Console.Clear();
                    Console.WriteLine("************EUR | BTC************");
                    Console.Write("Ingrese la cantidad de Euros € : ");
                    Euros = double.Parse(Console.ReadLine()!);
                    double EuroBitcoin = Euros * 0.000039; //Euro a Bitcoin: 0.000039 bitcoin
                    if (Euros > 1 || Euros < 1)
                    {
                        Console.WriteLine(Euros + " Euros = \n" + EuroBitcoin + " Bitcoins");
                    }
                    else
                    {
                        Console.WriteLine(Euros + " Euro = \n" + EuroBitcoin + " Bitcoins");
                    };
                    Console.WriteLine("\n1 EUR = 0.000039 BTC");
                    Console.WriteLine("1 Bitcoin = 25,739.78 EUR\n");

                }
                else
                {
                    if (OPCIONSELEC2 == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("************EUR | DOP************");
                        Console.Write("Ingrese la cantidad de Euros € : ");
                        Euros = double.Parse(Console.ReadLine()!);
                        double EuroPeso = Euros * 59.89; //Euro a pesos :59.89 pesos
                        if (Euros > 1 || Euros < 1)
                        {
                            Console.WriteLine(Euros + " Euros = \n" + EuroPeso + " Pesos dominicanos");
                        }
                        else
                        {
                            Console.WriteLine(Euros + " Euro = \n" + EuroPeso + " Pesos dominicanos");
                        };
                        Console.WriteLine("\n1 EUR = 59.89 DOP");
                        Console.WriteLine("1 DOP = 0.017 EUR\n");
                    }
                };

            }
        }

        static void FunBitcoin(int OPCIONSELEC2)//funcion BITCOIN
        {
            double Bitcoin;
            if (OPCIONSELEC2 == 1)//condicionales para convertir con seleccion de segunda divisa
            {
                {
                    Console.Clear();
                    Console.WriteLine("************BTC | USD************");
                    Console.Write("Ingrese la cantidad de BITCOIN que desea convertir a dolar: ");
                    Bitcoin = double.Parse(Console.ReadLine()!);
                    double BitcoinDolar = Bitcoin * 28299.00; //BITCOIN a dolar : 28,299.00 USD
                    if (Bitcoin > 1 || Bitcoin < 1)
                    {
                        Console.WriteLine(Bitcoin + " Bitcoin  = \n" + BitcoinDolar + " Dólares estadounidenses");
                    }
                    else
                    {
                        Console.WriteLine(Bitcoin + " Bitcoin  = \n" + BitcoinDolar + " Dólares estadounidenses");
                    };
                    Console.WriteLine("\n1 Bitcoin = 28,299.00 USD");
                    Console.WriteLine("1 USD = 0.000035 Bitcoin\n");
                }
            }
            else
            {
                if (OPCIONSELEC2 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("************BTC | EUR************");
                    Console.Write("Ingrese la cantidad de Bitcoin que desea convertir a Euro: ");
                    Bitcoin = double.Parse(Console.ReadLine()!);
                    double BitcoinEuro = Bitcoin * 25751.52; // Bitcoin a Euro :25,751.52 EUR
                    if (Bitcoin > 1 || Bitcoin < 1)
                    {
                        Console.WriteLine(Bitcoin + " Bitcoin = \n" + BitcoinEuro + " Euros");
                    }
                    else
                    {
                        Console.WriteLine(Bitcoin + " Bitcoin = \n" + BitcoinEuro + "  Euros");
                    };
                    Console.WriteLine("\n1 BTC = 25,751.52 EUR");
                    Console.WriteLine("1 EUR = 0.000039 BTC\n");
                }
                else
                {
                    if (OPCIONSELEC2 == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("************BTC | DOP************");
                        Console.Write("Ingrese la cantidad de Bitcoin que desea convertir a peso Dominicano: ");
                        Bitcoin = double.Parse(Console.ReadLine()!);
                        double BitcoinPeso = Bitcoin * 1542024.12; //Bitcoin a pesos = 1,542,024.12 pesos
                        if (Bitcoin > 1 || Bitcoin < 1)
                        {
                            Console.WriteLine(Bitcoin + " Bitcoin = \n" + BitcoinPeso + " Pesos dominicanos");
                        }
                        else
                        {
                            Console.WriteLine(Bitcoin + " Bitcoin = \n" + BitcoinPeso + " Pesos dominicanos");
                        };
                        Console.WriteLine("\n1 BTC = 1,542,024.12 DOP");
                        Console.WriteLine("1 DOP = 0.00 BTC\n");
                    }
                }
            }
        }

        static void FunPesos(int OPCIONSELEC2) //funcion de convetrir peso
        {
            double Pesos;
            if (OPCIONSELEC2 == 1)
            {
                Console.Clear();
                Console.WriteLine("************DOP | USD************");
                Console.Write("Ingrese la cantidad de Pesos a convertir RD$ : ");
                Pesos = double.Parse(Console.ReadLine()!);
                double PesoDolar = Pesos * 0.018; //peso a dolar : 0.018 USD
                if (Pesos > 1 || Pesos < 1)
                {
                    Console.WriteLine(Pesos + " Pesos dominicanos = \n" + PesoDolar + " Dólares estadounidenses");
                }
                else
                {
                    Console.WriteLine(Pesos + " Peso dominicano = \n" + PesoDolar + " Dólares estadounidenses");
                };
                Console.WriteLine("\n1 DOP = 0.018 USD");
                Console.WriteLine("1 USD = 54.60 DOP\n");
            }
            else
            {
                if (OPCIONSELEC2 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("************DOP | EUR************");
                    Console.Write("Ingrese la cantidad de Pesos RD$ : ");
                    Pesos = double.Parse(Console.ReadLine()!);
                    double PesoEuro = Pesos * 0.017; //peso a euro : 0.017 EUR
                    if (Pesos > 1 || Pesos < 1)
                    {
                        Console.WriteLine(Pesos + " Pesos dominicanos = \n" + PesoEuro + " Euros");
                    }
                    else
                    {
                        Console.WriteLine(Pesos + " Peso dominicano = \n" + PesoEuro + " Euros");
                    };
                    Console.WriteLine("\n1 DOP = 0.017 EUR");
                    Console.WriteLine("1 EUR = 59.89 DOP\n");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("************DOP | BTC************");
                    Console.Write("Ingrese la cantidad de Pesos que desea convertir a Bitcoin RD$ : ");
                    Pesos = double.Parse(Console.ReadLine()!);
                    double MonedaBitocin = Pesos * 2.01; //Bitcoin a pesos = 1,542,919.47 Bitcoin
                    if (Pesos > 1 || Pesos < 1)
                    {
                        Console.WriteLine(Pesos + " Peso dominicano = \n" + MonedaBitocin + " Bitcoin");
                    }
                    else
                    {
                        Console.WriteLine(Pesos + " Peso dominicano = \n" + MonedaBitocin + " Bitcoin");
                    };
                    Console.WriteLine("\n1 DOP = 0.00 BTC");
                    Console.WriteLine("1 BTC = 1,542,919.47 DOP\n");
                }
            }
        }

        //----------------FUNCIONES CAULCULADORA NORMAL----------------

        static void suma() //funcion suma 
        {
            Console.Clear();
            
            double numero1, numero2;
            Console.WriteLine("----- [Ha elegido la opcion sumar] ----\n");
            Console.Write("Ingrese el primer numero: ");
            numero1 = double.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el segundo numero: ");
            numero2 = double.Parse(Console.ReadLine()!);
            double SUMA = numero1 + numero2;  
            Console.WriteLine("\nEl resultado es : " + numero1 + " + " + numero2 + " = " + SUMA + "\n");  
        }

        static void resta() //funcion resta
        {
            Console.Clear();
            double numero1, numero2;
            Console.WriteLine("----- [Ha elegido la opcion restar] ----\n");
            Console.Write("Ingrese el primer numero : ");
            numero1 = double.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el segundo numero : ");
            numero2 = double.Parse(Console.ReadLine()!);
            double RESTA = numero1 - numero2;
            Console.WriteLine("\nEl resultado es : " + numero1+ " - " + numero2 + " = " + RESTA + "\n");
        }

        static void multiplicacion() //funcion multiplicacion
        {
            Console.Clear();
            double numero1, numero2;
            Console.WriteLine("----- [Ha elegido la opcion multiplicar] ----\n");
            Console.Write("Ingrese el primer numero : ");
            numero1 = double.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el segundo numero : ");
            numero2 = double.Parse(Console.ReadLine()!);
            double MULT = numero1 * numero2;
            Console.WriteLine("\nEl resultado es : " + numero1 + " * " + numero2 + " = " + MULT + "\n");
        }

        static void division() //funcion division
        {
            Console.Clear();
            double numero1, numero2;
            Console.WriteLine("----- [Ha elegido la opcion dividir] ----\n");
            Console.Write("Ingrese el primer numero : ");
            numero1 = double.Parse(Console.ReadLine()!);
            Console.Write("Ingrese el segundo numero : ");
            numero2 = double.Parse(Console.ReadLine()!);
            double DIV = numero1 / numero2;
            Console.WriteLine("\nEl resultado es : " + numero1 + " / " + numero2 + " = " + DIV + "\n");
        }
        //''''''''''''''''FUNCIONES CAULCULADORA DE INTERESES'''''''''''''''

        static void Interesimple() //interes simple
        {
            Console.WriteLine("----- [Interes simple] -----\n");
            Console.WriteLine("*************************************");
            Console.WriteLine("|   Formula para el interes simple  |");
            Console.WriteLine("|        Isimple = C * i * T        |");
            Console.WriteLine("|   [El tiempo se calcula en años]  |");
            Console.WriteLine("|                                   |");
            Console.WriteLine("*************************************");
           
            double Capital = 0;
            double Interes = 0;
            double Tiempo = 0;
            double Isimple = 0;
            
            Console.WriteLine("Digite el capital: ");
            Capital = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite el interes: ");
            Interes = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite el tiempo: ");
            Tiempo = double.Parse(Console.ReadLine()!);
            Console.WriteLine("----- [Interes simple] ----\n");
            Isimple = Capital * Interes * Tiempo;
            
            Console.WriteLine("Interes simple: {0}", Isimple);
        }

        static void Interescompuesto() //interes compuesto
        {
            Console.WriteLine("----- [Interes compuesto] -----\n");
            Console.WriteLine("*************************************");
            Console.WriteLine("|  Formula interes compuesto        |");
            Console.WriteLine("|     Icompuesto = C (1 + i)^T      |");
            Console.WriteLine("|  [El tiempo se calcula en años]   |");
            Console.WriteLine("|                                   |");
            Console.WriteLine("*************************************");
            
            double Capital = 0;
            double Interes = 0;
            double Tiempo = 0;
            double Icompuesto = 0;
            
            Console.WriteLine("Digite el capital: ");
            Capital = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite el interes: ");
            Interes = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite el tiempo: ");
            Tiempo = double.Parse(Console.ReadLine()!);
            Console.WriteLine("----- [Interes compuesto] ----\n");
            Icompuesto = Capital * Math.Pow((1 + Interes), Tiempo);
            Console.WriteLine("Interes compuesto: {0}", Icompuesto);
        }
    }
}



