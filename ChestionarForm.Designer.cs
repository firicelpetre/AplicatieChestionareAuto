namespace AplicatieChestionareAuto
{
    partial class ChestionarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            labelCorecte = new Label();
            labelGresite = new Label();
            labelRamase = new Label();
            labelIntrebari = new Label();
            labelCronometru = new Label();
            buttonInapoi = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            labelNrIntrebare = new Label();
            checkedListBoxIntrebare = new CheckedListBox();
            buttonTrimite = new Button();
            buttonSterge = new Button();
            buttonRaspundMaiTarziu = new Button();
            labelIntrebare = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelCorecte);
            groupBox1.Controls.Add(labelGresite);
            groupBox1.Controls.Add(labelRamase);
            groupBox1.Controls.Add(labelIntrebari);
            groupBox1.Controls.Add(labelCronometru);
            groupBox1.Controls.Add(buttonInapoi);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1045, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // labelCorecte
            // 
            labelCorecte.AutoSize = true;
            labelCorecte.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelCorecte.Location = new Point(746, 55);
            labelCorecte.Name = "labelCorecte";
            labelCorecte.Size = new Size(94, 30);
            labelCorecte.TabIndex = 5;
            labelCorecte.Text = "Corecte:";
            // 
            // labelGresite
            // 
            labelGresite.AutoSize = true;
            labelGresite.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelGresite.Location = new Point(505, 55);
            labelGresite.Name = "labelGresite";
            labelGresite.Size = new Size(86, 30);
            labelGresite.TabIndex = 4;
            labelGresite.Text = "Gresite:";
            // 
            // labelRamase
            // 
            labelRamase.AutoSize = true;
            labelRamase.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelRamase.Location = new Point(299, 55);
            labelRamase.Name = "labelRamase";
            labelRamase.Size = new Size(93, 30);
            labelRamase.TabIndex = 3;
            labelRamase.Text = "Ramase:";
            // 
            // labelIntrebari
            // 
            labelIntrebari.AutoSize = true;
            labelIntrebari.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelIntrebari.Location = new Point(127, 55);
            labelIntrebari.Name = "labelIntrebari";
            labelIntrebari.Size = new Size(100, 30);
            labelIntrebari.TabIndex = 2;
            labelIntrebari.Text = "Intrebari:";
            // 
            // labelCronometru
            // 
            labelCronometru.AutoSize = true;
            labelCronometru.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelCronometru.Location = new Point(127, 0);
            labelCronometru.Name = "labelCronometru";
            labelCronometru.Size = new Size(0, 30);
            labelCronometru.TabIndex = 1;
            // 
            // buttonInapoi
            // 
            buttonInapoi.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInapoi.Location = new Point(6, 45);
            buttonInapoi.Name = "buttonInapoi";
            buttonInapoi.Size = new Size(84, 40);
            buttonInapoi.TabIndex = 0;
            buttonInapoi.Text = "Inapoi";
            buttonInapoi.UseVisualStyleBackColor = true;
            buttonInapoi.Click += buttonInapoi_Click;
            // 
            // labelNrIntrebare
            // 
            labelNrIntrebare.AutoSize = true;
            labelNrIntrebare.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelNrIntrebare.Location = new Point(36, 103);
            labelNrIntrebare.Name = "labelNrIntrebare";
            labelNrIntrebare.Size = new Size(132, 30);
            labelNrIntrebare.TabIndex = 1;
            labelNrIntrebare.Text = "Intrebarea #";
            // 
            // checkedListBoxIntrebare
            // 
            checkedListBoxIntrebare.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBoxIntrebare.FormattingEnabled = true;
            checkedListBoxIntrebare.Location = new Point(36, 220);
            checkedListBoxIntrebare.Name = "checkedListBoxIntrebare";
            checkedListBoxIntrebare.Size = new Size(937, 100);
            checkedListBoxIntrebare.TabIndex = 3;
            checkedListBoxIntrebare.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // buttonTrimite
            // 
            buttonTrimite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonTrimite.Location = new Point(36, 403);
            buttonTrimite.Name = "buttonTrimite";
            buttonTrimite.Size = new Size(225, 40);
            buttonTrimite.TabIndex = 4;
            buttonTrimite.Text = "Trimite";
            buttonTrimite.UseVisualStyleBackColor = true;
            buttonTrimite.Click += buttonTrimite_Click;
            // 
            // buttonSterge
            // 
            buttonSterge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSterge.Location = new Point(36, 465);
            buttonSterge.Name = "buttonSterge";
            buttonSterge.Size = new Size(225, 40);
            buttonSterge.TabIndex = 5;
            buttonSterge.Text = "Sterge";
            buttonSterge.UseVisualStyleBackColor = true;
            buttonSterge.Click += buttonSterge_Click;
            // 
            // buttonRaspundMaiTarziu
            // 
            buttonRaspundMaiTarziu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRaspundMaiTarziu.Location = new Point(36, 525);
            buttonRaspundMaiTarziu.Name = "buttonRaspundMaiTarziu";
            buttonRaspundMaiTarziu.Size = new Size(225, 40);
            buttonRaspundMaiTarziu.TabIndex = 6;
            buttonRaspundMaiTarziu.Text = "Raspund mai tarziu";
            buttonRaspundMaiTarziu.UseVisualStyleBackColor = true;
            buttonRaspundMaiTarziu.Click += buttonRaspundMaiTarziu_Click;
            // 
            // labelIntrebare
            // 
            labelIntrebare.AutoSize = true;
            labelIntrebare.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelIntrebare.Location = new Point(36, 149);
            labelIntrebare.Name = "labelIntrebare";
            labelIntrebare.Size = new Size(106, 21);
            labelIntrebare.TabIndex = 7;
            labelIntrebare.Text = "labelIntrebare";
            labelIntrebare.Click += labelIntrebare_Click;
            // 
            // ChestionarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 601);
            Controls.Add(labelIntrebare);
            Controls.Add(buttonRaspundMaiTarziu);
            Controls.Add(buttonSterge);
            Controls.Add(buttonTrimite);
            Controls.Add(checkedListBoxIntrebare);
            Controls.Add(labelNrIntrebare);
            Controls.Add(groupBox1);
            Name = "ChestionarForm";
            Text = "ChestionarForm";
            Load += ChestionarForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonInapoi;
        private Label labelCorecte;
        private Label labelGresite;
        private Label labelRamase;
        private Label labelIntrebari;
        private Label labelCronometru;
        private System.Windows.Forms.Timer timer1;
        private Label labelNrIntrebare;
        private CheckedListBox checkedListBoxIntrebare;
        private Button buttonTrimite;
        private Button buttonSterge;
        private Button buttonRaspundMaiTarziu;
        private Label labelIntrebare;
    }
}