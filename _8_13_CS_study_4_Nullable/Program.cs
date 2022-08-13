using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Nullable -> Null + able
namespace _8_13_CS_study_4_Nullable
{
	internal class Program
	{
		static int Find()
		{

			return 0;
		}
		class Monster
		{
			public int Id { get; set; }
		}
		static void Main(string[] args)
		{

			Monster monster = null;

			int? id = monster?.Id;
									//위는 아래와 같다.
			if(monster ==null) { id = null; }
			else { id = monster.Id; }


			int? number = null;
			int b = number ?? 0;		//int b = (number != Null) ? number.Value : 0; 와 같다.(삼항연산자)
			Console.WriteLine(b);
		}
	}
}
