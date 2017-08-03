using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.Card_Suit
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Enum, AllowMultiple = true)]
	class TypeAttribute : Attribute
	{
		public TypeAttribute(string type, string category, string description)
		{
			this.Type = type;
			this.Category = category;
			this.Description = description;
		}

		public string Type { get; private set; }

		public string Category { get; private set; }

		public string Description { get; private set; }
	}
}
