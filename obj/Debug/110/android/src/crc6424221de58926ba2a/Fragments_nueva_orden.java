package crc6424221de58926ba2a;


public class Fragments_nueva_orden
	extends androidx.fragment.app.Fragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onCreateView:(Landroid/view/LayoutInflater;Landroid/view/ViewGroup;Landroid/os/Bundle;)Landroid/view/View;:GetOnCreateView_Landroid_view_LayoutInflater_Landroid_view_ViewGroup_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("appOrdenTecnica.Fragments.Fragments_nueva_orden, appOrdenTecnica", Fragments_nueva_orden.class, __md_methods);
	}


	public Fragments_nueva_orden ()
	{
		super ();
		if (getClass () == Fragments_nueva_orden.class)
			mono.android.TypeManager.Activate ("appOrdenTecnica.Fragments.Fragments_nueva_orden, appOrdenTecnica", "", this, new java.lang.Object[] {  });
	}


	public Fragments_nueva_orden (int p0)
	{
		super (p0);
		if (getClass () == Fragments_nueva_orden.class)
			mono.android.TypeManager.Activate ("appOrdenTecnica.Fragments.Fragments_nueva_orden, appOrdenTecnica", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public android.view.View onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2)
	{
		return n_onCreateView (p0, p1, p2);
	}

	private native android.view.View n_onCreateView (android.view.LayoutInflater p0, android.view.ViewGroup p1, android.os.Bundle p2);

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
