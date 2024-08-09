using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using app_02.Model; 

namespace app_02.ViewModel
{
    class SettingVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel; 
        public bool Settings 
        {
            get { return _pageModel.Locationstatus; }
            set { _pageModel.Locationstatus = value; OnPropertyChanged(); }
        }
        public SettingVM()
        {
            _pageModel = new PageModel();
            Settings = true;
        }
    }
}
