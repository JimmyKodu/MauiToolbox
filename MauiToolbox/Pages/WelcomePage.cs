namespace MauiToolbox.Pages;

public class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		Title = "欢迎";

		Padding = 12;

		Content = new VerticalStackLayout
		{
			Spacing = 12,

			Children = {
                new Label { HorizontalOptions = LayoutOptions.Center, Text = "欢迎使用 .NET MAUI 工具箱", FontSize = 32
                },
                new Label { HorizontalOptions = LayoutOptions.Center, Text = "使用左上角的弹出菜单浏览功能", FontSize = 16
                }
            }
		};
	}
}