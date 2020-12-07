namespace Consuela
{
    partial class fr_load
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_load));
            this.pb_load = new System.Windows.Forms.PictureBox();
            this.la_consuela = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_load)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_load
            // 
            this.pb_load.Image = ((System.Drawing.Image)(resources.GetObject("pb_load.Image")));
            this.pb_load.Location = new System.Drawing.Point(3, 52);
            this.pb_load.Name = "pb_load";
            this.pb_load.Size = new System.Drawing.Size(427, 199);
            this.pb_load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_load.TabIndex = 0;
            this.pb_load.TabStop = false;
            // 
            // la_consuela
            // 
            this.la_consuela.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.la_consuela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(192)))), ((int)(((byte)(207)))));
            this.la_consuela.Location = new System.Drawing.Point(-2, 9);
            this.la_consuela.Name = "la_consuela";
            this.la_consuela.Size = new System.Drawing.Size(427, 40);
            this.la_consuela.TabIndex = 1;
            this.la_consuela.Text = "CONSUELA";
            this.la_consuela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fr_load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(450, 292);
            this.Controls.Add(this.la_consuela);
            this.Controls.Add(this.pb_load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fr_load";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_load)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_load;
        private System.Windows.Forms.Label la_consuela;
        private System.Windows.Forms.Timer timer1;
    }
}

