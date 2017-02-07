namespace Bulkseperator
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
            this.pic1HA = new System.Windows.Forms.Label();
            this.pic1LA = new System.Windows.Forms.Label();
            this.presureHH = new System.Windows.Forms.Label();
            this.liquidHH = new System.Windows.Forms.Label();
            this.oilValve = new System.Windows.Forms.ProgressBar();
            this.lic1LA = new System.Windows.Forms.Label();
            this.lic1HA = new System.Windows.Forms.Label();
            this.lic2LA = new System.Windows.Forms.Label();
            this.lic2HA = new System.Windows.Forms.Label();
            this.waterValve = new System.Windows.Forms.ProgressBar();
            this.gasValve = new System.Windows.Forms.ProgressBar();
            this.inputValve = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.oilMixedRect = new System.Windows.Forms.Label();
            this.waterRect = new System.Windows.Forms.Label();
            this.oilSeperatedRect = new System.Windows.Forms.Label();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lic2Bar = new VerticalProgressBar();
            this.lic1Bar = new VerticalProgressBar();
            this.pic1Bar = new VerticalProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic1HA
            // 
            this.pic1HA.AutoSize = true;
            this.pic1HA.BackColor = System.Drawing.Color.Transparent;
            this.pic1HA.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pic1HA.Location = new System.Drawing.Point(342, 110);
            this.pic1HA.Name = "pic1HA";
            this.pic1HA.Size = new System.Drawing.Size(16, 9);
            this.pic1HA.TabIndex = 10;
            this.pic1HA.Text = "HA";
            // 
            // pic1LA
            // 
            this.pic1LA.AutoSize = true;
            this.pic1LA.BackColor = System.Drawing.Color.Transparent;
            this.pic1LA.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pic1LA.Location = new System.Drawing.Point(342, 191);
            this.pic1LA.Name = "pic1LA";
            this.pic1LA.Size = new System.Drawing.Size(14, 9);
            this.pic1LA.TabIndex = 11;
            this.pic1LA.Text = "LA";
            // 
            // presureHH
            // 
            this.presureHH.AutoSize = true;
            this.presureHH.BackColor = System.Drawing.Color.Transparent;
            this.presureHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presureHH.Location = new System.Drawing.Point(266, 132);
            this.presureHH.Name = "presureHH";
            this.presureHH.Size = new System.Drawing.Size(17, 9);
            this.presureHH.TabIndex = 18;
            this.presureHH.Text = "HH";
            // 
            // liquidHH
            // 
            this.liquidHH.AutoSize = true;
            this.liquidHH.BackColor = System.Drawing.Color.Transparent;
            this.liquidHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liquidHH.Location = new System.Drawing.Point(424, 132);
            this.liquidHH.Name = "liquidHH";
            this.liquidHH.Size = new System.Drawing.Size(17, 9);
            this.liquidHH.TabIndex = 19;
            this.liquidHH.Text = "HH";
            // 
            // oilValve
            // 
            this.oilValve.Location = new System.Drawing.Point(789, 538);
            this.oilValve.Name = "oilValve";
            this.oilValve.Size = new System.Drawing.Size(80, 15);
            this.oilValve.TabIndex = 20;
            // 
            // lic1LA
            // 
            this.lic1LA.AutoSize = true;
            this.lic1LA.BackColor = System.Drawing.Color.Transparent;
            this.lic1LA.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lic1LA.Location = new System.Drawing.Point(531, 191);
            this.lic1LA.Name = "lic1LA";
            this.lic1LA.Size = new System.Drawing.Size(14, 9);
            this.lic1LA.TabIndex = 23;
            this.lic1LA.Text = "LA";
            // 
            // lic1HA
            // 
            this.lic1HA.AutoSize = true;
            this.lic1HA.BackColor = System.Drawing.Color.Transparent;
            this.lic1HA.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lic1HA.Location = new System.Drawing.Point(531, 110);
            this.lic1HA.Name = "lic1HA";
            this.lic1HA.Size = new System.Drawing.Size(16, 9);
            this.lic1HA.TabIndex = 22;
            this.lic1HA.Text = "HA";
            // 
            // lic2LA
            // 
            this.lic2LA.AutoSize = true;
            this.lic2LA.BackColor = System.Drawing.Color.Transparent;
            this.lic2LA.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lic2LA.Location = new System.Drawing.Point(811, 378);
            this.lic2LA.Name = "lic2LA";
            this.lic2LA.Size = new System.Drawing.Size(14, 9);
            this.lic2LA.TabIndex = 26;
            this.lic2LA.Text = "LA";
            // 
            // lic2HA
            // 
            this.lic2HA.AutoSize = true;
            this.lic2HA.BackColor = System.Drawing.Color.Transparent;
            this.lic2HA.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lic2HA.Location = new System.Drawing.Point(811, 297);
            this.lic2HA.Name = "lic2HA";
            this.lic2HA.Size = new System.Drawing.Size(16, 9);
            this.lic2HA.TabIndex = 25;
            this.lic2HA.Text = "HA";
            // 
            // waterValve
            // 
            this.waterValve.Location = new System.Drawing.Point(789, 652);
            this.waterValve.Name = "waterValve";
            this.waterValve.Size = new System.Drawing.Size(80, 15);
            this.waterValve.TabIndex = 27;
            // 
            // gasValve
            // 
            this.gasValve.Location = new System.Drawing.Point(657, 104);
            this.gasValve.Name = "gasValve";
            this.gasValve.Size = new System.Drawing.Size(80, 15);
            this.gasValve.TabIndex = 28;
            // 
            // inputValve
            // 
            this.inputValve.AutoSize = true;
            this.inputValve.BackColor = System.Drawing.Color.Transparent;
            this.inputValve.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputValve.Location = new System.Drawing.Point(118, 110);
            this.inputValve.Name = "inputValve";
            this.inputValve.Size = new System.Drawing.Size(43, 9);
            this.inputValve.TabIndex = 29;
            this.inputValve.Text = "Noodklepie";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // oilMixedRect
            // 
            this.oilMixedRect.BackColor = System.Drawing.Color.DimGray;
            this.oilMixedRect.Location = new System.Drawing.Point(156, 297);
            this.oilMixedRect.Name = "oilMixedRect";
            this.oilMixedRect.Size = new System.Drawing.Size(100, 36);
            this.oilMixedRect.TabIndex = 42;
            this.oilMixedRect.Text = "oilMixedRect";
            // 
            // waterRect
            // 
            this.waterRect.BackColor = System.Drawing.Color.Maroon;
            this.waterRect.Location = new System.Drawing.Point(156, 411);
            this.waterRect.Name = "waterRect";
            this.waterRect.Size = new System.Drawing.Size(100, 31);
            this.waterRect.TabIndex = 43;
            this.waterRect.Text = "waterRect";
            // 
            // oilSeperatedRect
            // 
            this.oilSeperatedRect.BackColor = System.Drawing.Color.DarkGray;
            this.oilSeperatedRect.Location = new System.Drawing.Point(613, 361);
            this.oilSeperatedRect.Name = "oilSeperatedRect";
            this.oilSeperatedRect.Size = new System.Drawing.Size(100, 23);
            this.oilSeperatedRect.TabIndex = 44;
            this.oilSeperatedRect.Text = "oilSeperatedRect";
            // 
            // btnStartTest
            // 
            this.btnStartTest.Location = new System.Drawing.Point(12, 530);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(75, 23);
            this.btnStartTest.TabIndex = 45;
            this.btnStartTest.Text = "StartTest";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMToolStripMenuItem,
            this.manualControlToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // cOMToolStripMenuItem
            // 
            this.cOMToolStripMenuItem.Name = "cOMToolStripMenuItem";
            this.cOMToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cOMToolStripMenuItem.Text = "Serial COM";
            this.cOMToolStripMenuItem.Click += new System.EventHandler(this.cOMToolStripMenuItem_Click);
            // 
            // manualControlToolStripMenuItem
            // 
            this.manualControlToolStripMenuItem.Name = "manualControlToolStripMenuItem";
            this.manualControlToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.manualControlToolStripMenuItem.Text = "Manual Control";
            this.manualControlToolStripMenuItem.Click += new System.EventHandler(this.manualControlToolStripMenuItem_Click);
            // 
            // lic2Bar
            // 
            this.lic2Bar.BackColor = System.Drawing.Color.White;
            this.lic2Bar.Location = new System.Drawing.Point(833, 297);
            this.lic2Bar.MarqueeAnimationSpeed = 2147483647;
            this.lic2Bar.Name = "lic2Bar";
            this.lic2Bar.Size = new System.Drawing.Size(15, 90);
            this.lic2Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.lic2Bar.TabIndex = 24;
            // 
            // lic1Bar
            // 
            this.lic1Bar.BackColor = System.Drawing.Color.White;
            this.lic1Bar.Location = new System.Drawing.Point(553, 110);
            this.lic1Bar.MarqueeAnimationSpeed = 1000000;
            this.lic1Bar.Name = "lic1Bar";
            this.lic1Bar.Size = new System.Drawing.Size(15, 90);
            this.lic1Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.lic1Bar.TabIndex = 21;
            // 
            // pic1Bar
            // 
            this.pic1Bar.BackColor = System.Drawing.Color.White;
            this.pic1Bar.Location = new System.Drawing.Point(364, 110);
            this.pic1Bar.MarqueeAnimationSpeed = 2147483647;
            this.pic1Bar.Name = "pic1Bar";
            this.pic1Bar.Size = new System.Drawing.Size(15, 90);
            this.pic1Bar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pic1Bar.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bulkseperator.Properties.Resources.bulkBackground3;
            this.ClientSize = new System.Drawing.Size(1004, 729);
            this.Controls.Add(this.btnStartTest);
            this.Controls.Add(this.oilSeperatedRect);
            this.Controls.Add(this.waterRect);
            this.Controls.Add(this.oilMixedRect);
            this.Controls.Add(this.inputValve);
            this.Controls.Add(this.gasValve);
            this.Controls.Add(this.waterValve);
            this.Controls.Add(this.lic2LA);
            this.Controls.Add(this.lic2HA);
            this.Controls.Add(this.lic2Bar);
            this.Controls.Add(this.lic1LA);
            this.Controls.Add(this.lic1HA);
            this.Controls.Add(this.lic1Bar);
            this.Controls.Add(this.oilValve);
            this.Controls.Add(this.liquidHH);
            this.Controls.Add(this.presureHH);
            this.Controls.Add(this.pic1LA);
            this.Controls.Add(this.pic1HA);
            this.Controls.Add(this.pic1Bar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Bulkseperator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VerticalProgressBar pic1Bar;
        private System.Windows.Forms.Label pic1HA;
        private System.Windows.Forms.Label pic1LA;
        private System.Windows.Forms.Label presureHH;
        private System.Windows.Forms.Label liquidHH;
        private System.Windows.Forms.ProgressBar oilValve;
        private System.Windows.Forms.Label lic1LA;
        private System.Windows.Forms.Label lic1HA;
        private VerticalProgressBar lic1Bar;
        private System.Windows.Forms.Label lic2LA;
        private System.Windows.Forms.Label lic2HA;
        private VerticalProgressBar lic2Bar;
        private System.Windows.Forms.ProgressBar waterValve;
        private System.Windows.Forms.ProgressBar gasValve;
        private System.Windows.Forms.Label inputValve;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label oilMixedRect;
        private System.Windows.Forms.Label waterRect;
        private System.Windows.Forms.Label oilSeperatedRect;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMToolStripMenuItem;
    }
}

