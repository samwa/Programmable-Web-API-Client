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
    public class CategoryResult
    {
        public CategoryHeader Header { get; set; }
        public List<Category> Entries { get; set; }

        public CategoryResult()
        {
            Header = new CategoryHeader();

            string url = "http://www.programmableweb.com/apis/directory";

            var webGet = new HtmlWeb();
            var html = webGet.Load(url);
            var document = html.DocumentNode;

            var nodes = document.QuerySelectorAll("#fapicat option").ToList();
            
            Entries = (from node in nodes 
                       where node.Attributes["value"] != null 
                        && node.Attributes["value"].Value != String.Empty
                       select new Category(node.Attributes["value"].Value)).ToList();                
        }
    }
}
