using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace helloworld
{
    [Activity(Label = "helloworld", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
                protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button btnHola = FindViewById<Button>(Resource.Id.button1);

            btnHola.Click += BtnHola_Click;
            
        }

        void BtnHola_Click(object sender, EventArgs e)
        {
            TextView txtHola = FindViewById<TextView>(Resource.Id.txtHola);
            txtHola.Text = "Hola Mundo";
        }
    }
}

