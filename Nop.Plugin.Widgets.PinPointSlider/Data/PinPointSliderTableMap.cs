using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nop.Data.Mapping;
using Nop.Plugin.Widgets.PinPointSlider.Domains;

namespace Nop.Plugin.Widgets.PinPointSlider.Data
{
    public partial class PinPointSliderTableMap : NopEntityTypeConfiguration<PinPointSliderTable>
    {
        public override void Configure(EntityTypeBuilder<PinPointSliderTable> builder)
        {
            builder.ToTable(nameof(PinPointSliderTable));

            builder.HasKey(m => m.PinPointId);

            builder.Property(m => m.Title);
            builder.Property(m => m.Description);
            builder.Property(m => m.Url);
            builder.Property(m => m.Lat);
            builder.Property(m => m.Lng);
            builder.Property(m => m.ImagePinPointId);
        }
    }
}
