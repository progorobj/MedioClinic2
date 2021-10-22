﻿#define no_suffix

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace MedioClinic1.Components.ViewComponents
{
    public class Footer : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() => View();
    }
}
