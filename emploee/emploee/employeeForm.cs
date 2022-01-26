using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emploee
{
    public partial class Emploee : Form
    {
        public Emploee()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void no_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar));
            if(e.KeyChar==(Char)13)
                name.Focus();
            
        }

        private void name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsNumber(e.KeyChar);
            if (e.KeyChar == (Char)13)
                grade.Focus();
        }

        private void grade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                salary.Focus();
        }

        private void salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar));
            if (e.KeyChar == (char)13)
               birthDate.Focus();
        }
        private void birthDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                job.Focus();
        }
        private void job_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                no.Focus();
        }

        private void total_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < listBox4.Items.Count; i++) {
                sum += Convert.ToDouble(listBox4.Items[i]);
            }
            totalTitle.Text = sum.ToString();
        }

        private void count_Click(object sender, EventArgs e)
        {
            countTitle.Text = listBox3.Items.Count.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(no.Text==""||name.Text==""||salary.Text==""){
            MessageBox.Show("You have to full all fields");
            return;
            }
            listBox1.Items.Add(no.Text);
            listBox2.Items.Add(name.Text);
            listBox3.Items.Add(grade.Text);
            listBox4.Items.Add(salary.Text);
            listBox5.Items.Add(birthDate.Value.Date.ToString("MM/dd/yyyy"));
            listBox6.Items.Add(job.Text);
            MessageBox.Show("One employee was added");
            clearField();
        }
        private void clearField()
        {
            no.Clear();
            name.Clear();
            salary.Clear();
            grade.Items.Clear();
            job.Items.Clear();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            now.Text = Convert.ToString(DateTime.Now.Hour+":"+DateTime.Now.Minute+":"+DateTime.Now.Second);
            dateToday.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void Emploee_Load(object sender, EventArgs e)
        { // قعد الوقت ثابت على لحظة تحميل الفورم
            //now.Text = Convert.ToString(DateTime.Now);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(i);
            listBox2.Items.RemoveAt(i);
            listBox3.Items.RemoveAt(i);
            listBox4.Items.RemoveAt(i);
            listBox5.Items.RemoveAt(i);
            listBox6.Items.RemoveAt(i);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox1.SelectedIndex;
            listBox3.SelectedIndex = listBox1.SelectedIndex;
            listBox4.SelectedIndex = listBox1.SelectedIndex;
            listBox5.SelectedIndex = listBox1.SelectedIndex;
            listBox6.SelectedIndex = listBox1.SelectedIndex;

        }



    }
}
