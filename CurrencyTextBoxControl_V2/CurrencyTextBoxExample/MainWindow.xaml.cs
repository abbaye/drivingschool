using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;

namespace CurrencyTextBoxExample
{
    public partial class MainWindow : Window, IDataErrorInfo
    {
        private decimal _number = 12345.6756M;
        public decimal Number
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;

                listBox.Items.Add(value);
                listBox.SelectedIndex = listBox.Items.Count - 1;
                
            }
        }

        private List<string> _stringFormats;
        public List<string> StringFormats
        {
            get
            {
                if (_stringFormats == null)
                {
                    _stringFormats = new List<string>() { "C", "E", "F", "G", "N", "P", "{0:C1}", "{0:C0}", "{0:C4}" };
                }

                return _stringFormats;
            }
            set
            {
                _stringFormats = value;
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = this;
        }

        public string Error
        {
            get { throw new System.NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Number" &&
                    (_number < 0 || _number > 10))
                {
                    return "Number must be between zero and ten.";
                }
                else
                {
                    return null;
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            myCurrencyTextBox.MaximumValue = 20;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(myCurrencyTextBox.Number.ToString());
        }
    }
}
