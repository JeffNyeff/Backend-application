using MvC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace MvC.Controllers
{
    public class PostUpdateController : Controller
    {
        // GET: PostUpdate
        public ActionResult Index()
        {
            IEnumerable<mvcPostUpdateModel> postList; 
            HttpResponseMessage response = GlobalVariables.WepApiClient.GetAsync("Post_Update").Result;  
            postList = response.Content.ReadAsAsync<IEnumerable<mvcPostUpdateModel>>().Result;
            return View(postList);
        } 


    }
}