# WCF_RESTful_WebService
A template for a WCF RESTful web service with all CRUD operations

















<div class="separator" style="clear: both; text-align: center;">
<a href="http://2.bp.blogspot.com/-IfN8UpmUJW4/VkmHdFI_DhI/AAAAAAAALx8/wHtzimEi9vs/s1600/8.png" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img alt="Make a WCF RESTful Web Service with CRUD operations in 5 minutes" border="0" height="130" src="http://2.bp.blogspot.com/-IfN8UpmUJW4/VkmHdFI_DhI/AAAAAAAALx8/wHtzimEi9vs/s640/8.png" width="570" /></a></div>
<div class="separator" style="clear: both; text-align: center;">
Notice that the return value is an array of Data objects and a single Data object, accordingly:</div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">
<a href="http://3.bp.blogspot.com/-4M5h24lfUWI/VkmHdWfB8oI/AAAAAAAALyI/Fn1EeO4O56E/s1600/9.png" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img alt="Make a WCF RESTful Web Service with CRUD operations in 5 minutes" border="0" height="188" src="http://3.bp.blogspot.com/-4M5h24lfUWI/VkmHdWfB8oI/AAAAAAAALyI/Fn1EeO4O56E/s640/9.png" width="570" /></a></div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">
<a href="http://1.bp.blogspot.com/-RRvrjIekiJo/VkmHZ12lAGI/AAAAAAAALyQ/Mu-zaBNJ-M0/s1600/10.png" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img alt="Make a WCF RESTful Web Service with CRUD operations in 5 minutes" border="0" height="216" src="http://1.bp.blogspot.com/-RRvrjIekiJo/VkmHZ12lAGI/AAAAAAAALyQ/Mu-zaBNJ-M0/s640/10.png" width="570" /></a></div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">
<b><u>HTTP POST :</u></b></div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">
The POST HTTP verb is used to CREATE a new item, and we define it using the WebInvoke attribute:</div>

<div class="separator" style="clear: both; text-align: center;">
<a href="http://1.bp.blogspot.com/-_UTq74rKiaM/VkmHZ2RXuzI/AAAAAAAALyE/Y8QuXk-Dx4A/s1600/11.png" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img alt="Make a WCF RESTful Web Service with CRUD operations in 5 minutes" border="0" height="204" src="http://1.bp.blogspot.com/-_UTq74rKiaM/VkmHZ2RXuzI/AAAAAAAALyE/Y8QuXk-Dx4A/s640/11.png" width="570" /></a></div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">
We only want to check that our REST service works, so that just return the same Data object from the request (here i'm using <a href="https://chrome.google.com/webstore/category/apps" target="_blank">POSTMAN </a>to send HTTP requests. You can also use <a href="http://www.telerik.com/download/fiddler" target="_blank">FIDDLER</a>&nbsp;for that):</div>
<div class="separator" style="clear: both; text-align: center;">

</div>

<div class="separator" style="clear: both; text-align: center;">
<a href="http://2.bp.blogspot.com/-23VfmyQwn-E/VkmHaS2sasI/AAAAAAAALwo/v6vQTbhQOwY/s1600/12.png" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img alt="Make a WCF RESTful Web Service with CRUD operations in 5 minutes" border="0" height="638" src="http://2.bp.blogspot.com/-23VfmyQwn-E/VkmHaS2sasI/AAAAAAAALwo/v6vQTbhQOwY/s640/12.png" width="570" /></a></div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">
<span style="color: red;"><u><b>Important:</b></u>&nbsp;the JSON object in the request's body must hold the field's data with exactly the same field names set in the DataMembers in your service: it is case-sensitive ("Id" means "Id", and no "id", got it?).</span></div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">
<b><u>HTTP PUT:</u></b></div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">
The PUT HTTP VERB is used to update the entire item, i.e. to replace it with an updated one, and we do so by using the WebInvoke PUT option as follows:</div>
<div class="separator" style="clear: both; text-align: center;">

</div>

<div class="separator" style="clear: both; text-align: center;">
<a href="http://1.bp.blogspot.com/-0jJoMkMUr0s/VkmHaQ8l_YI/AAAAAAAALyU/wEhRkTl6tX4/s1600/13.png" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img alt="Make a WCF RESTful Web Service with CRUD operations in 5 minutes" border="0" height="174" src="http://1.bp.blogspot.com/-0jJoMkMUr0s/VkmHaQ8l_YI/AAAAAAAALyU/wEhRkTl6tX4/s640/13.png" width="570" /></a></div>
<div class="separator" style="clear: both; text-align: center;">
The binder will give you the Date object from the request, if the names of the fields being the same as the class in a case-sensitive way, and also will give you the ID of the item to update. Check that you wrote EXACTLY the same variable name for this : "Put/{id}" == string "id" .</div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">
Test this method from POSTMAN sending an PUT request with a JSON object in the body:</div>
<div class="separator" style="clear: both; text-align: center;">

</div>

<div class="separator" style="clear: both; text-align: center;">
<a href="http://2.bp.blogspot.com/-vd57UUfPTfc/VkmHaqFyAGI/AAAAAAAALw0/5YGLrX4AfKY/s1600/14.png" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img alt="Make a WCF RESTful Web Service with CRUD operations in 5 minutes" border="0" height="610" src="http://2.bp.blogspot.com/-vd57UUfPTfc/VkmHaqFyAGI/AAAAAAAALw0/5YGLrX4AfKY/s640/14.png" width="570" /></a></div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">
<u style="color: red;"><b>Important:</b></u><span style="color: red;">&nbsp;the JSON object inside the request's body must contain the field's data with exactly the same field names set in the DataMembers in your service: it is case-sensitive ("Id" means "Id", and no "id").</span></div>
<div class="separator" style="clear: both; text-align: center;">

</div>

<b><u>HTTP PATCH</u></b> :

The HTTP PATCH verb is used in REST for updating just some of the object's fields:


<div class="separator" style="clear: both; text-align: center;">
<a href="http://4.bp.blogspot.com/-2U6hmgOn8UQ/VkmHahHzRCI/AAAAAAAALws/4uZSi2gwwio/s1600/15.png" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img alt="Make a WCF RESTful Web Service with CRUD operations in 5 minutes" border="0" height="184" src="http://4.bp.blogspot.com/-2U6hmgOn8UQ/VkmHahHzRCI/AAAAAAAALws/4uZSi2gwwio/s640/15.png" width="570" /></a></div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">
Again, test it using this REST call with the HTTP PATCH verb:</div>

<div class="separator" style="clear: both; text-align: center;">
<a href="http://4.bp.blogspot.com/-4HOsvRruqdE/VkmHa_rwGdI/AAAAAAAALxM/z1T38gX50G8/s1600/16.png" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img alt="Make a WCF RESTful Web Service with CRUD operations in 5 minutes" border="0" height="586" src="http://4.bp.blogspot.com/-4HOsvRruqdE/VkmHa_rwGdI/AAAAAAAALxM/z1T38gX50G8/s640/16.png" width="570" /></a></div>
<div class="separator" style="clear: both; text-align: center;">
<b><u>HTTP DELETE</u></b> :</div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">
Finally, create the method to handle HTTP DELETE requests, as follows:</div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">

</div>

<div class="separator" style="clear: both; text-align: center;">
<a href="http://2.bp.blogspot.com/-4rdA3cefYGc/VkmHbFHqx2I/AAAAAAAALw8/-UmmXg8k4PA/s1600/17.png" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img alt="Make a WCF RESTful Web Service with CRUD operations in 5 minutes" border="0" height="168" src="http://2.bp.blogspot.com/-4rdA3cefYGc/VkmHbFHqx2I/AAAAAAAALw8/-UmmXg8k4PA/s640/17.png" width="570" /></a></div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">

</div>
<div class="separator" style="clear: both; text-align: center;">

</div>

<div class="separator" style="clear: both; text-align: center;">
<a href="http://1.bp.blogspot.com/-5Y9XEJ5pUOw/VkmHbkc9RAI/AAAAAAAALxU/6eiDv-CYuG8/s1600/18.png" imageanchor="1" style="margin-left: 1em; margin-right: 1em;"><img alt="Make a WCF RESTful Web Service with CRUD operations in 5 minutes" border="0" height="380" src="http://1.bp.blogspot.com/-5Y9XEJ5pUOw/VkmHbkc9RAI/AAAAAAAALxU/6eiDv-CYuG8/s640/18.png" width="570" /></a></div>
<div class="separator" style="clear: both; text-align: center;">
