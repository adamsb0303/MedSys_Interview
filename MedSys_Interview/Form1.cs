using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedSys_Interview
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            editUpdateButton.Hide();
            editCancelButton.Hide();
        }

        private void addButton_Click(object sender, EventArgs e) {
            itemListBox.Items.Add(itemTextBox.Text);
        }

        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e) {
            removeButton.Enabled = itemListBox.SelectedIndex != -1;
            editButton.Enabled = itemListBox.SelectedIndex != -1;
        }

        private void removeButton_Click(object sender, EventArgs e) {
            int selectedIndex = itemListBox.SelectedIndex;
            itemListBox.Items.RemoveAt(selectedIndex);

            if (itemListBox.Items.Count == 0)
                return;

            if (selectedIndex < itemListBox.Items.Count)
                itemListBox.SetSelected(selectedIndex, true);
            else
                itemListBox.SetSelected(itemListBox.Items.Count - 1, true);
        }

        private void editButton_Click(object sender, EventArgs e) {
            addButton.Hide();
            editButton.Hide();
            removeButton.Hide();

            itemTextBox.Text = itemListBox.Items[itemListBox.SelectedIndex].ToString();
            editUpdateButton.Show();
            editCancelButton.Show();
        }

        private void editUpdateButton_Click(object sender, EventArgs e) {
            itemListBox.Items[itemListBox.SelectedIndex] = itemTextBox.Text;

            editCancelButton_Click(sender, e);
        }

        private void editCancelButton_Click(object sender, EventArgs e) {
            itemTextBox.Text = "";

            addButton.Show();
            editButton.Show();
            removeButton.Show();

            editCancelButton.Hide();
            editUpdateButton.Hide();
        }
    }
}
