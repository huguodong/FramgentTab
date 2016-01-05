using Android.OS;
using Android.Support.V4.App;
using Android.Util;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FEAGMENT
{
    public class FragmentTabAdapter : Java.Lang.Object, RadioGroup.IOnCheckedChangeListener
    {
        private IntPtr handler;
        private List<Fragment> fragments;//一个tab页面对应一个Fragment
        private RadioGroup rgs;// 用于切换tab
        private FragmentActivity fragmentactivity;// Fragment所属的Activity
        private int fragmentcontentid;// Activity中所要被替换的区域的id
        private int currentTab;// 当前Tab页面索引
        private OnRgsExtraCheckedChangedListener onRgsExtraCheckedChangedListener; // 用于让调用者在切换tab时候增加新的功能
        public FragmentTabAdapter(FragmentActivity fragmentActivity, List<Fragment> fragments, int fragmentContentId, RadioGroup rgs)
        {
            this.fragments = fragments;
            this.rgs = rgs;
            this.fragmentactivity = fragmentActivity;
            this.fragmentcontentid = fragmentContentId;

            // 默认显示第一页
            FragmentTransaction ft = fragmentActivity.SupportFragmentManager.BeginTransaction();
            ft.Add(fragmentContentId, fragments[0]);
            ft.Commit();
            rgs.SetOnCheckedChangeListener(this);
          
        }
        
        public void OnCheckedChanged(RadioGroup group, int checkedId)
        {
            for (int i = 0; i < rgs.ChildCount; i++)
            {
                if (rgs.GetChildAt(i).Id == checkedId)
                {
                    Fragment fragment = fragments[i];
                    FragmentTransaction ft = obtainFragmentTransaction(i);

                    GetCurrentFragment().OnPause();
                    if (fragment.IsAdded)
                    {
                        fragment.OnResume();
                    }
                    else
                    {
                        ft.Add(fragmentcontentid, fragment);
                    }
                    showTab(i);// 显示目标tab
                    ft.Commit();

                    if (null != onRgsExtraCheckedChangedListener)
                    {
                        onRgsExtraCheckedChangedListener.OnRgsExtraCheckedChanged(group, checkedId, i);
                    }
                }
            }
        }

        /// <summary>
        /// 切换tabl
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private void showTab(int idx)
        {
            for (int i = 0; i < fragments.Count; i++)
            {
                Fragment fragment = fragments[i];
                FragmentTransaction ft = obtainFragmentTransaction(idx);
                if (idx == i)
                {
                    ft.Show(fragment);
                }
                else
                {
                    ft.Hide(fragment);
                }
                ft.Commit();
            }
            currentTab = idx;
        }

        private FragmentTransaction obtainFragmentTransaction(int index)
        {
            FragmentTransaction ft = fragmentactivity.SupportFragmentManager.BeginTransaction();
            if (index > currentTab)
            {
                ft.SetCustomAnimations(Resource.Animation.slide_left_in, Resource.Animation.slide_left_out);
            }
            else
            {
                ft.SetCustomAnimations(Resource.Animation.slide_right_in, Resource.Animation.slide_right_out);
            }
            return ft;
        }

        public int GetCurrentTab()
        {
            return currentTab;
        }

        public OnRgsExtraCheckedChangedListener GetOnRgsExtraCheckedChangedListener()
        {
            return onRgsExtraCheckedChangedListener;
        }
        public Fragment GetCurrentFragment()
        {
            return fragments[currentTab];
        }
        public void SetOnRgsExtraCheckedChangedListener(OnRgsExtraCheckedChangedListener onRgsExtraCheckedChangedListener)
        {
            this.onRgsExtraCheckedChangedListener = onRgsExtraCheckedChangedListener;
        }
        public class OnRgsExtraCheckedChangedListener
        {
            public void OnRgsExtraCheckedChanged(RadioGroup radioGroup, int checkedId, int index)
            {
                string tag = "mytag";
                Log.Info(tag, "Extra---- " + index + " checked!!! ");
            }
        }
    }
}
