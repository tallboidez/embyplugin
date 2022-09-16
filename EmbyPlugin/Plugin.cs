using System.ComponentModel;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Drawing;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace EmbyPlugin
{
    public class Plugin : BasePlugin<BasePluginConfiguration>, IHasThumbImage, ILocalMetadataProvider
    {
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
        {
            

        }
        public override string Name => "Actor Scraper";
        public override string Description => "Actor Scraper";

        public override Guid Id => new Guid("3D6A31B7-34D6-4B37-8253-E5BEB0EDCD6C");

        public ImageFormat ThumbImageFormat => ImageFormat.Jpg;

        public Stream GetThumbImage()
        {
            var type = GetType();
            return type.Assembly.GetManifestResourceStream(type.Namespace + ".thumb.jpg");
        }
    }
}