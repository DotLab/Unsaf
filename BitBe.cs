namespace Unsaf {
	[Unity.IL2CPP.CompilerServices.Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public static unsafe class BitBe {
		public static short ReadInt16(byte *bytes, int *i) {
			int j = *i;
			short v = (short)((sbyte)bytes[j] << 8 | bytes[j + 1]); 
			*i = j + 2;
			return v;
		}

		public static int ReadInt24(byte *bytes, int *i) {
			int j = *i;
			int v = (int)((sbyte)bytes[j] << 16 | bytes[j + 1] << 8 | bytes[j + 2]); 
			*i = j + 3;
			return v;
		}

		public static int ReadInt32(byte *bytes, int *i) {
			int j = *i;
			int v = (int)((sbyte)bytes[j] << 24 | bytes[j + 1] << 16 | bytes[j + 2] << 8 | bytes[j + 3]); 
			*i = j + 4;
			return v;
		}

		public static int ReadVlv(byte *bytes, int *i) {
			int v = 0;
			byte b;
			do {
				b = Bit.ReadByte(bytes, i);
				v = (v << 7) | (b & 0x7F);
			} while ((b & 0x80) != 0) ;
			return v;
		}
	}
}

