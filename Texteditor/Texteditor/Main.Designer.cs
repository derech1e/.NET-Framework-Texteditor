
namespace Texteditor
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.RichTextBox();
            this.boldBtn = new System.Windows.Forms.Button();
            this.underLineBtn = new System.Windows.Forms.Button();
            this.italicButton = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBoxReplace = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladenStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.Location = new System.Drawing.Point(7, 63);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(542, 432);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "";
            // 
            // boldBtn
            // 
            this.boldBtn.Location = new System.Drawing.Point(12, 34);
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(24, 23);
            this.boldBtn.TabIndex = 4;
            this.boldBtn.Text = "B";
            this.boldBtn.UseVisualStyleBackColor = true;
            this.boldBtn.Click += new System.EventHandler(this.boldBtn_Click);
            // 
            // underLineBtn
            // 
            this.underLineBtn.Location = new System.Drawing.Point(42, 34);
            this.underLineBtn.Name = "underLineBtn";
            this.underLineBtn.Size = new System.Drawing.Size(24, 23);
            this.underLineBtn.TabIndex = 5;
            this.underLineBtn.Text = "U";
            this.underLineBtn.UseVisualStyleBackColor = true;
            this.underLineBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // italicButton
            // 
            this.italicButton.Location = new System.Drawing.Point(72, 34);
            this.italicButton.Name = "italicButton";
            this.italicButton.Size = new System.Drawing.Size(24, 23);
            this.italicButton.TabIndex = 6;
            this.italicButton.Text = "K";
            this.italicButton.UseVisualStyleBackColor = true;
            this.italicButton.Click += new System.EventHandler(this.italicButton_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(118, 36);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 8;
            // 
            // textBoxReplace
            // 
            this.textBoxReplace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxReplace.Location = new System.Drawing.Point(377, 36);
            this.textBoxReplace.Name = "textBoxReplace";
            this.textBoxReplace.Size = new System.Drawing.Size(100, 20);
            this.textBoxReplace.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(224, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 21);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(483, 36);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(66, 21);
            this.btnReplace.TabIndex = 13;
            this.btnReplace.Text = "Ersetzen";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(296, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 21);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Löschen";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.dateiToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(559, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.speichernUnterToolStripMenuItem, this.speichernToolStripMenuItem, this.ladenStripMenuItem });
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // speichernUnterToolStripMenuItem
            // 
            this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
            this.speichernUnterToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.speichernUnterToolStripMenuItem.Text = "Speichern unter";
            this.speichernUnterToolStripMenuItem.Click += new System.EventHandler(this.speichernUnterToolStripMenuItem_Click);
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Enabled = false;
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // ladenStripMenuItem
            // 
            this.ladenStripMenuItem.Name = "ladenStripMenuItem";
            this.ladenStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.ladenStripMenuItem.Text = "Laden";
            this.ladenStripMenuItem.Click += new System.EventHandler(this.ladenStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 501);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxReplace);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.italicButton);
            this.Controls.Add(this.underLineBtn);
            this.Controls.Add(this.boldBtn);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Texteditor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem ladenStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernUnterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;

        private System.Windows.Forms.Button btnClear;

        #endregion

        private System.Windows.Forms.RichTextBox textBox;
        private System.Windows.Forms.Button boldBtn;
        private System.Windows.Forms.Button underLineBtn;
        private System.Windows.Forms.Button italicButton;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxReplace;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReplace;
    }
}

