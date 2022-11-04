namespace Santa
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.carButton = new System.Windows.Forms.Button();
            this.ballButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.boxColorButton = new System.Windows.Forms.Button();
            this.ribbonColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(12, 307);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 131);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick_1);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // carButton
            // 
            this.carButton.Location = new System.Drawing.Point(45, 52);
            this.carButton.Name = "carButton";
            this.carButton.Size = new System.Drawing.Size(75, 23);
            this.carButton.TabIndex = 1;
            this.carButton.Text = "CAR";
            this.carButton.UseVisualStyleBackColor = true;
            this.carButton.Click += new System.EventHandler(this.carButton_Click);
            // 
            // ballButton
            // 
            this.ballButton.Location = new System.Drawing.Point(162, 52);
            this.ballButton.Name = "ballButton";
            this.ballButton.Size = new System.Drawing.Size(75, 23);
            this.ballButton.TabIndex = 2;
            this.ballButton.Text = "BALL";
            this.ballButton.UseVisualStyleBackColor = true;
            this.ballButton.Click += new System.EventHandler(this.ballButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coming Next:";
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.Red;
            this.colorButton.Location = new System.Drawing.Point(162, 96);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(75, 23);
            this.colorButton.TabIndex = 4;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "PRESENT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxColorButton
            // 
            this.boxColorButton.BackColor = System.Drawing.Color.Lime;
            this.boxColorButton.Location = new System.Drawing.Point(280, 96);
            this.boxColorButton.Name = "boxColorButton";
            this.boxColorButton.Size = new System.Drawing.Size(101, 23);
            this.boxColorButton.TabIndex = 6;
            this.boxColorButton.UseVisualStyleBackColor = false;
            this.boxColorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // ribbonColorButton
            // 
            this.ribbonColorButton.BackColor = System.Drawing.Color.Red;
            this.ribbonColorButton.Location = new System.Drawing.Point(280, 137);
            this.ribbonColorButton.Name = "ribbonColorButton";
            this.ribbonColorButton.Size = new System.Drawing.Size(101, 23);
            this.ribbonColorButton.TabIndex = 7;
            this.ribbonColorButton.UseVisualStyleBackColor = false;
            this.ribbonColorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ribbonColorButton);
            this.Controls.Add(this.boxColorButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ballButton);
            this.Controls.Add(this.carButton);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button carButton;
        private System.Windows.Forms.Button ballButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button boxColorButton;
        private System.Windows.Forms.Button ribbonColorButton;
    }
}

