using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace Project.View
{
    public partial class FormRentBikes : Form
    {
        public FormRentBikes()
        {
            InitializeComponent();
            fetchData();
            AddSearchListener();

        }

        private void fetchData()
        {
            string connectionString = "Server=MSI\\SQLEXPRESS; Database=QLCHXD; Integrated Security=True; TrustServerCertificate=True;";
            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM ThueXe";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            Data_Bikes.AutoGenerateColumns = false; //Không tự động tạo cột
                            Data_Bikes.DataSource = dt;

                            //Chỉnh kích thước
                            for (int i = 0; i < Data_Bikes.Columns.Count; i++)
                            {
                                if (i < 6)
                                {
                                    Data_Bikes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                }
                                else
                                {
                                    Data_Bikes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                                    Data_Bikes.Columns[i].Width = 20;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        //HÀM CẬP NHẬT ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class BikeManager
        {
            private string connectionString = "Server=MSI\\SQLEXPRESS;Database=QLCHXD;Trusted_Connection=True;TrustServerCertificate=True;";

            public void InsertBikes(TextBox textBox1, TextBox textBox2, TextBox textBox6, TextBox textBox4, TextBox textBox5, TextBox textBox3 , DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "INSERT INTO ThueXe (MaPhieu, MaKH, MaXe, NgayThue, GiaThue,TGThue) VALUES (@MaPhieu, @MaKH, @MaXe, @NgayThue, @GiaThue,@TGThue)";
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@MaPhieu", textBox1.Text);
                        cmd.Parameters.AddWithValue("@MaKH", textBox2.Text);
                        cmd.Parameters.AddWithValue("@MaXe", textBox6.Text);
                        cmd.Parameters.AddWithValue("@NgayThue", DateTime.Parse(textBox4.Text));
                        cmd.Parameters.AddWithValue("@GiaThue", decimal.Parse(textBox5.Text));
                        cmd.Parameters.AddWithValue("@TGThue", textBox3.Text.PadRight(10));


                        cmd.ExecuteNonQuery();
                        FetchDataInforBikes(Data_Bikes);
                        MessageBox.Show("Thêm thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thêm được thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void UpdateBikes(TextBox textBox1, TextBox textBox2, TextBox textBox6, TextBox textBox4, TextBox textBox5, TextBox textBox3, DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "UPDATE ThueXe SET MaKH = @MaKH, MaXe = @MaXe, NgayThue = @NgayThue, GiaThue = @GiaThue, TGThue = @TGThue WHERE MaPhieu = @MaPhieu";
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@MaKH", textBox2.Text);
                        cmd.Parameters.AddWithValue("@MaXe", textBox6.Text);
                        cmd.Parameters.AddWithValue("@NgayThue", DateTime.Parse(textBox4.Text));
                        cmd.Parameters.AddWithValue("@GiaThue", decimal.Parse(textBox5.Text));
                        cmd.Parameters.AddWithValue("@TGThue", textBox3.Text.PadRight(10));

                        cmd.Parameters.AddWithValue("@MaPhieu", textBox1.Text);

                        cmd.ExecuteNonQuery();
                        FetchDataInforBikes(Data_Bikes);
                        MessageBox.Show("Cập nhật thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thông tin không thành công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            public void UpdateOrInsert(TextBox textBox1, TextBox textBox2, TextBox textBox6, TextBox textBox4, TextBox textBox5, TextBox textBox3, DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string checkSql = "SELECT COUNT(*) FROM ThueXe WHERE MaPhieu = @MaPhieu";
                        SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                        checkCmd.Parameters.AddWithValue("@MaPhieu", textBox1.Text);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            UpdateBikes(textBox1, textBox2, textBox6, textBox4, textBox5, textBox3, Data_Bikes);
                        }
                        else
                        {
                            InsertBikes(textBox1, textBox2, textBox6, textBox4, textBox5, textBox3, Data_Bikes);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi kiểm tra dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ClearText(textBox1, textBox2, textBox6, textBox4, textBox5, textBox3);
            }

            private void FetchDataInforBikes(DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "SELECT * FROM ThueXe ";
                        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        Data_Bikes.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void ClearText(TextBox textBox1, TextBox textBox2, TextBox textBox6, TextBox textBox4, TextBox textBox5, TextBox textBox3)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox6.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox3.Clear();
            }
        }

        //end////////////////////////////////////////////////////////////////////////////////////////////



        //CHỨC NĂNG TRONG BẢNG/////////////////////////////////////////////////////////////////////////

        private void Data_Bikes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một hàng hợp lệ!");
                return;
            }

            // Lấy cột được click
            DataGridViewColumn clickedColumn = Data_Bikes.Columns[e.ColumnIndex];

            // Kiểm tra chức năng theo cột
            if (clickedColumn.Name == "Add_btn") // Tên cột thêm
            {
                // Gọi chức năng thêm
                DataGridViewRow selectedRow = Data_Bikes.Rows[e.RowIndex];

                textBox1.Text = selectedRow.Cells["MaPhieu"].Value?.ToString() ?? string.Empty;
                textBox2.Text = selectedRow.Cells["MaKH"].Value?.ToString() ?? string.Empty;
                textBox6.Text = selectedRow.Cells["MaXe"].Value?.ToString() ?? string.Empty;
                textBox4.Text = selectedRow.Cells["NgayThue"].Value?.ToString() ?? string.Empty;
                textBox5.Text = selectedRow.Cells["GiaThue"].Value?.ToString() ?? string.Empty;
                textBox3.Text = selectedRow.Cells["TGThue"].Value?.ToString() ?? string.Empty;
            }

            else if (clickedColumn.Name == "Delete_btn") // Tên cột xóa
            {
                // Gọi chức năng xóa
                DeleteButtonInforBikes(e.RowIndex, Data_Bikes);
            }
            else
            {
                // Nếu click vào cột khác, thực hiện hành động mặc định (hiển thị dữ liệu trong TextBox)
                try
                {


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng BikeManager
            BikeManager bikeManager = new BikeManager();

            // Gọi hàm UpdateOrInsert với các tham số cần thiết
            bikeManager.UpdateOrInsert(textBox1, textBox2, textBox6, textBox4, textBox5, textBox3, Data_Bikes);
        }


        //XÓA/////////////////////////////////////////////////////////////////////////////////////////
        public void DeleteButtonInforBikes(int row, DataGridView dataBikes)
        {
            string connectionString = @"Server=MSI\SQLEXPRESS;Database=QLCHXD;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "DELETE FROM ThueXe WHERE MaPhieu = @MaPhieu";

            try
            {
                // Kiểm tra dòng được chọn
                if (row < 0 || row >= dataBikes.Rows.Count - 1) // -1 để bỏ qua dòng trống cuối cùng (nếu có)
                {
                    MessageBox.Show("Hãy chọn một dòng hợp lệ để xóa.");
                    return;
                }

                // Lấy giá trị MaXe từ dòng được chọn
                string MaXe = dataBikes.Rows[row].Cells["MaPhieu"].Value.ToString(); // Sử dụng tên cột nếu cần


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaPhieu", MaXe);

                        int affectedRows = cmd.ExecuteNonQuery();
                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Xóa thông tin thành công!");
                            dataBikes.Rows.RemoveAt(row); // Xóa dòng khỏi DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy dữ liệu để xóa.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công: " + ex.Message);
            }
        }

        //end//////////////////////////////////////////////////////////////////////////////////////////////


        // TÌM KIẾM //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void GetSanPham()
        {
            string connectionString = "Server=MSI\\SQLEXPRESS; Database=QLCHXD; Integrated Security=True; TrustServerCertificate=True;";

            string sql = "SELECT MaPhieu, MaKH, MaXe, NgayThue, GiaThue, TGThue FROM ThueXe";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    // Tạo DataTable để lưu dữ liệu từ SQL
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Gán dữ liệu cho DataGridView
                    Data_Bikes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
            }
        }

        private void AddSearchListener()
        {
            textBox7.TextChanged += (s, e) => HandleSearch();
        }

        private void HandleSearch()
        {
            string keyword = textBox7.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                // Nếu tìm kiếm trống, hiển thị toàn bộ sản phẩm
                GetSanPham();
            }
            else
            {
                SearchDataByBrand();
            }
        }

        private void SearchDataByBrand()
        {
            string connectionString = "Server=MSI\\SQLEXPRESS; Database=QLCHXD ; Integrated Security=True; TrustServerCertificate=True;";

            string selectedCriteria = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : string.Empty;
            string searchValue = textBox7.Text;

            string sql = "SELECT MaPhieu, MaKH , MaXe , NgayThue, GiaThue, TGThue FROM ThueXe WHERE ";

            switch (selectedCriteria)
            {
                case "Tất cả":
                    sql += "MaPhieu LIKE @SearchValue OR MaKH LIKE @SearchValue OR MaXe LIKE @SearchValue OR NgayThue LIKE @SearchValue OR GiaThue LIKE @SearchValue OR TGThue LIKE @SearchValue";
                    break;
                case "Mã phiếu thuê":
                    sql += "MaPhieu LIKE @SearchValue";
                    break;
                case "Mã khách hàng":
                    sql += "MaKH LIKE @SearchValue";
                    break;
                case "Mã xe":
                    sql += "MaXe LIKE @SearchValue";
                    break;
                case "Giá thuê":
                    sql += "GiaThue LIKE @SearchValue";
                    break;
                case "Thời gian thuê":
                    sql += "TGThue LIKE @SearchValue";
                    break;
                default:
                    sql += "NgayThue LIKE @SearchValue";
                    break;

            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);

                    // Sử dụng parameter để tránh lỗi SQL Injection
                    cmd.Parameters.AddWithValue("@SearchValue", "%" + searchValue + "%");

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Tạo DataTable để lưu dữ liệu từ SQL
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Gán dữ liệu cho DataGridView
                    Data_Bikes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleSearch();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            HandleSearch();
        }
        //end////////////////////////////////////////////////////////////////////////////////////////////////////


    }
}
