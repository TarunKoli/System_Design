public interface ICommand
{
    void Execute();
}

public class TextEditor
{
    public void BoldText()
    {
        Console.WriteLine("This text is bolded.....");
    }

    public void ItalicizeText()
    {
        Console.WriteLine("This text is italicized.....");
    }

    public void UnderlineText()
    {
        Console.WriteLine("This text is underlined.....");
    }
}

public class BoldCommand : ICommand
{
    private TextEditor textEditor;

    public BoldCommand(TextEditor textEditor)
    {
        this.textEditor = textEditor;
    }

    public void Execute()
    {
        textEditor.BoldText();
    }
}

public class ItalicizeCommand : ICommand
{
    private TextEditor textEditor;
    public ItalicizeCommand(TextEditor textEditor)
    {
        this.textEditor=textEditor;
    }

    public void Execute()
    {
        textEditor.ItalicizeText();
    }
}

public class Button
{
    private ICommand command;
    
    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    public void Click()
    {
        command.Execute();
    }
}

public class WithCommandPattern
{
    static void Main()
    {
        TextEditor textEditor = new TextEditor();

        ICommand boldCommand = new BoldCommand(textEditor);

        Button button = new Button();
        button.SetCommand(boldCommand);
        button.Click();
    }
}