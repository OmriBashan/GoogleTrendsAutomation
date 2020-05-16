using System;
using System.Collections.Generic;
using System.Text;
using GoogleTrendsExcersie;
using Infrastructure;

namespace Extensions
{
    public static class QueryPageExtensions
    {
        public static QueryHeader SearchCountry(this QueryPage page, string country)
        {
            return page
                .Header.PickCountry(country);

        }
        public static RegionComponenent InterstByLocation(this QueryPage page,string location)
        {
            return page.Region.ByLocation(location);


        }

        public static RelatedQueriesComponent FindRelatedLocation(this QueryPage page)
        {
            return page.RelatedQueries.FindRelatedQueriesOverDistrict();


        }

    }
}
