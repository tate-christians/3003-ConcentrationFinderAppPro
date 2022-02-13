namespace _3003_ConcentrationFinderAppPro
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_basicConcentration = new System.Windows.Forms.TabPage();
            this.grpb_bc_concentration = new System.Windows.Forms.GroupBox();
            this.txtb_bc_calculatedConcentration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_bc_concentrationConverted = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_bc_concentrationInput = new System.Windows.Forms.TextBox();
            this.grpb_bc_volume = new System.Windows.Forms.GroupBox();
            this.txtb_bc_calculatedVolume = new System.Windows.Forms.TextBox();
            this.txtb_bc_volumeConverted = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbo_bc_volume = new System.Windows.Forms.ComboBox();
            this.txtb_bc_volumeInput = new System.Windows.Forms.TextBox();
            this.grpb_bc_mass = new System.Windows.Forms.GroupBox();
            this.txtb_bc_calculatedMass = new System.Windows.Forms.TextBox();
            this.cmbo_bc_mass = new System.Windows.Forms.ComboBox();
            this.btn_bc_calculateMass = new System.Windows.Forms.Button();
            this.txtb_bc_massInput = new System.Windows.Forms.TextBox();
            this.tab_steadyState = new System.Windows.Forms.TabPage();
            this.tab_accumulationAndDecay = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_bc_calculateVolume = new System.Windows.Forms.Button();
            this.btn_bc_calculateConcentration = new System.Windows.Forms.Button();
            this.txtb_bc_massConverted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tab_basicConcentration.SuspendLayout();
            this.grpb_bc_concentration.SuspendLayout();
            this.grpb_bc_volume.SuspendLayout();
            this.grpb_bc_mass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tab_basicConcentration);
            this.tabControl1.Controls.Add(this.tab_steadyState);
            this.tabControl1.Controls.Add(this.tab_accumulationAndDecay);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 449);
            this.tabControl1.TabIndex = 1;
            // 
            // tab_basicConcentration
            // 
            this.tab_basicConcentration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tab_basicConcentration.Controls.Add(this.grpb_bc_concentration);
            this.tab_basicConcentration.Controls.Add(this.grpb_bc_volume);
            this.tab_basicConcentration.Controls.Add(this.grpb_bc_mass);
            this.tab_basicConcentration.Location = new System.Drawing.Point(4, 25);
            this.tab_basicConcentration.Name = "tab_basicConcentration";
            this.tab_basicConcentration.Padding = new System.Windows.Forms.Padding(3);
            this.tab_basicConcentration.Size = new System.Drawing.Size(788, 420);
            this.tab_basicConcentration.TabIndex = 0;
            this.tab_basicConcentration.Text = "BasicConcentration";
            // 
            // grpb_bc_concentration
            // 
            this.grpb_bc_concentration.Controls.Add(this.label7);
            this.grpb_bc_concentration.Controls.Add(this.btn_bc_calculateConcentration);
            this.grpb_bc_concentration.Controls.Add(this.txtb_bc_calculatedConcentration);
            this.grpb_bc_concentration.Controls.Add(this.label5);
            this.grpb_bc_concentration.Controls.Add(this.txtb_bc_concentrationConverted);
            this.grpb_bc_concentration.Controls.Add(this.label4);
            this.grpb_bc_concentration.Controls.Add(this.txtb_bc_concentrationInput);
            this.grpb_bc_concentration.Location = new System.Drawing.Point(588, 0);
            this.grpb_bc_concentration.Name = "grpb_bc_concentration";
            this.grpb_bc_concentration.Size = new System.Drawing.Size(200, 420);
            this.grpb_bc_concentration.TabIndex = 2;
            this.grpb_bc_concentration.TabStop = false;
            this.grpb_bc_concentration.Text = "Concentration";
            // 
            // txtb_bc_calculatedConcentration
            // 
            this.txtb_bc_calculatedConcentration.Location = new System.Drawing.Point(15, 326);
            this.txtb_bc_calculatedConcentration.Name = "txtb_bc_calculatedConcentration";
            this.txtb_bc_calculatedConcentration.ReadOnly = true;
            this.txtb_bc_calculatedConcentration.Size = new System.Drawing.Size(100, 22);
            this.txtb_bc_calculatedConcentration.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "mg/L (ppm)";
            // 
            // txtb_bc_concentrationConverted
            // 
            this.txtb_bc_concentrationConverted.Location = new System.Drawing.Point(15, 231);
            this.txtb_bc_concentrationConverted.Name = "txtb_bc_concentrationConverted";
            this.txtb_bc_concentrationConverted.ReadOnly = true;
            this.txtb_bc_concentrationConverted.Size = new System.Drawing.Size(100, 22);
            this.txtb_bc_concentrationConverted.TabIndex = 5;
            this.txtb_bc_concentrationConverted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "mg/L (ppm)";
            // 
            // txtb_bc_concentrationInput
            // 
            this.txtb_bc_concentrationInput.Location = new System.Drawing.Point(15, 69);
            this.txtb_bc_concentrationInput.Name = "txtb_bc_concentrationInput";
            this.txtb_bc_concentrationInput.Size = new System.Drawing.Size(98, 22);
            this.txtb_bc_concentrationInput.TabIndex = 2;
            this.txtb_bc_concentrationInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtb_bc_concentrationInput.TextChanged += new System.EventHandler(this.txtb_bc_concentrationInput_TextChanged);
            // 
            // grpb_bc_volume
            // 
            this.grpb_bc_volume.Controls.Add(this.label6);
            this.grpb_bc_volume.Controls.Add(this.btn_bc_calculateVolume);
            this.grpb_bc_volume.Controls.Add(this.txtb_bc_calculatedVolume);
            this.grpb_bc_volume.Controls.Add(this.txtb_bc_volumeConverted);
            this.grpb_bc_volume.Controls.Add(this.label3);
            this.grpb_bc_volume.Controls.Add(this.cmbo_bc_volume);
            this.grpb_bc_volume.Controls.Add(this.txtb_bc_volumeInput);
            this.grpb_bc_volume.Location = new System.Drawing.Point(295, 0);
            this.grpb_bc_volume.Name = "grpb_bc_volume";
            this.grpb_bc_volume.Size = new System.Drawing.Size(200, 420);
            this.grpb_bc_volume.TabIndex = 1;
            this.grpb_bc_volume.TabStop = false;
            this.grpb_bc_volume.Text = "Volume";
            // 
            // txtb_bc_calculatedVolume
            // 
            this.txtb_bc_calculatedVolume.Location = new System.Drawing.Point(47, 326);
            this.txtb_bc_calculatedVolume.Name = "txtb_bc_calculatedVolume";
            this.txtb_bc_calculatedVolume.ReadOnly = true;
            this.txtb_bc_calculatedVolume.Size = new System.Drawing.Size(100, 22);
            this.txtb_bc_calculatedVolume.TabIndex = 8;
            // 
            // txtb_bc_volumeConverted
            // 
            this.txtb_bc_volumeConverted.Location = new System.Drawing.Point(47, 231);
            this.txtb_bc_volumeConverted.Name = "txtb_bc_volumeConverted";
            this.txtb_bc_volumeConverted.ReadOnly = true;
            this.txtb_bc_volumeConverted.Size = new System.Drawing.Size(100, 22);
            this.txtb_bc_volumeConverted.TabIndex = 6;
            this.txtb_bc_volumeConverted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "L";
            // 
            // cmbo_bc_volume
            // 
            this.cmbo_bc_volume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_bc_volume.FormattingEnabled = true;
            this.cmbo_bc_volume.Items.AddRange(new object[] {
            "mL",
            "L",
            "cm^3",
            "m^3",
            "G"});
            this.cmbo_bc_volume.Location = new System.Drawing.Point(124, 69);
            this.cmbo_bc_volume.Name = "cmbo_bc_volume";
            this.cmbo_bc_volume.Size = new System.Drawing.Size(46, 24);
            this.cmbo_bc_volume.TabIndex = 4;
            this.cmbo_bc_volume.SelectionChangeCommitted += new System.EventHandler(this.cmbo_bc_volume_SelectionChangeCommitted);
            // 
            // txtb_bc_volumeInput
            // 
            this.txtb_bc_volumeInput.Location = new System.Drawing.Point(35, 69);
            this.txtb_bc_volumeInput.Name = "txtb_bc_volumeInput";
            this.txtb_bc_volumeInput.Size = new System.Drawing.Size(76, 22);
            this.txtb_bc_volumeInput.TabIndex = 1;
            // 
            // grpb_bc_mass
            // 
            this.grpb_bc_mass.Controls.Add(this.label2);
            this.grpb_bc_mass.Controls.Add(this.label1);
            this.grpb_bc_mass.Controls.Add(this.txtb_bc_massConverted);
            this.grpb_bc_mass.Controls.Add(this.txtb_bc_calculatedMass);
            this.grpb_bc_mass.Controls.Add(this.cmbo_bc_mass);
            this.grpb_bc_mass.Controls.Add(this.btn_bc_calculateMass);
            this.grpb_bc_mass.Controls.Add(this.txtb_bc_massInput);
            this.grpb_bc_mass.Location = new System.Drawing.Point(0, 0);
            this.grpb_bc_mass.Name = "grpb_bc_mass";
            this.grpb_bc_mass.Size = new System.Drawing.Size(200, 420);
            this.grpb_bc_mass.TabIndex = 0;
            this.grpb_bc_mass.TabStop = false;
            this.grpb_bc_mass.Text = "Mass";
            // 
            // txtb_bc_calculatedMass
            // 
            this.txtb_bc_calculatedMass.Location = new System.Drawing.Point(44, 326);
            this.txtb_bc_calculatedMass.Name = "txtb_bc_calculatedMass";
            this.txtb_bc_calculatedMass.ReadOnly = true;
            this.txtb_bc_calculatedMass.Size = new System.Drawing.Size(100, 22);
            this.txtb_bc_calculatedMass.TabIndex = 7;
            // 
            // cmbo_bc_mass
            // 
            this.cmbo_bc_mass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_bc_mass.FormattingEnabled = true;
            this.cmbo_bc_mass.Items.AddRange(new object[] {
            "ng",
            "ug",
            "mg",
            "g",
            "kg",
            "lb"});
            this.cmbo_bc_mass.Location = new System.Drawing.Point(121, 69);
            this.cmbo_bc_mass.Name = "cmbo_bc_mass";
            this.cmbo_bc_mass.Size = new System.Drawing.Size(46, 24);
            this.cmbo_bc_mass.TabIndex = 3;
            this.cmbo_bc_mass.SelectionChangeCommitted += new System.EventHandler(this.cmbo_bc_mass_SelectionChangeCommitted);
            // 
            // btn_bc_calculateMass
            // 
            this.btn_bc_calculateMass.Location = new System.Drawing.Point(33, 294);
            this.btn_bc_calculateMass.Name = "btn_bc_calculateMass";
            this.btn_bc_calculateMass.Size = new System.Drawing.Size(122, 26);
            this.btn_bc_calculateMass.TabIndex = 3;
            this.btn_bc_calculateMass.Text = "Calculate Mass";
            this.btn_bc_calculateMass.UseVisualStyleBackColor = true;
            this.btn_bc_calculateMass.Click += new System.EventHandler(this.btn_bc_calculateMass_Click);
            // 
            // txtb_bc_massInput
            // 
            this.txtb_bc_massInput.Location = new System.Drawing.Point(33, 69);
            this.txtb_bc_massInput.Name = "txtb_bc_massInput";
            this.txtb_bc_massInput.Size = new System.Drawing.Size(76, 22);
            this.txtb_bc_massInput.TabIndex = 0;
            // 
            // tab_steadyState
            // 
            this.tab_steadyState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tab_steadyState.Location = new System.Drawing.Point(4, 25);
            this.tab_steadyState.Name = "tab_steadyState";
            this.tab_steadyState.Padding = new System.Windows.Forms.Padding(3);
            this.tab_steadyState.Size = new System.Drawing.Size(788, 420);
            this.tab_steadyState.TabIndex = 1;
            this.tab_steadyState.Text = "Steady State";
            // 
            // tab_accumulationAndDecay
            // 
            this.tab_accumulationAndDecay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tab_accumulationAndDecay.Location = new System.Drawing.Point(4, 25);
            this.tab_accumulationAndDecay.Name = "tab_accumulationAndDecay";
            this.tab_accumulationAndDecay.Padding = new System.Windows.Forms.Padding(3);
            this.tab_accumulationAndDecay.Size = new System.Drawing.Size(788, 420);
            this.tab_accumulationAndDecay.TabIndex = 2;
            this.tab_accumulationAndDecay.Text = "Acummulation + Decay";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_bc_calculateVolume
            // 
            this.btn_bc_calculateVolume.Location = new System.Drawing.Point(35, 294);
            this.btn_bc_calculateVolume.Name = "btn_bc_calculateVolume";
            this.btn_bc_calculateVolume.Size = new System.Drawing.Size(122, 26);
            this.btn_bc_calculateVolume.TabIndex = 9;
            this.btn_bc_calculateVolume.Text = "Calculate Volume";
            this.btn_bc_calculateVolume.UseVisualStyleBackColor = true;
            this.btn_bc_calculateVolume.Click += new System.EventHandler(this.btn_bc_calculateVolume_Click);
            // 
            // btn_bc_calculateConcentration
            // 
            this.btn_bc_calculateConcentration.Location = new System.Drawing.Point(6, 294);
            this.btn_bc_calculateConcentration.Name = "btn_bc_calculateConcentration";
            this.btn_bc_calculateConcentration.Size = new System.Drawing.Size(188, 26);
            this.btn_bc_calculateConcentration.TabIndex = 10;
            this.btn_bc_calculateConcentration.Text = "Calculate Concentration";
            this.btn_bc_calculateConcentration.UseVisualStyleBackColor = true;
            this.btn_bc_calculateConcentration.Click += new System.EventHandler(this.btn_bc_calculateConcentration_Click);
            // 
            // txtb_bc_massConverted
            // 
            this.txtb_bc_massConverted.Location = new System.Drawing.Point(44, 234);
            this.txtb_bc_massConverted.Name = "txtb_bc_massConverted";
            this.txtb_bc_massConverted.ReadOnly = true;
            this.txtb_bc_massConverted.Size = new System.Drawing.Size(100, 22);
            this.txtb_bc_massConverted.TabIndex = 8;
            this.txtb_bc_massConverted.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "mg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "mg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "L";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "mg/L (ppm)";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tab_basicConcentration.ResumeLayout(false);
            this.grpb_bc_concentration.ResumeLayout(false);
            this.grpb_bc_concentration.PerformLayout();
            this.grpb_bc_volume.ResumeLayout(false);
            this.grpb_bc_volume.PerformLayout();
            this.grpb_bc_mass.ResumeLayout(false);
            this.grpb_bc_mass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_basicConcentration;
        private System.Windows.Forms.TabPage tab_steadyState;
        private System.Windows.Forms.TabPage tab_accumulationAndDecay;
        private System.Windows.Forms.GroupBox grpb_bc_concentration;
        private System.Windows.Forms.GroupBox grpb_bc_volume;
        private System.Windows.Forms.GroupBox grpb_bc_mass;
        private System.Windows.Forms.TextBox txtb_bc_concentrationInput;
        private System.Windows.Forms.TextBox txtb_bc_volumeInput;
        private System.Windows.Forms.Button btn_bc_calculateMass;
        private System.Windows.Forms.TextBox txtb_bc_massInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_bc_concentrationConverted;
        private System.Windows.Forms.ComboBox cmbo_bc_volume;
        private System.Windows.Forms.ComboBox cmbo_bc_mass;
        private System.Windows.Forms.TextBox txtb_bc_volumeConverted;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_bc_calculatedConcentration;
        private System.Windows.Forms.TextBox txtb_bc_calculatedVolume;
        private System.Windows.Forms.TextBox txtb_bc_calculatedMass;
        private System.Windows.Forms.Button btn_bc_calculateConcentration;
        private System.Windows.Forms.Button btn_bc_calculateVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_bc_massConverted;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

