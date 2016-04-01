﻿using com.codename1.facebook;
using com.codename1.impl;
using com.codename1.io;
using com.codename1.ui;
using com.codename1.util;
using java.lang;
using java.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Facebook;
using Windows.Security.Authentication.Web;
using System.Xml.Linq;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.Activation;


namespace com.codename1.social
{

    public class FacebookImpl : FacebookConnect
    {
        private static java.lang.String PREF_TOKEN = SilverlightImplementation.toJava("$CN1_FB_TOKEN");
        private static java.lang.String PREF_EXPIRES = SilverlightImplementation.toJava("$CN1_FB_EXPIRES");
        private FacebookClient fb = new FacebookClient();
        private static string appId = "";
        private static string redirectUrl = "";
        private string permissions = "";
        private CoreApplicationView view;
        private static bool configLoaded = false;

        public void @this()
        {
            
        }

        public override bool isFacebookSDKSupported()
        {

            try
            {
                if (!configLoaded)
                {
                    XDocument doc = XDocument.Load(@"FacebookConfig.xml");
                    foreach (XElement facebookElement in doc.Descendants().Elements("Facebook"))
                    {
                        appId = facebookElement.Attribute("AppId").Value;
                        redirectUrl = facebookElement.Attribute("RedirectUrl").Value;
                        permissions = facebookElement.Attribute("Permissions").Value;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch (System.Exception)
            {
                return false;
            }
            if (appId != "" && redirectUrl != "" && permissions != "")
            {
                configLoaded = true;
                return true;
            }
            return false;
        }

        public override void login()
        {
            loginFacebook();
        }

        private void loginFacebook()
        {
            SilverlightImplementation.dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, async () =>
            {
                Uri loginUrl = fb.GetLoginUrl(new
                {
                    client_id = appId,
                    redirect_uri = redirectUrl,
                    response_type = "token",
                    scope = permissions
                });
                Uri startUri = loginUrl;
                Uri endUri = new Uri(redirectUrl, UriKind.Absolute);
                view = CoreApplication.GetCurrentView();
#if WINDOWS_PHONE_APP
                WebAuthenticationBroker.AuthenticateAndContinue(startUri, endUri, null, WebAuthenticationOptions.None);
                view.Activated += view_Activated;
#else
                WebAuthenticationResult WebAuRes = await WebAuthenticationBroker.AuthenticateAsync(WebAuthenticationOptions.None, startUri, endUri);
                ParseAuthenticationResult(WebAuRes);
#endif
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();
        }
#if WINDOWS_PHONE_APP
        void view_Activated(CoreApplicationView sender, IActivatedEventArgs args)
        {
            if (args.Kind == ActivationKind.WebAuthenticationBrokerContinuation)
            {
                var continuationEventArgs = args as WebAuthenticationBrokerContinuationEventArgs;
                if (continuationEventArgs.WebAuthenticationResult != null)
                {
                    ParseAuthenticationResult(continuationEventArgs.WebAuthenticationResult);
                }
            }
        }
#endif
        public void ParseAuthenticationResult(WebAuthenticationResult result)
        {
            switch (result.ResponseStatus)
            {
                //connection error
                case WebAuthenticationStatus.ErrorHttp:
                    _fcallback.loginFailed(SilverlightImplementation.toJava("Failed to connect."));
                    break;
                //authentication successfull
                case WebAuthenticationStatus.Success:
                    var oAuthResult = fb.ParseOAuthCallbackUrl(new Uri(result.ResponseData));
                    com.codename1.io.Preferences.set(PREF_TOKEN, SilverlightImplementation.toJava(oAuthResult.AccessToken));
                    com.codename1.io.Preferences.set(PREF_EXPIRES, oAuthResult.Expires.Ticks);
                    _fcallback.loginSuccessful();
                    break;
                //operation aborted by the user
                case WebAuthenticationStatus.UserCancel:
                    _fcallback.loginFailed(SilverlightImplementation.toJava("Operation aborted"));
                    break;
                default:
                    break;
            }

        }

        public override void askPublishPermissions(LoginCallback lc)
        {
         
            if (!isLoggedIn())
            {
                _fcallback.loginSuccessful();
                login();
                return;
            }
            askPublishPermissions(lc);
        }

        public override object getAccessToken()
        {
            java.lang.String fbToken = (java.lang.String)com.codename1.io.Preferences.get(PREF_TOKEN, (java.lang.String)null);

            AccessToken token1 = new AccessToken();
            if (fbToken != null)
            {
                long expires = com.codename1.io.Preferences.get(PREF_EXPIRES, 0L) / 1000;
                java.lang.String diffstring = SilverlightImplementation.toJava(expires.ToString());
                ((AccessToken)token1).@this(fbToken, diffstring);
                return token1;
            }
            return null;
        }
        public override object getToken()
        {
            AccessToken t = (AccessToken)getAccessToken();
            if (t != null)
            {
                return t.getToken();
            }
            return null;
        }

        public override bool hasPublishPermissions()
        {
            // TODO
            return isLoggedIn();
        }

        public override bool isLoggedIn()
        {
            AccessToken fbToken = (AccessToken)getAccessToken();
            if (fbToken == null)
            {
                return false;
            }
            string token = SilverlightImplementation.toCSharp((java.lang.String)fbToken.getToken());         
            if (token != null && !"".Equals(token))
            {
                long expires = Convert.ToInt64(SilverlightImplementation.toCSharp((java.lang.String)fbToken.getExpires()));
                if (DateTime.Now.Ticks/1000 <= expires)
                {
                    return true;
                }
            }
            return false;
        }

        public override void logout()
        {
            com.codename1.io.Preferences.delete(PREF_TOKEN);
        }
    }
}
