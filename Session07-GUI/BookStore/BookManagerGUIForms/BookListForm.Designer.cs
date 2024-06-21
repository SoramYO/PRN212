namespace BookManagerGUIForms
{
    partial class BookListForm
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
            btnAbout = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(2, 1);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(220, 84);
            btnAbout.TabIndex = 0;
            btnAbout.Text = "About us";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(372, 52);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(220, 84);
            btnQuit.TabIndex = 1;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // BookListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1384, 692);
            Controls.Add(btnQuit);
            Controls.Add(btnAbout);
            Name = "BookListForm";
            Text = "Book List";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAbout;
        private Button btnQuit;
    }
}
