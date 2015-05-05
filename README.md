# MvcSiteMapProvider_TwoSiteExample
Project to show my usage of hostName across two sites. See read me and stack overflow question.

3 Projects
 - MVC4 Website "Site1"
 - MVC4 Website "other Site"
 - Class Library "MVC Site Map Helper"

 Goal: 
 - Find a way to have two MVC sites using MvcSiteMapProvider using breadcrumbs to navigate between them where the logical 
 structure of the sites are interlinked

 Purpose: 
 - Basically 2 websites to demonstrate cross MVC site links in breadcrumb trail when using MvcSiteMapProvider.
 - When running locally (on local machine) with IIS express (assumed) the hostName attribute works as I expect it to. 
 - However when running on a live server (e.g. www.sites.com/site1 and www.sites.com/otherSite) then the extra /site1 and /otherSite don't play well. 
 - Might be my usage of hostName or just the way it is. 

 Usage: 
 - preservedRouteParameters - in my application these are used and so added this in to simulate (even though not used)
 - hostName - is set in SiteMapHelper.SiteMapResolver.... change depending on debug/release and release site. 
 - Debug: just run and links are ok
 - Publish: Select Release build, right click each project, publish, suitable info. 
 - Published: from {site}/otherSite/Home/About..... 
	- notice that breadcrumb to 'Site 1 Home' is 
	- {site}/otherSite/Home/Index/1 BUT should be: 
	- {site}/Site1/Home/Index/1
