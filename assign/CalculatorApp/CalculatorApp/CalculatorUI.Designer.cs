namespace CalculatorApp
{
    partial class CalculatorUI
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
            this.firstnumbertextBox = new System.Windows.Forms.TextBox();
            this.secondnumbertextBox = new System.Windows.Forms.TextBox();
            this.resulttextBox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.subtractbutton = new System.Windows.Forms.Button();
            this.multiplybutton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // firstnumbertextBox
            // 
            this.firstnumbertextBox.Location = new System.Drawing.Point(122, 45);
            this.firstnumbertextBox.Name = "firstnumbertextBox";
            this.firstnumbertextBox.Size = new System.Drawing.Size(273, 20);
            this.firstnumbertextBox.TabIndex = 3;
            // 
            // secondnumbertextBox
            // 
            this.secondnumbertextBox.Location = new System.Drawing.Point(122, 90);
            this.secondnumbertextBox.Name = "secondnumbertextBox";
            this.secondnumbertextBox.Size = new System.Drawing.Size(269, 20);
            this.secondnumbertextBox.TabIndex = 4;
            // 
            // resulttextBox
            // 
            this.resulttextBox.Location = new System.Drawing.Point(122, 145);
            this.resulttextBox.Name = "resulttextBox";
            this.resulttextBox.Size = new System.Drawing.Size(271, 20);
            this.resulttextBox.TabIndex = 5;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(37, 196);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 6;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // subtractbutton
            // 
            this.subtractbutton.Location = new System.Drawing.Point(138, 199);
            this.subtractbutton.Name = "subtractbutton";
            this.subtractbutton.Size = new System.Drawing.Size(75, 23);
            this.subtractbutton.TabIndex = 7;
            this.subtractbutton.Text = "Subtract";
            this.subtractbutton.UseVisualStyleBackColor = true;
            this.subtractbutton.Click += new System.EventHandler(this.subtractbutton_Click);
            // 
            // multiplybutton
            // 
            this.multiplybutton.Location = new System.Drawing.Point(233, 199);
            this.multiplybutton.Name = "multiplybutton";
            this.multiplybutton.Size = new System.Drawing.Size(75, 23);
            this.multiplybutton.TabIndex = 8;
            this.multiplybutton.Text = "Multiply";
            this.multiplybutton.UseVisualStyleBackColor = true;
            this.multiplybutton.Click += new System.EventHandler(this.multiplybutton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(335, 204);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 9;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 261);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplybutton);
            this.Controls.Add(this.subtractbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.resulttextBox);
            this.Controls.Add(this.secondnumbertextBox);
            this.Controls.Add(this.firstnumbertextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstnumbertextBox;
        private System.Windows.Forms.TextBox secondnumbertextBox;
        private System.Windows.Forms.TextBox resulttextBox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button subtractbutton;
        private System.Windows.Forms.Button multiplybutton;
        private System.Windows.Forms.Button divideButton;
    }
}

