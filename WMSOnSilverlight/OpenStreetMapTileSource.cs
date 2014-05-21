using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Maps.MapControl;

namespace WMSOnSilverlight {
    
        public class OpenStreetMapTileSource : TileSource {
            public OpenStreetMapTileSource()
                : base("http://tile.openstreetmap.org/{2}/{0}/{1}.png") {
            }

            public override Uri GetUri(int x, int y, int zoomLevel) {
                return new Uri(String.Format(this.UriFormat, x, y, zoomLevel));
            }
        } 


    
}
