namespace serialConnect
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
			this.buttonserialRead = new System.Windows.Forms.Button();
			this.buttonSerialWrite = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonserialRead
			// 
			this.buttonserialRead.Location = new System.Drawing.Point(12, 12);
			this.buttonserialRead.Name = "buttonserialRead";
			this.buttonserialRead.Size = new System.Drawing.Size(174, 53);
			this.buttonserialRead.TabIndex = 0;
			this.buttonserialRead.Text = "serialPort 읽기";
			this.buttonserialRead.UseVisualStyleBackColor = true;
			this.buttonserialRead.Click += new System.EventHandler(this.buttonserialPort_Click);
			// 
			// buttonSerialWrite
			// 
			this.buttonSerialWrite.Location = new System.Drawing.Point(206, 12);
			this.buttonSerialWrite.Name = "buttonSerialWrite";
			this.buttonSerialWrite.Size = new System.Drawing.Size(174, 53);
			this.buttonSerialWrite.TabIndex = 1;
			this.buttonSerialWrite.Text = "serialPort 쓰기";
			this.buttonSerialWrite.UseVisualStyleBackColor = true;
			this.buttonSerialWrite.Click += new System.EventHandler(this.buttonSerialWrite_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 86);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(173, 47);
			this.button1.TabIndex = 2;
			this.button1.Text = "시리얼포트 비동기처리";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonSerialWrite);
			this.Controls.Add(this.buttonserialRead);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonserialRead;
		private System.Windows.Forms.Button buttonSerialWrite;
		private System.Windows.Forms.Button button1;
	}
}

