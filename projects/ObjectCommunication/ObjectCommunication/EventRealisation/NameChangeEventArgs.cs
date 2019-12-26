using System;
using System.Collections.Generic;
using System.Text;

namespace EventRealisation
{
    public class NameChangeEventArgs : EventArgs
    {
		private string name;

		public NameChangeEventArgs(string name)
		{
			Name = name;
		}

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}

	}
}
