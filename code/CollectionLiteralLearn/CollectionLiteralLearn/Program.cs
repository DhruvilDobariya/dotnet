using System;
using System.Collections.Generic;

namespace CollectionLiteralLearn
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>() { "red", "blue", "green" };
            List<string> newList = ["red", "blue", "green"];

            Span<string> newSpan = ["purple", "lime", "cyan"];

            List<string> colors = [.. newList, "pink", .. newSpan]; // merge collection
            // colors = ["red", "blue", "green", "pink", "purple", "lime", "cyan"]

            Dictionary<string, string> dict = new Dictionary<string, string>()
            {
                {"Name", "Dhruvil Dobariya" },
                {"City", "Rajkot" },
                {"State", "Gujarat" },
                {"Country", "India" }
            };

            //Dictionary<string, string> newDict = [
            //    "Name": "Dhruvil Dobariya", 
            //    "City": "Rajkot", 
            //    "State": "Gujarat", 
            //    "Country": "India"
            //];
            // Currently not implemented but targeted for C#12
        }
    }
}
