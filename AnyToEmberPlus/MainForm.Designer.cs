namespace AnyToEmberPlus
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxDataProviders = new ListBox();
            btAdd = new Button();
            btRemove = new Button();
            btEdit = new Button();
            menuStrip1 = new MenuStrip();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            emberProviderToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            btStart = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxDataProviders
            // 
            listBoxDataProviders.FormattingEnabled = true;
            listBoxDataProviders.Items.AddRange(new object[] { "Egy", "Ketto", "Harom", "Negy" });
            listBoxDataProviders.Location = new Point(12, 32);
            listBoxDataProviders.Name = "listBoxDataProviders";
            listBoxDataProviders.Size = new Size(394, 324);
            listBoxDataProviders.TabIndex = 0;
            listBoxDataProviders.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(12, 362);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 29);
            btAdd.TabIndex = 1;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            // 
            // btRemove
            // 
            btRemove.Location = new Point(112, 362);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(94, 29);
            btRemove.TabIndex = 2;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(212, 362);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(94, 29);
            btEdit.TabIndex = 3;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, quitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(418, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { emberProviderToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(76, 24);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // emberProviderToolStripMenuItem
            // 
            emberProviderToolStripMenuItem.Name = "emberProviderToolStripMenuItem";
            emberProviderToolStripMenuItem.Size = new Size(224, 26);
            emberProviderToolStripMenuItem.Text = "Ember+ provider";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(51, 24);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // btStart
            // 
            btStart.Location = new Point(312, 362);
            btStart.Name = "btStart";
            btStart.Size = new Size(94, 29);
            btStart.TabIndex = 5;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 395);
            Controls.Add(btStart);
            Controls.Add(btEdit);
            Controls.Add(btRemove);
            Controls.Add(btAdd);
            Controls.Add(listBoxDataProviders);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxDataProviders;
        private Button btAdd;
        private Button btRemove;
        private Button btEdit;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem emberProviderToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Button btStart;
    }
}
