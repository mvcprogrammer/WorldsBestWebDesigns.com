using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldsBestWebDesigns.com.Models
{
    public class WorldsBestRequest
    {

    }

    public class SeoData
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }

        public SeoData(string title, string description, string keywords)
        {
            Title = title;
            Description = description;
            Keywords = keywords;
        }

        public SeoData()
        {
            Title = "Title:Invaid";
            Description = "Description:Invalid";
            Keywords = "Keywords:Invalid";
        }
    }

    public class OgData
    {
        public string SiteName { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }

        public OgData()
        {
            SiteName = "WorldsBestWebDesigns.com";
            Type = "Website";
            Url = "www.worldsbestwebdesigns.com";
            Description = "Website and Custom Software Designs";
            Title = "World's Best Web Designs - If you can dream it, I can build it.";
            Image = "http://www.worldsbestwebdesigns.com/assets/img/abt.gif";
        }
    }

    public class WorldsBestResponse
    {
        public SeoData SeoData { get; set; }
        public OgData OgData { get; set; }

        public WorldsBestResponse()
        {
            SeoData = new SeoData();
            OgData = new OgData();
        }
    }

    
}