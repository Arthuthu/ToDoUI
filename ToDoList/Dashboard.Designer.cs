namespace ToDoList
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.shortTermLabel = new System.Windows.Forms.Label();
            this.midTermLabel = new System.Windows.Forms.Label();
            this.longTermLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.longTermGoalPanel = new System.Windows.Forms.Panel();
            this.longTermAddButton = new System.Windows.Forms.Button();
            this.longTermTexBox = new System.Windows.Forms.TextBox();
            this.midTermGoalPanel = new System.Windows.Forms.Panel();
            this.midTermAddButton = new System.Windows.Forms.Button();
            this.midTermTexBox = new System.Windows.Forms.TextBox();
            this.shortTermGoalPanel = new System.Windows.Forms.Panel();
            this.shortTermAddButton = new System.Windows.Forms.Button();
            this.shortTermTexBox = new System.Windows.Forms.TextBox();
            this.deletedCompletedGoalButton = new System.Windows.Forms.Button();
            this.searchCompletedGoalsButton = new System.Windows.Forms.Button();
            this.searchAllButton = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.goalsListbox = new System.Windows.Forms.ListBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.longTermSearchButton = new System.Windows.Forms.Button();
            this.shortTermSearchButton = new System.Windows.Forms.Button();
            this.midTermSearchButton = new System.Windows.Forms.Button();
            this.completeButtonPanel = new System.Windows.Forms.Panel();
            this.deleteButtonPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.deleteCompletedGoalPanel = new System.Windows.Forms.Panel();
            this.completedGoalPanel = new System.Windows.Forms.Panel();
            this.searchCompleteGoalsPanel = new System.Windows.Forms.Panel();
            this.serchAllListsPanel = new System.Windows.Forms.Panel();
            this.searchLongTermListPanel = new System.Windows.Forms.Panel();
            this.searchMidTermListPanel = new System.Windows.Forms.Panel();
            this.searchShortTermListPanel = new System.Windows.Forms.Panel();
            this.emptyPanel = new System.Windows.Forms.Panel();
            this.displayListNamePanel = new System.Windows.Forms.Panel();
            this.displayListNameButton = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            this.longTermGoalPanel.SuspendLayout();
            this.midTermGoalPanel.SuspendLayout();
            this.shortTermGoalPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.completeButtonPanel.SuspendLayout();
            this.deleteButtonPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.deleteCompletedGoalPanel.SuspendLayout();
            this.completedGoalPanel.SuspendLayout();
            this.searchCompleteGoalsPanel.SuspendLayout();
            this.serchAllListsPanel.SuspendLayout();
            this.searchLongTermListPanel.SuspendLayout();
            this.searchMidTermListPanel.SuspendLayout();
            this.searchShortTermListPanel.SuspendLayout();
            this.displayListNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // shortTermLabel
            // 
            this.shortTermLabel.AutoSize = true;
            this.shortTermLabel.ForeColor = System.Drawing.Color.White;
            this.shortTermLabel.Location = new System.Drawing.Point(12, 9);
            this.shortTermLabel.Name = "shortTermLabel";
            this.shortTermLabel.Size = new System.Drawing.Size(170, 30);
            this.shortTermLabel.TabIndex = 10;
            this.shortTermLabel.Text = "Short Term Goals";
            // 
            // midTermLabel
            // 
            this.midTermLabel.AutoSize = true;
            this.midTermLabel.ForeColor = System.Drawing.Color.White;
            this.midTermLabel.Location = new System.Drawing.Point(12, 0);
            this.midTermLabel.Name = "midTermLabel";
            this.midTermLabel.Size = new System.Drawing.Size(157, 30);
            this.midTermLabel.TabIndex = 12;
            this.midTermLabel.Text = "Mid Term Goals";
            // 
            // longTermLabel
            // 
            this.longTermLabel.AutoSize = true;
            this.longTermLabel.ForeColor = System.Drawing.Color.White;
            this.longTermLabel.Location = new System.Drawing.Point(12, 3);
            this.longTermLabel.Name = "longTermLabel";
            this.longTermLabel.Size = new System.Drawing.Size(167, 30);
            this.longTermLabel.TabIndex = 14;
            this.longTermLabel.Text = "Long Term Goals";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.topPanel.Controls.Add(this.longTermGoalPanel);
            this.topPanel.Controls.Add(this.midTermGoalPanel);
            this.topPanel.Controls.Add(this.shortTermGoalPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.topPanel.Location = new System.Drawing.Point(305, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1092, 269);
            this.topPanel.TabIndex = 7;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // longTermGoalPanel
            // 
            this.longTermGoalPanel.Controls.Add(this.longTermLabel);
            this.longTermGoalPanel.Controls.Add(this.longTermAddButton);
            this.longTermGoalPanel.Controls.Add(this.longTermTexBox);
            this.longTermGoalPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.longTermGoalPanel.Location = new System.Drawing.Point(0, 180);
            this.longTermGoalPanel.Name = "longTermGoalPanel";
            this.longTermGoalPanel.Size = new System.Drawing.Size(1092, 90);
            this.longTermGoalPanel.TabIndex = 29;
            // 
            // longTermAddButton
            // 
            this.longTermAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.longTermAddButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.longTermAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.longTermAddButton.ForeColor = System.Drawing.Color.White;
            this.longTermAddButton.Location = new System.Drawing.Point(946, 0);
            this.longTermAddButton.Margin = new System.Windows.Forms.Padding(0);
            this.longTermAddButton.Name = "longTermAddButton";
            this.longTermAddButton.Size = new System.Drawing.Size(146, 90);
            this.longTermAddButton.TabIndex = 6;
            this.longTermAddButton.Text = "Add long term goal";
            this.longTermAddButton.UseVisualStyleBackColor = false;
            this.longTermAddButton.Click += new System.EventHandler(this.shortTermAddButton_Click);
            // 
            // longTermTexBox
            // 
            this.longTermTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.longTermTexBox.Location = new System.Drawing.Point(17, 36);
            this.longTermTexBox.Name = "longTermTexBox";
            this.longTermTexBox.Size = new System.Drawing.Size(913, 35);
            this.longTermTexBox.TabIndex = 5;
            // 
            // midTermGoalPanel
            // 
            this.midTermGoalPanel.Controls.Add(this.midTermAddButton);
            this.midTermGoalPanel.Controls.Add(this.midTermLabel);
            this.midTermGoalPanel.Controls.Add(this.midTermTexBox);
            this.midTermGoalPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.midTermGoalPanel.Location = new System.Drawing.Point(0, 90);
            this.midTermGoalPanel.Name = "midTermGoalPanel";
            this.midTermGoalPanel.Size = new System.Drawing.Size(1092, 90);
            this.midTermGoalPanel.TabIndex = 28;
            // 
            // midTermAddButton
            // 
            this.midTermAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.midTermAddButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.midTermAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.midTermAddButton.ForeColor = System.Drawing.Color.White;
            this.midTermAddButton.Location = new System.Drawing.Point(946, 0);
            this.midTermAddButton.Margin = new System.Windows.Forms.Padding(0);
            this.midTermAddButton.Name = "midTermAddButton";
            this.midTermAddButton.Size = new System.Drawing.Size(146, 90);
            this.midTermAddButton.TabIndex = 4;
            this.midTermAddButton.Text = "Add mid term goal";
            this.midTermAddButton.UseVisualStyleBackColor = false;
            this.midTermAddButton.Click += new System.EventHandler(this.midTermAddButton_Click);
            // 
            // midTermTexBox
            // 
            this.midTermTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.midTermTexBox.Location = new System.Drawing.Point(12, 33);
            this.midTermTexBox.Name = "midTermTexBox";
            this.midTermTexBox.Size = new System.Drawing.Size(918, 35);
            this.midTermTexBox.TabIndex = 3;
            // 
            // shortTermGoalPanel
            // 
            this.shortTermGoalPanel.Controls.Add(this.shortTermAddButton);
            this.shortTermGoalPanel.Controls.Add(this.shortTermLabel);
            this.shortTermGoalPanel.Controls.Add(this.shortTermTexBox);
            this.shortTermGoalPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shortTermGoalPanel.Location = new System.Drawing.Point(0, 0);
            this.shortTermGoalPanel.Name = "shortTermGoalPanel";
            this.shortTermGoalPanel.Size = new System.Drawing.Size(1092, 90);
            this.shortTermGoalPanel.TabIndex = 27;
            // 
            // shortTermAddButton
            // 
            this.shortTermAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.shortTermAddButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.shortTermAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shortTermAddButton.ForeColor = System.Drawing.Color.White;
            this.shortTermAddButton.Location = new System.Drawing.Point(946, 0);
            this.shortTermAddButton.Margin = new System.Windows.Forms.Padding(0);
            this.shortTermAddButton.Name = "shortTermAddButton";
            this.shortTermAddButton.Size = new System.Drawing.Size(146, 90);
            this.shortTermAddButton.TabIndex = 2;
            this.shortTermAddButton.Text = "Add short term goal";
            this.shortTermAddButton.UseVisualStyleBackColor = false;
            this.shortTermAddButton.Click += new System.EventHandler(this.longTermAddButton_Click);
            // 
            // shortTermTexBox
            // 
            this.shortTermTexBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shortTermTexBox.Location = new System.Drawing.Point(12, 42);
            this.shortTermTexBox.Name = "shortTermTexBox";
            this.shortTermTexBox.Size = new System.Drawing.Size(918, 35);
            this.shortTermTexBox.TabIndex = 1;
            // 
            // deletedCompletedGoalButton
            // 
            this.deletedCompletedGoalButton.AutoSize = true;
            this.deletedCompletedGoalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deletedCompletedGoalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletedCompletedGoalButton.ForeColor = System.Drawing.Color.White;
            this.deletedCompletedGoalButton.Image = global::ToDoList.Properties.Resources.delete;
            this.deletedCompletedGoalButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletedCompletedGoalButton.Location = new System.Drawing.Point(0, 0);
            this.deletedCompletedGoalButton.Name = "deletedCompletedGoalButton";
            this.deletedCompletedGoalButton.Size = new System.Drawing.Size(305, 100);
            this.deletedCompletedGoalButton.TabIndex = 13;
            this.deletedCompletedGoalButton.Text = "Delete Completed Goal";
            this.deletedCompletedGoalButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletedCompletedGoalButton.UseVisualStyleBackColor = true;
            this.deletedCompletedGoalButton.Click += new System.EventHandler(this.deletedCompletedGoalButton_Click);
            // 
            // searchCompletedGoalsButton
            // 
            this.searchCompletedGoalsButton.AutoSize = true;
            this.searchCompletedGoalsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchCompletedGoalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCompletedGoalsButton.ForeColor = System.Drawing.Color.White;
            this.searchCompletedGoalsButton.Image = global::ToDoList.Properties.Resources.completedlist;
            this.searchCompletedGoalsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchCompletedGoalsButton.Location = new System.Drawing.Point(0, 0);
            this.searchCompletedGoalsButton.Name = "searchCompletedGoalsButton";
            this.searchCompletedGoalsButton.Size = new System.Drawing.Size(305, 100);
            this.searchCompletedGoalsButton.TabIndex = 11;
            this.searchCompletedGoalsButton.Text = "Completed Goals";
            this.searchCompletedGoalsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchCompletedGoalsButton.UseVisualStyleBackColor = true;
            this.searchCompletedGoalsButton.Click += new System.EventHandler(this.searchCompletedGoalsButton_Click);
            // 
            // searchAllButton
            // 
            this.searchAllButton.AutoSize = true;
            this.searchAllButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchAllButton.ForeColor = System.Drawing.Color.White;
            this.searchAllButton.Image = global::ToDoList.Properties.Resources.list4;
            this.searchAllButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchAllButton.Location = new System.Drawing.Point(0, 0);
            this.searchAllButton.Name = "searchAllButton";
            this.searchAllButton.Size = new System.Drawing.Size(305, 100);
            this.searchAllButton.TabIndex = 10;
            this.searchAllButton.Text = "All Goals";
            this.searchAllButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.searchAllButton.UseVisualStyleBackColor = true;
            this.searchAllButton.Click += new System.EventHandler(this.searchAllButton_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.goalsListbox);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(305, 269);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1092, 698);
            this.bottomPanel.TabIndex = 8;
            // 
            // goalsListbox
            // 
            this.goalsListbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.goalsListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goalsListbox.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goalsListbox.ForeColor = System.Drawing.Color.White;
            this.goalsListbox.FormattingEnabled = true;
            this.goalsListbox.ItemHeight = 47;
            this.goalsListbox.Location = new System.Drawing.Point(0, 0);
            this.goalsListbox.Name = "goalsListbox";
            this.goalsListbox.Size = new System.Drawing.Size(1092, 698);
            this.goalsListbox.TabIndex = 10;
            this.goalsListbox.SelectedIndexChanged += new System.EventHandler(this.goalsListbox_SelectedIndexChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSize = true;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(0, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(305, 100);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Complete Selected Goal";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // longTermSearchButton
            // 
            this.longTermSearchButton.AutoSize = true;
            this.longTermSearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.longTermSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.longTermSearchButton.ForeColor = System.Drawing.Color.White;
            this.longTermSearchButton.Image = ((System.Drawing.Image)(resources.GetObject("longTermSearchButton.Image")));
            this.longTermSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.longTermSearchButton.Location = new System.Drawing.Point(0, 0);
            this.longTermSearchButton.Name = "longTermSearchButton";
            this.longTermSearchButton.Size = new System.Drawing.Size(305, 100);
            this.longTermSearchButton.TabIndex = 9;
            this.longTermSearchButton.Text = "Long Term Goals";
            this.longTermSearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.longTermSearchButton.UseVisualStyleBackColor = true;
            this.longTermSearchButton.Click += new System.EventHandler(this.longTermSearchButton_Click);
            // 
            // shortTermSearchButton
            // 
            this.shortTermSearchButton.AutoSize = true;
            this.shortTermSearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shortTermSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shortTermSearchButton.ForeColor = System.Drawing.Color.White;
            this.shortTermSearchButton.Image = global::ToDoList.Properties.Resources.list1;
            this.shortTermSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.shortTermSearchButton.Location = new System.Drawing.Point(0, 0);
            this.shortTermSearchButton.Name = "shortTermSearchButton";
            this.shortTermSearchButton.Size = new System.Drawing.Size(305, 100);
            this.shortTermSearchButton.TabIndex = 7;
            this.shortTermSearchButton.Text = "Short Term Goals";
            this.shortTermSearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.shortTermSearchButton.UseVisualStyleBackColor = true;
            this.shortTermSearchButton.Click += new System.EventHandler(this.shortTermSearchButton_Click);
            // 
            // midTermSearchButton
            // 
            this.midTermSearchButton.AutoSize = true;
            this.midTermSearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midTermSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.midTermSearchButton.ForeColor = System.Drawing.Color.White;
            this.midTermSearchButton.Image = global::ToDoList.Properties.Resources.list3;
            this.midTermSearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.midTermSearchButton.Location = new System.Drawing.Point(0, 0);
            this.midTermSearchButton.Name = "midTermSearchButton";
            this.midTermSearchButton.Size = new System.Drawing.Size(305, 100);
            this.midTermSearchButton.TabIndex = 8;
            this.midTermSearchButton.Text = "Mid Term Goals";
            this.midTermSearchButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.midTermSearchButton.UseVisualStyleBackColor = true;
            this.midTermSearchButton.Click += new System.EventHandler(this.midTermSearchButton_Click);
            // 
            // completeButtonPanel
            // 
            this.completeButtonPanel.Controls.Add(this.deleteButton);
            this.completeButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.completeButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.completeButtonPanel.Name = "completeButtonPanel";
            this.completeButtonPanel.Size = new System.Drawing.Size(305, 100);
            this.completeButtonPanel.TabIndex = 31;
            // 
            // deleteButtonPanel
            // 
            this.deleteButtonPanel.Controls.Add(this.deletedCompletedGoalButton);
            this.deleteButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.deleteButtonPanel.Name = "deleteButtonPanel";
            this.deleteButtonPanel.Size = new System.Drawing.Size(305, 100);
            this.deleteButtonPanel.TabIndex = 32;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.leftPanel.Controls.Add(this.displayListNamePanel);
            this.leftPanel.Controls.Add(this.emptyPanel);
            this.leftPanel.Controls.Add(this.deleteCompletedGoalPanel);
            this.leftPanel.Controls.Add(this.completedGoalPanel);
            this.leftPanel.Controls.Add(this.searchCompleteGoalsPanel);
            this.leftPanel.Controls.Add(this.serchAllListsPanel);
            this.leftPanel.Controls.Add(this.searchLongTermListPanel);
            this.leftPanel.Controls.Add(this.searchMidTermListPanel);
            this.leftPanel.Controls.Add(this.searchShortTermListPanel);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(305, 967);
            this.leftPanel.TabIndex = 31;
            // 
            // deleteCompletedGoalPanel
            // 
            this.deleteCompletedGoalPanel.Controls.Add(this.deleteButtonPanel);
            this.deleteCompletedGoalPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteCompletedGoalPanel.Location = new System.Drawing.Point(0, 600);
            this.deleteCompletedGoalPanel.Name = "deleteCompletedGoalPanel";
            this.deleteCompletedGoalPanel.Size = new System.Drawing.Size(305, 100);
            this.deleteCompletedGoalPanel.TabIndex = 31;
            // 
            // completedGoalPanel
            // 
            this.completedGoalPanel.Controls.Add(this.completeButtonPanel);
            this.completedGoalPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.completedGoalPanel.Location = new System.Drawing.Point(0, 500);
            this.completedGoalPanel.Name = "completedGoalPanel";
            this.completedGoalPanel.Size = new System.Drawing.Size(305, 100);
            this.completedGoalPanel.TabIndex = 32;
            // 
            // searchCompleteGoalsPanel
            // 
            this.searchCompleteGoalsPanel.Controls.Add(this.searchCompletedGoalsButton);
            this.searchCompleteGoalsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchCompleteGoalsPanel.Location = new System.Drawing.Point(0, 400);
            this.searchCompleteGoalsPanel.Name = "searchCompleteGoalsPanel";
            this.searchCompleteGoalsPanel.Size = new System.Drawing.Size(305, 100);
            this.searchCompleteGoalsPanel.TabIndex = 31;
            // 
            // serchAllListsPanel
            // 
            this.serchAllListsPanel.Controls.Add(this.searchAllButton);
            this.serchAllListsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.serchAllListsPanel.Location = new System.Drawing.Point(0, 300);
            this.serchAllListsPanel.Name = "serchAllListsPanel";
            this.serchAllListsPanel.Size = new System.Drawing.Size(305, 100);
            this.serchAllListsPanel.TabIndex = 31;
            // 
            // searchLongTermListPanel
            // 
            this.searchLongTermListPanel.Controls.Add(this.longTermSearchButton);
            this.searchLongTermListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchLongTermListPanel.Location = new System.Drawing.Point(0, 200);
            this.searchLongTermListPanel.Name = "searchLongTermListPanel";
            this.searchLongTermListPanel.Size = new System.Drawing.Size(305, 100);
            this.searchLongTermListPanel.TabIndex = 2;
            // 
            // searchMidTermListPanel
            // 
            this.searchMidTermListPanel.Controls.Add(this.midTermSearchButton);
            this.searchMidTermListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchMidTermListPanel.Location = new System.Drawing.Point(0, 100);
            this.searchMidTermListPanel.Name = "searchMidTermListPanel";
            this.searchMidTermListPanel.Size = new System.Drawing.Size(305, 100);
            this.searchMidTermListPanel.TabIndex = 1;
            // 
            // searchShortTermListPanel
            // 
            this.searchShortTermListPanel.Controls.Add(this.shortTermSearchButton);
            this.searchShortTermListPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchShortTermListPanel.Location = new System.Drawing.Point(0, 0);
            this.searchShortTermListPanel.Name = "searchShortTermListPanel";
            this.searchShortTermListPanel.Size = new System.Drawing.Size(305, 100);
            this.searchShortTermListPanel.TabIndex = 0;
            // 
            // emptyPanel
            // 
            this.emptyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.emptyPanel.Location = new System.Drawing.Point(0, 700);
            this.emptyPanel.Name = "emptyPanel";
            this.emptyPanel.Size = new System.Drawing.Size(305, 100);
            this.emptyPanel.TabIndex = 33;
            // 
            // displayListNamePanel
            // 
            this.displayListNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.displayListNamePanel.Controls.Add(this.displayListNameButton);
            this.displayListNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayListNamePanel.Location = new System.Drawing.Point(0, 800);
            this.displayListNamePanel.Margin = new System.Windows.Forms.Padding(0);
            this.displayListNamePanel.Name = "displayListNamePanel";
            this.displayListNamePanel.Size = new System.Drawing.Size(305, 100);
            this.displayListNamePanel.TabIndex = 34;
            // 
            // displayListNameButton
            // 
            this.displayListNameButton.AutoSize = true;
            this.displayListNameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayListNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.displayListNameButton.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayListNameButton.ForeColor = System.Drawing.Color.White;
            this.displayListNameButton.Location = new System.Drawing.Point(0, 0);
            this.displayListNameButton.Margin = new System.Windows.Forms.Padding(0);
            this.displayListNameButton.Name = "displayListNameButton";
            this.displayListNameButton.Size = new System.Drawing.Size(305, 100);
            this.displayListNameButton.TabIndex = 0;
            this.displayListNameButton.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(1397, 967);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goals List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.topPanel.ResumeLayout(false);
            this.longTermGoalPanel.ResumeLayout(false);
            this.longTermGoalPanel.PerformLayout();
            this.midTermGoalPanel.ResumeLayout(false);
            this.midTermGoalPanel.PerformLayout();
            this.shortTermGoalPanel.ResumeLayout(false);
            this.shortTermGoalPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.completeButtonPanel.ResumeLayout(false);
            this.completeButtonPanel.PerformLayout();
            this.deleteButtonPanel.ResumeLayout(false);
            this.deleteButtonPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.deleteCompletedGoalPanel.ResumeLayout(false);
            this.completedGoalPanel.ResumeLayout(false);
            this.searchCompleteGoalsPanel.ResumeLayout(false);
            this.searchCompleteGoalsPanel.PerformLayout();
            this.serchAllListsPanel.ResumeLayout(false);
            this.serchAllListsPanel.PerformLayout();
            this.searchLongTermListPanel.ResumeLayout(false);
            this.searchLongTermListPanel.PerformLayout();
            this.searchMidTermListPanel.ResumeLayout(false);
            this.searchMidTermListPanel.PerformLayout();
            this.searchShortTermListPanel.ResumeLayout(false);
            this.searchShortTermListPanel.PerformLayout();
            this.displayListNamePanel.ResumeLayout(false);
            this.displayListNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label shortTermLabel;
        private System.Windows.Forms.Label midTermLabel;
        private System.Windows.Forms.Label longTermLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox longTermTexBox;
        private System.Windows.Forms.TextBox midTermTexBox;
        private System.Windows.Forms.TextBox shortTermTexBox;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button searchAllButton;
        private System.Windows.Forms.Button searchCompletedGoalsButton;
        private System.Windows.Forms.Button deletedCompletedGoalButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel shortTermGoalPanel;
        private System.Windows.Forms.Button longTermAddButton;
        private System.Windows.Forms.Button midTermAddButton;
        private System.Windows.Forms.Button shortTermAddButton;
        private System.Windows.Forms.Panel midTermGoalPanel;
        private System.Windows.Forms.Button midTermSearchButton;
        private System.Windows.Forms.Button shortTermSearchButton;
        private System.Windows.Forms.Button longTermSearchButton;
        private System.Windows.Forms.Panel longTermGoalPanel;
        private System.Windows.Forms.Panel deleteButtonPanel;
        private System.Windows.Forms.Panel completeButtonPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel deleteCompletedGoalPanel;
        private System.Windows.Forms.Panel completedGoalPanel;
        private System.Windows.Forms.Panel searchCompleteGoalsPanel;
        private System.Windows.Forms.Panel serchAllListsPanel;
        private System.Windows.Forms.Panel searchLongTermListPanel;
        private System.Windows.Forms.Panel searchMidTermListPanel;
        private System.Windows.Forms.Panel searchShortTermListPanel;
        private System.Windows.Forms.ListBox goalsListbox;
        private System.Windows.Forms.Panel displayListNamePanel;
        private System.Windows.Forms.Button displayListNameButton;
        private System.Windows.Forms.Panel emptyPanel;
    }
}

