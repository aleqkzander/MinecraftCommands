namespace MinecraftCommands
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
            button1 = new Button();
            KnopfCreeperSpawnen = new Button();
            AnzahlCreeper = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AnzahlCreeper).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(165, 23);
            button1.TabIndex = 0;
            button1.Text = "Command-Block erstellen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // KnopfCreeperSpawnen
            // 
            KnopfCreeperSpawnen.Location = new Point(12, 41);
            KnopfCreeperSpawnen.Name = "KnopfCreeperSpawnen";
            KnopfCreeperSpawnen.Size = new Size(166, 23);
            KnopfCreeperSpawnen.TabIndex = 1;
            KnopfCreeperSpawnen.Text = "Creeper spawnen";
            KnopfCreeperSpawnen.UseVisualStyleBackColor = true;
            KnopfCreeperSpawnen.Click += KnopfCreeperSpawnen_Click;
            // 
            // AnzahlCreeper
            // 
            AnzahlCreeper.Location = new Point(184, 41);
            AnzahlCreeper.Maximum = new decimal(new int[] { -1981284353, -1966660860, 0, 0 });
            AnzahlCreeper.Name = "AnzahlCreeper";
            AnzahlCreeper.Size = new Size(68, 23);
            AnzahlCreeper.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 628);
            Controls.Add(AnzahlCreeper);
            Controls.Add(KnopfCreeperSpawnen);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AnzahlCreeper).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button KnopfCreeperSpawnen;
        private NumericUpDown AnzahlCreeper;
    }
}
