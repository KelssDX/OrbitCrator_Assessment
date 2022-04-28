namespace OrbitCrator_Assessment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_VehRes = new System.Windows.Forms.TextBox();
            this.bt_Result = new System.Windows.Forms.Button();
            this.cmb_Weather = new System.Windows.Forms.ComboBox();
            this.txt_OrbRes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Orb1_Traff = new System.Windows.Forms.TextBox();
            this.txt_Orb2_Traff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Weather";
            // 
            // txt_VehRes
            // 
            this.txt_VehRes.Location = new System.Drawing.Point(36, 318);
            this.txt_VehRes.Name = "txt_VehRes";
            this.txt_VehRes.Size = new System.Drawing.Size(206, 23);
            this.txt_VehRes.TabIndex = 4;
            // 
            // bt_Result
            // 
            this.bt_Result.Location = new System.Drawing.Point(183, 220);
            this.bt_Result.Name = "bt_Result";
            this.bt_Result.Size = new System.Drawing.Size(206, 47);
            this.bt_Result.TabIndex = 5;
            this.bt_Result.Text = "Get Result";
            this.bt_Result.UseVisualStyleBackColor = true;
            this.bt_Result.Click += new System.EventHandler(this.bt_Result_Click);
            // 
            // cmb_Weather
            // 
            this.cmb_Weather.FormattingEnabled = true;
            this.cmb_Weather.Location = new System.Drawing.Point(182, 86);
            this.cmb_Weather.Name = "cmb_Weather";
            this.cmb_Weather.Size = new System.Drawing.Size(206, 23);
            this.cmb_Weather.TabIndex = 6;
            // 
            // txt_OrbRes
            // 
            this.txt_OrbRes.Location = new System.Drawing.Point(275, 318);
            this.txt_OrbRes.Name = "txt_OrbRes";
            this.txt_OrbRes.Size = new System.Drawing.Size(239, 23);
            this.txt_OrbRes.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vehicle:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Orbit:";
            // 
            // txt_Orb1_Traff
            // 
            this.txt_Orb1_Traff.Location = new System.Drawing.Point(183, 141);
            this.txt_Orb1_Traff.Name = "txt_Orb1_Traff";
            this.txt_Orb1_Traff.Size = new System.Drawing.Size(100, 23);
            this.txt_Orb1_Traff.TabIndex = 10;
          
            this.txt_Orb1_Traff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Orb1_Traff_KeyPress);
            // 
            // txt_Orb2_Traff
            // 
            this.txt_Orb2_Traff.Location = new System.Drawing.Point(183, 170);
            this.txt_Orb2_Traff.Name = "txt_Orb2_Traff";
            this.txt_Orb2_Traff.Size = new System.Drawing.Size(100, 23);
            this.txt_Orb2_Traff.TabIndex = 11;
            this.txt_Orb2_Traff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Orb2_Traff_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Orbit 1 Traffic Speed (mm/h)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Orbit 2 Traffic Speed (mm/h)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 447);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Orb2_Traff);
            this.Controls.Add(this.txt_Orb1_Traff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_OrbRes);
            this.Controls.Add(this.cmb_Weather);
            this.Controls.Add(this.bt_Result);
            this.Controls.Add(this.txt_VehRes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox txt_VehRes;
        private Button bt_Result;
        private ComboBox cmb_Weather;
        private TextBox txt_OrbRes;
        private Label label2;
        private Label label3;
        private TextBox txt_Orb1_Traff;
        private TextBox txt_Orb2_Traff;
        private Label label4;
        private Label label5;
    }
}