namespace Ch3WinFormsApp2Instances
{
    partial class Form1
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
            Silvia = new Button();
            Supra = new Button();
            Cefiro = new Button();
            Forester = new Button();
            CSupra = new Button();
            CSilvia = new Button();
            CCefiro = new Button();
            CFozzy = new Button();
            SuspendLayout();
            // 
            // Silvia
            // 
            Silvia.Location = new Point(12, 12);
            Silvia.Name = "Silvia";
            Silvia.Size = new Size(94, 29);
            Silvia.TabIndex = 0;
            Silvia.Text = "Silvia";
            Silvia.UseVisualStyleBackColor = true;
            Silvia.Click += Silvia_Click;
            // 
            // Supra
            // 
            Supra.Location = new Point(112, 12);
            Supra.Name = "Supra";
            Supra.Size = new Size(94, 29);
            Supra.TabIndex = 1;
            Supra.Text = "Supra";
            Supra.UseVisualStyleBackColor = true;
            Supra.Click += Supra_Click;
            // 
            // Cefiro
            // 
            Cefiro.Location = new Point(12, 47);
            Cefiro.Name = "Cefiro";
            Cefiro.Size = new Size(94, 29);
            Cefiro.TabIndex = 2;
            Cefiro.Text = "Cefiro";
            Cefiro.UseVisualStyleBackColor = true;
            Cefiro.Click += Cefiro_Click;
            // 
            // Forester
            // 
            Forester.Location = new Point(112, 47);
            Forester.Name = "Forester";
            Forester.Size = new Size(94, 29);
            Forester.TabIndex = 3;
            Forester.Text = "Forester";
            Forester.UseVisualStyleBackColor = true;
            Forester.Click += Forester_Click;
            // 
            // CSupra
            // 
            CSupra.Location = new Point(331, 12);
            CSupra.Name = "CSupra";
            CSupra.Size = new Size(113, 29);
            CSupra.TabIndex = 4;
            CSupra.Text = "Custom Supra";
            CSupra.UseVisualStyleBackColor = true;
            CSupra.Click += CSupra_Click;
            // 
            // CSilvia
            // 
            CSilvia.Location = new Point(212, 12);
            CSilvia.Name = "CSilvia";
            CSilvia.Size = new Size(113, 29);
            CSilvia.TabIndex = 5;
            CSilvia.Text = "Custom Silvia";
            CSilvia.UseVisualStyleBackColor = true;
            CSilvia.Click += CSilvia_Click;
            // 
            // CCefiro
            // 
            CCefiro.Location = new Point(212, 47);
            CCefiro.Name = "CCefiro";
            CCefiro.Size = new Size(113, 29);
            CCefiro.TabIndex = 6;
            CCefiro.Text = "Custom Cefiro";
            CCefiro.UseVisualStyleBackColor = true;
            CCefiro.Click += CCefiro_Click;
            // 
            // CFozzy
            // 
            CFozzy.Location = new Point(331, 47);
            CFozzy.Name = "CFozzy";
            CFozzy.Size = new Size(113, 29);
            CFozzy.TabIndex = 7;
            CFozzy.Text = "Custom Fozzy";
            CFozzy.UseVisualStyleBackColor = true;
            CFozzy.Click += CFozzy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CFozzy);
            Controls.Add(CCefiro);
            Controls.Add(CSilvia);
            Controls.Add(CSupra);
            Controls.Add(Forester);
            Controls.Add(Cefiro);
            Controls.Add(Supra);
            Controls.Add(Silvia);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Silvia;
        private Button Supra;
        private Button Cefiro;
        private Button Forester;
        private Button CSupra;
        private Button CSilvia;
        private Button CCefiro;
        private Button CFozzy;
    }
}