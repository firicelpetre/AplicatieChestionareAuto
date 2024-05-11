namespace AplicatieChestionareAuto
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            buttonStartChestionar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonStartChestionar
            // 
            buttonStartChestionar.Anchor = AnchorStyles.Top;
            buttonStartChestionar.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStartChestionar.Location = new Point(400, 484);
            buttonStartChestionar.Name = "buttonStartChestionar";
            buttonStartChestionar.Size = new Size(251, 60);
            buttonStartChestionar.TabIndex = 0;
            buttonStartChestionar.Text = "Start Chestionar";
            buttonStartChestionar.UseVisualStyleBackColor = true;
            buttonStartChestionar.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(255, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(560, 424);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 612);
            Controls.Add(pictureBox1);
            Controls.Add(buttonStartChestionar);
            Name = "MainForm";
            Text = "AplicatieChestionareAuto";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStartChestionar;
        private PictureBox pictureBox1;
    }
}