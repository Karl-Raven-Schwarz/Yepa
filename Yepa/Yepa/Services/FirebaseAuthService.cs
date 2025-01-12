using Firebase.Auth;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Yepa.Helpers;
using Yepa.Views.Popup;

namespace Yepa.Services 
{
    public class FirebaseAuthService 
    {

        private FirebaseAuthLink firebaseAuthLink;

        #region Private Methonds

        /// <summary>
        /// Save Firebase Auth and Firebase Token
        /// </summary>
        /// <param name="auth"></param>
        private void SaveFirebaseAuth(FirebaseAuth auth) {
            string json = JsonConvert.SerializeObject(auth);
            SaveFirebaseToken(auth.FirebaseToken);
            SecureStorage.SetAsync("FirebaseAuth",json);
        }
        
        /// <summary>
        /// Delete Firebase Auth and Firebase Token
        /// </summary>
        private void DeleteFirebaseAuth()
        {
            SecureStorage.Remove("FirebaseAuth");
            DeleteFirebaseToken();
        }

        private void SaveFirebaseToken(string firebaseToken) 
        {
            SecureStorage.SetAsync("FirebaseToken", firebaseToken);
        }

        private void DeleteFirebaseToken()
        {
            SecureStorage.Remove("FirebaseToken");
        }

        private FirebaseAuth GetFirebaseAuth() 
        {
            string getFirebaseAuthJson = SecureStorage.GetAsync("FirebaseAuth").Result;
            if (string.IsNullOrEmpty(getFirebaseAuthJson)) 
            {
                return null;
            }
            else 
            {
                return JsonConvert.DeserializeObject<FirebaseAuth>(getFirebaseAuthJson);
            }
        }

        public async Task<string> SendAlert() {
            var alertPopup = new AlertPopup(Languages.Alert, Languages.Emailnotactive, Languages.Yes, Languages.No);
            await PopupNavigation.Instance.PushAsync(alertPopup);
            var ret = await alertPopup.PopupClosedTask;
            return ret.ToString(); 
        }

        #endregion


        #region Public Methods

        public async Task<bool> SignUpWithEmailAndPasswordAsync(string email, string password, string diplayName) 
        {
            var firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(App.FirebaseApiKey));
            try 
            {
                firebaseAuthLink = await firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync(email, password, diplayName, true);
                var getphotoUrl = string.Empty;
                await firebaseAuthLink.UpdateProfileAsync(diplayName, getphotoUrl);
                await firebaseAuthProvider.SendEmailVerificationAsync(firebaseAuthLink);
                //Save ClientID
                Preferences.Set("ClientID",firebaseAuthLink.User.LocalId);

                App.FirebaseRTDBService.Initialize();
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, Languages.SingupVerification, Languages.Ok, null));
                return true;
            }
            catch (FirebaseAuthException FAex) 
            {
                var message = FAex.Reason.ToString() ?? FAex.Message;
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, message, Languages.Ok, null));
                return false;
            }
            catch (Exception ex) 
            {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, ex.Message, Languages.Ok, null));
                return false;
            }
        }

        public async Task<bool> LogInWithEmailAndPasswordAsync(string email , string password) 
        {
            var firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(App.FirebaseApiKey));
            try 
            {
                firebaseAuthLink = await firebaseAuthProvider.SignInWithEmailAndPasswordAsync(email, password);
                if (firebaseAuthLink.User.IsEmailVerified) 
                {
                    // Save the auth object/token every time it's refreshed.
                    SaveFirebaseAuth(firebaseAuthLink);
                    firebaseAuthLink.FirebaseAuthRefreshed += (s, e) => SaveFirebaseAuth(e.FirebaseAuth);
                    Preferences.Set("ClientID", firebaseAuthLink.User.LocalId);
                    App.FirebaseRTDBService.Initialize();
                    return true;
                }
                else 
                {
                    var alertPopup = new AlertPopup(Languages.Alert, Languages.Emailnotactive, Languages.Yes, Languages.No);
                    await PopupNavigation.Instance.PushAsync(alertPopup);
                    if (await alertPopup.PopupClosedTask) 
                    {
                        await firebaseAuthProvider.SendEmailVerificationAsync(firebaseAuthLink);
                    }
                    return false;
                }
            }
            catch (FirebaseAuthException FAex) 
            {
                var message = FAex.Reason.ToString() ?? FAex.Message;
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, message, Languages.Ok, null));
                return false;
            }
            catch (Exception ex) 
            {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, ex.Message, Languages.Ok, null));
                return false;
            }
        }

        public async Task<bool> LogInWithFirebaseAuthTokenAsync() 
        {
            var firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(App.FirebaseApiKey));
            try {
                var firebaseAuth = GetFirebaseAuth();
                if (firebaseAuth !=null) 
                {
                    if (firebaseAuth.IsExpired())
                    {
                        firebaseAuthLink = await firebaseAuthProvider.RefreshAuthAsync(GetFirebaseAuth());    
                    }
                    else
                    {
                        firebaseAuthLink =  new FirebaseAuthLink(firebaseAuthProvider, firebaseAuth);
                    }
                    // Save the auth object/token every time it's refreshed.
                    SaveFirebaseAuth(firebaseAuthLink);
                    firebaseAuthLink.FirebaseAuthRefreshed += (s, e) => SaveFirebaseAuth(e.FirebaseAuth);
                    Preferences.Set("ClientID", firebaseAuthLink.User.LocalId);
                    App.FirebaseRTDBService.Initialize();
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            catch (FirebaseAuthException FAex) 
            {
                var message = FAex.Reason.ToString() ?? FAex.Message;
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, message, Languages.Ok, null));
                return false;
            }
            catch (Exception ex) 
            {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, ex.Message, Languages.Ok, null));
                return false;
            }
        }

        public async Task<bool> SendPasswordResetEmailAsync(string email)
        {
            var firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(App.FirebaseApiKey));
            try
            {
                await firebaseAuthProvider.SendPasswordResetEmailAsync(email);
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, Languages.SingupVerification, Languages.Ok, null));
                return true;
            }
            catch (FirebaseAuthException FAex)
            {
                var message = FAex.Reason.ToString() ?? FAex.Message;
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, message, Languages.Ok, null));
                return false;
            }
            catch (Exception ex)
            {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, ex.Message, Languages.Ok, null));
                return false;
            }
        }

        public async Task<bool> UpdateProfileAsync(string displayName)
        {
            var firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(App.FirebaseApiKey));
            try
            {
                var getFirebaseAuth = GetFirebaseAuth();
                if (getFirebaseAuth != null)
                {
                    if (getFirebaseAuth.IsExpired())
                    {
                        getFirebaseAuth = await firebaseAuthProvider.RefreshAuthAsync(getFirebaseAuth);
                    }
                    string getPhotoUrl = string.Empty;
                    firebaseAuthLink = await firebaseAuthProvider.UpdateProfileAsync(getFirebaseAuth.FirebaseToken, displayName, getPhotoUrl);
                    SaveFirebaseAuth(firebaseAuthLink);
                    App.FirebaseRTDBService.Initialize();
                    await PopupNavigation.Instance.PushAsync(new AlertPopup(null,"Photo", Languages.Ok, null));
                    return true;
                }
                else
                {
                    await PopupNavigation.Instance.PushAsync(new AlertPopup(null, "Error Photo", Languages.Ok, null));
                    return false;
                }
            }
            catch (FirebaseAuthException FAex)
            {
                var message = FAex.Reason.ToString() ?? FAex.Message;
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, message, Languages.Ok, null));
                return false;
            }
            catch (Exception ex)
            {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, ex.Message, Languages.Ok, null));
                return false;
            }
        }

        public async Task<bool> ChangeUserPasswordAsync(string password)
        {
            var firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(App.FirebaseApiKey));
            try
            {
                var getFirebaseAuth = GetFirebaseAuth();
                if (getFirebaseAuth != null) {
                    if (getFirebaseAuth.IsExpired()) {
                        getFirebaseAuth = await firebaseAuthProvider.RefreshAuthAsync(getFirebaseAuth);
                    }
                    firebaseAuthLink = await firebaseAuthProvider.ChangeUserPassword(getFirebaseAuth.FirebaseToken, password);
                    SaveFirebaseAuth( firebaseAuthLink);
                    App.FirebaseRTDBService.Initialize();
                    await PopupNavigation.Instance.PushAsync(new AlertPopup(null, Languages.PasswordError, Languages.Ok, null));
                    return true;
                }
                else
                {
                    await PopupNavigation.Instance.PushAsync(new AlertPopup(null, Languages.PasswordError, Languages.Ok, null));
                    return false;
                }
            }
            catch (FirebaseAuthException FAex)
            {
                var message = FAex.Reason.ToString() ?? FAex.Message;
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, message, Languages.Ok, null));
                return false;
            }
            catch (Exception ex)
            {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, ex.Message, Languages.Ok, null));
                return false;
            }
        }

        public async Task LogOutAsync()
        {
            try  
            {
                DeleteFirebaseAuth();
                Preferences.Remove("ClientID");
            }
            catch (Exception ex)
            {
                await LogOutAsync();
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, ex.Message, Languages.Ok, null));
            }
        }

        #endregion

        //FOR TESTS
        public async Task<bool> SignUpWorkerWithEmailAndPasswordAsync(string email, string password, string diplayName)
        {
            var firebaseAuthProvider = new FirebaseAuthProvider(new FirebaseConfig(App.FirebaseApiKey));
            try
            {
                firebaseAuthLink = await firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync(email, password, diplayName, true);
                //Save ClientID
                Preferences.Set("WorkerID", firebaseAuthLink.User.LocalId);
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, Languages.SingupVerification, Languages.Ok, null));
                return true;
            }
            catch (FirebaseAuthException FAex)
            {
                var message = FAex.Reason.ToString() ?? FAex.Message;
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, message, Languages.Ok, null));
                return false;
            }
            catch (Exception ex)
            {
                await PopupNavigation.Instance.PushAsync(new AlertPopup(null, ex.Message, Languages.Ok, null));
                return false;
            }
        }
    }
}
