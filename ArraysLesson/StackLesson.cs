﻿using System;
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
    public partial class StackLesson : Form
    {
        Stack myStack = new Stack();

        public StackLesson()
        {
            InitializeComponent();
        }

        private void ClearOutput()
        {
            this.ls_Value.Items.Clear();
        }

        private void ClearInput()
        {
            this.txt_FindValue.Clear();
            this.txt_ValueValue.Clear();
        }

        private void DisplayTable()
        {
            //This will be used to display table
            ClearOutput();

            foreach (object item in myStack)
            {
                this.ls_Value.Items.Add(item.ToString());
            }


        }
        private void btn_AddItems_Click(object sender, EventArgs e)
        {
            string TempHold = this.txt_ValueValue.Text.Trim();

            if (TempHold.Length > 0)
            {
                myStack.Push(TempHold);
                //this.ls_Value.Items.Add(myQ.Peek());
                ClearInput();
                DisplayTable();
            }
            else
            {
                CommonProcs.Beep();
            }
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            if (myStack.Count > 0)
            {
                txt_ValueValue.Text = myStack.Peek().ToString();
            }
            else
                CommonProcs.Beep();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (myStack.Count > 0)
            {
                txt_ValueValue.Text = myStack.Pop().ToString();
                DisplayTable();
            }
            else
            {
                CommonProcs.Beep();
                ClearInput();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            myStack.Clear();
            DisplayTable();
        }

        private void btn_CopyTo_Click(object sender, EventArgs e)
        {
            if (myStack.Count == 0)
                return;

            object[] Target_Obj = new object[myStack.Count];
            myStack.CopyTo(Target_Obj, 0);
            ClearOutput();
            this.ls_Value.Items.Add("_______________Target_______________");
            foreach (object item in Target_Obj)
            {
                this.ls_Value.Items.Add(item.ToString());
            }
            MessageBox.Show("Press to continue...");
            DisplayTable();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (txt_FindValue.Text.Trim().Length > 0)
            {
                if (myStack.Contains(txt_FindValue.Text.Trim()))
                {
                    txt_FindValue.Text = "Found";
                }
                else
                {
                    CommonProcs.Beep();
                    ClearInput();
                }
            }
        }

        private void btn_ForEachQueue_Click(object sender, EventArgs e)
        {
            this.ls_Value.Items.Add("______________Using for___________________");
            if (myStack.Count > 0) //Using this is not recomended. No need to create stack if you want array
            {
                for (int i = 0; i < myStack.Count; i++)
                {
                    this.ls_Value.Items.Add(myStack.ToArray()[i]);
                }
            }
            else
                CommonProcs.Beep();
        }
    }
}
