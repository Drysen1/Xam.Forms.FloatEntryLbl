using CoreGraphics;
using FloatingEntry.CustomRenderers;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof(ClearEntry), typeof(FloatingEntry.iOS.Renderers.ClearEntryRenderer))]
namespace FloatingEntry.iOS.Renderers
{
    public class ClearEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                Control.BackgroundColor = UIColor.Clear;
                Control.BorderStyle = UITextBorderStyle.None;
            }
        } 
    }
}
