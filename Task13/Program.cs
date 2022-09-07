string text = "Once upon a midnight dreary, while I pondered, weak and weary," +
"Over many a quaint and curious volume of forgotten lore—"+
"While I nodded, nearly napping, suddenly there came a tapping," +
"As of some one gently rapping, rapping at my chamber door.";
string Replace (string text, char OldValue, char NewValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text [i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text [i]}";
    }
    return result;
}

string NewText = Replace (text, ' ', '|');
Console.WriteLine (NewText);
Console.WriteLine ();
string NewNewText = Replace (NewText, 'w', 'W');
Console.WriteLine (NewNewText);
