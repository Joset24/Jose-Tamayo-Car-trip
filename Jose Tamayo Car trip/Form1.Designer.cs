namespace Jose_Tamayo_Car_trip
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtNumberofGallon = new TextBox();
            listbox = new ListBox();
            btnCal = new Button();
            btnReset = new Button();
            btnQuit = new Button();
            label3 = new Label();
            txtTravel = new TextBox();
            LabelMPG = new Label();
            txtMGP = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 56);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 100);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 2;
            label2.Text = "Number of Gallon";
            label2.Click += label2_Click;
            // 
            // txtNumberofGallon
            // 
            txtNumberofGallon.Location = new Point(198, 100);
            txtNumberofGallon.Margin = new Padding(3, 4, 3, 4);
            txtNumberofGallon.Name = "txtNumberofGallon";
            txtNumberofGallon.Size = new Size(258, 27);
            txtNumberofGallon.TabIndex = 3;
            txtNumberofGallon.TextChanged += textBox1_TextChanged;
            // 
            // listbox
            // 
            listbox.FormattingEnabled = true;
            listbox.Location = new Point(96, 321);
            listbox.Margin = new Padding(3, 4, 3, 4);
            listbox.Name = "listbox";
            listbox.Size = new Size(380, 144);
            listbox.TabIndex = 4;
            listbox.TabStop = false;
            listbox.SelectedIndexChanged += lstOut_SelectedIndexChanged;
            // 
            // btnCal
            // 
            btnCal.BackColor = SystemColors.Window;
            btnCal.Location = new Point(61, 500);
            btnCal.Margin = new Padding(3, 4, 3, 4);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(117, 68);
            btnCal.TabIndex = 5;
            btnCal.Text = "&Calculate Total";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            btnCal.Leave += btnCal_Leave;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(271, 500);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 68);
            btnReset.TabIndex = 6;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(443, 500);
            btnQuit.Margin = new Padding(3, 4, 3, 4);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(86, 68);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 142);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 8;
            label3.Text = "Travel";
            // 
            // txtTravel
            // 
            txtTravel.Location = new Point(198, 138);
            txtTravel.Margin = new Padding(3, 4, 3, 4);
            txtTravel.Name = "txtTravel";
            txtTravel.Size = new Size(258, 27);
            txtTravel.TabIndex = 9;
            // 
            // LabelMPG
            // 
            LabelMPG.AutoSize = true;
            LabelMPG.Location = new Point(97, 194);
            LabelMPG.Name = "LabelMPG";
            LabelMPG.Size = new Size(40, 20);
            LabelMPG.TabIndex = 10;
            LabelMPG.Text = "MPG";
            // 
            // txtMGP
            // 
            txtMGP.Location = new Point(198, 196);
            txtMGP.Margin = new Padding(3, 4, 3, 4);
            txtMGP.Name = "txtMGP";
            txtMGP.Size = new Size(258, 27);
            txtMGP.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 600);
            Controls.Add(txtMGP);
            Controls.Add(LabelMPG);
            Controls.Add(txtTravel);
            Controls.Add(label3);
            Controls.Add(btnQuit);
            Controls.Add(btnReset);
            Controls.Add(btnCal);
            Controls.Add(listbox);
            Controls.Add(txtNumberofGallon);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Jose Car Trip";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNumberofGallon;
        private ListBox listbox;
        private Button btnCal;
        private Button btnQuit;
        
        private Button btnReset;
        private Label label3;
        private TextBox txtTravel;
        private Label LabelMPG;
        private TextBox txtMGP;
    }
}
