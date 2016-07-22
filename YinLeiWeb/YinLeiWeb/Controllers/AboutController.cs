using Common.DAL;
using Common.Model.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YinLeiWeb.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/

        public ActionResult Index()
        {
            Resume model = new Resume();
            //model.Name = "尹磊";
            //model.Sex = "男";
            //model.Phone = "15521025350";
            //model.IsMarry = true;
            //model.Email = "963928480@qq.com";
            //model.Age = 22;
            //model.Birthday = Convert.ToDateTime("1994-07");
            //model.Address = "广州市天河区";
            //model.Birthplace = "湖南省邵阳市";
            //model.JobStatus = "目前在职，考虑换个环境";
            //model.SelfEvaluate = "有责任心，认真完成上级安排工作，热爱编程，对科学技术有浓厚的兴趣。目前从事ASP.NET方面的工作，并对Web前端技术有着浓厚的兴趣，努力自学HTML5 + CSS3 + JavaSrcipt中。";

            TestDB db = new TestDB();
            //db.CreateDateBase();
            //db.Insert(model);
            model = db.GetResume(11);
            return View(model);
        }

        public ActionResult Photo()
        {
            return View();
        }

        public ActionResult Message()
        {
            return View();
        }
    }
}
