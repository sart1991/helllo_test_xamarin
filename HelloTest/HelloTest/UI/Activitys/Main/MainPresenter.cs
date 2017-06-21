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

        private static List<string> names = new List<string>();

        public void ClickButtonSubmit(string name)
        {
            if("".Equals(name))
            {
                GetMvpView().OnNotify("Debe ingresar un nombre", null);
            } else
            {
                GetMvpView().ShowNameText(name + " saluda a todo el mundo...");
            }
        }

        public void ClickButtonRegister(string name)
        {
            names.Add(name);
            GetMvpView().OnNotify(name + " ha sido registrado", null);
        }

        public void ClickButtonShowRegister()
        {
            string helloAll = "";
            names.ForEach((string name) =>
            {
                helloAll += name + ", ";
            });
            helloAll += names.Count > 1 ? "saludaron a todo el mundo" : "saludó a todo el mundo";
            GetMvpView().ShowNameText(helloAll);
        }

    }
}