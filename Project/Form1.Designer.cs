
namespace towers_of_hanoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtnoofmovements = new System.Windows.Forms.Label();
            this.btn_restart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "movements ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnoofmovements
            // 
            this.txtnoofmovements.AutoSize = true;
            this.txtnoofmovements.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.txtnoofmovements.Location = new System.Drawing.Point(347, 21);
            this.txtnoofmovements.Name = "txtnoofmovements";
            this.txtnoofmovements.Size = new System.Drawing.Size(42, 44);
            this.txtnoofmovements.TabIndex = 1;
            this.txtnoofmovements.Text = "0";
            // 
            // btn_restart
            // 
            this.btn_restart.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restart.Location = new System.Drawing.Point(509, 14);
            this.btn_restart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_restart.Name = "btn_restart";
            this.btn_restart.Size = new System.Drawing.Size(203, 52);
            this.btn_restart.TabIndex = 2;
            this.btn_restart.Text = "Restart";
            this.btn_restart.UseVisualStyleBackColor = true;
            this.btn_restart.Click += new System.EventHandler(this.btn_restart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "minimum movmentes is  7 ";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(867, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Resolve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_restart);
            this.Controls.Add(this.txtnoofmovements);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Towers Of Hanoi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtnoofmovements;
        private System.Windows.Forms.Button btn_restart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}

