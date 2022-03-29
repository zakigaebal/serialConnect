using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serialConnect
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonserialPort_Click(object sender, EventArgs e)
		{
			// 1. SerialPort 클래스 객체 생성  (COM5 포트를 사용)
			SerialPort sp = new SerialPort("COM5");

			// 2. 시리얼포트 오픈
			sp.Open();

			// 3. 시리얼포트에서 한 라인 읽기
			string data = sp.ReadLine();

			Console.WriteLine(data);

			// 4. 시리얼포트 닫기
			sp.Close();

			Console.WriteLine("Press Enter to Quit");
			Console.ReadLine();
		}

		private void buttonSerialWrite_Click(object sender, EventArgs e)
		{
			// 1. SerialPort 클래스 객체 생성  (COM6 포트를 사용)
			SerialPort sp = new SerialPort("COM6");

			// 2. SerialPort 포트 셋팅 설정
			sp.PortName = "COM6";
			sp.BaudRate = 9600;
			sp.DataBits = 8;
			sp.Parity = Parity.None;
			sp.StopBits = StopBits.One;


			// 2. 시리얼포트 오픈
			sp.Open();

			// 3. 시리얼포트에서 한 라인 쓰기
			sp.WriteLine("Hello World");

			// 4. 시리얼포트 닫기
			sp.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
		
			string portName = "COM6";

			// 시리얼포트 열기
			SerialPort sp = new SerialPort(portName);
			sp.Open();

			// 읽기 작업쓰레드: Read from serial port
			var cancel = new CancellationTokenSource();
			var readTask = Task.Factory.StartNew(() =>
			{
				while (!cancel.IsCancellationRequested)
				{
					string readMsg = sp.ReadLine();
					if (readMsg.ToLower() == "quit")
					{
						Environment.Exit(0);
					}
					Console.WriteLine(readMsg);
				}
			}, cancel.Token);

			// 메인쓰레드: Write to serial port
			while (true)
			{
				string sendMsg = Console.ReadLine();
				if (sendMsg.ToLower() == "quit")
				{
					sp.WriteLine(sendMsg);
					cancel.Cancel();
					break;
				}

				sp.WriteLine(sendMsg);
			}

			// 시리얼포트 닫기
			sp.Close();
		}
	}
}
