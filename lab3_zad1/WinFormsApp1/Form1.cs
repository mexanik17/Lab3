namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        private void tbname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            //�������� �������� ��������� ���� + �������� ������� �� �����:
            string UserNAme = tbname.Text.Trim();
            if (UserNAme.Length < 3) //���� ����� ����� ������������ ������� �������, ������!
            {
                MessageBox.Show("������� ��� ������������!");
            }
            else
            {
                MessageBox.Show("������ " + UserNAme);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
