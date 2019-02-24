namespace Unsaf {
	public unsafe static class Fdb {
		public static void Log(string fmt, params object[] args) {
			#if UNITY_EDITOR
			UnityEngine.Debug.Log(string.Format("Fdb: " + fmt, args));
			#endif
		}

		public static string Dump(void *ptr, int size, int ncol = 16) {
			#if UNITY_EDITOR
			byte *chr = (byte *)ptr;
			var sb = new System.Text.StringBuilder();
			sb.AppendFormat("{0} bytes at 0x{1:X}\n", size, (long)chr);
			for (int i = 0; i < size; i += 1) {
				if (i % ncol == 0) sb.AppendFormat("{0:X8}: ", (long)chr);
				sb.AppendFormat("{0:X2}", *chr++);				
				if ((i + 1) % 4 == 0) sb.Append(" ");
				if ((i + 1) % ncol == 0) sb.AppendFormat(" +{0:X} ({0})\n", i + 1);
			}
			string str = sb.ToString();
			Log(str);
			return str;
			#endif
		}
	}
}

