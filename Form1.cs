using System.Text;

namespace TheFinal
{
    public partial class Form1 : Form
    {
        List<Data1v> list = new List<Data1v>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _Name = this.textBox1.Text;
            string _Occupation = this.textBox2.Text;
            string _Birthyear = this.textBox3.Text;
            string _Income = this.textBox4.Text;
            string _Days = this.textBox5.Text;
            string _Gender = this.textBox6.Text;
            string _IDCard = this.textBox7.Text;
            string _Nationality = this.textBox8.Text;


            double ibirthyear = Double.Parse(_Birthyear);
            double iincome = Double.Parse(_Income);
            double idays = Double.Parse(_Days);


            Data1v newData1v = new Data1v(_Name, _Occupation, ibirthyear, iincome, idays, _Gender, _IDCard, _Nationality);


            this.list.Add(newData1v);


            BindingSource source = new BindingSource();
            source.DataSource = this.list;
            this.dataGridView1.DataSource = source;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(.csv)|.csv";
                if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
                {
                    try
                    {
                        int columnCount = dataGridView1.Columns.Count;
                        string columnNames = "";
                        string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                        for (int i = 0; i < columnCount; i++)
                        {
                            columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                        }
                        outputCSV[0] += columnNames;
                        for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < columnCount; j++)
                            {
                                var cellValue = dataGridView1.Rows[i - 1].Cells[j].Value;
                                outputCSV[i] += cellValue != null ? cellValue.ToString() + "," : ",";
                            }
                        }
                        File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        MessageBox.Show("Exported to CSV successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login2v f3 = new Login2v();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}