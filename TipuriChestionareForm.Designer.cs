namespace AplicatieChestionareAuto
{
    partial class TipuriChestionareForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            buttonInapoi = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(411, 127);
            button1.Name = "button1";
            button1.Size = new Size(220, 55);
            button1.TabIndex = 0;
            button1.Text = "A, A1, A2, AM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(411, 221);
            button2.Name = "button2";
            button2.Size = new Size(220, 55);
            button2.TabIndex = 1;
            button2.Text = "B, B1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(411, 320);
            button3.Name = "button3";
            button3.Size = new Size(220, 55);
            button3.TabIndex = 2;
            button3.Text = "C, C1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(411, 419);
            button4.Name = "button4";
            button4.Size = new Size(220, 55);
            button4.TabIndex = 3;
            button4.Text = "D, D1, Tb, Tv";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // buttonInapoi
            // 
            buttonInapoi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInapoi.Location = new Point(12, 12);
            buttonInapoi.Name = "buttonInapoi";
            buttonInapoi.Size = new Size(100, 35);
            buttonInapoi.TabIndex = 4;
            buttonInapoi.Text = "Inapoi";
            buttonInapoi.UseVisualStyleBackColor = true;
            buttonInapoi.Click += buttonInapoi_Click;
            // 
            // TipuriChestionareForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 625);
            Controls.Add(buttonInapoi);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "TipuriChestionareForm";
            Text = "TipuriChestionareForm";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button buttonInapoi;
    }
}