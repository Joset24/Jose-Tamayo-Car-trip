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
            lblDestination = new Label();
            txtDestination = new TextBox();
            lstOutput = new ListBox();
            btnCal = new Button();
            btnReset = new Button();
            btnQuit = new Button();
            labelDistance = new Label();
            txtDistance = new TextBox();
            LabelMPG = new Label();
            txtMGP = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 56);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Location = new Point(97, 97);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(100, 23);
            lblDestination.TabIndex = 0;
            lblDestination.Text = "Destination";
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(198, 97);
            txtDestination.Margin = new Padding(3, 4, 3, 4);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(258, 27);
            txtDestination.TabIndex = 1;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(96, 321);
            lstOutput.Margin = new Padding(3, 4, 3, 4);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(380, 144);
            lstOutput.TabIndex = 6;
            lstOutput.TabStop = false;
            // 
            // btnCal
            // 
            btnCal.BackColor = SystemColors.Window;
            btnCal.Location = new Point(61, 500);
            btnCal.Margin = new Padding(3, 4, 3, 4);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(117, 68);
            btnCal.TabIndex = 7;
            btnCal.Text = "&Calculate Total";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(271, 500);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 68);
            btnReset.TabIndex = 8;
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
            btnQuit.TabIndex = 9;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // labelDistance
            // 
            labelDistance.AutoSize = true;
            labelDistance.Location = new Point(97, 145);
            labelDistance.Name = "labelDistance";
            labelDistance.Size = new Size(66, 20);
            labelDistance.TabIndex = 3;
            labelDistance.Text = "Distance";
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(198, 138);
            txtDistance.Margin = new Padding(3, 4, 3, 4);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(258, 27);
            txtDistance.TabIndex = 4;
            // 
            // LabelMPG
            // 
            LabelMPG.AutoSize = true;
            LabelMPG.Location = new Point(97, 194);
            LabelMPG.Name = "LabelMPG";
            LabelMPG.Size = new Size(40, 20);
            LabelMPG.TabIndex = 5;
            LabelMPG.Text = "MPG";
            // 
            // txtMGP
            // 
            txtMGP.Location = new Point(198, 196);
            txtMGP.Margin = new Padding(3, 4, 3, 4);
            txtMGP.Name = "txtMGP";
            txtMGP.Size = new Size(258, 27);
            txtMGP.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 97);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 0;
            label2.Text = "Destination";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 600);
            Controls.Add(label2);
            Controls.Add(txtMGP);
            Controls.Add(LabelMPG);
            Controls.Add(txtDistance);
            Controls.Add(labelDistance);
            Controls.Add(btnQuit);
            Controls.Add(btnReset);
            Controls.Add(btnCal);
            Controls.Add(lstOutput);
            Controls.Add(txtDestination);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Jose Car Trip";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
      
        private TextBox txtDestination;
        private ListBox lstOutput;
        private Button btnCal;
        private Button btnQuit;
        
        private Button btnReset;
        private Label labelDistance;
        private TextBox txtDistance;
        private Label LabelMPG;
        private TextBox txtMGP;
        private Label lblDestination;
        private Label label2;
    }   
 }
