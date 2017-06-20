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
    class MainPresenter<V> : BasePresenter<V>, MainMvpPresenter<V> where V : MainMvpView
    {
        public void ClickButtonSubmit(String name)
        {
            if("".Equals(name))
            {
                GetMvpView().OnNotify("Debe ingresar un nombre", null);
            } else
            {
                GetMvpView().ShowNameText(name);
            }
        }
    }
}