using System;
using ARKit;
using SceneKit;
using ArKitSampleApp.ArKitRelated.Delegates;

namespace ArKitSampleApp.ArKitRelated
{
    public class ArSceneGenerator
    {
        public void GenerateArScene(ARSCNView sceneView)
        {
            var scene = SCNScene.FromFile("art.scnassets/ship");

            sceneView.Scene = scene;

            //sceneView.DebugOptions = ARSCNDebugOptions.ShowWorldOrigin
            //| ARSCNDebugOptions.ShowFeaturePoints;

            sceneView.Session.Delegate = new ArSessionDelegate();
        }

        public void PositionSceneObject(ARSCNView sceneView)
        {
            var configuration = new ARWorldTrackingConfiguration
            {
                PlaneDetection = ARPlaneDetection.Horizontal,
                LightEstimationEnabled = true
            };

            sceneView.Session.Run(configuration, ARSessionRunOptions.ResetTracking);

            var shipNode = sceneView.Scene.RootNode.FindChildNode("ship", true);

            shipNode.Position = new SCNVector3(0.0f, 0.0f, -20f);

            sceneView.Scene.RootNode.AddChildNode(shipNode);

            shipNode.RunAction(SCNAction.RepeatActionForever(SCNAction.RotateBy(0f, 4f, 0, 5)));
        }
    }
}
