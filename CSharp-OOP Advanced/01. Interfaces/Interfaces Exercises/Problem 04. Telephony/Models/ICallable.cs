using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04.Telephony.Models
{
	interface ICallable
	{
		string Call(string number);
	}
}
