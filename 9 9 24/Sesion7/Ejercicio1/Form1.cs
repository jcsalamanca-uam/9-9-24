using Ejercicio1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        GradeStorage grades= new GradeStorage();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbGrades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbGrades_TextChanged(object sender, EventArgs e)
        {
        }
        private void AddElement()
        {
            try
            {
                int grade = Convert.ToInt32(tbGrades.Text);
                grades.AddElement(grade, index);
                index++;
                ShowGrades();
                tbGrades.Clear();
                tbGrades.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowGrades()
        {
            try
            {
                lbGrades.Items.Clear();
                for (int i = 0; i < index; i++)
                {
                    lbGrades.Items.Add(grades.GetGrades()[i]);
                }
                int sum=grades.GetGrades().Sum();
                double avg=sum/index;
                lblSum.Text = "Suma: " + sum;
                lblAverage.Text = "Promedio: " + avg;
            }
            catch (Exception ex) { }
        }

        private void tbGrades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddElement();
            }

        }
    }
}
