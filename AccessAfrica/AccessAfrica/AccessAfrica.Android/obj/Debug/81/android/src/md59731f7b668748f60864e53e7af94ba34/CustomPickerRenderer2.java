package md59731f7b668748f60864e53e7af94ba34;


public class CustomPickerRenderer2
	extends md51558244f76c53b6aeda52c8a337f2c37.PickerRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("AccessAfrica.Droid.CustomRenderers.CustomPickerRenderer2, AccessAfrica.Android", CustomPickerRenderer2.class, __md_methods);
	}


	public CustomPickerRenderer2 (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomPickerRenderer2.class)
			mono.android.TypeManager.Activate ("AccessAfrica.Droid.CustomRenderers.CustomPickerRenderer2, AccessAfrica.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public CustomPickerRenderer2 (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomPickerRenderer2.class)
			mono.android.TypeManager.Activate ("AccessAfrica.Droid.CustomRenderers.CustomPickerRenderer2, AccessAfrica.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomPickerRenderer2 (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomPickerRenderer2.class)
			mono.android.TypeManager.Activate ("AccessAfrica.Droid.CustomRenderers.CustomPickerRenderer2, AccessAfrica.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
