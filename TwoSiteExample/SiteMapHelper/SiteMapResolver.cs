using System.Web;
using MvcSiteMapProvider;

namespace TwoSiteExample.MvcSiteMap.SiteMapHelper
{
    public class SiteMapResolver
    {
        // Public methods
        public void Resolve()
        {
            // Get the site map.
            var sm = SiteMaps.GetSiteMap();

            // Get all the nodes.
            var nodes = sm.GetDescendants(sm.RootNode);

            // Setup each node, using route values to determine settings.
            NodeConfig(sm.RootNode);
            foreach (var node in nodes)
            {
                NodeConfig(node);
            }
        }
        private void NodeConfig(ISiteMapNode node)
        {
            if (node == null) return;

            switch (node.Key)
            {
               // Access Level
                case "Home_Index_External":
                    node.Title = "Site 1 Home";                    
                    node.RouteValues["id"] = 1;
                    node.HostName = "localhost:59346";
                    //node.HostName = "site/site1"; 
                    node.Clickable = true;
                    break;
                case "Home_Index":
                    node.Title = "Site 1 Home";
                    node.Clickable = true;
                    break;
                case "Home_Contact":
                    node.Title = "Site 1 Contact";
                    node.Clickable = true;
                    break;
                case "Home_About":                    
                    node.Title = "Other site About";
                    node.Clickable = true;
                    break;
            }
        }
    }
}
