using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan7_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!File.Exists("data.txt"))
            {
                MessageBox.Show("Ghi dữ liệu thành công" +".");
                return;
            }

            using (StreamReader reader = new StreamReader("data.txt"))
            {
                txtSoNguyen.Text = reader.ReadLine();
                txtSoThuc.Text = reader.ReadLine();
                cboLogic.SelectedItem = reader.ReadLine() == "True" ? "True" : "False";
                txtXau.Text = reader.ReadLine();
            }

            MessageBox.Show("Đọc file thành công.");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSoNguyen.Clear();
            txtSoThuc.Clear();
            cboLogic.SelectedIndex = -1;
            txtXau.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (!File.Exists("data.txt"))
            {
                MessageBox.Show("File không tồn tại.");
                return;
            }

            using (StreamReader reader = new StreamReader("data.txt"))
            {
                txtSoNguyen.Text = reader.ReadLine();
                txtSoThuc.Text = reader.ReadLine();
                cboLogic.SelectedItem = reader.ReadLine() == "True" ? "True" : "False";
                txtXau.Text = reader.ReadLine();
            }

            MessageBox.Show("Đọc file thành công.");
        }
    }
}
