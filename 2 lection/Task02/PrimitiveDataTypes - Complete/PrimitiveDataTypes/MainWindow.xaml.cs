using System.Windows;
using System.Windows.Controls;

namespace PrimitiveDataTypes
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBoxTypeSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (type.SelectedItem as ListBoxItem);
            switch (selectedItem.Content.ToString())
            {
                case "int":
                    ShowIntValue();
                    break;
                case "long":
                    ShowLongValue();
                    break;
                case "float":
                    ShowFloatValue();
                    break;
                case "double":
                    ShowDoubleValue();
                    break;
                case "decimal":
                    ShowDecimalValue();
                    break;
                case "string":
                    ShowStringValue();
                    break;
                case "char":
                    ShowCharValue();
                    break;
                case "bool":
                    ShowBoolValue();
                    break;
            }
        }

        private void ShowIntValue()
        {
            int intVar;
            intVar = 42;
            value.Text = intVar.ToString();
        }

        private void ShowLongValue()
        {
            long longVar;
            longVar = 42L;
            value.Text = longVar.ToString();
        }

        private void ShowFloatValue()
        {
            float floatVar;
            floatVar = 0.42F;
            value.Text = floatVar.ToString();
        }

        private void ShowDoubleValue()
        {
            double doubleVar;
            doubleVar = 0.42;
            value.Text = doubleVar.ToString();
        }

        private void ShowDecimalValue()
        {
            decimal decimalVar;
            decimalVar = 0.42M;
            value.Text = decimalVar.ToString();
        }

        private void ShowStringValue()
        {
            string stringVar;
            stringVar = "forty two";
            value.Text = stringVar; // ToString not needed
        }

        private void ShowCharValue()
        {
            char charVar;
            charVar = 'x';
            value.Text = charVar.ToString();
        }

        private void ShowBoolValue()
        {
            bool boolVar;
            boolVar = false;
            value.Text = boolVar.ToString();
        }

        private void QuitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
