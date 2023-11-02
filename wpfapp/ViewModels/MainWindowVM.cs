//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
using Obj = System.Collections.ObjectModel;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using wpfapp.Models;

namespace wpfapp.ViewModels
{
  public class MainWindowVM
  {
    public static Obj::ObservableCollection<User>? userList { get; set; }

    public Obj::ObservableCollection<User> UserList
    {
#pragma warning disable CS8603
      get => userList;
#pragma warning restore CS8603
      set
      {
        userList = value;
      }
    }

    public MainWindowVM()
    {
      userList = new Obj::ObservableCollection<User>();
    }
  }
}
