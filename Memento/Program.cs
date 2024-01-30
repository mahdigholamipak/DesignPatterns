namespace Memento;

class Program
{
    static void Main(string[] args)
    {
        var editor = new Editor();

        editor.Type("This is the first sentence.");
        editor.Type("This is second.");

        editor.Save();

        editor.Type("This is third.");

        Console.WriteLine(editor.Content);

        editor.Restore();

        Console.Write(editor.Content);
    }
}


class EditorMemento
{
    private string _content;

    public EditorMemento(string content)
    {
        _content = content;
    }

    public string Content
    {
        get
        {
            return _content;
        }
    }
}


class Editor
{

    private string _content = string.Empty;
    private EditorMemento _memento;

    public Editor()
    {
        _memento = new EditorMemento(string.Empty);
    }

    public void Type(string words)
    {
        _content = String.Concat(_content, " ", words);
    }

    public string Content
    {
        get
        {
            return _content;
        }
    }

    public void Save()
    {
        _memento = new EditorMemento(_content);
    }

    public void Restore()
    {
        _content = _memento.Content;
    }
}




