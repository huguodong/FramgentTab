using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using System.Collections.Generic;

namespace FEAGMENT
{
    [Activity(Label = "FEAGMENT", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : FragmentActivity 
    {
        int count = 1;
        private RadioGroup rgs;
        public List<Android.Support.V4.App.Fragment> fragments = new List<Android.Support.V4.App.Fragment>();
        public string hello = "hello";
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            fragments.Add(new Fragment1());
            fragments.Add(new Fragment2());
            fragments.Add(new Fragment3());
            fragments.Add(new Fragment4());
            fragments.Add(new Fragment5());
            rgs = FindViewById<RadioGroup>(Resource.Id.tabs_rg);
            
            FragmentTabAdapter tabadapter = new FragmentTabAdapter(this, fragments, Resource.Id.tab_content, rgs);
   
            tabadapter.SetOnRgsExtraCheckedChangedListener(new FEAGMENT.FragmentTabAdapter.OnRgsExtraCheckedChangedListener());
        }
    }
}

