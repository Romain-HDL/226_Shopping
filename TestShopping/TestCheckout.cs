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
        public void Balance_EmptyCheckout_Success()
        {
            //given
            //refer to Setup
            float _expectedBalance = 0;
            Assert.That(_checkout.Articles.Count(), Is.EqualTo(0));

            //when
            //Event will be triggered by constructor

            //then
            Assert.That(_checkout.Articles.Count(), Is.EqualTo(0));
            Assert.That(_checkout.Balance, Is.EqualTo(_expectedBalance));
        }

        [Test]
        public void Add_FirstArticle_Success()
        {
            //given
            //refer to Setup
            float _expectedBalance = 1;
            Assert.That(_checkout.Articles.Count(), Is.EqualTo(0));

            //when
            _checkout.Add(ArticleGenerator.Generate(1));

            //then
            Assert.That(_checkout.Articles.Count(), Is.EqualTo(1));
            Assert.That(_checkout.Balance, Is.EqualTo(_expectedBalance));
        }

        [Test]
        public void Remove_OneArticleFromCheckoutWithArticles_Success()
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