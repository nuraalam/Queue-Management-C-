namespace QueueManagmentUserDefineApp
{
    partial class QueueManagmentUserDefineApp
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
            this.queueManagementListView = new System.Windows.Forms.ListView();
            this.serialNumberColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.complainColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.dequeueComplainTextBox = new System.Windows.Forms.TextBox();
            this.dequeueNameTextBox = new System.Windows.Forms.TextBox();
            this.dequeueSerialNoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.enqueueComplainTextBox = new System.Windows.Forms.TextBox();
            this.enqueueNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // queueManagementListView
            // 
            this.queueManagementListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialNumberColumnHeader,
            this.nameColumnHeader,
            this.complainColumnHeader});
            this.queueManagementListView.GridLines = true;
            this.queueManagementListView.Location = new System.Drawing.Point(24, 225);
            this.queueManagementListView.Name = "queueManagementListView";
            this.queueManagementListView.Size = new System.Drawing.Size(694, 142);
            this.queueManagementListView.TabIndex = 7;
            this.queueManagementListView.UseCompatibleStateImageBehavior = false;
            this.queueManagementListView.View = System.Windows.Forms.View.Details;
            // 
            // serialNumberColumnHeader
            // 
            this.serialNumberColumnHeader.Text = "Serial No.";
            this.serialNumberColumnHeader.Width = 83;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 158;
            // 
            // complainColumnHeader
            // 
            this.complainColumnHeader.Text = "Complain";
            this.complainColumnHeader.Width = 402;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dequeueButton);
            this.groupBox2.Controls.Add(this.dequeueComplainTextBox);
            this.groupBox2.Controls.Add(this.dequeueNameTextBox);
            this.groupBox2.Controls.Add(this.dequeueSerialNoTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(383, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 156);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dequeue System";
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(222, 28);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(85, 54);
            this.dequeueButton.TabIndex = 7;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // dequeueComplainTextBox
            // 
            this.dequeueComplainTextBox.Location = new System.Drawing.Point(82, 110);
            this.dequeueComplainTextBox.Multiline = true;
            this.dequeueComplainTextBox.Name = "dequeueComplainTextBox";
            this.dequeueComplainTextBox.Size = new System.Drawing.Size(247, 22);
            this.dequeueComplainTextBox.TabIndex = 6;
            // 
            // dequeueNameTextBox
            // 
            this.dequeueNameTextBox.Location = new System.Drawing.Point(82, 66);
            this.dequeueNameTextBox.Name = "dequeueNameTextBox";
            this.dequeueNameTextBox.Size = new System.Drawing.Size(120, 20);
            this.dequeueNameTextBox.TabIndex = 5;
            // 
            // dequeueSerialNoTextBox
            // 
            this.dequeueSerialNoTextBox.Location = new System.Drawing.Point(82, 25);
            this.dequeueSerialNoTextBox.Name = "dequeueSerialNoTextBox";
            this.dequeueSerialNoTextBox.Size = new System.Drawing.Size(82, 20);
            this.dequeueSerialNoTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Serial No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Complain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.enqueueButton);
            this.groupBox1.Controls.Add(this.enqueueComplainTextBox);
            this.groupBox1.Controls.Add(this.enqueueNameTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 156);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue System";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(205, 35);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(81, 54);
            this.enqueueButton.TabIndex = 4;
            this.enqueueButton.Text = "Engueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // enqueueComplainTextBox
            // 
            this.enqueueComplainTextBox.Location = new System.Drawing.Point(68, 110);
            this.enqueueComplainTextBox.Multiline = true;
            this.enqueueComplainTextBox.Name = "enqueueComplainTextBox";
            this.enqueueComplainTextBox.Size = new System.Drawing.Size(255, 22);
            this.enqueueComplainTextBox.TabIndex = 3;
            // 
            // enqueueNameTextBox
            // 
            this.enqueueNameTextBox.Location = new System.Drawing.Point(68, 53);
            this.enqueueNameTextBox.Name = "enqueueNameTextBox";
            this.enqueueNameTextBox.Size = new System.Drawing.Size(110, 20);
            this.enqueueNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Complain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // QueueManagmentUserDefineApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 389);
            this.Controls.Add(this.queueManagementListView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QueueManagmentUserDefineApp";
            this.Text = "QueueManagmentUserDefineApp";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView queueManagementListView;
        private System.Windows.Forms.ColumnHeader serialNumberColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader complainColumnHeader;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.TextBox dequeueComplainTextBox;
        private System.Windows.Forms.TextBox dequeueNameTextBox;
        private System.Windows.Forms.TextBox dequeueSerialNoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.TextBox enqueueComplainTextBox;
        private System.Windows.Forms.TextBox enqueueNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}

