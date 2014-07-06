﻿using Esri.ArcGISRuntime.Geometry;
using Windows.UI.Xaml.Controls;

namespace ArcGISRuntimeSDKDotNet_StoreSamples.Samples
{
    /// <summary>
	/// Shows how to set the initial extent of the map (Map.InitialViewpoint).
    /// </summary>
    /// <title>Set Initial Map Extent</title>
    /// <category>Mapping</category>
	public sealed partial class SetInitialMapExtent : Page
    {
        public SetInitialMapExtent()
        {
            InitializeComponent();

            // Note: uncomment the following to set the initial extent of the map in code.
			//mapView.Map.InitialViewpoint = new Envelope(-117.182686,32.695853,-117.133872,32.718530, SpatialReferences.Wgs84); 
        }
    }
}
