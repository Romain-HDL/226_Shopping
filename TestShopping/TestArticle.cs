using Shopping;

namespace TestShopping
{
    public class TestArticle
    {
        #region private attributes
        private Article _article = null;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _article = new Article();
        }

        [Test]
        public void Price_AfterInstantiation_Success()
        {
            //given
            //refer to Setup
            float expectedPrice = 20.45f;

            //when
            _cart.Add(ArticleGenerator.Generate(1));

            //then
            Assert.That(_cart.Articles.Count(), Is.EqualTo(1));
        }

        [Test]
        public void Remove_OneArticleFromCartWithArticles_Success()
        {
            //given
            //refer to Setup
            int amountOfArticlesToAdd = 10;
            List<Article> expectedArticles = ArticleGenerator.Generate(amountOfArticlesToAdd);
            List<Article> actualArticles = new List<Article>();

            _cart.Add(expectedArticles);
            Assert.AreEqual(expectedArticles.Count(), _cart.Articles.Count());

            //when
            actualArticles = _cart.Remove();

            //then
            Assert.AreEqual(expectedArticles.Count(), actualArticles.Count());
            Assert.AreEqual(amountOfArticlesToAdd-1, _cart.Articles.Count());
        }

        [Test]
        public void Remove_AllProductsFromCartWithArticles_Success()
        {
            //given
            //refer to Setup
            int amountOfArticlesToAdd = 10;
            List<Article> expectedArticles = ArticleGenerator.Generate(amountOfArticlesToAdd);
            List<Article> actualArticles = new List<Article>();
            
            _cart.Add(expectedArticles);
            Assert.AreEqual(expectedArticles.Count(), _cart.Articles.Count());

            //when
            actualArticles = _cart.Remove();

            //then
            Assert.AreEqual(expectedArticles.Count(), actualArticles.Count());
            Assert.AreEqual(0, _cart.Articles.Count());
        }
    }
}