using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.codename1.impl
{
    public class WindowsPurchase : com.codename1.payment.Purchase
    {
    
        public override bool isManagedPaymentSupported()
        {
            return base.isManagedPaymentSupported();
        }
        public override bool wasPurchased(java.lang.String n1)
        {
            return base.wasPurchased(n1);
        }
        public override object getProducts(org.xmlvm._nArrayAdapter<object> n1)
        {
            return base.getProducts(n1);
        }
    }
}