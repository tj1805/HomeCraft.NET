using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HomeCraft.Controls
{
    public partial class BorderDisplayView : ContentPage
    {
        public BorderDisplayView()
        {
            InitializeComponent();
        }


        public static readonly BindableProperty TitleTextProperty =
            BindableProperty.Create(nameof(TitleText),
                typeof(string),
                typeof(BorderDisplayView),
                defaultValue: string.Empty,
                defaultBindingMode: BindingMode.OneWay,
                propertyChanged: TitleTextPropertyChanged);

        private static void TitleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (BorderDisplayView)bindable;
            control.Title.Text = newValue.ToString();

        }

        public string TitleText { get; set; }
    }
}
