namespace Unsaf {
	public unsafe struct Buf {
		const int InitLength = 32;

		public int length;
		public int end;
		public byte *data;

		public static void Init(Buf *self) {
			self->length = InitLength;
			self->end = 0;
			self->data = (byte *)Mem.Malloc(InitLength);
		}

		public static void *Alloc(Buf *self, int n) {
			int loc = self->end;
			self->end += n;
			if (self->end > self->length) {
				if (self->end < self->length << 1) {
					self->length <<= 1;
				} else {
					self->length = self->end;
				}
				self->data = (byte *)Mem.Realloc(self->data, self->length);
			}
			return self->data + loc;
		}

		public static void *Trim(Buf *self) {
			if (self->length > self->end) {
				self->length = self->end;
				self->data = (byte *)Mem.Realloc(self->data, self->length);
			}
			return self->data;
		}
	}
}