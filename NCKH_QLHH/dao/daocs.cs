using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH_QLHH.dao
{
    public class daocs
    {
        public dataprovider.DBConnection conn;
        
        public daocs()
        {
            conn = new dataprovider.DBConnection();
        }
        public void ThemHangHoa(String id, String Product, String Price, String Ex)
        {
            const string sql = "insert into QLHH_main(id, Product, Price, Ex) values(@id, @Product, @Price, @Ex)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(id);
            sqlParameters[1] = new SqlParameter("@Product", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(Product);
            sqlParameters[2] = new SqlParameter("@Price", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToString(Price);
            sqlParameters[3] = new SqlParameter("@Ex", SqlDbType.Date);
            sqlParameters[3].Value = Convert.ToString(Ex);
            conn.executeInsertQuery(sql, sqlParameters);
        }
        public void SuaHangHoa(String id, String Product, String Price, String Ex)
        {
            const string sql = "update QLHH_main set id = @id, @Product, @Price, @Ex where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(id);
            sqlParameters[1] = new SqlParameter("@Product", SqlDbType.NVarChar);
            sqlParameters[1].Value = Convert.ToString(Product);
            sqlParameters[2] = new SqlParameter("@Price", SqlDbType.Int);
            sqlParameters[2].Value = Convert.ToString(Price);
            sqlParameters[3] = new SqlParameter("@Ex", SqlDbType.Date);
            sqlParameters[3].Value = Convert.ToString(Ex);
            conn.executeInsertQuery(sql, sqlParameters);
        }
        public void XoaHangHoa(String id)
        {
            const string sql = "delete from QLHH_main where id = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@id", SqlDbType.Int);
            sqlParameters[0].Value = Convert.ToString(id);
            conn.executeInsertQuery(sql, sqlParameters);
        }
        public DataTable CheckID(String id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                string sql = "select * from QLHH_main where id = ";
                sql = sql + id;
                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            dt.Load(dataReader);
                            dataReader.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return dt;
        }
    }
    public class HangHoaBUS
    {
        private daocs hhDAO;
        public HangHoaBUS()
        {
            hhDAO = new daocs();
        }
        public void ThemHangHoa(String id, String Product, String Price, String Ex)
        {
            hhDAO.ThemHangHoa(id, Product, Price, Ex);
        }

        public void SuaHangHoa(String id, String Product, String Price, String Ex)
        {
            hhDAO.SuaHangHoa(id, Product, Price, Ex);
        }

        public void XoaHangHoa(String id)
        {
            hhDAO.XoaHangHoa(id);
        }

        public DataTable CheckIDSinhVien(String id)
        {
            return hhDAO.CheckID(id);
        }
    }
}
