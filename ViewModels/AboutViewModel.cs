using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Net.Http;

namespace GeoFindsYou.ViewModels {
    
    public class AboutViewModel : BaseViewModel {
        
        public ICommand vOpenWebPegaIP { get; } /* ReadOnly */

        public AboutViewModel() {
            
            Title = "GeoFindsYou em modo de execução...";

            vOpenWebPegaIP = new Command(async () => {
                
                using (HttpClient vClient = new HttpClient()) {
                    
                    string vIP = await vClient.GetStringAsync("https://api.ipify.org");
                    await Browser.OpenAsync($"http://api.ipstack.com/{vIP}?access_key=8a6497ab9c197d32748033ad5f998bae&output=xml");
                }
            });
        }

        /* VERSÃO INICIAL:
        
        public AboutViewModel()
        {
            string vEndereco = Dns.GetHostName();
            IPAddress[] vIP = Dns.GetHostAddresses(vEndereco);

            Title = "Teste-Xamarin: " + vIP[1].ToString();
            OpenWebPegaIP = new Command(async () => await Browser.OpenAsync
            ($"http://api.ipstack.com/{vIP[1].ToString()}?access_key=8a6497ab9c197d32748033ad5f998bae&output=xml"));
        }
        
        */
    }
}