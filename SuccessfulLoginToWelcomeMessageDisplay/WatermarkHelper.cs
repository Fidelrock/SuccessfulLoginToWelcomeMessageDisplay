using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace SuccessfulLoginToWelcomeMessageDisplay
{
    public static class WatermarkHelper
    {
        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.RegisterAttached("Watermark", typeof(string), typeof(WatermarkHelper), new PropertyMetadata(string.Empty, OnWatermarkChanged));

        public static string GetWatermark(UIElement element)
        {
            return (string)element.GetValue(WatermarkProperty);
        }

        public static void SetWatermark(UIElement element, string value)
        {
            element.SetValue(WatermarkProperty, value);
        }

        private static void OnWatermarkChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is TextBox textBox)
            {
                textBox.Loaded += (sender, args) => ApplyWatermark(textBox);
                textBox.GotFocus += (sender, args) => RemoveWatermark(textBox);
                textBox.LostFocus += (sender, args) => ApplyWatermark(textBox);
            }
        }

        private static void ApplyWatermark(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = GetWatermark(textBox);
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private static void RemoveWatermark(TextBox textBox)
        {
            if (textBox.Text == GetWatermark(textBox))
            {
                textBox.Text = string.Empty;
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }
    }
}
