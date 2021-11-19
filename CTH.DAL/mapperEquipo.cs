using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTH.BE;
using System.Data;
using System.Data.SqlClient;
namespace CTH.DAL
{
    public class mapperEquipo : IConectBD<Equipo>
    {
        public List<Equipo> GetAll(Equipo _element)
        {
            throw new NotImplementedException();
        }

        public Equipo GetElement(Equipo _element)
        {
            throw new NotImplementedException();
        }

        public List<Equipo> GetByIdSector(int id)
        {
            List<Equipo> listado = new List<Equipo>();
            try
            {
                string sqlstring = "Data Source=EDUARDOSILVA1\\SQLEXPRESS01;Initial Catalog=CTH_INT;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(sqlstring))

                {
                    SqlCommand cdm = new SqlCommand("GetEquipoBySector", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "GetEquipoBySector"; //nombre del store procedure
                    cdm.Parameters.Add("@id_sector", SqlDbType.Int).Value = id;
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    da.Fill(dataTable);
                    conn.Close();
                    foreach (DataRow item in dataTable.Rows)
                    {
                        Equipo equipo = new Equipo();
                        equipo.id = Convert.ToInt32(item.ItemArray[0].ToString());
                        equipo.nombre = item.ItemArray[1].ToString();
                        listado.Add(equipo);
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return listado;
        }
    }
}
