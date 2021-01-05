using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Drive.v3;
using Google.Apis.Drive.v3.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xamarin.Auth;
using Xamarin.Auth.Presenters;
using Xamarin.Forms;

namespace ggdrive
{
    public class MainPageViewModel
    {
        //UserCredential credentials;

        //string ClientId = "334325008766-fo1fl6hhn4dpsbah751v3shaatst600e.apps.googleusercontent.com";
        //string RefreshToken = "1//0eX2xFd-i33-NCgYIARAAGA4SNwF-L9IrTLXV9Fpe5bJSRESKSUvliq38Ci2Q8Hy-sxdi_HXyu-jz53o28JRarxxWxoMaZo1dh-o";
        //string AccessToken = "ya29.a0AfH6SMCodh0Wo21sqPocZY4sYLF-4nf-qqXQgdczi54nn3Qcr7w6VECOwm8qaVO2hVTH3x4aptQdo-SP3zwtQhXyddX5vtkERmdwvQDi8yFl2TaPAK0U6imX0ybU8TsRMqiXlNV9Oat_RP4C4xekaxmxS33SlnqdvLoCZKlYfPA";
        //DriveService _service;
        //string ApplicationName = "Drive gg";

        //private readonly GoogleServices _googleServices;
        //ObservableCollection<Google.Apis.Drive.v3.Data.File> files = new ObservableCollection<Google.Apis.Drive.v3.Data.File>();
        //public ObservableCollection<Google.Apis.Drive.v3.Data.File> Files { get { return files; } }
        //public void Authenticate()
        //{
        //    // Register "Other" application in Google Console to get both clientId and clientSecret
        //    var secrets = new ClientSecrets() { ClientId = ClientId };
        //    var initializer = new GoogleAuthorizationCodeFlow.Initializer { ClientSecrets = secrets };
        //    var flow = new GoogleAuthorizationCodeFlow(initializer);

        //    // Refresh token can be obtained with the following curl commands: 
        //    // http://stackoverflow.com/questions/5850287/youtube-api-single-user-scenario-with-oauth-uploadingvideos/8876027#8876027
        //    // You should be able to achieve the same via Xamarin.Auth
        //    var token = new TokenResponse {AccessToken = AccessToken, RefreshToken = RefreshToken};
            
        //    credentials = new UserCredential(flow, "user", token);

        //}
        //public ICommand LoginCommand { get; set; }
        //public MainPageViewModel()
        //{
        //    _googleServices = new GoogleServices();
        //    Authenticate();
        //    _service = new DriveService(new BaseClientService.Initializer()
        //    {
        //        HttpClientInitializer = credentials,
        //        ApplicationName = ApplicationName,
        //    });
        //    this.LoginCommand = new Command(async () =>
        //    {
        //        if (files.Count > 0)
        //            files.Clear();
        //        var file = GetFileList();
        //        foreach (var item in file)
        //        {
        //            files.Add(item);
                    
        //        }
        //        //DriveServiceHelper helper = new DriveServiceHelper(_service);
        //        //var id = await helper.CreateFile();
        //        //await helper.SaveFile(id, "test", "test save content");
        //        //var content = await helper.ReadFile(id);
        //    });
        //}
        //public IList<Google.Apis.Drive.v3.Data.File> GetFileList()
        //{
        //    FilesResource.ListRequest listRequest = _service.Files.List();
        //    IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute().Files;

        //    return files;
        //}
        //public static class AuthenticatorHelper
        //{
        //    public static OAuth2Authenticator OAuth2Authenticator { get; set; }
        //}
    }
}