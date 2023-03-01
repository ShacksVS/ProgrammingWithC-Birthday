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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Date.Tools.Controls
{
    /// <summary>
    /// Interaction logic for DatePickerWithLabel.xaml
    /// </summary>
    public partial class DatePickerWithLabel : UserControl
    {
        public string Caption { 
            get { return (string)LCaption.Content ; }
            set { LCaption.Content = value; } }

        public string Text
        {
            get { return DpDate.Text; }
        }

        public DateTime Value
        {
            get { return DpDate.SelectedDate.Value; }
        }

        public DatePickerWithLabel()
        {
            InitializeComponent();
        }
    }
}
