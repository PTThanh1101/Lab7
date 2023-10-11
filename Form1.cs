using Lab7.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InputGendercomboBox.Items.Add("Male");
            InputGendercomboBox.Items.Add("Female");
            InputGendercomboBox.Items.Add("Other");
            InputCitycomboBox.Items.Add("HCMC");
            InputCitycomboBox.Items.Add("HNC");
            InputCitycomboBox.Items.Add("DNC");
            Display();
        }
        public void Display()
        {
            using (StudentInformationEntities context = new StudentInformationEntities())
            {
                List<StudentInfo> studentList = context.StudentDetails
            .Select(x => new StudentInfo
            {
                    Id = x.Id,
                    Name = x.Name,
                    Age = x.Age,
                    City = x.City,
                    Gender = x.Gender
                }).ToList();
                ShowInfordataGridView.DataSource = studentList;
            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem tất cả thông tin đã được nhập đúng cách
            if (string.IsNullOrWhiteSpace(InputStudentNametextBox.Text) || InputCitycomboBox.SelectedIndex == -1 || InputGendercomboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter all informations.");
                return; // Không thực hiện thêm khi thiếu thông tin
            }

            // Kiểm tra xem Age có phải là số nguyên hay không
            if (!int.TryParse(InputAgetextBox.Text, out _))
            {
                MessageBox.Show("Please enter a valid number for age.");
                return; // Không thực hiện thêm khi Age không hợp lệ
            }
            // Lấy thông tin từ các ô nhập liệu và ComboBox
            string name = InputStudentNametextBox.Text;
            int? age = string.IsNullOrEmpty(InputAgetextBox.Text) ? (int?)null : int.Parse(InputAgetextBox.Text);
            string city = InputCitycomboBox.SelectedItem.ToString();
            string gender = InputGendercomboBox.SelectedItem.ToString();

            // Tạo một đối tượng StudentDetail để thêm vào cơ sở dữ liệu
            StudentDetail studentDetail = new StudentDetail
            {
                Name = name,
                Age = age,
                City = city,
                Gender = gender
            };

            // Gọi hàm SaveStudentDetails để thêm vào cơ sở dữ liệu
            bool result = SaveStudentDetails(studentDetail);

            if (result)
            {
                // Nếu thêm thành công, hiển thị lại dữ liệu trong DataGridView
                Display();
                // Xóa nội dung của các ô nhập liệu
                InputStudentNametextBox.Clear();
                InputAgetextBox.Clear();
                InputCitycomboBox.SelectedIndex = -1;
                InputGendercomboBox.SelectedIndex = -1;
            }
            else
            {
                // Xử lý khi có lỗi xảy ra trong quá trình thêm vào cơ sở dữ liệu
                MessageBox.Show("Không thể thêm học sinh. Vui lòng thử lại hoặc kiểm tra lỗi.");
            }
        }

            public bool SaveStudentDetails(StudentDetail studentDetail)
            {
            using (StudentInformationEntities context = new StudentInformationEntities())
            {
                try
                {
                    context.StudentDetails.Add(studentDetail);
                    context.SaveChanges();
                    return true; // Trả về true nếu thêm thành công
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi hoặc ghi log ở đây nếu cần
                    return false; // Trả về false nếu xảy ra lỗi
                }
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ RemovetextBox
            if (int.TryParse(RemovetextBox.Text, out int id))
            {
                
                // Tạo một đối tượng StudentDetail với Id cần xóa
                StudentDetail studentToRemove = new StudentDetail { Id = id };

                // Gọi hàm RemoveStudentDetails để xóa dữ liệu từ cơ sở dữ liệu
                bool result = RemoveStudentDetails(studentToRemove);

                if (result)
                {
                    // Nếu xóa thành công, hiển thị lại dữ liệu trong DataGridView
                    Display();
                    // Xóa nội dung của RemovetextBox
                    RemovetextBox.Clear();
                }
                
            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter valid ID.");
            }
        }

        public bool RemoveStudentDetails(StudentDetail studentDetail)
        {
            using (StudentInformationEntities _entity = new StudentInformationEntities())
            {
                var existingStudent = _entity.StudentDetails.FirstOrDefault(s => s.Id == studentDetail.Id);
                if (existingStudent != null)
                {
                    _entity.Entry(existingStudent).State = EntityState.Deleted;
                    _entity.SaveChanges(); // Lưu lại thay đổi sau khi xóa
                    Display();
                    return true; // Trả về true nếu xóa thành công
                }
                else
                {
                    // Bản ghi không tồn tại, xử lý tùy ý (ví dụ: hiển thị thông báo)
                    MessageBox.Show("Không tìm thấy học sinh với ID này.");
                    return false; // Trả về false để chỉ ra rằng không thể xóa bản ghi
                }
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            using (StudentInformationEntities context = new StudentInformationEntities())
            {

                // Lấy tất cả dữ liệu từ bảng StudentDetails và xóa chúng
                var allStudentDetails = context.StudentDetails.ToList();
                context.StudentDetails.RemoveRange(allStudentDetails);
                context.SaveChanges();

                // Sau khi xóa, hiển thị lại dữ liệu trong DataGridView
                Display();
            }    
        }
    }
 }

