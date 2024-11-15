using System.ComponentModel;

namespace GenZFavouriteSocialMedia;

public class SfNeumorphicContentView : ContentView
{
    internal readonly Grid grid;

	internal readonly GraphicsView graphicsView;

    public static readonly BindableProperty DrawableProperty = BindableProperty.Create(nameof(Drawable), typeof(SfNeumorphismDrawer), typeof(SfNeumorphicContentView), defaultValue: null, propertyChanged: OnDrawablePropertyChanged);

    public static readonly new BindableProperty ContentProperty = BindableProperty.Create(nameof(Content), typeof(View), typeof(SfNeumorphicContentView), defaultValue: null, propertyChanged: OnContentPropertyChanged);
    
    public SfNeumorphismDrawer Drawable
    {
        get { return (SfNeumorphismDrawer)GetValue(DrawableProperty); }
        set { SetValue(DrawableProperty, value); }
    }

    public new View Content
    {
        get { return (View)GetValue(ContentProperty); }
        set { SetValue(ContentProperty, value); }
    }
    
    public SfNeumorphicContentView()
	{
        graphicsView = new GraphicsView();
        graphicsView.SetBinding(GraphicsView.DrawableProperty, new Binding() { Path = nameof(Drawable), Source = this });
        grid = new Grid() { };
        grid.Children.Add(graphicsView);
        base.Content = grid;
	}

    static void OnDrawablePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is SfNeumorphicContentView view)
        {
            if (view.graphicsView == null) return;

            if (oldValue is SfNeumorphismDrawer oldDrawer)
            {
                oldDrawer.PropertyChanged -= view.Drawer_PropertyChanged;
                oldDrawer.Parent = null;
            }

            if (newValue is SfNeumorphismDrawer newDrawer)
            {
                newDrawer.PropertyChanged += view.Drawer_PropertyChanged;
                newDrawer.Parent = view;
            }

            view.graphicsView.Drawable = newValue as IDrawable;
            view.graphicsView.Invalidate(); // Redraws the content
        }
    }

    void Drawer_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        graphicsView.Invalidate();
    }

    static void OnContentPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is SfNeumorphicContentView view)
        {
            if (oldValue is View oldView)
            {
                if (view.grid.Children.Contains(oldView))
                {
                    view.grid.Children.Remove(oldView);
                }
            }

            if (newValue is View newView)
            {
                if (!view.grid.Children.Contains(newView))
                {
                    view.grid.Children.Add(newView);
                }
            }
        }
    }
}

