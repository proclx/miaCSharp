using System.Windows.Forms;
// exercise 4 last part
namespace MiaLukashykLab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ϳ������� ����� formClosing �� ���� FormClosing
            this.FormClosing += new FormClosingEventHandler(formClosing);
        }

        // �����, ���� ���� ��������� ���� �������� �����
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you want to close this window?", "Close Window", buttons);
            if (result == DialogResult.No)
            {
                // ³���� �������� �����, ���� ���������� ������ "ͳ" ��� "���������"
                e.Cancel = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // �������� �������� � TextBox1 �� TextBox2, �� ���������� �� � �����
            if (double.TryParse(textBox1.Text, out double num1) && double.TryParse(textBox2.Text, out double num2))
            {
                // ������ ��������
                double mult = num1 * num2;
                // ������������ ��������� � TextBox3
                textBox3.Text = mult.ToString();
            }
            else
            {
                // ���� ������ ��� �� � ���������
                MessageBox.Show("Please enter valid numbers in TextBox1 and TextBox2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = listBox1.SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = comboBox2.SelectedIndex;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void windowStateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.Font = new Font("Calibri", 8);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            label2.Font = new Font("Calibri", 16);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            label2.Font = new Font("Calibri", 32);
        }

        private void button2Text���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2.Text = "Divide";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maximizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (maximizedToolStripMenuItem.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png|All files (*.*)|*.*";
            openFileDialog1.Title = "Select an Image File";
            openFileDialog1.ShowDialog();

            try
            {
                // Load the selected image into PictureBox
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Font = new Font("Calibri", 8);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Font = new Font("Calibri", 16);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label2.Font = new Font("Calibri", 32);
        }
    }
}