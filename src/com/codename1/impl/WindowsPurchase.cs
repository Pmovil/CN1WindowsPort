using com.codename1.payment;
using java.lang;
using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.UI.Xaml;
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
        private static Guid product1TempTransactionId = Guid.Empty;

        public static string productId;
        public static string name, name2;
        public static IEnumerable<string> keywords, keywords2;
        public static string formattedPrice, formattedPrice2;
        public static ProductType productType, productType2;
        public static string description, description2;
        public static string Tag, Tag2;
        CanvasControl screen;
        public static CanvasBitmap image, image2;
        public static string productId2;

        public WindowsPurchase(CanvasControl _screen)
        {
            screen = _screen;
            LoadInAppPurchaseProxyFileAsync();
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

        public void LoadInAppPurchaseProxyFileAsync()
        {

            CurrentApp.LicenseInformation.LicenseChanged += licenseChangeHandler;

            try
            {
                ListingInformation listing = CurrentApp.LoadListingInformationAsync().AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                var product1 = listing.ProductListings["product1"];
                image = CanvasBitmap.LoadAsync(screen, new Uri(product1.ImageUri.OriginalString, UriKind.RelativeOrAbsolute)).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                name = product1.Name;
                productId = product1.ProductId;
                keywords = product1.Keywords;
                formattedPrice = product1.FormattedPrice;
                productType = product1.ProductType;
                description = product1.Description;
                Tag = product1.Tag;
                var product2 = listing.ProductListings["product2"];
                image2 = CanvasBitmap.LoadAsync(screen, new Uri(product2.ImageUri.OriginalString, UriKind.RelativeOrAbsolute)).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
                name2 = product1.Name;
                productId2 = product2.ProductId;
                keywords2 = product2.Keywords;
                formattedPrice2 = product2.FormattedPrice;
                productType2 = product2.ProductType;
                description2 = product2.Description;
                Tag2 = product2.Tag;

            }
            catch (System.Exception)
            {
            }
        }

        public override object pay(double n1, java.lang.String n2)
        {
            return base.pay(n1, n2);
        }

        public override void purchase(java.lang.String n1)
        {
            string produto = SilverlightImplementation.toCSharp(n1);
            SilverlightImplementation.dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, async () =>
            {
                try
                {
                    PurchaseResults purchaseResults = await CurrentApp.RequestProductPurchaseAsync(produto);

                    switch (purchaseResults.Status)
                    {
                        case ProductPurchaseStatus.Succeeded:
                            product1TempTransactionId = purchaseResults.TransactionId;
                            Debug.WriteLine(SilverlightImplementation.toCSharp(n1) + " purchased ! Transaction id: " + purchaseResults.TransactionId);
                            ((com.codename1.payment.PurchaseCallback)SilverlightImplementation.getPurchaseCallback()).itemPurchased(n1);
                            // Normally you would grant the user their content here, and then call currentApp.reportConsumableFulfillment
                            break;
                        case ProductPurchaseStatus.NotFulfilled:
                            product1TempTransactionId = purchaseResults.TransactionId;
                            Debug.WriteLine(SilverlightImplementation.toCSharp(n1) + " purchase failed. Transaction id: " + purchaseResults.TransactionId);
                            ((com.codename1.payment.PurchaseCallback)SilverlightImplementation.getPurchaseCallback()).itemPurchaseError(n1, SilverlightImplementation.toJava(purchaseResults.Status.ToString()));
                            // Normally you would grant the user their content here, and then call currentApp.reportConsumableFulfillment
                            break;
                        case ProductPurchaseStatus.NotPurchased:
                            ((com.codename1.payment.PurchaseCallback)SilverlightImplementation.getPurchaseCallback()).itemPurchaseError(n1, SilverlightImplementation.toJava(purchaseResults.Status.ToString()));
                            Debug.WriteLine("Not purchased.");
                            break;
                    }
                }
                catch (System.Exception)
                {
                    Debug.WriteLine("Houston, we have a problem.");
                }
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
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