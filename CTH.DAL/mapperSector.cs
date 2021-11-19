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
    public class mapperSector : IConectBD<Sector>
    {
        public List<Sector> GetAll(Sector _element)
        {
            List<Sector> listado = new List<Sector>();
            try
            {
                string sqlstring = "Data Source=EDUARDOSILVA1\\SQLEXPRESS01;Initial Catalog=CTH_INT;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(sqlstring))

                {
                    SqlCommand cdm = new SqlCommand("GetAllSectores", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "GetAllSectores"; //nombre del store procedure
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    da.Fill(dataTable);
                    conn.Close();
                    foreach (DataRow item in dataTable.Rows)
                    {
                        Sector sector = new Sector();
                        sector.id = Convert.ToInt32(item.ItemArray[0].ToString());
                        sector.nombre = item.ItemArray[1].ToString();
                    }
                }
                return listado;
            }
            catch (Exception ex)
            {

                throw;
            }
        }



        public List<Sector> GetAll()
        {
            List<Sector> listado = new List<Sector>();
            try
            {
                string sqlstring = "Data Source=EDUARDOSILVA1\\SQLEXPRESS01;Initial Catalog=CTH_INT;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(sqlstring))

                {
                    SqlCommand cdm = new SqlCommand("GetAllSectores", conn);
                    cdm.CommandType = CommandType.StoredProcedure;
                    cdm.CommandText = "GetAllSectores"; //nombre del store procedure
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cdm);
                    conn.Open();
                    da.Fill(dataTable);
                    conn.Close();
                    foreach (DataRow item in dataTable.Rows)
                    {
                        Sector sector = new Sector();
                        sector.id = Convert.ToInt32(item.ItemArray[0].ToString());
                        sector.nombre = item.ItemArray[1].ToString();
                        listado.Add(sector);
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return listado;
        }

        public Sector GetElement(Sector _element)
        {
            throw new NotImplementedException();
        }
    }
}
