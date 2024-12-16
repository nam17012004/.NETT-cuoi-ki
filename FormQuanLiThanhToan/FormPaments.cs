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
    public partial class FormPaments : Form
    {
        public FormPaments()
        {
            InitializeComponent();
            fetchData();
            AddSearchListener();
        }

        //KẾT NỐI DATABASE/////////////////////////////////////////////////////////////////////////
        private void fetchData()
        {
            string connectionString = "Server=MSI\\SQLEXPRESS; Database=QLCHXD; Integrated Security=True; TrustServerCertificate=True;";
            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM ThanhToan";
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
                                if (i < 8)
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

            public void InsertBikes(TextBox textBox1, TextBox textBox2, TextBox textBox6, TextBox textBox4, TextBox textBox5, TextBox textBox3, TextBox textBox8 , TextBox textBox9 ,DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "INSERT INTO ThanhToan (MaThanhToan, MaXe, MaKH, NgayThanhToan, PhuongThucThanhToan,HinhThuc, SoLuong , ThanhTien ) VALUES (@MaThanhToan, @MaXe, @MaKH, @NgayThanhToan, @PhuongThucThanhToan,@HinhThuc, @SoLuong, @ThanhTien)";
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@MaThanhToan", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaXe", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaKH", textBox6.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgayThanhToan", DateTime.Parse(textBox4.Text));
                        cmd.Parameters.AddWithValue("@PhuongThucThanhToan", textBox5.Text.Trim());
                        cmd.Parameters.AddWithValue("@HinhThuc", textBox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@SoLuong", int.Parse(textBox8.Text));
                        cmd.Parameters.AddWithValue("@ThanhTien", decimal.Parse(textBox9.Text));


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

            public void UpdateBikes(TextBox textBox1, TextBox textBox2, TextBox textBox6, TextBox textBox4, TextBox textBox5, TextBox textBox3, TextBox textBox8, TextBox textBox9 , DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "UPDATE ThanhToan SET MaXe = @MaXe, MaKH = @MaKH, NgayThanhToan = @NgayThanhToan , PhuongThucThanhToan = @PhuongThucThanhToan , HinhThuc = @HinhThuc,  SoLuong = @SoLuong,  ThanhTien = @ThanhTien WHERE MaThanhToan = @MaThanhToan";
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        
                        cmd.Parameters.AddWithValue("@MaXe", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@MaKH", textBox6.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgayThanhToan", DateTime.Parse(textBox4.Text));
                        cmd.Parameters.AddWithValue("@PhuongThucThanhToan", textBox5.Text.Trim());
                        cmd.Parameters.AddWithValue("@HinhThuc", textBox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@SoLuong", int.Parse(textBox8.Text));
                        cmd.Parameters.AddWithValue("@ThanhTien", decimal.Parse(textBox9.Text));

                        cmd.Parameters.AddWithValue("@MaThanhToan", textBox1.Text.Trim());

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

            public void UpdateOrInsert(TextBox textBox1, TextBox textBox2, TextBox textBox6, TextBox textBox4, TextBox textBox5, TextBox textBox3, TextBox textBox8, TextBox textBox9 , DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string checkSql = "SELECT COUNT(*) FROM ThanhToan WHERE MaThanhToan = @MaThanhToan";
                        SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                        checkCmd.Parameters.AddWithValue("@MaThanhToan", textBox1.Text);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            UpdateBikes(textBox1, textBox2, textBox6, textBox4, textBox5, textBox3, textBox8 , textBox9 , Data_Bikes);
                        }
                        else
                        {
                            InsertBikes(textBox1, textBox2, textBox6, textBox4, textBox5, textBox3, textBox8 , textBox9 ,  Data_Bikes);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi kiểm tra dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ClearText(textBox1, textBox2, textBox6, textBox4, textBox5, textBox3, textBox8, textBox9);

            }

            private void FetchDataInforBikes(DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "SELECT * FROM ThanhToan ";
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

            private void ClearText(TextBox textBox1, TextBox textBox2, TextBox textBox6, TextBox textBox4, TextBox textBox5, TextBox textBox3, TextBox textBox8 , TextBox textBox9 )
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox6.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox3.Clear();
                textBox8.Clear();
                textBox9.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng BikeManager
            BikeManager bikeManager = new BikeManager();

            // Gọi hàm UpdateOrInsert với các tham số cần thiết
            bikeManager.UpdateOrInsert(textBox1, textBox2, textBox6, textBox4, textBox5, textBox3, textBox8 , textBox9,  Data_Bikes);
        }

        //XÓA/////////////////////////////////////////////////////////////////////////////////////////
        public void DeleteButtonInforBikes(int row, DataGridView dataBikes)
        {
            string connectionString = @"Server=MSI\SQLEXPRESS;Database=QLCHXD;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "DELETE FROM ThanhToan WHERE MaThanhToan = @MaThanhToan";

            try
            {
                // Kiểm tra dòng được chọn
                if (row < 0 || row >= dataBikes.Rows.Count - 1) // -1 để bỏ qua dòng trống cuối cùng (nếu có)
                {
                    MessageBox.Show("Hãy chọn một dòng hợp lệ để xóa.");
                    return;
                }

                // Lấy giá trị MaXe từ dòng được chọn
                string MaXe = dataBikes.Rows[row].Cells["MaThanhToan"].Value.ToString(); // Sử dụng tên cột nếu cần


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaThanhToan", MaXe);

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

                textBox1.Text = selectedRow.Cells["MaThanhToan"].Value?.ToString() ?? string.Empty;
                textBox2.Text = selectedRow.Cells["MaXe"].Value?.ToString() ?? string.Empty;
                textBox6.Text = selectedRow.Cells["MaKH"].Value?.ToString() ?? string.Empty;
                textBox4.Text = selectedRow.Cells["NgayThanhToan"].Value?.ToString() ?? string.Empty;
                textBox5.Text = selectedRow.Cells["PhuongThucThanhToan"].Value?.ToString() ?? string.Empty;
                textBox3.Text = selectedRow.Cells["HinhThuc"].Value?.ToString() ?? string.Empty;
                textBox8.Text = selectedRow.Cells["SoLuong"].Value?.ToString() ?? string.Empty;
                textBox9.Text = selectedRow.Cells["ThanhTien"].Value?.ToString() ?? string.Empty;
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

        //end//////////////////////////////////////////////////////////////////////////////////////////////


        // TÌM KIẾM //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void GetSanPham()
        {
            string connectionString = "Server=MSI\\SQLEXPRESS; Database=QLCHXD; Integrated Security=True; TrustServerCertificate=True;";

            string sql = "SELECT MaThanhToan , MaXe, MaKH, NgayThanhToan, PhuongThucThanhToan, HinhThuc, SoLuong , ThanhTien  FROM ThanhToan";

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

            string sql = "SELECT MaThanhToan , MaXe, MaKH, NgayThanhToan, PhuongThucThanhToan, HinhThuc, SoLuong , ThanhTien FROM ThanhToan WHERE ";

            switch (selectedCriteria)
            {
                case "Tất cả":
                    sql += "MaThanhToan LIKE @SearchValue OR MaXe LIKE @SearchValue OR MaKH LIKE @SearchValue OR NgayThanhToan LIKE @SearchValue OR PhuongThucThanhToan LIKE @SearchValue OR HinhThuc LIKE @SearchValue OR SoLuong LIKE @SearchValue OR ThanhTien LIKE @SearchValue";
                    break;
                case "Mã thanh toán":
                    sql += "MaThanhToan LIKE @SearchValue";
                    break;
                case "Mã xe":
                    sql += "MaXe LIKE @SearchValue";
                    break;
                case "Mã khách hàng":
                    sql += "MaKH LIKE @SearchValue";
                    break;
                case "Ngày TT":
                    sql += "NgayThanhToan LIKE @SearchValue";
                    break;
                case "Phương thức TT":
                    sql += "PhuongThucThanhToan LIKE @SearchValue";
                    break;
                case "Hình thức":
                    sql += "HinhThuc LIKE @SearchValue";
                    break;
                case "Số lượng":
                    sql += "SoLuong LIKE @SearchValue";
                    break;
                case "Thành tiền":
                    sql += "ThanhTien LIKE @SearchValue";
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
    }
}

