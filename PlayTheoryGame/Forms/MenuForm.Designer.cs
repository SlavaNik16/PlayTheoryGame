namespace PlayTheoryGame.Forms
{
    partial class MenuForm
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
            this.butPlay = new MaterialSkin.Controls.MaterialButton();
            this.butExit = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butPlay
            // 
            this.butPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.butPlay.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butPlay.Depth = 0;
            this.butPlay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butPlay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.butPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butPlay.HighEmphasis = true;
            this.butPlay.Icon = null;
            this.butPlay.Location = new System.Drawing.Point(4, 63);
            this.butPlay.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butPlay.MouseState = MaterialSkin.MouseState.HOVER;
            this.butPlay.Name = "butPlay";
            this.butPlay.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butPlay.Size = new System.Drawing.Size(425, 36);
            this.butPlay.TabIndex = 0;
            this.butPlay.Text = "Играть";
            this.butPlay.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.butPlay.UseAccentColor = false;
            this.butPlay.UseVisualStyleBackColor = false;
            this.butPlay.Click += new System.EventHandler(this.butPlay_Click);
            // 
            // butExit
            // 
            this.butExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.butExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.butExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.butExit.Depth = 0;
            this.butExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.butExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butExit.HighEmphasis = true;
            this.butExit.Icon = null;
            this.butExit.Location = new System.Drawing.Point(4, 111);
            this.butExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.butExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.butExit.Name = "butExit";
            this.butExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.butExit.Size = new System.Drawing.Size(425, 36);
            this.butExit.TabIndex = 1;
            this.butExit.Text = "Выход";
            this.butExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.butExit.UseAccentColor = false;
            this.butExit.UseVisualStyleBackColor = false;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.butExit, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.butPlay, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 242);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(433, 210);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(439, 455);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(900, 1100);
            this.MinimumSize = new System.Drawing.Size(439, 455);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton butPlay;
        private MaterialSkin.Controls.MaterialButton butExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}