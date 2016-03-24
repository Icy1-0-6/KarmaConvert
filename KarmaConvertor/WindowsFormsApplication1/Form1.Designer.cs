namespace KarmaConvertor
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
            this.components = new System.ComponentModel.Container();
            this.Forge = new System.Windows.Forms.Timer(this.components);
            this.Realforge = new System.Windows.Forms.Timer(this.components);
            this.testTimer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblXas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblYas = new System.Windows.Forms.Label();
            this.MouseTrackTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Forge
            // 
            this.Forge.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Realforge
            // 
            this.Realforge.Tick += new System.EventHandler(this.Realforge_Tick);
            // 
            // testTimer1
            // 
            this.testTimer1.Tick += new System.EventHandler(this.testTimer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblXas
            // 
            this.lblXas.AutoSize = true;
            this.lblXas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXas.Location = new System.Drawing.Point(25, 102);
            this.lblXas.Name = "lblXas";
            this.lblXas.Size = new System.Drawing.Size(52, 20);
            this.lblXas.TabIndex = 2;
            this.lblXas.Text = "lblXas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set PackCount";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Return PackCount value";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYas.Location = new System.Drawing.Point(25, 122);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(52, 20);
            this.lblYas.TabIndex = 5;
            this.lblYas.Text = "lblYas";
            // 
            // MouseTrackTimer
            // 
            this.MouseTrackTimer.Tick += new System.EventHandler(this.MouseTrackTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblXas);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Forge;
        private System.Windows.Forms.Timer Realforge;
        private System.Windows.Forms.Timer testTimer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblXas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Timer MouseTrackTimer;
    }
}

