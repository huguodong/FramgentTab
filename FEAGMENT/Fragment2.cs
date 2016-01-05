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

namespace FEAGMENT
{
    public class Fragment2 : Android.Support.V4.App.Fragment
    {
        string tag = "mytag";
        public override void OnCreate(Bundle savedInstanceState)
        {
            Log.Info(tag, "BBBBBBBBBB____ OnCreate");
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }
        public override void OnAttach(Activity activity)
        {
            Log.Info(tag, "BBBBBBBBBB____ OnAttach");
            base.OnAttach(activity);
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            Log.Info(tag, "BBBBBBBBBB____ OnCreateView");
            return inflater.Inflate(Resource.Layout.B, container, false);
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            this.View.FindViewById<Button>(Resource.Id.button1).SetOnClickListener(new Onclicklistener());
    
            base.OnActivityCreated(savedInstanceState);
        }
     public  class Onclicklistener :Java.Lang.Object, View.IOnClickListener
        {

            public void OnClick(View v)
            {
              
            }
        }

    }
}