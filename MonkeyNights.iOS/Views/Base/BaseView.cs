using System;
using MvvmCross.iOS.Views;
using Foundation;
using UIKit;

namespace MonkeyNights.iOS
{
    public class BaseView : MvxViewController
    {
        public BaseView (string nibName, Foundation.NSBundle bundle)
            : base (nibName, bundle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            NavigationController.SetNavigationBarHidden (true, false);
        }

        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations ()
        {
            return UIInterfaceOrientationMask.Portrait;
        }

        public override UIInterfaceOrientation PreferredInterfaceOrientationForPresentation ()
        {
            return UIInterfaceOrientation.Portrait;
        }
    }
}
