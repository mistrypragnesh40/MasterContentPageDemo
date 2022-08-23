namespace MasterContentPageDemo.CustomControls;

public partial class MasterContentPage : ContentPage
{
    public MasterContentPage()
    {
        InitializeComponent();
    }

    #region HeaderText & Footer Text

    public static readonly BindableProperty HeaderTextProperty = BindableProperty.Create(
        propertyName: nameof(HeaderText),
        returnType: typeof(string),
        declaringType: typeof(MasterContentPage),
        defaultValue: ""
        );

    public string HeaderText
    {
        get=> (string)GetValue(HeaderTextProperty);
        set=> SetValue(HeaderTextProperty, value);
    }


    public static readonly BindableProperty HeaderLogoProperty = BindableProperty.Create(
       propertyName: nameof(HeaderLogo),
       returnType: typeof(string),
       declaringType: typeof(MasterContentPage),
       defaultValue: "dotnet_bot"
       );

    public string HeaderLogo
    {
        get => (string)GetValue(HeaderLogoProperty);
        set => SetValue(HeaderLogoProperty, value);
    }



    public static readonly BindableProperty FooterTextProperty = BindableProperty.Create(
       propertyName: nameof(FooterText),
       returnType: typeof(string),
       declaringType: typeof(MasterContentPage),
       defaultValue: ""
       );

    public string FooterText
    {
        get => (string)GetValue(FooterTextProperty);
        set => SetValue(FooterTextProperty, value);
    }

    #endregion
}