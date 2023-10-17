using System;
using System.Collections;
using System.Collections.Generic;


using System.Text.RegularExpressions;

using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<string> subjects = new List<string>(); // Create a list to store textBox3 values
        private ArrayList nameList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text.ToString().Trim();
            firstName = Regex.Replace(firstName, @"\s+", " ");
            string lastName = textBox2.Text.ToString().Trim();
            lastName = Regex.Replace(lastName, @"\s+", " ");
            bool isChecked = checkBox1.Checked;

            string textBox3Value = textBox3.Text;
            subjects.Add(textBox3Value); // Add the value to the list

            // Add first and last names to the ArrayList
            nameList.Add(firstName);
            nameList.Add(lastName);

            // Join the elements of the list into a single string
            string textBox3ValuesText = string.Join("\n", subjects);

            // Display the result in label4
            label4.Text = $"First Name: {firstName}\nLast Name: {lastName}\nIs Checked: {isChecked}\nSubjects: {textBox3ValuesText}\nNames in ArrayList: {string.Join("\n", nameList.ToArray())}";
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
