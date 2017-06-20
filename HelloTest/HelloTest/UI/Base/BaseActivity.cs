using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.Design.Widget;

namespace HelloTest.UI.Base
{
    abstract public class BaseActivity : Activity, MvpView
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
        }

        public void OnNotify(int stringRes, View view)
        {
            OnNotify(GetString(stringRes), view);
        }

        public void OnNotify(string message, View view)
        {
            ShowSnackBar(message, view);
        }

        private void ShowSnackBar(string message, View view)
        {
            Snackbar.Make(GetSnackView(view), message, Snackbar.LengthLong).Show();
        }

        private View GetSnackView(View view)
        {
            return view != null ? view : FindViewById(Android.Resource.Id.Content);
        }

        public abstract Context GetViewContext();

        public abstract void SetUp();
    }
}