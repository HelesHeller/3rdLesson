namespace _3rdLesson
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
            dateTimePicker1 = new DateTimePicker();
            radioButtonYears = new RadioButton();
            radioButtonMonths = new RadioButton();
            radioButtonDays = new RadioButton();
            radioButtonMinutes = new RadioButton();
            buttonCalculate = new Button();
            labelResult = new Label();
            radioButtonSeconds = new RadioButton();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(32, 64);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // radioButtonYears
            // 
            radioButtonYears.AutoSize = true;
            radioButtonYears.Location = new Point(412, 98);
            radioButtonYears.Name = "radioButtonYears";
            radioButtonYears.Size = new Size(52, 19);
            radioButtonYears.TabIndex = 1;
            radioButtonYears.TabStop = true;
            radioButtonYears.Text = "Years";
            radioButtonYears.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonths
            // 
            radioButtonMonths.AutoSize = true;
            radioButtonMonths.Location = new Point(412, 123);
            radioButtonMonths.Name = "radioButtonMonths";
            radioButtonMonths.Size = new Size(66, 19);
            radioButtonMonths.TabIndex = 2;
            radioButtonMonths.TabStop = true;
            radioButtonMonths.Text = "Months";
            radioButtonMonths.UseVisualStyleBackColor = true;
            // 
            // radioButtonDays
            // 
            radioButtonDays.AutoSize = true;
            radioButtonDays.Location = new Point(412, 148);
            radioButtonDays.Name = "radioButtonDays";
            radioButtonDays.Size = new Size(50, 19);
            radioButtonDays.TabIndex = 3;
            radioButtonDays.TabStop = true;
            radioButtonDays.Text = "Days";
            radioButtonDays.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinutes
            // 
            radioButtonMinutes.AutoSize = true;
            radioButtonMinutes.Location = new Point(412, 173);
            radioButtonMinutes.Name = "radioButtonMinutes";
            radioButtonMinutes.Size = new Size(68, 19);
            radioButtonMinutes.TabIndex = 4;
            radioButtonMinutes.TabStop = true;
            radioButtonMinutes.Text = "Minutes";
            radioButtonMinutes.UseVisualStyleBackColor = true;
            radioButtonMinutes.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(232, 273);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 23);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(32, 150);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(38, 15);
            labelResult.TabIndex = 6;
            labelResult.Text = "label1";
            // 
            // radioButtonSeconds
            // 
            radioButtonSeconds.AutoSize = true;
            radioButtonSeconds.Location = new Point(412, 198);
            radioButtonSeconds.Name = "radioButtonSeconds";
            radioButtonSeconds.Size = new Size(69, 19);
            radioButtonSeconds.TabIndex = 7;
            radioButtonSeconds.TabStop = true;
            radioButtonSeconds.Text = "Seconds";
            radioButtonSeconds.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 332);
            Controls.Add(radioButtonSeconds);
            Controls.Add(labelResult);
            Controls.Add(buttonCalculate);
            Controls.Add(radioButtonMinutes);
            Controls.Add(radioButtonDays);
            Controls.Add(radioButtonMonths);
            Controls.Add(radioButtonYears);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private RadioButton radioButtonYears;
        private RadioButton radioButtonMonths;
        private RadioButton radioButtonDays;
        private RadioButton radioButtonMinutes;
        private Button buttonCalculate;
        private Label labelResult;
        private RadioButton radioButtonSeconds;
    }
}