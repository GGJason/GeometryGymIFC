using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GeometryGym.Ifc;
using Microsoft.Win32;
using System.Diagnostics;
namespace WPFGetAllGeometryType
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ifc|*.ifc";
            ofd.ShowDialog();

            DatabaseIfc db = new DatabaseIfc(ofd.FileName);
            IfcProject project = db.Project;
            IfcSpatialElement rootElement = project.RootElement;
            List<IfcBuildingElement> elements = project.Extract<IfcBuildingElement>();
            List<IfcFacetedBrep> breps = new List<IfcFacetedBrep>();
            foreach (IfcBuildingElement element in elements)
            {
                //outputLabel.Content += element.Name+ "\n";
                IfcProductRepresentation representation = element.Representation;
                if (representation != null)
                {
                    foreach (IfcRepresentation rep in representation.Representations)
                    {
                        IfcShapeRepresentation sr = rep as IfcShapeRepresentation;
                        if (sr != null)
                        {
                            foreach (IfcRepresentationItem item in sr.Items)
                            {
                                var ifcTopologicalRepItem = item as IfcTopologicalRepresentationItem;
                                var ifcGeometricRepItem = item as IfcGeometricRepresentationItem;
                                var ifcMappedItem = item as IfcMappedItem;
                                var ifcStyledItem = item as IfcStyledItem;
                                if (ifcTopologicalRepItem != null)
                                {
                                    var ifcConnectedFaceSet = ifcTopologicalRepItem as IfcConnectedFaceSet;
                                    var ifcEdge = ifcTopologicalRepItem as IfcEdge;
                                    var ifcFace = ifcTopologicalRepItem as IfcFace;
                                    var ifcFaceBound = ifcTopologicalRepItem as IfcFaceBound;
                                    var ifcPath = ifcTopologicalRepItem as IfcPath;
                                    var ifcVertex = ifcTopologicalRepItem as IfcVertex;
                                    var ifcLoop = ifcTopologicalRepItem as IfcLoop;

                                }
                                else if (ifcGeometricRepItem != null)
                                {
                                    var ifcCompositeCurveSegment = ifcGeometricRepItem as IfcCompositeCurveSegment;
                                    var ifcCurve = ifcGeometricRepItem as IfcCurve;
                                    var ifcDirection = ifcGeometricRepItem as IfcDirection;
                                    var ifcPlacement = ifcGeometricRepItem as IfcPlacement;
                                    var ifcPoint = ifcGeometricRepItem as IfcPoint;
                                    var ifcSurface = ifcGeometricRepItem as IfcSurface;
                                    var ifcVector = ifcGeometricRepItem as IfcVector;
                                    var ifcBooleanResult = ifcGeometricRepItem as IfcBooleanResult;
                                    var ifcSolidModel = ifcGeometricRepItem as IfcSolidModel;
                                    var ifcHalfSpaceSolid = ifcGeometricRepItem as IfcHalfSpaceSolid;
                                    var ifcBoundingBox = ifcGeometricRepItem as IfcBoundingBox;
                                    var ifcCartesianTransformationOperator = ifcGeometricRepItem as IfcCartesianTransformationOperator;
                                    var ifcSectionedSpine = ifcGeometricRepItem as IfcSectionedSpine;
                                    var ifcGeometricSet = ifcGeometricRepItem as IfcGeometricSet;
                                    var ifcFaceBasedSurfaceModel = ifcGeometricRepItem as IfcFaceBasedSurfaceModel;
                                    var ifcShellBasedSurfaceModel = ifcGeometricRepItem as IfcShellBasedSurfaceModel;
                                }
                                else if (ifcMappedItem != null)
                                {
                                    var mapSource = ifcMappedItem.MappingSource;
                                    var mapTarget = ifcMappedItem.MappingTarget;
                                    foreach(var mappedItem in mapSource.MappedRepresentation.Items)
                                    {
                                        var itm = mappedItem as IfcExtrudedAreaSolid;
                                        Debug.WriteLine(itm.Depth);
                                        Debug.WriteLine(itm.SweptArea.ProfileName);
                                       
                                    }
                                }
                                else if (ifcStyledItem != null)
                                {

                                }
                            }

                        }
                    }
                }
            }
        }
    }
}
