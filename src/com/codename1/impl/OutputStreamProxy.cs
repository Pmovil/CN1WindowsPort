using System;
using System.IO;

namespace com.codename1.impl
{
    class OutputStreamProxy : java.io.OutputStream
    {
        private Stream internalStream;
        public OutputStreamProxy(Stream internalStream)
        {
            base.@this();
            this.internalStream = internalStream;
        }

        public override void close()
        {
            if (internalStream == null)
            {
                return;
            }
            try
            {
                lock (internalStream)
                    internalStream.Dispose();
            }
            catch (Exception)
            {
                //internalStream = null;
            }
            internalStream = null;
        }

        public override void flush()
        {
            if (internalStream == null)
            {
                return;
            }
            try
            {
                lock (internalStream)
                    internalStream.Flush();
            }
            catch (Exception)
            {
                // internalStream = null;
            }
        }

        public override void write(global::org.xmlvm._nArrayAdapter<sbyte> n1)
        {
            write(n1, 0, n1.Length);
        }

        public override void write(global::org.xmlvm._nArrayAdapter<sbyte> n1, int n2, int n3)
        {
            if (internalStream != null)
                lock (internalStream)
                    internalStream.Write(SilverlightImplementation.toByteArray(n1.getCSharpArray()), n2, n3);
        }

        public override void write(int n1)
        {
            if (internalStream != null)
                lock (internalStream)
                    internalStream.WriteByte((byte)n1);

        }

    }
}
