// Automatically generated by xmlvm2csharp (do not edit).

using org.xmlvm;
namespace org.xmlvm.runtime
{
    public class Mutex : global::java.lang.Object
    {

        static Mutex()
        {
            @static();
        }

        private static global::java.util.Queue _ffinalizableNativeMutexList;

        private global::java.lang.Object _fnativeMutex;

        private static void addNativeMutexToFinalizerQueue(global::java.lang.Object n1)
        {
            //XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.Mutex: void addNativeMutexToFinalizerQueue(java.lang.Object)]
            global::org.xmlvm._nElement _r0;
            _r0.i = 0;
            _r0.l = 0;
            _r0.f = 0;
            _r0.d = 0;
            global::System.Object _r0_o = null;
            global::org.xmlvm._nElement _r1;
            _r1.i = 0;
            _r1.l = 0;
            _r1.f = 0;
            _r1.d = 0;
            global::System.Object _r1_o = null;
            _r1_o = n1;
            _r0_o = global::org.xmlvm.runtime.Mutex._ffinalizableNativeMutexList;
            ((global::java.util.Queue)_r0_o).add((global::java.lang.Object)_r1_o);
            return;
            //XMLVM_END_WRAPPER[org.xmlvm.runtime.Mutex: void addNativeMutexToFinalizerQueue(java.lang.Object)]
        }

        public static void destroyFinalizableNativeMutexes()
        {
            //XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.Mutex: void destroyFinalizableNativeMutexes()]
            global::org.xmlvm._nElement _r0;
            _r0.i = 0;
            _r0.l = 0;
            _r0.f = 0;
            _r0.d = 0;
            global::System.Object _r0_o = null;
            global::org.xmlvm._nElement _r1;
            _r1.i = 0;
            _r1.l = 0;
            _r1.f = 0;
            _r1.d = 0;
            global::System.Object _r1_o = null;
            _r0_o = null;
        label1: ;
            _r1_o = global::org.xmlvm.runtime.Mutex._ffinalizableNativeMutexList;
            _r0_o = ((global::java.util.Queue)_r1_o).poll();
            if (_r0_o == null) goto label13;
            global::org.xmlvm.runtime.Mutex.destroyNativeMutex((global::java.lang.Object)_r0_o);
            goto label1;
        label13: ;
            return;
            //XMLVM_END_WRAPPER[org.xmlvm.runtime.Mutex: void destroyFinalizableNativeMutexes()]
        }

        private static void destroyNativeMutex(global::java.lang.Object n1)
        {
            //XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.Mutex: void destroyNativeMutex(java.lang.Object)]
            throw new global::org.xmlvm._nNotYetImplementedException("native/wrapper method not yet implemented");
            //XMLVM_END_WRAPPER[org.xmlvm.runtime.Mutex: void destroyNativeMutex(java.lang.Object)]
        }

        public void @this()
        {
            //XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.Mutex: void <init>()]
            global::org.xmlvm._nElement _r0;
            _r0.i = 0;
            _r0.l = 0;
            _r0.f = 0;
            _r0.d = 0;
            global::System.Object _r0_o = null;
            _r0_o = this;
            ((global::java.lang.Object)_r0_o).@this();
            ((global::org.xmlvm.runtime.Mutex)_r0_o).initNativeInstance();
            return;
            //XMLVM_END_WRAPPER[org.xmlvm.runtime.Mutex: void <init>()]
        }

        private void initNativeInstance()
        {
            //XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.Mutex: void initNativeInstance()]
            // initializing a dummy object on which we monitor
            this._fnativeMutex = new java.lang.Object();
            this._fnativeMutex.@this();
            //XMLVM_END_WRAPPER[org.xmlvm.runtime.Mutex: void initNativeInstance()]
        }

        public virtual void @lock()
        {
            //XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.Mutex: void lock()]
            global::System.Threading.Monitor.Enter(this._fnativeMutex);
            //XMLVM_END_WRAPPER[org.xmlvm.runtime.Mutex: void lock()]
        }

        public virtual void unlock()
        {
            //XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.Mutex: void unlock()]
            global::System.Threading.Monitor.Exit(this._fnativeMutex);
            //XMLVM_END_WRAPPER[org.xmlvm.runtime.Mutex: void unlock()]
        }

        public static void @static()
        {
            //XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.Mutex: void <clinit>()]
            global::org.xmlvm._nElement _r0;
            _r0.i = 0;
            _r0.l = 0;
            _r0.f = 0;
            _r0.d = 0;
            global::System.Object _r0_o = null;
            _r0_o = new global::java.util.LinkedList();
            ((global::java.util.LinkedList)_r0_o).@this();
            global::org.xmlvm.runtime.Mutex._ffinalizableNativeMutexList = (global::java.util.Queue)_r0_o;
            return;
            //XMLVM_END_WRAPPER[org.xmlvm.runtime.Mutex: void <clinit>()]
        }

        //XMLVM_BEGIN_WRAPPER[org.xmlvm.runtime.Mutex]
        //XMLVM_END_WRAPPER[org.xmlvm.runtime.Mutex]

    } // end of class: Mutex

} // end of namespace: org.xmlvm.runtime
