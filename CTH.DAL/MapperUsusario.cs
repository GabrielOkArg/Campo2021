using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using System.Data.SqlClient;
using System.Data;

namespace CTH.DAL
{
    public class MapperUsusario : IConectBD<Usuario>
    {
        public List<Usuario> GetAll(Usuario _element)
        {
            throw new NotImplementedException();
        }

        public Usuario GetElement(Usuario _element)
        {
            List<Usuario> listado = new List<Usuario>();
            string sqlstring = "Data Source=DESKTOP-N6CNO7F\\SQLEXPRESS;Initial Catalog=CTH_INT;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(sqlstring))

            {
                    SqlCommand cdm = new SqlCommand("GetUser",conn);
                cdm.CommandType = CommandType.StoredProcedure;
                cdm.CommandText = "GetUser"; //nombre del store procedure
                cdm.Parameters.Add("@username", SqlDbType.NVarChar).Value = _element.getUserName;
                DataTable dataTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cdm);
                conn.Open();
                da.Fill(dataTable);
                conn.Close();
                _element.apellido = dataTable.Rows[0].ItemArray[2].ToString();
                _element.nombre = dataTable.Rows[0].ItemArray[1].ToString();
                _element.id = Convert.ToInt32( dataTable.Rows[0].ItemArray[0]);
                _element.pass = dataTable.Rows[0].ItemArray[4].ToString();
            }
            return _element;
            
        }

    }
}
