namespace AutoMouse
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXPoint = new System.Windows.Forms.TextBox();
            this.txtYPoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRepeat = new System.Windows.Forms.TextBox();
            this.butGetMouse = new System.Windows.Forms.Button();
            this.butStart = new System.Windows.Forms.Button();
            this.butExit = new System.Windows.Forms.Button();
            this.butStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtCycle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labCount = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtStartCycle = new System.Windows.Forms.TextBox();
            this.txtEndCycle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mouse Point";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(24, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(24, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Y";
            // 
            // txtXPoint
            // 
            this.txtXPoint.Location = new System.Drawing.Point(52, 42);
            this.txtXPoint.Name = "txtXPoint";
            this.txtXPoint.Size = new System.Drawing.Size(68, 21);
            this.txtXPoint.TabIndex = 3;
            // 
            // txtYPoint
            // 
            this.txtYPoint.Location = new System.Drawing.Point(52, 74);
            this.txtYPoint.Name = "txtYPoint";
            this.txtYPoint.Size = new System.Drawing.Size(68, 21);
            this.txtYPoint.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(26, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "반복 횟수";
            // 
            // txtRepeat
            // 
            this.txtRepeat.Location = new System.Drawing.Point(103, 116);
            this.txtRepeat.Name = "txtRepeat";
            this.txtRepeat.Size = new System.Drawing.Size(68, 21);
            this.txtRepeat.TabIndex = 6;
            this.txtRepeat.Text = "100";
            // 
            // butGetMouse
            // 
            this.butGetMouse.Location = new System.Drawing.Point(126, 46);
            this.butGetMouse.Name = "butGetMouse";
            this.butGetMouse.Size = new System.Drawing.Size(101, 48);
            this.butGetMouse.TabIndex = 7;
            this.butGetMouse.Text = "Get Mouse Point";
            this.butGetMouse.UseVisualStyleBackColor = true;
            this.butGetMouse.Click += new System.EventHandler(this.butGetMouse_Click);
            // 
            // butStart
            // 
            this.butStart.Location = new System.Drawing.Point(26, 243);
            this.butStart.Name = "butStart";
            this.butStart.Size = new System.Drawing.Size(76, 39);
            this.butStart.TabIndex = 8;
            this.butStart.Text = "Start";
            this.butStart.UseVisualStyleBackColor = true;
            this.butStart.Click += new System.EventHandler(this.butStart_Click);
            // 
            // butExit
            // 
            this.butExit.Location = new System.Drawing.Point(28, 288);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(174, 39);
            this.butExit.TabIndex = 9;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click_1);
            // 
            // butStop
            // 
            this.butStop.Location = new System.Drawing.Point(126, 243);
            this.butStop.Name = "butStop";
            this.butStop.Size = new System.Drawing.Size(76, 39);
            this.butStop.TabIndex = 10;
            this.butStop.Text = "STOP";
            this.butStop.UseVisualStyleBackColor = true;
            this.butStop.Click += new System.EventHandler(this.butStop_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(26, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "반복 주기";
            // 
            // txtCycle
            // 
            this.txtCycle.Enabled = false;
            this.txtCycle.Location = new System.Drawing.Point(103, 205);
            this.txtCycle.Name = "txtCycle";
            this.txtCycle.Size = new System.Drawing.Size(68, 21);
            this.txtCycle.TabIndex = 12;
            this.txtCycle.Text = "20";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(177, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "SEC";
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labCount.Location = new System.Drawing.Point(177, 117);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(18, 12);
            this.labCount.TabIndex = 14;
            this.labCount.Text = "회";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(26, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "반복 설정";
            // 
            // txtStartCycle
            // 
            this.txtStartCycle.Location = new System.Drawing.Point(94, 168);
            this.txtStartCycle.Name = "txtStartCycle";
            this.txtStartCycle.Size = new System.Drawing.Size(27, 21);
            this.txtStartCycle.TabIndex = 16;
            this.txtStartCycle.Text = "1";
            // 
            // txtEndCycle
            // 
            this.txtEndCycle.Location = new System.Drawing.Point(140, 168);
            this.txtEndCycle.Name = "txtEndCycle";
            this.txtEndCycle.Size = new System.Drawing.Size(31, 21);
            this.txtEndCycle.TabIndex = 17;
            this.txtEndCycle.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(177, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "SEC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(124, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "~";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 336);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEndCycle);
            this.Controls.Add(this.txtStartCycle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCycle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butStop);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butStart);
            this.Controls.Add(this.butGetMouse);
            this.Controls.Add(this.txtRepeat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtYPoint);
            this.Controls.Add(this.txtXPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXPoint;
        private System.Windows.Forms.TextBox txtYPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRepeat;
        private System.Windows.Forms.Button butGetMouse;
        private System.Windows.Forms.Button butStart;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.Button butStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCycle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStartCycle;
        private System.Windows.Forms.TextBox txtEndCycle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

