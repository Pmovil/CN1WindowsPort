using com.codename1.facebook;
using com.codename1.impl;
using com.codename1.io;
using com.codename1.ui;
using com.codename1.util;
using EscalonesNati;
using Facebook.Client;
using Facebook.Client.Controls;
using java.lang;
using java.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.codename1.social
{

    public class FacebookImpl : FacebookConnect
    {

        private LoginButton loginFace;
        private FriendPicker friendPicker;
        private DateTime date;
        private LoginCallback callback;
        static Callback inviteCallback;
        public static bool loginLock = false;

        public void @this()
        {
            FacebookConnect._fimplClass = ((java.lang.Class)(object)typeof(FacebookImpl));
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
                loginFace.RequestNewPermissions("publish_actions");
                Session.ActiveSession.LoginWithBehavior("email,public_profile,user_friends", FacebookLoginBehavior.LoginBehaviorAppwithMobileInternetFallback);
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
    }
}
