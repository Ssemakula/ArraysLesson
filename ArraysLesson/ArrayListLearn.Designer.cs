namespace ArraysLesson
{
    partial class ArrayListLearn
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
            btn_Arraylist1 = new Button();
            lb_Items = new ListBox();
            btn_varArray = new Button();
            lbl_Search = new Label();
            txt_Search = new TextBox();
            btn_Read = new Button();
            btn_Write = new Button();
            btn_Delete = new Button();
            btn_Copy = new Button();
            SuspendLayout();
            // 
            // btn_Arraylist1
            // 
            btn_Arraylist1.Location = new Point(35, 31);
            btn_Arraylist1.Name = "btn_Arraylist1";
            btn_Arraylist1.Size = new Size(195, 23);
            btn_Arraylist1.TabIndex = 0;
            btn_Arraylist1.Text = "Add Items by Arraylist";
            btn_Arraylist1.UseVisualStyleBackColor = true;
            btn_Arraylist1.Click += btn_Arraylist1_Click;
            // 
            // lb_Items
            // 
            lb_Items.FormattingEnabled = true;
            lb_Items.ItemHeight = 15;
            lb_Items.Location = new Point(35, 116);
            lb_Items.Name = "lb_Items";
            lb_Items.Size = new Size(506, 394);
            lb_Items.TabIndex = 1;
            // 
            // btn_varArray
            // 
            btn_varArray.Location = new Point(265, 31);
            btn_varArray.Name = "btn_varArray";
            btn_varArray.Size = new Size(195, 23);
            btn_varArray.TabIndex = 2;
            btn_varArray.Text = "Add Items by var";
            btn_varArray.UseVisualStyleBackColor = true;
            btn_varArray.Click += btn_varArray_Click;
            // 
            // lbl_Search
            // 
            lbl_Search.Location = new Point(38, 67);
            lbl_Search.Name = "lbl_Search";
            lbl_Search.Size = new Size(67, 23);
            lbl_Search.TabIndex = 3;
            lbl_Search.Text = "Item Index";
            lbl_Search.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(109, 67);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(100, 23);
            txt_Search.TabIndex = 4;
            // 
            // btn_Read
            // 
            btn_Read.Location = new Point(223, 67);
            btn_Read.Name = "btn_Read";
            btn_Read.Size = new Size(75, 23);
            btn_Read.TabIndex = 5;
            btn_Read.Text = "Read";
            btn_Read.UseVisualStyleBackColor = true;
            btn_Read.Click += btn_Read_Click;
            // 
            // btn_Write
            // 
            btn_Write.Location = new Point(304, 67);
            btn_Write.Name = "btn_Write";
            btn_Write.Size = new Size(75, 23);
            btn_Write.TabIndex = 6;
            btn_Write.Text = "Write";
            btn_Write.UseVisualStyleBackColor = true;
            btn_Write.Click += btn_Write_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(385, 67);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(75, 23);
            btn_Delete.TabIndex = 7;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Copy
            // 
            btn_Copy.Location = new Point(466, 67);
            btn_Copy.Name = "btn_Copy";
            btn_Copy.Size = new Size(75, 23);
            btn_Copy.TabIndex = 8;
            btn_Copy.Text = "Copy";
            btn_Copy.UseVisualStyleBackColor = true;
            btn_Copy.Click += btn_Copy_Click;
            // 
            // ArrayListLearn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 543);
            Controls.Add(btn_Copy);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Write);
            Controls.Add(btn_Read);
            Controls.Add(txt_Search);
            Controls.Add(lbl_Search);
            Controls.Add(btn_varArray);
            Controls.Add(lb_Items);
            Controls.Add(btn_Arraylist1);
            Name = "ArrayListLearn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ArrayList";
            Load += ArrayListLearn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Arraylist1;
        private ListBox lb_Items;
        private Button btn_varArray;
        private Label lbl_Search;
        private TextBox txt_Search;
        private Button btn_Read;
        private Button btn_Write;
        private Button btn_Delete;
        private Button btn_Copy;
    }
}