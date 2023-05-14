using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysLesson
{
    public partial class HashTable : Form
    {
        System.Collections.Hashtable hashTable = new System.Collections.Hashtable();

        public HashTable()
        {
            InitializeComponent();
        }

        private void ClearInput()
        {
            this.txt_KeyValue.Clear();
            this.txt_ValueValue.Clear();
        }

        private void ClearOutput()
        {
            this.ls_Key.Items.Clear();
            this.ls_Value.Items.Clear();
        }

        private void DisplayTable()
        {
            //This will be used to display table
            ClearOutput();

            foreach (DictionaryEntry item in hashTable)
            {
                this.ls_Key.Items.Add(item.Key.ToString());
                this.ls_Value.Items.Add(item.Value.ToString());
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddHashItems_Click(object sender, EventArgs e)
        {
            string keyValue = txt_KeyValue.Text.Trim();
            string valueValue = txt_ValueValue.Text.Trim();

            if (keyValue.Length > 0 && valueValue.Length > 0)
            {
                try
                {
                    hashTable.Add(keyValue, valueValue);
                }
                catch
                {
                    CommonProcs.Beep();
                    MessageBox.Show($"Key {keyValue} exists in table");
                }
                ClearInput();
            }
            else
            {
                CommonProcs.Beep();
            }
            DisplayTable();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            string KeyValue = txt_KeyValue.Text.Trim();
            string ValueValue = txt_ValueValue.Text.Trim();

            if (KeyValue.Length > 0)
            {
                if (hashTable.ContainsKey(KeyValue))
                {
                    this.txt_ValueValue.Text = hashTable[KeyValue].ToString();
                }
                else
                {
                    MessageBox.Show("Key not found");
                }
            }
            else if (ValueValue.Length > 0)
            {
                if (hashTable.ContainsValue(ValueValue))
                {
                    //MessageBox.Show("Found");
                    foreach (DictionaryEntry item in hashTable)
                    {
                        if (item.Value.ToString() == ValueValue)
                        {
                            this.txt_KeyValue.Text = item.Key.ToString();
                            return;
                        }

                    }
                }
                else
                    CommonProcs.Beep();
            }
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            string keyValue = txt_KeyValue.Text.Trim();
            string valueValue = txt_ValueValue.Text.Trim();

            if (keyValue.Length == 0)
            {
                CommonProcs.Beep();
            }
            else
            {
                if (valueValue.Length > 0)
                {
                    hashTable[keyValue] = valueValue;
                    ClearInput();
                }
                else
                {
                    CommonProcs.Beep();
                }
            }
            DisplayTable();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string keyValue = txt_KeyValue.Text.Trim();

            if (keyValue.Length == 0)
            {
                CommonProcs.Beep();
            }
            else if (hashTable.ContainsKey(keyValue))
            {
                hashTable.Remove(keyValue);
                ClearInput();
            }
            else
            {
                CommonProcs.Beep();
            }
            DisplayTable();
        }
    }
}
