using com.codename1.payment;
using java.lang;
using Microsoft.Graphics.Canvas;
using Microsoft.Graphics.Canvas.UI.Xaml;
using System;
using System.Collections.Generic;
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

        private string productId;
        private string name;
        private IEnumerable<string> keywords;
        private string formattedPrice;
        private ProductType productType;
        private string description;
        private string Tag;
        CanvasControl screen;
        private CanvasBitmap image;

        public WindowsPurchase(CanvasControl _screen)
        {
            screen = _screen;
            LoadInAppPurchaseProxyFileAsync().AsAsyncAction().AsTask();
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

        private async Task LoadInAppPurchaseProxyFileAsync()
        {

            CurrentApp.LicenseInformation.LicenseChanged += licenseChangeHandler;

            try
            {
                ListingInformation listing = await CurrentApp.LoadListingInformationAsync();
                var product1 = listing.ProductListings["product1"];
                image = await CanvasBitmap.LoadAsync(screen, new Uri(product1.ImageUri.OriginalString, UriKind.RelativeOrAbsolute));
                name = product1.Name;
                productId = product1.ProductId;
                keywords = product1.Keywords;
                formattedPrice = product1.FormattedPrice;
                productType = product1.ProductType;
                description = product1.Description;
                Tag = product1.Tag;
                // var product2 = listing.ProductListings["product2"];

            }
            catch (System.Exception)
            {
            }

            // recover any unfulfilled consumables
            //try
            //{
            //    IReadOnlyList<UnfulfilledConsumable> products = await CurrentApp.GetUnfulfilledConsumablesAsync();
            //    foreach (UnfulfilledConsumable product in products)
            //    {
            //        if (product.ProductId == "product1")
            //        {
            //            product1TempTransactionId = product.TransactionId;
            //        }
            //    }
            //}
            //catch (Exception)
            //{

            //}
        }

        public override object pay(double n1, java.lang.String n2)
        {
            return base.pay(n1, n2);
        }

        private async void BuyStoreProdut(object sender, RoutedEventArgs e)
        {
            try
            {
                PurchaseResults purchaseResults = await CurrentApp.RequestProductPurchaseAsync("product1");
                switch (purchaseResults.Status)
                {
                    case ProductPurchaseStatus.Succeeded:
                        product1TempTransactionId = purchaseResults.TransactionId;
                        // Normally you would grant the user their content here, and then call currentApp.reportConsumableFulfillment
                        break;
                    case ProductPurchaseStatus.NotFulfilled:
                        product1TempTransactionId = purchaseResults.TransactionId;
                        // Normally you would grant the user their content here, and then call currentApp.reportConsumableFulfillment
                        break;
                    case ProductPurchaseStatus.NotPurchased:
                        break;
                }
            }
            catch (System.Exception)
            {

            }
        }

        public override void purchase(java.lang.String n1)
        {
            base.purchase(n1);
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