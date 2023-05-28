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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsb_SimpleArray_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void tsb_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Close program", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tsb_Arraylist_Click(object sender, EventArgs e)
        {
            ArrayListLearn arrayListLearn = new ArrayListLearn();
            arrayListLearn.MdiParent = this;
            arrayListLearn.Show();
        }

        private void tsb_Hashtable_Click(object sender, EventArgs e)
        {
            HashTable hashTable = new HashTable();
            hashTable.MdiParent = this;
            hashTable.Show();
        }

        private void tsnSortedList_Click(object sender, EventArgs e)
        {
            SortedListLearn sortedListLearn = new SortedListLearn();
            sortedListLearn.MdiParent = this;
            sortedListLearn.Show();
        }

        private void tsb_Queue_Click(object sender, EventArgs e)
        {
            QueueLesson queueLesson = new QueueLesson();
            queueLesson.MdiParent = this;
            queueLesson.Show();
        }

        private void tsb_Stack_Click(object sender, EventArgs e)
        {
            StackLesson stackLesson = new StackLesson();
            stackLesson.MdiParent = this;
            stackLesson.Show();
        }

        private void tsb_List_Click(object sender, EventArgs e)
        {
            ListLearn listLearn = new ListLearn();
            listLearn.MdiParent = this;
            listLearn.Show();
        }

        private void tsb_Dictionary_Click(object sender, EventArgs e)
        {
            DictionaryLearn dictionaryLearn = new DictionaryLearn();
            dictionaryLearn.MdiParent = this;
            dictionaryLearn.Show();
        }

        private void tsb_SortedDict_Click(object sender, EventArgs e)
        {
            SortedDictLearn sortedDictLearn = new SortedDictLearn();
            sortedDictLearn.MdiParent = this;
            sortedDictLearn.Show();
        }

        private void tst_SortedListGen_Click(object sender, EventArgs e)
        {
            SortedListGen sortedListGen = new SortedListGen();
            sortedListGen.MdiParent = this;
            sortedListGen.Show();
        }

        private void tsb_QueueGen_Click(object sender, EventArgs e)
        {
            QueueGenLesson queueGenLesson = new QueueGenLesson();
            queueGenLesson.MdiParent = this;
            queueGenLesson.Show();
        }

        private void tsb_StackGen_Click(object sender, EventArgs e)
        {
            StackGenLesson stackGenLesson = new StackGenLesson();
            stackGenLesson.MdiParent = this;
            stackGenLesson.Show();
        }

        private void tsb_LinkedList_Click(object sender, EventArgs e)
        {
            LinkedListLesson listLesson = new LinkedListLesson();
            listLesson.MdiParent = this;
            listLesson.Show();
        }
    }
}
