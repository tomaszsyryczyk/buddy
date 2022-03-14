using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TS.Common.Datalayer
{
    public static class EFConfigurationExtensions
    {
        public static PropertyBuilder<TEnum> AsString<TEnum>(this PropertyBuilder<TEnum> property)
        where TEnum : struct
        {
            return property.HasConversion(new EnumToStringConverter<TEnum>());
        }
        public static PropertyBuilder MoneyType(this PropertyBuilder property)
        {
            return property.HasColumnType("decimal(18,2)");
        }
    }
}
