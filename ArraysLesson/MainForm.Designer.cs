namespace ArraysLesson
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            tsb_SimpleArray = new ToolStripButton();
            tsb_Arraylist = new ToolStripButton();
            tsb_Exit = new ToolStripButton();
            tsb_Hashtable = new ToolStripButton();
            tsnSortedList = new ToolStripButton();
            tsb_Queue = new ToolStripButton();
            tsb_Stack = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsb_List = new ToolStripButton();
            tsb_Dictionary = new ToolStripButton();
            tsb_SortedDict = new ToolStripButton();
            tst_SortedListGen = new ToolStripButton();
            tsb_QueueGen = new ToolStripButton();
            tsb_StackGen = new ToolStripButton();
            tsb_LinkedList = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsb_SimpleArray, tsb_Arraylist, tsb_Exit, tsb_Hashtable, tsnSortedList, tsb_Queue, tsb_Stack, toolStripSeparator1, tsb_List, tsb_Dictionary, tsb_SortedDict, tst_SortedListGen, tsb_QueueGen, tsb_StackGen, toolStripSeparator2, tsb_LinkedList });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1065, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsb_SimpleArray
            // 
            tsb_SimpleArray.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsb_SimpleArray.Image = (Image)resources.GetObject("tsb_SimpleArray.Image");
            tsb_SimpleArray.ImageTransparentColor = Color.Magenta;
            tsb_SimpleArray.Name = "tsb_SimpleArray";
            tsb_SimpleArray.Size = new Size(78, 22);
            tsb_SimpleArray.Text = "Simple Array";
            tsb_SimpleArray.Click += tsb_SimpleArray_Click;
            // 
            // tsb_Arraylist
            // 
            tsb_Arraylist.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsb_Arraylist.Image = (Image)resources.GetObject("tsb_Arraylist.Image");
            tsb_Arraylist.ImageTransparentColor = Color.Magenta;
            tsb_Arraylist.Name = "tsb_Arraylist";
            tsb_Arraylist.Size = new Size(60, 22);
            tsb_Arraylist.Text = "Array List";
            tsb_Arraylist.Click += tsb_Arraylist_Click;
            // 
            // tsb_Exit
            // 
            tsb_Exit.Alignment = ToolStripItemAlignment.Right;
            tsb_Exit.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsb_Exit.Image = Properties.Resources.exit_oct_icon;
            tsb_Exit.ImageTransparentColor = Color.Magenta;
            tsb_Exit.Name = "tsb_Exit";
            tsb_Exit.Size = new Size(23, 22);
            tsb_Exit.Text = "Exit";
            tsb_Exit.Click += tsb_Exit_Click;
            // 
            // tsb_Hashtable
            // 
            tsb_Hashtable.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsb_Hashtable.Image = (Image)resources.GetObject("tsb_Hashtable.Image");
            tsb_Hashtable.ImageTransparentColor = Color.Magenta;
            tsb_Hashtable.Name = "tsb_Hashtable";
            tsb_Hashtable.Size = new Size(64, 22);
            tsb_Hashtable.Text = "Hashtable";
            tsb_Hashtable.Click += tsb_Hashtable_Click;
            // 
            // tsnSortedList
            // 
            tsnSortedList.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsnSortedList.Image = (Image)resources.GetObject("tsnSortedList.Image");
            tsnSortedList.ImageTransparentColor = Color.Magenta;
            tsnSortedList.Name = "tsnSortedList";
            tsnSortedList.Size = new Size(66, 22);
            tsnSortedList.Text = "Sorted List";
            tsnSortedList.Click += tsnSortedList_Click;
            // 
            // tsb_Queue
            // 
            tsb_Queue.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsb_Queue.Image = (Image)resources.GetObject("tsb_Queue.Image");
            tsb_Queue.ImageTransparentColor = Color.Magenta;
            tsb_Queue.Name = "tsb_Queue";
            tsb_Queue.Size = new Size(46, 22);
            tsb_Queue.Text = "Queue";
            tsb_Queue.Click += tsb_Queue_Click;
            // 
            // tsb_Stack
            // 
            tsb_Stack.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsb_Stack.Image = (Image)resources.GetObject("tsb_Stack.Image");
            tsb_Stack.ImageTransparentColor = Color.Magenta;
            tsb_Stack.Name = "tsb_Stack";
            tsb_Stack.Size = new Size(39, 22);
            tsb_Stack.Text = "Stack";
            tsb_Stack.Click += tsb_Stack_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsb_List
            // 
            tsb_List.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsb_List.Image = (Image)resources.GetObject("tsb_List.Image");
            tsb_List.ImageTransparentColor = Color.Magenta;
            tsb_List.Name = "tsb_List";
            tsb_List.Size = new Size(29, 22);
            tsb_List.Text = "List";
            tsb_List.Click += tsb_List_Click;
            // 
            // tsb_Dictionary
            // 
            tsb_Dictionary.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsb_Dictionary.Image = (Image)resources.GetObject("tsb_Dictionary.Image");
            tsb_Dictionary.ImageTransparentColor = Color.Magenta;
            tsb_Dictionary.Name = "tsb_Dictionary";
            tsb_Dictionary.Size = new Size(65, 22);
            tsb_Dictionary.Text = "Dictionary";
            tsb_Dictionary.Click += tsb_Dictionary_Click;
            // 
            // tsb_SortedDict
            // 
            tsb_SortedDict.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsb_SortedDict.Image = (Image)resources.GetObject("tsb_SortedDict.Image");
            tsb_SortedDict.ImageTransparentColor = Color.Magenta;
            tsb_SortedDict.Name = "tsb_SortedDict";
            tsb_SortedDict.Size = new Size(69, 22);
            tsb_SortedDict.Text = "Sorted Dict";
            tsb_SortedDict.Click += tsb_SortedDict_Click;
            // 
            // tst_SortedListGen
            // 
            tst_SortedListGen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tst_SortedListGen.Image = (Image)resources.GetObject("tst_SortedListGen.Image");
            tst_SortedListGen.ImageTransparentColor = Color.Magenta;
            tst_SortedListGen.Name = "tst_SortedListGen";
            tst_SortedListGen.Size = new Size(66, 22);
            tst_SortedListGen.Text = "Sorted List";
            tst_SortedListGen.Click += tst_SortedListGen_Click;
            // 
            // tsb_QueueGen
            // 
            tsb_QueueGen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsb_QueueGen.Image = (Image)resources.GetObject("tsb_QueueGen.Image");
            tsb_QueueGen.ImageTransparentColor = Color.Magenta;
            tsb_QueueGen.Name = "tsb_QueueGen";
            tsb_QueueGen.Size = new Size(46, 22);
            tsb_QueueGen.Text = "Queue";
            tsb_QueueGen.Click += tsb_QueueGen_Click;
            // 
            // tsb_StackGen
            // 
            tsb_StackGen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsb_StackGen.Image = (Image)resources.GetObject("tsb_StackGen.Image");
            tsb_StackGen.ImageTransparentColor = Color.Magenta;
            tsb_StackGen.Name = "tsb_StackGen";
            tsb_StackGen.Size = new Size(39, 22);
            tsb_StackGen.Text = "Stack";
            tsb_StackGen.Click += tsb_StackGen_Click;
            // 
            // tsb_LinkedList
            // 
            tsb_LinkedList.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsb_LinkedList.Image = (Image)resources.GetObject("tsb_LinkedList.Image");
            tsb_LinkedList.ImageTransparentColor = Color.Magenta;
            tsb_LinkedList.Name = "tsb_LinkedList";
            tsb_LinkedList.Size = new Size(67, 22);
            tsb_LinkedList.Text = "Linked List";
            tsb_LinkedList.Click += tsb_LinkedList_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 703);
            ControlBox = false;
            Controls.Add(toolStrip1);
            IsMdiContainer = true;
            KeyPreview = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arrays & Lists";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsb_SimpleArray;
        private ToolStripButton tsb_Arraylist;
        private ToolStripButton tsb_Exit;
        private ToolStripButton tsb_Hashtable;
        private ToolStripButton tsnSortedList;
        private ToolStripButton tsb_Queue;
        private ToolStripButton tsb_Stack;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsb_List;
        private ToolStripButton tsb_Dictionary;
        private ToolStripButton tsb_SortedDict;
        private ToolStripButton tst_SortedListGen;
        private ToolStripButton tsb_QueueGen;
        private ToolStripButton tsb_StackGen;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsb_LinkedList;
    }
}