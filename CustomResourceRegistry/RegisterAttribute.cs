using System;

namespace Godot
{
	[AttributeUsage(System.AttributeTargets.Class)]
	public class RegisterAttribute : System.Attribute
	{
		public string name;
        public string baseType;
        public string iconPath;

		public RegisterAttribute(string name, string baseType = "", string iconPath = "")
		{
			this.name = name;
            this.baseType = baseType;
            this.iconPath = iconPath;
		}
	}
}