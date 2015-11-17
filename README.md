# d.Web Web Session and Cache helper
<pre><code>
//get key from session <br />
d.Web.Helper.Session.Get<int>("someKey");<br />
HttpContext.Current.Session.Get<int>("someKey");<br />
<br />
//if key not exists return value from function and insert to cache<br />
d.Web.Helper.Session.TryGet<int>("someKey", () => { return 0; });<br />
d.Web.Helper.Session.TryGet<int>("someKey", CreateNewSessionFunction );<br />
<br />
<br />
//get key from cache<br />
d.Web.Helper.Cache.Get<int>("someKey");<br />
HttpRuntime.Cache.Get<int>("someKey");<br />
<br />
//if key not exists return value from function and insert to cache<br />
d.Web.Helper.Cache.TryGet<int>("someKey", () => { return 0; });<br />
HttpRuntime.Cache.TryGet<int>("someKey", new TimeSpan(1000), CreateNewCacheFunction);<br />
<pre><code>

# d.Web Web Form helper<br />
<br />
//get value from HttpContext.Current.Request.QueryString<br />
d.Web.Helper.Form.QueryValue<int>("someKey");<br />
d.Web.Helper.Form.QueryValue<decimal>("someKey", "",",");<br />
d.Web.Helper.Form.QueryValue<DateTime>("someKey", "yyyyMMdd");<br />
<br />
//get value from  HttpContext.Current.Request.Params<br />
d.Web.Helper.Form.PostValue<string>("someKey");<br />
d.Web.Helper.Form.PostValue<decimal>("someKey", "", ",");<br />
d.Web.Helper.Form.PostValue<DateTime>("someKey", "yyyyMMdd");<br />