using Model.DAO;
using OnlineHotel.Areas.Admin.Models;
using OnlineHotel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineHotel.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new ACCOUNT_DAO();
                var result = dao.Login(model.UserName, model.Password);
                if (result == 1)
                {
                    var account = dao.GetById(model.UserName);
                    var accountSession = new AccountLogin();
                    accountSession.UserName = account.UserName;
                    accountSession.AccountID = account.ID;

                    Session.Add(CommonConstants.ACCOUNT_SESSION, accountSession);
                    return RedirectToAction("Index", "Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại.");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập không đúng");
                }
            }
            return View("Index");
        }
    }
}