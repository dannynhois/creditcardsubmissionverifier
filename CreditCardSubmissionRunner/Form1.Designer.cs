namespace CreditCardSubmissionRunner
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
            this.runFileButton = new System.Windows.Forms.Button();
            this.datePrefixTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rootPathTextBox = new System.Windows.Forms.TextBox();
            this.rootPathLabel = new System.Windows.Forms.Label();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.savePathTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            // 
            // runFileButton
            // 
            this.runFileButton.Location = new System.Drawing.Point(50, 44);
            this.runFileButton.Name = "runFileButton";
            this.runFileButton.Size = new System.Drawing.Size(121, 25);
            this.runFileButton.TabIndex = 0;
            this.runFileButton.Text = "Create Excel File";
            this.runFileButton.UseVisualStyleBackColor = true;
            this.runFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // datePrefixTextBox
            // 
            this.datePrefixTextBox.Location = new System.Drawing.Point(50, 150);
            this.datePrefixTextBox.Name = "datePrefixTextBox";
            this.datePrefixTextBox.Size = new System.Drawing.Size(181, 23);
            this.datePrefixTextBox.TabIndex = 1;
            this.datePrefixTextBox.Text = "20191003";
            this.datePrefixTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date Prefix";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rootPathTextBox
            // 
            this.rootPathTextBox.Location = new System.Drawing.Point(50, 201);
            this.rootPathTextBox.Name = "rootPathTextBox";
            this.rootPathTextBox.Size = new System.Drawing.Size(601, 23);
            this.rootPathTextBox.TabIndex = 3;
            this.rootPathTextBox.Text = "G:\\My Drive";
            this.rootPathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // rootPathLabel
            // 
            this.rootPathLabel.AutoSize = true;
            this.rootPathLabel.Location = new System.Drawing.Point(50, 183);
            this.rootPathLabel.Name = "rootPathLabel";
            this.rootPathLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rootPathLabel.Size = new System.Drawing.Size(92, 15);
            this.rootPathLabel.TabIndex = 4;
            this.rootPathLabel.Text = "Folder to Search";
            this.rootPathLabel.Click += new System.EventHandler(this.rootPathTextBox_Click);
            // 
            // savePathLabel
            // 
            this.savePathLabel.AutoSize = true;
            this.savePathLabel.Location = new System.Drawing.Point(50, 240);
            this.savePathLabel.Name = "savePathLabel";
            this.savePathLabel.Size = new System.Drawing.Size(121, 15);
            this.savePathLabel.TabIndex = 5;
            this.savePathLabel.Text = "Folder to Save Results";
            this.savePathLabel.UseMnemonic = false;
            this.savePathLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // savePathTextBox
            // 
            this.savePathTextBox.Location = new System.Drawing.Point(50, 258);
            this.savePathTextBox.Name = "savePathTextBox";
            this.savePathTextBox.Size = new System.Drawing.Size(601, 23);
            this.savePathTextBox.TabIndex = 6;
            this.savePathTextBox.Text = "C:\\Users\\danny\\Documents\\";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(50, 306);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(290, 96);
            this.statusTextBox.TabIndex = 7;
            this.statusTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 435);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.savePathTextBox);
            this.Controls.Add(this.savePathLabel);
            this.Controls.Add(this.rootPathLabel);
            this.Controls.Add(this.rootPathTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePrefixTextBox);
            this.Controls.Add(this.runFileButton);
            this.Name = "Form1";
            this.Text = "Credit Card Verifier";

        }

        #endregion

        private System.Windows.Forms.Button runFile;
        private System.Windows.Forms.TextBox datePrefixTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rootPathTextBox;
        private System.Windows.Forms.Label rootPathLabel;
        private System.Windows.Forms.Label savePathLabel;
        private System.Windows.Forms.TextBox savePathTextBox;
        private System.Windows.Forms.RichTextBox statusTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button runFileButton;
    }
}

