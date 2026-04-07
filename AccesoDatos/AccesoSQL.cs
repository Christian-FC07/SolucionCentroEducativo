using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Seguridad;

namespace AccesoDatos
{
    public class AccesoSQL
    {
        #region Atributos
        private string cadenadeconexion = ConfigurationManager.AppSettings["conexionBD"].ToString();
        

        private SqlConnection Objconexion;

        #endregion

        #region Constructor          
        public AccesoSQL()
        {
            try  
            {
                Objconexion = new SqlConnection(Encriptacion.Desencriptar(cadenadeconexion));
                ABRIR();
            }
            catch (SqlException exSQL)
            {
                throw exSQL;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }
        }
        #endregion

        #region Metodos

        #region privados

        private void ABRIR()
        {
            if (Objconexion.State == System.Data.ConnectionState.Closed)
                Objconexion.Open();
        }
        private void CERRAR()
        {
            if (Objconexion.State == System.Data.ConnectionState.Open)
                Objconexion.Close();
        }

        #endregion

        #region Publicos    

        #region Transaccion

        public void Agregar_En_Cola(SQLPeticion P_Entidad, ref List<SqlCommand> P_ListaPeticiones)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = Objconexion,
                CommandType = System.Data.CommandType.Text,
                CommandText = P_Entidad.Peticion
            };

            if (P_Entidad.ListaParametros.Count > 0)
                cmd.Parameters.AddRange(P_Entidad.ListaParametros.ToArray());

            P_ListaPeticiones.Add(cmd);
        }

        public bool EjecutarTransaccion(List<SqlCommand> P_ListaPeticion)
        {
            SqlTransaction objtran;
            ABRIR();
            objtran = Objconexion.BeginTransaction();

            try
            {
                foreach (SqlCommand cmd in P_ListaPeticion)
                {
                    cmd.Transaction = objtran;
                    cmd.Connection = Objconexion;
                    cmd.ExecuteNonQuery();
                }
                objtran.Commit();
            }
            catch (Exception ex)
            {
                objtran.Rollback();
                return false;
            }
            finally
            {
                CERRAR();       
            }
            return true;
        }        
        #endregion

        public bool EjecutarSentencia(SQLPeticion P_Entidad)
        {
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Objconexion,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_Entidad.Peticion
                };

                if (P_Entidad.ListaParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Entidad.ListaParametros.ToArray());

                ABRIR();
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            #endregion
            #endregion
        }
        
        public List<Funcionario> ConsultaFuncionario(SQLPeticion P_Entidad)
        {
            DataTable dt = new DataTable();
            List<Funcionario> lstresultado = new List<Funcionario>();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Objconexion,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_Entidad.Peticion
                };

                if (P_Entidad.ListaParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Entidad.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        Funcionario p = new Funcionario
                        {
                            Nombre = fila.ItemArray[0].ToString(),
                            Contraseña = fila.ItemArray[1].ToString(),
                            Puesto = fila.ItemArray[2].ToString(),
                            Estado = Convert.ToBoolean(fila.ItemArray[3].ToString())

                        };

                        lstresultado.Add(p);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return lstresultado;
        }

        //Matriculas
        public List<Matricula> ConsultaMatriculas(SQLPeticion P_Entidad)
        {
            DataTable dt = new DataTable();
            List<Matricula> lstresultado = new List<Matricula>();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Objconexion,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_Entidad.Peticion
                };

                if (P_Entidad.ListaParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Entidad.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        Matricula m = new Matricula
                        {
                            ID_Matricula = Convert.ToInt32(fila.ItemArray[0].ToString()),
                            Dia_Matricula = DateTime.Parse(fila.ItemArray[1].ToString()),
                            ID_Materia = Convert.ToInt32(fila.ItemArray[2].ToString()),
                            ID_Estudiante = Convert.ToInt32(fila.ItemArray[3].ToString()),
                            Estado = Convert.ToBoolean(fila.ItemArray[4].ToString())
                        };

                        lstresultado.Add(m);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return lstresultado;
        }

        // Estudiantes
        public List<Estudiantes> ConsultaEstudiantes(SQLPeticion P_Entidad)
        {
            DataTable dt = new DataTable();
            List<Estudiantes> lstresultado = new List<Estudiantes>();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Objconexion,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_Entidad.Peticion
                };

                if (P_Entidad.ListaParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Entidad.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        Estudiantes e = new Estudiantes
                        {
                            ID_Estudiante = Convert.ToInt32(fila.ItemArray[0].ToString()),
                            Nombre = fila.ItemArray[1].ToString(),
                            Correo = fila.ItemArray[2].ToString(),
                            Telefono = fila.ItemArray[3].ToString(),
                            Estado = Convert.ToBoolean(fila.ItemArray[4].ToString())

                        };

                        lstresultado.Add(e);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return lstresultado;
        }
        //Materias
        public List<Materias> ConsultaMaterias(SQLPeticion P_Entidad)
        {
            DataTable dt = new DataTable();
            List<Materias> lstresultado = new List<Materias>();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Objconexion,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_Entidad.Peticion
                };

                if (P_Entidad.ListaParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Entidad.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        Materias m = new Materias
                        {
                            ID_Materia = Convert.ToInt32(fila.ItemArray[0].ToString()),
                            Nombre = fila.ItemArray[1].ToString(),
                            Descripcion = fila.ItemArray[2].ToString(),
                            ID_Profesor = Convert.ToInt32(fila.ItemArray[3].ToString()),
                            ID_Aula = Convert.ToInt32(fila.ItemArray[4].ToString()),
                            ID_Horario = Convert.ToInt32(fila.ItemArray[5].ToString())
                        };

                        lstresultado.Add(m);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return lstresultado;
        }
        //Profesor
        public List<Profesor> ConsultaProfesores(SQLPeticion P_Entidad)
        {
            DataTable dt = new DataTable();
            List<Profesor> lstresultado = new List<Profesor>();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Objconexion,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_Entidad.Peticion
                };

                if (P_Entidad.ListaParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Entidad.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        Profesor p = new Profesor
                        {
                            ID_Profesor = Convert.ToInt32(fila.ItemArray[0].ToString()),
                            Nombre = fila.ItemArray[1].ToString(),
                            Correo = fila.ItemArray[2].ToString(),
                            Telefono = fila.ItemArray[3].ToString(),
                            Estado = Convert.ToBoolean(fila.ItemArray[4].ToString())

                        };

                        lstresultado.Add(p);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return lstresultado;
        }
        //Consulta Profesor
        public Profesor ConsultaProfesor(SQLPeticion P_Entidad)
        {
            DataTable dt = new DataTable();
            Profesor resultado = null;
            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Objconexion,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_Entidad.Peticion
                };

                if (P_Entidad.ListaParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Entidad.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];
                    resultado = new Profesor
                    {
                        ID_Profesor = Convert.ToInt32(fila.ItemArray[0].ToString()),
                        Nombre = fila.ItemArray[1].ToString(),
                        Correo = fila.ItemArray[2].ToString(),
                        Telefono = fila.ItemArray[3].ToString(),
                        Estado = Convert.ToBoolean(fila.ItemArray[4].ToString())
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return resultado;
        }
        //Horarios
        public List<Horarios> ConsultaHorarios(SQLPeticion P_Entidad)
        {
            DataTable dt = new DataTable();
            List<Horarios> lstresultado = new List<Horarios>();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Objconexion,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_Entidad.Peticion
                };

                if (P_Entidad.ListaParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Entidad.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        Horarios h = new Horarios
                        {
                            ID_Horario = Convert.ToInt32(fila.ItemArray[0].ToString()),
                            Dia = fila.ItemArray[1].ToString(),
                            Hora_inicio = TimeSpan.Parse(fila.ItemArray[2].ToString()),
                            Hora_fin = TimeSpan.Parse(fila.ItemArray[3].ToString()),
                        };

                        lstresultado.Add(h);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return lstresultado;
        }
        //Consulta Horarios
        public Horarios ConsultaHorario(SQLPeticion P_Entidad)
        {
            DataTable dt = new DataTable();
            Horarios resultado = null;

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Objconexion,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_Entidad.Peticion
                };

                if (P_Entidad.ListaParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Entidad.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];
                    resultado = new Horarios
                    {
                        ID_Horario = Convert.ToInt32(fila.ItemArray[0].ToString()),
                        Dia = fila.ItemArray[1].ToString(),
                        Hora_inicio = TimeSpan.Parse(fila.ItemArray[2].ToString()),
                        Hora_fin = TimeSpan.Parse(fila.ItemArray[3].ToString())
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return resultado;
        }
        //  Aulas
        public List<Aula> ConsultaAulas(SQLPeticion P_Entidad)
        {
            DataTable dt = new DataTable();
            List<Aula> lstresultado = new List<Aula>();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Objconexion,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_Entidad.Peticion
                };

                if (P_Entidad.ListaParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Entidad.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        Aula h = new Aula
                        {
                            ID_Aula = Convert.ToInt32(fila.ItemArray[0].ToString()),
                            Numero = Convert.ToInt32(fila.ItemArray[1].ToString()),
                            Ubicacion = fila.ItemArray[2].ToString(),
                            Estado = fila.ItemArray[3].ToString(),
                        };

                        lstresultado.Add(h);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return lstresultado;
        }

        public Aula ConsultaAula(SQLPeticion P_Entidad)
        {
            DataTable dt = new DataTable();
            Aula resultado = null;

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Objconexion,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_Entidad.Peticion
                };

                if (P_Entidad.ListaParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Entidad.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow fila = dt.Rows[0];
                    resultado = new Aula
                    {
                        ID_Aula = Convert.ToInt32(fila.ItemArray[0].ToString()),
                        Numero = Convert.ToInt32(fila.ItemArray[1].ToString()),
                        Ubicacion = fila.ItemArray[2].ToString(),
                        Estado = fila.ItemArray[3].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return resultado;
        }

        public Funcionario Autenticacion(SQLPeticion P_Entidad) 
        {
            DataTable dt = new DataTable();
            Funcionario resultado = new Funcionario();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Objconexion,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_Entidad.Peticion
                };

                if (P_Entidad.ListaParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Entidad.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow fila in dt.Rows)
                        {
                            resultado.Nombre = fila.ItemArray[0].ToString();                        
                        }                    
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return resultado;
        }

        public List<Usuario> Autorizacion(SQLPeticion P_Entidad)
        {
            DataTable dt = new DataTable();
            List<Usuario> resultado = new List<Usuario>();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = Objconexion,
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_Entidad.Peticion
                };

                if (P_Entidad.ListaParametros.Count > 0)
                    cmd.Parameters.AddRange(P_Entidad.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow fila in dt.Rows)
                    {
                        Usuario u = new Usuario 
                        {
                            Codigo_Usuario = Convert.ToInt32(fila.ItemArray[0].ToString()),
                            Descripcion = fila.ItemArray[1].ToString()
                        };
                        resultado.Add(u);
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return resultado;
        }



    }

}

    
