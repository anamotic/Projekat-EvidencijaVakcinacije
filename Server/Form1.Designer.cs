namespace Server
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
            btnStart = new Button();
            txtServer = new TextBox();
            btnStop = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(135, 239);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(127, 65);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtServer
            // 
            txtServer.Location = new Point(212, 167);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(243, 27);
            txtServer.TabIndex = 4;
            txtServer.Text = "Server trenutno nije pokrenut!";
            txtServer.TextAlign = HorizontalAlignment.Center;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(377, 239);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(127, 65);
            btnStop.TabIndex = 5;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 450);
            Controls.Add(btnStop);
            Controls.Add(txtServer);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Server";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private TextBox txtServer;
        private Button btnStop;
    }
}
