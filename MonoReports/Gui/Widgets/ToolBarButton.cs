// 
// ToolBarButton.cs
//  
// Author:
//       Tomasz Kubacki <tomasz.kubacki (at) gmail.com>
// 
// Copyright (c) 2010 Tomasz Kubacki
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// code copied from Jonathan Pobst Pinta 

using System;
using Gtk;
using Gdk;

namespace MonoReports.Gui.Widgets
{
	public class ToolBarButton : ToolButton
	{
		public ToolBarButton (string image, string label, string tooltip) : base (null, label)
		{
			Gtk.Image i = new Gtk.Image ( GetIcon (image));
			i.Show ();
			this.IconWidget = i;			
			
			TooltipText = tooltip;
			
			Show ();
		}
		
		public static Pixbuf GetIcon (string name)
		{
			// First see if it's a built-in gtk icon, like gtk-new
			if (Gtk.IconTheme.Default.HasIcon (name))
				return Gtk.IconTheme.Default.LoadIcon (name, 16, Gtk.IconLookupFlags.UseBuiltin);
			
			// Get it from our embedded resources
			return Gdk.Pixbuf.LoadFromResource (name);
		}
	}
}
