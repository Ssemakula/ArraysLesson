using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArraysLesson;

namespace ArraysLesson
{
    public partial class SortedDictLearn : Form
    {
        SortedDictionary<string, string> dict = new SortedDictionary<string, string>();
        public SortedDictLearn()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
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

            foreach (KeyValuePair<string, string> item in dict) // I like this one better...
            {
                this.ls_Key.Items.Add(item.Key);
                this.ls_Value.Items.Add(item.Value);
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
                    dict.Add(keyValue, valueValue);
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
                if (dict.ContainsKey(KeyValue))
                {
                    this.txt_ValueValue.Text = dict[KeyValue];
                }
                else
                {
                    MessageBox.Show("Key not found");
                }
            }
            else if (ValueValue.Length > 0)
            {
                if (dict.ContainsValue(ValueValue))
                {
                    //MessageBox.Show("Found");

                    foreach (var item in dict) // Need to find a better way...
                    {
                        if (item.Value == ValueValue)
                        {
                            this.txt_KeyValue.Text = item.Key;
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
                    dict[keyValue] = valueValue;
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
            else if (dict.ContainsKey(keyValue))
            {
                if (dict.Remove(keyValue))
                    ClearInput();
                else
                    CommonProcs.Beep();
            }
            else
            {
                CommonProcs.Beep();
            }
            DisplayTable();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            dict.Clear();
            DisplayTable();
        }

        private void btn_CopyTo_Click(object sender, EventArgs e)
        {
            if (dict.Count == 0)
                return;

            /*
             * Note that the lessons look at copy for each
             * dict.Keys.CopyTo and dict.Values.CopyTo
             * Not very useful when coping all and want same structure
             */

            SortedDictionary<string, string> Target_Obj = new(dict); //Copy from old to new
            // Dictionary value = dict.ToDictionary(Target_Obj, 0);
            //ClearOutput();
            this.ls_Value.Items.Add("_______________Target_______________");
            this.ls_Key.Items.Add("_______________Target_______________");
            //dict.CopyTo(SortedDictionary<string, string>[] Target, 0); //How do you use CopyTo?????
            foreach (var item in Target_Obj) // For demonstration of diffrent use
            {
                this.ls_Value.Items.Add(item.Value);
                this.ls_Key.Items.Add(item.Key);
            }
            MessageBox.Show("Press to continue...");
            DisplayTable();
        }
    }
}
