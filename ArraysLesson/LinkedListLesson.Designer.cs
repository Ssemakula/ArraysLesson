namespace ArraysLesson
{
    partial class LinkedListLesson
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
            pnl_Controls = new Panel();
            btn_AddAfter = new Button();
            brn_Read = new Button();
            btn_Find = new Button();
            lbl_ValueValue = new Label();
            txt_ValueValue = new TextBox();
            txt_FindValue = new TextBox();
            lbl_FindValue = new Label();
            btn_CopyTo = new Button();
            btn_Clear = new Button();
            btn_Delete = new Button();
            btn_AddBefore = new Button();
            btn_AddItems = new Button();
            ls_Items = new ListBox();
            pnl_Controls.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Close
            // 
            btn_Close.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Close.Location = new Point(319, 519);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(75, 23);
            btn_Close.TabIndex = 0;
            btn_Close.Text = "Exit";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // pnl_Controls
            // 
            pnl_Controls.Controls.Add(btn_AddAfter);
            pnl_Controls.Controls.Add(brn_Read);
            pnl_Controls.Controls.Add(btn_Find);
            pnl_Controls.Controls.Add(lbl_ValueValue);
            pnl_Controls.Controls.Add(txt_ValueValue);
            pnl_Controls.Controls.Add(txt_FindValue);
            pnl_Controls.Controls.Add(lbl_FindValue);
            pnl_Controls.Controls.Add(btn_CopyTo);
            pnl_Controls.Controls.Add(btn_Clear);
            pnl_Controls.Controls.Add(btn_Delete);
            pnl_Controls.Controls.Add(btn_AddBefore);
            pnl_Controls.Controls.Add(btn_AddItems);
            pnl_Controls.Location = new Point(12, 12);
            pnl_Controls.Name = "pnl_Controls";
            pnl_Controls.Size = new Size(379, 139);
            pnl_Controls.TabIndex = 7;
            // 
            // btn_AddAfter
            // 
            btn_AddAfter.Location = new Point(192, 38);
            btn_AddAfter.Name = "btn_AddAfter";
            btn_AddAfter.Size = new Size(85, 23);
            btn_AddAfter.TabIndex = 8;
            btn_AddAfter.Text = "Add After";
            btn_AddAfter.UseVisualStyleBackColor = true;
            btn_AddAfter.Click += btn_AddAfter_Click;
            // 
            // brn_Read
            // 
            brn_Read.Location = new Point(282, 38);
            brn_Read.Name = "brn_Read";
            brn_Read.Size = new Size(74, 23);
            brn_Read.TabIndex = 8;
            brn_Read.Text = "Read";
            brn_Read.UseVisualStyleBackColor = true;
            // 
            // btn_Find
            // 
            btn_Find.Location = new Point(282, 96);
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
            txt_FindValue.Location = new Point(90, 98);
            txt_FindValue.Name = "txt_FindValue";
            txt_FindValue.Size = new Size(186, 23);
            txt_FindValue.TabIndex = 13;
            // 
            // lbl_FindValue
            // 
            lbl_FindValue.Location = new Point(18, 99);
            lbl_FindValue.Name = "lbl_FindValue";
            lbl_FindValue.Size = new Size(66, 21);
            lbl_FindValue.TabIndex = 12;
            lbl_FindValue.Text = "Find Value:";
            lbl_FindValue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn_CopyTo
            // 
            btn_CopyTo.Location = new Point(281, 67);
            btn_CopyTo.Name = "btn_CopyTo";
            btn_CopyTo.Size = new Size(75, 23);
            btn_CopyTo.TabIndex = 9;
            btn_CopyTo.Text = "Copy to";
            btn_CopyTo.UseVisualStyleBackColor = true;
            btn_CopyTo.Click += btn_CopyTo_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(199, 67);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(75, 23);
            btn_Clear.TabIndex = 8;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(115, 67);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(78, 23);
            btn_Delete.TabIndex = 5;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_AddBefore
            // 
            btn_AddBefore.Location = new Point(102, 38);
            btn_AddBefore.Name = "btn_AddBefore";
            btn_AddBefore.Size = new Size(85, 23);
            btn_AddBefore.TabIndex = 3;
            btn_AddBefore.Text = "Add Before";
            btn_AddBefore.UseVisualStyleBackColor = true;
            btn_AddBefore.Click += btn_AddBefore_Click;
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
            // ls_Items
            // 
            ls_Items.FormattingEnabled = true;
            ls_Items.ItemHeight = 15;
            ls_Items.Location = new Point(15, 156);
            ls_Items.Name = "ls_Items";
            ls_Items.Size = new Size(376, 349);
            ls_Items.TabIndex = 8;
            // 
            // LinkedListLesson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 554);
            Controls.Add(ls_Items);
            Controls.Add(pnl_Controls);
            Controls.Add(btn_Close);
            Name = "LinkedListLesson";
            Text = "LinkedListLesson";
            pnl_Controls.ResumeLayout(false);
            pnl_Controls.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Close;
        private Panel pnl_Controls;
        private Button btn_Find;
        private Label lbl_ValueValue;
        private TextBox txt_ValueValue;
        private TextBox txt_FindValue;
        private Label lbl_FindValue;
        private Button btn_CopyTo;
        private Button btn_Clear;
        private Button btn_Delete;
        private Button btn_AddBefore;
        private Button btn_AddItems;
        private Button brn_Read;
        private Button btn_AddAfter;
        private ListBox ls_Items;
    }
}