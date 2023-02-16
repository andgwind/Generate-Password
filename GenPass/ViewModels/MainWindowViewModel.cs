using GenPass.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenPass.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок
        /// <summary> Заголовок приложения </summary>
        private string _Title = "GenPass";

        /// <summary> Заголовок приложения </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        private string _Logotip = "/Views/Windows/logopass.png";

        public string Logotip
        {
            get => _Logotip;
            set => Set(ref _Logotip, value);
        }


    }
}
