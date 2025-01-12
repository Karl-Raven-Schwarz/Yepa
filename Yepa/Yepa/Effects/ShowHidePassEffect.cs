using Xamarin.Forms;

namespace Yepa.Effects 
{
	public class ShowHidePassEffect : RoutingEffect 
	{
		public string EntryText { get; set; }
		public ShowHidePassEffect() : base("Yepa.ShowHidePassEffect") { }
	}
}
