namespace Domas.Web.Mvc.UI
{
    using System.Collections.Generic;
    using Domas.Web.Mvc.Infrastructure;
    using Domas.Web.Mvc.Extensions;

    internal class ChartAxisTicksSerializer : IChartSerializer
    {
        private readonly ChartAxisTicks ticks;

        public ChartAxisTicksSerializer(ChartAxisTicks ticks)
        {
            this.ticks = ticks;
        }

        public virtual IDictionary<string, object> Serialize()
        {
            var result = new Dictionary<string, object>();

            FluentDictionary.For(result)
                .Add("size", ticks.Size, () => ticks.Size.HasValue)
                .Add("visible", ticks.Visible, () => ticks.Visible.HasValue);

            return result;
        }
    }
}