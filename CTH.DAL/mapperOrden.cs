using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CTH.BE;

namespace CTH.DAL
{
    public class mapperOrden : IConectBD<Orden>
    {



        private string sqlstring = "Data Source=DESKTOP-N6CNO7F\\SQLEXPRESS;Initial Catalog=CTH_INT;Integrated Security=True";
        public List<Orden> GetAll(Orden _element)
        {
            throw new NotImplementedException();
        }

        public Orden GetElement(Orden _element)
        {
            throw new NotImplementedException();
        }

        public int Save(Orden _element)
        {
            int result = 0;
            try
            {
               
                using (SqlConnection conn = new SqlConnection(sqlstring))
                {
                    SqlCommand cdm = new SqlCommand("AddOrden", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "AddOrden"; //nombre del store procedure
                    cdm.Parameters.Add("@fechaCreacion", SqlDbType.Date).Value = _element.fechaCreacion;
                    cdm.Parameters.Add("@solicitante", SqlDbType.NVarChar).Value = _element.solicitante;
                    cdm.Parameters.Add("@sector", SqlDbType.NVarChar).Value = _element.sector;
                    cdm.Parameters.Add("@equipo", SqlDbType.Int).Value = _element.equipo;
                    cdm.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = _element.descripcion;
                    cdm.Parameters.Add("@urgencia", SqlDbType.NVarChar).Value = _element.urgencia;
                    cdm.Parameters.Add("@id_solicitante", SqlDbType.Int).Value = _element.id_solicitante;
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    da.Fill(dataTable);
                    conn.Close();
                    result = Convert.ToInt32(dataTable.Rows[0].ItemArray[0]);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return result;
        }

        public void AsignarAgente(Orden orden)
        {
            using(SqlConnection conn = new SqlConnection(sqlstring))
            {
                SqlCommand cdm = new SqlCommand("AsignarAgente", conn);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.CommandText = "AsignarAgente";
                cdm.Parameters.Add("@agente", SqlDbType.NVarChar).Value = orden.agente;
                cdm.Parameters.Add("@id_agente", SqlDbType.Int).Value = orden.id_agente;
                cdm.Parameters.Add("@id_orden", SqlDbType.Int).Value = orden.id;
                cdm.Parameters.Add("@asignada", SqlDbType.Bit).Value = orden.asignada;
                cdm.Parameters.Add("@coordinador", SqlDbType.NVarChar).Value = orden.coordinador;
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cdm);
                conn.Open();
                cdm.ExecuteNonQuery();
                conn.Close();
            }
        }

        public List<Orden> GetLibres()
        {
            List<Orden> listado = new List<Orden>();
            using (SqlConnection conn = new SqlConnection(sqlstring))
            {
                SqlCommand cdm = new SqlCommand("getOrdenLibre", conn);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.CommandText = "getOrdenLibre";
                DataTable dataTable = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cdm);
                conn.Open();
                sa.Fill(dataTable);
                conn.Close();


                foreach (DataRow item in dataTable.Rows)
                {
                    Orden orden = new Orden();
                    orden.id = Convert.ToInt32(item.ItemArray[0].ToString());
                    orden.fechaCreacion = Convert.ToDateTime(item.ItemArray[1]);
                    orden.fechaCierre = (item.ItemArray[2] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(item.ItemArray[2]));
                    orden.fechaFinalizado = (item.ItemArray[3] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(item.ItemArray[3]));
                    orden.solicitante = item.ItemArray[4].ToString();
                    orden.coordinador = item.ItemArray[5].ToString();
                    orden.agente = item.ItemArray[6].ToString();
                    orden.descripcion = item.ItemArray[7].ToString();
                    orden.sector = item.ItemArray[8].ToString();
                    orden.equipo = Convert.ToInt32(item.ItemArray[9].ToString());
                    orden.terminada = Convert.ToBoolean(item.ItemArray[10]);
                    orden.finalizada = Convert.ToBoolean(item.ItemArray[11]);
                    orden.cierre = Convert.ToBoolean(item.ItemArray[12]);
                    orden.urgencia = item.ItemArray[13].ToString();
                    orden.id_solicitante = Convert.ToInt32(item.ItemArray[14].ToString());
                    orden.tiempo = Convert.ToInt32(item.ItemArray[15]);
                    orden.asignada = Convert.ToBoolean(item.ItemArray[16]);
                    orden.estado = item.ItemArray[17].ToString();
                    listado.Add(orden);

                }
            }

            return listado.ToList();
        }

        public List<Orden> GetByAgente(int id)
        {
            List<Orden> listado = new List<Orden>();
            using (SqlConnection conn = new SqlConnection(sqlstring))
            {
                SqlCommand cdm = new SqlCommand("GetOrdenesByAgente", conn);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.CommandText = "GetOrdenesByAgente";
                cdm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                DataTable dataTable = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cdm);
                conn.Open();
                sa.Fill(dataTable);
                conn.Close();


                foreach (DataRow item in dataTable.Rows)
                {
                    Orden orden = new Orden();
                    orden.id = Convert.ToInt32(item.ItemArray[0].ToString());
                    orden.fechaCreacion = Convert.ToDateTime(item.ItemArray[1]);
                    orden.fechaCierre = (item.ItemArray[2] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(item.ItemArray[2]));
                    orden.fechaFinalizado = (item.ItemArray[3] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(item.ItemArray[3]));
                    orden.solicitante = item.ItemArray[4].ToString();
                    orden.coordinador = item.ItemArray[5].ToString();
                    orden.agente = item.ItemArray[6].ToString();
                    orden.descripcion = item.ItemArray[7].ToString();
                    orden.sector = item.ItemArray[8].ToString();
                    orden.equipo = Convert.ToInt32(item.ItemArray[9].ToString());
                    orden.terminada = Convert.ToBoolean(item.ItemArray[10]);
                    orden.finalizada = Convert.ToBoolean(item.ItemArray[11]);
                    orden.cierre = Convert.ToBoolean(item.ItemArray[12]);
                    orden.urgencia = item.ItemArray[13].ToString();
                    orden.id_solicitante = Convert.ToInt32(item.ItemArray[14].ToString());
                    orden.tiempo = Convert.ToInt32(item.ItemArray[15]);
                    orden.asignada = Convert.ToBoolean(item.ItemArray[16]);
                    orden.estado = item.ItemArray[17].ToString();
                    listado.Add(orden);

                }
            }

            return listado.ToList();
        }

        public List<Orden> GetByUser(int id)
        {
            List<Orden> listado = new List<Orden>();
            using (SqlConnection conn = new SqlConnection(sqlstring))
            {
                SqlCommand cdm = new SqlCommand("GetOrdenByIdUser", conn);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.CommandText = "GetOrdenByIdUser";
                cdm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                DataTable dataTable = new DataTable();
                SqlDataAdapter sa = new SqlDataAdapter(cdm);
                conn.Open();
                sa.Fill(dataTable);
                conn.Close();


                foreach (DataRow item in dataTable.Rows)
                {
                    Orden orden = new Orden();
                    orden.id = Convert.ToInt32(item.ItemArray[0].ToString());
                    orden.fechaCreacion =Convert.ToDateTime(item.ItemArray[1]);
                    orden.fechaCierre =(item.ItemArray[2] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(item.ItemArray[2]));
                    orden.fechaFinalizado = (item.ItemArray[3] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(item.ItemArray[3]));
                    orden.solicitante = item.ItemArray[4].ToString();
                    orden.coordinador = item.ItemArray[5].ToString();
                    orden.agente = item.ItemArray[6].ToString();
                    orden.descripcion = item.ItemArray[7].ToString();
                    orden.sector = item.ItemArray[8].ToString();
                    orden.equipo = Convert.ToInt32(item.ItemArray[9].ToString());
                    orden.terminada = Convert.ToBoolean(item.ItemArray[10]);
                    orden.finalizada = Convert.ToBoolean(item.ItemArray[11]);
                    orden.cierre = Convert.ToBoolean(item.ItemArray[12]);
                    orden.urgencia = item.ItemArray[13].ToString();
                    orden.id_solicitante = Convert.ToInt32(item.ItemArray[14].ToString());
                    orden.tiempo = Convert.ToInt32(item.ItemArray[15]);
                    orden.asignada = Convert.ToBoolean(item.ItemArray[16]);
                    orden.estado = item.ItemArray[17].ToString();
                    listado.Add(orden);

                }
            }

            return listado.ToList();
        }
        

        public Orden GetOrdenByID(int id)
        {
            Orden orden = new Orden();
            try
            {
                using (SqlConnection conn = new SqlConnection(sqlstring))
                {
                    SqlCommand cdm = new SqlCommand("getOrdenByIDot", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "getOrdenByIDot";
                    cdm.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter sa = new SqlDataAdapter(cdm);
                    conn.Open();
                    sa.Fill(dataTable);
                    conn.Close();


                    orden.id = Convert.ToInt32(dataTable.Rows[0].ItemArray[0].ToString());
                    orden.fechaCreacion = Convert.ToDateTime(dataTable.Rows[0].ItemArray[1]);
                    orden.fechaCierre = (dataTable.Rows[0].ItemArray[2] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dataTable.Rows[0].ItemArray[2]));
                    orden.fechaFinalizado = (dataTable.Rows[0].ItemArray[3] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(dataTable.Rows[0].ItemArray[3]));
                    orden.solicitante = dataTable.Rows[0].ItemArray[4].ToString();
                    orden.coordinador = dataTable.Rows[0].ItemArray[5].ToString();
                    orden.agente = dataTable.Rows[0].ItemArray[6].ToString();
                    orden.descripcion = dataTable.Rows[0].ItemArray[7].ToString();
                    orden.sector = dataTable.Rows[0].ItemArray[8].ToString();
                    orden.equipo = Convert.ToInt32(dataTable.Rows[0].ItemArray[9].ToString());
                    orden.terminada = Convert.ToBoolean(dataTable.Rows[0].ItemArray[10]);
                    orden.finalizada = Convert.ToBoolean(dataTable.Rows[0].ItemArray[11]);
                    orden.cierre = Convert.ToBoolean(dataTable.Rows[0].ItemArray[12]);
                    orden.urgencia = dataTable.Rows[0].ItemArray[13].ToString();
                    orden.id_solicitante = Convert.ToInt32(dataTable.Rows[0].ItemArray[14].ToString());
                    orden.tiempo = Convert.ToInt32(dataTable.Rows[0].ItemArray[15]);
                    orden.asignada = Convert.ToBoolean(dataTable.Rows[0].ItemArray[16]);
                    orden.estado = dataTable.Rows[0].ItemArray[17].ToString();
                }
                return orden;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
