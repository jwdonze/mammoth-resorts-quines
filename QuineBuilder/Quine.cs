class Quine
{
    public void B(string s)
    {
        const string pre = "class Program{static void Main(){var s=@\"";
        System.Console.Write(pre);
        int columnNo = 0;
        const int width = 171;
        int fi = pre.Length+1;
        columnNo = pre.Length;
        foreach(char c in s.ToCharArray())
        {
            if (c != 10 && c != 13)
            {
                System.Console.Write(c);
                if (++columnNo >= width)
                {
                    columnNo = 0;
                    System.Console.WriteLine();
                }
            }
        }

        var post = new System.Text.StringBuilder();
        post.Append("\";var rx = new System.Text.RegularExpressions.Regex(\"<Chair[J0-9]*>\");var s2=rx.Replace(s.Replace(\" \",\"\").Replace(\"\\r\", \"\").Replace(\"\\n\", \"\").Replace(\"");
        post.Append(System.Text.Encoding.ASCII.GetString(System.Convert.FromBase64String("PFBvd2Rlcj4=")));
        post.Append("\", \"\\r\").Replace(\"");
        post.Append(System.Text.Encoding.ASCII.GetString(System.Convert.FromBase64String("PERheT4=")));
        post.Append("\", \"\\n\").Replace(\"");
        post.Append(System.Text.Encoding.ASCII.GetString(System.Convert.FromBase64String("PENoYWlySjc+")));
        post.Append("\", \"\\\"\"),\" \");");
        post.Append("var res=Microsoft.CSharp.CSharpCodeProvider.CreateProvider(\"CSharp\").CompileAssemblyFromSource(new System.CodeDom.Compiler.CompilerParameters() { }, new string[] { s2 });var asy = res.CompiledAssembly;asy.GetType(\"Quine\").GetMethod(\"B\").Invoke(asy.CreateInstance(\"Quine\"),new object[]{ s });}} /************* June Mountain Quine in C# Version 6+ - CC BY-NC-SA 4.0 2019 - Jeff Donze jwdonze@gmail.com *****************/");
        var postStringScript = post.ToString();
        var postStringScriptArray  = postStringScript.Split('.');
        for(int index = 0; index < postStringScriptArray.Length; index++)
        {
            var word = postStringScriptArray[index];
            var rem = columnNo + word.Length + 1;
            if (rem > width)
            {
                if (width - columnNo >= 4 && index < postStringScriptArray.Length - 1)
                {
                    System.Console.Write("/" + new string('*', width-columnNo-2) + "/");
                }
                System.Console.WriteLine();
                columnNo = 0;
            }
            System.Console.Write(word);
            columnNo += word.Length;
            if (index < postStringScriptArray.Length - 1)
            {
                System.Console.Write(".");
                columnNo++;
            }
        }
        System.Console.WriteLine();
    }
}
