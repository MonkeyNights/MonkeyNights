using System;

using UIKit;
using MonkeyNights.Core.ViewModels;
using MvvmCross.Binding.BindingContext;

namespace MonkeyNights.iOS
{
    public partial class MainView : BaseView
    {
        public MainView ()
            : base ("MainView", null)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            var set = this.CreateBindingSet<MainView, MainViewModel> ();
        }
    }
}


