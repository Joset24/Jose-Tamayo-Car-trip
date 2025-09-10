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
            txtCustomerName = new TextBox();
            label2 = new Label();
            txtNumWidgets = new TextBox();
            lstOut = new ListBox();
            btnCal = new Button();
            btnReset = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 107);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(172, 99);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(226, 23);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.Enter += txtCustomerName_Enter;
            txtCustomerName.Leave += txtCustomerName_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 140);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 2;
            label2.Text = "Number of Gallon";
            label2.Click += label2_Click;
            // 
            // txtNumWidgets
            // 
            txtNumWidgets.Location = new Point(172, 140);
            txtNumWidgets.Name = "txtNumWidgets";
            txtNumWidgets.Size = new Size(226, 23);
            txtNumWidgets.TabIndex = 3;
            txtNumWidgets.TextChanged += textBox1_TextChanged;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(84, 195);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(333, 109);
            lstOut.TabIndex = 4;
            lstOut.TabStop = false;
            lstOut.SelectedIndexChanged += lstOut_SelectedIndexChanged;
            // 
            // btnCal
            // 
            btnCal.BackColor = SystemColors.Window;
            btnCal.Location = new Point(97, 344);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(102, 51);
            btnCal.TabIndex = 5;
            btnCal.Text = "&Calculate Total";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            btnCal.Leave += btnCal_Leave;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(205, 344);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 51);
            btnReset.TabIndex = 6;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(323, 344);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 51);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuit);
            Controls.Add(btnReset);
            Controls.Add(btnCal);
            Controls.Add(lstOut);
            Controls.Add(txtNumWidgets);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Jose Car Trip";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCustomerName;
        private Label label2;
        private TextBox txtNumWidgets;
        private ListBox lstOut;
        private Button btnCal;
        private Button btnQuit;
        
        private Button btnReset;
    }
}
