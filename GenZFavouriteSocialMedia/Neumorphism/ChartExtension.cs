using Syncfusion.Maui.Toolkit.Charts;
using System.ComponentModel;

namespace GenZFavouriteSocialMedia
{
    public class SfNeumorphismColumnSeries : ColumnSeries
    {
        public SfNeumorphismDrawer Drawable
        {
            get { return (SfNeumorphismDrawer)GetValue(DrawableProperty); }
            set { SetValue(DrawableProperty, value); }
        }

        public static readonly BindableProperty DrawableProperty =
            BindableProperty.Create(nameof(Drawable), typeof(SfNeumorphismDrawer), typeof(SfNeumorphismColumnSeries), defaultValue: null, propertyChanged: OnDrawablePropertyChanged);

        protected override ChartSegment CreateSegment()
        {
            return new SfNeumorphismColumnSegment(Drawable);
        }

        protected static void OnDrawablePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is SfNeumorphismColumnSeries series)
            {
                if (oldValue is SfNeumorphismDrawer oldDrawer)
                {
                    oldDrawer.PropertyChanged -= series.DrawerPropertyChanged;
                    oldDrawer.Parent = null;
                }

                if (newValue is SfNeumorphismDrawer newDrawer)
                {
                    newDrawer.PropertyChanged += series.DrawerPropertyChanged;
                    newDrawer.Parent = series;
                }
            }
        }

        private void DrawerPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
        }
    }

    public class SfNeumorphismColumnSegment : ColumnSegment
    {

        private SfNeumorphismDrawer Drawable;

        public SfNeumorphismColumnSegment(SfNeumorphismDrawer drawable)
        {
            Drawable = drawable;
        }

        protected override void Draw(ICanvas canvas)
        {
            if (Series is ColumnSeries series && series.ActualYAxis is NumericalAxis yAxis)
            {
                var top = yAxis.ValueToPoint(Convert.ToDouble(yAxis.Maximum ?? double.NaN));

                var trackRect = new RectF() { Left = Left, Top = top, Right = Right, Bottom = Bottom };

                Drawable.Draw(canvas, trackRect);
            }

            base.Draw(canvas);
        }

    }
}
