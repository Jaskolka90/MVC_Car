namespace MVC_v3
{
    partial class MainView
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
            this.btnColor = new System.Windows.Forms.Button();
            this.btnLights = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnGoForward = new System.Windows.Forms.Button();
            this.btnGoBackword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(10, 400);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(100, 30);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Kolor";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnLights
            // 
            this.btnLights.Location = new System.Drawing.Point(125, 400);
            this.btnLights.Name = "btnLights";
            this.btnLights.Size = new System.Drawing.Size(100, 30);
            this.btnLights.TabIndex = 0;
            this.btnLights.Text = "Światła";
            this.btnLights.UseVisualStyleBackColor = true;
            this.btnLights.Click += new System.EventHandler(this.btnLights_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(470, 400);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 30);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnGoForward
            // 
            this.btnGoForward.Location = new System.Drawing.Point(240, 400);
            this.btnGoForward.Name = "btnGoForward";
            this.btnGoForward.Size = new System.Drawing.Size(100, 30);
            this.btnGoForward.TabIndex = 0;
            this.btnGoForward.Text = "Do przodu";
            this.btnGoForward.UseVisualStyleBackColor = true;
            this.btnGoForward.Click += new System.EventHandler(this.btnGoForward_Click);
            // 
            // btnGoBackword
            // 
            this.btnGoBackword.Location = new System.Drawing.Point(355, 400);
            this.btnGoBackword.Name = "btnGoBackword";
            this.btnGoBackword.Size = new System.Drawing.Size(100, 30);
            this.btnGoBackword.TabIndex = 0;
            this.btnGoBackword.Text = "Do tył";
            this.btnGoBackword.UseVisualStyleBackColor = true;
            this.btnGoBackword.Click += new System.EventHandler(this.btnGoBackword_Click);
            // 
            // MainView
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(582, 453);
            this.Controls.Add(this.btnGoBackword);
            this.Controls.Add(this.btnGoForward);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnLights);
            this.Controls.Add(this.btnColor);
            this.Name = "MainView";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainView_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnLights;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnGoForward;
        private System.Windows.Forms.Button btnGoBackword;
    }
}

