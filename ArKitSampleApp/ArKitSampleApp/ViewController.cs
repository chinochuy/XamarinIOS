using System;
using ARKit;
using ArKitSampleApp.ArKitRelated;
using UIKit;

namespace ArKitSampleApp
{
    public partial class ViewController : UIViewController
    {
        private ArSceneGenerator _aRSceneGenerator;
        public ARSCNView SceneView
        {
            get { return View as ARSCNView; }
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            _aRSceneGenerator = new ArSceneGenerator();
            _aRSceneGenerator.GenerateArScene(SceneView);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            _aRSceneGenerator.PositionSceneObject(SceneView);
        }


        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
            SceneView.Session.Pause();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        public override bool ShouldAutorotate()
        {
            return true;
        }

        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations()
        {
            return UIInterfaceOrientationMask.All;
        }
    }
}
