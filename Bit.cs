namespace Unsaf {
	[Unity.IL2CPP.CompilerServices.Il2CppSetOption(Unity.IL2CPP.CompilerServices.Option.NullChecks, false)]
	public static unsafe class Bit {
		public static byte ReadByte(byte *bytes, int *i) {
			int j = *i;
			byte v = bytes[j]; 
			*i = j + 1;
			return v;
		}

		public static short ReadShort(byte *bytes, int *i) {
			int j = *i;
			short v = (short)((sbyte)bytes[j + 1] << 8 | bytes[j]); 
			*i = j + 2;
			return v;
		}

		public static int ReadInt(byte *bytes, int *i) {
			int j = *i;
			int v = (int)((sbyte)bytes[j + 3] << 24 | bytes[j + 2] << 16 | bytes[j + 1] << 8 | bytes[j]); 
			*i = j + 4;
			return v;
		}
	}
}

