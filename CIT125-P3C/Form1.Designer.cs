namespace CIT125_P3C
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
            this.lblMeter1 = new System.Windows.Forms.Label();
            this.lblMeter2 = new System.Windows.Forms.Label();
            this.lblMeter3 = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtbxMeter1Start = new System.Windows.Forms.TextBox();
            this.txtbxMeter1End = new System.Windows.Forms.TextBox();
            this.txtbxMeter2Start = new System.Windows.Forms.TextBox();
            this.txtbxMeter2End = new System.Windows.Forms.TextBox();
            this.txtbxMeter3Start = new System.Windows.Forms.TextBox();
            this.txtbxMeter3End = new System.Windows.Forms.TextBox();
            this.lblKWHUsed = new System.Windows.Forms.Label();
            this.lblMeter1KWHUsed = new System.Windows.Forms.Label();
            this.lblMeter2KWHUsed = new System.Windows.Forms.Label();
            this.lblMeter3KWHUsed = new System.Windows.Forms.Label();
            this.lblPriorBalance = new System.Windows.Forms.Label();
            this.txtbxPriorBalance = new System.Windows.Forms.TextBox();
            this.lblMeterCount = new System.Windows.Forms.Label();
            this.lblTotalKWH = new System.Windows.Forms.Label();
            this.lblTotalKWHResult = new System.Windows.Forms.Label();
            this.txtbxMeterCount = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReCalc = new System.Windows.Forms.Button();
            this.lblKWHCharge = new System.Windows.Forms.Label();
            this.lblMeterCharge = new System.Windows.Forms.Label();
            this.lblAfterHours = new System.Windows.Forms.Label();
            this.lblMissedAppt = new System.Windows.Forms.Label();
            this.lblKWHChargeResult = new System.Windows.Forms.Label();
            this.lblMeterChargeResult = new System.Windows.Forms.Label();
            this.lblAfterHoursResult = new System.Windows.Forms.Label();
            this.lblMissedApptResult = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRehabProgram = new System.Windows.Forms.Label();
            this.chkBoxAfterHoursChg = new System.Windows.Forms.CheckBox();
            this.chkBoxApptChg = new System.Windows.Forms.CheckBox();
            this.RadioRehabYes = new System.Windows.Forms.RadioButton();
            this.RadioRehabNo = new System.Windows.Forms.RadioButton();
            this.lblErrorsHeader = new System.Windows.Forms.Label();
            this.lblRehabDiscount = new System.Windows.Forms.Label();
            this.lblRehabDiscountResult = new System.Windows.Forms.Label();
            this.lblKWHDiscountResult = new System.Windows.Forms.Label();
            this.lblKWHDiscount = new System.Windows.Forms.Label();
            this.lblCharges = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMeter1
            // 
            this.lblMeter1.AutoSize = true;
            this.lblMeter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeter1.Location = new System.Drawing.Point(20, 45);
            this.lblMeter1.Name = "lblMeter1";
            this.lblMeter1.Size = new System.Drawing.Size(78, 25);
            this.lblMeter1.TabIndex = 0;
            this.lblMeter1.Text = "Meter 1";
            // 
            // lblMeter2
            // 
            this.lblMeter2.AutoSize = true;
            this.lblMeter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeter2.Location = new System.Drawing.Point(20, 80);
            this.lblMeter2.Name = "lblMeter2";
            this.lblMeter2.Size = new System.Drawing.Size(78, 25);
            this.lblMeter2.TabIndex = 1;
            this.lblMeter2.Text = "Meter 2";
            // 
            // lblMeter3
            // 
            this.lblMeter3.AutoSize = true;
            this.lblMeter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeter3.Location = new System.Drawing.Point(20, 115);
            this.lblMeter3.Name = "lblMeter3";
            this.lblMeter3.Size = new System.Drawing.Size(78, 25);
            this.lblMeter3.TabIndex = 2;
            this.lblMeter3.Text = "Meter 3";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(103, 9);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(79, 25);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Starting";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(215, 9);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(73, 25);
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "Ending";
            // 
            // txtbxMeter1Start
            // 
            this.txtbxMeter1Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMeter1Start.Location = new System.Drawing.Point(104, 45);
            this.txtbxMeter1Start.Name = "txtbxMeter1Start";
            this.txtbxMeter1Start.Size = new System.Drawing.Size(100, 30);
            this.txtbxMeter1Start.TabIndex = 5;
            this.txtbxMeter1Start.Text = "0";
            // 
            // txtbxMeter1End
            // 
            this.txtbxMeter1End.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMeter1End.Location = new System.Drawing.Point(220, 42);
            this.txtbxMeter1End.Name = "txtbxMeter1End";
            this.txtbxMeter1End.Size = new System.Drawing.Size(100, 30);
            this.txtbxMeter1End.TabIndex = 6;
            this.txtbxMeter1End.Text = "0";
            // 
            // txtbxMeter2Start
            // 
            this.txtbxMeter2Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMeter2Start.Location = new System.Drawing.Point(104, 80);
            this.txtbxMeter2Start.Name = "txtbxMeter2Start";
            this.txtbxMeter2Start.Size = new System.Drawing.Size(100, 30);
            this.txtbxMeter2Start.TabIndex = 7;
            this.txtbxMeter2Start.Text = "0";
            // 
            // txtbxMeter2End
            // 
            this.txtbxMeter2End.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMeter2End.Location = new System.Drawing.Point(220, 79);
            this.txtbxMeter2End.Name = "txtbxMeter2End";
            this.txtbxMeter2End.Size = new System.Drawing.Size(100, 30);
            this.txtbxMeter2End.TabIndex = 8;
            this.txtbxMeter2End.Text = "0";
            // 
            // txtbxMeter3Start
            // 
            this.txtbxMeter3Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMeter3Start.Location = new System.Drawing.Point(104, 116);
            this.txtbxMeter3Start.Name = "txtbxMeter3Start";
            this.txtbxMeter3Start.Size = new System.Drawing.Size(100, 30);
            this.txtbxMeter3Start.TabIndex = 9;
            this.txtbxMeter3Start.Text = "0";
            // 
            // txtbxMeter3End
            // 
            this.txtbxMeter3End.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMeter3End.Location = new System.Drawing.Point(220, 115);
            this.txtbxMeter3End.Name = "txtbxMeter3End";
            this.txtbxMeter3End.Size = new System.Drawing.Size(100, 30);
            this.txtbxMeter3End.TabIndex = 10;
            this.txtbxMeter3End.Text = "0";
            // 
            // lblKWHUsed
            // 
            this.lblKWHUsed.AutoSize = true;
            this.lblKWHUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKWHUsed.Location = new System.Drawing.Point(355, 9);
            this.lblKWHUsed.Name = "lblKWHUsed";
            this.lblKWHUsed.Size = new System.Drawing.Size(111, 25);
            this.lblKWHUsed.TabIndex = 11;
            this.lblKWHUsed.Text = "KWH Used";
            // 
            // lblMeter1KWHUsed
            // 
            this.lblMeter1KWHUsed.AutoSize = true;
            this.lblMeter1KWHUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeter1KWHUsed.Location = new System.Drawing.Point(355, 45);
            this.lblMeter1KWHUsed.Name = "lblMeter1KWHUsed";
            this.lblMeter1KWHUsed.Size = new System.Drawing.Size(50, 25);
            this.lblMeter1KWHUsed.TabIndex = 12;
            this.lblMeter1KWHUsed.Text = "0.00";
            // 
            // lblMeter2KWHUsed
            // 
            this.lblMeter2KWHUsed.AutoSize = true;
            this.lblMeter2KWHUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeter2KWHUsed.Location = new System.Drawing.Point(355, 80);
            this.lblMeter2KWHUsed.Name = "lblMeter2KWHUsed";
            this.lblMeter2KWHUsed.Size = new System.Drawing.Size(50, 25);
            this.lblMeter2KWHUsed.TabIndex = 13;
            this.lblMeter2KWHUsed.Text = "0.00";
            // 
            // lblMeter3KWHUsed
            // 
            this.lblMeter3KWHUsed.AutoSize = true;
            this.lblMeter3KWHUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeter3KWHUsed.Location = new System.Drawing.Point(355, 115);
            this.lblMeter3KWHUsed.Name = "lblMeter3KWHUsed";
            this.lblMeter3KWHUsed.Size = new System.Drawing.Size(50, 25);
            this.lblMeter3KWHUsed.TabIndex = 14;
            this.lblMeter3KWHUsed.Text = "0.00";
            // 
            // lblPriorBalance
            // 
            this.lblPriorBalance.AutoSize = true;
            this.lblPriorBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriorBalance.Location = new System.Drawing.Point(499, 27);
            this.lblPriorBalance.Name = "lblPriorBalance";
            this.lblPriorBalance.Size = new System.Drawing.Size(128, 25);
            this.lblPriorBalance.TabIndex = 15;
            this.lblPriorBalance.Text = "Prior Balance";
            // 
            // txtbxPriorBalance
            // 
            this.txtbxPriorBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPriorBalance.Location = new System.Drawing.Point(633, 24);
            this.txtbxPriorBalance.Name = "txtbxPriorBalance";
            this.txtbxPriorBalance.Size = new System.Drawing.Size(89, 30);
            this.txtbxPriorBalance.TabIndex = 16;
            this.txtbxPriorBalance.Text = "0";
            // 
            // lblMeterCount
            // 
            this.lblMeterCount.AutoSize = true;
            this.lblMeterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeterCount.Location = new System.Drawing.Point(554, 121);
            this.lblMeterCount.Name = "lblMeterCount";
            this.lblMeterCount.Size = new System.Drawing.Size(120, 25);
            this.lblMeterCount.TabIndex = 17;
            this.lblMeterCount.Text = "Meter Count";
            // 
            // lblTotalKWH
            // 
            this.lblTotalKWH.AutoSize = true;
            this.lblTotalKWH.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKWH.Location = new System.Drawing.Point(235, 179);
            this.lblTotalKWH.Name = "lblTotalKWH";
            this.lblTotalKWH.Size = new System.Drawing.Size(109, 25);
            this.lblTotalKWH.TabIndex = 18;
            this.lblTotalKWH.Text = "Total KWH";
            // 
            // lblTotalKWHResult
            // 
            this.lblTotalKWHResult.AutoSize = true;
            this.lblTotalKWHResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalKWHResult.Location = new System.Drawing.Point(355, 179);
            this.lblTotalKWHResult.Name = "lblTotalKWHResult";
            this.lblTotalKWHResult.Size = new System.Drawing.Size(50, 25);
            this.lblTotalKWHResult.TabIndex = 19;
            this.lblTotalKWHResult.Text = "0.00";
            // 
            // txtbxMeterCount
            // 
            this.txtbxMeterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMeterCount.Location = new System.Drawing.Point(680, 118);
            this.txtbxMeterCount.Name = "txtbxMeterCount";
            this.txtbxMeterCount.Size = new System.Drawing.Size(60, 30);
            this.txtbxMeterCount.TabIndex = 20;
            this.txtbxMeterCount.Text = "0";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(217, 542);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 74);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReCalc
            // 
            this.btnReCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReCalc.Location = new System.Drawing.Point(30, 622);
            this.btnReCalc.Name = "btnReCalc";
            this.btnReCalc.Size = new System.Drawing.Size(314, 74);
            this.btnReCalc.TabIndex = 24;
            this.btnReCalc.Text = "Recalculate";
            this.btnReCalc.UseVisualStyleBackColor = true;
            this.btnReCalc.Click += new System.EventHandler(this.btnReCalc_Click);
            // 
            // lblKWHCharge
            // 
            this.lblKWHCharge.AutoSize = true;
            this.lblKWHCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKWHCharge.Location = new System.Drawing.Point(524, 228);
            this.lblKWHCharge.Name = "lblKWHCharge";
            this.lblKWHCharge.Size = new System.Drawing.Size(130, 25);
            this.lblKWHCharge.TabIndex = 25;
            this.lblKWHCharge.Text = "KWH Charge";
            // 
            // lblMeterCharge
            // 
            this.lblMeterCharge.AutoSize = true;
            this.lblMeterCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeterCharge.Location = new System.Drawing.Point(524, 333);
            this.lblMeterCharge.Name = "lblMeterCharge";
            this.lblMeterCharge.Size = new System.Drawing.Size(132, 25);
            this.lblMeterCharge.TabIndex = 26;
            this.lblMeterCharge.Text = "Meter Charge";
            // 
            // lblAfterHours
            // 
            this.lblAfterHours.AutoSize = true;
            this.lblAfterHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfterHours.Location = new System.Drawing.Point(524, 371);
            this.lblAfterHours.Name = "lblAfterHours";
            this.lblAfterHours.Size = new System.Drawing.Size(110, 25);
            this.lblAfterHours.TabIndex = 27;
            this.lblAfterHours.Text = "After Hours";
            // 
            // lblMissedAppt
            // 
            this.lblMissedAppt.AutoSize = true;
            this.lblMissedAppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissedAppt.Location = new System.Drawing.Point(524, 411);
            this.lblMissedAppt.Name = "lblMissedAppt";
            this.lblMissedAppt.Size = new System.Drawing.Size(126, 25);
            this.lblMissedAppt.TabIndex = 28;
            this.lblMissedAppt.Text = "Missed Appt.";
            // 
            // lblKWHChargeResult
            // 
            this.lblKWHChargeResult.AutoSize = true;
            this.lblKWHChargeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKWHChargeResult.Location = new System.Drawing.Point(680, 228);
            this.lblKWHChargeResult.Name = "lblKWHChargeResult";
            this.lblKWHChargeResult.Size = new System.Drawing.Size(61, 25);
            this.lblKWHChargeResult.TabIndex = 29;
            this.lblKWHChargeResult.Text = "$0.00";
            // 
            // lblMeterChargeResult
            // 
            this.lblMeterChargeResult.AutoSize = true;
            this.lblMeterChargeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMeterChargeResult.Location = new System.Drawing.Point(680, 332);
            this.lblMeterChargeResult.Name = "lblMeterChargeResult";
            this.lblMeterChargeResult.Size = new System.Drawing.Size(61, 25);
            this.lblMeterChargeResult.TabIndex = 30;
            this.lblMeterChargeResult.Text = "$0.00";
            // 
            // lblAfterHoursResult
            // 
            this.lblAfterHoursResult.AutoSize = true;
            this.lblAfterHoursResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAfterHoursResult.Location = new System.Drawing.Point(680, 370);
            this.lblAfterHoursResult.Name = "lblAfterHoursResult";
            this.lblAfterHoursResult.Size = new System.Drawing.Size(61, 25);
            this.lblAfterHoursResult.TabIndex = 31;
            this.lblAfterHoursResult.Text = "$0.00";
            // 
            // lblMissedApptResult
            // 
            this.lblMissedApptResult.AutoSize = true;
            this.lblMissedApptResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMissedApptResult.Location = new System.Drawing.Point(680, 410);
            this.lblMissedApptResult.Name = "lblMissedApptResult";
            this.lblMissedApptResult.Size = new System.Drawing.Size(61, 25);
            this.lblMissedApptResult.TabIndex = 32;
            this.lblMissedApptResult.Text = "$0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(390, 601);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(202, 46);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "Total Due";
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.AutoSize = true;
            this.lblTotalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResult.Location = new System.Drawing.Point(598, 601);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(124, 46);
            this.lblTotalResult.TabIndex = 34;
            this.lblTotalResult.Text = "$0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 35;
            // 
            // lblRehabProgram
            // 
            this.lblRehabProgram.AutoSize = true;
            this.lblRehabProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRehabProgram.Location = new System.Drawing.Point(291, 395);
            this.lblRehabProgram.Name = "lblRehabProgram";
            this.lblRehabProgram.Size = new System.Drawing.Size(143, 24);
            this.lblRehabProgram.TabIndex = 36;
            this.lblRehabProgram.Text = "Rehab Program";
            // 
            // chkBoxAfterHoursChg
            // 
            this.chkBoxAfterHoursChg.AutoSize = true;
            this.chkBoxAfterHoursChg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxAfterHoursChg.Location = new System.Drawing.Point(295, 254);
            this.chkBoxAfterHoursChg.Name = "chkBoxAfterHoursChg";
            this.chkBoxAfterHoursChg.Size = new System.Drawing.Size(190, 28);
            this.chkBoxAfterHoursChg.TabIndex = 37;
            this.chkBoxAfterHoursChg.Text = "After Hours Charge";
            this.chkBoxAfterHoursChg.UseVisualStyleBackColor = true;
            this.chkBoxAfterHoursChg.CheckedChanged += new System.EventHandler(this.chkBoxAfterHoursChg_CheckedChanged);
            // 
            // chkBoxApptChg
            // 
            this.chkBoxApptChg.AutoSize = true;
            this.chkBoxApptChg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxApptChg.Location = new System.Drawing.Point(295, 292);
            this.chkBoxApptChg.Name = "chkBoxApptChg";
            this.chkBoxApptChg.Size = new System.Drawing.Size(200, 28);
            this.chkBoxApptChg.TabIndex = 38;
            this.chkBoxApptChg.Text = "Missed Appt Charge";
            this.chkBoxApptChg.UseVisualStyleBackColor = true;
            this.chkBoxApptChg.CheckedChanged += new System.EventHandler(this.chkBoxApptChg_CheckedChanged);
            // 
            // RadioRehabYes
            // 
            this.RadioRehabYes.AutoSize = true;
            this.RadioRehabYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioRehabYes.Location = new System.Drawing.Point(295, 435);
            this.RadioRehabYes.Name = "RadioRehabYes";
            this.RadioRehabYes.Size = new System.Drawing.Size(60, 28);
            this.RadioRehabYes.TabIndex = 39;
            this.RadioRehabYes.TabStop = true;
            this.RadioRehabYes.Text = "Yes";
            this.RadioRehabYes.UseVisualStyleBackColor = true;
            this.RadioRehabYes.CheckedChanged += new System.EventHandler(this.RadioRehabYes_CheckedChanged);
            // 
            // RadioRehabNo
            // 
            this.RadioRehabNo.AutoSize = true;
            this.RadioRehabNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioRehabNo.Location = new System.Drawing.Point(295, 465);
            this.RadioRehabNo.Name = "RadioRehabNo";
            this.RadioRehabNo.Size = new System.Drawing.Size(53, 28);
            this.RadioRehabNo.TabIndex = 40;
            this.RadioRehabNo.TabStop = true;
            this.RadioRehabNo.Text = "No";
            this.RadioRehabNo.UseVisualStyleBackColor = true;
            this.RadioRehabNo.CheckedChanged += new System.EventHandler(this.RadioRehabNo_CheckedChanged);
            // 
            // lblErrorsHeader
            // 
            this.lblErrorsHeader.AutoSize = true;
            this.lblErrorsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorsHeader.Location = new System.Drawing.Point(25, 228);
            this.lblErrorsHeader.Name = "lblErrorsHeader";
            this.lblErrorsHeader.Size = new System.Drawing.Size(70, 25);
            this.lblErrorsHeader.TabIndex = 41;
            this.lblErrorsHeader.Text = "Errors";
            // 
            // lblRehabDiscount
            // 
            this.lblRehabDiscount.AutoSize = true;
            this.lblRehabDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRehabDiscount.Location = new System.Drawing.Point(524, 478);
            this.lblRehabDiscount.Name = "lblRehabDiscount";
            this.lblRehabDiscount.Size = new System.Drawing.Size(150, 25);
            this.lblRehabDiscount.TabIndex = 42;
            this.lblRehabDiscount.Text = "Rehab Discount";
            // 
            // lblRehabDiscountResult
            // 
            this.lblRehabDiscountResult.AutoSize = true;
            this.lblRehabDiscountResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRehabDiscountResult.Location = new System.Drawing.Point(680, 478);
            this.lblRehabDiscountResult.Name = "lblRehabDiscountResult";
            this.lblRehabDiscountResult.Size = new System.Drawing.Size(61, 25);
            this.lblRehabDiscountResult.TabIndex = 43;
            this.lblRehabDiscountResult.Text = "$0.00";
            // 
            // lblKWHDiscountResult
            // 
            this.lblKWHDiscountResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.lblKWHDiscountResult.AutoSize = true;
            this.lblKWHDiscountResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKWHDiscountResult.Location = new System.Drawing.Point(680, 266);
            this.lblKWHDiscountResult.Name = "lblKWHDiscountResult";
            this.lblKWHDiscountResult.Size = new System.Drawing.Size(61, 25);
            this.lblKWHDiscountResult.TabIndex = 45;
            this.lblKWHDiscountResult.Text = "$0.00";
            // 
            // lblKWHDiscount
            // 
            this.lblKWHDiscount.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.lblKWHDiscount.AutoSize = true;
            this.lblKWHDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKWHDiscount.Location = new System.Drawing.Point(524, 266);
            this.lblKWHDiscount.Name = "lblKWHDiscount";
            this.lblKWHDiscount.Size = new System.Drawing.Size(141, 25);
            this.lblKWHDiscount.TabIndex = 44;
            this.lblKWHDiscount.Text = "KWH Discount";
            // 
            // lblCharges
            // 
            this.lblCharges.AutoSize = true;
            this.lblCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharges.Location = new System.Drawing.Point(511, 179);
            this.lblCharges.Name = "lblCharges";
            this.lblCharges.Size = new System.Drawing.Size(87, 25);
            this.lblCharges.TabIndex = 46;
            this.lblCharges.Text = "Charges";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(26, 293);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(170, 20);
            this.lblError.TabIndex = 47;
            this.lblError.Text = "temp error message lbl";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 757);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblCharges);
            this.Controls.Add(this.lblKWHDiscountResult);
            this.Controls.Add(this.lblKWHDiscount);
            this.Controls.Add(this.lblRehabDiscountResult);
            this.Controls.Add(this.lblRehabDiscount);
            this.Controls.Add(this.lblErrorsHeader);
            this.Controls.Add(this.RadioRehabNo);
            this.Controls.Add(this.RadioRehabYes);
            this.Controls.Add(this.chkBoxApptChg);
            this.Controls.Add(this.chkBoxAfterHoursChg);
            this.Controls.Add(this.lblRehabProgram);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalResult);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMissedApptResult);
            this.Controls.Add(this.lblAfterHoursResult);
            this.Controls.Add(this.lblMeterChargeResult);
            this.Controls.Add(this.lblKWHChargeResult);
            this.Controls.Add(this.lblMissedAppt);
            this.Controls.Add(this.lblAfterHours);
            this.Controls.Add(this.lblMeterCharge);
            this.Controls.Add(this.lblKWHCharge);
            this.Controls.Add(this.btnReCalc);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtbxMeterCount);
            this.Controls.Add(this.lblTotalKWHResult);
            this.Controls.Add(this.lblTotalKWH);
            this.Controls.Add(this.lblMeterCount);
            this.Controls.Add(this.txtbxPriorBalance);
            this.Controls.Add(this.lblPriorBalance);
            this.Controls.Add(this.lblMeter3KWHUsed);
            this.Controls.Add(this.lblMeter2KWHUsed);
            this.Controls.Add(this.lblMeter1KWHUsed);
            this.Controls.Add(this.lblKWHUsed);
            this.Controls.Add(this.txtbxMeter3End);
            this.Controls.Add(this.txtbxMeter3Start);
            this.Controls.Add(this.txtbxMeter2End);
            this.Controls.Add(this.txtbxMeter2Start);
            this.Controls.Add(this.txtbxMeter1End);
            this.Controls.Add(this.txtbxMeter1Start);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblMeter3);
            this.Controls.Add(this.lblMeter2);
            this.Controls.Add(this.lblMeter1);
            this.Name = "Form1";
            this.Text = "Delinquent Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMeter1;
        private System.Windows.Forms.Label lblMeter2;
        private System.Windows.Forms.Label lblMeter3;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtbxMeter1Start;
        private System.Windows.Forms.TextBox txtbxMeter1End;
        private System.Windows.Forms.TextBox txtbxMeter2Start;
        private System.Windows.Forms.TextBox txtbxMeter2End;
        private System.Windows.Forms.TextBox txtbxMeter3Start;
        private System.Windows.Forms.TextBox txtbxMeter3End;
        private System.Windows.Forms.Label lblKWHUsed;
        private System.Windows.Forms.Label lblMeter1KWHUsed;
        private System.Windows.Forms.Label lblMeter2KWHUsed;
        private System.Windows.Forms.Label lblMeter3KWHUsed;
        private System.Windows.Forms.Label lblPriorBalance;
        private System.Windows.Forms.TextBox txtbxPriorBalance;
        private System.Windows.Forms.Label lblMeterCount;
        private System.Windows.Forms.Label lblTotalKWH;
        private System.Windows.Forms.Label lblTotalKWHResult;
        private System.Windows.Forms.TextBox txtbxMeterCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReCalc;
        private System.Windows.Forms.Label lblKWHCharge;
        private System.Windows.Forms.Label lblMeterCharge;
        private System.Windows.Forms.Label lblAfterHours;
        private System.Windows.Forms.Label lblMissedAppt;
        private System.Windows.Forms.Label lblKWHChargeResult;
        private System.Windows.Forms.Label lblMeterChargeResult;
        private System.Windows.Forms.Label lblAfterHoursResult;
        private System.Windows.Forms.Label lblMissedApptResult;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRehabProgram;
        private System.Windows.Forms.CheckBox chkBoxAfterHoursChg;
        private System.Windows.Forms.CheckBox chkBoxApptChg;
        private System.Windows.Forms.RadioButton RadioRehabYes;
        private System.Windows.Forms.RadioButton RadioRehabNo;
        private System.Windows.Forms.Label lblErrorsHeader;
        private System.Windows.Forms.Label lblRehabDiscount;
        private System.Windows.Forms.Label lblRehabDiscountResult;
        private System.Windows.Forms.Label lblKWHDiscountResult;
        private System.Windows.Forms.Label lblKWHDiscount;
        private System.Windows.Forms.Label lblCharges;
        private System.Windows.Forms.Label lblError;
    }
}

