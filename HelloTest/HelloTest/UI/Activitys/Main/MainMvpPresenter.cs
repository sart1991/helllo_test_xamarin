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
using HelloTest.UI.Base;

namespace HelloTest.UI.Activitys.Main
{
    interface MainMvpPresenter<V> : MvpPresenter<V> where V : MainMvpView
    {
        void ClickButtonSubmit(String name);
        void ClickButtonRegister(String name);
        void ClickButtonShowRegister();
    }
}