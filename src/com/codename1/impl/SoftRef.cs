using System;

namespace com.codename1.impl
{
    public class SoftRef : java.lang.Object
    {
        WeakReference w;

        public SoftRef(java.lang.Object obj)
        {
            w = new WeakReference(obj);
        }

        public java.lang.Object get()
        {
            java.lang.Object o = (java.lang.Object)w.Target;
            return o;
        }
    }
}
