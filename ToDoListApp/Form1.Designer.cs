namespace ToDoListApp
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
            BT_View = new Button();
            BT_ADD = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // BT_View
            // 
            BT_View.Anchor = AnchorStyles.Bottom;
            BT_View.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(BT_View, 2);
            BT_View.Font = new Font("Segoe UI", 12F);
            BT_View.Location = new Point(192, 66);
            BT_View.MinimumSize = new Size(200, 62);
            BT_View.Name = "BT_View";
            BT_View.Size = new Size(200, 62);
            BT_View.TabIndex = 0;
            BT_View.Text = "View TO DO";
            BT_View.UseVisualStyleBackColor = true;
            BT_View.Click += BT_View_Click;
            // 
            // BT_ADD
            // 
            BT_ADD.Anchor = AnchorStyles.Top;
            BT_ADD.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.SetColumnSpan(BT_ADD, 2);
            BT_ADD.Font = new Font("Segoe UI", 12F);
            BT_ADD.Location = new Point(192, 134);
            BT_ADD.Name = "BT_ADD";
            BT_ADD.Size = new Size(200, 62);
            BT_ADD.TabIndex = 1;
            BT_ADD.Text = "Add TO DO";
            BT_ADD.UseVisualStyleBackColor = true;
            BT_ADD.Click += BT_ADD_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(BT_View, 0, 0);
            tableLayoutPanel1.Controls.Add(BT_ADD, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(585, 263);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(700, 350);
            MinimumSize = new Size(300, 300);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button BT_View;
        private Button BT_ADD;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
