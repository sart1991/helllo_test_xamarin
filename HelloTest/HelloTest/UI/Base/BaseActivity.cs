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
        public void OnNotify(int stringRes, View view)
        {
            OnNotify(GetString(stringRes), view);
        }

        public void OnNotify(string message, View view)
        {
            ShowSnackBar(message, view);
        }

        private void ShowSnackBar(String message, View view)
        {
            Snackbar.Make(view, message, Snackbar.LengthLong).Show();
        }

        private View SnackView(View view)
        {
            return view != null ? view : FindViewById(Resource.Id.wrap_content);
        }

        public abstract Context GetViewContext();

        public abstract void SetUp();
    }
}