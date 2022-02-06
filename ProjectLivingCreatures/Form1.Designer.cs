
namespace ProjectLivingCreatures
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
            this.btnSeeHuman = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeeHuman
            // 
            this.btnSeeHuman.Location = new System.Drawing.Point(52, 79);
            this.btnSeeHuman.Name = "btnSeeHuman";
            this.btnSeeHuman.Size = new System.Drawing.Size(75, 23);
            this.btnSeeHuman.TabIndex = 0;
            this.btnSeeHuman.Text = "See Human";
            this.btnSeeHuman.UseVisualStyleBackColor = true;
            this.btnSeeHuman.Click += new System.EventHandler(this.btnSeeHuman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 200);
            this.Controls.Add(this.btnSeeHuman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeeHuman;
    }
}

