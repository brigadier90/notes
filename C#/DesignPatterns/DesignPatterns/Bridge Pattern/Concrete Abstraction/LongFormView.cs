using System;
using DesignPatterns.BridgePattern.Abtraction;
using DesignPatterns.BridgePattern.ConcreteAbstraction;
using DesignPatterns.BridgePattern.Implementation;

namespace DesignPatterns.BridgePattern.ConcreteAbstraction
{
    public class LongFormView : View
    {
        public IResource Resource;

        public LongFormView(IResource Resource)
        {
            this.Resource = Resource;
        }

        public override string Show()
        {
            return String.Format("<h1>{0}</h1>\n<img>{1}</img>\n<p>{2}</p>\n<p>{3}</p>",
            Resource.Title(),
            Resource.Image(),
            Resource.Snippet(),
            Resource.Url());

        }
    }
}
