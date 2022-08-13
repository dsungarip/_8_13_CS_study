using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_13_CS_study_1_1
{
	class InputManager
	{
		/*	delegate와 event의 접근한정자는 동일해야 한다.	*/

		public delegate void OnInputKey();  //	매개변수&return이 없는 함수만 등록가능
		public event OnInputKey InputKey;   //	event의 타입 정의(OnInputKey)

		/*	event 정의 : 접근한정자 event delegate이름 event이름	*/
		public void Update()
		{
			if (Console.KeyAvailable==false)    //	사용자의 입력을 받는다. 입력이 없을경우 false
				return;

			ConsoleKeyInfo info = Console.ReadKey();    //	입력이 있을경우 입력된 값을 info에 저장
			if (info.Key == ConsoleKey.A)   //	입력이 'A'일 경우 문장을 실행한다.
			{
				InputKey(); //	Program class에서 OnInputTest 함수를 실행시킨다.
			}
		}
	}
}
