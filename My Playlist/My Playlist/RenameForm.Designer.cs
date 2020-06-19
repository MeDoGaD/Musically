namespace My_Playlist
{
    partial class RenameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.Rename_bt = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.playnametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Rename_bt
            // 
            this.Rename_bt.BackColor = System.Drawing.Color.Transparent;
            this.Rename_bt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rename_bt.BackgroundImage")));
            this.Rename_bt.ButtonText = "Rename";
            this.Rename_bt.ButtonTextMarginLeft = 0;
            this.Rename_bt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Rename_bt.DisabledFillColor = System.Drawing.Color.Gray;
            this.Rename_bt.DisabledForecolor = System.Drawing.Color.White;
            this.Rename_bt.ForeColor = System.Drawing.Color.White;
            this.Rename_bt.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Rename_bt.IconPadding = 10;
            this.Rename_bt.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Rename_bt.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Rename_bt.IdleBorderRadius = 1;
            this.Rename_bt.IdleBorderThickness = 0;
            this.Rename_bt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Rename_bt.IdleIconLeftImage = null;
            this.Rename_bt.IdleIconRightImage = null;
            this.Rename_bt.Location = new System.Drawing.Point(248, 74);
            this.Rename_bt.Margin = new System.Windows.Forms.Padding(4);
            this.Rename_bt.Name = "Rename_bt";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.Rename_bt.onHoverState = stateProperties1;
            this.Rename_bt.Size = new System.Drawing.Size(121, 37);
            this.Rename_bt.TabIndex = 5;
            this.Rename_bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rename_bt.Click += new System.EventHandler(this.Rename_bt_Click);
            // 
            // playnametxt
            // 
            this.playnametxt.Location = new System.Drawing.Point(146, 21);
            this.playnametxt.Margin = new System.Windows.Forms.Padding(4);
            this.playnametxt.Name = "playnametxt";
            this.playnametxt.Size = new System.Drawing.Size(192, 22);
            this.playnametxt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter new name";
            // 
            // RenameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(385, 133);
            this.Controls.Add(this.Rename_bt);
            this.Controls.Add(this.playnametxt);
            this.Controls.Add(this.label1);
            this.Name = "RenameForm";
            this.Text = "Rename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Rename_bt;
        private System.Windows.Forms.TextBox playnametxt;
        private System.Windows.Forms.Label label1;
    }
}