public interface IButton
{
    void Action();
}

public class BoldButton : IButton
{
    private TextEditor textEditor;
    public BoldButton(TextEditor textEditor)
    {
        this.textEditor = textEditor;
    }

    public void Action()
    {
        textEditor.BoldText();
    }
}

public class ItalicizeButton : IButton
{
    private TextEditor textEditor;

    public ItalicizeButton(TextEditor textEditor)
    {
        this.textEditor = textEditor;
    }

    public void Action()
    {
        textEditor.ItalicizeText();
    }
}


public class TextEditor
{
    public void BoldText()
    {
        Console.WriteLine("This text is bolded....");
    }

    public void ItalicizeText()
    {
        Console.WriteLine("This text is italicize....");
    }

    public void UnderLined()
    {
        Console.WriteLine("This text is Underlined....");
    }
}

public class WithoutCommandPattern
{
    static void Main()
    {
        TextEditor textEditor = new TextEditor();

        IButton button = new BoldButton(textEditor);
        button.Action();
    }
}