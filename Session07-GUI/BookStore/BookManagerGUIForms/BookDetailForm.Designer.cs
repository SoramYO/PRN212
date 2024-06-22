namespace BookManagerGUIForms
{
    partial class BookDetailForm
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
            lblBookList = new Label();
            SuspendLayout();
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.BackColor = Color.Transparent;
            lblBookList.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookList.ForeColor = SystemColors.ButtonHighlight;
            lblBookList.ImageAlign = ContentAlignment.BottomCenter;
            lblBookList.Location = new Point(28, 23);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(370, 50);
            lblBookList.TabIndex = 4;
            lblBookList.Text = "Create | Update Book";
            // 
            // BookDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(1249, 600);
            Controls.Add(lblBookList);
            ForeColor = Color.Green;
            Name = "BookDetailForm";
            Text = "BookDetailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBookList;
    }
}