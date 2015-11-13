# d.Web
Web Session and Cache helper

//get key from session
int someKey1 = d.Web.Helper.Session.Get<int>("someKey");
int someKey2 = HttpContext.Current.Session.Get<int>("someKey");

//if key not exists return value from function and insert to cache
int someKey3 = d.Web.Helper.Session.TryGet<int>("someKey", () => { return 0; });
int someKey4 = d.Web.Helper.Session.TryGet<int>("someKey", CreateNewSessionFunction );



//get key from cache
int someKey1 = d.Web.Helper.Cache.Get<int>("someKey");
int someKey2 = HttpRuntime.Cache.Get<int>("someKey");

//if key not exists return value from function and insert to cache
int someKey3 = d.Web.Helper.Cache.TryGet<int>("someKey", () => { return 0; });
int someKey4 = HttpRuntime.Cache.TryGet<int>("someKey", new TimeSpan(1000), CreateNewCacheFunction);
