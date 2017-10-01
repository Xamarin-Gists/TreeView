using Android.App;
using Android.Widget;
using Android.OS;
using Com.Unnamed.B.Atv.View;
using Com.Unnamed.B.Atv.Model;
using Android.Views;

namespace TreeView
{
    [Activity(Label = "TreeView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.ActivitySelectableNodes);
            ViewGroup containerView = (ViewGroup)FindViewById(Resource.Id.container);
            TreeNode parent = new TreeNode("MyParentNode");

            TreeNode child00 = new TreeNode("ChildNode00");
            TreeNode child01 = new TreeNode("ChildNode01");
            TreeNode child0 = new TreeNode("ChildNode0");

            TreeNode child10 = new TreeNode("ChildNode10");
            TreeNode child11 = new TreeNode("ChildNode11");
            TreeNode child1 = new TreeNode("ChildNode1");

            child0.AddChildren(child00, child01);
            child1.AddChildren(child10, child11);
            parent.AddChildren(child0, child1);
            AndroidTreeView tView = new AndroidTreeView(ApplicationContext, parent);
            containerView.AddView(tView.View);
        }
    }
}

