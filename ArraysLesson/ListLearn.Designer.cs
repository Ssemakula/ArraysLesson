namespace ArraysLesson
{
    partial class ListLearn
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
            ls_Value = new ListBox();
            pnl_Controls = new Panel();
            txt_Index = new TextBox();
            lbl_Index = new Label();
            btn_Insert = new Button();
            btn_SortDesc = new Button();
            btn_SortAsc = new Button();
            btn_NoSort = new Button();
            btn_Find = new Button();
            lbl_ValueValue = new Label();
            txt_ValueValue = new TextBox();
            txt_FindValue = new TextBox();
            lbl_FindValue = new Label();
            btn_CopyTo = new Button();
            btn_Clear = new Button();
            btn_ForEachQueue = new Button();
            btn_Write = new Button();
            btn_Delete = new Button();
            btn_Read = new Button();
            btn_AddItems = new Button();
            pnl_Controls.SuspendLayout();
            SuspendLayout();
            // 
            // ls_Value
            // 
            ls_Value.FormattingEnabled = true;
            ls_Value.ItemHeight = 15;
            ls_Value.Location = new Point(12, 194);
            ls_Value.Name = "ls_Value";
            ls_Value.Size = new Size(379, 334);
            ls_Value.TabIndex = 5;
            // 
            // pnl_Controls
            // 
            pnl_Controls.Controls.Add(txt_Index);
            pnl_Controls.Controls.Add(lbl_Index);
            pnl_Controls.Controls.Add(btn_Insert);
            pnl_Controls.Controls.Add(btn_SortDesc);
            pnl_Controls.Controls.Add(btn_SortAsc);
            pnl_Controls.Controls.Add(btn_NoSort);
            pnl_Controls.Controls.Add(btn_Find);
            pnl_Controls.Controls.Add(lbl_ValueValue);
            pnl_Controls.Controls.Add(txt_ValueValue);
            pnl_Controls.Controls.Add(txt_FindValue);
            pnl_Controls.Controls.Add(lbl_FindValue);
            pnl_Controls.Controls.Add(btn_CopyTo);
            pnl_Controls.Controls.Add(btn_Clear);
            pnl_Controls.Controls.Add(btn_ForEachQueue);
            pnl_Controls.Controls.Add(btn_Write);
            pnl_Controls.Controls.Add(btn_Delete);
            pnl_Controls.Controls.Add(btn_Read);
            pnl_Controls.Controls.Add(btn_AddItems);
            pnl_Controls.Location = new Point(12, 12);
            pnl_Controls.Name = "pnl_Controls";
            pnl_Controls.Size = new Size(379, 176);
            pnl_Controls.TabIndex = 4;
            // 
            // txt_Index
            // 
            txt_Index.Location = new Point(277, 9);
            txt_Index.Name = "txt_Index";
            txt_Index.Size = new Size(81, 23);
            txt_Index.TabIndex = 24;
            // 
            // lbl_Index
            // 
            lbl_Index.AutoSize = true;
            lbl_Index.Location = new Point(235, 13);
            lbl_Index.Name = "lbl_Index";
            lbl_Index.Size = new Size(39, 15);
            lbl_Index.TabIndex = 23;
            lbl_Index.Text = "Index:";
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(283, 38);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(75, 23);
            btn_Insert.TabIndex = 22;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // btn_SortDesc
            // 
            btn_SortDesc.Location = new Point(251, 105);
            btn_SortDesc.Name = "btn_SortDesc";
            btn_SortDesc.Size = new Size(107, 23);
            btn_SortDesc.TabIndex = 21;
            btn_SortDesc.Text = "Sort Descending";
            btn_SortDesc.UseVisualStyleBackColor = true;
            btn_SortDesc.Click += btn_SortDesc_Click;
            // 
            // btn_SortAsc
            // 
            btn_SortAsc.Location = new Point(135, 105);
            btn_SortAsc.Name = "btn_SortAsc";
            btn_SortAsc.Size = new Size(107, 23);
            btn_SortAsc.TabIndex = 20;
            btn_SortAsc.Text = "Sort Ascending";
            btn_SortAsc.UseVisualStyleBackColor = true;
            btn_SortAsc.Click += btn_SortAsc_Click;
            // 
            // btn_NoSort
            // 
            btn_NoSort.Location = new Point(19, 105);
            btn_NoSort.Name = "btn_NoSort";
            btn_NoSort.Size = new Size(107, 23);
            btn_NoSort.TabIndex = 19;
            btn_NoSort.Text = "Not Sorted";
            btn_NoSort.UseVisualStyleBackColor = true;
            // 
            // btn_Find
            // 
            btn_Find.Location = new Point(283, 142);
            btn_Find.Name = "btn_Find";
            btn_Find.Size = new Size(75, 23);
            btn_Find.TabIndex = 18;
            btn_Find.Text = "Find";
            btn_Find.UseVisualStyleBackColor = true;
            btn_Find.Click += btn_Find_Click;
            // 
            // lbl_ValueValue
            // 
            lbl_ValueValue.AutoSize = true;
            lbl_ValueValue.Location = new Point(19, 13);
            lbl_ValueValue.Name = "lbl_ValueValue";
            lbl_ValueValue.Size = new Size(38, 15);
            lbl_ValueValue.TabIndex = 17;
            lbl_ValueValue.Text = "Value:";
            // 
            // txt_ValueValue
            // 
            txt_ValueValue.Location = new Point(63, 9);
            txt_ValueValue.Name = "txt_ValueValue";
            txt_ValueValue.Size = new Size(166, 23);
            txt_ValueValue.TabIndex = 15;
            // 
            // txt_FindValue
            // 
            txt_FindValue.Location = new Point(91, 144);
            txt_FindValue.Name = "txt_FindValue";
            txt_FindValue.Size = new Size(186, 23);
            txt_FindValue.TabIndex = 13;
            // 
            // lbl_FindValue
            // 
            lbl_FindValue.Location = new Point(19, 145);
            lbl_FindValue.Name = "lbl_FindValue";
            lbl_FindValue.Size = new Size(66, 21);
            lbl_FindValue.TabIndex = 12;
            lbl_FindValue.Text = "Find Item:";
            lbl_FindValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_CopyTo
            // 
            btn_CopyTo.Location = new Point(283, 72);
            btn_CopyTo.Name = "btn_CopyTo";
            btn_CopyTo.Size = new Size(75, 23);
            btn_CopyTo.TabIndex = 9;
            btn_CopyTo.Text = "Copy to";
            btn_CopyTo.UseVisualStyleBackColor = true;
            btn_CopyTo.Click += btn_CopyTo_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(105, 72);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(75, 23);
            btn_Clear.TabIndex = 8;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_ForEachQueue
            // 
            btn_ForEachQueue.Location = new Point(16, 72);
            btn_ForEachQueue.Name = "btn_ForEachQueue";
            btn_ForEachQueue.Size = new Size(75, 23);
            btn_ForEachQueue.TabIndex = 7;
            btn_ForEachQueue.Text = "For Each";
            btn_ForEachQueue.UseVisualStyleBackColor = true;
            // 
            // btn_Write
            // 
            btn_Write.Location = new Point(196, 38);
            btn_Write.Name = "btn_Write";
            btn_Write.Size = new Size(75, 23);
            btn_Write.TabIndex = 6;
            btn_Write.Text = "Change";
            btn_Write.UseVisualStyleBackColor = true;
            btn_Write.Click += btn_Write_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(196, 72);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 23);
            btn_Delete.TabIndex = 5;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Read
            // 
            btn_Read.Location = new Point(109, 38);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(75, 23);
            btn_Read.TabIndex = 3;
            btn_Read.Text = "Read";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_AddItems
            // 
            btn_AddItems.Location = new Point(19, 38);
            btn_AddItems.Name = "btn_AddItems";
            btn_AddItems.Size = new Size(78, 23);
            btn_AddItems.TabIndex = 0;
            btn_AddItems.Text = "Add Items";
            btn_AddItems.UseVisualStyleBackColor = true;
            btn_AddItems.Click += btn_AddItems_Click;
            // 
            // ListLearn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 547);
            Controls.Add(ls_Value);
            Controls.Add(pnl_Controls);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ListLearn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListLearn";
            pnl_Controls.ResumeLayout(false);
            pnl_Controls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox ls_Value;
        private Panel pnl_Controls;
        private Button btn_Insert;
        private Button btn_SortDesc;
        private Button btn_SortAsc;
        private Button btn_NoSort;
        private Button btn_Find;
        private Label lbl_ValueValue;
        private TextBox txt_ValueValue;
        private TextBox txt_FindValue;
        private Label lbl_FindValue;
        private Button btn_CopyTo;
        private Button btn_Clear;
        private Button btn_ForEachQueue;
        private Button btn_Write;
        private Button btn_Delete;
        private Button btn_Read;
        private Button btn_AddItems;
        private TextBox txt_Index;
        private Label lbl_Index;
    }
}