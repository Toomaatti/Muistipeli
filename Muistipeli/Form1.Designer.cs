namespace _120_Muistipeli
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
        public void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Ajastin = new System.Windows.Forms.Timer(components);
            P2 = new Label();
            P1 = new Label();
            SuspendLayout();
            // 
            // Ajastin
            // 
            Ajastin.Interval = 500;
            Ajastin.Tick += Ajastin_Tick;
            // 
            // P2
            // 
            P2.AutoSize = true;
            P2.ForeColor = SystemColors.ControlText;
            P2.Location = new Point(867, 103);
            P2.Name = "P2";
            P2.Size = new Size(0, 25);
            P2.TabIndex = 16;
            // 
            // P1
            // 
            P1.AutoSize = true;
            P1.Location = new Point(867, 9);
            P1.Name = "P1";
            P1.Size = new Size(0, 25);
            P1.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 460);
            Controls.Add(P1);
            Controls.Add(P2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private System.Windows.Forms.Timer Ajastin;
      
        private Label P2;
        private Label P1;

    }
}
