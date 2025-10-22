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
            groupBox1 = new GroupBox();
            rdoSuv = new RadioButton();
            rdoMinivan = new RadioButton();
            rdoMicro = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 41);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
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
            txtDestination.Location = new Point(173, 73);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(226, 23);
            txtDestination.TabIndex = 1;
            // 
            // lstOutput
            // 
            lstOutput.FormattingEnabled = true;
            lstOutput.ItemHeight = 15;
            lstOutput.Location = new Point(84, 241);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(333, 109);
            lstOutput.TabIndex = 6;
            lstOutput.TabStop = false;
            // 
            // btnCal
            // 
            btnCal.BackColor = SystemColors.Window;
            btnCal.Location = new Point(53, 375);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(102, 51);
            btnCal.TabIndex = 7;
            btnCal.Text = "&Calculate Total";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(237, 375);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 51);
            btnReset.TabIndex = 8;
            btnReset.Text = "&Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(388, 375);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(75, 51);
            btnQuit.TabIndex = 9;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // labelDistance
            // 
            labelDistance.AutoSize = true;
            labelDistance.Location = new Point(85, 109);
            labelDistance.Name = "labelDistance";
            labelDistance.Size = new Size(52, 15);
            labelDistance.TabIndex = 3;
            labelDistance.Text = "Distance";
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(173, 104);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(226, 23);
            txtDistance.TabIndex = 4;
            // 
            // LabelMPG
            // 
            LabelMPG.AutoSize = true;
            LabelMPG.Location = new Point(85, 146);
            LabelMPG.Name = "LabelMPG";
            LabelMPG.Size = new Size(33, 15);
            LabelMPG.TabIndex = 5;
            LabelMPG.Text = "MPG";
            // 
            // txtMGP
            // 
            txtMGP.Location = new Point(173, 147);
            txtMGP.Name = "txtMGP";
            txtMGP.Size = new Size(226, 23);
            txtMGP.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 73);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "Destination";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoMicro);
            groupBox1.Controls.Add(rdoMinivan);
            groupBox1.Controls.Add(rdoSuv);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(38, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 63);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Car Type";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdoSuv
            // 
            rdoSuv.AutoSize = true;
            rdoSuv.Location = new Point(27, 25);
            rdoSuv.Name = "rdoSuv";
            rdoSuv.Size = new Size(44, 19);
            rdoSuv.TabIndex = 1;
            rdoSuv.TabStop = true;
            rdoSuv.Text = "Suv";
            rdoSuv.UseVisualStyleBackColor = true;
            // 
            // rdoMinivan
            // 
            rdoMinivan.AutoSize = true;
            rdoMinivan.Location = new Point(114, 25);
            rdoMinivan.Name = "rdoMinivan";
            rdoMinivan.Size = new Size(68, 19);
            rdoMinivan.TabIndex = 2;
            rdoMinivan.TabStop = true;
            rdoMinivan.Text = "Minivan";
            rdoMinivan.UseVisualStyleBackColor = true;
            // 
            // rdoMicro
            // 
            rdoMicro.AutoSize = true;
            rdoMicro.Location = new Point(213, 25);
            rdoMicro.Name = "rdoMicro";
            rdoMicro.Size = new Size(56, 19);
            rdoMicro.TabIndex = 3;
            rdoMicro.TabStop = true;
            rdoMicro.Text = "Micro";
            rdoMicro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
            Controls.Add(groupBox1);
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
            Name = "Form1";
            Text = "Jose Car Trip";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private RadioButton rdoMinivan;
        private RadioButton rdoSuv;
        private RadioButton rdoMicro;
    }   
 }
