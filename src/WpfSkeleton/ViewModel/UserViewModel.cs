using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using WpfSkeleton.Model.User;

namespace WpfSkeleton.ViewModel
{
    public class UserViewModel : ViewModelBase
    {
        private UserModel _userModel;
        public ObservableCollection<UserModel> _UserList;


        public UserViewModel(UserModel userModel)
        {
            _userModel = userModel;
        }

        public string Username
        {
            get { return _userModel.Username; }
            set
            {
                _userModel.Username = value;

                // set => SetProperty(ref _firstName, value);
            }
        }

        public ObservableCollection<UserModel> Users
        {
            get { return _UserList; }
            set { _UserList = value; }
        }


    }
}
