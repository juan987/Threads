namespace Threads
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstmensajes = new System.Windows.Forms.ListBox();
            this.btncomenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejecucion de hilos";
            // 
            // lstmensajes
            // 
            this.lstmensajes.FormattingEnabled = true;
            this.lstmensajes.Location = new System.Drawing.Point(43, 60);
            this.lstmensajes.Name = "lstmensajes";
            this.lstmensajes.Size = new System.Drawing.Size(214, 264);
            this.lstmensajes.TabIndex = 1;
            // 
            // btncomenzar
            // 
            this.btncomenzar.Location = new System.Drawing.Point(43, 360);
            this.btncomenzar.Name = "btncomenzar";
            this.btncomenzar.Size = new System.Drawing.Size(75, 23);
            this.btncomenzar.TabIndex = 2;
            this.btncomenzar.Text = "Comenzar ejecucion";
            this.btncomenzar.UseVisualStyleBackColor = true;
            this.btncomenzar.Click += new System.EventHandler(this.btncomenzar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 469);
            this.Controls.Add(this.btncomenzar);
            this.Controls.Add(this.lstmensajes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstmensajes;
        private System.Windows.Forms.Button btncomenzar;
    }
}

