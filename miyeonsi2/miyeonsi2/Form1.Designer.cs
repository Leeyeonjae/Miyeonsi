namespace miyeonsi2
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
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.lSubscript = new System.Windows.Forms.Label();
            this.bChoice1 = new System.Windows.Forms.Button();
            this.bChoice2 = new System.Windows.Forms.Button();
            this.bChoice3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lSubscript
            // 
            this.lSubscript.AutoSize = true;
            this.lSubscript.Location = new System.Drawing.Point(21, 28);
            this.lSubscript.Name = "lSubscript";
            this.lSubscript.Size = new System.Drawing.Size(38, 12);
            this.lSubscript.TabIndex = 0;
            this.lSubscript.Text = "label1";
            this.lSubscript.Click += new System.EventHandler(this.lSubscript_Click);
            // 
            // bChoice1
            // 
            this.bChoice1.Location = new System.Drawing.Point(13, 79);
            this.bChoice1.Name = "bChoice1";
            this.bChoice1.Size = new System.Drawing.Size(250, 23);
            this.bChoice1.TabIndex = 1;
            this.bChoice1.Text = "button1";
            this.bChoice1.UseVisualStyleBackColor = true;
            this.bChoice1.Click += new System.EventHandler(this.bChoice1_Click);
            // 
            // bChoice2
            // 
            this.bChoice2.Location = new System.Drawing.Point(12, 108);
            this.bChoice2.Name = "bChoice2";
            this.bChoice2.Size = new System.Drawing.Size(251, 23);
            this.bChoice2.TabIndex = 2;
            this.bChoice2.Text = "button2";
            this.bChoice2.UseVisualStyleBackColor = true;
            this.bChoice2.Click += new System.EventHandler(this.bChoice2_Click);
            // 
            // bChoice3
            // 
            this.bChoice3.Location = new System.Drawing.Point(12, 137);
            this.bChoice3.Name = "bChoice3";
            this.bChoice3.Size = new System.Drawing.Size(251, 23);
            this.bChoice3.TabIndex = 3;
            this.bChoice3.Text = "button3";
            this.bChoice3.UseVisualStyleBackColor = true;
            this.bChoice3.Click += new System.EventHandler(this.bChoice3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bChoice3);
            this.Controls.Add(this.bChoice2);
            this.Controls.Add(this.bChoice1);
            this.Controls.Add(this.lSubscript);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lSubscript;
        private System.Windows.Forms.Button bChoice1;
        private System.Windows.Forms.Button bChoice2;
        private System.Windows.Forms.Button bChoice3;
        private System.Windows.Forms.Label label1;
    }
}

