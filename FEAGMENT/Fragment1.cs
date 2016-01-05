using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using  Android.Support.V4.App;
namespace FEAGMENT
{
    public class Fragment1 : Android.Support.V4.App.Fragment
    {
        string tag = "mytap";
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Log.Info(tag, "AAAAAAAAAA____onCreate");
            // Create your fragment here
        }

        public override void OnAttach(Activity activity)
        {
            base.OnAttach(activity);
            Log.Info(tag, "AAAAAAAAAA____OnAttach");
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Log.Info(tag, "AAAAAAAAAA____OnCreateView");
            return inflater.Inflate(Resource.Layout.A, container, false);
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            Log.Info(tag, "AAAAAAAAAA____ OnActivityCreated");
            base.OnActivityCreated(savedInstanceState);
        }
        public override void OnStart()
        {
            base.OnStart();
        }

        public override void OnResume()
        {
            base.OnResume();
        }
        public override void OnPause()
        {
            base.OnPause();
        }

    }
}