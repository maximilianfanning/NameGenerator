namespace NameGeneratorInterface
{
    partial class Interface
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
            this.Execute_BTN = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.minLengthInput = new System.Windows.Forms.TextBox();
            this.maxLengthInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Execute_BTN
            // 
            this.Execute_BTN.Location = new System.Drawing.Point(375, 303);
            this.Execute_BTN.Name = "Execute_BTN";
            this.Execute_BTN.Size = new System.Drawing.Size(75, 23);
            this.Execute_BTN.TabIndex = 0;
            this.Execute_BTN.Text = "Go!";
            this.Execute_BTN.UseVisualStyleBackColor = true;
            this.Execute_BTN.Click += new System.EventHandler(this.Execute_BTN_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ResultLabel.Location = new System.Drawing.Point(391, 155);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(35, 20);
            this.ResultLabel.TabIndex = 1;
            this.ResultLabel.Text = "Null";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLengthInput
            // 
            this.minLengthInput.Location = new System.Drawing.Point(676, 29);
            this.minLengthInput.Name = "minLengthInput";
            this.minLengthInput.Size = new System.Drawing.Size(100, 20);
            this.minLengthInput.TabIndex = 2;
            // 
            // maxLengthInput
            // 
            this.maxLengthInput.Location = new System.Drawing.Point(676, 72);
            this.maxLengthInput.Name = "maxLengthInput";
            this.maxLengthInput.Size = new System.Drawing.Size(100, 20);
            this.maxLengthInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Minimum Characters:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Maximum Characters:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Caesar Cypher:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxLengthInput);
            this.Controls.Add(this.minLengthInput);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Execute_BTN);
            this.Name = "Interface";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Execute_BTN;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox minLengthInput;
        private System.Windows.Forms.TextBox maxLengthInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

