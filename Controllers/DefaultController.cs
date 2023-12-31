﻿using Microsoft.AspNetCore.Mvc;
using htt_test_case.Models;

namespace htt_test_case.Controllers
{
    public class DefaultController : Controller
    {
        //ссылка на контекст бд
        private readonly ApplicationContext _context;

        public DefaultController(ApplicationContext context)
        {
            _context = context;
        }

        //Объединение таблиц из БД и передача их для отображения
        public IActionResult Goods()
        {
            var goods = _context.Goods.Join(_context.Categories,
                g => g.Category_ID,
                c => c.ID,
                (g, c) => new
                {
                    Name = g.Name,
                    Category = c.Name
                });
            return View(goods.ToList());

        }
    }
}
