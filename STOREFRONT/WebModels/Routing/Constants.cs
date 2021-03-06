﻿using System.Text.RegularExpressions;
using System;

namespace VirtoCommerce.Web.Models.Routing
{
    public static class Constants
    {
        #region Constants
        /// <summary>
        ///     The category route key
        /// </summary>
        public const string Category = "category";

        /// <summary>
        ///     The item route key
        /// </summary>
        public const string Item = "item";

        public const string Page = "page";

        /// <summary>
        ///     The language route key
        /// </summary>
        public const string Language = "lang";

        public const string Tags = "tags";

        /// <summary>
        ///     The language regex
        /// </summary>
        public static Regex LanguageRegex = new Regex("^([a-zA-Z]{2}(-[a-zA-Z]{2})?)$", RegexOptions.Compiled);

        /// <summary>
        ///     The store route key
        /// </summary>
        public const string Store = "store";
        #endregion

        #region Public Properties
        public static string PageRoute
        {
            get
            {
                return string.Format("{0}/{{{1}}}", StoreRoute, Page);
            }
        }

        /// <summary>
        ///     Gets the category route. {lang}/{store}/{category}
        /// </summary>
        /// <value>
        ///     The category route.
        /// </value>
        public static string CategoryRoute
        {
            get
            {
                return string.Format("{0}/{{{1}}}", StoreRoute, Category);
            }
        }

        /// <summary>
        ///     Gets the item route. {lang}/{store}/{category}/{item}
        /// </summary>
        /// <value>
        ///     The item route.
        /// </value>
        public static string ItemRoute
        {
            get
            {
                return string.Format("{0}/{{{1}}}", CategoryRoute, Item);
            }
        }

        /// <summary>
        ///     Gets the store route. {lang}/{store}
        /// </summary>
        /// <value>
        ///     The store route.
        /// </value>
        public static string StoreRoute
        {
            get
            {
                return string.Format("{{{0}}}/{{{1}}}", Language, Store);
            }
        }

        #endregion
    }
}