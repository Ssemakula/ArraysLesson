namespace ArraysLesson
{
    partial class SortedListLearn
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
            btn_Close = new Button();
            ls_Value = new ListBox();
            ls_Key = new ListBox();
            pnl_Controls = new Panel();
            btn_SearchValue = new Button();
            btn_SearchKey = new Button();
            btn_ReadIndex = new Button();
            btn_For = new Button();
            lbl_ValueValue = new Label();
            lbl_KeyValue = new Label();
            txt_ValueValue = new TextBox();
            txt_KeyValue = new TextBox();
            txt_FindValue = new TextBox();
            lbl_FindValue = new Label();
            txt_FindKey = new TextBox();
            lbl_FindKey = new Label();
            btn_CopyTo = new Button();
            btn_Clear = new Button();
            btn_ForEach = new Button();
            btn_Delete = new Button();
            btn_Write = new Button();
            btn_Read = new Button();
            btn_AddItems = new Button();
            pnl_Controls.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Close
            // 
            btn_Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Close.Location = new Point(443, 537);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(75, 23);
            btn_Close.TabIndex = 7;
            btn_Close.Text = "Exit";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // ls_Value
            // 
            ls_Value.FormattingEnabled = true;
            ls_Value.ItemHeight = 15;
            ls_Value.Location = new Point(203, 197);
            ls_Value.Name = "ls_Value";
            ls_Value.Size = new Size(315, 334);
            ls_Value.TabIndex = 6;
            // 
            // ls_Key
            // 
            ls_Key.FormattingEnabled = true;
            ls_Key.ItemHeight = 15;
            ls_Key.Location = new Point(12, 197);
            ls_Key.Name = "ls_Key";
            ls_Key.Size = new Size(191, 334);
            ls_Key.TabIndex = 5;
            // 
            // pnl_Controls
            // 
            pnl_Controls.Controls.Add(btn_SearchValue);
            pnl_Controls.Controls.Add(btn_SearchKey);
            pnl_Controls.Controls.Add(btn_ReadIndex);
            pnl_Controls.Controls.Add(btn_For);
            pnl_Controls.Controls.Add(lbl_ValueValue);
            pnl_Controls.Controls.Add(lbl_KeyValue);
            pnl_Controls.Controls.Add(txt_ValueValue);
            pnl_Controls.Controls.Add(txt_KeyValue);
            pnl_Controls.Controls.Add(txt_FindValue);
            pnl_Controls.Controls.Add(lbl_FindValue);
            pnl_Controls.Controls.Add(txt_FindKey);
            pnl_Controls.Controls.Add(lbl_FindKey);
            pnl_Controls.Controls.Add(btn_CopyTo);
            pnl_Controls.Controls.Add(btn_Clear);
            pnl_Controls.Controls.Add(btn_ForEach);
            pnl_Controls.Controls.Add(btn_Delete);
            pnl_Controls.Controls.Add(btn_Write);
            pnl_Controls.Controls.Add(btn_Read);
            pnl_Controls.Controls.Add(btn_AddItems);
            pnl_Controls.Location = new Point(12, 12);
            pnl_Controls.Name = "pnl_Controls";
            pnl_Controls.Size = new Size(506, 179);
            pnl_Controls.TabIndex = 4;
            // 
            // btn_SearchValue
            // 
            btn_SearchValue.Location = new Point(328, 145);
            btn_SearchValue.Name = "btn_SearchValue";
            btn_SearchValue.Size = new Size(128, 23);
            btn_SearchValue.TabIndex = 21;
            btn_SearchValue.Text = "Search";
            btn_SearchValue.UseVisualStyleBackColor = true;
            btn_SearchValue.Click += btn_SearchValue_Click;
            // 
            // btn_SearchKey
            // 
            btn_SearchKey.Location = new Point(328, 117);
            btn_SearchKey.Name = "btn_SearchKey";
            btn_SearchKey.Size = new Size(128, 23);
            btn_SearchKey.TabIndex = 20;
            btn_SearchKey.Text = "Search";
            btn_SearchKey.UseVisualStyleBackColor = true;
            btn_SearchKey.Click += btn_SearchKey_Click;
            // 
            // btn_ReadIndex
            // 
            btn_ReadIndex.Location = new Point(216, 39);
            btn_ReadIndex.Name = "btn_ReadIndex";
            btn_ReadIndex.Size = new Size(75, 23);
            btn_ReadIndex.TabIndex = 19;
            btn_ReadIndex.Text = "Read Index";
            btn_ReadIndex.UseVisualStyleBackColor = true;
            btn_ReadIndex.Click += btn_ReadIndex_Click;
            // 
            // btn_For
            // 
            btn_For.Location = new Point(166, 76);
            btn_For.Name = "btn_For";
            btn_For.Size = new Size(128, 23);
            btn_For.TabIndex = 18;
            btn_For.Text = "For";
            btn_For.UseVisualStyleBackColor = true;
            btn_For.Click += btn_For_Click;
            // 
            // lbl_ValueValue
            // 
            lbl_ValueValue.AutoSize = true;
            lbl_ValueValue.Location = new Point(262, 14);
            lbl_ValueValue.Name = "lbl_ValueValue";
            lbl_ValueValue.Size = new Size(38, 15);
            lbl_ValueValue.TabIndex = 17;
            lbl_ValueValue.Text = "Value:";
            // 
            // lbl_KeyValue
            // 
            lbl_KeyValue.AutoSize = true;
            lbl_KeyValue.Location = new Point(22, 14);
            lbl_KeyValue.Name = "lbl_KeyValue";
            lbl_KeyValue.Size = new Size(29, 15);
            lbl_KeyValue.TabIndex = 16;
            lbl_KeyValue.Text = "Key:";
            // 
            // txt_ValueValue
            // 
            txt_ValueValue.Location = new Point(306, 10);
            txt_ValueValue.Name = "txt_ValueValue";
            txt_ValueValue.Size = new Size(181, 23);
            txt_ValueValue.TabIndex = 15;
            // 
            // txt_KeyValue
            // 
            txt_KeyValue.Location = new Point(57, 10);
            txt_KeyValue.Name = "txt_KeyValue";
            txt_KeyValue.Size = new Size(187, 23);
            txt_KeyValue.TabIndex = 14;
            // 
            // txt_FindValue
            // 
            txt_FindValue.Location = new Point(91, 146);
            txt_FindValue.Name = "txt_FindValue";
            txt_FindValue.Size = new Size(211, 23);
            txt_FindValue.TabIndex = 13;
            // 
            // lbl_FindValue
            // 
            lbl_FindValue.Location = new Point(19, 147);
            lbl_FindValue.Name = "lbl_FindValue";
            lbl_FindValue.Size = new Size(66, 21);
            lbl_FindValue.TabIndex = 12;
            lbl_FindValue.Text = "Find Value:";
            lbl_FindValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_FindKey
            // 
            txt_FindKey.Location = new Point(91, 117);
            txt_FindKey.Name = "txt_FindKey";
            txt_FindKey.Size = new Size(211, 23);
            txt_FindKey.TabIndex = 11;
            // 
            // lbl_FindKey
            // 
            lbl_FindKey.Location = new Point(19, 118);
            lbl_FindKey.Name = "lbl_FindKey";
            lbl_FindKey.Size = new Size(66, 21);
            lbl_FindKey.TabIndex = 10;
            lbl_FindKey.Text = "Find Key:";
            lbl_FindKey.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_CopyTo
            // 
            btn_CopyTo.Location = new Point(411, 76);
            btn_CopyTo.Name = "btn_CopyTo";
            btn_CopyTo.Size = new Size(75, 23);
            btn_CopyTo.TabIndex = 9;
            btn_CopyTo.Text = "Copy to";
            btn_CopyTo.UseVisualStyleBackColor = true;
            btn_CopyTo.Click += btn_CopyTo_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(315, 76);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(75, 23);
            btn_Clear.TabIndex = 8;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_ForEach
            // 
            btn_ForEach.Location = new Point(17, 76);
            btn_ForEach.Name = "btn_ForEach";
            btn_ForEach.Size = new Size(128, 23);
            btn_ForEach.TabIndex = 7;
            btn_ForEach.Text = "For Each";
            btn_ForEach.UseVisualStyleBackColor = true;
            btn_ForEach.Click += btn_ForEach_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(410, 39);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 23);
            btn_Delete.TabIndex = 5;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Write
            // 
            btn_Write.Location = new Point(313, 39);
            btn_Write.Name = "btn_Write";
            btn_Write.Size = new Size(75, 23);
            btn_Write.TabIndex = 4;
            btn_Write.Text = "Write";
            btn_Write.UseVisualStyleBackColor = true;
            btn_Write.Click += btn_Write_Click;
            // 
            // btn_Read
            // 
            btn_Read.Location = new Point(119, 39);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(75, 23);
            btn_Read.TabIndex = 3;
            btn_Read.Text = "Read";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_AddItems
            // 
            btn_AddItems.Location = new Point(19, 39);
            btn_AddItems.Name = "btn_AddItems";
            btn_AddItems.Size = new Size(78, 23);
            btn_AddItems.TabIndex = 0;
            btn_AddItems.Text = "Add Items";
            btn_AddItems.UseVisualStyleBackColor = true;
            btn_AddItems.Click += btn_AddItems_Click;
            // 
            // SortedListLearn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 570);
            Controls.Add(btn_Close);
            Controls.Add(ls_Value);
            Controls.Add(ls_Key);
            Controls.Add(pnl_Controls);
            Name = "SortedListLearn";
            Text = "Sorted List";
            pnl_Controls.ResumeLayout(false);
            pnl_Controls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Close;
        private ListBox ls_Value;
        private ListBox ls_Key;
        private Panel pnl_Controls;
        private Label lbl_ValueValue;
        private Label lbl_KeyValue;
        private TextBox txt_ValueValue;
        private TextBox txt_KeyValue;
        private TextBox txt_FindValue;
        private Label lbl_FindValue;
        private TextBox txt_FindKey;
        private Label lbl_FindKey;
        private Button btn_CopyTo;
        private Button btn_Clear;
        private Button btn_ForEach;
        private Button btn_Delete;
        private Button btn_Write;
        private Button btn_Read;
        private Button btn_AddItems;
        private Button btn_For;
        private Button btn_ReadIndex;
        private Button btn_SearchValue;
        private Button btn_SearchKey;
    }
}