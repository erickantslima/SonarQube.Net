﻿using System.Collections.Generic;
using SonarQube.Net.Models;

namespace SonarQube.Net.Common.Converters
{
	public static class BooleanConverter
	{
		public static string ToString(bool? boolean)
		{
			return boolean == true ? "true" : "false";
		}
	}
}
