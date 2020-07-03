using System;
using System.Collections.Generic;
using System.Text;

namespace exSharp {
	public static class NumberOperations {
		public static double Absolute(this double x) => Math.Abs(x);

		public static TimeSpan AsHoursSpan(this double x) => TimeSpan.FromHours(x);

		public static TimeSpan AsDaysSpan(this double x) => TimeSpan.FromDays(x);

		public static TimeSpan AsMinutesSpan(this double x) => TimeSpan.FromMinutes(x);
	}
}
