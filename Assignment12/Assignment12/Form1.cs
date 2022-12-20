using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment12
{
    public partial class Form1 : Form
    {
        ProductionWorker productionWorker = new ProductionWorker(); 


        public class Employee
        {
            public string EmployeeName { get; set; }
            public int EmployeeNumber { get; set; }
        }

        public class ProductionWorker : Employee
        {
            public float HourlyPayRate { get; set; }
            public Shift Shift { get; set; }
        }

        public enum Shift
        {
            Day = 1,
            Night = 2
        }

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            productionWorker.EmployeeName = textBox1.Text;
            productionWorker.EmployeeNumber = Convert.ToInt32(textBox2.Text);
            productionWorker.HourlyPayRate = Convert.ToInt32(textBox3.Text);
            productionWorker.Shift = (Shift)Enum.Parse(typeof(Shift), textBox4.Text);


            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: " + productionWorker.EmployeeName + " Employee Number: " + productionWorker.EmployeeNumber + " Hourly rate: " + productionWorker.HourlyPayRate + " Shift: " + productionWorker.Shift);
        }
    }


}

