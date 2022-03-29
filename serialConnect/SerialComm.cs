using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Collections;
namespace serialConnect
{
	class SerialComm
	{
		public ArrayList arrSerialbuff = new ArrayList(); // 수신용 List 버퍼 선언 
		private SerialPort sp = new SerialPort();// 시리얼 포트 선언
																						 //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
																						 //        Comport 열기        
																						 //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH
		public string Comport_Open(string port, string baud, string databits, string parity, string stop)
		{
			try
			{
				// 시리얼 통신 포트, 보레이트, 데이터 비트, 패리티, 스톱 비트를 설정         
				sp.PortName = port;
				sp.BaudRate = int.Parse(baud);
				sp.DataBits = int.Parse(databits);
				sp.Parity = (Parity)Enum.Parse(typeof(Parity), parity);
				sp.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stop);
				// 이미 오픈상태인지 체크하여 아니라면 
				if (!sp.IsOpen)
				{
					// 포트 열기
					sp.Open();
				}
				// 포트가 열린 상태이면 연결 완료      
				if (sp.IsOpen)
				{
					return "연결완료";
				}
				else  // 포트열기가 열린상태가 아니라면 연결 실패   
				{
					return "연결실패";
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		//HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH       

		//      수신 처리          //HHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH

		public void RcvSerialComm()

		{
			try

			{

				// 포트가 열린 상태인지 체크      

				if (sp.IsOpen)

				{

					// 시리얼 수신 버퍼에 적재된 byte 개수를 읽어 온다.        

					int nbyte = sp.BytesToRead;

					// 시리얼 byte개수 만큼 버퍼를 생성한다.

					byte[] rbuff = new byte[nbyte];

					// byte개수가 0보다 크다면





					if (nbyte > 0)

					{

						//  수신버퍼에서 버퍼의 지정된 인덱스 부터 개수 만큼 읽어 온다.   

						sp.Read(rbuff, 0, nbyte);

					}

					// ArrayList에 적재한다.     

					for (int i = 0; i < nbyte; i++)

					{

						arrSerialbuff.Add(rbuff[i]);

					}

				}

			}

			catch (Exception ex)

			{

				// 수신에러 발생시      

				// ArrayList를 클리어한다.         

				arrSerialbuff.Clear();

				//예외를 던지고 종료     

				throw ex;

			}

		}
	}
}