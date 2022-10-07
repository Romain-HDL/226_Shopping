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
            _articles.AddRange(articles);
        }

        public List<Article> Remove(Boolean clearCart = false)
        {
            if (clearCart == true) 
            {
                List<Article> articlesReadyToCheckout = new List<Article>();
                articlesReadyToCheckout.AddRange(_articles);
                _articles.Clear();
                return articlesReadyToCheckout;
            }
            else
            {
                List<Article> articlesReadyToCheckout = new List<Article>();
                articlesReadyToCheckout.Add(_articles.Last());
                _articles.Remove(_articles.Last());
                return articlesReadyToCheckout;
            }            
        }

        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
        }
        #endregion public methods
    }
}
