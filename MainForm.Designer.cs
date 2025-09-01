namespace Web_Browser
{
    partial class MainForm
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
            this.AddNewTabButton = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Panel();
            this.TabList = new System.Windows.Forms.TableLayoutPanel();
            this.TabListContainer = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            this.TabListContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewTabButton
            // 
            this.AddNewTabButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNewTabButton.Location = new System.Drawing.Point(8, 8);
            this.AddNewTabButton.Margin = new System.Windows.Forms.Padding(8);
            this.AddNewTabButton.Name = "AddNewTabButton";
            this.AddNewTabButton.Size = new System.Drawing.Size(184, 34);
            this.AddNewTabButton.TabIndex = 1;
            this.AddNewTabButton.Text = "Add New Tab";
            this.AddNewTabButton.UseVisualStyleBackColor = true;
            this.AddNewTabButton.Click += new System.EventHandler(this.AddNewTabButton_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.White;
            this.Header.Controls.Add(this.AddNewTabButton);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(200, 50);
            this.Header.TabIndex = 0;
            // 
            // TabList
            // 
            this.TabList.AutoSize = true;
            this.TabList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TabList.BackColor = System.Drawing.Color.White;
            this.TabList.ColumnCount = 1;
            this.TabList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TabList.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabList.Location = new System.Drawing.Point(0, 0);
            this.TabList.Margin = new System.Windows.Forms.Padding(0);
            this.TabList.Name = "TabList";
            this.TabList.RowCount = 1;
            this.TabList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TabList.Size = new System.Drawing.Size(200, 0);
            this.TabList.TabIndex = 2;
            // 
            // TabListContainer
            // 
            this.TabListContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TabListContainer.AutoScroll = true;
            this.TabListContainer.BackColor = System.Drawing.Color.White;
            this.TabListContainer.Controls.Add(this.TabList);
            this.TabListContainer.Location = new System.Drawing.Point(0, 50);
            this.TabListContainer.Margin = new System.Windows.Forms.Padding(0);
            this.TabListContainer.Name = "TabListContainer";
            this.TabListContainer.Size = new System.Drawing.Size(200, 451);
            this.TabListContainer.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.TabListContainer);
            this.Controls.Add(this.Header);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(200, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Browser";
            this.Header.ResumeLayout(false);
            this.TabListContainer.ResumeLayout(false);
            this.TabListContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddNewTabButton;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.TableLayoutPanel TabList;
        private System.Windows.Forms.Panel TabListContainer;
    }
}

