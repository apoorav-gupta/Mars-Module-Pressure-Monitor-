namespace NASA_Life_Support_System
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
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.nValue = new System.Windows.Forms.Label();
            this.nAvgVal = new System.Windows.Forms.Label();
            this.nState = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textN = new System.Windows.Forms.TextBox();
            this.textC = new System.Windows.Forms.TextBox();
            this.textO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cState = new System.Windows.Forms.Label();
            this.cAvgVal = new System.Windows.Forms.Label();
            this.cValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.oState = new System.Windows.Forms.Label();
            this.oAvgVal = new System.Windows.Forms.Label();
            this.oValue = new System.Windows.Forms.Label();
            this.pressureVal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.nTarget = new System.Windows.Forms.TextBox();
            this.cTarget = new System.Windows.Forms.TextBox();
            this.oTarget = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lpState = new System.Windows.Forms.CheckBox();
            this.nMain = new System.Windows.Forms.Label();
            this.nBackup = new System.Windows.Forms.Label();
            this.cMain = new System.Windows.Forms.Label();
            this.cBackup = new System.Windows.Forms.Label();
            this.oMain = new System.Windows.Forms.Label();
            this.oBackup = new System.Windows.Forms.Label();
            this.rButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Clock
            // 
            this.Clock.Enabled = true;
            this.Clock.Interval = 500;
            this.Clock.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // nValue
            // 
            this.nValue.AutoSize = true;
            this.nValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nValue.Location = new System.Drawing.Point(44, 34);
            this.nValue.MinimumSize = new System.Drawing.Size(50, 0);
            this.nValue.Name = "nValue";
            this.nValue.Size = new System.Drawing.Size(50, 15);
            this.nValue.TabIndex = 0;
            this.nValue.Text = "nValue";
            this.nValue.Click += new System.EventHandler(this.label1_Click);
            // 
            // nAvgVal
            // 
            this.nAvgVal.AutoSize = true;
            this.nAvgVal.Location = new System.Drawing.Point(737, 320);
            this.nAvgVal.Name = "nAvgVal";
            this.nAvgVal.Size = new System.Drawing.Size(47, 13);
            this.nAvgVal.TabIndex = 1;
            this.nAvgVal.Text = "nAvgVal";
            this.nAvgVal.Visible = false;
            // 
            // nState
            // 
            this.nState.AutoSize = true;
            this.nState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nState.Location = new System.Drawing.Point(18, 201);
            this.nState.MinimumSize = new System.Drawing.Size(75, 0);
            this.nState.Name = "nState";
            this.nState.Size = new System.Drawing.Size(75, 15);
            this.nState.TabIndex = 2;
            this.nState.Text = "nState";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set Parameters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textN
            // 
            this.textN.Location = new System.Drawing.Point(707, 59);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(100, 20);
            this.textN.TabIndex = 4;
            this.textN.Text = "11.5";
            // 
            // textC
            // 
            this.textC.Location = new System.Drawing.Point(707, 116);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(100, 20);
            this.textC.TabIndex = 5;
            this.textC.Text = "0.1";
            // 
            // textO
            // 
            this.textO.Location = new System.Drawing.Point(707, 170);
            this.textO.Name = "textO";
            this.textO.Size = new System.Drawing.Size(100, 20);
            this.textO.TabIndex = 6;
            this.textO.Text = "3.2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(608, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nitrogen Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(608, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "CO2 Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Oxygen Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Current Nitrogen Level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Average Nitrogen Level";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nitrogen State";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(177, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "CO2 State";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(608, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Average CO2 Level";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(165, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Current CO2 Level";
            // 
            // cState
            // 
            this.cState.AutoSize = true;
            this.cState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cState.Location = new System.Drawing.Point(172, 201);
            this.cState.MinimumSize = new System.Drawing.Size(75, 0);
            this.cState.Name = "cState";
            this.cState.Size = new System.Drawing.Size(75, 15);
            this.cState.TabIndex = 15;
            this.cState.Text = "label10";
            // 
            // cAvgVal
            // 
            this.cAvgVal.AutoSize = true;
            this.cAvgVal.Location = new System.Drawing.Point(726, 302);
            this.cAvgVal.Name = "cAvgVal";
            this.cAvgVal.Size = new System.Drawing.Size(41, 13);
            this.cAvgVal.TabIndex = 14;
            this.cAvgVal.Text = "label11";
            this.cAvgVal.Visible = false;
            // 
            // cValue
            // 
            this.cValue.AutoSize = true;
            this.cValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cValue.Location = new System.Drawing.Point(185, 34);
            this.cValue.MinimumSize = new System.Drawing.Size(50, 0);
            this.cValue.Name = "cValue";
            this.cValue.Size = new System.Drawing.Size(50, 15);
            this.cValue.TabIndex = 13;
            this.cValue.Text = "label12";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(321, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Oxygen State";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Average Oxygen Level";
            this.label11.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(308, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Current Oxygen Level";
            // 
            // oState
            // 
            this.oState.AutoSize = true;
            this.oState.BackColor = System.Drawing.Color.Transparent;
            this.oState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.oState.Location = new System.Drawing.Point(324, 201);
            this.oState.MinimumSize = new System.Drawing.Size(75, 0);
            this.oState.Name = "oState";
            this.oState.Size = new System.Drawing.Size(75, 15);
            this.oState.TabIndex = 21;
            this.oState.Text = "oState";
            // 
            // oAvgVal
            // 
            this.oAvgVal.AutoSize = true;
            this.oAvgVal.Location = new System.Drawing.Point(725, 279);
            this.oAvgVal.Name = "oAvgVal";
            this.oAvgVal.Size = new System.Drawing.Size(59, 13);
            this.oAvgVal.TabIndex = 20;
            this.oAvgVal.Text = "oAvgValue";
            this.oAvgVal.Visible = false;
            // 
            // oValue
            // 
            this.oValue.AutoSize = true;
            this.oValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.oValue.Location = new System.Drawing.Point(337, 34);
            this.oValue.MinimumSize = new System.Drawing.Size(50, 0);
            this.oValue.Name = "oValue";
            this.oValue.Size = new System.Drawing.Size(50, 15);
            this.oValue.TabIndex = 19;
            this.oValue.Text = "oValue";
            // 
            // pressureVal
            // 
            this.pressureVal.AutoSize = true;
            this.pressureVal.BackColor = System.Drawing.Color.Transparent;
            this.pressureVal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pressureVal.Location = new System.Drawing.Point(487, 34);
            this.pressureVal.MinimumSize = new System.Drawing.Size(50, 0);
            this.pressureVal.Name = "pressureVal";
            this.pressureVal.Size = new System.Drawing.Size(50, 15);
            this.pressureVal.TabIndex = 25;
            this.pressureVal.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(470, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Total Pressure";
            // 
            // nTarget
            // 
            this.nTarget.Location = new System.Drawing.Point(19, 66);
            this.nTarget.Name = "nTarget";
            this.nTarget.Size = new System.Drawing.Size(100, 20);
            this.nTarget.TabIndex = 27;
            this.nTarget.Enter += new System.EventHandler(this.nTarget_Enter);
            // 
            // cTarget
            // 
            this.cTarget.Location = new System.Drawing.Point(159, 65);
            this.cTarget.Name = "cTarget";
            this.cTarget.Size = new System.Drawing.Size(100, 20);
            this.cTarget.TabIndex = 28;
            this.cTarget.Enter += new System.EventHandler(this.cTarget_Enter);
            // 
            // oTarget
            // 
            this.oTarget.Location = new System.Drawing.Point(311, 65);
            this.oTarget.Name = "oTarget";
            this.oTarget.Size = new System.Drawing.Size(100, 20);
            this.oTarget.TabIndex = 29;
            this.oTarget.Enter += new System.EventHandler(this.oTarget_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "Set Nitrogen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Set C02";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(324, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 32;
            this.button4.Text = "Set Oxygen";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lpState
            // 
            this.lpState.AutoSize = true;
            this.lpState.Location = new System.Drawing.Point(455, 177);
            this.lpState.Name = "lpState";
            this.lpState.Size = new System.Drawing.Size(107, 17);
            this.lpState.TabIndex = 33;
            this.lpState.Text = "Low Power State";
            this.lpState.UseVisualStyleBackColor = true;
            this.lpState.CheckedChanged += new System.EventHandler(this.lpState_CheckedChanged);
            // 
            // nMain
            // 
            this.nMain.AutoSize = true;
            this.nMain.Location = new System.Drawing.Point(26, 252);
            this.nMain.Name = "nMain";
            this.nMain.Size = new System.Drawing.Size(41, 13);
            this.nMain.TabIndex = 34;
            this.nMain.Text = "label13";
            // 
            // nBackup
            // 
            this.nBackup.AutoSize = true;
            this.nBackup.Location = new System.Drawing.Point(26, 275);
            this.nBackup.Name = "nBackup";
            this.nBackup.Size = new System.Drawing.Size(41, 13);
            this.nBackup.TabIndex = 35;
            this.nBackup.Text = "label15";
            // 
            // cMain
            // 
            this.cMain.AutoSize = true;
            this.cMain.Location = new System.Drawing.Point(180, 252);
            this.cMain.Name = "cMain";
            this.cMain.Size = new System.Drawing.Size(41, 13);
            this.cMain.TabIndex = 36;
            this.cMain.Text = "label16";
            // 
            // cBackup
            // 
            this.cBackup.AutoSize = true;
            this.cBackup.Location = new System.Drawing.Point(180, 275);
            this.cBackup.Name = "cBackup";
            this.cBackup.Size = new System.Drawing.Size(41, 13);
            this.cBackup.TabIndex = 37;
            this.cBackup.Text = "label17";
            // 
            // oMain
            // 
            this.oMain.AutoSize = true;
            this.oMain.Location = new System.Drawing.Point(332, 247);
            this.oMain.Name = "oMain";
            this.oMain.Size = new System.Drawing.Size(41, 13);
            this.oMain.TabIndex = 38;
            this.oMain.Text = "label18";
            // 
            // oBackup
            // 
            this.oBackup.AutoSize = true;
            this.oBackup.Location = new System.Drawing.Point(332, 275);
            this.oBackup.Name = "oBackup";
            this.oBackup.Size = new System.Drawing.Size(41, 13);
            this.oBackup.TabIndex = 39;
            this.oBackup.Text = "label19";
            // 
            // rButton
            // 
            this.rButton.Location = new System.Drawing.Point(455, 265);
            this.rButton.Name = "rButton";
            this.rButton.Size = new System.Drawing.Size(75, 23);
            this.rButton.TabIndex = 40;
            this.rButton.Text = "RESET";
            this.rButton.UseVisualStyleBackColor = true;
            this.rButton.Click += new System.EventHandler(this.rButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(654, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 13);
            this.label13.TabIndex = 41;
            this.label13.Text = "Test Parameters";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(596, -6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(2, 500);
            this.label15.TabIndex = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 342);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rButton);
            this.Controls.Add(this.oBackup);
            this.Controls.Add(this.oMain);
            this.Controls.Add(this.cBackup);
            this.Controls.Add(this.cMain);
            this.Controls.Add(this.nBackup);
            this.Controls.Add(this.nMain);
            this.Controls.Add(this.lpState);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.oTarget);
            this.Controls.Add(this.cTarget);
            this.Controls.Add(this.nTarget);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pressureVal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.oState);
            this.Controls.Add(this.oAvgVal);
            this.Controls.Add(this.oValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cState);
            this.Controls.Add(this.cAvgVal);
            this.Controls.Add(this.cValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textO);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nState);
            this.Controls.Add(this.nAvgVal);
            this.Controls.Add(this.nValue);
            this.Name = "Form1";
            this.Text = "Internal Pressure Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Label nValue;
        private System.Windows.Forms.Label nAvgVal;
        private System.Windows.Forms.Label nState;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.TextBox textO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cState;
        private System.Windows.Forms.Label cAvgVal;
        private System.Windows.Forms.Label cValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label oState;
        private System.Windows.Forms.Label oAvgVal;
        private System.Windows.Forms.Label oValue;
        private System.Windows.Forms.Label pressureVal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox nTarget;
        private System.Windows.Forms.TextBox cTarget;
        private System.Windows.Forms.TextBox oTarget;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox lpState;
        private System.Windows.Forms.Label nMain;
        private System.Windows.Forms.Label nBackup;
        private System.Windows.Forms.Label cMain;
        private System.Windows.Forms.Label cBackup;
        private System.Windows.Forms.Label oMain;
        private System.Windows.Forms.Label oBackup;
        private System.Windows.Forms.Button rButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
    }
}

