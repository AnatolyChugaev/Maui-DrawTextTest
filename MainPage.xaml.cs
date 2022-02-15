namespace DrawTextTest;

public partial class MainPage : ContentPage {

	public MainPage() {
		InitializeComponent();
	}
}


public class GraphicsDrawable : IDrawable {

    public void Draw(ICanvas canvas, RectangleF dirtyRect) {
		canvas.FontColor = Colors.Blue;
		canvas.FontSize = 18;

		canvas.SetToSystemFont();
		canvas.DrawString("Text is left aligned.", 20, 20, 380, 100, HorizontalAlignment.Left, VerticalAlignment.Top);
		canvas.DrawString("Text is centered.", 20, 60, 380, 100, HorizontalAlignment.Center, VerticalAlignment.Top);
		canvas.DrawString("Text is right aligned.", 20, 100, 380, 100, HorizontalAlignment.Right, VerticalAlignment.Top);

		canvas.SetToBoldSystemFont();
		canvas.DrawString("This text is displayed using the bold system font.", 20, 140, 350, 100, HorizontalAlignment.Left, VerticalAlignment.Top);

		canvas.FontName = "Arial";
		canvas.FontColor = Colors.Black;
		canvas.SetShadow(new SizeF(6, 6), 4, Colors.Gray);
		canvas.DrawString("This text has a shadow.", 20, 200, 300, 100, HorizontalAlignment.Left, VerticalAlignment.Top);
	}
}
