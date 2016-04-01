using System;
using System.IO;

namespace com.codename1.impl
{
    class InputStreamProxy : java.io.InputStream
    {
        private Stream internalStream;
        private long markedPosition = 0;

        public InputStreamProxy(Stream internalStream)
        {
            base.@this();
            this.internalStream = internalStream;
        }

        public override int available()
        {
            return 0;
        }

        public override void close()
        {
            internalStream.Dispose();
        }

        public override bool markSupported()
        {
            return internalStream.CanSeek;
        }

        public override void mark(int readlimit)
        {
            markedPosition = internalStream.Position;
        }

        public override int read()
        {
            return internalStream.ReadByte();
        }

        public override int read(global::org.xmlvm._nArrayAdapter<sbyte> n1)
        {
            return read(n1, 0, n1.Length);

        }

        public override int read(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3)
        {
            sbyte[] sb = n1.getCSharpArray();
            int v = internalStream.Read((byte[])(Array)sb, n2, n3);
            if (v <= 0)
            {
                return -1;
            }
            return v;
        }

        public override void reset()
        {
            internalStream.Seek(markedPosition, SeekOrigin.Begin);
        }

        public override long skip(long n)
        {
            internalStream.Seek(n, SeekOrigin.Current);
            return n;
        }
    }
}
