using CreditCardSubmissionVerification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreditCardSubmissionRunner
{
    public partial class Form1 : Form
    {
        private Panel buttonPanel = new Panel();
        private DataGridView songsDataGridView = new DataGridView();
        private Button addNewRowButton = new Button();
        private Button deleteRowButton = new Button();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.runFileButton.Enabled = false;
            var datePrefix = this.datePrefixTextBox.Text;
            var rootPath = this.rootPathTextBox.Text;
            var savePath = this.savePathTextBox.Text;
            this.statusTextBox.Text = "Scanning files";
            var creditCardVerifier = new CreditCardVerifier(datePrefix, rootPath, savePath);
            creditCardVerifier.PopulateData();
            this.statusTextBox.Text = "Creating Excel File";
            creditCardVerifier.CreateExcelFile();
            this.statusTextBox.Text = $"Saved Excel File to {creditCardVerifier.SaveFileName}";
            this.runFileButton.Enabled = true;
            MessageBox.Show($"Saved Excel File to {creditCardVerifier.SaveFileName}", "Completed");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rootPathTextBox_Click(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

    }
}
