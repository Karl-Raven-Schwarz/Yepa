package crc64b11c0cf8ce3f302d;


public class URLSpanNoUnderline
	extends android.text.style.URLSpan
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onClick:(Landroid/view/View;)V:GetOnClick_Landroid_view_View_Handler\n" +
			"n_updateDrawState:(Landroid/text/TextPaint;)V:GetUpdateDrawState_Landroid_text_TextPaint_Handler\n" +
			"";
		mono.android.Runtime.register ("Yepa.Droid.Renderers.URLSpanNoUnderline, Yepa.Android", URLSpanNoUnderline.class, __md_methods);
	}


	public URLSpanNoUnderline (android.os.Parcel p0)
	{
		super (p0);
		if (getClass () == URLSpanNoUnderline.class)
			mono.android.TypeManager.Activate ("Yepa.Droid.Renderers.URLSpanNoUnderline, Yepa.Android", "Android.OS.Parcel, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public URLSpanNoUnderline (java.lang.String p0)
	{
		super (p0);
		if (getClass () == URLSpanNoUnderline.class)
			mono.android.TypeManager.Activate ("Yepa.Droid.Renderers.URLSpanNoUnderline, Yepa.Android", "System.String, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onClick (android.view.View p0)
	{
		n_onClick (p0);
	}

	private native void n_onClick (android.view.View p0);


	public void updateDrawState (android.text.TextPaint p0)
	{
		n_updateDrawState (p0);
	}

	private native void n_updateDrawState (android.text.TextPaint p0);

	private java.util.ArrayList refList;
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
