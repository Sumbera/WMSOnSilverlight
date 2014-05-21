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
using System.Text;

namespace WMSOnSilverlight {
    
   
    /// <summary>
    /// WMSTile
    /// </summary>
        public class WMSTile : TileSource {
            public const int TILE_SIZE = 256;
            
            public WMSTile()
                : base(@"http://services.cuzk.cz/wms/wms.asp?&LAYERS=KN&REQUEST=GetMap&SERVICE=WMS&VERSION=1.3.0&FORMAT=image/png&TRANSPARENT=TRUE&STYLES=&CRS=EPSG:900913&WIDTH=256&HEIGHT=256&BBOX={0},{1},{2},{3}")
            {
                
            }
            public override Uri GetUri(int tilePositionX, int tilePositionY, int tileLevel)
            {

                int zoom = tileLevel; //SSU tileLevel would be same as zoom in Bing control
                Rect  mercBounds = GlobalMercator.TileBounds(new Tile(tilePositionX, tilePositionY), tileLevel);
                return new Uri(string.Format(this.UriFormat, mercBounds.Left, Math.Abs(mercBounds.Bottom), mercBounds.Right, Math.Abs(mercBounds.Top)));
            }
         
        } 


    
}
