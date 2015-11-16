using com.codename1.facebook;
using com.codename1.impl;
using com.codename1.io;
using com.codename1.ui;
using com.codename1.util;
using Facebook.Client;
using Facebook.Client.Controls;
using java.lang;
using java.util;
using PumpopNati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;

namespace com.codename1.social
{

    public  class FacebookImpl : FacebookConnect 
    {

        private LoginButton loginFace;     
        static Callback inviteCallback;
     
        public static bool loginLock = false;
        public static Facebook.FacebookClient fb;
        public static object result;
        public static GraphUser currentUser;
        private LoginCallback callback = null;
        private static java.lang.Class implClass;
        private object instance;

        public FacebookImpl()
            : base()
        {
            instance = typeof(FacebookImpl);
            instance = ((java.lang.Class)instance).newInstance();
            implClass = (java.lang.Class)instance;
             FacebookConnect._fimplClass = FacebookImpl.implClass;
        }
  
        public override bool isFacebookSDKSupported()
        {
            return true;
        }

        public override void login()
        {
            login(callback);
        }
    
        private void login(LoginCallback cb)
        {
            if (loginLock)
            {
                return;
            }
            loginLock = true;

            SilverlightImplementation.dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal, () =>
            {
                loginFace = new LoginButton();
               // loginFace.RequestNewPermissions("publish_actions");
                Session.ActiveSession.LoginWithBehavior("email,public_profile,user_friends", FacebookLoginBehavior.LoginBehaviorAppwithMobileInternetFallback);
               Session.OnFacebookAuthenticationFinished += OnFacebookAuthenticationFinished;
                var protocolArgs = args as ProtocolActivatedEventArgs;
                LifecycleHelper.FacebookAuthenticationReceived(protocolArgs);
                SessionStateChangedEventArgs e = new SessionStateChangedEventArgs(FacebookSessionState.Opened);
                loginFace.SessionStateChanged += loginButton_SessionStateChanged;
               
            }).AsTask().ConfigureAwait(false).GetAwaiter().GetResult();

            loginFace.SessionStateChanged -= loginButton_SessionStateChanged;
        }
        void loginButton_SessionStateChanged(object sender, SessionStateChangedEventArgs e)
        {
            if (e.SessionState == FacebookSessionState.Opened)
            {
             
            }
        }
        public override void askPublishPermissions(LoginCallback lc)
        {
            if (loginLock)
            {
                return;
            }
            loginLock = true;
            if (!isLoggedIn())
            {
                callback.loginSuccessful();
                login();
                return;
            }
            askPublishPermissions(lc);

        }

        public override object getAccessToken()
        {
            var fbToken = Session.ActiveSession.CurrentAccessTokenData.AccessToken;

            AccessToken token1 = new AccessToken();
            if (fbToken != null)
            {
                java.lang.String stirngToke = SilverlightImplementation.toJava(fbToken);
                long diff = Session.ActiveSession.CurrentAccessTokenData.Expires.Ticks - Session.ActiveSession.CurrentAccessTokenData.Issued.Ticks;
                diff = diff / 1000;
                java.lang.String diffstring = SilverlightImplementation.toJava(diff.ToString());
                ((AccessToken)token1).@this(stirngToke, diffstring);
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

        public override object createOauth2()
        {
            FaceBookAccess.setClientId(SilverlightImplementation.toJava(App.currentUser.Id));
            FaceBookAccess.setClientSecret(SilverlightImplementation.toJava(App.currentUser.UserName));
            FaceBookAccess.setRedirectURI(SilverlightImplementation.toJava(App.currentUser.ProfilePictureUrl.OriginalString));
            FaceBookAccess.setToken(SilverlightImplementation.toJava(App.fb.AccessToken));

            return ((FaceBookAccess)FaceBookAccess.getInstance()).createOAuth();
            //return base.createOauth2();
        }
        public override bool hasPublishPermissions()
        {

            AccessToken fbToken = (AccessToken)getToken();
            if (fbToken != null)
            {
                if (Session.ActiveSession.CurrentAccessTokenData.Issued <= Session.ActiveSession.CurrentAccessTokenData.Expires.Date)
                {
                    return Session.ActiveSession.CurrentAccessTokenData.CurrentPermissions.Contains("PUBLISH_PERMISSIONS");
                }

            }
            return false;
        }

        public override bool isLoggedIn()
        {
            var token = Session.ActiveSession.CurrentAccessTokenData.AccessToken;
            if (token != "")
            {
                if (Session.ActiveSession.CurrentAccessTokenData.Issued <= Session.ActiveSession.CurrentAccessTokenData.Expires.Date)
                {
                    return true;
                }

            }
            return false;
        }


        public override void logout()
        {
            Session.ActiveSession.Logout();
        }
        public override void inviteFriends(java.lang.String appLinkUrl, java.lang.String previewImageUrl)
        {
            inviteFriends(appLinkUrl, previewImageUrl, null);
        }
        public override void inviteFriends(java.lang.String appLinkUrl, java.lang.String previewImageUrl, Callback cb)
        {
            inviteCallback = cb;
            if (inviteCallback != null)
            {
                if (inviteCallback != null)
                {
                    inviteCallback.onSucess(null);
                    inviteCallback = null;
                }
            }

            base.inviteFriends(appLinkUrl, previewImageUrl);

        }
        public override bool isInviteFriendsSupported()
        {
            return false;
        }
        private async void OnFacebookAuthenticationFinished(AccessTokenData session)
        {
            fb = new Facebook.FacebookClient(Session.ActiveSession.CurrentAccessTokenData.AccessToken);
            result = await fb.GetTaskAsync("me");
            currentUser = new Facebook.Client.GraphUser(result);
        }

        public ProtocolActivatedEventArgs args { get; set; }
    }
}