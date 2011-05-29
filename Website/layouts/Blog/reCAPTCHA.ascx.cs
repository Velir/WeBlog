﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sitecore.Configuration;

namespace Sitecore.Modules.Blog.Layouts
{
    public partial class reCaptcha : System.Web.UI.UserControl
    {
        const string SETTING_PRIVATE_KEY = "EviBlog.reCAPTCHA.PrivateKey";
        const string SETTING_PUBLIC_KEY = "EviBlog.reCAPTCHA.PublicKey";

        protected void uxRecaptcha_Init(object sender, EventArgs e)
        {
            Recaptcha.RecaptchaControl recaptcha = sender as Recaptcha.RecaptchaControl;
            recaptcha.PublicKey = Sitecore.Configuration.Settings.GetSetting(SETTING_PUBLIC_KEY);
            recaptcha.PrivateKey = Sitecore.Configuration.Settings.GetSetting(SETTING_PRIVATE_KEY);
        }
    }
}