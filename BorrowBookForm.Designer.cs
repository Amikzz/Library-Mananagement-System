namespace Assignmnt
{
    partial class BorrowBookForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
            this.isbnText = new System.Windows.Forms.TextBox();
            this.bookNameText = new System.Windows.Forms.TextBox();
            this.isbnLabel = new System.Windows.Forms.Label();
            this.booknamelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.memberIDInput = new System.Windows.Forms.TextBox();
            this.memberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.IndianRed;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(534, 381);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(103, 45);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Exit";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // borrowButton
            // 
            this.borrowButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.borrowButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.borrowButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowButton.Location = new System.Drawing.Point(84, 381);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(103, 45);
            this.borrowButton.TabIndex = 16;
            this.borrowButton.Text = "Borrow";
            this.borrowButton.UseVisualStyleBackColor = false;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // isbnText
            // 
            this.isbnText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnText.Location = new System.Drawing.Point(363, 197);
            this.isbnText.Name = "isbnText";
            this.isbnText.Size = new System.Drawing.Size(234, 32);
            this.isbnText.TabIndex = 15;
            // 
            // bookNameText
            // 
            this.bookNameText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameText.Location = new System.Drawing.Point(363, 119);
            this.bookNameText.Name = "bookNameText";
            this.bookNameText.Size = new System.Drawing.Size(234, 32);
            this.bookNameText.TabIndex = 13;
            // 
            // isbnLabel
            // 
            this.isbnLabel.AutoSize = true;
            this.isbnLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbnLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.isbnLabel.Location = new System.Drawing.Point(80, 197);
            this.isbnLabel.Name = "isbnLabel";
            this.isbnLabel.Size = new System.Drawing.Size(74, 24);
            this.isbnLabel.TabIndex = 12;
            this.isbnLabel.Text = "ISBN: ";
            // 
            // booknamelabel
            // 
            this.booknamelabel.AutoSize = true;
            this.booknamelabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booknamelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.booknamelabel.Location = new System.Drawing.Point(80, 122);
            this.booknamelabel.Name = "booknamelabel";
            this.booknamelabel.Size = new System.Drawing.Size(136, 24);
            this.booknamelabel.TabIndex = 10;
            this.booknamelabel.Text = "Book name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(250, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Borrow Books";
            // 
            // memberIDInput
            // 
            this.memberIDInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDInput.Location = new System.Drawing.Point(363, 277);
            this.memberIDInput.Name = "memberIDInput";
            this.memberIDInput.Size = new System.Drawing.Size(234, 32);
            this.memberIDInput.TabIndex = 19;
            // 
            // memberLabel
            // 
            this.memberLabel.AutoSize = true;
            this.memberLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.memberLabel.Location = new System.Drawing.Point(80, 277);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(132, 24);
            this.memberLabel.TabIndex = 18;
            this.memberLabel.Text = "Member ID: ";
            // 
            // BorrowBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(737, 492);
            this.ControlBox = false;
            this.Controls.Add(this.memberIDInput);
            this.Controls.Add(this.memberLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.isbnText);
            this.Controls.Add(this.bookNameText);
            this.Controls.Add(this.isbnLabel);
            this.Controls.Add(this.booknamelabel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.TextBox isbnText;
        private System.Windows.Forms.TextBox bookNameText;
        private System.Windows.Forms.Label isbnLabel;
        private System.Windows.Forms.Label booknamelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memberIDInput;
        private System.Windows.Forms.Label memberLabel;
    }
}