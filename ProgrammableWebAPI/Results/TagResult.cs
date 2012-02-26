using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProgrammableWebAPI.Models;
using ProgrammableWebAPI.Headers;
using HtmlAgilityPack;
using Fizzler;
using Fizzler.Systems.HtmlAgilityPack;

namespace ProgrammableWebAPI.Results
{
    public class TagResult
    {
        public TagHeader Header { get; set; }
        public List<Tag> Entries { get; set; }

        public TagResult()
        {
            Header = new TagHeader();

            string url = "http://www.programmableweb.com/mashup-tag-cloud";

            var webGet = new HtmlWeb();
            var html = webGet.Load(url);
            var document = html.DocumentNode;

            var nodes = document.QuerySelectorAll(".box10 > a.tsxl3").ToList();

            Entries = (from node in nodes
                       where node.InnerText != String.Empty
                       select new Tag(node.InnerText)).ToList();

        }
    }
}
