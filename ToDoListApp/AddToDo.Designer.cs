namespace ToDoListApp
{
    partial class AddToDo
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
            DT_DeadLine = new DateTimePicker();
            TB_Title = new TextBox();
            TB_Desc = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            BT_AddToList = new Button();
            SuspendLayout();
            // 
            // DT_DeadLine
            // 
            DT_DeadLine.Location = new Point(103, 70);
            DT_DeadLine.Name = "DT_DeadLine";
            DT_DeadLine.Size = new Size(200, 23);
            DT_DeadLine.TabIndex = 0;
            // 
            // TB_Title
            // 
            TB_Title.Location = new Point(103, 36);
            TB_Title.Name = "TB_Title";
            TB_Title.Size = new Size(200, 23);
            TB_Title.TabIndex = 2;
            // 
            // TB_Desc
            // 
            TB_Desc.Location = new Point(103, 108);
            TB_Desc.Name = "TB_Desc";
            TB_Desc.Size = new Size(457, 214);
            TB_Desc.TabIndex = 3;
            TB_Desc.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 39);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 4;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 111);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 5;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 76);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "DeadLine";
            // 
            // BT_AddToList
            // 
            BT_AddToList.Location = new Point(453, 328);
            BT_AddToList.Name = "BT_AddToList";
            BT_AddToList.Size = new Size(107, 35);
            BT_AddToList.TabIndex = 7;
            BT_AddToList.Text = "Add";
            BT_AddToList.UseVisualStyleBackColor = true;
            BT_AddToList.Click += BT_AddToList_Click;
            // 
            // AddToDo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 411);
            Controls.Add(BT_AddToList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TB_Desc);
            Controls.Add(TB_Title);
            Controls.Add(DT_DeadLine);
            MaximumSize = new Size(600, 450);
            MinimumSize = new Size(600, 450);
            Name = "AddToDo";
            Text = "AddToDo";
            FormClosed += AddToDo_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DT_DeadLine;
        private TextBox TB_Title;
        private RichTextBox TB_Desc;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button BT_AddToList;
    }
}