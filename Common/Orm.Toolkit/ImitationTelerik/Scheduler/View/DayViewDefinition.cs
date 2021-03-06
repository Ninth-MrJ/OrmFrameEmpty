using System.Windows;
using Orm.Toolkit.Telerik.Windows.Controls.Scheduler;

namespace Orm.Toolkit.Telerik.Windows.Controls
{
    /// <summary>
    /// Represents a definition of a view that shows a single day in day view mode.
    /// </summary>
    public class DayViewDefinition : MultidayViewDefinition
    {

        static DayViewDefinition()
        {
            VisibleDaysProperty.OverrideMetadata(typeof(DayViewDefinition), new PropertyMetadata(1));
            LargeChangeIntervalProperty.OverrideMetadata(
                typeof(DayViewDefinition), new PropertyMetadata(DateTimeInterval.FromDays(1)));
        }

        // ReSharper disable RedundantOverridenMember
        // Added for changing the comment for default values

        /// <summary>
        /// Gets or sets large change interval. It indicates date time interval with which current view will be
        /// increased or decreased. This is a dependency property.
        /// </summary>
        /// <value></value>
        /// <returns><see cref="DateTimeInterval"/> for large change. The default value is 1 day.</returns>
        public override DateTimeInterval LargeChangeInterval
        {
            get
            {
                return base.LargeChangeInterval;
            }
            set
            {
                base.LargeChangeInterval = value;
            }
        }

        /// <summary>
        /// Gets or sets visible days count for this view. It indicates how many dates this view will display.
        /// This is a dependency property.
        /// </summary>
        /// <returns>Visible days count for this view. The default value is 1.</returns>
        public override int VisibleDays
        {
            get
            {
                return base.VisibleDays;
            }
            set
            {
                base.VisibleDays = value;
            }
        }

        // ReSharper restore RedundantOverridenMember
    }
}