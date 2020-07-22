namespace QuizProjectMvc.Web.Controllers
{
    using System.Web.Http.Cors;
    using System.Web.Mvc;

    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
