// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace MinhasTarefas.Helpers
{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters. 
  /// </summary>
  public static class Settings
  {

        private static ISettings AppSettings => CrossSettings.Current;

        const string UserIdKey = "userid";
        private static readonly string UserIdDefault = string.Empty;
        public static string UserId
        {
            get { return AppSettings.GetValueOrDefault<string>(UserIdKey, UserIdDefault); }
            set { AppSettings.AddOrUpdateValue<string>(UserIdKey, value); }
        }

        const string AuthTokenKey = "authtoken";
        private static readonly string AuthTokenDefault = string.Empty;
        public static string AuthToken
        {
            get { return AppSettings.GetValueOrDefault<string>(AuthTokenKey, AuthTokenDefault); }
            set { AppSettings.AddOrUpdateValue<string>(AuthTokenKey, value); }
        }

        const string UserNameKey = "userName";
        static readonly string UserNameDefault = "Usuário";
        public static string UserName
        {
            get { return AppSettings.GetValueOrDefault<string>(UserNameKey, UserNameDefault); }
            set { AppSettings.AddOrUpdateValue<string>(UserNameKey, value); }
        }

        const string UserProfileKey = "userProfile";
        static readonly string UserProfileDefault = "user.png";
        public static string UserProfile
        {
            get { return AppSettings.GetValueOrDefault<string>(UserProfileKey, UserProfileDefault); }
            set { AppSettings.AddOrUpdateValue<string>(UserProfileKey, value); }
        }


        const string UserCoverKey = "userCover";
        static readonly string UserCoverDefault = string.Empty;
        public static string UserCover
        {
            get { return AppSettings.GetValueOrDefault<string>(UserCoverKey, UserCoverDefault); }
            set { AppSettings.AddOrUpdateValue<string>(UserCoverKey, value); }
        }

        public static bool IsLoggedIn => !string.IsNullOrWhiteSpace(UserId);
    }
}