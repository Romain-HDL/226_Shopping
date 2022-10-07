using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            throw new NotImplementedException();
        }

        public List<Article> Remove(Boolean empty = false)
        {
            throw new NotImplementedException();
        }

        public List<Article> Articles
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion public methods
    }
}
