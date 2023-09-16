using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Data;
using System.Windows.Forms;
using EjercicioPreParcial.Entities;

namespace EjercicioPreParcial.Services
{
    internal class Connection
    {
        public SqlConnection conn { get; set; }

        public Connection()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-1G25HFQ;Initial Catalog=simulacro_parcial;Integrated Security=True");

        }

        public DataTable ConsultarJugadores()
        {
            DataTable table = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_CONSULTAR_PERSONAS", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            try
            {
                table.Load(cmd.ExecuteReader());

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "error al traer la base de datos");
            }
            finally
            {
                conn.Close();
            }

            return table;
        }

    
        public void RegistrarEquipo(Equipo equipo)
        {
            SqlTransaction transaction = null;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                 int id = RegistrarEquipo(transaction, equipo);
                RegistrarJugador(transaction, equipo.JugadorList, id);
                transaction.Commit();

        }
            catch(Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show(ex.Message, "error al traer la base de datos");

            }
            finally
            {
                conn.Close();
            }


        }

        private void RegistrarJugador(SqlTransaction transaction, List<Jugador> jugadores, int idEquipo)
        {

            foreach(Jugador jugador in jugadores)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = transaction;
                List<Param> listParam = new List<Param>();
                listParam.Add( new Param("@id_Equipo", idEquipo.ToString()));
                listParam.Add(new Param("@id_persona", jugador.Persona.id.ToString()));
                listParam.Add(new Param("@Camiseta", jugador.Camiseta.ToString()));
                listParam.Add(new Param("@posicion", jugador.posicion));

                ExecuteProcedure(cmd,"SP_INSERTAR_DETALLES_EQUIPOS", listParam);

            }

        }

        private int RegistrarEquipo(SqlTransaction transaction, Equipo equipo)
        {
            int idEquipo = 0;
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_EQUIPO", conn);
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Transaction = transaction;
            SqlParameter idParam = new SqlParameter("@id", SqlDbType.Int);
            idParam.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(idParam);
            cmd.Parameters.AddWithValue("@pais", equipo.Pais);
            cmd.Parameters.AddWithValue("@director_tecnico", equipo.DirectorTecnico);
            cmd.ExecuteNonQuery();
            idEquipo = (int)idParam.Value;

            return idEquipo;
        }

        private void ExecuteProcedure(SqlCommand cmd, string Procedure, List<Param> listParameters)
        {
            cmd.CommandText = Procedure;
            cmd.CommandType = CommandType.StoredProcedure;

            foreach(Param param in listParameters)
            {
                cmd.Parameters.AddWithValue(param.Parameter, param.Value);
            }
            cmd.ExecuteNonQuery();
           
        }

        
    }
}
