using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using FloatingEntry.CustomRenderers;

[assembly: ExportRenderer (typeof(ClearEntry), typeof(FloatingEntry.Droid.Renderers.ClearEntryRenderer))]
namespace FloatingEntry.Droid.Renderers
{
    class ClearEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
                Control.SetPadding(5,0,0,5);
            }
        }
    }
}