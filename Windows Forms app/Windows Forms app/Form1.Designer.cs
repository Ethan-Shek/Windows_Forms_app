namespace Windows_Forms_app
{
    partial class Form1
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
            btnAdd = new Button();
            label = new Label();
            IstName = new ListBox();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(138, 55);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Name";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 9);
            label.Name = "label";
            label.Size = new Size(44, 15);
            label.TabIndex = 1;
            label.Text = "Names";
            // 
            // IstName
            // 
            IstName.FormattingEnabled = true;
            IstName.ItemHeight = 15;
            IstName.Location = new Point(12, 27);
            IstName.Name = "IstName";
            IstName.Size = new Size(120, 94);
            IstName.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 141);
            Controls.Add(txtName);
            Controls.Add(IstName);
            Controls.Add(label);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Names";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label;
        private ListBox IstName;
        private TextBox txtName;
        public Button btnAdd;
    }
}
