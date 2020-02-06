﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using handmasterjundiai.Scripts;



namespace handmasterjundiai.Pages
{
    public class TeamModel : PageModel
    {
        private readonly ILogger<TeamModel> _logger;

        public TeamModel(ILogger<TeamModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var reader = new Csv();
            
            //lines.ForEach(i => Console.WriteLine(i));
        }
    }
}
