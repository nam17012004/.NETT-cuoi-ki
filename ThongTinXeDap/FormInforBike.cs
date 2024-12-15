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

namespace Project.View
{
    public partial class FormInforBike : Form
    {
        public FormInforBike()
        {
            InitializeComponent();
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

                    string sql = "SELECT * FROM ThongTinXeDap";
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
        private void FormInforBike_Load(object sender, EventArgs e)
        {
            fetchData();
            AddSearchListener();
        }


        //end///////////////////////////////////////////////////////////////////////////////////////////

        //HÀM CẬP NHẬT ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public class BikeManager
        {
            private string connectionString = "Server=MSI\\SQLEXPRESS;Database=QLCHXD;Trusted_Connection=True;TrustServerCertificate=True;";

            public void InsertBikes(TextBox ID_Trans, TextBox Name_Trans, TextBox Brand_Trans, TextBox Style_Trans, TextBox Price_Trans, TextBox quantity_Trans, DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "INSERT INTO ThongTinXeDap (MaXe, TenXe, HangXe, LoaiXe, GiaBan, SoLuongTonKho) VALUES (@MaXe, @TenXe, @HangXe, @LoaiXe, @GiaBan, @SoLuongTonKho)";
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@MaXe", ID_Trans.Text);
                        cmd.Parameters.AddWithValue("@TenXe", Name_Trans.Text);
                        cmd.Parameters.AddWithValue("@HangXe", Brand_Trans.Text);
                        cmd.Parameters.AddWithValue("@LoaiXe", Style_Trans.Text);
                        cmd.Parameters.AddWithValue("@GiaBan", float.Parse(Price_Trans.Text));
                        cmd.Parameters.AddWithValue("@SoLuongTonKho", int.Parse(quantity_Trans.Text));

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

            public void UpdateBikes(TextBox ID_Trans, TextBox Name_Trans, TextBox Brand_Trans, TextBox Style_Trans, TextBox Price_Trans, TextBox quantity_Trans, DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "UPDATE ThongTinXeDap SET TenXe = @TenXe, HangXe = @HangXe, LoaiXe = @LoaiXe, GiaBan = @GiaBan, SoLuongTonKho = @SoLuongTonKho WHERE MaXe = @MaXe";
                        SqlCommand cmd = new SqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@TenXe", Name_Trans.Text);
                        cmd.Parameters.AddWithValue("@HangXe", Brand_Trans.Text);
                        cmd.Parameters.AddWithValue("@LoaiXe", Style_Trans.Text);
                        cmd.Parameters.AddWithValue("@GiaBan", float.Parse(Price_Trans.Text));
                        cmd.Parameters.AddWithValue("@SoLuongTonKho", int.Parse(quantity_Trans.Text));
                        cmd.Parameters.AddWithValue("@MaXe", ID_Trans.Text);

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

            public void UpdateOrInsert(TextBox ID_Trans, TextBox Name_Trans, TextBox Brand_Trans, TextBox Style_Trans, TextBox Price_Trans, TextBox quantity_Trans, DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string checkSql = "SELECT COUNT(*) FROM ThongTinXeDap WHERE MaXe = @MaXe";
                        SqlCommand checkCmd = new SqlCommand(checkSql, conn);
                        checkCmd.Parameters.AddWithValue("@MaXe", ID_Trans.Text);

                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            UpdateBikes(ID_Trans, Name_Trans, Brand_Trans, Style_Trans, Price_Trans, quantity_Trans, Data_Bikes);
                        }
                        else
                        {
                            InsertBikes(ID_Trans, Name_Trans, Brand_Trans, Style_Trans, Price_Trans, quantity_Trans, Data_Bikes);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi kiểm tra dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ClearText(ID_Trans, Name_Trans, Brand_Trans, Style_Trans, Price_Trans, quantity_Trans);
            }

            private void FetchDataInforBikes(DataGridView Data_Bikes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string sql = "SELECT * FROM ThongTinXeDap";
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

            private void ClearText(TextBox ID_Trans, TextBox Name_Trans, TextBox Brand_Trans, TextBox Style_Trans, TextBox Price_Trans, TextBox quantity_Trans)
            {
                ID_Trans.Clear();
                Name_Trans.Clear();
                Brand_Trans.Clear();
                Style_Trans.Clear();
                Price_Trans.Clear();
                quantity_Trans.Clear();
            }
        }

        //end////////////////////////////////////////////////////////////////////////////////////////////

        public void DeleteButtonInforBikes(int row, DataGridView dataBikes)
        {
            string connectionString = @"Server=MSI\SQLEXPRESS;Database=QLCHXD;Trusted_Connection=True;TrustServerCertificate=True;";
            string query = "DELETE FROM ThongTinXeDap WHERE MaXe = @MaXe";

            try
            {
                // Kiểm tra dòng được chọn
                if (row < 0 || row >= dataBikes.Rows.Count - 1) // -1 để bỏ qua dòng trống cuối cùng (nếu có)
                {
                    MessageBox.Show("Hãy chọn một dòng hợp lệ để xóa.");
                    return;
                }

                // Lấy giá trị MaXe từ dòng được chọn
                string MaXe = dataBikes.Rows[row].Cells["MaXe"].Value.ToString(); // Sử dụng tên cột nếu cần


                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaXe", MaXe);

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

        private void Data_Bikes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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
                ClearText(ID_Trans, Name_Trans, Brand_Trans, Style_Trans, Price_Trans, quantity_Trans);
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
                    DataGridViewRow selectedRow = Data_Bikes.Rows[e.RowIndex];

                    ID_Trans.Text = selectedRow.Cells["MaXe"].Value?.ToString() ?? string.Empty;
                    Name_Trans.Text = selectedRow.Cells["TenXe"].Value?.ToString() ?? string.Empty;
                    Brand_Trans.Text = selectedRow.Cells["HangXe"].Value?.ToString() ?? string.Empty;
                    Style_Trans.Text = selectedRow.Cells["LoaiXe"].Value?.ToString() ?? string.Empty;
                    Price_Trans.Text = selectedRow.Cells["GiaBan"].Value?.ToString() ?? string.Empty;
                    quantity_Trans.Text = selectedRow.Cells["SoLuongTonKho"].Value?.ToString() ?? string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy dữ liệu: " + ex.Message);
                }
            }
        }

        public void ClearText(TextBox ID_Trans, TextBox Name_Trans, TextBox Brand_Trans, TextBox Style_Trans, TextBox Price_Trans, TextBox quantity_Trans)
        {
            ID_Trans.Clear();
            Name_Trans.Clear();
            Brand_Trans.Clear();
            Style_Trans.Clear();
            Price_Trans.Clear();
            quantity_Trans.Clear();
        }

        // TÌM KIẾM //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void GetSanPham()
        {
            string connectionString = "Server=MSI\\SQLEXPRESS; Database=QLCHXD; Integrated Security=True; TrustServerCertificate=True;";

            string sql = "SELECT MaXe, TenXe, HangXe, LoaiXe, GiaBan, SoLuongTonKho FROM ThongTinXeDap";

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

            string sql = "SELECT MaXe, TenXe, HangXe, LoaiXe, GiaBan, SoLuongTonKho FROM ThongTinXeDap WHERE ";

            switch (selectedCriteria)
            {
                case "Tất cả":
                    sql += "MaXe LIKE @SearchValue OR TenXe LIKE @SearchValue OR HangXe LIKE @SearchValue OR LoaiXe LIKE @SearchValue";
                    break;
                case "Mã xe":
                    sql += "MaXe LIKE @SearchValue";
                    break;
                case "Tên xe":
                    sql += "TenXe LIKE @SearchValue";
                    break;
                case "Hãng xe":
                    sql += "HangXe LIKE @SearchValue";
                    break;
                case "Loại xe":
                    sql += "LoaiXe LIKE @SearchValue";
                    break;
                case "Giá bán":
                    sql += "GiaBan LIKE @SearchValue";
                    break;
                default:
                    sql += "SoLuongTonKho LIKE @SearchValue";
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
            // Tạo đối tượng BikeManager
            BikeManager bikeManager = new BikeManager();

            // Gọi hàm UpdateOrInsert với các tham số cần thiết
            bikeManager.UpdateOrInsert(ID_Trans, Name_Trans, Brand_Trans, Style_Trans, Price_Trans, quantity_Trans, Data_Bikes);
        }
    }
}
