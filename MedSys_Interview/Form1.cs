using System;
using System.IO;
using System.Linq;

namespace MedSys_Interview
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            editUpdateButton.Hide();
            editCancelButton.Hide();

            //Loads saved items from file
            try
            {
                string[] savedLines = File.ReadAllLines("SavedItems.txt");

                foreach (string item in savedLines)
                    itemListBox.Items.Add(item);
            }catch(FileNotFoundException exception) {
                System.Console.WriteLine("SavedItems.txt not found");
            }
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e) {
            //Saves current items to file
            string[] itemList = itemListBox.Items.OfType<string>().ToArray();
            File.WriteAllLines("SavedItems.txt", itemList);
        }

        private void addButton_Click(object sender, EventArgs e) {
            itemListBox.Items.Add(itemTextBox.Text);
        }

        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e) {
            //Hides edit and remove buttons if no item is selected
            removeButton.Enabled = itemListBox.SelectedIndex != -1;
            editButton.Enabled = itemListBox.SelectedIndex != -1;
        }

        private void removeButton_Click(object sender, EventArgs e) {
            int selectedIndex = itemListBox.SelectedIndex;
            itemListBox.Items.RemoveAt(selectedIndex);

            if (itemListBox.Items.Count == 0)
                return;

            //Keeps selected index at current point
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
