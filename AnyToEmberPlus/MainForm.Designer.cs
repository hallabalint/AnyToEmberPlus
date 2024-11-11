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
            refresToolStripMenuItem = new ToolStripMenuItem();
            btStart = new Button();
            refresToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxDataProviders
            // 
            listBoxDataProviders.DisplayMember = "identifier";
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
            btAdd.Click += btAdd_Click;
            // 
            // btRemove
            // 
            btRemove.Location = new Point(112, 362);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(94, 29);
            btRemove.TabIndex = 2;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(212, 362);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(94, 29);
            btEdit.TabIndex = 3;
            btEdit.Text = "Edit";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, quitToolStripMenuItem, refresToolStripMenuItem });
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
            emberProviderToolStripMenuItem.Size = new Size(205, 26);
            emberProviderToolStripMenuItem.Text = "Ember+ provider";
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(51, 24);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // refresToolStripMenuItem
            // 
            refresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { refresToolStripMenuItem1 });
            refresToolStripMenuItem.Name = "refresToolStripMenuItem";
            refresToolStripMenuItem.Size = new Size(64, 24);
            refresToolStripMenuItem.Text = "Refres";
            refresToolStripMenuItem.Click += refresToolStripMenuItem_Click;
            // 
            // btStart
            // 
            btStart.Location = new Point(312, 362);
            btStart.Name = "btStart";
            btStart.Size = new Size(94, 29);
            btStart.TabIndex = 5;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // refresToolStripMenuItem1
            // 
            refresToolStripMenuItem1.Name = "refresToolStripMenuItem1";
            refresToolStripMenuItem1.Size = new Size(133, 26);
            refresToolStripMenuItem1.Text = "Refres";
            // 
            // MainForm
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
            Name = "MainForm";
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
        private ToolStripMenuItem refresToolStripMenuItem;
        private ToolStripMenuItem refresToolStripMenuItem1;
    }
}
