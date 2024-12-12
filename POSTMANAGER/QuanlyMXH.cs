using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static POSTMANAGER.Program;

namespace POSTMANAGER
{
    public partial class QuanlyMXH : Form
    {
        public QuanlyMXH()
        {
            InitializeComponent();
            linkedList = new MyLinkedList();
        }
        private LinkedList<Post> posts;

        public class Post
        {
            public string PostID { get; set; }
            public string noiDungBaiDang { get; set; }
            public string tacGia { get; set; }
            public string ngayDang { get; set; }
        }
        private MyLinkedList linkedList;
        public class MyLinkedList
        {
            private MyNode head;

            public void AddLast(Post data)
            {
                MyNode newNode = new MyNode(data);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    MyNode current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                }
            }
            public void EditPost(string postID, string newData)
            {
                MyNode current = head;
                while (current != null)
                {
                    if (current.Data.PostID == postID)
                    {
                        current.Data.noiDungBaiDang = newData;
                        break;
                    }
                    current = current.Next;
                }
            }

            public void DeletePost(string postID)
            {
                if (head == null)
                    return;

                if (head.Data.PostID == postID)
                {
                    head = head.Next;
                    return;
                }

                MyNode current = head;
                MyNode previous = null;
                while (current != null && current.Data.PostID != postID)
                {
                    previous = current;
                    current = current.Next;
                }

                if (current != null)
                {
                    previous.Next = current.Next;
                }
            }

            public IEnumerable<Post> GetAllPosts()
            {
                MyNode current = head;
                while (current != null)
                {
                    yield return current.Data;
                    current = current.Next;
                }
            }

        }

        public class MyNode
        {
            public Post Data { get; set; }
            public MyNode Next { get; set; }

            public MyNode(Post data)
            {
                Data = data;
                Next = null;
            }
        }
        private void HienThi()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("PostID");
            dt.Columns.Add("noiDungBaiDang");
            dt.Columns.Add("tacGia");
            dt.Columns.Add("ngayDang");

            foreach (Post post in linkedList.GetAllPosts())
            {
                dt.Rows.Add(post.PostID, post.noiDungBaiDang, post.tacGia, post.ngayDang);
            }


            dgvbaiDang.DataSource = dt;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtPostID.Text == "" || txtNoiDungBaiDang.Text == "" || txtTacGia.Text == "" || dtpngayDang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                Post newPost = new Post
                {
                    PostID = txtPostID.Text,
                    noiDungBaiDang = txtNoiDungBaiDang.Text,
                    tacGia = txtTacGia.Text,
                    ngayDang = dtpngayDang.Value.ToString()
                };
                linkedList.AddLast(newPost);
                HienThi();
            }
        }


        private void btnSuaBaiDang_Click(object sender, EventArgs e)
        {
            if (txtPostID.Text == "" || txtNoiDungBaiDang.Text == "" || txtTacGia.Text == "" || dtpngayDang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else
            {
                linkedList.EditPost(txtPostID.Text, txtNoiDungBaiDang.Text);
                HienThi();
            }
        }

        private void btnXoaBaiDang_Click(object sender, EventArgs e)
        {
            if (txtPostID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã bài đăng cần xóa");
                return;
            }
            else
            {
                linkedList.DeletePost(txtPostID.Text);
                HienThi();
            }
        }
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Home());
            label5.Text = button1.Text;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label5.Text = button2.Text;
        }
        private void dgvbaiDang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtPostID.Text = dgvbaiDang.Rows[index].Cells["postID"].Value.ToString();
                txtNoiDungBaiDang.Text = dgvbaiDang.Rows[index].Cells["noiDungBaiDang"].Value.ToString();
                txtTacGia.Text = dgvbaiDang.Rows[index].Cells["tacGia"].Value.ToString();
                dtpngayDang.Text = dgvbaiDang.Rows[index].Cells["ngayDang"].Value.ToString();

            }
        }

    }
}
