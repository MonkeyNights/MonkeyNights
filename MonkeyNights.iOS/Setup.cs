using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using UIKit;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform.Platform;

namespace MonkeyNights.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }

        public Setup(MvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp() => new Core.App();

        protected override IMvxTrace CreateDebugTrace() => new DebugTrace();
    }
}

