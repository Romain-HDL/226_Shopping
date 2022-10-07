using Shopping;

namespace TestShopping
{
    public class TestCheckout
    {
        #region private attributes
        private Checkout? _checkout = null;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _checkout = new Checkout();
        }

        [Test]
        public void Add_FirstArticle_Success()
        {
            //given
            //refer to Setup
            Assert.That(_checkout.Articles.Count(), Is.EqualTo(0));

            //when
            _checkout.Add(ArticleGenerator.Generate(1));

            //then
            Assert.That(_checkout.Articles.Count(), Is.EqualTo(1));
        }

        [Test]
        public void Remove_OneArticleFromCartWithArticles_Success()
        {
            //given
            //refer to Setup
            int amountOfArticlesToAdd = 10;
            List<Article> expectedArticles = ArticleGenerator.Generate(amountOfArticlesToAdd);
            List<Article> actualArticles = new List<Article>();

            _checkout.Add(expectedArticles);
            Assert.AreEqual(expectedArticles.Count(), _checkout.Articles.Count());

            //when
            actualArticles = _checkout.Remove();

            //then
            Assert.AreEqual(expectedArticles.Count(), actualArticles.Count());
            Assert.AreEqual(amountOfArticlesToAdd-1, _checkout.Articles.Count());
        }

        [Test]
        public void Remove_AllProductsFromCartWithArticles_Success()
        {
            //given
            //refer to Setup
            int amountOfArticlesToAdd = 10;
            List<Article> expectedArticles = ArticleGenerator.Generate(amountOfArticlesToAdd);
            List<Article> actualArticles = new List<Article>();
            
            _checkout.Add(expectedArticles);
            Assert.AreEqual(expectedArticles.Count(), _checkout.Articles.Count());

            //when
            actualArticles = _checkout.Remove();

            //then
            Assert.AreEqual(expectedArticles.Count(), actualArticles.Count());
            Assert.AreEqual(0, _checkout.Articles.Count());
        }
    }
}