namespace calculadorarealksks
{
    partial class FormHistorico
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
            lstHistorico = new ListBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lstHistorico
            // 
            lstHistorico.BackColor = Color.FromArgb(238, 244, 249);
            lstHistorico.BorderStyle = BorderStyle.None;
            lstHistorico.Font = new Font("Segoe UI", 11F);
            lstHistorico.FormattingEnabled = true;
            lstHistorico.Location = new Point(31, 38);
            lstHistorico.Name = "lstHistorico";
            lstHistorico.Size = new Size(281, 360);
            lstHistorico.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 244, 249);
            panel1.Location = new Point(17, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 403);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // FormHistorico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(343, 450);
            Controls.Add(lstHistorico);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormHistorico";
            Text = "FormHistorico";
            Load += FormHistorico_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstHistorico;
        private Panel panel1;
    }
}