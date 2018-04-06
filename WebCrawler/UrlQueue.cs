﻿namespace WebCrawler
{
    public class UrlQueue : SecurityQueue<UrlInfo>
    {
        #region Constructors and Destructors

        /// <summary>
        /// Prevents a default instance of the <see cref="UrlQueue"/> class from being created.
        /// </summary>
        private UrlQueue()
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets the instance.实例
        /// </summary>
        public static UrlQueue Instance
        {
            get
            {
                return Nested.Inner;
            }
        }

        #endregion

        /// <summary>
        /// The nested.
        /// </summary>
        private static class Nested
        {
            #region Static Fields

            /// <summary>
            /// The inner.
            /// </summary>
            internal static readonly UrlQueue Inner = new UrlQueue();

            #endregion
        }
    }
}
