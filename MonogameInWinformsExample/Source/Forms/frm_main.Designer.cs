using Monogame2DEditor.Source;

namespace MonogameInWinformsExample
{
    partial class frm_main
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
            this.editorContext = new Editor();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editorContext
            // 
            this.editorContext.Location = new System.Drawing.Point(66, 12);
            this.editorContext.Name = "editorContext";
            this.editorContext.Size = new System.Drawing.Size(504, 405);
            this.editorContext.TabIndex = 0;
            this.editorContext.Text = "editorContext";
            this.editorContext.Click += new System.EventHandler(this.editor1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_main
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editorContext);
            this.Name = "frm_main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Editor editorContext;
        private System.Windows.Forms.Button button1;
    }
}

