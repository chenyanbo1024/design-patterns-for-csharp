using System;

namespace Core.Builder
{
    public class UrlBuilder
    {
        private readonly string SSL_SCHEME = "https://";
        private readonly string NO_SSL_SCHEME = "http://";

        private bool IsSSL;
        private string Domiain;
        private string Path;
        private string Query;

        public UrlBuilder SetSSL(bool isSSL)
        {
            IsSSL = isSSL;
            return this;
        }

        public UrlBuilder SetDomain(string domain)
        {
            Domiain = domain;
            return this;
        }

        public UrlBuilder SetPath(string path)
        {
            Path = path;
            return this;
        }

        public UrlBuilder SetQuery(string query)
        {
            Query = query;
            return this;
        }

        public string Build()
        {
            string url = string.Empty;
            if (IsSSL)
            {
                url += SSL_SCHEME;
            }
            else
            {
                url += NO_SSL_SCHEME;
            }

            if (string.IsNullOrEmpty(Domiain))
            {
                throw new ArgumentNullException();
            }
            else
            {
                url += Domiain;
            }

            if (!string.IsNullOrEmpty(Path))
            {
                url += Path;
            }

            if (!string.IsNullOrEmpty(Query))
            {
                url += "?" + Query;
            }
            return url;
        }
    }
}