using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCKH_QLHH
{
    public partial class Them : Form
    {
        public Them()
        {
            InitializeComponent();

        }
        private void Show_DataTable()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.cnnStr))
            {
                const string sql = "select * from QLHH_main";

                using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                {
                    try
                    {
                        connection.Open();
                        using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(dataReader);

                            this.dataGridView1.DataSource = dt;

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
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            Sua f2 = new Sua();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            Show_DataTable();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            Xoa f2 = new Xoa();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var hhBUS = new dao.HangHoaBUS();
            hhBUS.ThemHangHoa(txt_id.Text, txt_product.Text, txt_ex.Text, txt_price.Text);
            txt_id.Clear();
            txt_product.Clear();
            txt_ex.Clear();
            txt_price.Clear();
            Show_DataTable();
        }

       
    }
}
