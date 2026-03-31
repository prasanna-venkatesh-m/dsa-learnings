using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class Most_CommonWord
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            string[] splitted = paragraph.Split(
                new char[] { ' ', ',', '!', '?', '\'', ';', '.', ':' },
                StringSplitOptions.RemoveEmptyEntries
            );
            var countedList = splitted.Select(x => x.ToLower())
                .GroupBy(x => x)
                .Select(g=> new
                {
                    word = g.Key,
                    count = g.Count()
                })
                .Where(x=> !banned.Contains(x.word))
                .OrderByDescending(x=>x.count)
                .Select(x=>x.word)
                .FirstOrDefault();
            return countedList;
        }
    }
}
