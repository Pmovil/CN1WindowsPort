using com.codename1.impl;
using com.codename1.ui;
using Facebook.Client;
using Facebook.Client.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.codename1.social
{
    class FacebookImpl : FacebookConnect
    {
        public static FacebookImpl instance;
        public static java.lang.Class implClass;
        Facebook.Client.Controls.LoginButton loginFace;
 
        

        public override bool isFacebookSDKSupported()
        {
            return true;
        }
        
 
        public override void login()
        {
            SilverlightImplementation.dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                loginFace = new LoginButton();
                loginFace.RequestNewPermissions("publish_actions");
                Session.ActiveSession.LoginWithBehavior("email,public_profile,user_friends", FacebookLoginBehavior.LoginBehaviorAppwithMobileInternetFallback);
                SessionStateChangedEventArgs e = new SessionStateChangedEventArgs(FacebookSessionState.Opened);
                loginFace.SessionStateChanged += loginButton_SessionStateChanged;
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();

        }

        void loginButton_SessionStateChanged(object sender, SessionStateChangedEventArgs e)
        {
            if (e.SessionState == FacebookSessionState.Opened)
            {

            }
        }

        public override void askPublishPermissions(LoginCallback n1)
        {
            base.askPublishPermissions(n1);
        }

        public override object getToken()
        {
            java.lang.String t = SilverlightImplementation.toJava(Session.ActiveSession.CurrentAccessTokenData.AccessToken);
            if (t != null)
            {
                return t;
            }
            return null;
        }

        public override bool hasPublishPermissions()
        {

            return true;
        }
       
        public override bool isLoggedIn()
        {
           
                var token = Session.ActiveSession.CurrentAccessTokenData.AccessToken;
                var date = DateTime.Today;
                if (token != "")
                {
                    if (date.Date <= Session.ActiveSession.CurrentAccessTokenData.Expires.Date)
                    {
                        return true;
                    }

                }
                return false;
        }

        public override void setCallback(LoginCallback n1)
        {

            base.setCallback(n1);
        }
        public override void logout()
        {
            Session.ActiveSession.Logout();
        }
    }
}
