﻿
using System;
using System.Collections.Generic;

namespace CartoMobileSample
{
	public static class CommonExtensions
	{
		public static string[] ToStringArray(this List<Type> list)
		{
			string[] sampleNames = new string[list.Count];

			for (int i = 0; i < list.Count; i++)
			{
				sampleNames[i] = list[i].Name;
			}

			return sampleNames;
		}

		public static long ToLong(this ulong ulongValue)
		{
			return (long)ulongValue;
		}

		public static double To4Decimals(this double original)
		{
			return Math.Round(original, 4);	
		}

		public static string ConvertFromSecondsToHours(this double sec)
		{
			int hours = ((int)sec) / 3600,

			remainder = ((int)sec) % 3600,
			minutes = remainder / 60,
			seconds = remainder % 60;

			return ((hours < 10 ? "0" : "") + hours
				+ "h" + (minutes < 10 ? "0" : "") + minutes
				+ "m" + (seconds < 10 ? "0" : "") + seconds + "s");
		}

		public static long ToUnixTime(this DateTime date)
		{
			var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			return Convert.ToInt64((date.ToUniversalTime() - epoch).TotalSeconds);
		}
	}
}

