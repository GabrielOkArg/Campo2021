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
        
            string sqlstring = "Data Source=EDUARDOSILVA1\\SQLEXPRESS01;Initial Catalog=CTH_INT;Integrated Security=True";
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
                if (dataTable.Rows.Count > 0)
                {
                    _element.apellido = dataTable.Rows[0].ItemArray[2].ToString();
                    _element.nombre = dataTable.Rows[0].ItemArray[1].ToString();
                    _element.id = Convert.ToInt32(dataTable.Rows[0].ItemArray[0]);
                    _element.pass = dataTable.Rows[0].ItemArray[4].ToString();
                }
                else
                {
                    _element = null;
                }
            }
            return _element;
            
        }

        private string GetConnectionString()
        {
            var cs = new SqlConnectionStringBuilder();
            cs.IntegratedSecurity = true;
            cs.DataSource = "EDUARDOSILVA1\\SQLEXPRESS01";
            cs.InitialCatalog = "CTH_INT";
            return cs.ConnectionString;
        }

        public List<UsuarioView> GetAllS()
        {
            var cnn = new SqlConnection(GetConnectionString());
            cnn.Open();
            var cmd = new SqlCommand();
            cmd.Connection = cnn;

            var sql = $@"select * from usuarios;";

            cmd.CommandText = sql;

            var reader = cmd.ExecuteReader();

            var lista = new List<UsuarioView>();

            while (reader.Read())
            {
                UsuarioView c = new UsuarioView();
                c.username = reader.GetString(reader.GetOrdinal("username"));
                c.Id = reader.GetInt32(reader.GetOrdinal("id"));
                lista.Add(c);
            }
            reader.Close();
            cnn.Close();

            return lista;
        }



        public void GuardarPermisos(UsuarioView u)
        {

            try
            {
                var cnn = new SqlConnection(GetConnectionString());
                cnn.Open();

                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $@"delete from usuarios_permisos where id_usuario=@id;";
                cmd.Parameters.Add(new SqlParameter("id", u.Id));
                cmd.ExecuteNonQuery();

                foreach (var item in u.Permisos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    cmd.CommandText = $@"insert into usuarios_permisos (id_usuario,id_permiso) values (@id_usuario,@id_permiso) "; ;
                    cmd.Parameters.Add(new SqlParameter("id_usuario", u.Id));
                    cmd.Parameters.Add(new SqlParameter("id_permiso", item.Id));

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }



        public void GuardarPermisos(Usuario u)
        {

            try
            {
                var cnn = new SqlConnection(GetConnectionString());
                cnn.Open();

                var cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $@"delete from usuarios_permisos where id_usuario=@id;";
                cmd.Parameters.Add(new SqlParameter("id", u.id));
                cmd.ExecuteNonQuery();

                foreach (var item in u.Permisos)
                {
                    cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    cmd.CommandText = $@"insert into usuarios_permisos (id_usuario,id_permiso) values (@id_usuario,@id_permiso) "; ;
                    cmd.Parameters.Add(new SqlParameter("id_usuario", u.id));
                    cmd.Parameters.Add(new SqlParameter("id_permiso", item.Id));

                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
