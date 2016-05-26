using System;

namespace CaSoftworks.MvvmBase {

    using System.ComponentModel;

    public class ViewModel: INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invokes the PropertyChanged event for this class.
        /// </summary>
        /// <param name="propertyName">The name of the property that has changed.</param>
        protected void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
