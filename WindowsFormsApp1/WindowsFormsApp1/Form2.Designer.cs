namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtBsalary = new System.Windows.Forms.TextBox();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.txtDA = new System.Windows.Forms.TextBox();
            this.txtPF = new System.Windows.Forms.TextBox();
            this.txtGsalary = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EmpId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emp Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Basic Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "HRA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "TA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "DA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "PF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gross Salary";
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Purple;
            this.lblmsg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmsg.Location = new System.Drawing.Point(436, 206);
            this.lblmsg.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(36, 13);
            this.lblmsg.TabIndex = 9;
            this.lblmsg.Text = "lblmsg";
            this.lblmsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(163, 35);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(137, 20);
            this.txtEmpId.TabIndex = 10;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(163, 82);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(137, 20);
            this.txtEmpName.TabIndex = 11;
            // 
            // txtBsalary
            // 
            this.txtBsalary.Location = new System.Drawing.Point(163, 199);
            this.txtBsalary.Name = "txtBsalary";
            this.txtBsalary.Size = new System.Drawing.Size(137, 20);
            this.txtBsalary.TabIndex = 12;
            // 
            // txtHRA
            // 
            this.txtHRA.Location = new System.Drawing.Point(163, 264);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.ReadOnly = true;
            this.txtHRA.Size = new System.Drawing.Size(137, 20);
            this.txtHRA.TabIndex = 13;
            // 
            // txtTA
            // 
            this.txtTA.Location = new System.Drawing.Point(163, 320);
            this.txtTA.Name = "txtTA";
            this.txtTA.ReadOnly = true;
            this.txtTA.Size = new System.Drawing.Size(137, 20);
            this.txtTA.TabIndex = 14;
            // 
            // txtDA
            // 
            this.txtDA.Location = new System.Drawing.Point(163, 365);
            this.txtDA.Name = "txtDA";
            this.txtDA.ReadOnly = true;
            this.txtDA.Size = new System.Drawing.Size(137, 20);
            this.txtDA.TabIndex = 15;
            // 
            // txtPF
            // 
            this.txtPF.Location = new System.Drawing.Point(163, 429);
            this.txtPF.Name = "txtPF";
            this.txtPF.ReadOnly = true;
            this.txtPF.Size = new System.Drawing.Size(137, 20);
            this.txtPF.TabIndex = 16;
            // 
            // txtGsalary
            // 
            this.txtGsalary.Location = new System.Drawing.Point(163, 499);
            this.txtGsalary.Name = "txtGsalary";
            this.txtGsalary.ReadOnly = true;
            this.txtGsalary.Size = new System.Drawing.Size(137, 20);
            this.txtGsalary.TabIndex = 17;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(163, 136);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(137, 21);
            this.cmbDepartment.TabIndex = 19;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.Location = new System.Drawing.Point(64, 568);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 40);
            this.btnCalculate.TabIndex = 20;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDisplay.Location = new System.Drawing.Point(229, 568);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(99, 40);
            this.btnDisplay.TabIndex = 21;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.txtGsalary);
            this.Controls.Add(this.txtPF);
            this.Controls.Add(this.txtDA);
            this.Controls.Add(this.txtTA);
            this.Controls.Add(this.txtHRA);
            this.Controls.Add(this.txtBsalary);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtBsalary;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.TextBox txtDA;
        private System.Windows.Forms.TextBox txtPF;
        private System.Windows.Forms.TextBox txtGsalary;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnDisplay;
    }
}