using Microsoft.VisualBasic;
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
    public partial class ArrayListLearn : Form
    {
        public ArrayListLearn()
        {
            InitializeComponent();
        }

        private void btn_Arraylist1_Click(object sender, EventArgs e)
        {
            ArrayList myList = new ArrayList() { 2, "Brenda", 382.23, false, "Maissan", this.btn_Arraylist1 };
            int[] myIntList = { 2, 4, 6, 8 };

            myList.Add("Whatever?");
            myList.Add(myIntList);
            lb_Items.Items.AddRange(myList.ToArray());

        }

        private void btn_varArray_Click(object sender, EventArgs e)
        {
            var myList = new ArrayList() { 2, "Brenda", 382.23, false, "Maissan", this.btn_Arraylist1 };
            int[] myIntList = { 2, 4, 6, 8 };

            myList.Add("Whatever?");
            myList.Add(myIntList);
            lb_Items.Items.AddRange(myList.ToArray());
        }

        private void ArrayListLearn_Load(object sender, EventArgs e)
        {
            //---------------------------------- To Decide -----------------
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            var myList = new ArrayList() { 2, "Brenda", 382.23, false, "Maissan", this.btn_Arraylist1 };
            int[] myIntList = { 2, 4, 6, 8 };
            int r;

            myList.Add(myIntList);
            //this.lb_Items.Items.Clear();
            //this.lb_Items.Items.AddRange(myList.ToArray());

            int.TryParse(this.txt_Search.Text.Trim(), out r);
            if (r < myList.Count && r >= 0)
            {
                if (myList[r].GetType().ToString().IndexOf("[]") >= 0)
                {
                    this.lb_Items.Items.Add("Array...");
                }
                else if (myList[r].GetType().ToString().IndexOf("System.Windows") >= 0)
                {
                    this.lb_Items.Items.Add("Control...");
                }
                else
                    this.lb_Items.Items.Add(myList[r]);
            }
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            var myList = new ArrayList() { 2, "Brenda", 382.23, false, "Maissan", this.btn_Arraylist1 };
            int[] myIntList = { 2, 4, 6, 8 };
            int r;

            myList.Add(myIntList);
            //this.lb_Items.Items.Clear();
            //this.lb_Items.Items.AddRange(myList.ToArray());

            lb_Items.Items.Clear();

            if (!int.TryParse(this.txt_Search.Text.Trim(), out r))
            {
                r = -1;
            }
            if (r < myList.Count && r >= 0)
            {
                myList[r] = this.txt_Search.Text;
            }
            else
                myList.Insert(0, this.txt_Search.Text); //Insert at the beginning of list (Add is at end)

            foreach (var item in myList)
            {
                if (item.GetType().ToString().Contains("[]"))
                {
                    this.lb_Items.Items.Add("Array...");
                }
                else if (item.GetType().ToString().IndexOf("System.Windows") >= 0)
                {
                    this.lb_Items.Items.Add("Control...");
                }
                else
                    this.lb_Items.Items.Add(item);
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var myList = new ArrayList() { 2, "Brenda", 382.23, false, "Maissan", this.btn_Arraylist1 };
            int[] myIntList = { 2, 4, 6, 8 };
            int r;

            myList.Add(myIntList);
            //this.lb_Items.Items.Clear();
            //this.lb_Items.Items.AddRange(myList.ToArray());

            lb_Items.Items.Clear();

            if (!int.TryParse(this.txt_Search.Text.Trim(), out r))
            {
                r = -1;
            }
            if (r < myList.Count && r >= 0)
            {
                object obj = myList[r];
                myList.Remove(obj);
            }
            foreach (object item in myList)
            {
                if (item.GetType().ToString().Contains("[]"))
                {
                    this.lb_Items.Items.Add("Array...");
                }
                else if (item.GetType().ToString().IndexOf("System.Windows") >= 0)
                {
                    this.lb_Items.Items.Add("Control...");
                }
                else
                    this.lb_Items.Items.Add(item);
            }
            foreach (object item in myList)
            {
                this.lb_Items.Items.Add(item.GetType().ToString());
            }

        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            var myList = new ArrayList() { 2, "Brenda", 382.23, false, "Maissan", this.btn_Arraylist1 };
            int[] myIntList = { 2, 4, 6, 8 };

            myList.Add(myIntList);
            var target_list = new ArrayList();

            lb_Items.Items.Clear();
            foreach (object item in myList)
            {
                if (item.GetType().ToString().Contains("[]"))
                {
                    this.lb_Items.Items.Add("Array...");
                }
                else if (item.GetType().ToString().IndexOf("System.Windows") >= 0)
                {
                    this.lb_Items.Items.Add("Control...");
                }
                else
                    this.lb_Items.Items.Add(item);
            }
            lb_Items.Items.Add("-------------------------------------");
            if (myList.Contains(myIntList))
                MessageBox.Show("We can see the array");
            

            myCopyList(myList, (ArrayList) target_list);
            foreach (object item in target_list) {
                lb_Items.Items.Add(item);
            }
            
        }

        private void myCopyList(ArrayList fromList, ArrayList toList)
        {
            foreach(object item in fromList)
            {
                toList.Add(item);
            }
        }
    }
}
