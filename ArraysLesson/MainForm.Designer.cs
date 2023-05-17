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
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsb_SimpleArray, tsb_Arraylist, tsb_Exit, tsb_Hashtable, tsnSortedList, tsb_Queue, tsb_Stack, toolStripSeparator1, tsb_List });
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 703);
            ControlBox = false;
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            KeyPreview = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
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
    }
}