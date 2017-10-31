using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> lst = new List<string>();
            Console.WriteLine("要素数：" + lst.Count);

            // 要素をテキトーに入れる
            lst.Add("community");
            lst.Add("acquaintance");
            lst.Add("rapid");
            lst.Add("recommendation");
            lst.Add("refreshment");
            lst.Add("trendy");
            lst.Add("pension");
            lst.Add("remuneration");
 
            // 要素数の確認
            Console.WriteLine("要素数：" + lst.Count);
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i] + " ");
            }

            // 検索ワードの指定
            string searchWord = "ation";

            // キーワード検索
            for (int i = 0; i < lst.Count; i++){
                if (lst[i].IndexOf(searchWord,StringComparison.CurrentCulture) != -1)
                {
                    // ヒットしたlstのインデックス番号を表示
                    Console.WriteLine("インデックス番号：" + i);
                }
            }


            /*以降は、無視していいです。*/
            // サイトからコピペしたもの
            // https://msdn.microsoft.com/ja-jp/library/ms224425(v=vs.110).aspx
            string s1 = "ani\u00ADmal";
            string s2 = "animal";

            Console.WriteLine("Culture-sensitive comparison:");
            // Use culture-sensitive comparison to find the soft hyphen.
            Console.WriteLine(s1.IndexOf("\u00AD", StringComparison.CurrentCulture));
            Console.WriteLine(s2.IndexOf("\u00AD", StringComparison.CurrentCulture));

            // Use culture-sensitive comparison to find the soft hyphen followed by "n".
            Console.WriteLine(s1.IndexOf("\u00ADn", StringComparison.CurrentCulture));
            Console.WriteLine(s2.IndexOf("\u00ADn", StringComparison.CurrentCulture));

            // Use culture-sensitive comparison to find the soft hyphen followed by "m".
            Console.WriteLine(s1.IndexOf("\u00ADm", StringComparison.CurrentCulture));
            Console.WriteLine(s2.IndexOf("\u00ADm", StringComparison.CurrentCulture));

            Console.WriteLine("Ordinal comparison:");
            // Use ordinal comparison to find the soft hyphen.
            Console.WriteLine(s1.IndexOf("\u00AD", StringComparison.Ordinal));
            Console.WriteLine(s2.IndexOf("\u00AD", StringComparison.Ordinal));

            // Use ordinal comparison to find the soft hyphen followed by "n".
            Console.WriteLine(s1.IndexOf("\u00ADn", StringComparison.Ordinal));
            Console.WriteLine(s2.IndexOf("\u00ADn", StringComparison.Ordinal));

            // Use ordinal comparison to find the soft hyphen followed by "m".
            Console.WriteLine(s1.IndexOf("\u00ADm", StringComparison.Ordinal));
            Console.WriteLine(s2.IndexOf("\u00ADm", StringComparison.Ordinal));

        }
    }
}
