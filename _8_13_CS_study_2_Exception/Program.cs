using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_13_CS_study_2_Exception
{
	//예외처리
	internal class Program
	{
		class TestException : Exception
		{

		}
		static void Main(string[] args)
		{
			try
			{
				// 1. 0으로 나눌 때
				// 2. 잘못된 메모리를 참조(null)
				// 3. 오버플로우

				throw new TestException();
			}
			catch (DivideByZeroException e)
			{

			}
			catch (Exception e)
			{

			}
			finally
			{
				// DB, 파일 정리 등등
			}
		}
	}
}
