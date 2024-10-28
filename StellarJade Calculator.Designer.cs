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
            SuspendLayout();
            // 
            // lblDaysSelected
            // 
            lblDaysSelected.AutoSize = true;
            lblDaysSelected.Location = new Point(10, 105);
            lblDaysSelected.Name = "lblDaysSelected";
            lblDaysSelected.Size = new Size(82, 15);
            lblDaysSelected.TabIndex = 1;
            lblDaysSelected.Text = "Days Selected:";
            // 
            // lbljadesDaily
            // 
            lbljadesDaily.AutoSize = true;
            lbljadesDaily.Location = new Point(10, 169);
            lbljadesDaily.Name = "lbljadesDaily";
            lbljadesDaily.Size = new Size(102, 15);
            lbljadesDaily.TabIndex = 2;
            lbljadesDaily.Text = "Daily Stellar Jades:";
            // 
            // expressPass
            // 
            expressPass.AutoSize = true;
            expressPass.Location = new Point(10, 122);
            expressPass.Margin = new Padding(3, 2, 3, 2);
            expressPass.Name = "expressPass";
            expressPass.Size = new Size(134, 19);
            expressPass.TabIndex = 3;
            expressPass.Text = "Enable Express Pass?";
            expressPass.UseVisualStyleBackColor = true;
            expressPass.CheckedChanged += expressPass_CheckedChanged;
            // 
            // tbExpressDays
            // 
            tbExpressDays.Location = new Point(245, 120);
            tbExpressDays.Margin = new Padding(3, 2, 3, 2);
            tbExpressDays.Name = "tbExpressDays";
            tbExpressDays.Size = new Size(110, 23);
            tbExpressDays.TabIndex = 5;
            tbExpressDays.Visible = false;
            tbExpressDays.KeyPress += tbExpressDays_KeyPress;
            // 
            // lblExpressActive
            // 
            lblExpressActive.AutoSize = true;
            lblExpressActive.Location = new Point(162, 123);
            lblExpressActive.Name = "lblExpressActive";
            lblExpressActive.Size = new Size(71, 15);
            lblExpressActive.TabIndex = 6;
            lblExpressActive.Text = "Days Active:";
            lblExpressActive.Visible = false;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(10, 26);
            dateTimePickerStart.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(211, 23);
            dateTimePickerStart.TabIndex = 7;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(10, 78);
            dateTimePickerEnd.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(211, 23);
            dateTimePickerEnd.TabIndex = 8;
            dateTimePickerEnd.Value = new DateTime(2024, 10, 29, 0, 0, 0, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 8);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 9;
            label1.Text = "Starting Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 61);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 10;
            label2.Text = "End Date:";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(10, 145);
            calculateButton.Margin = new Padding(3, 2, 3, 2);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(211, 22);
            calculateButton.TabIndex = 12;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // lblSimUni
            // 
            lblSimUni.AutoSize = true;
            lblSimUni.Location = new Point(10, 184);
            lblSimUni.Name = "lblSimUni";
            lblSimUni.Size = new Size(218, 15);
            lblSimUni.TabIndex = 13;
            lblSimUni.Text = "Simulated Universe Weekly Stellar Jades:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Periodical Stellar Jade Calculator";
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
    }
}
