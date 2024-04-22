using HtmlCrawl.HtmlCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlCrawl.Contracts
{
    public interface IHtmlOperation
    {
        void PerformOperation(string relativePath, string argument);
    }
}