using Encoding = System.Text.Encoding;

namespace Unsaf {
	public static class Bit {
		public static byte ReadByte(byte[] bytes, ref int i) {
			byte v = bytes[i]; 
			i += 1;
			return v;
		}

		public static ushort ReadUInt16(byte[] bytes, ref int i) {
			ushort v = (ushort)(bytes[i + 1] << 8 | bytes[i]); 
			i += 2;
			return v;
		}

		public static short ReadInt16(byte[] bytes, ref int i) {
			short v = (short)((sbyte)bytes[i + 1] << 8 | bytes[i]); 
			i += 2;
			return v;
		}

		public static uint ReadUInt32(byte[] bytes, ref int i) {
			uint v = (uint)(bytes[i + 3] << 24 | bytes[i + 2] << 16 | bytes[i + 1] << 8 | bytes[i]); 
			i += 4;
			return v;
		}

		public static int ReadInt32(byte[] bytes, ref int i) {
			int v = (int)((sbyte)bytes[i + 3] << 24 | bytes[i + 2] << 16 | bytes[i + 1] << 8 | bytes[i]); 
			i += 4;
			return v;
		}

		public static string ReadStringAscii(byte[] bytes, ref int i, int count) {
			string v = Encoding.ASCII.GetString(bytes, i, count);
			i += count;
			return v;
		}

		public static string ReadStringUtf8(byte[] bytes, ref int i, int count) {
			string v = Encoding.UTF8.GetString(bytes, i, count);
			i += count;
			return v;
		}
	}
}

