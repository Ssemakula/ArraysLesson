﻿namespace ArraysLesson
{
    partial class HashTable
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
            pnl_Controls = new Panel();
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
            btn_ForEachHarsh = new Button();
            btn_GetSize = new Button();
            btn_Delete = new Button();
            btn_Write = new Button();
            btn_Read = new Button();
            btn_AddHashItems = new Button();
            ls_Key = new ListBox();
            ls_Value = new ListBox();
            btn_Close = new Button();
            pnl_Controls.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Controls
            // 
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
            pnl_Controls.Controls.Add(btn_ForEachHarsh);
            pnl_Controls.Controls.Add(btn_GetSize);
            pnl_Controls.Controls.Add(btn_Delete);
            pnl_Controls.Controls.Add(btn_Write);
            pnl_Controls.Controls.Add(btn_Read);
            pnl_Controls.Controls.Add(btn_AddHashItems);
            pnl_Controls.Location = new Point(17, 10);
            pnl_Controls.Name = "pnl_Controls";
            pnl_Controls.Size = new Size(506, 179);
            pnl_Controls.TabIndex = 0;
            // 
            // lbl_ValueValue
            // 
            lbl_ValueValue.AutoSize = true;
            lbl_ValueValue.Location = new Point(265, 9);
            lbl_ValueValue.Name = "lbl_ValueValue";
            lbl_ValueValue.Size = new Size(38, 15);
            lbl_ValueValue.TabIndex = 17;
            lbl_ValueValue.Text = "Value:";
            // 
            // lbl_KeyValue
            // 
            lbl_KeyValue.AutoSize = true;
            lbl_KeyValue.Location = new Point(25, 9);
            lbl_KeyValue.Name = "lbl_KeyValue";
            lbl_KeyValue.Size = new Size(29, 15);
            lbl_KeyValue.TabIndex = 16;
            lbl_KeyValue.Text = "Key:";
            // 
            // txt_ValueValue
            // 
            txt_ValueValue.Location = new Point(309, 5);
            txt_ValueValue.Name = "txt_ValueValue";
            txt_ValueValue.Size = new Size(181, 23);
            txt_ValueValue.TabIndex = 15;
            // 
            // txt_KeyValue
            // 
            txt_KeyValue.Location = new Point(60, 5);
            txt_KeyValue.Name = "txt_KeyValue";
            txt_KeyValue.Size = new Size(187, 23);
            txt_KeyValue.TabIndex = 14;
            // 
            // txt_FindValue
            // 
            txt_FindValue.Location = new Point(94, 141);
            txt_FindValue.Name = "txt_FindValue";
            txt_FindValue.Size = new Size(211, 23);
            txt_FindValue.TabIndex = 13;
            // 
            // lbl_FindValue
            // 
            lbl_FindValue.Location = new Point(22, 142);
            lbl_FindValue.Name = "lbl_FindValue";
            lbl_FindValue.Size = new Size(66, 21);
            lbl_FindValue.TabIndex = 12;
            lbl_FindValue.Text = "Find Value:";
            lbl_FindValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_FindKey
            // 
            txt_FindKey.Location = new Point(94, 112);
            txt_FindKey.Name = "txt_FindKey";
            txt_FindKey.Size = new Size(211, 23);
            txt_FindKey.TabIndex = 11;
            // 
            // lbl_FindKey
            // 
            lbl_FindKey.Location = new Point(22, 113);
            lbl_FindKey.Name = "lbl_FindKey";
            lbl_FindKey.Size = new Size(66, 21);
            lbl_FindKey.TabIndex = 10;
            lbl_FindKey.Text = "Find Key:";
            lbl_FindKey.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_CopyTo
            // 
            btn_CopyTo.Location = new Point(291, 71);
            btn_CopyTo.Name = "btn_CopyTo";
            btn_CopyTo.Size = new Size(75, 23);
            btn_CopyTo.TabIndex = 9;
            btn_CopyTo.Text = "Copy to";
            btn_CopyTo.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(210, 71);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(75, 23);
            btn_Clear.TabIndex = 8;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_ForEachHarsh
            // 
            btn_ForEachHarsh.Location = new Point(20, 71);
            btn_ForEachHarsh.Name = "btn_ForEachHarsh";
            btn_ForEachHarsh.Size = new Size(174, 23);
            btn_ForEachHarsh.TabIndex = 7;
            btn_ForEachHarsh.Text = "For Each Hash";
            btn_ForEachHarsh.UseVisualStyleBackColor = true;
            // 
            // btn_GetSize
            // 
            btn_GetSize.Location = new Point(415, 33);
            btn_GetSize.Name = "btn_GetSize";
            btn_GetSize.Size = new Size(75, 23);
            btn_GetSize.TabIndex = 6;
            btn_GetSize.Text = "Get Size";
            btn_GetSize.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(334, 33);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 23);
            btn_Delete.TabIndex = 5;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Write
            // 
            btn_Write.Location = new Point(253, 33);
            btn_Write.Name = "btn_Write";
            btn_Write.Size = new Size(75, 23);
            btn_Write.TabIndex = 4;
            btn_Write.Text = "Write";
            btn_Write.UseVisualStyleBackColor = true;
            btn_Write.Click += btn_Write_Click;
            // 
            // btn_Read
            // 
            btn_Read.Location = new Point(172, 33);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(75, 23);
            btn_Read.TabIndex = 3;
            btn_Read.Text = "Read";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_AddHashItems
            // 
            btn_AddHashItems.Location = new Point(88, 33);
            btn_AddHashItems.Name = "btn_AddHashItems";
            btn_AddHashItems.Size = new Size(78, 23);
            btn_AddHashItems.TabIndex = 0;
            btn_AddHashItems.Text = "Add Items";
            btn_AddHashItems.UseVisualStyleBackColor = true;
            btn_AddHashItems.Click += btn_AddHashItems_Click;
            // 
            // ls_Key
            // 
            ls_Key.FormattingEnabled = true;
            ls_Key.ItemHeight = 15;
            ls_Key.Location = new Point(27, 210);
            ls_Key.Name = "ls_Key";
            ls_Key.Size = new Size(156, 334);
            ls_Key.TabIndex = 1;
            // 
            // ls_Value
            // 
            ls_Value.FormattingEnabled = true;
            ls_Value.ItemHeight = 15;
            ls_Value.Location = new Point(208, 210);
            ls_Value.Name = "ls_Value";
            ls_Value.Size = new Size(315, 334);
            ls_Value.TabIndex = 2;
            // 
            // btn_Close
            // 
            btn_Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Close.Location = new Point(446, 555);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(75, 23);
            btn_Close.TabIndex = 3;
            btn_Close.Text = "Exit";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // HashTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 581);
            ControlBox = false;
            Controls.Add(btn_Close);
            Controls.Add(ls_Value);
            Controls.Add(ls_Key);
            Controls.Add(pnl_Controls);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "HashTable";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HashTable";
            pnl_Controls.ResumeLayout(false);
            pnl_Controls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Controls;
        private TextBox txt_FindValue;
        private Label lbl_FindValue;
        private TextBox txt_FindKey;
        private Label lbl_FindKey;
        private Button btn_CopyTo;
        private Button btn_Clear;
        private Button btn_ForEachHarsh;
        private Button btn_GetSize;
        private Button btn_Delete;
        private Button btn_Write;
        private Button btn_Read;
        private Button btn_AddHashItems;
        private ListBox ls_Key;
        private ListBox ls_Value;
        private Button btn_Close;
        private Label lbl_ValueValue;
        private Label lbl_KeyValue;
        private TextBox txt_ValueValue;
        private TextBox txt_KeyValue;
    }
}