using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace intra_models
{
    public class Customer : INotifyPropertyChanged
    {
        private string name;
        private string lastName;
        private string address;
        private string city;
        private string province;
        private string postalCode;
        private string contactInfo;
        private string picturePath;
        private string info;
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                OnPropertyChanged();
            }
        }
        public string Address
        {
            get => address;
            set
            {
                address = value;
                OnPropertyChanged();
            }
        }
        public string City
        {
            get => city;
            set
            {
                city = value;
                OnPropertyChanged();
            }
        }
        public string Province
        {
            get => province;
            set
            {
                province = value;
                OnPropertyChanged();
            }
        }
        public string PostalCode
        {
            get => postalCode;
            set
            {
                postalCode = value;
                OnPropertyChanged();
            }
        }
        public string ContactInfo
        {
            get => contactInfo;
            set
            {
                contactInfo = value;
                OnPropertyChanged();
            }
        }
        public string PicturePath
        {
            get => picturePath;
            set
            {
                picturePath = value;
                OnPropertyChanged();
            }
        }
        public string Info
        {
            get => info;
            set
            {
                info = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    
}
