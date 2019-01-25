using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGIS {
	public static class LICore {
		public static string[] LI_Line(double[] data) {
			for (int i = 0; i < data.Count(); i++) {
				Logger.log("X:" + data[i].ToString() +
					", Y:" + data[++i].ToString());
			}
			return null;
		}

		public static string[] LI_Circle(double[] data) {
			return null;
		}
	}
}
