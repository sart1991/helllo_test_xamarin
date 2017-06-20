using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HelloTest.UI.Base;

namespace HelloTest.UI.Activitys.Main
{
    [Activity(Label = "Convertir número", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : BaseActivity, MainMvpView
    {
        private MainMvpPresenter<MainMvpView> presenter = new MainPresenter<MainMvpView>();

        private EditText editName;
        private TextView txtShowName;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            presenter.OnAttach(this);
            SetUp();
        }

        public override void SetUp()
        {
            Button buttonSubmit = FindViewById<Button>(Resource.Id.button_main_submit);
            editName = FindViewById<EditText>(Resource.Id.editText_main_name);
            txtShowName = FindViewById<TextView>(Resource.Id.textView_main_showName);
            buttonSubmit.Click += delegate { presenter.ClickButtonSubmit(editName.Text); };
        }

        public void ShowNameText(String name)
        {
            txtShowName.Text = name + " saluda a todo el mundo...";
        }

        public override Context GetViewContext()
        {
            return this;
        }

        protected override void OnDestroy()
        {
            presenter = default(MainPresenter<MainMvpView>);
        }
    }
}

