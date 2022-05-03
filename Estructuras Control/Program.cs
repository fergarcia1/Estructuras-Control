using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_Control
{
    class Program
    {
        static void Main()
        {
            int aux = 0, i = 0, num , option = 0,horas = 0;
            double valorHora = 0,descuento = 0,salario = 0,aumento = 0; ;
            Console.WriteLine("(1) Ejercicio 1");
            Console.WriteLine("(2) Ejercicio 2");
            Console.WriteLine("(3) Ejercicio 3");
            Console.WriteLine("(4) Ejercicio 4");
            Console.WriteLine("(5) Ejercicio 5");
            Console.WriteLine("(6) Ejercicio 6");
            Console.WriteLine("(7) Ejercicio 7");
            Console.WriteLine("(8) Ejercicio 8");
            Console.WriteLine("(9) Ejercicio 9");
            Console.WriteLine("(10) Ejercicio 10");
            Console.WriteLine("(11) Ejercicio 11");
            Console.WriteLine("(12) Ejercicio 12");
            option = Int32.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    //1.- Realiza un programa que sume los 100 números siguientes a un número entero y
                    //positivo introducido por teclado. Se debe comprobar que el dato introducido es correcto
                    Console.Write("Numero: ");
                    num = int.Parse(Console.ReadLine());
                    aux = num;
                    while (i < 100)
                    {
                        num = num + aux;
                        aux++;
                        i++;
                    }
                    Console.Write(num);
                    Console.ReadKey();
                    break;
                case 2:
                    //2.- Escribe un programa que obtenga los números enteros comprendidos entre dos números introducidos por
                    //teclado y validados como distintos, el programa debe empezar por el menor de los enteros introducidos e ir incrementando de 7
                    aux = 0;
                    i = 0;
                    Console.Write("Numero 1: ");
                    int num1 = int.Parse(Console.ReadLine());

                    Console.Write("Numero 2: ");
                    int num2 = int.Parse(Console.ReadLine());
                    if (num1 != num2)
                    {
                        if (num2 < num1)
                        {
                            aux = num2;
                            num2 = num1;
                            num1 = aux;
                        }
                        i = num1 + 1;
                        while (i < num2)
                        {
                            Console.Write(i + ", ");
                            i++;
                        }
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Los numeros no deben ser iguales!");
                        Main();
                    }
                    break;
                case 3:
                    //3.- Escribe un programa que permita ir introduciendo una serie indeterminada de números mientras
                    //su suma no supere el valor de 150 Cuando esto último ocurra, se debe mostrar el total acumulado,
                    //el contador de los números introducidos y la media.
                    int suma = 0;
                    i = 1;
                    Console.WriteLine("Sume valores hasta 150");

                    while (suma < 150)
                    {
                        Console.Write("Numero i: ");
                        num = int.Parse(Console.ReadLine());
                        suma = suma + num;
                        i++;
                    }
                    i = i - 1;
                    Console.WriteLine("Valor final: " + suma);
                    Console.WriteLine("Cantidad de numeros: " + i);
                    Console.WriteLine("La media es: " + suma / i);
                    Console.ReadKey();
                    break;
                case 4:
                    //4.- Calcular el salario de un trabajador, ingresando las horas trabajadas y el valor por hora,
                    //se debe mostrar el nombre del trabajador.
                    valorHora = 850.20;
                    Console.Write("Nombre del trabajador: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Horas trabajadas en el ultimo mes: ");
                    horas = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("El trabajador " + nombre + " trabajo un total de " + horas + " por lo tanto gano: " + horas * valorHora);
                    Console.ReadKey();

                    break;
                case 5:
                    //5.- En una carretera se ha colocado un radar que detecta la velocidad del vehículo que pasa y el tipo de vehículo: 0 Bicicleta,
                    //1 Moto, 2 Coche, 3 Camión, 4 Error. El proceso se interrumpe si se generan 1000 señales o si se producen 2 errores consecutivos.
                    //Al final se debe mostrar una estadística que indique el número total de vehículos que han pasado, el número de errores y los porcentajes de cada caso.
                    //También se debe indicar el máximo intervalo (medido en número de vehículos) entre dos coches.
                    int bici = 0, moto = 0, coche = 0, camion = 0, error = 0, anterior = 0, total = 0;
                    Random rnd = new Random();
                    i = 0;
                    while (i < 1000 && error < 2)
                    {
                        int radar = rnd.Next(0, 5);
                        switch (radar)
                        {
                            case 0:
                                bici++;
                                total++;
                                if (error == 1)
                                {
                                    error--;
                                }
                                break;
                            case 1:
                                moto++;
                                total++;
                                if (error == 1)
                                {
                                    error--;
                                }
                                break;
                            case 2:
                                coche++;
                                total++;
                                if (error == 1)
                                {
                                    error--;
                                }
                                break;
                            case 3:
                                camion++;
                                total++;
                                if (error == 1)
                                {
                                    error--;
                                }
                                break;
                            case 4:
                                error++;
                                break;
                        }
                    }
                    Console.ReadKey();
                    break;
                case 6:
                    //6.-Calcular el monto a pagar en una cabina de Internet si el costo por hora es de $1,5 y por cada 5 horas te dan una hora de promoción gratis,
                    //sabiendo que la permanencia en la cabina  fue  de 12 horas.
                    i = 0;
                    horas = 12;
                    valorHora = 1.5;
                    int horasDescuento = 5;
                    double totalPagar;
                    if (horas > 5)
                    {
                        while (horas > 0)
                        {
                            horas = horas - horasDescuento;
                            i++;
                        }
                        if (horas < 0)
                        {
                            i--;
                        }
                        descuento = i * valorHora;
                        totalPagar = (horas * valorHora) - descuento;
                    }
                    Console.ReadKey();
                    break;
                case 7:
                    //7.- Ingresar un tiempo en segundos y separarlos en horas, minutos y segundos
                    int minutos = 0, segundos = 0;
                    horas = 0;
                    Console.WriteLine("Tiempo en segundos: ");
                    segundos = Int32.Parse(Console.ReadLine());
                    while (segundos > 60)
                    {
                        minutos++;
                        segundos = segundos - 60;
                        if (minutos > 60)
                        {
                            horas++;
                            minutos = minutos - 60;
                        }
                    }
                    Console.WriteLine("Segundos: " + segundos);
                    Console.WriteLine("Minutos: " + minutos);
                    Console.WriteLine("Horas: " + horas);
                    Console.ReadKey();
                    break;
                case 8:
                    //8.-Calcular el nuevo salario de un empleado si obtuvo un incremento del 8% sobre su salario actual y un descuento de 2,5% por servicios.
                    salario = 100000;
                    aumento = 8;
                    descuento = 2.5;
                    aumento = (aumento * salario) / 100 ;
                    salario = salario + aumento;
                    descuento = (descuento * salario) / 100;
                    salario = salario - descuento;
                    Console.WriteLine("Aumento: " + aumento);
                    Console.WriteLine("Descuento: " + descuento);
                    Console.WriteLine("Salario final: " + salario);
                    Console.ReadKey();
                    break;
                case 9:
                    //9.- Calcular el área de un trapecio
                    double altura = 0, baseA = 0, baseB = 0, area = 0;
                    Console.WriteLine("Altura en CM: ");
                    altura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Base mayor CM: ");
                    baseA = double.Parse(Console.ReadLine());
                    Console.WriteLine("Base menor CM: ");
                    baseB = double.Parse(Console.ReadLine());

                    area = (baseA + baseB) / 2;
                    area = area * altura;
                    Console.WriteLine("Area en cm: " + area);

                    Console.ReadKey();
                    break;
                case 10:
                    //10.- Un empresario decide heredar su terreno a sus 3 hijos, tomando como referencia la cantidad de hijos,
                    //al mayor que tiene 6 hijos le otorga el doble del menor,
                    //al que tiene 2 hijos le corresponde 125.2 mt2, al menor le otorga el 27% del total del terreno.
                    //Calcular el total del terreno y la cantidad que le corresponde a cada hijo.

                    //mayor 54%, menor 27%, mediano 19%, 19% == 125.2mt2

                    double terrenoMayor =0 , terrenoMenor = 0, terrenoMediano=125.2, terrenoTotal;

                    terrenoMayor = (54 * terrenoMediano) / 19;
                    terrenoMenor = (27 * terrenoMediano) / 19;
                    terrenoTotal = terrenoMenor + terrenoMediano + terrenoMayor;
                    Console.WriteLine("El hermano mayor tendria: " + terrenoMayor + " mts2");
                    Console.WriteLine("El hermano menor tendria: " + terrenoMenor + " mts2");
                    Console.WriteLine("El tamaño del terreno es: " + terrenoTotal + " mts2");

                    Console.ReadKey();
                    break;
                case 11:
                    //11.- Escribe un programa que lea un número N e imprima una pirámide de números con N filas como en la siguiente figura:

                    int alturaIntroducida;

                    Console.WriteLine("Introduzca la altura de la piramide");

                    alturaIntroducida = Int32.Parse(Console.ReadLine());
                    //tuve que pedir ayuda ya que no pude hacerlo, pero aun asi sigue sin funcionar
                    altura = 1;
                    double j = 0;
                    int espacios = alturaIntroducida - 1;
                    while (altura <= alturaIntroducida)
                    {
                        for (j = 1; j <= espacios; j++)
                        {
                            Console.Write(" ");
                        }
                        for (j = 1; j < altura; j++)
                        {
                            Console.Write(i);
                        }
                        for (j = altura; j > 0; j--)
                        {
                            Console.Write(j);
                        }
                        Console.WriteLine("");
                        altura++;
                        espacios--;
                    }
                    Console.ReadKey();
                    break;
                case 12:
                    break;
                case 13:
                    //13.- Calcular el nuevo salario de un obrero, si obtuvo un incremento semestral del 25% sobre su salario anterior,
                    //y mostrar el total cobrado de los meses con el nuevo salario, si solo trabajó 10 meses
                    double aumentoMensual = (1 * 25) / 6, salarioMensual = 100000;
                    salarioMensual = salarioMensual + aumentoMensual;
                    Console.WriteLine("En 10 meses cobro: " + salarioMensual * 10);
                    break;
                case 14:

                    //14 - Queremos conocer los datos estadísticos de una materia, por lo tanto, necesitamos un algoritmo que lea el número de reprobados,
                    //aprobados, notables y sobresalientes, y nos devuelva: El tanto por ciento de alumnos que han superado la asignatura.
                    //El tanto por ciento de reprobados, aprobados, notables y sobresalientes de la asignatura

                    int numeroDeAprobados, numeroDeDesaprobados, numeroDeNotables, numeroDeSobresalientes;
                    double porcentajeSuperados, porcentajeDesaprobados, porcentajeAprobados, porcentajeNotables, porcentajeSobresalientes;

                    total = 0;

                    Console.WriteLine("Ingresa el valor de numero de aprobados:");
                    numeroDeAprobados = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresa el valor de numero de desaprobados:");
                    numeroDeDesaprobados = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresa el valor de numero de notables:");
                    numeroDeNotables = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Ingresa el valor de numero de sobresalientes:");
                    numeroDeSobresalientes = Int32.Parse(Console.ReadLine());

                    total = numeroDeDesaprobados + numeroDeAprobados + numeroDeNotables + numeroDeSobresalientes;

                    porcentajeSuperados = 100 * (numeroDeAprobados + numeroDeNotables + numeroDeSobresalientes) / total;
                    porcentajeDesaprobados = 100 * numeroDeDesaprobados / total;
                    porcentajeAprobados = 100 * numeroDeAprobados / total;
                    porcentajeNotables = 100 * numeroDeNotables / total;
                    porcentajeSobresalientes = 100 * numeroDeSobresalientes / total;

                    Console.WriteLine("Valor de porcentaje aprobados: " + porcentajeAprobados);
                    Console.WriteLine("Valor de porcentaje desaprobados: " + porcentajeDesaprobados);
                    Console.WriteLine("Valor de porcentaje notables: " + porcentajeNotables);
                    Console.WriteLine("Valor de porcentaje sobresalientes: " + porcentajeSobresalientes);
                    Console.WriteLine("Valor de total: " + total);
                    Console.ReadKey();

                    break;

                        

            }
        }
        }
}

