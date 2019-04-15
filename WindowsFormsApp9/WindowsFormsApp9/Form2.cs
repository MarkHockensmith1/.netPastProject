using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form2 : Form
    {

        public String[] products = null;
        public Form2()
        {
            InitializeComponent();
        }
        //this loads when the application starts
        //I create 
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'milestoneDatabaseDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.milestoneDatabaseDataSet.products);
            products = new String[listBox1.Items.Count + 10];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                products[i] = listBox1.Items[i].ToString();
            }
        }

        //the add button that adds items to the list
        private void button1_Click(object sender, EventArgs e)
        {
            products[products.Length + 1] = textBox1.Text;//added from the textbox to array
            for (int i = 0; i <products.Length; i++)//listbox is updated with array
            {
                listBox1.Items.Add(products[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            products[listBox1.SelectedIndex] = null; //removes the selected item
            for (int i = 0; i < products.Length; i++)//listbox is updated with array
            {
                listBox1.Items.Add(products[i].ToString());
            }
        }
        //after the edit button is pressed, can edit stock
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)//if checks for a press of the edit button
            {
                products[listBox1.SelectedIndex] = textBox1.Text;
                for (int i = 0; i < products.Length; i++)//listbox is updated with array
                {
                    listBox1.Items.Add(products[i].ToString());
                }
            }
            else
            {
                label1.Text = "please press edit first";
            }
        }
        //allows an item to be edited by placing it in the textbox
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItems.ToString();
        }
        //adds products in search to listbox
        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products.Contains(textBox2.Text))
                {
                    listBox2.Items.Add(products[i]);
                }
            }
            
        }
        //adds items to listbox by Quantity
        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products.Contains(textBox2.Text))
                {
                    listBox2.Items.Add(products[i]);
                }
            }
        }
    }

    private void MilestoneDatabaseDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
