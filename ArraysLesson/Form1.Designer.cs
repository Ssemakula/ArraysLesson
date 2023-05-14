namespace ArraysLesson
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_AddManual = new Button();
            btn_AddInfinite = new Button();
            btn_AddLimited = new Button();
            lb_ArrayList = new ListBox();
            btn_ForLoop = new Button();
            btn_ForEach = new Button();
            btn_Sort = new Button();
            SuspendLayout();
            // 
            // btn_AddManual
            // 
            btn_AddManual.Location = new Point(34, 19);
            btn_AddManual.Name = "btn_AddManual";
            btn_AddManual.Size = new Size(169, 24);
            btn_AddManual.TabIndex = 0;
            btn_AddManual.Text = "Add Items Manually";
            btn_AddManual.UseVisualStyleBackColor = true;
            btn_AddManual.Click += btn_AddManual_Click;
            // 
            // btn_AddInfinite
            // 
            btn_AddInfinite.Location = new Point(209, 19);
            btn_AddInfinite.Name = "btn_AddInfinite";
            btn_AddInfinite.Size = new Size(169, 24);
            btn_AddInfinite.TabIndex = 1;
            btn_AddInfinite.Text = "Add Items by Infinite Array";
            btn_AddInfinite.UseVisualStyleBackColor = true;
            btn_AddInfinite.Click += btn_AddInfinite_Click;
            btn_AddInfinite.MouseLeave += btn_AddInfinite_RClickLeave;
            btn_AddInfinite.MouseHover += btn_AddInfinite_RClick;
            // 
            // btn_AddLimited
            // 
            btn_AddLimited.Location = new Point(209, 53);
            btn_AddLimited.Name = "btn_AddLimited";
            btn_AddLimited.Size = new Size(169, 24);
            btn_AddLimited.TabIndex = 2;
            btn_AddLimited.Text = "Add Items by Limited Array";
            btn_AddLimited.UseVisualStyleBackColor = true;
            // 
            // lb_ArrayList
            // 
            lb_ArrayList.FormattingEnabled = true;
            lb_ArrayList.ItemHeight = 15;
            lb_ArrayList.Location = new Point(34, 122);
            lb_ArrayList.Name = "lb_ArrayList";
            lb_ArrayList.Size = new Size(344, 304);
            lb_ArrayList.TabIndex = 3;
            // 
            // btn_ForLoop
            // 
            btn_ForLoop.Location = new Point(37, 84);
            btn_ForLoop.Name = "btn_ForLoop";
            btn_ForLoop.Size = new Size(166, 23);
            btn_ForLoop.TabIndex = 4;
            btn_ForLoop.Text = "Use For Loop";
            btn_ForLoop.UseVisualStyleBackColor = true;
            btn_ForLoop.Click += btn_ForLoop_Click;
            // 
            // btn_ForEach
            // 
            btn_ForEach.Location = new Point(209, 84);
            btn_ForEach.Name = "btn_ForEach";
            btn_ForEach.Size = new Size(166, 23);
            btn_ForEach.TabIndex = 5;
            btn_ForEach.Text = "Use For Each";
            btn_ForEach.UseVisualStyleBackColor = true;
            btn_ForEach.Click += btn_ForEach_Click;
            // 
            // btn_Sort
            // 
            btn_Sort.Location = new Point(36, 54);
            btn_Sort.Name = "btn_Sort";
            btn_Sort.Size = new Size(167, 23);
            btn_Sort.TabIndex = 6;
            btn_Sort.Text = "Sort";
            btn_Sort.UseVisualStyleBackColor = true;
            btn_Sort.Click += btn_Sort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 450);
            Controls.Add(btn_Sort);
            Controls.Add(btn_ForEach);
            Controls.Add(btn_ForLoop);
            Controls.Add(lb_ArrayList);
            Controls.Add(btn_AddLimited);
            Controls.Add(btn_AddInfinite);
            Controls.Add(btn_AddManual);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arrays in C#";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_AddManual;
        private Button btn_AddInfinite;
        private Button btn_AddLimited;
        private ListBox lb_ArrayList;
        private Button btn_ForLoop;
        private Button btn_ForEach;
        private Button btn_Sort;
    }
}