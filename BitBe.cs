namespace Unsaf {
	public static class BitBe {
		public static short ReadInt16(byte[] bytes, ref int i) {
			short v = (short)((sbyte)bytes[i] << 8 | bytes[i + 1]); 
			i += 2;
			return v;
		}

		public static int ReadInt24(byte[] bytes, ref int i) {
			int v = (int)((sbyte)bytes[i] << 16 | bytes[i + 1] << 8 | bytes[i + 2]); 
			i += 3;
			return v;
		}

		public static int ReadInt32(byte[] bytes, ref int i) {
			int v = (int)((sbyte)bytes[i] << 24 | bytes[i + 1] << 16 | bytes[i + 2] << 8 | bytes[i + 3]); 
			i += 4;
			return v;
		}

		public static int ReadVlv(byte[] bytes, ref int i) {
			int v = 0;
			byte b;
			do {
				b = bytes[i];
				i += 1;
				v = (v << 7) | (b & 0x7F);
			} while ((b & 0x80) != 0) ;
			return v;
		}
	}
}

