using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraysLesson
{
    public partial class LinkedListLesson : Form
    {
        LinkedList<string> linkedList = new LinkedList<string>(); //System.Collections.Generic
        public LinkedListLesson()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearInput(bool allItems)
        {
            if (allItems)
                this.txt_FindValue.Clear();
            this.txt_ValueValue.Clear();
        }

        private void btn_AddItems_Click(object sender, EventArgs e)
        {
            string useItem = this.txt_ValueValue.Text.Trim();

            if (useItem.Length > 0)
            {
                if (linkedList.Count == 0)
                    linkedList.AddFirst(useItem);
                else if (linkedList.Count >= 1)
                    linkedList.AddLast(useItem);
                ClearInput(true);
            }
            DisplayTable();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            linkedList.Clear();
            DisplayTable();
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            if (linkedList.Count == 0)
            {
                CommonProcs.Beep();
                return;
            }
            LinkedListNode<string> node;
            string useItem = this.txt_FindValue.Text.Trim();

            ClearInput(false);

            node = linkedList.Find(useItem);
            if (node != null)
            {
                this.txt_ValueValue.Text = node.Value;
            }
            else
                CommonProcs.Beep();

        }

        private void btn_AddBefore_Click(object sender, EventArgs e)
        {
            if (linkedList.Count == 0)
            {
                CommonProcs.Beep();
                return;
            }
            LinkedListNode<string> node;
            string useItem = this.txt_FindValue.Text.Trim();
            string insertItem = this.txt_ValueValue.Text.Trim();

            node = linkedList.Find(useItem);
            if (node != null)
            {
                linkedList.AddBefore(node, insertItem);
                ClearInput(false);
            }
            else
                CommonProcs.Beep();
            DisplayTable();
        }

        private void btn_AddAfter_Click(object sender, EventArgs e)
        {
            if (linkedList.Count == 0)
            {
                CommonProcs.Beep();
                return;
            }
            LinkedListNode<string> node;
            string useItem = this.txt_FindValue.Text.Trim();
            string insertItem = this.txt_ValueValue.Text.Trim();

            node = linkedList.Find(useItem);
            if (node != null)
            {
                linkedList.AddAfter(node, insertItem);
                ClearInput(false);
            }
            else
                CommonProcs.Beep();
            DisplayTable();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (linkedList.Count == 0) // Let's not waste resources on empty lists
            {
                CommonProcs.Beep();
                return;
            }

            string useItem = this.txt_FindValue.Text.Trim();


            /*
            //Remove by node
            linkedList.RemoveFirst();
            linkedList.RemoveLast();

            LinkedListNode<string> node;
            node = linkedList.Find(useItem);

            //Removeing cy node
            //* option is linkedList.Remove(Value) //Returns false if not removed or if not found
            //* not sure it has check structure but it's a smaller overhead



            if (node != null) // Throws exception therefore have to check first
            {
                linkedList.Remove(node);
            }
            else
                CommonProcs.Beep();*/

            if (!linkedList.Remove(useItem))
            {
                CommonProcs.Beep();
            }
            else
                ClearInput(true);
            DisplayTable();

        }

        private void DisplayTable()
        {
            //This will be used to display table
            ClearOutput();

            foreach (var item in linkedList)
            {
                this.ls_Items.Items.Add(item.ToString());
            }


        }

        private void ClearOutput()
        {
            ls_Items.Items.Clear();
        }

        private void btn_CopyTo_Click(object sender, EventArgs e)
        {
            if (linkedList.Count == 0) // Let's not waste resources on empty lists
            {
                CommonProcs.Beep();
                return;
            }

            string[] Target = new string[linkedList.Count];

            linkedList.CopyTo(Target, 0);

            this.ls_Items.Items.Add("____________Target_____________");
            foreach (var item in Target)
            {
                this.ls_Items.Items.Add(item.ToString());
            }
            MessageBox.Show("Pres a key to Continue");
            ClearOutput();
            ClearInput(true);
        }
    }
}
