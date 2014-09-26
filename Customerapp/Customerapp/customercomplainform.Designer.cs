namespace Customerapp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enqueuebutton = new System.Windows.Forms.Button();
            this.complaintextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dequeuebutton = new System.Windows.Forms.Button();
            this.complainDqtextBox = new System.Windows.Forms.TextBox();
            this.namedqtextBox = new System.Windows.Forms.TextBox();
            this.serialnotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.outputlistView = new System.Windows.Forms.ListView();
            this.serialcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.namcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comcolumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enqueuebutton);
            this.groupBox1.Controls.Add(this.complaintextBox);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue Customer";
            // 
            // enqueuebutton
            // 
            this.enqueuebutton.Location = new System.Drawing.Point(82, 97);
            this.enqueuebutton.Name = "enqueuebutton";
            this.enqueuebutton.Size = new System.Drawing.Size(108, 23);
            this.enqueuebutton.TabIndex = 4;
            this.enqueuebutton.Text = "Enqueue";
            this.enqueuebutton.UseVisualStyleBackColor = true;
            this.enqueuebutton.Click += new System.EventHandler(this.enqueuebutton_Click);
            // 
            // complaintextBox
            // 
            this.complaintextBox.Location = new System.Drawing.Point(78, 58);
            this.complaintextBox.Multiline = true;
            this.complaintextBox.Name = "complaintextBox";
            this.complaintextBox.Size = new System.Drawing.Size(230, 20);
            this.complaintextBox.TabIndex = 3;
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(77, 25);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(231, 20);
            this.nametextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Complain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dequeuebutton);
            this.groupBox2.Controls.Add(this.complainDqtextBox);
            this.groupBox2.Controls.Add(this.namedqtextBox);
            this.groupBox2.Controls.Add(this.serialnotextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(357, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dequeue Customer";
            // 
            // dequeuebutton
            // 
            this.dequeuebutton.Location = new System.Drawing.Point(186, 24);
            this.dequeuebutton.Name = "dequeuebutton";
            this.dequeuebutton.Size = new System.Drawing.Size(106, 23);
            this.dequeuebutton.TabIndex = 6;
            this.dequeuebutton.Text = "Dequeue";
            this.dequeuebutton.UseVisualStyleBackColor = true;
            this.dequeuebutton.Click += new System.EventHandler(this.dequeuebutton_Click);
            // 
            // complainDqtextBox
            // 
            this.complainDqtextBox.Location = new System.Drawing.Point(71, 90);
            this.complainDqtextBox.Multiline = true;
            this.complainDqtextBox.Name = "complainDqtextBox";
            this.complainDqtextBox.Size = new System.Drawing.Size(221, 20);
            this.complainDqtextBox.TabIndex = 5;
            // 
            // namedqtextBox
            // 
            this.namedqtextBox.Location = new System.Drawing.Point(71, 55);
            this.namedqtextBox.Name = "namedqtextBox";
            this.namedqtextBox.Size = new System.Drawing.Size(221, 20);
            this.namedqtextBox.TabIndex = 4;
            // 
            // serialnotextBox
            // 
            this.serialnotextBox.Location = new System.Drawing.Point(71, 22);
            this.serialnotextBox.Name = "serialnotextBox";
            this.serialnotextBox.Size = new System.Drawing.Size(100, 20);
            this.serialnotextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Complain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Serial No";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.outputlistView);
            this.groupBox3.Location = new System.Drawing.Point(25, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(624, 145);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Waiting Customer";
            // 
            // outputlistView
            // 
            this.outputlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialcolumnHeader,
            this.namcolumnHeader,
            this.comcolumnHeader});
            this.outputlistView.Location = new System.Drawing.Point(19, 19);
            this.outputlistView.Name = "outputlistView";
            this.outputlistView.Size = new System.Drawing.Size(589, 120);
            this.outputlistView.TabIndex = 0;
            this.outputlistView.UseCompatibleStateImageBehavior = false;
            this.outputlistView.View = System.Windows.Forms.View.Details;
            // 
            // serialcolumnHeader
            // 
            this.serialcolumnHeader.Text = "Serial";
            // 
            // namcolumnHeader
            // 
            this.namcolumnHeader.Text = "Name";
            // 
            // comcolumnHeader
            // 
            this.comcolumnHeader.Text = "Complain";
            this.comcolumnHeader.Width = 328;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 330);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Queue Mannagment System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enqueuebutton;
        private System.Windows.Forms.TextBox complaintextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button dequeuebutton;
        private System.Windows.Forms.TextBox complainDqtextBox;
        private System.Windows.Forms.TextBox namedqtextBox;
        private System.Windows.Forms.TextBox serialnotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView outputlistView;
        private System.Windows.Forms.ColumnHeader serialcolumnHeader;
        private System.Windows.Forms.ColumnHeader namcolumnHeader;
        private System.Windows.Forms.ColumnHeader comcolumnHeader;
    }
}

