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
    public class BasePresenter<V> : MvpPresenter<V> where V : MvpView
    {
        private V mMvpView;

        public void OnAttach(V mvpView)
        {
            mMvpView = mvpView;
        }

        public V GetMvpView()
        {
            return mMvpView;
        }

        public void OnDetach()
        {
            mMvpView = default(V);
        }
    }
}