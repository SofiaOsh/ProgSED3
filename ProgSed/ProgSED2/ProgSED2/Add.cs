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
    public partial class Add : Form
    {
        CDocument cd = new CDocument();
        bool prov = false;
        public Add(List<CDocument> doc)
        {
            InitializeComponent();
        }

        public void buttonClick_Save(object sender, EventArgs e)
        {
            
                prov = true;
                cd.Name = comboBox1.Text;
                cd.Status = comboBox2.Text;
                cd.Type = comboBox1.Text;
                cd.Author_1 = textBox3.Text;
                cd.Author_2 = textBox4.Text;
                cd.Number = textBox2.Text;
                cd.Comments = textBox6.Text;
                cd.Summa = Convert.ToInt32(textBox5.Text);
                cd.Date_Start = Convert.ToDateTime(dateTimePicker1.Text);
                cd.Date_Finish = Convert.ToDateTime(dateTimePicker2.Text);
            
            this.Close();
            prov = false;

        }

        public CDocument GetDocument()
        {
            return cd; 
        }
        public void Clear()
        {
            cd = null;
        }
    }
}
