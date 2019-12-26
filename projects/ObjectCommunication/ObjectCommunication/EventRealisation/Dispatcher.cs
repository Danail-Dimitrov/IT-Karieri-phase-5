using System;
using System.Collections.Generic;
using System.Text;

namespace EventRealisation
{
	public delegate void NameChangeEventHandler(object source, NameChangeEventArgs args);

	public class Dispatcher
    {
		private string name;

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
				OnNameChange(new NameChangeEventArgs(name));
			}
		}

		public event NameChangeEventHandler NameChange;

		public void OnNameChange(NameChangeEventArgs args)
		{
			if(NameChange != null)
				NameChange(this, args);
		}
	}
}
