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
                string sqlstring = "Data Source=EDUARDOSILVA1\\SQLEXPRESS01;Initial Catalog=CTH_INT;Integrated Security=True";
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
    }
}
