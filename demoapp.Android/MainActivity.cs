using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Com.Instabug.Library;
using Com.Instabug.Library.Invocation;
using SuaveControls.MaterialForms.Android;

namespace demoapp.Droid
{
    [Activity(Label = "demoapp", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            RendererInitializer.Init();
            base.OnCreate(savedInstanceState);

            new Instabug.Builder(Application, "86fae965aa72b45f6ce0f173e79c3357")
                        .SetInvocationEvents(InstabugInvocationEvent.FloatingButton, InstabugInvocationEvent.Shake)
                        .Build();

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}