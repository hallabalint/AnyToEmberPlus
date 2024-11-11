namespace AnyToEmberPlus
{
    partial class EditProvider
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
            dgvProperties = new DataGridView();
            btOk = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProperties).BeginInit();
            SuspendLayout();
            // 
            // dgvProperties
            // 
            dgvProperties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProperties.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dgvProperties.Location = new Point(12, 12);
            dgvProperties.Name = "dgvProperties";
            dgvProperties.RowHeadersWidth = 51;
            dgvProperties.Size = new Size(557, 426);
            dgvProperties.TabIndex = 0;
            // 
            // btOk
            // 
            btOk.Location = new Point(12, 445);
            btOk.Name = "btOk";
            btOk.Size = new Size(94, 29);
            btOk.TabIndex = 1;
            btOk.Text = "Ok";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += button1_Click;
            // 
            // EditProvider
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 486);
            Controls.Add(btOk);
            Controls.Add(dgvProperties);
            Name = "EditProvider";
            Text = "EditProvider";
            ((System.ComponentModel.ISupportInitialize)dgvProperties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProperties;
        private Button btOk;
    }
}