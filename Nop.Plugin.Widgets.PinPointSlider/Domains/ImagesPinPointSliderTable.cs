using Nop.Core;

namespace Nop.Plugin.Widgets.PinPointSlider.Domains
{
    public partial class ImagesPinPointSliderTable : BaseEntity
    {
        public int ImagePinPointId { get; set; }
        public string Title { get; set; }
        public string Alt { get; set; }
        public string Url { get; set; }
        public double ImageWidth { get; set; }
        public double ImgaeHeight { get; set; }
    }
}
