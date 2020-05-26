using Nop.Core;

namespace Nop.Plugin.Widgets.PinPointSlider.Domains
{
    public partial class PinPointSliderTable : BaseEntity
    {
        public int PinPointId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int ImagePinPointId { get; set; }
    }
}
