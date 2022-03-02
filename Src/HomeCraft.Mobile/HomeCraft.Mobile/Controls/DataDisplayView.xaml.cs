using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HomeCraft.Controls
{
    public partial class DataDisplayView : ContentPage
    {
        

        #region BindableProperty
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(DataDisplayView), defaultBindingMode: BindingMode.TwoWay);

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public static readonly BindableProperty ValueProperty = BindableProperty.Create(nameof(Value), typeof(string), typeof(DataDisplayView), defaultBindingMode: BindingMode.TwoWay);

        public string Value
        {
            get => (string)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        #endregion
        #region Constructor
        public DataDisplayView()
        {
            InitializeComponent();
        }

        #endregion
    }
}
