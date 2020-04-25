# OrchardSkills.OrchardCore.Taxonomies

Using Taxonomies in Orchard Core CMS

Disqus module for Orchard Core. Allows you to add a Disqus comment section to a content type.

## Original Authors GitHub Repository

[Antoine Griffard agriffard Disqus.OrchardCore](https://github.com/agriffard/Disqus.OrchardCore)

## Getting Started

* Add a Disqus Part in the Definition of the Content Type on which you want to add Disqus comments (BlogPosts)
* Edit the settings of the Disqus Part and enter the name of the site that you created at https://disqus.com/.
* Add {{ Model.Content.DisqusPart | shape_render }} to the bottom of the Content-BlogPost.liquid file.
* Set the Base Url (ex: https://localhost:5001 ) in /Admin/Settings/general so that the urls will be absolute.
