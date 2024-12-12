# Building a Neumorphic Column Chart to Visualize Gen Z's Favorite Social Media Platforms

We're excited to demonstrate how to build a visually stunning Neumorphic Column Chart using the [Syncfusion .NET MAUI Charts control](https://www.syncfusion.com/maui-controls/maui-cartesian-charts). This chart provides a modern, sleek way to visualize Gen Z's favorite social media platforms while integrating Neumorphic design principles. 

## Column Chart

Column charts are ideal for representing and comparing categorical data. With vertical bars to display values, they are intuitive and widely used for data visualization.

## Add Neumorphic Effects to the Chart
[Syncfusion’s .NET MAUI Cartesian Chart](https://www.syncfusion.com/maui-controls/maui-cartesian-charts) supports customizing the chart's appearance with creative designs. To achieve a Neumorphic look, follow these steps:

### Background Design
Customize the chart’s background with a Neumorphic effect using a combination of shadows and gradients. Wrap the chart in a NeumorphicContentView for this design.

### Custom Column Segments
Create a Neumorphic effect for column segments by applying shadows and gradients that adapt to light and dark themes.

## Apply Gradient Backgrounds to Chart
The Neumorphic style is brought to life using gradient backgrounds for the column segments. Use the LinearGradientBrush to define a smooth gradient that responds dynamically to theme changes. Adjust StartPoint and EndPoint for the gradient’s direction and use GradientStop elements to define precise color transitions.

## Customizing the Chart for Light and Dark Themes
Adapt the chart seamlessly to light and dark modes using AppThemeBinding. This ensures the Neumorphic design remains consistent and visually appealing across different themes.

## Visual Appeal
This Neumorphic Column Chart stands out with:

* Dynamic Neumorphic design.
* Gradient-filled column segments.
* Light and dark theme adaptability.

![ScreenCapture_20-11-202423 59 00-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/c8f893f9-dc8d-45e5-babd-0ade445bf0b4)

## Troubleshooting
#### Path too long exception
If you encounter a Path Too Long Exception while building the project:

  1. Close Visual Studio.
  2. Rename the repository to a shorter name.
  3. Rebuild the project.

## For a step-by-step procedure
Refer to the blog, ["Visualizing Gen Z's Favorite Social Media Platforms with a Neumorphic UI in .NET MAUI"](https://www.syncfusion.com/blogs/post/neumorphic-ui-net-maui-column-chart) for detailed instructions and code examples.
