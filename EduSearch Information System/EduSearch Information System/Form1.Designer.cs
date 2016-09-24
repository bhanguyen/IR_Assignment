﻿namespace EduSearch_Information_System
{
    partial class Form1
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
            this.BrowseSourceButton = new System.Windows.Forms.Button();
            this.BrowseIndexButton = new System.Windows.Forms.Button();
            this.SourceBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.IndexBrowseDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SourcePathLabel = new System.Windows.Forms.Label();
            this.IndexPathLabel = new System.Windows.Forms.Label();
            this.CreateIndexButton = new System.Windows.Forms.Button();
            this.TimeExcutionLabel = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.Rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchTimeExcutionLabel = new System.Windows.Forms.Label();
            this.InformationNeedButton = new System.Windows.Forms.Button();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.totalresultLabel = new System.Windows.Forms.Label();
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bibliographic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Abstract = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // BrowseSourceButton
            // 
            this.BrowseSourceButton.Location = new System.Drawing.Point(23, 12);
            this.BrowseSourceButton.Name = "BrowseSourceButton";
            this.BrowseSourceButton.Size = new System.Drawing.Size(98, 23);
            this.BrowseSourceButton.TabIndex = 0;
            this.BrowseSourceButton.Text = "Browse Source";
            this.BrowseSourceButton.UseVisualStyleBackColor = true;
            this.BrowseSourceButton.Click += new System.EventHandler(this.BrowseSourceButton_Click);
            // 
            // BrowseIndexButton
            // 
            this.BrowseIndexButton.Location = new System.Drawing.Point(23, 41);
            this.BrowseIndexButton.Name = "BrowseIndexButton";
            this.BrowseIndexButton.Size = new System.Drawing.Size(98, 23);
            this.BrowseIndexButton.TabIndex = 1;
            this.BrowseIndexButton.Text = "Browse Index";
            this.BrowseIndexButton.UseVisualStyleBackColor = true;
            this.BrowseIndexButton.Click += new System.EventHandler(this.BrowseIndexButton_Click);
            // 
            // SourcePathLabel
            // 
            this.SourcePathLabel.AutoSize = true;
            this.SourcePathLabel.Location = new System.Drawing.Point(151, 17);
            this.SourcePathLabel.Name = "SourcePathLabel";
            this.SourcePathLabel.Size = new System.Drawing.Size(66, 13);
            this.SourcePathLabel.TabIndex = 2;
            this.SourcePathLabel.Text = "Source Path";
            // 
            // IndexPathLabel
            // 
            this.IndexPathLabel.AutoSize = true;
            this.IndexPathLabel.Location = new System.Drawing.Point(151, 46);
            this.IndexPathLabel.Name = "IndexPathLabel";
            this.IndexPathLabel.Size = new System.Drawing.Size(58, 13);
            this.IndexPathLabel.TabIndex = 3;
            this.IndexPathLabel.Text = "Index Path";
            // 
            // CreateIndexButton
            // 
            this.CreateIndexButton.Location = new System.Drawing.Point(622, 12);
            this.CreateIndexButton.Name = "CreateIndexButton";
            this.CreateIndexButton.Size = new System.Drawing.Size(98, 23);
            this.CreateIndexButton.TabIndex = 4;
            this.CreateIndexButton.Text = "Create Index";
            this.CreateIndexButton.UseVisualStyleBackColor = true;
            this.CreateIndexButton.Click += new System.EventHandler(this.CreateIndexButton_Click);
            // 
            // TimeExcutionLabel
            // 
            this.TimeExcutionLabel.AutoSize = true;
            this.TimeExcutionLabel.Location = new System.Drawing.Point(628, 46);
            this.TimeExcutionLabel.Name = "TimeExcutionLabel";
            this.TimeExcutionLabel.Size = new System.Drawing.Size(0, 13);
            this.TimeExcutionLabel.TabIndex = 5;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(154, 84);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(463, 20);
            this.SearchBox.TabIndex = 6;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(622, 128);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(98, 23);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Rank,
            this.Title,
            this.Author,
            this.Bibliographic,
            this.Abstract});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(154, 257);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(463, 254);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Rank
            // 
            this.Rank.Text = "Rank";
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 150;
            // 
            // SearchTimeExcutionLabel
            // 
            this.SearchTimeExcutionLabel.AutoSize = true;
            this.SearchTimeExcutionLabel.Location = new System.Drawing.Point(628, 154);
            this.SearchTimeExcutionLabel.Name = "SearchTimeExcutionLabel";
            this.SearchTimeExcutionLabel.Size = new System.Drawing.Size(0, 13);
            this.SearchTimeExcutionLabel.TabIndex = 9;
            // 
            // InformationNeedButton
            // 
            this.InformationNeedButton.Location = new System.Drawing.Point(622, 81);
            this.InformationNeedButton.Name = "InformationNeedButton";
            this.InformationNeedButton.Size = new System.Drawing.Size(98, 23);
            this.InformationNeedButton.TabIndex = 10;
            this.InformationNeedButton.Text = "Information need";
            this.InformationNeedButton.UseVisualStyleBackColor = true;
            this.InformationNeedButton.Click += new System.EventHandler(this.InformationNeedButton_Click);
            // 
            // checkedListBox
            // 
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(154, 111);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(462, 139);
            this.checkedListBox.TabIndex = 11;
            // 
            // totalresultLabel
            // 
            this.totalresultLabel.AutoSize = true;
            this.totalresultLabel.Location = new System.Drawing.Point(628, 269);
            this.totalresultLabel.Name = "totalresultLabel";
            this.totalresultLabel.Size = new System.Drawing.Size(0, 13);
            this.totalresultLabel.TabIndex = 12;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            // 
            // Bibliographic
            // 
            this.Bibliographic.Text = "Bibliographic";
            // 
            // Abstract
            // 
            this.Abstract.Text = "Abstract";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(485, 41);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 523);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.totalresultLabel);
            this.Controls.Add(this.checkedListBox);
            this.Controls.Add(this.InformationNeedButton);
            this.Controls.Add(this.SearchTimeExcutionLabel);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.TimeExcutionLabel);
            this.Controls.Add(this.CreateIndexButton);
            this.Controls.Add(this.IndexPathLabel);
            this.Controls.Add(this.SourcePathLabel);
            this.Controls.Add(this.BrowseIndexButton);
            this.Controls.Add(this.BrowseSourceButton);
            this.Name = "Form1";
            this.Text = "EduSearch Information System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseSourceButton;
        private System.Windows.Forms.Button BrowseIndexButton;
        private System.Windows.Forms.FolderBrowserDialog SourceBrowserDialog;
        private System.Windows.Forms.FolderBrowserDialog IndexBrowseDialog;
        private System.Windows.Forms.Label SourcePathLabel;
        private System.Windows.Forms.Label IndexPathLabel;
        private System.Windows.Forms.Button CreateIndexButton;
        private System.Windows.Forms.Label TimeExcutionLabel;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ColumnHeader Rank;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.Label SearchTimeExcutionLabel;
        public System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button InformationNeedButton;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label totalresultLabel;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader Bibliographic;
        private System.Windows.Forms.ColumnHeader Abstract;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}
