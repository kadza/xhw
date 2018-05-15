using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace xhw
{
	public class MainPageViewModel : INotifyPropertyChanged
    {
		public MainPageViewModel()
		{
			GetPlatform = new Command(GetPlatformImpl);
		}
       
		string platform = "test";

		public event PropertyChangedEventHandler PropertyChanged;

		public string Platform
		{
			get {
				return platform;
			}

			set {
				platform = value;
				OnPropertyChanged("Platform");
			}
		}

		protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

		public ICommand GetPlatform { get; }
        
		private void GetPlatformImpl(){
			Platform = "test1";
		}
        
	}
}
