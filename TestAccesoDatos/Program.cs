using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAccesoDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int opc = 0;

                do
                {
                    Console.Clear();
                    string menu = "Menu Principal\n";
                    menu += "1. Verificar conexion  \n";
                    menu += "2. Agregar  \n";
                    menu += "3. Salir\n";

                    Console.WriteLine(menu);
                    opc = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    switch (opc)
                    {
                        case 1:
                            {
                                Console.Clear();
                                Console.WriteLine("Realizando validacion");
                                Console.ReadLine();
                                AccesoSQL objacceso = new AccesoSQL();
                                Console.WriteLine("Conexion satisfactoria");
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            {
                                Funcionario objfuncionario = new Funcionario();

                                Console.Clear();

                                Console.WriteLine("Digite nombre");
                                objfuncionario.Nombre = Console.ReadLine();
                                Console.WriteLine("Digite Contraseña");
                                objfuncionario.Contraseña = Console.ReadLine();
                                Console.WriteLine("Digite Puesto");    
                                objfuncionario.Puesto = Console.ReadLine();

                                objfuncionario.Estado = true;

                                SQLPeticion peticion = new SQLPeticion
                                {
                                    Peticion = "INSERT INTO Funcionarios(Nombre, Contraseña, Puesto, Estado) VALUES('" + objfuncionario.Nombre + "','" + objfuncionario.Contraseña + "','" + objfuncionario.Puesto + "','" + objfuncionario.Estado + "')"
                                };
                                AccesoSQL objacceso = new AccesoSQL();
                                objacceso.EjecutarSentencia(peticion);
                                Console.WriteLine("Usuario registrado");
                                Console.ReadKey();
                            }
                            break;

                        case 3: 
                             { } break;
                        default:
                            {
                                Console.Clear();
                                Console.WriteLine("Opcion digitada no existe =  " + opc);
                                Console.ReadKey();
                            }break;
                    }
                    break;
                
                        } while (opc != 3) ;
             }
                catch (SqlException exSQL)
            {
                Console.Clear();
                Console.WriteLine(exSQL.Message);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    } 
}
