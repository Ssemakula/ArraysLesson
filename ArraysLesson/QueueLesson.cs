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

namespace ArraysLesson
{
    public partial class QueueLesson : Form
    {

        Queue myQ = new Queue();
        public QueueLesson()
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

            foreach (object item in myQ)
            {
                this.ls_Value.Items.Add(item.ToString());
            }


        }
        private void btn_AddItems_Click(object sender, EventArgs e)
        {
            string TempHold = this.txt_ValueValue.Text.Trim();

            if (TempHold.Length > 0)
            {
                myQ.Enqueue(TempHold);
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
            if (myQ.Count > 0)
            {
                txt_ValueValue.Text = myQ.Peek().ToString();
            }
            else
                CommonProcs.Beep();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (myQ.Count > 0)
            {
                txt_ValueValue.Text = myQ.Dequeue().ToString();
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
            myQ.Clear();
            DisplayTable();
        }

        private void btn_CopyTo_Click(object sender, EventArgs e)
        {
            if (myQ.Count == 0)
                return;

            object[] Target_Obj = new object[myQ.Count];
            myQ.CopyTo(Target_Obj, 0);
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
                if (myQ.Contains(txt_FindValue.Text.Trim()))
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
    }
}
