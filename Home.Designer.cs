namespace Assignmnt
{
    partial class Home
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
            this.lbsHomelabel = new System.Windows.Forms.Label();
            this.addBookButton = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
            this.removeBookButton = new System.Windows.Forms.Button();
            this.viewBooksButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.viewLogButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbsHomelabel
            // 
            this.lbsHomelabel.AutoSize = true;
            this.lbsHomelabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbsHomelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbsHomelabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsHomelabel.ForeColor = System.Drawing.SystemColors.Window;
            this.lbsHomelabel.Location = new System.Drawing.Point(128, 32);
            this.lbsHomelabel.Margin = new System.Windows.Forms.Padding(5);
            this.lbsHomelabel.Name = "lbsHomelabel";
            this.lbsHomelabel.Padding = new System.Windows.Forms.Padding(5);
            this.lbsHomelabel.Size = new System.Drawing.Size(468, 47);
            this.lbsHomelabel.TabIndex = 0;
            this.lbsHomelabel.Text = "Library Management System";
            // 
            // addBookButton
            // 
            this.addBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addBookButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBookButton.Location = new System.Drawing.Point(92, 131);
            this.addBookButton.Name = "addBookButton";
            this.addBookButton.Size = new System.Drawing.Size(119, 100);
            this.addBookButton.TabIndex = 1;
            this.addBookButton.Text = "Add Books";
            this.addBookButton.UseVisualStyleBackColor = false;
            this.addBookButton.Click += new System.EventHandler(this.addBookButton_Click);
            // 
            // borrowButton
            // 
            this.borrowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.borrowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrowButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowButton.Location = new System.Drawing.Point(298, 131);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(119, 100);
            this.borrowButton.TabIndex = 2;
            this.borrowButton.Text = "Borrow Books";
            this.borrowButton.UseVisualStyleBackColor = false;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // removeBookButton
            // 
            this.removeBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.removeBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeBookButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBookButton.Location = new System.Drawing.Point(92, 285);
            this.removeBookButton.Name = "removeBookButton";
            this.removeBookButton.Size = new System.Drawing.Size(119, 100);
            this.removeBookButton.TabIndex = 3;
            this.removeBookButton.Text = "Remove Books";
            this.removeBookButton.UseVisualStyleBackColor = false;
            this.removeBookButton.Click += new System.EventHandler(this.removeBookButton_Click);
            // 
            // viewBooksButton
            // 
            this.viewBooksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewBooksButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewBooksButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBooksButton.Location = new System.Drawing.Point(493, 131);
            this.viewBooksButton.Name = "viewBooksButton";
            this.viewBooksButton.Size = new System.Drawing.Size(136, 100);
            this.viewBooksButton.TabIndex = 4;
            this.viewBooksButton.Text = "View Available Books";
            this.viewBooksButton.UseVisualStyleBackColor = false;
            this.viewBooksButton.Click += new System.EventHandler(this.viewBooksButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.returnButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(298, 285);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(119, 100);
            this.returnButton.TabIndex = 5;
            this.returnButton.Text = "Return Books";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // viewLogButton
            // 
            this.viewLogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.viewLogButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewLogButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewLogButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLogButton.Location = new System.Drawing.Point(493, 285);
            this.viewLogButton.Name = "viewLogButton";
            this.viewLogButton.Size = new System.Drawing.Size(136, 100);
            this.viewLogButton.TabIndex = 6;
            this.viewLogButton.Text = "View Transacion Log";
            this.viewLogButton.UseVisualStyleBackColor = false;
            this.viewLogButton.Click += new System.EventHandler(this.viewLogButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(275, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 492);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewLogButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.viewBooksButton);
            this.Controls.Add(this.removeBookButton);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.addBookButton);
            this.Controls.Add(this.lbsHomelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home - LBS";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbsHomelabel;
        private System.Windows.Forms.Button addBookButton;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.Button removeBookButton;
        private System.Windows.Forms.Button viewBooksButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button viewLogButton;
        private System.Windows.Forms.Button button1;
    }
}