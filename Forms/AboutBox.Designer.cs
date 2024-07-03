
namespace EverLoader.Forms
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            lblInfo = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo___EverSD;
            pictureBox1.Location = new System.Drawing.Point(148, 245);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(114, 67);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(74, 300);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(183, 20);
            label1.TabIndex = 1;
            label1.Text = "For news and updates visit";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkLabel1.Location = new System.Drawing.Point(237, 300);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(88, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "EverSD.com";
            linkLabel1.LinkClicked += LinkLabel1_LinkClicked;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new System.Drawing.Point(15, 17);
            lblInfo.MaximumSize = new System.Drawing.Size(514, 267);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(374, 200);
            lblInfo.TabIndex = 3;
            lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(30, 394);
            label2.MaximumSize = new System.Drawing.Size(514, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(336, 45);
            label2.TabIndex = 4;
            label2.Text = "Disclaimer: EverSD and EverLoader are not affiliated in any way\r\nwith Evercade, HyperMegaTech! or Blaze Entertainment Ltd.\r\nEverSD does not support or condone piracy.";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(52, 329);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(176, 20);
            label3.TabIndex = 5;
            label3.Text = "Join our Discord server at";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            linkLabel2.Location = new System.Drawing.Point(208, 329);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new System.Drawing.Size(143, 20);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "EverSD.com/discord";
            linkLabel2.LinkClicked += LinkLabel2_LinkClicked;
            // 
            // AboutBox
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(400, 444);
            Controls.Add(linkLabel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblInfo);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutBox";
            Padding = new System.Windows.Forms.Padding(11, 13, 11, 13);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "About EverLoader";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}
