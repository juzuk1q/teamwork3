using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class banan : Form
    {
        public banan()
        {
            InitializeComponent();
            AddItemsToListBox();

            btnAdd.Click += BtnAdd_Click;
            btnShowSelected.Click += BtnShowSelected_Click;

        }
        private void AddItemsToListBox()
        {
            // Очистка перед добавлением
            checkedListBox1.Items.Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Добавление нового элемента из TextBox
            if (!string.IsNullOrWhiteSpace(txtNewItem.Text))
            {
                checkedListBox1.Items.Add(txtNewItem.Text);
                txtNewItem.Clear();
                txtNewItem.Focus();
            }
        }

        private void BtnShowSelected_Click(object sender, EventArgs e)
        {
            // Получение отмеченных элементов
            string selectedItems = "Выбрано:\n";

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    selectedItems += $"- {checkedListBox1.Items[i]}\n";
                }
            }

            MessageBox.Show(selectedItems);
        }
    }
}
