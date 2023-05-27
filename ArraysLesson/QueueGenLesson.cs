using System;
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
    public partial class QueueGenLesson : Form
    {
        Queue<string> myQ = new Queue<string>();
        public QueueGenLesson()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
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

            foreach (var item in myQ)
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
            ClearInput();
            DisplayTable();
        }

        private void btn_CopyTo_Click(object sender, EventArgs e)
        {
            if (myQ.Count == 0)
                return;

            Queue<String> Target_Obj = new(myQ); //Instant copy type 1
            string[] Target2 = myQ.ToArray(); //Copy while defining???
            string[] Target3 = new string[myQ.Count]; //Lesson option
            string[] Target4 = new string[myQ.Count]; //Second Lesson Option

            Target3 = myQ.ToArray(); //Lesson option 1
            myQ.CopyTo(Target4, 0); // Lesson option 2. Remember to put the index as well

            //myQ.CopyTo(Target_Obj, 0);
            //ClearOutput();
            this.ls_Value.Items.Add("_______________Target_______________");
            foreach (var item in Target_Obj)
            {
                this.ls_Value.Items.Add(item.ToString());
            }
            this.ls_Value.Items.Add("_______________Target2_______________");
            foreach (var item in Target2)
            {
                this.ls_Value.Items.Add(item.ToString());
            }
            this.ls_Value.Items.Add("_______________Target3_______________");
            foreach (var item in Target3)
            {
                this.ls_Value.Items.Add(item.ToString());
            }
            this.ls_Value.Items.Add("_______________Target4_______________");
            foreach (var item in Target4)
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
