﻿namespace AnyToEmberPlus
{
    partial class AddProvider
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            tbNodeName = new TextBox();
            btClose = new Button();
            btSave = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 28);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 56);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 1;
            label1.Text = "Provider Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 79);
            tbName.Name = "tbName";
            tbName.Size = new Size(231, 27);
            tbName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 3;
            label2.Text = "Ember Node name";
            // 
            // tbNodeName
            // 
            tbNodeName.Location = new Point(12, 147);
            tbNodeName.Name = "tbNodeName";
            tbNodeName.Size = new Size(231, 27);
            tbNodeName.TabIndex = 4;
            // 
            // btClose
            // 
            btClose.Location = new Point(12, 196);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 5;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += button1_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(149, 196);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 6;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // AddProvider
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 235);
            Controls.Add(btSave);
            Controls.Add(btClose);
            Controls.Add(tbNodeName);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "AddProvider";
            Text = "AddProvider";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private TextBox tbName;
        private Label label2;
        private TextBox tbNodeName;
        private Button btClose;
        private Button btSave;
    }
}