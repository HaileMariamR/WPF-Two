using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MWD.ViewModels;


namespace MWD.Views
{
    /// <summary>
    /// Interaction logic for Meeting.xaml
    /// </summary>
    public partial class Meeting : Window
    {
        public Meeting()
        {
            InitializeComponent();
            MeetingViewModel meetingViewModel = new MeetingViewModel();
            this.DataContext = meetingViewModel;
        }
        
    }
}
