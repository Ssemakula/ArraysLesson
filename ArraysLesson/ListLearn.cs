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
    public partial class ListLearn : Form
    {
        List<string> list = new List<string>(); //Has to be typed (even custom types)

        public ListLearn()
        {
            InitializeComponent();
        }

        private void ClearInput()
        {
            this.txt_FindValue.Clear();
            this.txt_ValueValue.Clear();
            this.txt_Index.Clear();
        }

        private void ClearOutput()
        {
            this.ls_Value.Items.Clear();
        }

        private void DisplayTable()
        {
            //This will be used to display table
            ClearOutput();

            foreach (string item in list)
            {
                this.ls_Value.Items.Add(item);
            }
        }

        private void btn_AddItems_Click(object sender, EventArgs e)
        {
            string TempHold = this.txt_ValueValue.Text.Trim();

            if (TempHold.Length > 0)
            {
                list.Add(TempHold);
                ClearInput();
                DisplayTable();
            }
            else
            {
                CommonProcs.Beep();
            }
            /*
             * Note that you can also use AddRange to add an array
             * list.AddRange(string[]);
             */
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            int lenVar;
            ClearInput();

            if (txt_Index.Text.Trim().Length > 0)
            {
                if (int.TryParse(txt_Index.Text, out lenVar) && lenVar < list.Count)
                {
                    txt_ValueValue.Text = list[lenVar];
                }
                else
                    CommonProcs.Beep();
            }
            else { CommonProcs.Beep(); }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            if (txt_Index.Text.Trim().Length > 0)
            {
                if (int.TryParse(txt_Index.Text, out int lenVar) && lenVar < list.Count)
                {
                    list.RemoveAt(lenVar);
                    ClearInput();
                    DisplayTable();
                }
                else
                    CommonProcs.Beep();
            }
            else if (txt_ValueValue.Text.Trim().Length > 0)
            {
                if (!list.Remove(txt_ValueValue.Text.Trim()))
                    CommonProcs.Beep();
                ClearInput();
                DisplayTable();
            }
            else
            {
                CommonProcs.Beep();
            }
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            int lenVar;

            if (txt_Index.Text.Trim().Length > 0 && txt_ValueValue.Text.Trim().Length > 0)
            {
                if (int.TryParse(txt_Index.Text, out lenVar) && lenVar < list.Count)
                {
                    list[lenVar] = txt_ValueValue.Text;
                    ClearInput();
                    DisplayTable();
                }
                else
                    CommonProcs.Beep();
            }
            else
            {
                CommonProcs.Beep();
            }

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            int lenVar;

            if (txt_Index.Text.Trim().Length > 0 && txt_ValueValue.Text.Trim().Length > 0)
            {
                if (int.TryParse(txt_Index.Text, out lenVar) && lenVar < list.Count)
                {
                    list.Insert(lenVar, txt_ValueValue.Text);
                    ClearInput();
                    DisplayTable();
                }
                else
                    CommonProcs.Beep();
            }
            else
            {
                CommonProcs.Beep();
            }

        }

        private void btn_SortAsc_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                list.Sort();
                DisplayTable();
            }
        }

        private void btn_SortDesc_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                list.Sort();
                list.Reverse();
                DisplayTable();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            list.Clear();
            DisplayTable();
        }

        private void btn_CopyTo_Click(object sender, EventArgs e)
        {
            string[] target = new string[list.Count]; //Set size of array equal to source
            list.CopyTo(target, 0); //Copies to new array
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            int ind;

            if (txt_FindValue.Text.Trim().Length > 0)
            {
                ind = list.IndexOf(txt_FindValue.Text);
                if (ind > -1)
                {
                    txt_ValueValue.Text = list[ind];
                    txt_Index.Text = ind.ToString();
                }
                else
                {
                    CommonProcs.Beep();
                    ClearInput();
                }
            }
            else if (txt_Index.Text.Trim().Length > 0)
            {
                if(int.TryParse(txt_Index.Text, out ind) && ind < list.Count)
                {
                    txt_ValueValue.Text = list[ind];
                    txt_Index.Text = ind.ToString();
                }
            }
        }
    }
}

