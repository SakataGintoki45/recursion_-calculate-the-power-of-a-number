namespace recursion__calculate_the_power_of_a_number
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
            txtBase = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtExponent = new TextBox();
            btnCalculate = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtBase
            // 
            txtBase.Font = new Font("Segoe UI", 15F);
            txtBase.Location = new Point(273, 86);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(206, 34);
            txtBase.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(354, 52);
            label1.Name = "label1";
            label1.Size = new Size(51, 28);
            label1.TabIndex = 1;
            label1.Text = "Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(334, 153);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 3;
            label2.Text = "Exponent";
            // 
            // txtExponent
            // 
            txtExponent.Font = new Font("Segoe UI", 15F);
            txtExponent.Location = new Point(273, 184);
            txtExponent.Name = "txtExponent";
            txtExponent.Size = new Size(206, 34);
            txtExponent.TabIndex = 2;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(334, 237);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(95, 30);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.BackColor = Color.Transparent;
            lblResult.Font = new Font("Segoe UI", 15F);
            lblResult.Location = new Point(282, 333);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 28);
            lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(label2);
            Controls.Add(txtExponent);
            Controls.Add(label1);
            Controls.Add(txtBase);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBase;
        private Label label1;
        private Label label2;
        private TextBox txtExponent;
        private Button btnCalculate;
        private Label lblResult;
    }
}
