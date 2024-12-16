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

namespace Project.View
{
    public partial class FormEmployees : Form
    {
        public FormEmployees()
        {
            InitializeComponent();
            fetchData();
        }

        //Kết nối DB
        private void fetchData()
        {
            string connectionString = "Server=MSI\\SQLEXPRESS; Database=QLCHXD; Integrated Security=True; TrustServerCertificate=True;";
            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string sql = "SELECT * FROM NhanVien";
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

        //Gắn kết nối DB
        private void FormEmployees_Load(object sender, EventArgs e)
        {
            fetchData();
            AddSearchListener();
        }


        //end///////////////////////////////////////////////////////////////////////////////////////////

        //HÀM CẬP NHẬT ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class BikeManager
        {
            private string connectionString = "Server=MSI\\SQLEXPRESS;Database=QLCHXD;Trusted_Connection=True;TrustServerCertificate=True;";

            public void InsertBikes(TextBox textBox1, TextBox textBox2, TextBox textBox6, TextBox textBox4, TextBox textBox5, DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "INSERT INTO NhanVien (MaNV, HoTen, ChucVu, SoDienThoai, Email) VALUES (@MaNV, @HoTen, @ChucVu, @SoDienThoai, @Email)";
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@MaNV", textBox1.Text);
                        cmd.Parameters.AddWithValue("@HoTen", textBox2.Text);
                        cmd.Parameters.AddWithValue("@ChucVu", textBox6.Text);
                        cmd.Parameters.AddWithValue("@SoDienThoai", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Email", textBox5.Text);


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

            public void UpdateBikes(TextBox textBox1 , TextBox textBox2 , TextBox textBox6, TextBox textBox4 , TextBox textBox5 , DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "UPDATE NhanVien SET HoTen = @HoTen, ChucVu = @ChucVu, SoDienThoai = @SoDienThoai, Email = @Email WHERE MaNV = @MaNV";
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@HoTen", textBox2.Text);
                        cmd.Parameters.AddWithValue("@ChucVu", textBox6.Text);
                        cmd.Parameters.AddWithValue("@SoDienThoai", textBox4.Text);
                        cmd.Parameters.AddWithValue("@Email", textBox5.Text);
                      
                        cmd.Parameters.AddWithValue("@MaNV", textBox1.Text);

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

            public void UpdateOrInsert(TextBox textBox1, TextBox textBox2 , TextBox textBox6 , TextBox textBox4 , TextBox textBox5, DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string checkSql = "SELECT COUNT(*) FROM NhanVien WHERE MaNV = @MaNV";
                        SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                        checkCmd.Parameters.AddWithValue("@MaNV", textBox1.Text);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            UpdateBikes(textBox1, textBox2, textBox6, textBox4 , textBox5 , Data_Bikes);
                        }
                        else
                        {
                            InsertBikes(textBox1, textBox2, textBox6, textBox4, textBox5, Data_Bikes);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi kiểm tra dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ClearText(textBox1, textBox2, textBox6, textBox4, textBox5);
            }

            private void FetchDataInforBikes(DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "SELECT * FROM NhanVien";
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

            private void ClearText(TextBox textBox1, TextBox textBox2, TextBox textBox6, TextBox textBox4, TextBox textBox5)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox6.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
        }

        //end////////////////////////////////////////////////////////////////////////////////////////////

        public void DeleteButtonInforBikes(int row, DataGridView dataBikes)
        {
            string connectionString = @"Server=MSI\SQLEXPRESS;Database=QLCHXD;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";

            try
            {
                // Kiểm tra dòng được chọn
                if (row < 0 || row >= dataBikes.Rows.Count - 1) // -1 để bỏ qua dòng trống cuối cùng (nếu có)
                {
                    MessageBox.Show("Hãy chọn một dòng hợp lệ để xóa.");
                    return;
                }

                // Lấy giá trị MaXe từ dòng được chọn
                string MaXe = dataBikes.Rows[row].Cells["MaNV"].Value.ToString(); // Sử dụng tên cột nếu cần


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", MaXe);

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





        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            HandleSearch();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //CHỨC NĂNG TRONG BẢNG//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void ClearText(TextBox textBox1, TextBox textBox2, TextBox textBox6, TextBox textBox4, TextBox textBox5)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox6.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        // TÌM KIẾM //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void GetSanPham()
        {
            string connectionString = "Server=MSI\\SQLEXPRESS; Database=QLCHXD; Integrated Security=True; TrustServerCertificate=True;";

            string sql = "SELECT MaNV, HoTen, ChucVu, SoDienThoai, Email FROM NhanVien";

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

            string sql = "SELECT MaNV, HoTen , ChucVu , SoDienThoai, Email FROM NhanVien WHERE ";

            switch (selectedCriteria)
            {
                case "Tất cả":
                    sql += "MaNV LIKE @SearchValue OR HoTen LIKE @SearchValue OR ChucVu LIKE @SearchValue OR SoDienThoai LIKE @SearchValue OR Email LIKE @SearchValue";
                    break;
                case "Mã nhân viên":
                    sql += "MaNV LIKE @SearchValue";
                    break;
                case "Họ tên":
                    sql += "HoTen LIKE @SearchValue";
                    break;
                case "Chức vụ":
                    sql += "ChucVu LIKE @SearchValue";
                    break;
                case "Số điện thoại":
                    sql += "SoDienThoai LIKE @SearchValue";
                    break;
                case "Email":
                    sql += "Email LIKE @SearchValue";
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
        //end////////////////////////////////////////////////////////////////////////////////////////////////////

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity_Trans_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

                textBox1.Text = selectedRow.Cells["MaNV"].Value?.ToString() ?? string.Empty;
                textBox2.Text = selectedRow.Cells["HoTen"].Value?.ToString() ?? string.Empty;
                textBox6.Text = selectedRow.Cells["ChucVu"].Value?.ToString() ?? string.Empty;
                textBox4.Text = selectedRow.Cells["SoDienThoai"].Value?.ToString() ?? string.Empty;
                textBox5.Text = selectedRow.Cells["Email"].Value?.ToString() ?? string.Empty;
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Tạo đối tượng BikeManager
            BikeManager bikeManager = new BikeManager();

            // Gọi hàm UpdateOrInsert với các tham số cần thiết
            bikeManager.UpdateOrInsert(textBox1, textBox2, textBox6, textBox4, textBox5, Data_Bikes);
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            HandleSearch();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            HandleSearch();
        }
    }

}
