package md5f9778e3d239eb9290a3434f362da2688;


public class Fragment2_Onclicklistener
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		android.view.View.OnClickListener
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler:Android.Views.View/IOnClickListenerInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("FEAGMENT.Fragment2+Onclicklistener, FEAGMENT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Fragment2_Onclicklistener.class, __md_methods);
	}


	public Fragment2_Onclicklistener () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Fragment2_Onclicklistener.class)
			mono.android.TypeManager.Activate ("FEAGMENT.Fragment2+Onclicklistener, FEAGMENT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
