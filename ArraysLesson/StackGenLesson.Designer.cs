namespace ArraysLesson
{
    partial class StackGenLesson
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
            btn_Find = new Button();
            lbl_ValueValue = new Label();
            txt_ValueValue = new TextBox();
            txt_FindValue = new TextBox();
            lbl_FindValue = new Label();
            btn_CopyTo = new Button();
            btn_Clear = new Button();
            btn_ForEachQueue = new Button();
            btn_GetSize = new Button();
            btn_Delete = new Button();
            btn_Read = new Button();
            btn_AddItems = new Button();
            btn_Close = new Button();
            pnl_Controls.SuspendLayout();
            SuspendLayout();
            // 
            // ls_Value
            // 
            ls_Value.FormattingEnabled = true;
            ls_Value.ItemHeight = 15;
            ls_Value.Location = new Point(12, 157);
            ls_Value.Name = "ls_Value";
            ls_Value.Size = new Size(379, 334);
            ls_Value.TabIndex = 7;
            // 
            // pnl_Controls
            // 
            pnl_Controls.Controls.Add(btn_Find);
            pnl_Controls.Controls.Add(lbl_ValueValue);
            pnl_Controls.Controls.Add(txt_ValueValue);
            pnl_Controls.Controls.Add(txt_FindValue);
            pnl_Controls.Controls.Add(lbl_FindValue);
            pnl_Controls.Controls.Add(btn_CopyTo);
            pnl_Controls.Controls.Add(btn_Clear);
            pnl_Controls.Controls.Add(btn_ForEachQueue);
            pnl_Controls.Controls.Add(btn_GetSize);
            pnl_Controls.Controls.Add(btn_Delete);
            pnl_Controls.Controls.Add(btn_Read);
            pnl_Controls.Controls.Add(btn_AddItems);
            pnl_Controls.Location = new Point(12, 12);
            pnl_Controls.Name = "pnl_Controls";
            pnl_Controls.Size = new Size(379, 139);
            pnl_Controls.TabIndex = 6;
            // 
            // btn_Find
            // 
            btn_Find.Location = new Point(283, 105);
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
            txt_ValueValue.Size = new Size(294, 23);
            txt_ValueValue.TabIndex = 15;
            // 
            // txt_FindValue
            // 
            txt_FindValue.Location = new Point(91, 107);
            txt_FindValue.Name = "txt_FindValue";
            txt_FindValue.Size = new Size(186, 23);
            txt_FindValue.TabIndex = 13;
            // 
            // lbl_FindValue
            // 
            lbl_FindValue.Location = new Point(19, 108);
            lbl_FindValue.Name = "lbl_FindValue";
            lbl_FindValue.Size = new Size(66, 21);
            lbl_FindValue.TabIndex = 12;
            lbl_FindValue.Text = "Find Value:";
            lbl_FindValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_CopyTo
            // 
            btn_CopyTo.Location = new Point(282, 76);
            btn_CopyTo.Name = "btn_CopyTo";
            btn_CopyTo.Size = new Size(75, 23);
            btn_CopyTo.TabIndex = 9;
            btn_CopyTo.Text = "Copy to";
            btn_CopyTo.UseVisualStyleBackColor = true;
            btn_CopyTo.Click += btn_CopyTo_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(200, 76);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(75, 23);
            btn_Clear.TabIndex = 8;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_ForEachQueue
            // 
            btn_ForEachQueue.Location = new Point(19, 76);
            btn_ForEachQueue.Name = "btn_ForEachQueue";
            btn_ForEachQueue.Size = new Size(174, 23);
            btn_ForEachQueue.TabIndex = 7;
            btn_ForEachQueue.Text = "For Each by Queue";
            btn_ForEachQueue.UseVisualStyleBackColor = true;
            btn_ForEachQueue.Click += btn_ForEachQueue_Click;
            // 
            // btn_GetSize
            // 
            btn_GetSize.Location = new Point(283, 38);
            btn_GetSize.Name = "btn_GetSize";
            btn_GetSize.Size = new Size(75, 23);
            btn_GetSize.TabIndex = 6;
            btn_GetSize.Text = "For Test";
            btn_GetSize.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(184, 38);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(93, 23);
            btn_Delete.TabIndex = 5;
            btn_Delete.Text = "Read & Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Read
            // 
            btn_Read.Location = new Point(103, 38);
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
            // btn_Close
            // 
            btn_Close.Location = new Point(316, 497);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(75, 23);
            btn_Close.TabIndex = 8;
            btn_Close.Text = "Exit";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // StackGenLesson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 525);
            Controls.Add(btn_Close);
            Controls.Add(ls_Value);
            Controls.Add(pnl_Controls);
            Name = "StackGenLesson";
            Text = "StackGenLesson";
            pnl_Controls.ResumeLayout(false);
            pnl_Controls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox ls_Value;
        private Panel pnl_Controls;
        private Button btn_Find;
        private Label lbl_ValueValue;
        private TextBox txt_ValueValue;
        private TextBox txt_FindValue;
        private Label lbl_FindValue;
        private Button btn_CopyTo;
        private Button btn_Clear;
        private Button btn_ForEachQueue;
        private Button btn_GetSize;
        private Button btn_Delete;
        private Button btn_Read;
        private Button btn_AddItems;
        private Button btn_Close;
    }
}