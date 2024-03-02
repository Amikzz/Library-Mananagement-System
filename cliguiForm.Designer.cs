namespace Assignmnt
{
    partial class cliguiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cliguiForm));
            this.label1 = new System.Windows.Forms.Label();
            this.labelLBS = new System.Windows.Forms.Label();
            this.buttonCMD = new System.Windows.Forms.Button();
            this.buttonGUI = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMainForm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // labelLBS
            // 
            this.labelLBS.AutoSize = true;
            this.labelLBS.BackColor = System.Drawing.Color.Transparent;
            this.labelLBS.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLBS.ForeColor = System.Drawing.Color.White;
            this.labelLBS.Location = new System.Drawing.Point(117, 32);
            this.labelLBS.Name = "labelLBS";
            this.labelLBS.Size = new System.Drawing.Size(486, 42);
            this.labelLBS.TabIndex = 1;
            this.labelLBS.Text = "Library Management System";
            // 
            // buttonCMD
            // 
            this.buttonCMD.BackColor = System.Drawing.Color.Yellow;
            this.buttonCMD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCMD.BackgroundImage")));
            this.buttonCMD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCMD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCMD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCMD.ForeColor = System.Drawing.Color.Black;
            this.buttonCMD.Location = new System.Drawing.Point(124, 174);
            this.buttonCMD.Name = "buttonCMD";
            this.buttonCMD.Size = new System.Drawing.Size(137, 107);
            this.buttonCMD.TabIndex = 2;
            this.buttonCMD.UseVisualStyleBackColor = false;
            this.buttonCMD.Click += new System.EventHandler(this.buttonCMD_Click);
            // 
            // buttonGUI
            // 
            this.buttonGUI.BackColor = System.Drawing.Color.White;
            this.buttonGUI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGUI.BackgroundImage")));
            this.buttonGUI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGUI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGUI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGUI.Location = new System.Drawing.Point(466, 174);
            this.buttonGUI.Name = "buttonGUI";
            this.buttonGUI.Size = new System.Drawing.Size(137, 107);
            this.buttonGUI.TabIndex = 3;
            this.buttonGUI.UseVisualStyleBackColor = false;
            this.buttonGUI.Click += new System.EventHandler(this.buttonGUI_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Font = new System.Drawing.Font("Franklin Gothic Book", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.Location = new System.Drawing.Point(308, 359);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(5);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(106, 42);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Exit";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // labelMainForm
            // 
            this.labelMainForm.AutoSize = true;
            this.labelMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMainForm.Location = new System.Drawing.Point(243, 107);
            this.labelMainForm.Name = "labelMainForm";
            this.labelMainForm.Size = new System.Drawing.Size(221, 25);
            this.labelMainForm.TabIndex = 6;
            this.labelMainForm.Text = "Select your platform...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(158, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "CMD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(510, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "GUI";
            // 
            // cliguiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 456);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelMainForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonGUI);
            this.Controls.Add(this.buttonCMD);
            this.Controls.Add(this.labelLBS);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "cliguiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LBS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLBS;
        private System.Windows.Forms.Button buttonCMD;
        private System.Windows.Forms.Button buttonGUI;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMainForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

