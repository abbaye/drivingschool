using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace CurrencyTextBoxControl
{
    public class CurrencyTextBox : TextBox
    {
        #region Dependency Properties
        public static readonly DependencyProperty NumberProperty = DependencyProperty.Register(
            "Number",
            typeof(decimal),
            typeof(CurrencyTextBox),
            new FrameworkPropertyMetadata(0M, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(NumberChangedCallBack), new CoerceValueCallback(NumberCoerceValueCallBack)));

        private static object NumberCoerceValueCallBack(DependencyObject d, object baseValue)
        {

            CurrencyTextBox ctb = d as CurrencyTextBox;
            decimal value = (decimal)baseValue;

            if (value > ctb.MaximumValue && ctb.MaximumValue > 0)
                return ctb.MaximumValue;
            else
                return value;           
        }

        private static void NumberChangedCallBack(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CurrencyTextBox ctb = d as CurrencyTextBox;

            //Color update
            if (ctb.Number < 0)
                ctb.Foreground = Brushes.Red;
            else
                ctb.Foreground = Brushes.Black;

        }

        public decimal Number
        {
            get
            {
                return (decimal)GetValue(NumberProperty);
            }
            set
            {
                SetValue(NumberProperty, value);
            }
        }


        public static readonly DependencyProperty MaximumValueProperty =
            DependencyProperty.Register(
                "MaximumValue", 
                typeof(decimal), 
                typeof(CurrencyTextBox), 
                new FrameworkPropertyMetadata(0M, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(MaximumValueChangedCallback)));

        private static void MaximumValueChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CurrencyTextBox ctb = d as CurrencyTextBox;

            if (ctb.Number > (decimal)e.NewValue)
                ctb.Number = (decimal)e.NewValue;
        }

        public decimal MaximumValue
        {
            get
            {
                return (decimal)GetValue(MaximumValueProperty);
            }
            set
            {
                SetValue(MaximumValueProperty, value);
            }
        }

        public static readonly DependencyProperty StringFormatProperty = DependencyProperty.Register(
            "StringFormat",
            typeof(string),
            typeof(CurrencyTextBox),
            new FrameworkPropertyMetadata("C2", StringFormatPropertyChanged));
        public string StringFormat
        {
            get
            {
                return (string)GetValue(StringFormatProperty);
            }
            set
            {
                SetValue(StringFormatProperty, value);
            }
        }

        private static void StringFormatPropertyChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            // Update the Text binding with the new StringFormat
            var textBinding = new Binding();
            textBinding.Path = new PropertyPath("Number");
            textBinding.RelativeSource = new RelativeSource(RelativeSourceMode.Self);
            textBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            textBinding.StringFormat = (string)e.NewValue;

            BindingOperations.SetBinding(obj, TextBox.TextProperty, textBinding);
        }
        #endregion

        #region Constructor
        static CurrencyTextBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(
                typeof(CurrencyTextBox),
                new FrameworkPropertyMetadata(typeof(CurrencyTextBox)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            
            // Bind Text to Number with the specified StringFormat
            var textBinding = new Binding();
            textBinding.Path = new PropertyPath("Number");
            textBinding.RelativeSource = new RelativeSource(RelativeSourceMode.Self);
            textBinding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            textBinding.StringFormat = this.StringFormat;

            BindingOperations.SetBinding(this, TextBox.TextProperty, textBinding);

            // Disable copy/paste
            DataObject.AddCopyingHandler(this, PastingEventHandler);
            DataObject.AddPastingHandler(this, PastingEventHandler);

            this.CaretIndex = this.Text.Length;
            this.PreviewKeyDown += TextBox_PreviewKeyDown;
            this.PreviewMouseDown += TextBox_PreviewMouseDown;
            this.PreviewMouseUp += TextBox_PreviewMouseUp;
            this.TextChanged += TextBox_TextChanged;
            
            this.ContextMenu = null;
            
        }
        #endregion

        #region Events
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = sender as TextBox;

            if (Number < 0 && tb.Text.EndsWith(")"))
                tb.CaretIndex = tb.Text.Length - 1;
            else
                tb.CaretIndex = tb.Text.Length;
        }

        private void TextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            // Prevent changing the caret index
            e.Handled = true;
            (sender as TextBox).Focus();
        }

        void TextBox_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            // Prevent changing the caret index
            e.Handled = true;
            (sender as TextBox).Focus();
        }

        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            var tb = sender as TextBox;

            if (IsNumericKey(e.Key))
            {
                e.Handled = true;

                //Max length fix
                if (tb.MaxLength != 0 && Number.ToString().Length > tb.MaxLength)
                    return;

                // Push the new number from the right
                if (Number < 0)
                    Number = (Number * 10M) - (GetDigitFromKey(e.Key) / GetDivider(tb));
                else
                    Number = (Number * 10M) + (GetDigitFromKey(e.Key) / GetDivider(tb));

            }
            else if (IsBackspaceKey(e.Key))
            {
                e.Handled = true;

                // Remove the right-most digit

                RemoveRightMostDigit(tb);
            }
            else if (IsDeleteKey(e.Key))
            {
                e.Handled = true;

                Number = 0M;
            }
            else if (IsSubstractKey(e.Key))
            {
                e.Handled = true;

                Number *= -1;
            }
            else if (IsIgnoredKey(e.Key))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PastingEventHandler(object sender, DataObjectEventArgs e)
        {
            // Prevent copy/paste
            e.CancelCommand();
        }
        #endregion

        #region Private Methods
        private decimal GetDigitFromKey(Key key)
        {
            switch (key)
            {
                case Key.D0:
                case Key.NumPad0: return 0M;
                case Key.D1:
                case Key.NumPad1: return 1M;
                case Key.D2:
                case Key.NumPad2: return 2M;
                case Key.D3:
                case Key.NumPad3: return 3M;
                case Key.D4:
                case Key.NumPad4: return 4M;
                case Key.D5:
                case Key.NumPad5: return 5M;
                case Key.D6:
                case Key.NumPad6: return 6M;
                case Key.D7:
                case Key.NumPad7: return 7M;
                case Key.D8:
                case Key.NumPad8: return 8M;
                case Key.D9:
                case Key.NumPad9: return 9M;
                default: throw new ArgumentOutOfRangeException("Invalid key: " + key.ToString());
            }
        }

        private decimal GetDivider(TextBox tb)
        {
            switch (tb.GetBindingExpression(TextBox.TextProperty).ParentBinding.StringFormat)
            {
                case "C0":
                    return 1M;
                case "C":
                    return 100M;
                case "C1":
                    return 10M;
                case "C2":
                    return 100M;
                case "C3":
                    return 1000M;
                case "C4":
                    return 10000M;
                case "C5":
                    return 100000M;
                case "C6":
                    return 1000000M;
            }

            return 1M;
        }


        private int GetSubstract(TextBox tb)
        {
            switch (tb.GetBindingExpression(TextBox.TextProperty).ParentBinding.StringFormat)
            {
                case "C0":
                    return 1;
                case "C":
                    return 3;
                case "C1":
                    return 2;
                case "C2":
                    return 3;
                case "C3":
                    return 4;
                case "C4":
                    return 5;
                case "C5":
                    return 6;
                case "C6":
                    return 7;
            }

            return 1;
        }

        private bool IsNumericKey(Key key)
        {
            return key == Key.D0 ||
                key == Key.D1 ||
                key == Key.D2 ||
                key == Key.D3 ||
                key == Key.D4 ||
                key == Key.D5 ||
                key == Key.D6 ||
                key == Key.D7 ||
                key == Key.D8 ||
                key == Key.D9 ||
                key == Key.NumPad0 ||
                key == Key.NumPad1 ||
                key == Key.NumPad2 ||
                key == Key.NumPad3 ||
                key == Key.NumPad4 ||
                key == Key.NumPad5 ||
                key == Key.NumPad6 ||
                key == Key.NumPad7 ||
                key == Key.NumPad8 ||
                key == Key.NumPad9;
        }

        private bool IsBackspaceKey(Key key)
        {
            return key == Key.Back;
        }

        private bool IsSubstractKey(Key key)
        {
            return key == Key.Subtract || 
                key == Key.OemMinus;
        }

        private bool IsDeleteKey(Key key)
        {
            return key == Key.Delete;
        }

        private bool IsIgnoredKey(Key key)
        {
            return key == Key.Up ||
                key == Key.Down ||
                key == Key.Tab ||
                key == Key.Enter;
        }

        private void RemoveRightMostDigit(TextBox tb)
        {
            try
            {
                if (Number.ToString().LastIndexOf(",") == -1)
                {
                    Number = Convert.ToDecimal(Number.ToString().Remove(Number.ToString().Length - 1));
                }
                else
                {
                    string numberstring = Number.ToString().Replace(",", "");
                    numberstring = numberstring.Insert(numberstring.Length - GetSubstract(tb), ",");

                    Number = Convert.ToDecimal(numberstring.Remove(numberstring.Length - 1));
                }
            }
            catch
            {
                Number = 0;
            }
        }
        #endregion
    }
}
