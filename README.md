# d.Web Web Session and Cache helper
```
//get key from session 
d.Web.Helper.Session.Get<int>("someKey");
HttpContext.Current.Session.Get<int>("someKey");

//if key not exists return value from function and insert to cache
d.Web.Helper.Session.TryGet<int>("someKey", () => { return 0; });
d.Web.Helper.Session.TryGet<int>("someKey", CreateNewSessionFunction );


//get key from cache
d.Web.Helper.Cache.Get<int>("someKey");
HttpRuntime.Cache.Get<int>("someKey");

//if key not exists return value from function and insert to cache
d.Web.Helper.Cache.TryGet<int>("someKey", () => { return 0; });
HttpRuntime.Cache.TryGet<int>("someKey", new TimeSpan(1000), CreateNewCacheFunction);
```

# d.Web Web Form helper
```
//get value from HttpContext.Current.Request.QueryString
d.Web.Helper.Form.QueryValue<int>("someKey");
d.Web.Helper.Form.QueryValue<decimal>("someKey", "",",");
d.Web.Helper.Form.QueryValue<DateTime>("someKey", "yyyyMMdd");

//get value from  HttpContext.Current.Request.Params
d.Web.Helper.Form.PostValue<string>("someKey");
d.Web.Helper.Form.PostValue<decimal>("someKey", "", ",");
d.Web.Helper.Form.PostValue<DateTime>("someKey", "yyyyMMdd");
```