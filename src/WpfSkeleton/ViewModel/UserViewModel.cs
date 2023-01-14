using System.Collections.ObjectModel;
using System.ComponentModel;
using WpfSkeleton.Model.User;

namespace WpfSkeleton.ViewModel
{
    public class UserViewModel : ViewModelBase
    {
        private UserModel userModel;
        public ObservableCollection<UserModel> userList;


        public UserViewModel(UserModel userModel)
        {
            userModel = userModel;
        }

        public string Username
        {

            get { return userModel.Username; }
            set
            {
                userModel.Username = value;

                // set => SetProperty(ref _firstName, value);
            }
        }

        public ObservableCollection<UserModel> Users
        {
            get { return userList; }
            set { userList = value; }
        }


    }
}
