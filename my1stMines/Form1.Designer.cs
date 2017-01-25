namespace my1stMines
{
    partial class myNiceForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x99ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x1640ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorSchemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackAndOrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deskPicBox = new System.Windows.Forms.PictureBox();
            this.flagLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deskPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.colorSchemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(649, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x99ToolStripMenuItem,
            this.x1640ToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // x99ToolStripMenuItem
            // 
            this.x99ToolStripMenuItem.Name = "x99ToolStripMenuItem";
            this.x99ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.x99ToolStripMenuItem.Text = "9 X 9 10";
            this.x99ToolStripMenuItem.Click += new System.EventHandler(this.x1010ToolStripMenuItem_Click);
            // 
            // x1640ToolStripMenuItem
            // 
            this.x1640ToolStripMenuItem.Name = "x1640ToolStripMenuItem";
            this.x1640ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.x1640ToolStripMenuItem.Text = "16 X 16 40";
            this.x1640ToolStripMenuItem.Click += new System.EventHandler(this.x1640ToolStripMenuItem_Click);
            // 
            // colorSchemeToolStripMenuItem
            // 
            this.colorSchemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkBlueToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.blackAndOrangeToolStripMenuItem});
            this.colorSchemeToolStripMenuItem.Name = "colorSchemeToolStripMenuItem";
            this.colorSchemeToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.colorSchemeToolStripMenuItem.Text = "Color scheme";
            // 
            // darkBlueToolStripMenuItem
            // 
            this.darkBlueToolStripMenuItem.Name = "darkBlueToolStripMenuItem";
            this.darkBlueToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.darkBlueToolStripMenuItem.Text = "Dark Blue";
            this.darkBlueToolStripMenuItem.Click += new System.EventHandler(this.darkBlueToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.purpleToolStripMenuItem.Text = "Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // blackAndOrangeToolStripMenuItem
            // 
            this.blackAndOrangeToolStripMenuItem.Name = "blackAndOrangeToolStripMenuItem";
            this.blackAndOrangeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.blackAndOrangeToolStripMenuItem.Text = "Gray and Orange";
            this.blackAndOrangeToolStripMenuItem.Click += new System.EventHandler(this.blackAndOrangeToolStripMenuItem_Click);
            // 
            // deskPicBox
            // 
            this.deskPicBox.BackColor = System.Drawing.Color.Silver;
            this.deskPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deskPicBox.Location = new System.Drawing.Point(0, 24);
            this.deskPicBox.Name = "deskPicBox";
            this.deskPicBox.Size = new System.Drawing.Size(649, 438);
            this.deskPicBox.TabIndex = 3;
            this.deskPicBox.TabStop = false;
            this.deskPicBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.deskPicBox_MouseClick);
            // 
            // flagLabel
            // 
            this.flagLabel.AutoSize = true;
            this.flagLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flagLabel.Location = new System.Drawing.Point(481, 8);
            this.flagLabel.Name = "flagLabel";
            this.flagLabel.Size = new System.Drawing.Size(58, 13);
            this.flagLabel.TabIndex = 4;
            this.flagLabel.Text = " Flags left: ";
            // 
            // myNiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(649, 462);
            this.Controls.Add(this.flagLabel);
            this.Controls.Add(this.deskPicBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "myNiceForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.myNiceForm_Load);
            this.Resize += new System.EventHandler(this.myNiceForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deskPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox deskPicBox;
        private System.Windows.Forms.ToolStripMenuItem x99ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x1640ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorSchemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackAndOrangeToolStripMenuItem;
        private System.Windows.Forms.Label flagLabel;
    }
}

