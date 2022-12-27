using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgSED2
{
    public partial class DataForm : Form
    {
        List<CDocument> Doc;
        public DataForm(List<CDocument> doc)
        {
            Doc = doc;
            InitializeComponent();
            DataGridMethod();
        }

       
        public void DataGridMethod()
        {
<<<<<<< HEAD
            dataGridView1.Rows.Add(Doc[0].Number, Doc[0].Name, Doc[0].Status, Doc[0].Date_Start, Doc[0].Date_Finish );
            dataGridView1.Rows.Add(Doc[1].Number, Doc[1].Name, Doc[1].Status, Doc[1].Date_Start, Doc[1].Date_Finish);
            dataGridView1.Rows.Add(Doc[2].Number, Doc[2].Name, Doc[2].Status, Doc[2].Date_Start, Doc[2].Date_Finish);
=======
            for(int i = 0; i < Doc.Count; i++)
            {
                dataGridView1.Rows.Add(Doc[i].Number, Doc[i].Name, Doc[i].Status, Doc[i].Date_Start, Doc[i].Date_Finish);
            }
>>>>>>> Class

        }

        private void buttonClick_Nayti(object sender, EventArgs e)
        {
          
        }

        private void buttonClick_Dobavit(object sender, EventArgs e)
        {
            
            Add add = new Add(Doc);
<<<<<<< HEAD
            add.Show();
=======
            add.ShowDialog();
            Doc.Add(add.GetDocument());
            add.Clear();

>>>>>>> Class
        }

        private void buttonClick_Redact(object sender, EventArgs e)
        {

        }

        private void buttonClick_Delete(object sender, EventArgs e)
        {

        }

        private void buttonClick_Vxod(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "" || this.textBox2.Text == "")
            {
                MessageBox.Show(
                "Введите логин и пароль",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            }

            else { this.textBox1.Text = ""; this.textBox2.Text = ""; }

        }
    }
    
}
