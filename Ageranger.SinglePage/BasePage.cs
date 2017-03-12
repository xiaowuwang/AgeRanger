using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace AgeRanger.SinglePage
{
    public class BasePage : Page
    {
        public BasePage()
        {
            StructureMapBootStrap.Configure().BuildUp(this);
        }
    }
}