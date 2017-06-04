using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
	class Startup
	{
		static void Main()
		{
			//IOManager.TraverseDirectory(@"C:\Users\Bogdan Alov\Documents\Visual Studio 2017");

			StudentsRepository.InitializeData();
			StudentsRepository.GetAllStudentsFromCourse("Unity");
			//StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");
		}
	}
}
