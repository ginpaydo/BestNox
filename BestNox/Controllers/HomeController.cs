﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BestNox.Models;
using Microsoft.AspNetCore.Authorization;

namespace BestNox.Controllers
{
    /// <summary>
    /// HOME画面：最初に表示する
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// 最初のページ
        /// </summary>
        public IActionResult Index()
        {
            // 引数に何も指定しない場合は、メソッド名と同じ名前のビューを返す。
            return View();
        }

        /// <summary>
        /// プライバシーポリシー
        /// </summary>
        /// <returns></returns>
        public IActionResult Privacy()
        {
            return View();
        }

        /// <summary>
        /// プライバシーポリシー
        /// </summary>
        /// <returns></returns>
        public IActionResult Aaaa()
        {
            return View("Index");
        }

        public IActionResult Bbbb(int id, string ananid)
        {
            // だめ
            var model = new {
                Id = id,
                Ananid = ananid
            };
            
            return View("Index", model);
        }

        public IActionResult Cccc()
        {
            ViewData["Message"] = "Ccccメソッドを呼んだよ。";
            return View("Index");
        }

        /// <summary>
        /// エラーページ
        /// 応答キャッシュなし（特定ページのキャッシュを無効にする）
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
