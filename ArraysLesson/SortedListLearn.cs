using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysLesson
{
    public partial class SortedListLearn : Form
    {
        SortedList sortedList = new SortedList(); //System.Collections
        public SortedListLearn()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearOutput() //Clear list display
        {
            this.ls_Key.Items.Clear();
            this.ls_Value.Items.Clear();
        }

        private void ClearInput() //Clear input fields
        {
            this.txt_KeyValue.Clear();
            this.txt_ValueValue.Clear();
        }

        private void DisplayTable() //Display tables
        {
            //This will be used to display table
            ClearOutput();

            foreach (DictionaryEntry item in sortedList)
            {
                this.ls_Key.Items.Add(item.Key.ToString());
                this.ls_Value.Items.Add(item.Value.ToString());
            }
        }

        private void btn_AddItems_Click(object sender, EventArgs e)
        {
            string keyValue = txt_KeyValue.Text.Trim();
            string valueValue = txt_ValueValue.Text.Trim();

            if (keyValue.Length > 0 && valueValue.Length > 0)
            {
                try
                {
                    sortedList.Add(keyValue, valueValue);
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
                if (sortedList.ContainsKey(KeyValue))
                {
                    this.txt_ValueValue.Text = sortedList[KeyValue].ToString();
                }
                else
                {
                    CommonProcs.Beep();
                }
            }
            else if (ValueValue.Length > 0)
            {
                if (sortedList.ContainsValue(ValueValue))
                {
                    //MessageBox.Show("Found");
                    foreach (DictionaryEntry item in sortedList)
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

        private void btn_ReadIndex_Click(object sender, EventArgs e)
        {
            object Index;
            string KeyValue = txt_KeyValue.Text.Trim();
            string ValueValue = txt_ValueValue.Text.Trim();
            int IndexVal;

            if (KeyValue.Length > 0)
            {
                if (int.TryParse(KeyValue, out IndexVal) && IndexVal < sortedList.Count)
                {
                    Index = sortedList.GetByIndex(IndexVal);
                    this.txt_ValueValue.Text = Index.ToString();
                }
                else
                    CommonProcs.Beep();
            }
            else
                CommonProcs.Beep();

        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            string keyValue = txt_KeyValue.Text.Trim();
            string valueValue = txt_ValueValue.Text.Trim();

            //Edit by Key
            if (keyValue.Length == 0)
            {
                CommonProcs.Beep();
            }
            else
            {
                if (valueValue.Length > 0)
                {
                    sortedList[keyValue] = valueValue;
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
            else if (sortedList.ContainsKey(keyValue))
            {
                sortedList.Remove(keyValue); // sortedList.RemoveAt(int) would remove via index
                ClearInput();
            }
            else
            {
                CommonProcs.Beep();
            }
            DisplayTable();
        }

        private void btn_For_Click(object sender, EventArgs e)
        {
            ClearOutput();

            for (int i = 0; i < sortedList.Count; i++)
            {
                this.ls_Key.Items.Add(i);
                this.ls_Value.Items.Add(sortedList.GetByIndex(i)); // The list is presorted so order is changed
            }
        }

        private void btn_ForEach_Click(object sender, EventArgs e)
        {
            ClearOutput();

            foreach (DictionaryEntry item in sortedList)
            {
                this.ls_Key.Items.Add((string)item.Key);
                this.ls_Value.Items.Add(item.Value);
            }
        }

        private void btn_CopyTo_Click(object sender, EventArgs e)
        {
            object[] target = new object[sortedList.Count];
            sortedList.CopyTo(target, 0);
            sortedList.Keys.CopyTo(target, 0); // Copy keys alone
            sortedList.Values.CopyTo(target, 0); // Copy values alone
        }

        private void btn_SearchKey_Click(object sender, EventArgs e)
        {
            if (sortedList.ContainsKey(this.txt_FindKey.Text))
            {
                //Do things with key
            }
        }

        private void btn_SearchValue_Click(object sender, EventArgs e)
        {
            if (sortedList.ContainsValue(this.txt_FindKey.Text))
            {
                //Do things with value (not sure how)
            }
        }
    }
}
