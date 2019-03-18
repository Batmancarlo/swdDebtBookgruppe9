using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Linq;
using System.Windows.Controls;
using System.Windows;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Debtbook.Models;
using Prism.Commands;
using Prism.Mvvm;
using Microsoft.Win32;


namespace Debtbook.ViewModels
{
    public class MainWindowsViewModel : BindableBase
    {
        private ObservableCollection<Debitor> debitors;
        
       
        public MainWindowsViewModel()
        {

            

            debitors = new ObservableCollection<Debitor>
            {
                new Debitor("Carsten den slyngel", -500),

                new Debitor("Krudtuglen Kenneth", -40)
            };
            
            CurrentDebitor = null;


        }
    
        
        public ObservableCollection<Debitor> Debitors
        {
            get { return debitors;}
            set
            {
               SetProperty(ref debitors, value);
            }
        }

        Debitor currentDebitor = null;

        public Debitor CurrentDebitor
        {
            get { return currentDebitor; }
            set { SetProperty(ref currentDebitor, value); }
        }

      

        int currentIndex = 1;
        public int CurrentIndex
        {
            get { return currentIndex; }
            set
            {
                SetProperty(ref currentIndex, value);
            }
        }

        ICommand _EditDebitorCommand;
        public ICommand EditDebitorCommand
        {
            get
            {
                return _EditDebitorCommand ?? (_EditDebitorCommand = new DelegateCommand(() =>
                           {
                               
                               var vm = new DebitorViewModel(CurrentDebitor)
                               {
                                  
                               };
                               var dlg = new DebitorWindow()
                               {
                                   DataContext = vm,
                                   Owner = App.Current.MainWindow
                               };
                               if (dlg.ShowDialog() == true)
                               {
                                   
                               }



                               //dlg.DataContext = tempDebitor;
                           },
                           () => {
                               return CurrentIndex >= 0;
                           }
                       ).ObservesProperty(() => CurrentIndex));
            }
        }


        private ICommand _AddDebitorCommand;
            
        public ICommand AddDebitorCommand
        {
            get
            {
                return _AddDebitorCommand ?? (_AddDebitorCommand = new DelegateCommand(() =>
                           {
                               
                               var vm = new AddDebitorViewModel(Debitors);
                               {

                               };
                               var dlg = new AddDebitorWindow()
                               {
                                   DataContext = vm,
                                   Owner = App.Current.MainWindow
                               };
                               if (dlg.ShowDialog() == true)
                               {

                               }
                               
                               //dlg.DataContext = tempDebitor;
                           },
                           () => {
                               return CurrentIndex >= 0;
                           }
                       ).ObservesProperty(() => CurrentIndex));
            }
        }

    }
}
