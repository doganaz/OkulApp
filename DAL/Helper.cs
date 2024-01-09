using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAL
{
    public class Helper:IDisposable
    {
        SqlConnection cn;
        SqlCommand cmd;
        string cstr = ConfigurationManager.ConnectionStrings["cstr"].ConnectionString;
        private bool disposedValue;

        public int ExecuteNonQuery(string cmdtext, SqlParameter[] p=null)
        {
            using (cn=new SqlConnection(cstr))
            {
                using (cmd =new SqlCommand(cmdtext,cn))
                {
                    if (p != null)
                    {
                        cmd.Parameters.AddRange(p);
                    }
                    cn.Open();
                    return cmd.ExecuteNonQuery();
                    
                }
            }
        }
        public SqlDataReader ExecuteReader(string cmdtext, SqlParameter[] p = null )
        {
            try
            {
                cn = new SqlConnection(cstr);
                cmd = new SqlCommand(cmdtext, cn);
                if (p != null)
                {
                    cmd.Parameters.AddRange(p);
                }
                cn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (SqlException ex)
            {
                throw new Exception("Veritabanı hatası", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Bir hata oluştu", ex);
            }


        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    cmd.Dispose();
                    cn.Dispose();
                }
                disposedValue = true;
            }
        }
        ~Helper()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
