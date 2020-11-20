﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ureche_iudita_lab8.Data;
using ureche_iudita_lab8.Models;

namespace ureche_iudita_lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly ureche_iudita_lab8.Data.ureche_iudita_lab8Context _context;

        public IndexModel(ureche_iudita_lab8.Data.ureche_iudita_lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
