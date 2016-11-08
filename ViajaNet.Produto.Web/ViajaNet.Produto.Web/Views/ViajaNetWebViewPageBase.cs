﻿using System.Web.Mvc;

namespace ViajaNet.Produto.Web.Views
{
    public abstract class ViajaNetWebViewPageBase : ViajaNetWebViewPageBase<dynamic>
    {

    }

    public abstract class ViajaNetWebViewPageBase<TModel> : WebViewPage<TModel>
    {

        public string ApplicationPath
        {
            get {
                return Request.ApplicationPath;
            }
        }
        protected ViajaNetWebViewPageBase()
        {
        }

  

    }
}