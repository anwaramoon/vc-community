﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;
using coreModel = VirtoCommerce.Domain.Quote.Model;
using VirtoCommerce.Platform.Core.Common;

namespace VirtoCommerce.QuoteModule.Web.Controllers.Api
{
	public class SearchCriteriaBinder : IModelBinder
	{

		#region IModelBinder Members

		public bool BindModel(System.Web.Http.Controllers.HttpActionContext actionContext, ModelBindingContext bindingContext)
		{
			if (bindingContext.ModelType != typeof(coreModel.QuoteRequestSearchCriteria))
			{
				return false;
			}

			var qs = HttpUtility.ParseQueryString(actionContext.Request.RequestUri.Query as string);

			var result = new coreModel.QuoteRequestSearchCriteria();

			result.Keyword = qs["q"].EmptyToNull();
            result.Status = qs["status"].EmptyToNull();
            result.Tag = qs["tag"].EmptyToNull();	
			result.StoreId = qs["site"].EmptyToNull();
			result.CustomerId = qs["customer"].EmptyToNull();
			result.Count = qs["count"].TryParse(20);
			result.Start = qs["start"].TryParse(0);
			bindingContext.Model = result;
			return true;
		}

		#endregion
	}
}