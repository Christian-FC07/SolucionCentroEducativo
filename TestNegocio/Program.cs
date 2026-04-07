using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNegocio
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
                    menu += "1. Insertar  \n";
                    menu += "2. Modificar  \n";
                    menu += "3. Eliminar  \n";
                    menu += "4. Consultar  \n";
                    menu += "5. Salir \n";
                    menu += "Digite Opcion  \n";

                    Console.WriteLine(menu);
                    opc = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    switch (opc)
                    {
                        case 1:
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

                                UsuarioLN.Agregar(objfuncionario);
                                Console.WriteLine("Usuario Registrado");
                                Console.ReadKey();  

                            }
                            break;
                        case 2:
                            {
                                Funcionario objfuncionario = new Funcionario();

                                Console.Clear();

                                Console.WriteLine("Digite nombre usuario actual : ");
                                objfuncionario.Nombre = Console.ReadLine();
                                Console.WriteLine("Digite Contraseña nueva");
                                objfuncionario.Contraseña = Console.ReadLine();
                                Console.WriteLine("Digite Puesto");
                                objfuncionario.Puesto = Console.ReadLine();

                                objfuncionario.Estado = true;

                                UsuarioLN.Modificar(objfuncionario);
                                Console.WriteLine("Usuario Modificado");
                                Console.ReadKey();

                            }
                            break;
                        case 3:
                            {
                                Funcionario objfuncionario = new Funcionario();

                                Console.WriteLine("Digite el usuario a eliminar: ");
                                objfuncionario.Nombre = Console.ReadLine();

                                UsuarioLN.Eliminar(objfuncionario);
                                Console.WriteLine("Usuario eliminado");
                                Console.ReadKey();

                            }
                            break;
                        case 4:
                            {
                                Funcionario objfuncionario = new Funcionario();

                                Console.WriteLine("Digite el usuario a consultar: ");
                                objfuncionario.Nombre = Console.ReadLine();

                                List<Funcionario> respuesta = UsuarioLN.Consultar(objfuncionario);

                                if (respuesta.Count > 0)
                                {
                                    string mensaje = string.Empty;
                                    
                              
                                foreach (Funcionario dato in respuesta)
                                    {
                                        mensaje += "Nombre: " + dato.Nombre + "\n";
                                        mensaje += "Contraseña: " + dato.Contraseña + "\n";
                                        mensaje += "Puesto: " + dato.Puesto + "\n";
                                        mensaje += "Estado: " + dato.Estado + "\n";
                                        mensaje += ">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>\n";
                                    }
                                    Console.WriteLine(mensaje);
                                }
                                else
                                    Console.WriteLine("No se encontraron resultados");
                                    Console.ReadKey();

                            }
                            break;
                        case 5:{}
                            break;
                        default:
                            {
                                Console.WriteLine("Opcion no existe =>" + opc);
                                Console.ReadKey();
                            }
                            break;
                    }

                } while (opc != 5);
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

