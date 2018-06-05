namespace UI
{
    partial class CashTransfer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbCardNoTo = new System.Windows.Forms.TextBox();
            this.panelCardNoTo = new System.Windows.Forms.Panel();
            this.panelMonetTranfer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMoneyTransfer = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCardNoTo.SuspendLayout();
            this.panelMonetTranfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập số tài khoản bạn muốn chuyển tiền";
            // 
            // tbCardNoTo
            // 
            this.tbCardNoTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCardNoTo.Location = new System.Drawing.Point(133, 32);
            this.tbCardNoTo.Name = "tbCardNoTo";
            this.tbCardNoTo.Size = new System.Drawing.Size(186, 29);
            this.tbCardNoTo.TabIndex = 3;
            // 
            // panelCardNoTo
            // 
            this.panelCardNoTo.BackColor = System.Drawing.Color.Transparent;
            this.panelCardNoTo.Controls.Add(this.label1);
            this.panelCardNoTo.Controls.Add(this.tbCardNoTo);
            this.panelCardNoTo.Location = new System.Drawing.Point(162, 20);
            this.panelCardNoTo.Name = "panelCardNoTo";
            this.panelCardNoTo.Size = new System.Drawing.Size(453, 101);
            this.panelCardNoTo.TabIndex = 4;
            // 
            // panelMonetTranfer
            // 
            this.panelMonetTranfer.BackColor = System.Drawing.Color.Transparent;
            this.panelMonetTranfer.Controls.Add(this.label2);
            this.panelMonetTranfer.Controls.Add(this.tbMoneyTransfer);
            this.panelMonetTranfer.Location = new System.Drawing.Point(162, 87);
            this.panelMonetTranfer.Name = "panelMonetTranfer";
            this.panelMonetTranfer.Size = new System.Drawing.Size(453, 101);
            this.panelMonetTranfer.TabIndex = 4;
            this.panelMonetTranfer.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(55, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập số tiền bạn muốn chuyển";
            // 
            // tbMoneyTransfer
            // 
            this.tbMoneyTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMoneyTransfer.Location = new System.Drawing.Point(133, 32);
            this.tbMoneyTransfer.Name = "tbMoneyTransfer";
            this.tbMoneyTransfer.Size = new System.Drawing.Size(186, 29);
            this.tbMoneyTransfer.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::UI.Properties.Resources.dongY;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(648, 257);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 44);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::UI.Properties.Resources.huyBo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(648, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 44);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // CashTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.default_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMonetTranfer);
            this.Controls.Add(this.panelCardNoTo);
            this.Name = "CashTransfer";
            this.Size = new System.Drawing.Size(811, 375);
            this.panelCardNoTo.ResumeLayout(false);
            this.panelCardNoTo.PerformLayout();
            this.panelMonetTranfer.ResumeLayout(false);
            this.panelMonetTranfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCardNoTo;
        private System.Windows.Forms.Panel panelCardNoTo;
        private System.Windows.Forms.Panel panelMonetTranfer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMoneyTransfer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
