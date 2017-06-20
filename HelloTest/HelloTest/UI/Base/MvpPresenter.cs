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

namespace HelloTest.UI.Base
{
    public interface MvpPresenter<V> where V : MvpView
    {
        void OnAttach(V mvpView);

        V GetMvpView();

        void OnDetach();
    }
}