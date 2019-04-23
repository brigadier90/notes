using System;
namespace DesignPatterns.BridgePattern.Implementation
{
    public interface IResource
    {
        string Snippet();
        string Title();
        string Image();
        string Url();

    }
}
