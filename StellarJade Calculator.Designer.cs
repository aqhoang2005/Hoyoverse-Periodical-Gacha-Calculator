namespace test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblDaysSelected = new Label();
            lbljadesDaily = new Label();
            expressPass = new CheckBox();
            tbExpressDays = new TextBox();
            lblExpressActive = new Label();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            calculateButton = new Button();
            lblSimUni = new Label();
            helpButton = new Button();
            lblTotalYield = new Label();
            onHandCheck = new CheckBox();
            lblJadesOnHand = new Label();
            tbJadesOnHand = new TextBox();
            SuspendLayout();
            // 
            // lblDaysSelected
            // 
            lblDaysSelected.AutoSize = true;
            lblDaysSelected.Location = new Point(11, 140);
            lblDaysSelected.Name = "lblDaysSelected";
            lblDaysSelected.Size = new Size(105, 20);
            lblDaysSelected.TabIndex = 1;
            lblDaysSelected.Text = "Days Selected:";
            // 
            // lbljadesDaily
            // 
            lbljadesDaily.AutoSize = true;
            lbljadesDaily.Location = new Point(11, 225);
            lbljadesDaily.Name = "lbljadesDaily";
            lbljadesDaily.Size = new Size(132, 20);
            lbljadesDaily.TabIndex = 2;
            lbljadesDaily.Text = "Daily Stellar Jades:";
            // 
            // expressPass
            // 
            expressPass.AutoSize = true;
            expressPass.Location = new Point(11, 163);
            expressPass.Name = "expressPass";
            expressPass.Size = new Size(167, 24);
            expressPass.TabIndex = 3;
            expressPass.Text = "Enable Express Pass?";
            expressPass.UseVisualStyleBackColor = true;
            expressPass.CheckedChanged += expressPass_CheckedChanged;
            // 
            // tbExpressDays
            // 
            tbExpressDays.Location = new Point(280, 160);
            tbExpressDays.Name = "tbExpressDays";
            tbExpressDays.Size = new Size(125, 27);
            tbExpressDays.TabIndex = 5;
            tbExpressDays.Visible = false;
            tbExpressDays.KeyPress += tbExpressDays_KeyPress;
            // 
            // lblExpressActive
            // 
            lblExpressActive.AutoSize = true;
            lblExpressActive.Location = new Point(185, 164);
            lblExpressActive.Name = "lblExpressActive";
            lblExpressActive.Size = new Size(89, 20);
            lblExpressActive.TabIndex = 6;
            lblExpressActive.Text = "Days Active:";
            lblExpressActive.Visible = false;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(11, 35);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(241, 27);
            dateTimePickerStart.TabIndex = 7;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(11, 104);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(241, 27);
            dateTimePickerEnd.TabIndex = 8;
            dateTimePickerEnd.Value = new DateTime(2024, 10, 29, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 11);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 9;
            label1.Text = "Starting Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 81);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 10;
            label2.Text = "End Date:";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(11, 193);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(241, 29);
            calculateButton.TabIndex = 12;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // lblSimUni
            // 
            lblSimUni.AutoSize = true;
            lblSimUni.Location = new Point(11, 245);
            lblSimUni.Name = "lblSimUni";
            lblSimUni.Size = new Size(276, 20);
            lblSimUni.TabIndex = 13;
            lblSimUni.Text = "Simulated Universe Weekly Stellar Jades:";
            // 
            // helpButton
            // 
            helpButton.Location = new Point(11, 5);
            helpButton.Margin = new Padding(3, 4, 3, 4);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(22, 25);
            helpButton.TabIndex = 14;
            helpButton.Text = "?";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // lblTotalYield
            // 
            lblTotalYield.AutoSize = true;
            lblTotalYield.Location = new Point(11, 354);
            lblTotalYield.Name = "lblTotalYield";
            lblTotalYield.Size = new Size(202, 20);
            lblTotalYield.TabIndex = 15;
            lblTotalYield.Text = "Approximate Obtained Total:";
            // 
            // onHandCheck
            // 
            onHandCheck.AutoSize = true;
            onHandCheck.Location = new Point(11, 272);
            onHandCheck.Name = "onHandCheck";
            onHandCheck.Size = new Size(144, 24);
            onHandCheck.TabIndex = 16;
            onHandCheck.Text = "Include On-Hand";
            onHandCheck.UseVisualStyleBackColor = true;
            onHandCheck.CheckedChanged += onHandCheck_CheckedChanged;
            // 
            // lblJadesOnHand
            // 
            lblJadesOnHand.AutoSize = true;
            lblJadesOnHand.Location = new Point(185, 272);
            lblJadesOnHand.Name = "lblJadesOnHand";
            lblJadesOnHand.Size = new Size(157, 20);
            lblJadesOnHand.TabIndex = 17;
            lblJadesOnHand.Text = "Stellar Jades On Hand:";
            lblJadesOnHand.Visible = false;
            // 
            // tbJadesOnHand
            // 
            tbJadesOnHand.Location = new Point(348, 269);
            tbJadesOnHand.Name = "tbJadesOnHand";
            tbJadesOnHand.Size = new Size(125, 27);
            tbJadesOnHand.TabIndex = 18;
            tbJadesOnHand.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(tbJadesOnHand);
            Controls.Add(lblJadesOnHand);
            Controls.Add(onHandCheck);
            Controls.Add(lblTotalYield);
            Controls.Add(helpButton);
            Controls.Add(lblSimUni);
            Controls.Add(calculateButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(lblExpressActive);
            Controls.Add(tbExpressDays);
            Controls.Add(expressPass);
            Controls.Add(lbljadesDaily);
            Controls.Add(lblDaysSelected);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Hoyoverse Periodical Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDaysSelected;
        private Label lbljadesDaily;
        private CheckBox expressPass;
        private TextBox tbExpressDays;
        private Label lblExpressActive;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label label1;
        private Label label2;
        private Button calculateButton;
        private Label lblSimUni;
        private Button helpButton;
        private Label lblTotalYield;
        private CheckBox onHandCheck;
        private Label lblJadesOnHand;
        private TextBox tbJadesOnHand;
    }
}
