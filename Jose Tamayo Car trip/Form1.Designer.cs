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
            label2 = new Label();
            groupBox1 = new GroupBox();
            rdoMicro = new RadioButton();
            rdoMinivan = new RadioButton();
            rdoSuv = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 55);
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
            txtDistance.Location = new Point(198, 139);
            txtDistance.Margin = new Padding(3, 4, 3, 4);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(258, 27);
            txtDistance.TabIndex = 4;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoMicro);
            groupBox1.Controls.Add(rdoMinivan);
            groupBox1.Controls.Add(rdoSuv);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(43, 1);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(467, 84);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Car Type";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rdoMicro
            // 
            rdoMicro.AutoSize = true;
            rdoMicro.Location = new Point(243, 33);
            rdoMicro.Margin = new Padding(3, 4, 3, 4);
            rdoMicro.Name = "rdoMicro";
            rdoMicro.Size = new Size(68, 24);
            rdoMicro.TabIndex = 3;
            rdoMicro.TabStop = true;
            rdoMicro.Text = "Micro";
            rdoMicro.UseVisualStyleBackColor = true;
            rdoMicro.CheckedChanged += rdoMicro_CheckedChanged;
            // 
            // rdoMinivan
            // 
            rdoMinivan.AutoSize = true;
            rdoMinivan.Location = new Point(130, 33);
            rdoMinivan.Margin = new Padding(3, 4, 3, 4);
            rdoMinivan.Name = "rdoMinivan";
            rdoMinivan.Size = new Size(83, 24);
            rdoMinivan.TabIndex = 2;
            rdoMinivan.TabStop = true;
            rdoMinivan.Text = "MiniVan";
            rdoMinivan.UseVisualStyleBackColor = true;
            rdoMinivan.CheckedChanged += rdoMinivan_CheckedChanged;
            // 
            // rdoSuv
            // 
            rdoSuv.AutoSize = true;
            rdoSuv.Checked = true;
            rdoSuv.Location = new Point(31, 33);
            rdoSuv.Margin = new Padding(3, 4, 3, 4);
            rdoSuv.Name = "rdoSuv";
            rdoSuv.Size = new Size(57, 24);
            rdoSuv.TabIndex = 1;
            rdoSuv.TabStop = true;
            rdoSuv.Text = "SUV";
            rdoSuv.UseVisualStyleBackColor = true;
            rdoSuv.CheckedChanged += rdoSuv_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 600);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(txtDistance);
            Controls.Add(labelDistance);
            Controls.Add(btnQuit);
            Controls.Add(btnReset);
            Controls.Add(btnCal);
            Controls.Add(lstOutput);
            Controls.Add(txtDestination);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Jose Car Trip";
            Load += Form1_Load;
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
        private Label lblDestination;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton rdoMinivan;
        private RadioButton rdoSuv;
        private RadioButton rdoMicro;
    }   
 }
