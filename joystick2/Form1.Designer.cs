namespace joystick2
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
            components = new System.ComponentModel.Container();
            panelJoystick = new Panel();
            label1 = new Label();
            moveTimer = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            SuspendLayout();
            // 
            // panelJoystick
            // 
            panelJoystick.BackColor = Color.Transparent;
            panelJoystick.BackgroundImageLayout = ImageLayout.Stretch;
            panelJoystick.Location = new Point(189, 191);
            panelJoystick.Name = "panelJoystick";
            panelJoystick.Size = new Size(114, 100);
            panelJoystick.TabIndex = 0;
            panelJoystick.Paint += panelJoystick_Paint;
            panelJoystick.MouseDown += PanelJoystickMouseDown;
            panelJoystick.MouseMove += PanelJoystickMouseMove;
            panelJoystick.MouseUp += PanelJoystickMouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(451, 461);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // moveTimer
            // 
            moveTimer.Interval = 1000;
            moveTimer.Tick += moveTimer_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(377, 461);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 2;
            label2.Text = "PANEL X :0 | PANEL Y :0";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.lime_circle;
            ClientSize = new Size(519, 485);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panelJoystick);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelJoystick;
        private Label label1;
        private System.Windows.Forms.Timer moveTimer;
        private Label label2;
    }
}
