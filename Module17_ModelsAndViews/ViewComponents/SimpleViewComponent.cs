namespace Module17_ModelsAndViews.ViewComponents;

public class SimpleViewComponent
{
    public string Invoke()
    {
        return (2 + 2).ToString();
       // return nameof(SimpleViewComponent);
    }
}