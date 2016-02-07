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
            new FrameworkPropertyMetadata(0M, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, 
                new PropertyChangedCallback(NumberPropertyChanged), 
                new CoerceValueCallback(NumberPropertyCoerceValue)), new ValidateValueCallback(NumberPropertyValidated));

        private static bool NumberPropertyValidated(object value)
        {
            return value is decimal;
        }

        private static object NumberPropertyCoerceValue(DependencyObject d, object baseValue)
        {
            CurrencyTextBox ctb = d as CurrencyTextBox;
            decimal value = (decimal)baseValue;

            //Check maximum value
            if (value > ctb.MaximumValue && ctb.MaximumValue > 0)
                return ctb.MaximumValue;
            else
            //Check minimum value
            if (value < ctb.MinimumValue && ctb.MinimumValue < 0)
                return ctb.MinimumValue;
            else
                return value;
        }

        private static void NumberPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
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
            get { return (decimal)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }


        public static readonly DependencyProperty MaximumValueProperty =
            DependencyProperty.Register(
                "MaximumValue", 
                typeof(decimal), 
                typeof(CurrencyTextBox), 
                new FrameworkPropertyMetadata(0M, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, 
                    new PropertyChangedCallback(MaximumValuePropertyChanged), new CoerceValueCallback(MaximumCoerceValue)));

        private static object MaximumCoerceValue(DependencyObject d, object baseValue)
        {
            CurrencyTextBox ctb = d as CurrencyTextBox;

            if (ctb.MaximumValue > decimal.MaxValue / 2)
              return decimal.MaxValue / 2;

            return baseValue;
        }
        
        private static void MaximumValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CurrencyTextBox ctb = d as CurrencyTextBox;

            if (ctb.Number > (decimal)e.NewValue)
                ctb.Number = (decimal)e.NewValue;
        }

        public decimal MaximumValue
        {
            get { return (decimal)GetValue(MaximumValueProperty); }
            set { SetValue(MaximumValueProperty, value); }
        }
        
        public decimal MinimumValue
        {
            get { return (decimal)GetValue(MinimumValueProperty); }
            set { SetValue(MinimumValueProperty, value); }
        }

        public static readonly DependencyProperty MinimumValueProperty =
            DependencyProperty.Register("MinimumValue", 
                typeof(decimal), 
                typeof(CurrencyTextBox), 
                new FrameworkPropertyMetadata(0M, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    new PropertyChangedCallback(MinimumValuePropertyChanged), new CoerceValueCallback(MinimumCoerceValue)));

        private static object MinimumCoerceValue(DependencyObject d, object baseValue)
        {
            CurrencyTextBox ctb = d as CurrencyTextBox;

            if (ctb.MinimumValue < decimal.MinValue / 2)
                return decimal.MinValue / 2;

            return baseValue;
        }

        private static void MinimumValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            CurrencyTextBox ctb = d as CurrencyTextBox;

            if (ctb.Number < (decimal)e.NewValue)
                ctb.Number = (decimal)e.NewValue;
        }

        public static readonly DependencyProperty StringFormatProperty = DependencyProperty.Register(
            "StringFormat",
            typeof(string),
            typeof(CurrencyTextBox),
            new FrameworkPropertyMetadata("C2", StringFormatPropertyChanged));

        public string StringFormat
        {
            get { return (string)GetValue(StringFormatProperty); }
            set { SetValue(StringFormatProperty, value); }
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
            DataObject.AddCopyingHandler(this, CopyPasteEventHandler);
            DataObject.AddPastingHandler(this, CopyPasteEventHandler);

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
            if (IsNumericKey(e.Key))
            {
                e.Handled = true;

                InsertKey(e.Key);
            }
            else if (IsBackspaceKey(e.Key))
            {
                e.Handled = true;

                RemoveRightMostDigit();
            }
            else if (IsUpKey(e.Key))
            {
                e.Handled = true;
                
                AddOneDigit();

                //if the key is repeated add more digit
                if (e.IsRepeat) AddOneDigit(10);
            }
            else if (IsDownKey(e.Key))
            {
                e.Handled = true;

                SubstractOneDigit();

                //if the key is repeated substract more digit
                if (e.IsRepeat) SubstractOneDigit(10); 
            }
            else if (IsDeleteKey(e.Key))
            {
                e.Handled = true;

                Clear();
            }
            else if (IsSubstractKey(e.Key))
            {
                e.Handled = true;

                InvertValue();
            }
            else if (IsIgnoredKey(e.Key))
            {
                e.Handled = false;
            }
            else if (IsCtrlCKey(e.Key))
            {
                e.Handled = false;

                CopyToClipBoard();
            }
            else if (IsCtrlVKey(e.Key))
            {
                e.Handled = false;

                PasteFromClipBoard();
            }
            else
            {
                e.Handled = true;
            }
        }
        
        private void InsertKey(Key key)
        {
            //Max length fix
            if (this.MaxLength != 0 && Number.ToString().Length > this.MaxLength)
                return;

            // Push the new number from the right
            if (Number < 0)
                Number = (Number * 10M) - (GetDigitFromKey(key) / GetDivider());
            else
                Number = (Number * 10M) + (GetDigitFromKey(key) / GetDivider());
        }

        /// <summary>
        /// Paste if is a number on clipboard
        /// </summary>
        private void PasteFromClipBoard()
        {
            try
            {
                Number = decimal.Parse(Clipboard.GetText());
            }
            catch { }
        }

        /// <summary>
        /// Copy the property Number to Control
        /// </summary>
        private void CopyToClipBoard()
        {
            Clipboard.Clear();
            Clipboard.SetText(Number.ToString());
        }

        /// <summary>
        /// Reset the number to zero.
        /// </summary>
        public new void Clear()
        {
            Number = 0M;
        }

        /// <summary>
        /// Set number to positive
        /// </summary>
        public void SetPositive()
        {
            if (Number < 0) Number *= -1;
        }

        /// <summary>
        /// Set number to negative
        /// </summary>
        public void SetNegative()
        {
            if (Number > 0) Number *= -1;
        }

        /// <summary>
        /// Alternate value to Negative-Positive and Positive-Negative
        /// </summary>
        public void InvertValue()
        {
            Number *= -1;
        }

        /// <summary>
        /// Add one digit to the property number
        /// </summary>
        public void AddOneDigit(int repeat = 1)
        {
            for (int i = 0; i< repeat; i++)
                switch (this.GetBindingExpression(TextBox.TextProperty).ParentBinding.StringFormat)
                {
                    case "C0":
                        Number = decimal.Add(Number, 1M);
                        break;
                    case "C":
                        Number = decimal.Add(Number, 0.01M);
                        break;
                    case "C1":
                        Number = decimal.Add(Number, 0.1M);
                        break;
                    case "C2":
                        Number = decimal.Add(Number, 0.01M);
                        break;
                    case "C3":
                        Number = decimal.Add(Number, 0.001M);
                        break;
                    case "C4":
                        Number = decimal.Add(Number, 0.0001M);
                        break;
                    case "C5":
                        Number = decimal.Add(Number, 0.00001M);
                        break;
                    case "C6":
                        Number = decimal.Add(Number, 0.000001M);
                        break;
                }
        }

        public void SubstractOneDigit(int repeat = 1)
        {
            for (int i = 0; i < repeat; i++)
                switch (this.GetBindingExpression(TextBox.TextProperty).ParentBinding.StringFormat)
                {
                    case "C0":
                        Number = decimal.Subtract(Number, 1M);
                        break;
                    case "C":
                        Number = decimal.Subtract(Number, 0.01M);
                        break;
                    case "C1":
                        Number = decimal.Subtract(Number, 0.1M);
                        break;
                    case "C2":
                        Number = decimal.Subtract(Number, 0.01M);
                        break;
                    case "C3":
                        Number = decimal.Subtract(Number, 0.001M);
                        break;
                    case "C4":
                        Number = decimal.Subtract(Number, 0.0001M);
                        break;
                    case "C5":
                        Number = decimal.Subtract(Number, 0.00001M);
                        break;
                    case "C6":
                        Number = decimal.Subtract(Number, 0.000001M);
                        break;
                }
        }

        private void CopyPasteEventHandler(object sender, DataObjectEventArgs e)
        {
            // cancel copy and paste
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

        private decimal GetDivider()
        {
            switch (this.GetBindingExpression(TextBox.TextProperty).ParentBinding.StringFormat)
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


        private int GetSubstract()
        {
            switch (this.GetBindingExpression(TextBox.TextProperty).ParentBinding.StringFormat)
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
            return key == Key.Subtract || key == Key.OemMinus;
        }

        private bool IsDeleteKey(Key key)
        {
            return key == Key.Delete;
        }

        private bool IsIgnoredKey(Key key)
        {
            return key == Key.Tab || key == Key.Enter;            
        }

        private bool IsUpKey(Key key)
        {
            return key == Key.Up;
        }

        private bool IsDownKey (Key key)
        {
            return key == Key.Down;
        }

        private static bool IsCtrlCKey(Key key)
        {
            return key == Key.C && Keyboard.Modifiers == ModifierKeys.Control;
        }

        private static bool IsCtrlVKey(Key key)
        {
            return key == Key.V && Keyboard.Modifiers == ModifierKeys.Control;
        }

        /// <summary>
        /// Delete the right digit of number property
        /// </summary>
        /// <param name="tb"></param>
        private void RemoveRightMostDigit()
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
                    numberstring = numberstring.Insert(numberstring.Length - GetSubstract(), ",");

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
