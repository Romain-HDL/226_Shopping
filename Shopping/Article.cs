namespace Shopping
{
    public class Article
    {
        #region private attributes
        private float _price = 0f;
        #endregion private attributes

        #region public methods
        public Article(float price)
        {
            _price = price;
        }
        public float Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        #endregion public methods
    }
}
