namespace AhmadProject
{
    partial class Form1
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
            this.Play = new System.Windows.Forms.Label();
            this.EXIT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.AutoSize = true;
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(63, 289);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(99, 36);
            this.Play.TabIndex = 2;
            this.Play.Text = "PLAY";
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // EXIT
            // 
            this.EXIT.AutoSize = true;
            this.EXIT.BackColor = System.Drawing.Color.Transparent;
            this.EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EXIT.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.Location = new System.Drawing.Point(328, 289);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(91, 36);
            this.EXIT.TabIndex = 3;
            this.EXIT.Text = "EXIT";
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AhmadProject.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(486, 354);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.Play);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackgroundImageLayoutChanged += new System.EventHandler(this.Form1_BackgroundImageLayoutChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Play;
        private System.Windows.Forms.Label EXIT;

        public System.EventHandler Exitbutton_Click { get; set; }
    }
}

