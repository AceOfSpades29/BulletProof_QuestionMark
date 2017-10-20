using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletProof_QuestionMark
{
    class Program
    {
        static void Main(string[] args)
        {
        }


       
        }
    }

public class BulletProof
{
    public object DoStuff(string url, string productPath, string categoryPath)
    {

        string file;

        productPath = productPath?.ToLower();
        categoryPath = categoryPath?.ToLower();

        if (string.IsNullOrWhiteSpace(url))
        {
            throw new ArgumentException("URL cannot be null, empty, or whitespace.");
        }
        else if (!string.IsNullOrWhiteSpace(productPath) && url.ToLower().Contains(productPath))
        {
            file = "GoogleTagManagerScripts/GtmProductDetailsView";
        }
        else if (!string.IsNullOrWhiteSpace(categoryPath) && url.ToLower().Contains(categoryPath))
        {
            file = "GoogleTagManagerScripts/GtmCategoryDetails";
        }
        else
        {
            file = "GoogleTagManagerScripts/GtmMainScript";
        }

        return file;
    }
}
