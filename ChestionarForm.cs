using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AplicatieChestionareAuto
{
    public partial class ChestionarForm : Form
    {
        private string nextPage;
        int iteratorIntrebari = 0;
        int raspunsuriCorecte = 0;
        int raspunsuriGresite = 0;
        int intrebariRamase = 25;
        ChestionarService chestionarService = new ChestionarService();

        List<int> indexIntrebari = new List<int>();

        public ChestionarForm()
        {
            for (int i = 1; i <= 25; i++)
            {
                indexIntrebari.Add(i);
            }

            InitializeComponent();
            timer1.Start();
            labelCorecte.Text = "Corecte: " + raspunsuriCorecte.ToString();
            labelGresite.Text = "Gresite: " + raspunsuriGresite.ToString();
            labelRamase.Text = "Ramase: " + intrebariRamase.ToString();

            labelNrIntrebare.Text = "Intrebarea #" + (indexIntrebari[0]).ToString();
            labelIntrebare.Text = chestionarService.listaIntrebariChestionar[0].enuntIntrebare;
            checkedListBoxIntrebare.Items.Add(chestionarService.listaIntrebariChestionar[0].variantaA);
            checkedListBoxIntrebare.Items.Add(chestionarService.listaIntrebariChestionar[0].variantaB);
            checkedListBoxIntrebare.Items.Add(chestionarService.listaIntrebariChestionar[0].variantaC);

            labelCronometru.Visible = false;

        }

        private void LoadNextQuestion()
        {
            labelCorecte.Text = "Corecte: " + raspunsuriCorecte.ToString();
            labelGresite.Text = "Gresite: " + raspunsuriGresite.ToString();
            labelRamase.Text = "Ramase: " + intrebariRamase.ToString();
            labelNrIntrebare.Text = "Intrebarea #" + (indexIntrebari[0]).ToString();
            checkedListBoxIntrebare.Items.Clear();
            labelIntrebare.Text = chestionarService.listaIntrebariChestionar[indexIntrebari[0] - 1].enuntIntrebare;
            checkedListBoxIntrebare.Items.Add(chestionarService.listaIntrebariChestionar[indexIntrebari[0] - 1].variantaA);
            checkedListBoxIntrebare.Items.Add(chestionarService.listaIntrebariChestionar[indexIntrebari[0] - 1].variantaB);
            checkedListBoxIntrebare.Items.Add(chestionarService.listaIntrebariChestionar[indexIntrebari[0] - 1].variantaC);
        }

        public string GetNextPage()
        {
            return this.nextPage;
        }

        private void buttonInapoi_Click(object sender, EventArgs e)
        {
            this.Close();
            this.nextPage = "TipuriChestionareForm";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonTrimite_Click(object sender, EventArgs e)
        {
            string raspuns = "";

            if (checkedListBoxIntrebare.GetItemChecked(0))
            {
                raspuns = raspuns + "a";
            }
            if (checkedListBoxIntrebare.GetItemChecked(1))
            {
                raspuns = raspuns + "b";
            }
            if (checkedListBoxIntrebare.GetItemChecked(2))
            {
                raspuns = raspuns + "c";
            }

            if (chestionarService.listaIntrebariChestionar[indexIntrebari[0] - 1].VerificareRaspuns(raspuns) == true)
            {
                raspunsuriCorecte++;
            }
            else
            {
                raspunsuriGresite++;
            }

            if (raspunsuriGresite == 4)
            {
                MessageBox.Show(    "Rezultat: chestionar picat" +
                                    "\n" +
                                    "Total intrebari corecte: " +
                                    raspunsuriCorecte.ToString() +
                                    "\n" +
                                    "Total intrebari gresite: " +
                                    raspunsuriGresite.ToString()
                                );
                this.Close();
                this.nextPage = "TipuriChestionareForm";
            }         

            indexIntrebari.RemoveAt(0);

            if(indexIntrebari.Count == 0)
            {
                MessageBox.Show(    "Rezultat: chestionar trecut" +
                                    "\n" +
                                    "Total intrebari corecte: " +
                                    raspunsuriCorecte.ToString() +
                                    "\n" + 
                                    "Total intrebari gresite: " +
                                    raspunsuriGresite.ToString()
                                );
                this.Close();
                this.nextPage = "TipuriChestionareForm";
            }

            LoadNextQuestion();
        }

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBoxIntrebare.Items.Count; i++)
            {
                checkedListBoxIntrebare.SetItemChecked(i, false);
            }
        }

        private void buttonRaspundMaiTarziu_Click(object sender, EventArgs e)
        {
            indexIntrebari.Add(indexIntrebari[0]);
            indexIntrebari.RemoveAt(0);

            LoadNextQuestion();
        }

        private void labelIntrebare_Click(object sender, EventArgs e)
        {

        }

        private void ChestionarForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
