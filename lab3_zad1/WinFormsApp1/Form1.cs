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
            //получаем значение тексового пол€ + отрезаем пробелы по кра€м:
            string UserNAme = tbname.Text.Trim();
            if (UserNAme.Length < 3) //если длина имени пользовател€ слишком коротка, ошибка!
            {
                MessageBox.Show("¬ведите им€ пользовател€!");
            }
            else
            {
                MessageBox.Show("ѕривет " + UserNAme);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
