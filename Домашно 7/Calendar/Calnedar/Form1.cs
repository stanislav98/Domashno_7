using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            JulianCalendar dt = new JulianCalendar();
            textBox1.Text ="Day "+ (dt.GetDayOfYear(dateTimePicker1.Value)).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
