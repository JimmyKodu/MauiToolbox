namespace MauiToolbox.Pages;

public class WelcomePage : ContentPage
{
	public WelcomePage()
	{
		Title = "��ӭ";

		Padding = 12;

		Content = new VerticalStackLayout
		{
			Spacing = 12,

			Children = {
                new Label { HorizontalOptions = LayoutOptions.Center, Text = "��ӭʹ�� .NET MAUI ������", FontSize = 32
                },
                new Label { HorizontalOptions = LayoutOptions.Center, Text = "ʹ�����Ͻǵĵ����˵��������", FontSize = 16
                }
            }
		};
	}
}