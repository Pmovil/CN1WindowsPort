using com.codename1.payment;
using java.lang;
using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.UI.Xaml;
using PumpopNati;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Imaging;

namespace com.codename1.impl
{
    public class WindowsPurchase : Purchase
    {
        public static LicenseChangedEventHandler licenseChangeHandler = null;
        private static Guid transactionId = Guid.Empty;
        private static CanvasControl screen;
        private int numberOfConsumablesPurchased = 0;
        private Dictionary<string, List<Guid>> grantedConsumableTransactionIds = new Dictionary<string, List<Guid>>();
        private static ProductListing product1;
        private static PurchaseCallback pc;
        private FulfillmentResult result;

        public WindowsPurchase(CanvasControl _screen)
        {
            screen = _screen;
            LoadInAppPurchaseConsumablesProxyFileAsync();
            grantedConsumableTransactionIds = new Dictionary<string, List<Guid>>();   
        }

        public override bool isManagedPaymentSupported()
        {
            return true;
        }

        public override bool wasPurchased(java.lang.String n1)
        {
            return base.wasPurchased(n1);
        }

        public override object getProducts(org.xmlvm._nArrayAdapter<object> n1)
        {
            return base.getProducts(n1);
        }
    
        public override object pay(double  amount, java.lang.String currency)
        {
            return base.pay(amount, currency);
        }
        private void LoadInAppPurchaseConsumablesProxyFileAsync()
        {
            CurrentApp.LicenseInformation.LicenseChanged += licenseChangeHandler;
            try
            {             
                ListingInformation listing = CurrentApp.LoadListingInformationAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                product1 = listing.ProductListings["501Ponts"];           
            }
            catch (System.Exception e)
            {
                Debug.WriteLine("LoadListingInformationAsync API call failed: " + e);
            }
        }
        public override void purchase(java.lang.String idProduct)
        {
            string produto = SilverlightImplementation.toCSharp(idProduct);
            Main main = new Main();
            pc = (PurchaseCallback)SilverlightImplementation.getPurchaseCallback();
            SilverlightImplementation.dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, async () =>
            {
                try
                {
                    PurchaseResults purchaseResults = await CurrentApp.RequestProductPurchaseAsync(product1.ProductId);
             
                    switch (purchaseResults.Status)
                    {
                        case ProductPurchaseStatus.Succeeded:
                            GrantFeatureLocally(product1.ProductId, purchaseResults.TransactionId);
                            FulfillProduct1(product1.ProductId, purchaseResults.TransactionId);
                            pc.itemPurchased(idProduct);
                            break;
                        case ProductPurchaseStatus.NotFulfilled:
                            if (!IsLocallyFulfilled(product1.ProductId, purchaseResults.TransactionId))
                            {
                                GrantFeatureLocally(product1.ProductId, purchaseResults.TransactionId);
                            }
                            FulfillProduct1(product1.ProductId, purchaseResults.TransactionId);
                            break;
                        case ProductPurchaseStatus.NotPurchased:                         
                            pc.itemPurchaseError(idProduct, SilverlightImplementation.toJava("purchase failed"));
                            break;
                    }
                }
                catch (System.Exception e)
                {
                    Debug.WriteLine("Houston, we have a problem: \n\n" + e + "\n\n");
                }
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        private void FulfillProduct1(string productId, Guid transactionId)
        {
            try
            {
                
                    result = CurrentApp.ReportConsumableFulfillmentAsync(productId, transactionId).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                switch (result)
                {
                    case FulfillmentResult.Succeeded:
                        Debug.WriteLine("You bought and fulfilled product 1.");
                        break;
                    case FulfillmentResult.NothingToFulfill:
                        Debug.WriteLine("There is no purchased product 1 to fulfill.");
                        break;
                    case FulfillmentResult.PurchasePending:
                        Debug.WriteLine("You bought product 1. The purchase is pending so we cannot fulfill the product.");
                        break;
                    case FulfillmentResult.PurchaseReverted:
                        Debug.WriteLine("You bought product 1. But your purchase has been reverted.");
                        // Since the user's purchase was revoked, they got their money back.
                        // You may want to revoke the user's access to the consumable content that was granted.
                        break;
                    case FulfillmentResult.ServerError:
                        Debug.WriteLine("You bought product 1. There was an error when fulfilling.");
                        break;
                }
            }
            catch (System.Exception e)
            {
                Debug.WriteLine("You bought Product 1. There was an error when fulfilling.  " + e);
            }
        }
      

        private void GrantFeatureLocally(string productId, Guid transactionId)
        {
            if (!grantedConsumableTransactionIds.ContainsKey(productId))
            {
                grantedConsumableTransactionIds.Add(productId, new List<Guid>());
            }
            grantedConsumableTransactionIds[productId].Add(transactionId);

            // Grant the user their content. You will likely increase some kind of gold/coins/some other asset count.
            numberOfConsumablesPurchased++;
        }

        private bool IsLocallyFulfilled(string productId, Guid transactionId)
        {
            return grantedConsumableTransactionIds.ContainsKey(productId) && grantedConsumableTransactionIds[productId].Contains(transactionId);
        }

        public override bool isSubscriptionSupported()
        {
            return true;
        }

        public override bool isUnsubscribeSupported()
        {
            return false;
        }

        public override bool isManualPaymentSupported()
        {
            return true;
        }

        public override bool isItemListingSupported()
        {
            return true;
        }

        public override void subscribe(java.lang.String n1)
        {
            base.subscribe(n1);
        }
    }
}