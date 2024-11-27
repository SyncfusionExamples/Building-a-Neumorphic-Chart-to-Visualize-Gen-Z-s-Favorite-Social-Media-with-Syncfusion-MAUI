using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GenZFavouriteSocialMedia
{
    public class SfNeumorphismDrawer : Element, IDrawable
    {
        public static readonly BindableProperty BackgroundProperty = BindableProperty.Create(nameof(Background), typeof(Brush), typeof(SfNeumorphismDrawer), defaultValue: new SolidColorBrush(Colors.Transparent));

        public static readonly BindableProperty StrokeProperty = BindableProperty.Create(nameof(Stroke), typeof(SolidColorBrush), typeof(SfNeumorphismDrawer), defaultValue: new SolidColorBrush(Colors.Transparent));

        public static readonly BindableProperty StrokeWidthProperty = BindableProperty.Create(nameof(StrokeWidth), typeof(float), typeof(SfNeumorphismDrawer), defaultValue: 2f);

        public static readonly BindableProperty PaddingProperty = BindableProperty.Create(nameof(Padding), typeof(Thickness), typeof(SfNeumorphismDrawer), defaultValue: new Thickness(0));

        public static readonly BindableProperty ShadowColorProperty = BindableProperty.Create(nameof(ShadowColor), typeof(Color), typeof(SfNeumorphismDrawer), defaultValue: Colors.Transparent);

        public static readonly BindableProperty ShadowOffsetProperty = BindableProperty.Create(nameof(ShadowOffset), typeof(SizeF), typeof(SfNeumorphismDrawer), defaultValue: new SizeF(0, 0));

        public static readonly BindableProperty ShadowBlurProperty = BindableProperty.Create(nameof(ShadowBlur), typeof(float), typeof(SfNeumorphismDrawer), defaultValue: 0f);

        public static readonly BindableProperty CornerRadiusProperty = BindableProperty.Create(nameof(CornerRadius), typeof(CornerRadius), typeof(SfNeumorphismDrawer), defaultValue: new CornerRadius(5));

        [TypeConverter(typeof(BrushTypeConverter))]
        public Brush Background
        {
            get { return (Brush)GetValue(BackgroundProperty); }
            set { SetValue(BackgroundProperty, value); }
        }
        
        public SolidColorBrush Stroke
        {
            get { return (SolidColorBrush)GetValue(StrokeProperty); }
            set { SetValue(StrokeProperty, value); }
        }
        
        public float StrokeWidth
        {
            get { return (float)GetValue(StrokeWidthProperty); }
            set { SetValue(StrokeWidthProperty, value); }
        }
        
        public Thickness Padding
        {
            get { return (Thickness)GetValue(PaddingProperty); }
            set { SetValue(PaddingProperty, value); }
        }
        
        public Color ShadowColor
        {
            get { return (Color)GetValue(ShadowColorProperty); }
            set { SetValue(ShadowColorProperty, value); }
        }
        
        public float ShadowBlur
        {
            get { return (float)GetValue(ShadowBlurProperty); }
            set { SetValue(ShadowBlurProperty, value); }
        }
        
        public SizeF ShadowOffset
        {
            get { return (SizeF)GetValue(ShadowOffsetProperty); }
            set { SetValue(ShadowOffsetProperty, value); }
        }
        
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            var paddingRect = new RectF() { Left = dirtyRect.Left + (float)Padding.Left, Top = dirtyRect.Top + (float)Padding.Top, Right = dirtyRect.Right - (float)Padding.Right, Bottom = dirtyRect.Bottom - (float)Padding.Bottom };
            double cornerRadius = CornerRadius.TopLeft > paddingRect.Width / 2 ? paddingRect.Width / 2 : CornerRadius.TopLeft;
            //To create the Background and Shadow effect
            canvas.SetShadow(ShadowOffset, ShadowBlur, ShadowColor.WithAlpha(0.5f));
            canvas.SetFillPaint(Background, paddingRect);
            canvas.FillRoundedRectangle(paddingRect, cornerRadius);
            //To create the stroke effect for the content view
            var strokeRect = new RectF() { Left = paddingRect.Left - StrokeWidth / 2, Top = paddingRect.Top - StrokeWidth / 2, Right = paddingRect.Right + StrokeWidth / 2, Bottom = paddingRect.Bottom + StrokeWidth / 2 };
            canvas.StrokeColor = Stroke.Color;
            canvas.StrokeSize = StrokeWidth;
            canvas.DrawRoundedRectangle(strokeRect, cornerRadius);
        }
    }
}
