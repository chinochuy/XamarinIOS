using System;
using ARKit;

namespace ArKitSampleApp.ArKitRelated.Delegates
{
    public class ArSCNViewDelegate : ARSCNViewDelegate
    {
        public ArSCNViewDelegate()
        {
        }

        public override void DidAddNode(SceneKit.ISCNSceneRenderer renderer, SceneKit.SCNNode node, ARAnchor anchor)
        {
            System.Diagnostics.Debug.WriteLine("NODE ADDED! ");
        }

        public override void DidUpdateNode(SceneKit.ISCNSceneRenderer renderer, SceneKit.SCNNode node, ARAnchor anchor)
        {
            System.Diagnostics.Debug.WriteLine("NODE UPDATED! ");
        }

        public override void DidRemoveNode(SceneKit.ISCNSceneRenderer renderer, SceneKit.SCNNode node, ARAnchor anchor)
        {
            System.Diagnostics.Debug.WriteLine("NODE REMOVED! ");
        }

        public override void DidApplyAnimations(SceneKit.ISCNSceneRenderer renderer, double timeInSeconds)
        {
            System.Diagnostics.Debug.WriteLine("ANIMATION ADDED! ");
        }

    }
}
