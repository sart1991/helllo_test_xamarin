using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HelloTest.UI.Base;
using Android.Support.Design.Widget;

namespace HelloTest.UI.Activitys.Main
{
    [Activity(MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : BaseActivity, MainMvpView
    {
        private MainMvpPresenter<MainMvpView> presenter = new MainPresenter<MainMvpView>();

        private TextInputLayout tilName;
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
            Button buttonRegister = FindViewById<Button>(Resource.Id.button_main_register);
            Button buttonShowRegister = FindViewById<Button>(Resource.Id.button_main_showRegister);
            tilName = FindViewById<TextInputLayout>(Resource.Id.til_main_name);
            editName = FindViewById<EditText>(Resource.Id.editText_main_name);
            txtShowName = FindViewById<TextView>(Resource.Id.textView_main_showName);
            buttonSubmit.Click += delegate { presenter.ClickButtonSubmit(editName.Text); };
            buttonRegister.Click += delegate { presenter.ClickButtonRegister(editName.Text); };
            buttonShowRegister.Click += delegate { presenter.ClickButtonShowRegister(); };
        }

        public void ShowNameText(String name)
        {
            txtShowName.Text = name;
        }

        public void ShowNameError()
        {
            tilName.Error = " ";
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

