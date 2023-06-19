namespace Monthly_Savings_WF
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbFees = new System.Windows.Forms.TextBox();
            this.tbGrowth = new System.Windows.Forms.TextBox();
            this.tbPeriod = new System.Windows.Forms.TextBox();
            this.tbMonthlyDepo = new System.Windows.Forms.TextBox();
            this.tbInitialDepo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblFinalBalance = new System.Windows.Forms.Label();
            this.lblEarned = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculateSaving = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFees);
            this.groupBox1.Controls.Add(this.tbGrowth);
            this.groupBox1.Controls.Add(this.tbPeriod);
            this.groupBox1.Controls.Add(this.tbMonthlyDepo);
            this.groupBox1.Controls.Add(this.tbInitialDepo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 220);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saving plan";
            // 
            // tbFees
            // 
            this.tbFees.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbFees.Location = new System.Drawing.Point(170, 175);
            this.tbFees.Margin = new System.Windows.Forms.Padding(7);
            this.tbFees.Name = "tbFees";
            this.tbFees.Size = new System.Drawing.Size(130, 20);
            this.tbFees.TabIndex = 9;
            this.tbFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbGrowth
            // 
            this.tbGrowth.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbGrowth.Location = new System.Drawing.Point(170, 140);
            this.tbGrowth.Name = "tbGrowth";
            this.tbGrowth.Size = new System.Drawing.Size(130, 20);
            this.tbGrowth.TabIndex = 8;
            this.tbGrowth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbPeriod
            // 
            this.tbPeriod.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbPeriod.Location = new System.Drawing.Point(170, 105);
            this.tbPeriod.Name = "tbPeriod";
            this.tbPeriod.Size = new System.Drawing.Size(130, 20);
            this.tbPeriod.TabIndex = 7;
            this.tbPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMonthlyDepo
            // 
            this.tbMonthlyDepo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbMonthlyDepo.Location = new System.Drawing.Point(170, 70);
            this.tbMonthlyDepo.Name = "tbMonthlyDepo";
            this.tbMonthlyDepo.Size = new System.Drawing.Size(130, 20);
            this.tbMonthlyDepo.TabIndex = 6;
            this.tbMonthlyDepo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbInitialDepo
            // 
            this.tbInitialDepo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbInitialDepo.Location = new System.Drawing.Point(170, 35);
            this.tbInitialDepo.Margin = new System.Windows.Forms.Padding(5);
            this.tbInitialDepo.Name = "tbInitialDepo";
            this.tbInitialDepo.Size = new System.Drawing.Size(130, 20);
            this.tbInitialDepo.TabIndex = 5;
            this.tbInitialDepo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fees in %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Growth (or interest) in %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Period (years)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monthly deposit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial deposit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotalFees);
            this.groupBox2.Controls.Add(this.lblFinalBalance);
            this.groupBox2.Controls.Add(this.lblEarned);
            this.groupBox2.Controls.Add(this.lblPaid);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(13, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Future value";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblTotalFees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalFees.Location = new System.Drawing.Point(170, 140);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(130, 20);
            this.lblTotalFees.TabIndex = 7;
            this.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinalBalance
            // 
            this.lblFinalBalance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblFinalBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFinalBalance.Location = new System.Drawing.Point(170, 105);
            this.lblFinalBalance.Name = "lblFinalBalance";
            this.lblFinalBalance.Size = new System.Drawing.Size(130, 20);
            this.lblFinalBalance.TabIndex = 6;
            this.lblFinalBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEarned
            // 
            this.lblEarned.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblEarned.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEarned.Location = new System.Drawing.Point(170, 70);
            this.lblEarned.Name = "lblEarned";
            this.lblEarned.Size = new System.Drawing.Size(130, 20);
            this.lblEarned.TabIndex = 5;
            this.lblEarned.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaid
            // 
            this.lblPaid.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPaid.Location = new System.Drawing.Point(170, 35);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(130, 20);
            this.lblPaid.TabIndex = 4;
            this.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Total fees";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Final balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Amount earned";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Amount paid";
            // 
            // btnCalculateSaving
            // 
            this.btnCalculateSaving.Location = new System.Drawing.Point(120, 270);
            this.btnCalculateSaving.Name = "btnCalculateSaving";
            this.btnCalculateSaving.Size = new System.Drawing.Size(120, 30);
            this.btnCalculateSaving.TabIndex = 2;
            this.btnCalculateSaving.Text = "Calculate saving";
            this.btnCalculateSaving.UseVisualStyleBackColor = true;
            this.btnCalculateSaving.Click += new System.EventHandler(this.btnCalculateSaving_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 536);
            this.Controls.Add(this.btnCalculateSaving);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Saving calculator by Gyorgy Horak";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFees;
        private System.Windows.Forms.TextBox tbGrowth;
        private System.Windows.Forms.TextBox tbPeriod;
        private System.Windows.Forms.TextBox tbMonthlyDepo;
        private System.Windows.Forms.TextBox tbInitialDepo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalculateSaving;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblFinalBalance;
        private System.Windows.Forms.Label lblEarned;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

