using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_Worker
{
    public partial class Form1 : Form
    {
        private Workers _workers;
        public Form1()
        {
            _workers = new Workers();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _workers.CreateWorkers();
        }
       
        private void BtnSalary_Click(object sender, EventArgs e)
        {
            _workers.LoadWorkers(ListWorkers);

        }

        private void BtnSort_Click(object sender, EventArgs e)
        {
            _workers.SortSalary(ListWorkers);
        }
        
    }
}
