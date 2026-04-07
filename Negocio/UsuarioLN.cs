using AccesoDatos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.AccessControl;
using System.Data.SqlClient;
using System.Data;

namespace Negocio 
{
    public class UsuarioLN
    {
        public static bool Agregar(Funcionario P_Entidad )
        {
            SqlParameter parametroNombre= new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroContraseña = new SqlParameter
            {
                ParameterName = @"@Contraseña",
                Value = P_Entidad.Contraseña,
                SqlDbType = SqlDbType.NVarChar,
                Size = 20,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroPuesto = new SqlParameter
            {
                ParameterName = @"@Puesto",
                Value = P_Entidad.Puesto,
                SqlDbType = SqlDbType.NVarChar,
                Size = 30,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroEstado = new SqlParameter
            {
                ParameterName = @"@Estado",
                Value = P_Entidad.Estado,
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Input
            };


            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_AgregarFuncionario @Nombre, @Contraseña, @Puesto, @Estado",
                ListaParametros = new List<SqlParameter> { parametroNombre, parametroContraseña, parametroPuesto, parametroEstado }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static bool Modificar(Funcionario P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroContraseña = new SqlParameter
            {
                ParameterName = @"@Contraseña",
                Value = P_Entidad.Contraseña,
                SqlDbType = SqlDbType.NVarChar,
                Size = 20,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroPuesto = new SqlParameter
            {
                ParameterName = @"@Puesto",
                Value = P_Entidad.Puesto,
                SqlDbType = SqlDbType.NVarChar,
                Size = 30,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroEstado = new SqlParameter
            {
                ParameterName = @"@Estado",
                Value = P_Entidad.Estado,
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_ModificarFuncionario @Nombre, @Contraseña, @Puesto, @Estado", 
                ListaParametros = new List<SqlParameter> { parametroNombre, parametroContraseña, parametroPuesto, parametroEstado }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static bool Eliminar(Funcionario P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };


            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_EliminarFuncionario @Nombre", 
                ListaParametros = new List<SqlParameter> { parametroNombre}        
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static List<Funcionario> Consultar(Funcionario P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {

                Peticion = "EXEC PA_ConsultarFuncionario @Nombre",
                ListaParametros = new List<SqlParameter> { parametroNombre }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.ConsultaFuncionario(peticion);
        }

        // Matricula
        public static bool Agregar(Matricula P_Entidad)
        {
            SqlParameter parametroIDMateria = new SqlParameter
            {
                ParameterName = @"@ID_Materia",
                Value = P_Entidad.ID_Materia,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroIDEstudiante = new SqlParameter
            {
                ParameterName = @"@ID_Estudiante",
                Value = P_Entidad.ID_Estudiante,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroEstado = new SqlParameter
            {
                ParameterName = @"@Estado",
                Value = P_Entidad.Estado,
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_AgregarMatricula @ID_Materia, @ID_Estudiante, @Estado",
                ListaParametros = new List<SqlParameter> { parametroIDMateria, parametroIDEstudiante, parametroEstado }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static bool Modificar(Matricula P_Entidad)
        {

            SqlParameter parametroIDMatricula = new SqlParameter
            {
                ParameterName = @"@ID_Matricula",
                Value = P_Entidad.ID_Matricula,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroIDMateria = new SqlParameter
            {
                ParameterName = @"@ID_Materia",
                Value = P_Entidad.ID_Materia,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroIDEstudiante = new SqlParameter
            {
                ParameterName = @"@ID_Estudiante",
                Value = P_Entidad.ID_Estudiante,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroEstado = new SqlParameter
            {
                ParameterName = @"@Estado",
                Value = P_Entidad.Estado,
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_ModificarMatricula @ID_Matricula, @ID_Materia, @ID_Estudiante, @Estado",
                ListaParametros = new List<SqlParameter> { parametroIDMatricula, parametroIDMateria, parametroIDEstudiante, parametroEstado }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static bool Eliminar(Matricula P_Entidad)
        {
            SqlParameter parametroIDMatricula = new SqlParameter
            {
                ParameterName = @"@ID_Matricula",
                Value = P_Entidad.ID_Matricula,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_EliminarMatricula @ID_Matricula",
                ListaParametros = new List<SqlParameter> { parametroIDMatricula }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static List<Matricula> Consultar(Matricula P_Entidad)
        {
            SqlParameter parametroIDEstudiante = new SqlParameter
            {
                ParameterName = @"@ID_Estudiante",
                Value = P_Entidad.ID_Estudiante,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {

                Peticion = "EXEC PA_ConsultarMatriculas @ID_Estudiante",
                ListaParametros = new List<SqlParameter> { parametroIDEstudiante }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.ConsultaMatriculas(peticion);
        }

        // Estudiantes

        public static bool Agregar(Estudiantes P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroCorreo = new SqlParameter
            {
                ParameterName = @"@Correo",
                Value = P_Entidad.Correo,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroTelefono = new SqlParameter
            {
                ParameterName = @"@Telefono",
                Value = P_Entidad.Telefono,
                SqlDbType = SqlDbType.NVarChar,
                Size = 20,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroEstado = new SqlParameter
            {
                ParameterName = @"@Estado",
                Value = P_Entidad.Estado,
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_AgregarEstudiante @Nombre, @Correo, @Telefono, @Estado",
                ListaParametros = new List<SqlParameter> { parametroNombre, parametroCorreo, parametroTelefono, parametroEstado}
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static bool Modificar(Estudiantes P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroCorreo = new SqlParameter
            {
                ParameterName = @"@Correo",
                Value = P_Entidad.Correo,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroTelefono = new SqlParameter
            {
                ParameterName = @"@Telefono",
                Value = P_Entidad.Telefono,
                SqlDbType = SqlDbType.NVarChar,
                Size = 20,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroEstado = new SqlParameter
            {
                ParameterName = @"@Estado",
                Value = P_Entidad.Estado,
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_ModificarEstudiante @Nombre, @Correo, @Telefono, @Estado",
                ListaParametros = new List<SqlParameter> { parametroNombre, parametroCorreo, parametroTelefono, parametroEstado}
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static bool Eliminar(Estudiantes P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };


            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_EliminarEstudiante @Nombre",
                ListaParametros = new List<SqlParameter> { parametroNombre }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static List<Estudiantes>Consultar(Estudiantes P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                
                Peticion = "EXEC PA_ConsultarEstudiante @Nombre",
                ListaParametros = new List<SqlParameter> { parametroNombre }
            };
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultaEstudiantes(peticion);
        }


        //Materia
        public static bool Agregar(Materias P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroDescripcion = new SqlParameter
            {
                ParameterName = @"@Descripcion",
                Value = P_Entidad.Descripcion,
                SqlDbType = SqlDbType.NVarChar,
                Size = 200,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroProfesorID = new SqlParameter
            {
                ParameterName = @"@ProfesorID",
                Value = P_Entidad.ID_Profesor,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroAulaID = new SqlParameter
            {
                ParameterName = @"@AulaID",
                Value = P_Entidad.ID_Aula,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroHorarioID = new SqlParameter
            {
                ParameterName = @"@HorarioID",
                Value = P_Entidad.ID_Horario,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_AgregarMateria @Nombre, @Descripcion, @ProfesorID, @AulaID, @HorarioID",
                ListaParametros = new List<SqlParameter> { parametroNombre, parametroDescripcion, parametroProfesorID, parametroAulaID, parametroHorarioID }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static bool Modificar(Materias P_Entidad)
        {
            SqlParameter parametroMateriaID = new SqlParameter
            {
                ParameterName = @"@MateriaID",
                Value = P_Entidad.ID_Materia,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroDescripcion = new SqlParameter
            {
                ParameterName = @"@Descripcion",
                Value = P_Entidad.Descripcion,
                SqlDbType = SqlDbType.NVarChar,
                Size = 200,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroProfesorID = new SqlParameter
            {
                ParameterName = @"@ProfesorID",
                Value = P_Entidad.ID_Profesor,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroAulaID = new SqlParameter
            {
                ParameterName = @"@AulaID",
                Value = P_Entidad.ID_Aula,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroHorarioID = new SqlParameter
            {
                ParameterName = @"@HorarioID",
                Value = P_Entidad.ID_Horario,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_ModificarMateria @MateriaID, @Nombre, @Descripcion, @ProfesorID, @AulaID, @HorarioID",
                ListaParametros = new List<SqlParameter> { parametroMateriaID, parametroNombre, parametroDescripcion, parametroProfesorID, parametroAulaID, parametroHorarioID }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static bool Eliminar(Materias P_Entidad)
        {
            SqlParameter parametroMateriaID = new SqlParameter
            {
                ParameterName = @"@MateriaID",
                Value = P_Entidad.ID_Materia,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_EliminarMateria @MateriaID",
                ListaParametros = new List<SqlParameter> { parametroMateriaID }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static List<Materias> Consultar(Materias P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {

                Peticion = "EXEC PA_ConsultarMaterias @Nombre",
                ListaParametros = new List<SqlParameter> { parametroNombre }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.ConsultaMaterias(peticion);
        }

        //Profesor
        public static bool Agregar(Profesor P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroCorreo = new SqlParameter
            {
                ParameterName = @"@Correo",
                Value = P_Entidad.Correo,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };
            SqlParameter parametroTelefono = new SqlParameter
            {
                ParameterName = @"@Telefono",
                Value = P_Entidad.Telefono,
                SqlDbType = SqlDbType.NVarChar,
                Size = 20,
                Direction = ParameterDirection.Input
            };
            SqlParameter parametroEstado = new SqlParameter
            {
                ParameterName = @"@Estado",
                Value = P_Entidad.Estado,
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_AgregarProfesor @Nombre, @Correo, @Telefono,@Estado",
                ListaParametros = new List<SqlParameter> { parametroNombre, parametroCorreo, parametroTelefono, parametroEstado }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static bool Modificar(Profesor P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroCorreo = new SqlParameter
            {
                ParameterName = @"@Correo",
                Value = P_Entidad.Correo,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };
            SqlParameter parametroTelefono = new SqlParameter
            {
                ParameterName = @"@Telefono",
                Value = P_Entidad.Telefono,
                SqlDbType = SqlDbType.NVarChar,
                Size = 20,
                Direction = ParameterDirection.Input
            };
            SqlParameter parametroEstado = new SqlParameter
            {
                ParameterName = @"@Estado",
                Value = P_Entidad.Estado,
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_ModificarProfesor @Nombre, @Correo, @Telefono, @Estado",
                ListaParametros = new List<SqlParameter> { parametroNombre, parametroCorreo, parametroTelefono, parametroEstado }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static bool Eliminar(Profesor P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };


            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_EliminarProfesor @Nombre",
                ListaParametros = new List<SqlParameter> { parametroNombre }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static List<Profesor> Consultar(Profesor P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {

                Peticion = "EXEC PA_ConsultarProfesores @Nombre",
                ListaParametros = new List<SqlParameter> { parametroNombre }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.ConsultaProfesores(peticion);
        }

        public static Profesor ConsultarProfesor(Profesor P_Entidad)
        {
            SqlParameter parametroProfesorID = new SqlParameter
            {
                ParameterName = @"@ProfesorID",
                Value = P_Entidad.ID_Profesor,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {

                Peticion = "EXEC PA_ConsultarProfesor @ProfesorID",
                ListaParametros = new List<SqlParameter> { parametroProfesorID }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.ConsultaProfesor(peticion);
        }


        //Horario
        public static bool Agregar(Horarios P_Entidad)
        {
            SqlParameter parametroDia = new SqlParameter
            {
                ParameterName = @"@Dia",
                Value = P_Entidad.Dia,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroHoraInicio = new SqlParameter
            {
                ParameterName = @"@HoraInicio",
                Value = P_Entidad.Hora_inicio,
                SqlDbType = SqlDbType.Time,
                Direction = ParameterDirection.Input
            };
            SqlParameter parametroHoraFin = new SqlParameter
            {
                ParameterName = @"@HoraFin",
                Value = P_Entidad.Hora_fin,
                SqlDbType = SqlDbType.Time,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_AgregarHorario @Dia, @HoraInicio, @HoraFin",
                ListaParametros = new List<SqlParameter> { parametroDia, parametroHoraInicio, parametroHoraFin }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static bool Modificar(Horarios P_Entidad)
        {

            SqlParameter parametroHorarioID = new SqlParameter
            {
                ParameterName = @"@HorarioID",
                Value = P_Entidad.ID_Horario,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroDia = new SqlParameter
            {
                ParameterName = @"@Dia",
                Value = P_Entidad.Dia,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroHoraInicio = new SqlParameter
            {
                ParameterName = @"@HoraInicio",
                Value = P_Entidad.Hora_inicio,
                SqlDbType = SqlDbType.Time,
                Direction = ParameterDirection.Input
            };
            SqlParameter parametroHoraFin = new SqlParameter
            {
                ParameterName = @"@HoraFin",
                Value = P_Entidad.Hora_fin,
                SqlDbType = SqlDbType.Time,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_ModificarHorario @HorarioID,@Dia, @HoraInicio, @HoraFin",
                ListaParametros = new List<SqlParameter> { parametroHorarioID, parametroDia, parametroHoraInicio, parametroHoraFin }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static bool Eliminar(Horarios P_Entidad)
        {
            SqlParameter parametroDia = new SqlParameter
            {
                ParameterName = @"@Dia",
                Value = P_Entidad.Dia,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroHoraInicio = new SqlParameter
            {
                ParameterName = @"@HoraInicio",
                Value = P_Entidad.Hora_inicio,
                SqlDbType = SqlDbType.Time,
                Direction = ParameterDirection.Input
            };
            SqlParameter parametroHoraFin = new SqlParameter
            {
                ParameterName = @"@HoraFin",
                Value = P_Entidad.Hora_fin,
                SqlDbType = SqlDbType.Time,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_EliminarHorario @Dia, @HoraInicio, @HoraFin",
                ListaParametros = new List<SqlParameter> { parametroDia, parametroHoraInicio, parametroHoraFin }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static List<Horarios> Consultar(Horarios P_Entidad)
        {
            SqlParameter parametroDia = new SqlParameter
            {
                ParameterName = @"@Dia",
                Value = P_Entidad.Dia,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {

                Peticion = "EXEC PA_ConsultarHorarios",
                ListaParametros = new List<SqlParameter> { parametroDia }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.ConsultaHorarios(peticion);
        }

        public static Horarios ConsultarHorario(Horarios P_Entidad)
        {
            SqlParameter parametroHorarioID = new SqlParameter
            {
                ParameterName = @"@HorarioID",
                Value = P_Entidad.ID_Horario,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {

                Peticion = "EXEC PA_ConsultarHorario @HorarioID",
                ListaParametros = new List<SqlParameter> { parametroHorarioID }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.ConsultaHorario(peticion);
        }

        // Aula

        public static bool Agregar(Aula P_Entidad)
        {
            SqlParameter parametroNumero = new SqlParameter
            {
                ParameterName = @"@Numero",
                Value = P_Entidad.Numero,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroUbicacion = new SqlParameter
            {
                ParameterName = @"@Ubicacion",
                Value = P_Entidad.Ubicacion,
                SqlDbType = SqlDbType.NVarChar,
                Size = 255,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroEstado = new SqlParameter
            {
                ParameterName = @"@Estado",
                Value = P_Entidad.Estado,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_AgregarAula @Numero, @Ubicacion, @Estado",
                ListaParametros = new List<SqlParameter> { parametroNumero, parametroUbicacion, parametroEstado }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static bool Modificar(Aula P_Entidad)
        {
            SqlParameter parametroAulaID = new SqlParameter
            {
                ParameterName = @"@AulaID",
                Value = P_Entidad.ID_Aula,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroNumero = new SqlParameter
            {
                ParameterName = @"@Numero",
                Value = P_Entidad.Numero,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroUbicacion = new SqlParameter
            {
                ParameterName = @"@Ubicacion",
                Value = P_Entidad.Ubicacion,
                SqlDbType = SqlDbType.NVarChar,
                Size = 255,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroEstado = new SqlParameter
            {
                ParameterName = @"@Estado",
                Value = P_Entidad.Estado,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_ModificarAula @AulaID, @Numero, @Ubicacion, @Estado",
                ListaParametros = new List<SqlParameter> { parametroAulaID, parametroNumero, parametroUbicacion, parametroEstado }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static bool Eliminar(Aula P_Entidad)
        {
            SqlParameter parametroAulaID = new SqlParameter
            {
                ParameterName = @"@AulaID",
                Value = P_Entidad.ID_Aula,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_EliminarAula @AulaID",
                ListaParametros = new List<SqlParameter> { parametroAulaID }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.EjecutarSentencia(peticion);
        }

        public static List<Aula> Consultar(Aula P_Entidad)
        {
            SqlParameter parametroUbicacion = new SqlParameter
            {
                ParameterName = @"@Ubicacion",
                Value = P_Entidad.Ubicacion,
                SqlDbType = SqlDbType.NVarChar,
                Size = 255,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {

                Peticion = "EXEC PA_ConsultarAulas @Ubicacion",
                ListaParametros = new List<SqlParameter> { parametroUbicacion }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.ConsultaAulas(peticion);
        }

        public static Aula ConsultarAula(Aula P_Entidad)
        {
            SqlParameter parametroAulaID = new SqlParameter
            {
                ParameterName = @"@AulaID",
                Value = P_Entidad.ID_Aula,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {

                Peticion = "EXEC PA_ConsultarAula @AulaID",
                ListaParametros = new List<SqlParameter> { parametroAulaID }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.ConsultaAula(peticion);
        }

        public static Funcionario Autentificacion(Funcionario P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };            
            SqlParameter parametroContraseña = new SqlParameter
            {
                ParameterName = @"@Contraseña",
                Value = P_Entidad.Contraseña,
                SqlDbType = SqlDbType.NVarChar,
                Size = 20,
                Direction = ParameterDirection.Input
            };


            SQLPeticion peticion = new SQLPeticion
            {

                Peticion = "EXEC PA_Autenticacion @Nombre, @Contraseña",
                ListaParametros = new List<SqlParameter> { parametroNombre, parametroContraseña }
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.Autenticacion(peticion);
        }

        public static List<Usuario> Autorizacion(Funcionario P_Entidad)
        {
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };            

            SQLPeticion peticion = new SQLPeticion
            {

                Peticion = "EXEC PA_Autorizacion @Nombre",
                ListaParametros = new List<SqlParameter> { parametroNombre}
            };
            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.Autorizacion(peticion);
        }

        public static bool RegistrarUsuario (Funcionario P_Entidad)
        {
            List<SqlCommand> ListaPeticiones = new List<SqlCommand>();
            AccesoSQL objacceso = new AccesoSQL();

        
            SqlParameter parametroNombre = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroContraseña = new SqlParameter
            {
                ParameterName = @"@Contraseña",
                Value = P_Entidad.Contraseña,
                SqlDbType = SqlDbType.NVarChar,
                Size = 20,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroPuesto = new SqlParameter
            {
                ParameterName = @"@Puesto",
                Value = P_Entidad.Puesto,
                SqlDbType = SqlDbType.NVarChar,
                Size = 30,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroEstado = new SqlParameter
            {
                ParameterName = @"@Estado",
                Value = P_Entidad.Estado,
                SqlDbType = SqlDbType.Bit,
                Direction = ParameterDirection.Input
            };

            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_AgregarFuncionario @Nombre, @Contraseña, @Puesto, @Estado",
                ListaParametros = new List<SqlParameter> { parametroNombre, parametroContraseña, parametroPuesto, parametroEstado }
            };

            objacceso.Agregar_En_Cola(peticion, ref ListaPeticiones);

          
            SqlParameter parametroNombre2 = new SqlParameter
            {
                ParameterName = @"@Nombre",
                Value = P_Entidad.Nombre,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50,
                Direction = ParameterDirection.Input
            };

            SqlParameter parametroUsuario = new SqlParameter
            {
                ParameterName = @"@Usuario",
                Value = P_Entidad.PerfilesAsociados.FirstOrDefault().Nombre,
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Input
            };

             peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_AgregarUsuarioPorPerfil @Nombre, @Usuario",
                ListaParametros = new List<SqlParameter> { parametroNombre2, parametroUsuario }
            };
            objacceso.Agregar_En_Cola(peticion, ref ListaPeticiones);

        
            return objacceso.EjecutarTransaccion(ListaPeticiones);


        }


    }
}
