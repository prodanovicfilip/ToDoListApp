namespace ToDoListApp
{
    partial class ViewToDo
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
            components = new System.ComponentModel.Container();
            GV_List = new DataGridView();
            CT_Context = new ContextMenuStrip(components);
            TS_Edit = new ToolStripMenuItem();
            TS_Delete = new ToolStripMenuItem();
            TB_Search = new TextBox();
            BT_Search = new Button();
            ((System.ComponentModel.ISupportInitialize)GV_List).BeginInit();
            CT_Context.SuspendLayout();
            SuspendLayout();
            // 
            // GV_List
            // 
            GV_List.AllowUserToAddRows = false;
            GV_List.AllowUserToDeleteRows = false;
            GV_List.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GV_List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GV_List.BorderStyle = BorderStyle.Fixed3D;
            GV_List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GV_List.ContextMenuStrip = CT_Context;
            GV_List.Location = new Point(3, 59);
            GV_List.Name = "GV_List";
            GV_List.ReadOnly = true;
            GV_List.Size = new Size(678, 299);
            GV_List.TabIndex = 0;
            GV_List.MouseDown += GV_List_MouseDown;
            // 
            // CT_Context
            // 
            CT_Context.Items.AddRange(new ToolStripItem[] { TS_Edit, TS_Delete });
            CT_Context.Name = "CT_Context";
            CT_Context.Size = new Size(108, 48);
            // 
            // TS_Edit
            // 
            TS_Edit.Name = "TS_Edit";
            TS_Edit.Size = new Size(107, 22);
            TS_Edit.Text = "Edit";
            TS_Edit.Click += TS_Edit_Click;
            // 
            // TS_Delete
            // 
            TS_Delete.Name = "TS_Delete";
            TS_Delete.Size = new Size(107, 22);
            TS_Delete.Text = "Delete";
            TS_Delete.Click += TS_Delete_Click;
            // 
            // TB_Search
            // 
            TB_Search.Location = new Point(12, 21);
            TB_Search.Name = "TB_Search";
            TB_Search.Size = new Size(239, 23);
            TB_Search.TabIndex = 1;
            // 
            // BT_Search
            // 
            BT_Search.Location = new Point(267, 21);
            BT_Search.Name = "BT_Search";
            BT_Search.Size = new Size(75, 23);
            BT_Search.TabIndex = 2;
            BT_Search.Text = "Search";
            BT_Search.UseVisualStyleBackColor = true;
            BT_Search.Click += BT_Search_Click;
            // 
            // ViewToDo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(BT_Search);
            Controls.Add(TB_Search);
            Controls.Add(GV_List);
            MaximumSize = new Size(700, 700);
            MinimumSize = new Size(700, 400);
            Name = "ViewToDo";
            Text = "ViewToDo";
            Load += ViewToDo_Load;
            ((System.ComponentModel.ISupportInitialize)GV_List).EndInit();
            CT_Context.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GV_List;
        private TextBox TB_Search;
        private Button BT_Search;
        private ContextMenuStrip CT_Context;
        private ToolStripMenuItem TS_Edit;
        private ToolStripMenuItem TS_Delete;
    }
}