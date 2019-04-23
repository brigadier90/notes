using System;
using DesignPatterns.BridgePattern.Abtraction;
using DesignPatterns.BridgePattern.ConcreteAbstraction;
using DesignPatterns.BridgePattern.Implementation;

namespace DesignPatterns.BridgePattern.ConcreteAbstraction
{
    public class ShortFormView : View
    {
        public IResource Resource;

        public ShortFormView(IResource Resource)
        {
            this.Resource = Resource;
        }

        public override string Show()
        {
            return String.Format("<h1>{0}</h1>\n<img>{1}</img>",
            Resource.Title(),
            Resource.Image());

        }
    }
}
