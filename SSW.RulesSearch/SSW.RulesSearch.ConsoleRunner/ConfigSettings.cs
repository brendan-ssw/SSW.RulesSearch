﻿namespace SSW.RulesSearch.ConsoleRunner
{
    public static class ConfigSettings
    {

        public static string SeqUrl => System.Configuration.ConfigurationManager.AppSettings["SeqUrl"];
  
        public static string RulesIndexPath => System.Configuration.ConfigurationManager.AppSettings["RulesIndexPath"];

        public static string SharePointUrl => System.Configuration.ConfigurationManager.AppSettings["SharePointUrl"];

        public static string ElasticSearchUrl => System.Configuration.ConfigurationManager.AppSettings["ElasticSearchUrl"];
    }
}
