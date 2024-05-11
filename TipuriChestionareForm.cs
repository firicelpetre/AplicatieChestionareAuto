using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieChestionareAuto
{
    public partial class TipuriChestionareForm : Form
    {
        private string nextPage;

        public TipuriChestionareForm()
        {
            InitializeComponent();
        }

        public string GetNextPage()
        {
            return this.nextPage;
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            this.nextPage = "MainForm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.nextPage = "ChestionarForm";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.nextPage = "ChestionarForm";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.nextPage = "ChestionarForm";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.nextPage = "ChestionarForm";
        }
    }
}
