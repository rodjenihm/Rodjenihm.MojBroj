namespace Rodjenihm.MojBroj
{
    partial class PlayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTarget3 = new System.Windows.Forms.TextBox();
            this.txtTarget1 = new System.Windows.Forms.TextBox();
            this.txtTarget2 = new System.Windows.Forms.TextBox();
            this.gbSmallNumbers = new System.Windows.Forms.GroupBox();
            this.txtInput4 = new System.Windows.Forms.TextBox();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.txtInput3 = new System.Windows.Forms.TextBox();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.gbBigNumbers = new System.Windows.Forms.GroupBox();
            this.txtInput6 = new System.Windows.Forms.TextBox();
            this.gbMediumNumbers = new System.Windows.Forms.GroupBox();
            this.txtInput5 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.pgElapsedTime = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.gbSmallNumbers.SuspendLayout();
            this.gbBigNumbers.SuspendLayout();
            this.gbMediumNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.txtTarget3);
            this.panel1.Controls.Add(this.txtTarget1);
            this.panel1.Controls.Add(this.txtTarget2);
            this.panel1.Controls.Add(this.gbSmallNumbers);
            this.panel1.Controls.Add(this.gbBigNumbers);
            this.panel1.Controls.Add(this.gbMediumNumbers);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 186);
            this.panel1.TabIndex = 0;
            // 
            // txtTarget3
            // 
            this.txtTarget3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarget3.Location = new System.Drawing.Point(203, 30);
            this.txtTarget3.Name = "txtTarget3";
            this.txtTarget3.ReadOnly = true;
            this.txtTarget3.Size = new System.Drawing.Size(30, 26);
            this.txtTarget3.TabIndex = 2;
            this.txtTarget3.TabStop = false;
            this.txtTarget3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTarget1
            // 
            this.txtTarget1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarget1.Location = new System.Drawing.Point(127, 30);
            this.txtTarget1.MaxLength = 3;
            this.txtTarget1.Name = "txtTarget1";
            this.txtTarget1.ReadOnly = true;
            this.txtTarget1.Size = new System.Drawing.Size(30, 26);
            this.txtTarget1.TabIndex = 0;
            this.txtTarget1.TabStop = false;
            this.txtTarget1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTarget2
            // 
            this.txtTarget2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarget2.Location = new System.Drawing.Point(165, 30);
            this.txtTarget2.Name = "txtTarget2";
            this.txtTarget2.ReadOnly = true;
            this.txtTarget2.Size = new System.Drawing.Size(30, 26);
            this.txtTarget2.TabIndex = 1;
            this.txtTarget2.TabStop = false;
            this.txtTarget2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbSmallNumbers
            // 
            this.gbSmallNumbers.Controls.Add(this.txtInput4);
            this.gbSmallNumbers.Controls.Add(this.txtInput1);
            this.gbSmallNumbers.Controls.Add(this.txtInput3);
            this.gbSmallNumbers.Controls.Add(this.txtInput2);
            this.gbSmallNumbers.Location = new System.Drawing.Point(10, 73);
            this.gbSmallNumbers.Name = "gbSmallNumbers";
            this.gbSmallNumbers.Size = new System.Drawing.Size(180, 90);
            this.gbSmallNumbers.TabIndex = 3;
            this.gbSmallNumbers.TabStop = false;
            // 
            // txtInput4
            // 
            this.txtInput4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput4.Location = new System.Drawing.Point(132, 32);
            this.txtInput4.MaxLength = 1;
            this.txtInput4.Name = "txtInput4";
            this.txtInput4.ReadOnly = true;
            this.txtInput4.Size = new System.Drawing.Size(30, 26);
            this.txtInput4.TabIndex = 3;
            this.txtInput4.TabStop = false;
            this.txtInput4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInput1
            // 
            this.txtInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput1.Location = new System.Drawing.Point(18, 32);
            this.txtInput1.MaxLength = 1;
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.ReadOnly = true;
            this.txtInput1.Size = new System.Drawing.Size(30, 26);
            this.txtInput1.TabIndex = 0;
            this.txtInput1.TabStop = false;
            this.txtInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInput3
            // 
            this.txtInput3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput3.Location = new System.Drawing.Point(94, 32);
            this.txtInput3.MaxLength = 1;
            this.txtInput3.Name = "txtInput3";
            this.txtInput3.ReadOnly = true;
            this.txtInput3.Size = new System.Drawing.Size(30, 26);
            this.txtInput3.TabIndex = 2;
            this.txtInput3.TabStop = false;
            this.txtInput3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInput2
            // 
            this.txtInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput2.Location = new System.Drawing.Point(56, 32);
            this.txtInput2.MaxLength = 1;
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.ReadOnly = true;
            this.txtInput2.Size = new System.Drawing.Size(30, 26);
            this.txtInput2.TabIndex = 1;
            this.txtInput2.TabStop = false;
            this.txtInput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbBigNumbers
            // 
            this.gbBigNumbers.Controls.Add(this.txtInput6);
            this.gbBigNumbers.Location = new System.Drawing.Point(290, 73);
            this.gbBigNumbers.Name = "gbBigNumbers";
            this.gbBigNumbers.Size = new System.Drawing.Size(60, 90);
            this.gbBigNumbers.TabIndex = 5;
            this.gbBigNumbers.TabStop = false;
            // 
            // txtInput6
            // 
            this.txtInput6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput6.Location = new System.Drawing.Point(10, 32);
            this.txtInput6.MaxLength = 3;
            this.txtInput6.Name = "txtInput6";
            this.txtInput6.ReadOnly = true;
            this.txtInput6.Size = new System.Drawing.Size(40, 26);
            this.txtInput6.TabIndex = 0;
            this.txtInput6.TabStop = false;
            this.txtInput6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbMediumNumbers
            // 
            this.gbMediumNumbers.Controls.Add(this.txtInput5);
            this.gbMediumNumbers.Location = new System.Drawing.Point(210, 73);
            this.gbMediumNumbers.Name = "gbMediumNumbers";
            this.gbMediumNumbers.Size = new System.Drawing.Size(60, 90);
            this.gbMediumNumbers.TabIndex = 4;
            this.gbMediumNumbers.TabStop = false;
            // 
            // txtInput5
            // 
            this.txtInput5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput5.Location = new System.Drawing.Point(10, 32);
            this.txtInput5.MaxLength = 2;
            this.txtInput5.Name = "txtInput5";
            this.txtInput5.ReadOnly = true;
            this.txtInput5.Size = new System.Drawing.Size(40, 26);
            this.txtInput5.TabIndex = 0;
            this.txtInput5.TabStop = false;
            this.txtInput5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(280, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 9;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Resetuj";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnRandomize
            // 
            this.btnRandomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomize.Location = new System.Drawing.Point(200, 220);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(75, 30);
            this.btnRandomize.TabIndex = 8;
            this.btnRandomize.TabStop = false;
            this.btnRandomize.Text = "Počni";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.BtnRandomize_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(12, 300);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(300, 26);
            this.txtAnswer.TabIndex = 11;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pgElapsedTime
            // 
            this.pgElapsedTime.Location = new System.Drawing.Point(12, 256);
            this.pgElapsedTime.Name = "pgElapsedTime";
            this.pgElapsedTime.Size = new System.Drawing.Size(360, 26);
            this.pgElapsedTime.Step = 1;
            this.pgElapsedTime.TabIndex = 12;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(322, 300);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(40, 26);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "✔";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(12, 344);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(360, 26);
            this.txtInfo.TabIndex = 14;
            this.txtInfo.TabStop = false;
            this.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pgElapsedTime);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRandomize);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlayForm";
            this.Text = "Igraj";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbSmallNumbers.ResumeLayout(false);
            this.gbSmallNumbers.PerformLayout();
            this.gbBigNumbers.ResumeLayout(false);
            this.gbBigNumbers.PerformLayout();
            this.gbMediumNumbers.ResumeLayout(false);
            this.gbMediumNumbers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTarget1;
        private System.Windows.Forms.GroupBox gbSmallNumbers;
        private System.Windows.Forms.TextBox txtInput4;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput3;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.GroupBox gbBigNumbers;
        private System.Windows.Forms.TextBox txtInput6;
        private System.Windows.Forms.GroupBox gbMediumNumbers;
        private System.Windows.Forms.TextBox txtInput5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.TextBox txtTarget3;
        private System.Windows.Forms.TextBox txtTarget2;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.ProgressBar pgElapsedTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtInfo;
    }
}