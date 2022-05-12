using Microsoft.Maui.Controls.Shapes;

namespace MauiIssueClipArcSegment;

public partial class MainPage : ContentPage
{	public MainPage()
	{
		InitializeComponent();

        var geometry = new PathGeometry();

        var figure = new PathFigure();
        figure.IsClosed = true;

        figure.Segments.Add(new LineSegment(new Point(100, 0)));
        figure.Segments.Add(new ArcSegment(new Point(100, 100), new Size(50), 0, SweepDirection.Clockwise, false));
        figure.Segments.Add(new LineSegment(new Point(0, 100)));

        geometry.Figures.Add(figure);

        box.Clip = geometry;
    }
}

